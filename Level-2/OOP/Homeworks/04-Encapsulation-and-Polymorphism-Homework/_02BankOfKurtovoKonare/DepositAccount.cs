using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare
{
    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public void Withdraw(decimal amount)
        {
            ValidationMethods.CheckIfNumIsNegative("Withdraw Amount", amount);
            if (amount > this.Balance)
            {
                throw new ArgumentOutOfRangeException(
                    "This ammount cannot be withdrawn due to insufficient funds in the account!");
            }
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int periodInMonths)
        {

            //I've made it so that the Deposit Account cannot have negative balance so no need to check if it's < 0
            if (this.Balance < 1000)
            {
                return this.Balance;
            }
            return base.CalculateInterest(periodInMonths);
        }
    }
}
