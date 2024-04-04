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
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact("sjeffman83@outlook.com");
            FormContact frmContact = new FormContact(contact);
            frmContact.ShowDialog();
        }
    }
}
