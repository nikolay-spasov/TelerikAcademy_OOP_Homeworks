using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bank.Bank
{
    public class Company : Customer
    {
        public string CompanyName { get; set; }

        public Company(string companyName, string ownerFirstName, string ownerLastName)
            : base(CustomerType.Company, ownerFirstName, ownerLastName)
        {
            CompanyName = companyName;
        }
    }
}
