using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bank.Bank
{
    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer customer,
            decimal balance, decimal interestRatePerMonth)
            : base(customer, balance, interestRatePerMonth) { }

        public decimal Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Withdraw amount must be positive");
            }

            if (amount > Balance)
            {
                throw new InvalidOperationException(
                    "You cannot withdraw amount larger than current balance.");
            }

            Balance -= amount;
            return amount;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (Balance > 0m && Balance < 1000m)
            {
                return 0m;
            }

            return base.CalculateInterestAmount(months);
        }
    }
}
