/// <summary>
/// Filename: Contact.cs
/// Created on: 2024-04-02 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using static Assignment5.Helpers.EmailChecker;
using static Assignment5.Helpers.Debugger;
using System.Security.Policy;

namespace Assignment5.Classes
{
    public class EmailAddress
    {
        private string? _address;
        public string? Address 
        { 
            get => _address; 
            set
            {
                if(IsValidAddress(value))
                {
                    _address = value;
                    DEBUG_PRINT($"EmailAddress.Address - Correct address: {value}");
                }
                else
                {
                    //TODO: Throw exception?
                    DEBUG_PRINT($"EmailAddress.Address - Incorrect address: {value}");
                }
            }
        }

        public EmailAddress() 
        { 
        
        }

        public EmailAddress(string email) 
        { 
            Address = email;
        }
    }
    public class PhoneNumber
    {
        public PhoneNumber() { }
    }
    public class Address
    {
        public Address() { }
    }

    public class Name
    {
        private string? _name;
        private bool _isLastName = false;

        public bool IsLastName
        {
            get => _isLastName;
            set => _isLastName = value;
        }

        public string? NameProp
        {
            get => _name;
            set => _name = value; 
        }
        public Name() 
        { 
            
        }
    }

    public class Contact
    {
        private EmailAddress? _businessEmail = new EmailAddress();
        private EmailAddress? _privateEmail = new();
        private PhoneNumber? _homePhone = new();
        private PhoneNumber? _mobilePhone = new();
        private Address? _address = new();
        private Name? _firstName = new();
        private Name? _lastName = new();

        public EmailAddress? BusinessEmail
        {
            get => _businessEmail;
            set => _businessEmail = value;
        }
        public EmailAddress? PrivateEmail
        {
            get => _privateEmail;
            set => _privateEmail = value;
        }
        public PhoneNumber? HomePhone
        {
            get => _homePhone;
            set => _homePhone = value;
        }
        public PhoneNumber? MobilePhone
        {
            get => _mobilePhone;
            set => _mobilePhone = value;
        }
        public Address? Address
        {
            get => _address;
            set => _address = value;
        }
        public Name? FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        public Name? LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                if (_lastName is not null)
                {
                    _lastName.IsLastName = true;
                }
            }
        }

        public Contact()
        {
        }
        public Contact(string firstName) : this(firstName, string.Empty)
        {
            FirstName.NameProp = firstName;
        }
        public Contact(string firstName, string lastName) : this(firstName, lastName, string.Empty)
        {
        }
        public Contact(string firstName, string lastName, string businessEmail) : this(firstName, lastName, businessEmail, )
        {
        }

    }
}
