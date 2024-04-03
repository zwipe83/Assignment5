namespace Assignment5.Classes
{
    public class Email
    {
        public Email() { }
    }
    public class Phone
    {
        public Phone() { }
    }
    public class Address
    {
        public Address() { }
    }

    public class Name
    {
        public Name() { }
    }

    public class Contact
    {
        private Email businessEmail;
        private Email privateEmail;
        private Phone homePhone;
        private Phone mobilePhone;
        private Address address;
        private Name firstName;
        private Name lastName;

        public Contact()
        {
            businessEmail = new Email();
            privateEmail = new Email();
            homePhone = new Phone();
            mobilePhone = new Phone();
            address = new Address();
            firstName = new Name();
            lastName = new Name();
        }
    }
}
