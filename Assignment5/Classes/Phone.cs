/// <summary>
/// Filename: Contact.cs
/// Created on: 2024-04-07 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using static Assignment5.Helpers.Debugger;

namespace Assignment5.Classes
{
    public class Phone
    {
        #region Fields
        private string _homePhone;
        private string _mobilePhone;
        #endregion
        #region Properties
        public string HomePhone
        {
            get => _homePhone;
            set => _homePhone = value; //TODO: Check correct format?
        }
        public string MobilePhone
        {
            get => _mobilePhone;
            set => _mobilePhone = value; //TODO: Check correct format?
        }
        #endregion
        #region Constructors
        public Phone() : this(string.Empty, string.Empty)
        {
        }
        public Phone(string homePhone, string mobilePhone)
        {
            HomePhone = homePhone;
            MobilePhone = mobilePhone;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            string phoneData = $"Home phone: {HomePhone}, Mobile phone: {MobilePhone}";

            DEBUG_PRINT($"Phone.ToString(): {phoneData}");

            return phoneData;
        }
        #endregion
    }
}
