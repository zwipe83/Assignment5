using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment5.Helpers.Debugger;

namespace Assignment5.Classes
{
    public class CustomerManager
    {
        private List<Customer> _customerList = new List<Customer>();

        public List<Customer> CustomerList
        {
            get => _customerList;
            set => _customerList = value; //TODO: Add check Index method
        }

        public void AddNew(Customer customer)
        {
            CustomerList.Add(customer);

            DEBUG_PRINT($"Customer list count: {CustomerList.Count}");
        }
    }
}
