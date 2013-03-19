using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bank.Bank
{
    public abstract class Customer
    {
        public CustomerType CustomerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected Customer(CustomerType customerType, string firstName, string lastName)
        {
            CustomerType = customerType;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
