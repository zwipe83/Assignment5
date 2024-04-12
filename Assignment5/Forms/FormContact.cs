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
        private Contact _contact;

        public Contact ContactData
        {
            get => _contact;
            set => _contact = value;
        }
        public FormContact() : this(new Contact())
        {
            //New _contact
        }
        public FormContact(Contact contact)
        {
            InitializeComponent();
            this._contact = contact;
        }

        private void InitializeGUI()
        {
            cmbCountry.DataSource = Enum.GetValues(typeof(Country));
            cmbCountry.SelectedIndex = (int)ContactData.AddressData.Country;
            txtFirstName.Focus();

            if(!string.IsNullOrEmpty(ContactData.FirstName))
            {
                txtFirstName.Text = ContactData.FirstName;
                txtLastName.Text = ContactData.LastName;
                txtBusinessEmail.Text = ContactData.EmailData.Work;
                txtPrivateEmail.Text = ContactData.EmailData.Personal;
                txtHomePhone.Text = ContactData.PhoneData.HomePhone;
                txtMobilePhone.Text = ContactData.PhoneData.MobilePhone;
                txtStreet.Text = ContactData.AddressData.Street;
                txtZipCode.Text = ContactData.AddressData.ZipCode;
                txtCity.Text = ContactData.AddressData.City;
                cmbCountry.SelectedIndex = (int)ContactData.AddressData.Country;
            }
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
                //FIXED: Add rest of _contact information

                if (!ContactData.CheckData())
                    return;

                ContactData.ToString(); //Debug

                DialogResult = DialogResult.OK;

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
