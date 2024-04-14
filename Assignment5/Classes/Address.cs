/// <summary>
/// Filename: Address.cs
/// Created on: 2024-04-07 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment5.Enums;
using static Assignment5.Helpers.EnumHelper;

namespace Assignment5.Classes
{
    public class Address
    {
        #region Fields
        /// <summary>
        /// Field for storing of street name, of type <see cref="string"/>
        /// </summary>
        private string _street;
        /// <summary>
        /// Field for stroing of zip code, of type <see cref="string"/>
        /// </summary>
        private string _zipCode;
        /// <summary>
        /// Field for storing of city name, of type <see cref="string"/>
        /// </summary>
        private string _city;
        /// <summary>
        /// Field for storing of country name, of type <see cref="Assignment5.Enums.Country"/>
        /// </summary>
        private Country _country;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_street"/>
        /// </summary>
        public string Street
        {
            get => _street;
            set => _street = value; //TODO: Add validity checker?
        }
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_zipCode"/>
        /// </summary>
        public string ZipCode
        {
            get => _zipCode;
            set => _zipCode = value; //TODO: Add validity checker?
        }
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_city"/>
        /// </summary>
        public string City
        {
            get => _city;
            set => _city = value; //TODO: Add validity checker?
        }
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_country"/>
        /// </summary>
        public Country Country
        {
            get => _country;
            set => _country = value; //TODO: Add validity checker?
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Base Address constructor, creates an intance of <see cref="Address"/> with all default values
        /// </summary>
        public Address() : this(string.Empty)
        {
        }
        /// <summary>
        /// Address constructor, creates an intance of <see cref="Address"/> with a specific <see cref="Street"/> name
        /// </summary>
        /// <param name="street"></param>
        public Address(string street) : this(street, string.Empty)
        {
        }
        /// <summary>
        /// Address constructor, creates an intance of <see cref="Address"/> with a specific <see cref="Street"/> name and <see cref="ZipCode"/>
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zipCode"></param>
        public Address(string street, string zipCode) : this(street, zipCode, string.Empty)
        {
        }
        /// <summary>
        /// Address constructor, creates an intance of <see cref="Address"/> with a specific <see cref="Street"/> name, <see cref="ZipCode"/> and <see cref="City"/>
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zipCode"></param>
        /// <param name="city"></param>
        public Address(string street, string zipCode, string city) : this(street, zipCode, city, Country.Sweden)
        {
        }
        /// <summary>
        /// Address constructor, creates an intance of <see cref="Address"/> with a specific <see cref="Street"/> name, <see cref="ZipCode"/>, <see cref="City"/> and <see cref="Country"/>
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zipCode"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        public Address(string street, string zipCode, string city, Country country)
        {
            Street = street;
            ZipCode = zipCode;
            City = city;
            Country = country;

            ToString(); //Debug purpose
        }
        /// <summary>
        /// Copy Constructor, copies values from one <see cref="Address"/> to a new instance of <see cref="Address"/>
        /// </summary>
        /// <param name="objToCopyFrom"></param>
        public Address(Address objToCopyFrom)
        {
            this.Street = objToCopyFrom.Street;
            this.ZipCode = objToCopyFrom.ZipCode;
            this.City = objToCopyFrom.City;
            this.Country = objToCopyFrom.Country;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// Overridden method for printing Address data to a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = $"\nAddress\n";
            strOut += $"{" Street",-10} {Street,-10}\n";
            strOut += $"{" Zip code",-10} {ZipCode,-10}\n";
            strOut += $"{" City",-10} {City,-10}\n";
            strOut += $"{" Country",-10} {GetDescription(Country),-10}\n\n";

            return strOut;
        }
        #endregion
    }
}
