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
            try
            {

                ContactData.FirstName = txtFirstName.Text;
                ContactData.LastName = txtLastName.Text;
                ContactData.EmailData.Work = txtBusinessEmail.Text;
                ContactData.EmailData.Personal = txtPrivateEmail.Text;
                ContactData.PhoneData.HomePhone = txtHomePhone.Text;
                ContactData.PhoneData.MobilePhone = txtMobilePhone.Text;
                ContactData.AddressData.Street = txtStreet.Text;
                ContactData.AddressData.ZipCode = txtZipCode.Text;
                ContactData.AddressData.City = txtCity.Text;
                ContactData.AddressData.Country = (Country)cmbCountry.SelectedIndex;
                //FIXED: Add rest of contact information

                if (!ContactData.CheckData())
                    return;

                ContactData.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormContact_Shown(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            //TODO: Maybe ad a spcific position for the confirmation dialog?
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
