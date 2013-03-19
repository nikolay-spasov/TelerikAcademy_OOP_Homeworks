using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bank.Bank
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer,
            decimal balance, decimal interestRatePerMonth)
            : base(customer, balance, interestRatePerMonth) { }

        public override decimal CalculateInterestAmount(int months)
        {
            if (Customer.CustomerType == CustomerType.Company)
            {
                if (months > 12)
                {
                    return 6 * InterestRatePerMonth + months - 12 + InterestRatePerMonth;
                }
                return 0m;
            }
            else
            {
                if (months > 6)
                {
                    return 3 * InterestRatePerMonth + months - 3 + InterestRatePerMonth;
                }
                return 0m;
            }
        }
    }
}
