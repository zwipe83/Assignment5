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
            Customer customer = new Customer(contact, guid);

            int index = CustomerList.FindIndex(item => item.CustomerId == guid);

            if (index != -1)
            {
                CustomerList[index] = customer;
            }
        }
        public bool CheckIndex(Guid guid)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Guid guid)
        {
            int index = CustomerList.FindIndex(item => item.CustomerId == guid);

            if (index != -1)
            {
                CustomerList.RemoveAt(index);
            }
        }

        public (bool, Guid) CheckGuid(string guid)
        {
            Guid validGuid;
            if (Guid.TryParse(guid, out validGuid))
            {
                return (true, validGuid);
            }
            return (false, Guid.Empty);
        }

        public Guid ParseCustomerInfoAsGuid(string customerInfo)
        {
            // Extract the GUID from the customer information string
            string customerIdString = customerInfo.Split(' ')[0].Trim();

            (bool isValid, Guid validGuid) = CheckGuid(customerIdString);

            if (isValid)
            {
                return validGuid;
            }
            return Guid.Empty;
        }

        public Customer GetCustomer(Guid customerId)
        {
            // Find the customer with the matching GUID in the CustomerManager.CustomerList
            Customer selectedCustomer = new Customer(CustomerList.FirstOrDefault(customer => customer.CustomerId == customerId));

            return selectedCustomer ?? null;
        }

        public string[] GetCustomerInfoStrings()
        {
            throw new NotImplementedException();
        }
        public string GetAddressInfo(Guid customerId)
        {
            Customer customer = GetCustomer(customerId);

            return $"{customer.Contact.AddressData}";
        }

        public string GetEmailInfo(Guid customerId)
        {
            Customer customer = GetCustomer(customerId);

            return $"{customer.Contact.EmailData}";
        }

        public string GetPhoneInfo(Guid customerId)
        {
            Customer customer = GetCustomer(customerId);

            return $"{customer.Contact.PhoneData}";
        }

        public void TestValues()
        {
            throw new NotImplementedException();
        }
    }
}
