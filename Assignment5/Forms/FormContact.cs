/// <summary>
/// Filename: FormContact.cs
/// Created on: 2024-04-02 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment5.Classes;
using Assignment5.Enums;
using static Assignment5.Helpers.EnumHelper;

namespace Assignment5.Forms
{
    public partial class FormContact : Form
    {
        #region Fields
        /// <summary>
        /// Field for storing of contact, of type <see cref="Contact"/>
        /// </summary>
        private Contact _contact;
        /// <summary>
        /// Field for storing of country, of type <see cref="Country"/>
        /// </summary>
        private readonly Country defaultCountry = Country.Sweden;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_contact"/>
        /// </summary>
        public Contact ContactData
        {
            get => _contact;
            set
            {
                if(value != null) 
                { 
                    _contact = value;
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Base FormContact constructor, creates an intance of Form <see cref="FormContact"/> with a new instance of <see cref="Contact"/>
        /// </summary>
        public FormContact() : this(new Contact())
        {
            //New _contact
        }
        /// <summary>
        /// Base FormContact constructor, creates an intance of Form <see cref="FormContact"/> with an existing instance of <see cref="Contact"/>
        /// </summary>
        /// <param name="contact"></param>
        public FormContact(Contact contact)
        {
            InitializeComponent();
            ContactData = contact;
        }
        #endregion
        #region Private Methods
        /// <summary>
        /// Does inizialition work for GUI
        /// </summary>
        private void InitializeGUI()
        {
            string[] countryDescriptions = GetCountryDescriptions();
            SetCountryDescriptions(countryDescriptions, cmbCountry);
            SetDefaults();

            if (!string.IsNullOrEmpty(ContactData.FirstName) || !string.IsNullOrEmpty(ContactData.LastName)) //Doing an edit of an existing customer
            {
                LoadContactData();
            }
        }
        /// <summary>
        /// Sets default values in controls
        /// </summary>
        private void SetDefaults()
        {
            cmbCountry.SelectedIndex = (int)defaultCountry;
            txtFirstName.Focus();
        }
        /// <summary>
        /// Gets country descriptions as <see cref="string"/> from Enum of type <see cref="Country"/>
        /// </summary>
        private string[] GetCountryDescriptions()
        {
            var countryAry = Enum.GetValues(typeof(Country));
            var countryDescriptions = new string[countryAry.Length];
            for (int i = 0; i < countryAry.Length; i++)
            {
                countryDescriptions[i] = GetDescription((Enum)countryAry.GetValue(i));
            }

            return countryDescriptions;
        }
        /// <summary>
        /// Set country descriptions to provided <see cref="ComboBox"/>
        /// </summary>
        /// <param name="countryDescriptions"></param>
        private void SetCountryDescriptions(string[] countryDescriptions, ComboBox comboBox)
        {
            comboBox.DataSource = countryDescriptions;
        }

        /// <summary>
        /// Loads contact details from <see cref="Contact"/> object copy and loads them to the corresponding controls
        /// </summary>
        private void LoadContactData()
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
        /// <summary>
        /// Handle OK click. Create new or save existing customer contact data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOkAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ContactData.AddressData.Country = (Country)cmbCountry.SelectedIndex;
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
        /// <summary>
        /// Run initzialization when from is shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormContact_Shown(object sender, EventArgs e)
        {
            InitializeGUI();
        }
        /// <summary>
        /// Handle Cancel click. Abort contact form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No) 
            {
                return; //Do nothing
            }
        }
        /// <summary>
        /// Update controls in the GUI
        /// </summary>
        private void UpdateGUI()
        {
            if (ContactData.CheckData())
            {
                btnOkAdd.Enabled = true;
            }
            else
            {
                btnOkAdd.Enabled = false;
            }
        }
        /// <summary>
        /// Save first name to local copy of <see cref="Contact"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ContactData.FirstName = txtFirstName.Text;
            UpdateGUI();
        }
        /// <summary>
        /// Save last name to local copy of <see cref="Contact"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ContactData.LastName = txtLastName.Text;
            UpdateGUI();
        }
        /// <summary>
        /// Save homephone number to local copy of <see cref="Contact"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHomePhone_TextChanged(object sender, EventArgs e)
        {
            ContactData.PhoneData.HomePhone = txtHomePhone.Text;
            UpdateGUI();
        }
        /// <summary>
        /// Save mobile phone number to local copy of <see cref="Contact"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMobilePhone_TextChanged(object sender, EventArgs e)
        {
            ContactData.PhoneData.MobilePhone = txtMobilePhone.Text;
            UpdateGUI();
        }
        /// <summary>
        /// Save work email to local copy of <see cref="Contact"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBusinessEmail_TextChanged(object sender, EventArgs e)
        {
            ContactData.EmailData.Work = txtBusinessEmail.Text;
            UpdateGUI();
        }
        /// <summary>
        /// Save private email to local copy of <see cref="Contact"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrivateEmail_TextChanged(object sender, EventArgs e)
        {
            ContactData.EmailData.Personal = txtPrivateEmail.Text;
            UpdateGUI();
        }
        /// <summary>
        /// Save street address to local copy of <see cref="Contact"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            ContactData.AddressData.Street = txtStreet.Text;
            UpdateGUI();
        }
        /// <summary>
        /// Save zip code to local copy of <see cref="Contact"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {
            ContactData.AddressData.ZipCode = txtZipCode.Text;
            UpdateGUI();
        }
        /// <summary>
        /// Save city to local copy of <see cref="Contact"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            ContactData.AddressData.City = txtCity.Text;
            UpdateGUI();
        }
        /// <summary>
        /// Save country to local copy of <see cref="Contact"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }
        #endregion
    }
}
