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

        public Contact ContactData
        {
            get => contact;
            set => contact = value;
        }
        public FormContact(Contact contact)
        {
            InitializeComponent();

            this.contact = contact;
        }

        private void InitializeGUI()
        {
            cmbCountry.DataSource = Enum.GetValues(typeof(Country));
            cmbCountry.SelectedIndex = (int)ContactData.AddressData.Country;
            txtFirstName.Focus();
        }

        private void btnOkAdd_Click(object sender, EventArgs e)
        {
            ContactData.FirstName = txtFirstName.Text;
            ContactData.LastName = txtLastName.Text;
            ContactData.EmailData.Personal = txtPrivateEmail.Text;
            ContactData.EmailData.Work = txtBusinessEmail.Text;
            ContactData.PhoneData.HomePhone = txtHomePhone.Text;
            ContactData.PhoneData.MobilePhone = txtMobilePhone.Text;
            ContactData.AddressData.Street = txtStreet.Text;
            ContactData.AddressData.ZipCode = txtZipCode.Text;
            ContactData.AddressData.City = txtCity.Text;
            ContactData.AddressData.Country = (Country)cmbCountry.SelectedIndex;
            //FIXED: Add rest of contact information
            ContactData.ToString();
            this.Close();
        }

        private void FormContact_Shown(object sender, EventArgs e)
        {
            InitializeGUI();
        }
    }
}
