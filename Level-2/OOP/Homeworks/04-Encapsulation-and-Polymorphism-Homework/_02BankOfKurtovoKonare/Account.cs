using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare
{
    public abstract class Account : IAccount, IDepositable
    {
        private ICustomer customer;
        private decimal balance;
        private decimal monthlyInterestRate;
        public Account(ICustomer customer, decimal balance, decimal monthlyInterestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
        }
        public ICustomer Customer
        {
            get { return this.customer; }
            set
            {
                ValidationMethods.CheckIfCustomerIsNull(value);
                this.customer = value;
            }
        }
        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                ValidationMethods.CheckIfNumIsNegative("Account Balance", value);
                this.balance = value;
            }
        }
        public decimal MonthlyInterestRate
        {
            get { return this.monthlyInterestRate; }
            set
            {
                ValidationMethods.CheckIfNumIsNegative("Monthly Interest Rate", value);
                this.monthlyInterestRate = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Account Holder:\n{0}\nBalance: {1:0.00#}\nMonthly Interest Rate: {2}%",
                this.Customer, this.Balance, this.MonthlyInterestRate);
        }

        public void Deposit(decimal deposit)
        {
            ValidationMethods.CheckIfNumIsNegativeOrZero("Deposit", deposit);
            this.Balance += deposit;
        }

        public virtual decimal CalculateInterest(int periodInMonths)
        {
            ValidationMethods.CheckIfNumIsNegative("Period in Months for interest calculation", periodInMonths);
            /*
             *According to the formula in the problem description, it seems to me that this method should 
             *return not only the interest for the period, but the INTEREST + CURRENT BALANCE.
             *If only the interest is needed. the formula should be:
             *this.Balance * ((this.MonthlyInterestRate / 100) * periodInMonths)
             */
            decimal interestForPeriod = this.Balance * (1 + (this.MonthlyInterestRate / 100) * periodInMonths);
            return interestForPeriod;
        }
    }
}
