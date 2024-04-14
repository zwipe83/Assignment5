/// <summary>
/// Filename: Customer.cs
/// Created on: 2024-04-07 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment5.Classes
{
    public class Customer
    {
        #region Fields
        /// <summary>
        /// Private field for storing of customer contact data, of type <see cref="Contact"/>
        /// </summary>
        private Contact _contact;
        /// <summary>
        /// Private field for storing unique customer id, of type <see cref="Guid"/>
        /// </summary>
        private Guid _customerId;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting value of private field <see cref="_customerId"/>
        /// </summary>
        public Guid CustomerId
        {
            get => _customerId;
        }
        /// <summary>
        /// Property for getting value of private field <see cref="_contact"/>
        /// </summary>
        public Contact Contact
        {
            get => _contact;
        }
        /// <summary>
        /// Property for getting value of property <see cref="Contact.LastName"/>
        /// </summary>
        public string LastName
        {
            get => Contact.LastName;
        }
        /// <summary>
        /// Property for getting value of property <see cref="Contact.FirstName"/>
        /// </summary>
        public string FirstName
        {
            get => Contact.FirstName;
        }
        /// <summary>
        /// Property for getting value of property <see cref="Contact.PhoneData.MobilePhone"/>
        /// </summary>
        public string MobilePhone
        {
            get => Contact.PhoneData.MobilePhone;
        }
        /// <summary>
        /// Property for getting value of property <see cref="Contact.EmailData.Work"/>
        /// </summary>
        public string WorkEmail
        {
            get => Contact.EmailData.Work;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Base Address constructor, creates an intance of <see cref="Customer"/> with all default values
        /// </summary>
        public Customer() : this(new Contact(), Guid.NewGuid())
        {
        }
        /// <summary>
        /// Address constructor, creates an intance of <see cref="Customer"/> with a specific <see cref="Contact"/>
        /// </summary>
        /// <param name="contact"></param>
        public Customer(Contact contact) : this(contact, Guid.NewGuid())
        {
        }
        /// <summary>
        /// Address constructor, creates an intance of <see cref="Customer"/> with a specific <see cref="Contact"/> and <see cref="CustomerId"/>
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="customerId"></param>
        public Customer(Contact contact, Guid customerId)
        {
            this._contact = contact;
            this._customerId = customerId;
        }
        /// <summary>
        /// Copy Constructor, copies values from one <see cref="Customer"/> to a new instance of <see cref="Customer"/>
        /// </summary>
        /// <param name="objToCopyFrom"></param>
        public Customer(Customer objToCopyFrom)
        {
            this._contact = objToCopyFrom.Contact;
            this._customerId = objToCopyFrom.CustomerId;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        ///  Overridden method for printing Customer data to a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{CustomerId,-38}{LastName,12},{FirstName,-12}{MobilePhone,-15}{WorkEmail,-15}";
        }
        #endregion
    }
}
