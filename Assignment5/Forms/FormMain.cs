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
        private CustomerManager _customerManager = new CustomerManager();
        public CustomerManager CustomerManager
        {
            get => _customerManager;
            set => _customerManager = value;
        }
        public FormMain()
        {
            InitializeComponent();
        }

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

        private void UpdateCustomerList()
        {
            lstCustomers.Items.Clear();
            foreach (Customer customer in CustomerManager.CustomerList)
            {
                lstCustomers.Items.Add(customer.ToString());
            }
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            //Get Guid here
            Contact contact = new Contact(new Contact()); //TODO: Obviously replace this with a _contact from the list
            FormContact frmContact = new FormContact(contact);
            frmContact.ShowDialog();

            if (frmContact.DialogResult == DialogResult.OK)
            {
                CustomerManager.ChangeCustomer(frmContact.ContactData, Guid.NewGuid()); //TODO: Fix this, should NOT be NewGuid...
            }
        }

        private void lstCustomers_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = CustomerManager.GetCustomer(lstCustomers.SelectedItem.ToString());

            lblContactAddress.Text = $"{selectedCustomer.Contact.FirstName},{selectedCustomer.Contact.LastName}\n{selectedCustomer.Contact.AddressData.ToString()}";
        }
    }
}
