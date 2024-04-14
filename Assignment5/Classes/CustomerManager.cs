/// <summary>
/// Filename: CustomerManager.cs
/// Created on: 2024-04-07 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment5.Interfaces;
using static Assignment5.Helpers.Debugger;

namespace Assignment5.Classes
{
    public class CustomerManager : ICustomerManager
    {
        #region Fields
        /// <summary>
        /// Private field for storing of collection of type <see cref="Customer"/>
        /// </summary>
        private List<Customer> _customerList = new List<Customer>();
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_customerList"/>
        /// </summary>
        public List<Customer> CustomerList
        {
            get => _customerList;
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Adds a new <see cref="Customer"/> to collection <see cref="CustomerList"/>
        /// </summary>
        /// <param name="contact"></param>
        public void AddCustomer(Contact contact)
        {
            try
            {
                Customer customer = new Customer(contact);
                CustomerList.Add(customer);

                DEBUG_PRINT($"Customer list count: {CustomerList.Count}");
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Changes an existing <see cref="Customer"/> in <see cref="CustomerList"/> using a specific customer id of type <see cref="Guid"/>
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="guid"></param>
        public void ChangeCustomer(Contact contact, Guid guid)
        {
            Customer customer = new Customer(contact, guid);

            int index = CustomerList.FindIndex(item => item.CustomerId == guid);

            if (index != -1)
            {
                CustomerList[index] = customer;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool CheckIndex(Guid guid)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Deletes an existing <see cref="Customer"/> in <see cref="CustomerList"/> using a specific customer id of type <see cref="Guid"/>
        /// </summary>
        /// <param name="guid"></param>
        public void DeleteCustomer(Guid guid)
        {
            int index = CustomerList.FindIndex(item => item.CustomerId == guid);

            if (index != -1)
            {
                CustomerList.RemoveAt(index);
            }
        }
        /// <summary>
        /// Parses Customer Id part of customer info string as a <see cref="Guid"/>
        /// </summary>
        /// <param name="customerInfo"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Gets a specific <see cref="Customer"/> from <see cref="CustomerList"/> using a specific customer id of type <see cref="Guid"/>
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer GetCustomer(Guid customerId)
        {
            Customer customer = CustomerList.FirstOrDefault(customer => customer.CustomerId == customerId);

            if (customer == null)
            {
                throw new InvalidOperationException($"Customer with customerId: {customerId} not found.");
            }

            Customer selectedCustomer = new Customer(customer); //Create copy

            return selectedCustomer ?? null;
        }
        public string[] GetCustomerInfoStrings()
        {
            throw new NotImplementedException(); //TODO: Implement this?
        }
        /// <summary>
        /// Gets a specific <see cref="Customer"/> address info from <see cref="CustomerList"/> using a specific customer id of type <see cref="Guid"/>
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public string GetAddressInfo(Guid customerId)
        {
            try
            {
                Customer customer = GetCustomer(customerId);

                return $"{customer.Contact.AddressData}";
            }
            catch 
            {
                throw;
            }
        }
        /// <summary>
        /// Gets a specific <see cref="Customer"/> email info from <see cref="CustomerList"/> using a specific customer id of type <see cref="Guid"/>
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public string GetEmailInfo(Guid customerId)
        {
            try 
            {
                Customer customer = GetCustomer(customerId);

                return $"{customer.Contact.EmailData}";
            }
            catch 
            {
                throw;
            }
        }
        /// <summary>
        /// Gets a specific <see cref="Customer"/> phone info from <see cref="CustomerList"/> using a specific customer id of type <see cref="Guid"/>
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public string GetPhoneInfo(Guid customerId)
        {
            try
            { 
                Customer customer = GetCustomer(customerId);

                return $"{customer.Contact.PhoneData}";
            }
            catch 
            {
                throw;
            }
        }
        #endregion
        #region Private Methods
        /// <summary>
        /// Checks to see if <see cref="Guid"/> is a valid guid
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        private (bool, Guid) CheckGuid(string guid)
        {
            Guid validGuid;
            if (Guid.TryParse(guid, out validGuid))
            {
                return (true, validGuid);
            }
            return (false, Guid.Empty);
        }
        #endregion
    }
}
