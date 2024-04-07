/// <summary>
/// Filename: Contact.cs
/// Modified on: 2024-04-07 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment5.Enums;
using static Assignment5.Helpers.Debugger;

namespace Assignment5.Classes
{
    public class Address
    {
        #region Fields
        private string _street;
        private string _zipCode;
        private string _city;
        private Country _country;
        #endregion
        #region Properties
        public string Street
        {
            get => _street;
            set => _street = value;
        }
        public string ZipCode
        {
            get => _zipCode;
            set => _zipCode = value;
        }
        public string City
        {
            get => _city;
            set => _city = value;
        }
        public Country Country
        {
            get => _country;
            set => _country = value;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Base constructor, creates an intance of <see cref="Address"/> with default values
        /// </summary>
        public Address() : this(string.Empty)
        {
        }
        public Address(string street) : this(street, string.Empty)
        {
        }
        public Address(string street, string zipCode) : this(street, zipCode, string.Empty)
        {
        }
        public Address(string street, string zipCode, string city) : this(street, zipCode, city, Country.Sweden)
        {
        }
        /// <summary>
        /// Inits a new object of type <see cref="Address">
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zipCode"></param>
        /// <param name="city"></param>
        public Address(string street, string zipCode, string city, Country country)
        {
            Street = street;
            ZipCode = zipCode;
            City = city;
            Country = country;

            ToString(); //Debug purpose
        }
        #endregion
        #region Methods
        public override string ToString()
        {

            string strOut = "\n" + "Address" + "\n";
            //TODO: Rework to use interpolation?
            strOut += string.Format(" {0,-10} {1, -10}\n", "Street", Street);
            strOut += string.Format(" {0,-10} {1, -10}\n", "Zip code", ZipCode);
            strOut += string.Format(" {0,-10} {1, -10}\n", "City", City);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Country", Country);

            //DEBUG_PRINT($"Phone.ToString(): {strOut}");

            return strOut;
        }
        #endregion



    }
}
