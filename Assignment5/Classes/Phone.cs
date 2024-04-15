/// <summary>
/// Filename: Phone.cs
/// Created on: 2024-04-07 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment5.Classes
{
    public class Phone
    {
        #region Fields
        /// <summary>
        /// Private field for storing of home phone number, of type <see cref="string"/>
        /// </summary>
        private string _homePhone;
        /// <summary>
        /// Private field for storing of mobile phone number, of type <see cref="string"/>
        /// </summary>
        private string _mobilePhone;
        #endregion
        #region Properties
        /// <summary>
        ///  Property for getting and setting value to private field <see cref="_homePhone"/>
        /// </summary>
        public string HomePhone
        {
            get => _homePhone;
            set
            { 
                if(value != null)
                {
                    _homePhone = value;
                }
            }
        }
        /// <summary>
        ///  Property for getting and setting value to private field <see cref="_mobilePhone"/>
        /// </summary>
        public string MobilePhone
        {
            get => _mobilePhone;
            set 
            { 
                if(value != null)
                {
                    _mobilePhone = value;
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Base Phone constructor, creates an intance of <see cref="Phone"/> with all default values
        /// </summary>
        public Phone() : this(string.Empty, string.Empty)
        {
        }
        /// <summary>
        /// Phone constructor, creates an intance of <see cref="Address"/> with a specific <see cref="HomePhone"/> and <see cref="MobilePhone"/>
        /// </summary>
        /// <param name="homePhone"></param>
        /// <param name="mobilePhone"></param>
        public Phone(string homePhone, string mobilePhone)
        {
            HomePhone = homePhone;
            MobilePhone = mobilePhone;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// Overridden method for printing Phone data to a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = $"\nPhone Numbers\n";

            strOut += $"{"Home",-10} {HomePhone,-10}\n";
            strOut += $"{"Mobile",-10} {MobilePhone,-10}\n\n";

            return strOut;
        }
        #endregion
    }
}
