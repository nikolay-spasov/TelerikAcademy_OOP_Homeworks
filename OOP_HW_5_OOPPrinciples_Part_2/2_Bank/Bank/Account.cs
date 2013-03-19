using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bank.Bank
{
    public abstract class Account : IDepositable
    {
        private decimal interestRatePerMonth;
        
        protected Account(Customer customer,
            decimal balance, decimal interestRatePerMonth)
        {
            Customer = customer;
            Balance = balance;
            InterestRatePerMonth = interestRatePerMonth;
        }

        public decimal InterestRatePerMonth 
        {
            get { return this.interestRatePerMonth; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Interest rate per month cannot be negative.");
                }
                this.interestRatePerMonth = value;
            }
        }

        public Customer Customer { get; protected set; }

        // Note that negative balance is fine.
        public decimal Balance { get; protected set; }

        public virtual decimal CalculateInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Months cannot be negative");
            }

            return interestRatePerMonth * months * Balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Deposit amount must be positive");
            }

            Balance += amount;
        }
    }
}
