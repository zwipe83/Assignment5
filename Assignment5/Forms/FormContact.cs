/// <summary>
/// Filename: FormContact.cs
/// Created on: 2024-04-02 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment5.Classes;
using Assignment5.Enums;

namespace Assignment5.Forms
{
    public partial class FormContact : Form
    {
        private Contact contact;
        public FormContact(Contact contact)
        {
            InitializeComponent();

            this.contact = contact;

            InitializeGUI();
        }

        private void InitializeGUI()
        {
            cmbCountry.DataSource = Enum.GetValues(typeof(Country));
        }
    }
}
