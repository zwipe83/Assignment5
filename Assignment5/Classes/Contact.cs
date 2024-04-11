/// <summary>
/// Filename: Contact.cs
/// Created on: 2024-04-02 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using static Assignment5.Helpers.Debugger;
using Assignment5.Enums;

namespace Assignment5.Classes
{
    public class Contact
    {
        #region Fields
        private Email? email;
        private Phone? phone;
        private Address? address;

        private string _firstName;
        private string _lastName;
        #endregion
        #region Properties
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public Address AddressData
        {
            get => address;
            set => address = value;
        }

        public Email EmailData
        {
            get => email;
            set => email = value;
        }

        public Phone PhoneData
        {
            get => phone;
            set => phone = value;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Base constructor, creates an intance of <see cref="Contact"/> with default values
        /// </summary>
        public Contact() : this(string.Empty, string.Empty, new Address(), new Phone(), new Email())
        {
        }
        /// <summary>
        /// Inits a new object of type <see cref="Contact">
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
        /// <exception cref="NotImplementedException"></exception>
        public Contact(Contact objToCopyFrom)
        {
            this.FirstName = objToCopyFrom.FirstName;
            this.LastName = objToCopyFrom.LastName;
            this.AddressData = objToCopyFrom.AddressData;
            this.PhoneData = objToCopyFrom.PhoneData;
            this.EmailData = objToCopyFrom.EmailData;
        }
        #endregion
        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            bool ok = (!string.IsNullOrWhiteSpace(FirstName) || !string.IsNullOrWhiteSpace(LastName))
                && !string.IsNullOrWhiteSpace(AddressData.City)
                && Enum.IsDefined(typeof(Country), (int)AddressData.Country); //Probably not entirely necessary

            DEBUG_PRINT($"CheckData() OK: {ok}");

            return ok;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private string GetAddressInfo()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
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
