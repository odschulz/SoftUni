using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare
{
    class LoanAccount : Account
    {
        public LoanAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }
        public override decimal CalculateInterest(int periodInMonths)
        {
            string customerType = this.Customer.GetType().Name;
            int periodWithoutInterest = 0;

            if (customerType == "IndividualCustomer")
            {
                periodWithoutInterest = 3;
            }
            else if (customerType == "CompanyCustomer")
            {
                periodWithoutInterest = 2;
            }
            else
            {
                throw new NotImplementedException(
                    "This method is used for a type of customer that is not supported!");
            }

            if (periodWithoutInterest > periodInMonths)
            {
                return this.Balance;
            }
            return base.CalculateInterest(periodInMonths - periodWithoutInterest);

        }
    }
}
