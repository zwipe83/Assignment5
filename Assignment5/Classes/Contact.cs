/// <summary>
/// Filename: Contact.cs
/// Created on: 2024-04-02 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment5.Enums;
using static Assignment5.Helpers.Debugger;

namespace Assignment5.Classes
{
    public class Contact
    {
        #region Fields
        /// <summary>
        /// Private field for the storing of an instance of object <see cref="Email"/>
        /// </summary>
        private Email? _email;
        /// <summary>
        /// Private field for the storing of an instance of object <see cref="Phone"/>
        /// </summary>
        private Phone? _phone;
        /// <summary>
        /// Private field for the storing of an instance of object <see cref="Address"/>
        /// </summary>
        private Address? _address;
        /// <summary>
        /// Private field for the storing of first name as a <see cref="string"/>
        /// </summary>
        private string _firstName;
        /// <summary>
        /// Private field for the storing of last name as a <see cref="string"/>
        /// </summary>
        private string _lastName;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_firstName"/>
        /// </summary>
        public string FirstName
        {
            get => _firstName ?? string.Empty;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _firstName = value;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(LastName))
                    {
                        //throw new ArgumentException("Both first and last name cannot be empty or null.");
                    }
                }
            }
        }
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_lastName"/>
        /// </summary>
        public string LastName
        {
            get => _lastName ?? string.Empty;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _lastName = value;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(FirstName))
                    {
                        //throw new ArgumentException("Both last and first name cannot be empty or null.");
                    }
                }
            }
        }
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_address"/>
        /// </summary>
        public Address AddressData
        {
            get => _address ?? new Address();
            set {
                if (value != null)
                { 
                    _address = value;
                }
            }
        }
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_email"/>
        /// </summary>
        public Email EmailData
        {
            get => _email ?? new Email();
            set 
            { 
                if(value != null)
                {
                    _email = value;
                }
            }
        }
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_phone"/>
        /// </summary>
        public Phone PhoneData
        {
            get => _phone ?? new Phone();
            set
            {
                if(value != null)
                {
                    _phone = value;
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Base Contact constructor, creates an intance of <see cref="Contact"/> with all default values
        /// </summary>
        public Contact() : this(string.Empty, string.Empty, new Address(), new Phone(), new Email())
        {
        }
        /// <summary>
        /// Contact constructor, creates an intance of <see cref="Address"/> with a specific <see cref="FirstName"/>, <see cref="LastName"/>, <see cref="AddressData"/>, <see cref="PhoneData"/> and <see cref="EmailData"/>
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public Contact(string firstName, string lastName, Address address, Phone phone, Email email)
        {
            FirstName = firstName;
            LastName = lastName;
            AddressData = address;
            PhoneData = phone;
            EmailData = email;
        }
        /// <summary>
        /// Copy Constructor, copies values from one <see cref="Contact"/> to a new instance of <see cref="Contact"/>
        /// </summary>
        /// <param name="objToCopyFrom"></param>
        public Contact(Contact objToCopyFrom)
        {
            this.FirstName = objToCopyFrom.FirstName ?? string.Empty;
            this.LastName = objToCopyFrom.LastName ?? string.Empty;
            this.AddressData = objToCopyFrom.AddressData ?? new Address();
            this.PhoneData = objToCopyFrom.PhoneData ?? new Phone();
            this.EmailData = objToCopyFrom.EmailData ?? new Email();
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Checks data to see if a minimum fulfilled
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            bool ok = (!string.IsNullOrWhiteSpace(FirstName) || !string.IsNullOrWhiteSpace(LastName))
                && !string.IsNullOrWhiteSpace(AddressData.City)
                && Enum.IsDefined(typeof(Country), (int)AddressData.Country);

            DEBUG_PRINT($"CheckData() OK: {ok}");

            return ok;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// Overridden ToString() method to return contact information for the current customer.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string contactData = $"First name: {FirstName}, last name: {LastName} {AddressData} {EmailData} {PhoneData}";

            DEBUG_PRINT($"Contact.ToString(): {contactData}");

            return contactData;
        }
        #endregion
    }
}
