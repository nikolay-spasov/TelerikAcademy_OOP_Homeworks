using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bank.Bank
{
    public class Individual : Customer
    {
        public Individual(string firstName, string lastName)
            : base(CustomerType.Individual, firstName, lastName) { }
    }
}
