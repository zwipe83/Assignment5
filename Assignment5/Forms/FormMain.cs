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
        /// Field for storing of customer manager, of type <see cref="CustomerManager"/>
        /// </summary>
        private CustomerManager _customerManager = new CustomerManager();
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting value from private field <see cref="_customerManager"/>
        /// </summary>
        public CustomerManager CustomerManager
        {
            get => _customerManager;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Constructor creates instance of <see cref="FormMain"/>
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }
        #endregion
        #region Destructors
        /// <summary>
        /// Destructor for <see cref="FormMain"/>
        /// </summary>
        ~FormMain()
        {
        }
        #endregion
        #region Private Methods
        /// <summary>
        /// Perform initialization tasks for GUI on startup
        /// </summary>
        private void InitializeGUI()
        {
            UpdateButtons(false);
        }
        /// <summary>
        /// Handle adding a new contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            try
            {
                FormContact frmContact = new FormContact();
                frmContact.ShowDialog();

                if (frmContact.DialogResult == DialogResult.OK)
                {
                    CustomerManager.AddCustomer(frmContact.ContactData);
                    UpdateCustomerList();
                    UpdateContactDetails(true);
                }
                else
                {
                    //Nothing for now...
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /// <summary>
        /// Update customer listbox
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
        /// Edit an existing customer after selecting one in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditContact_Click(object sender, EventArgs e)
        {
            try
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
                    UpdateContactDetails(true);
                }
                else
                {
                    //Nothing for now...
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Handle event when clicking on an existing customer in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCustomers_Click(object sender, EventArgs e)
        {
            try
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
                UpdateContactDetails(customerId, selectedCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /// <summary>
        /// Update Contact info group box
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="selectedCustomer"></param>
        private void UpdateContactDetails(Guid customerId, Customer selectedCustomer)
        {
            grpContactDetails.Text = $"Contact Details - {selectedCustomer.Contact.LastName.ToUpper()},{selectedCustomer.Contact.FirstName}";
            lblContactAddress.Text = $"{CustomerManager.GetAddressInfo(customerId)}";
            lblContactEmails.Text = $"{CustomerManager.GetEmailInfo(customerId)}";
            lblContactPhoneNumbers.Text = $"{CustomerManager.GetPhoneInfo(customerId)}";
        }
        /// <summary>
        /// Clear contact details
        /// </summary>
        /// <param name="clear"></param>
        private void UpdateContactDetails(bool clear)
        {
            if (clear)
            {
                grpContactDetails.Text = $"Contact Details";
                lblContactAddress.Text = $"Address";
                lblContactEmails.Text = $"Emails";
                lblContactPhoneNumbers.Text = $"Phone numbers";
            }
            else
            {
                //Nothing for now...
            }
        }
        /// <summary>
        /// Handle double click event, open form for editing existing user.
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
        /// Update state of buttons
        /// </summary>
        /// <param name="setting"></param>
        private void UpdateButtons(bool setting)
        {
            btnEditContact.Enabled = setting;
            btnDeleteContact.Enabled = setting;
        }
        /// <summary>
        /// Handle index change on listbox
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
        /// Handle click on delete button to delete an existing customer
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
            UpdateContactDetails(true);
        }
        #endregion
    }
}
