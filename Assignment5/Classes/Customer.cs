using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Classes
{
    public class Customer
    {
        #region Fields
        private Contact _contact;
        private Guid _customerId;
        #endregion
        #region Properties
        public Guid CustomerId
        {
            get => _customerId;
        }
        public Contact Contact
        {
            get => _contact;
        }
        public string LastName
        {
            get => Contact.LastName;
        }
        public string FirstName
        {
            get => Contact.FirstName;
        }
        public string MobilePhone
        {
            get => Contact.PhoneData.MobilePhone;
        }
        public string WorkEmail
        {
            get => Contact.EmailData.Work;
        }
        #endregion
        #region Constructors
        public Customer() : this(new Contact(), Guid.NewGuid())
        {
        }
        public Customer(Contact contact) : this(contact, Guid.NewGuid())
        {
        }
        public Customer(Contact contact, Guid customerId)
        {
            this._contact = contact;
            this._customerId = customerId;
        }

        public Customer(Customer customer)
        {
            this._contact = customer._contact;
            this._customerId = customer._customerId;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{CustomerId}           {LastName},{FirstName} {MobilePhone} {WorkEmail}";
        }
        #endregion
    }
}
