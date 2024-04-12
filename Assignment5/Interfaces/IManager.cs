using Assignment5.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Interfaces
{
    internal interface ICustomerManager
    {
        public void AddCustomer(Contact contact);
        public void ChangeCustomer(Contact contact, Guid customerId);
        public bool CheckIndex(Guid customerId);
        public void DeleteCustomer(Guid customerId);
        public Customer GetCustomer(Guid customerId);
        public string[] GetCustomerInfoStrings();
        public string GetAddressInfo(Guid customerId);
        public string GetEmailInfo(Guid customerId);
        public string GetPhoneInfo(Guid customerId);
        public void TestValues();
    }
}
