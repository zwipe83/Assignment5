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
        private Contact contact;
        private Guid id;
        #endregion
        #region Properties
        #endregion
        #region Constructors
        public Customer(Contact contact) : this(contact, Guid.NewGuid())
        {
        }
        public Customer(Contact contact, Guid guid)
        {
            this.contact = contact;
            this.id = guid;
        }
        #endregion
        #region Methods
        #endregion
    }
}
