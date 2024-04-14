/// <summary>
/// Filename: FormMain.cs
/// Created on: 2024-04-02 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment5.Classes;

namespace Assignment5.Forms
{
    public partial class FormMain : Form
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private CustomerManager _customerManager = new CustomerManager();
        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public CustomerManager CustomerManager
        {
            get => _customerManager;
            set => _customerManager = value;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }
        #endregion
        #region Destructors
        /// <summary>
        /// 
        /// </summary>
        ~FormMain()
        {
        }
        #endregion
        #region Private Methods
        /// <summary>
        /// 
        /// </summary>
        private void InitializeGUI()
        {

            UpdateButtons(false);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            FormContact frmContact = new FormContact();
            frmContact.ShowDialog();

            if (frmContact.DialogResult == DialogResult.OK)
            {
                CustomerManager.AddCustomer(frmContact.ContactData);
                UpdateCustomerList();
            }
            else
            {
                //Nothing for now...
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpdateCustomerList()
        {
            lstCustomers.Items.Clear();
            foreach (Customer customer in CustomerManager.CustomerList)
            {
                lstCustomers.Items.Add(customer.ToString());
                //lstViewCustomers.Items.Add(customer.ToString());
                //lstViewCustomers.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                //listView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditContact_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItems.Count <= 0)
            {
                MessageBox.Show($"There is no customer to edit.");
                return;
            }
            string customer = lstCustomers.SelectedItem.ToString();
            if (string.IsNullOrEmpty(customer))
            {
                MessageBox.Show($"There is no customer to edit.");
                return;
            }
            Guid customerId = CustomerManager.ParseCustomerInfoAsGuid(customer);
            Customer editCustomer = new Customer(CustomerManager.GetCustomer(customerId));
            Contact contact = new Contact(editCustomer.Contact);
            FormContact frmContact = new FormContact(contact);
            frmContact.ShowDialog();

            if (frmContact.DialogResult == DialogResult.OK)
            {
                CustomerManager.ChangeCustomer(frmContact.ContactData, editCustomer.CustomerId);
                UpdateCustomerList();
            }
            else
            {
                //Nothing for now...
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCustomers_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItems.Count <= 0)
            {
                return;
            }
            string customer = lstCustomers.SelectedItem.ToString();
            if (string.IsNullOrEmpty(customer))
            {
                return;
            }
            Guid customerId = CustomerManager.ParseCustomerInfoAsGuid(customer);
            Customer selectedCustomer = CustomerManager.GetCustomer(customerId);

            grpContactDetails.Text = $"Contact Details - {selectedCustomer.Contact.LastName.ToUpper()},{selectedCustomer.Contact.FirstName}";
            lblContactAddress.Text = $"{CustomerManager.GetAddressInfo(customerId)}";
            lblContactEmails.Text = $"{CustomerManager.GetEmailInfo(customerId)}";
            lblContactPhoneNumbers.Text = $"{CustomerManager.GetPhoneInfo(customerId)}";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCustomers_DoubleClick(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItems.Count <= 0)
            {
                return;
            }
            btnEditContact_Click(sender, e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="setting"></param>
        private void UpdateButtons(bool setting)
        {
            btnEditContact.Enabled = setting;
            btnDeleteContact.Enabled = setting;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomers.Items.Count > 0 && lstCustomers.SelectedIndex >= 0)
            {
                UpdateButtons(true);
            }
            else
            {
                UpdateButtons(false);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItems.Count <= 0)
            {
                MessageBox.Show($"There is no customer to delete.");
                return; //Nothing to delete
            }
            string? customer = lstCustomers.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(customer))
            {
                MessageBox.Show($"There is no customer to delete.");
                return; //Again, nothing to delete
            }
            Guid customerId = CustomerManager.ParseCustomerInfoAsGuid(customer);
            CustomerManager.DeleteCustomer(customerId);
            UpdateCustomerList();
            GC.Collect(); //TODO: Not needed, just trying it out
        }
        #endregion
    }
}
