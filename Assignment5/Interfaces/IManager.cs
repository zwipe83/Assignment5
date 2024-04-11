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
        public void ChangeCustomer(Contact contact, Guid guid);
        public bool CheckIndex(Guid guid);
        public void Remove(Guid guid);
        public void DeleteCustomer(Guid guid);
        public void GetAddressInfo(Guid guid);
        public Customer GetCustomer(string customerInfo);
        public string[] GetCustomerInfoStrings();
        public string GetEmailInfo();
        public string GetPhoneInfo();
        public void TestValues();
    }
}
