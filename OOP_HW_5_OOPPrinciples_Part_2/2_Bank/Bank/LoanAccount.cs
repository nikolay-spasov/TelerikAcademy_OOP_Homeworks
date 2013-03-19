using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bank.Bank
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer,
            decimal balance, decimal interestRatePerMonth)
            : base(customer, balance, interestRatePerMonth) { }

        public override decimal CalculateInterestAmount(int months)
        {
            if (Customer.CustomerType == CustomerType.Company && months - 2 >= 0)
            {
                return base.CalculateInterestAmount(months - 2);
            }
            else if (Customer.CustomerType == CustomerType.Individual && months - 3 >= 0)
            {
                return base.CalculateInterestAmount(months - 3);
            }

            return 0m;
        }
    }
}
