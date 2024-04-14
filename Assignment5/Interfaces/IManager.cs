/// <summary>
/// Filename: IManager.cs
/// Created on: 2024-04-11 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment5.Classes;

namespace Assignment5.Interfaces
{
    internal interface ICustomerManager
    {
        #region Public Methods
        public void AddCustomer(Contact contact);
        public void ChangeCustomer(Contact contact, Guid customerId);
        public bool CheckIndex(Guid customerId);
        public void DeleteCustomer(Guid customerId);
        public Customer GetCustomer(Guid customerId);
        public string[] GetCustomerInfoStrings();
        public string GetAddressInfo(Guid customerId);
        public string GetEmailInfo(Guid customerId);
        public string GetPhoneInfo(Guid customerId);
        #endregion
    }
}
