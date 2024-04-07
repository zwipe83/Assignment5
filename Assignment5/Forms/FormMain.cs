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
        private CustomerManager customerManager = new CustomerManager();
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            FormAddContact frmAddContact = new FormAddContact(contact, customerManager);
            frmAddContact.ShowDialog();
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            FormEditContact frmEditContact = new FormEditContact(contact, customerManager);
            frmEditContact.ShowDialog();
        }
    }
}
