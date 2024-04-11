using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment5.Helpers.Debugger;
using Assignment5.Interfaces;

namespace Assignment5.Classes
{
    public class CustomerManager : ICustomerManager
    {
        private List<Customer> _customerList = new List<Customer>();

        public List<Customer> CustomerList
        {
            get => _customerList;
            set => _customerList = value; //TODO: Add check Index method
        }

        public void AddCustomer(Contact contact)
        {
            Customer customer = new Customer(contact);
            CustomerList.Add(customer);

            DEBUG_PRINT($"Customer list count: {CustomerList.Count}");
        }

        public void ChangeCustomer(Contact contact, Guid guid)
        {
            throw new NotImplementedException();
        }

        public bool CheckIndex(Guid guid)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Guid guid)
        {
            throw new NotImplementedException();
        }

        public void GetAddressInfo(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(string customerInfo)
        {
            // Extract the GUID from the customer information string
            string customerIdString = customerInfo.Split(' ')[0].Trim();

            // Find the customer with the matching GUID in the CustomerManager.CustomerList
            Customer selectedCustomer = new Customer(CustomerList.FirstOrDefault(customer => customer.CustomerId.ToString() == customerIdString));

            return selectedCustomer;
        }

        public string[] GetCustomerInfoStrings()
        {
            throw new NotImplementedException();
        }

        public string GetEmailInfo()
        {
            throw new NotImplementedException();
        }

        public string GetPhoneInfo()
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid guid)
        {
            throw new NotImplementedException();
        }

        public void TestValues()
        {
            throw new NotImplementedException();
        }
    }
}
