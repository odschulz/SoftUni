using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare
{
    class MortgageAccount : Account
    {
        public MortgageAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }
        public override decimal CalculateInterest(int periodInMonths)
        {
            string customerType = this.Customer.GetType().Name;

            if (customerType == "IndividualCustomer")
            {
                int periodWithoutInterest = 6;
                if (periodInMonths <= periodWithoutInterest)
                {
                    return this.Balance;
                }
                else
                {
                    return base.CalculateInterest(periodInMonths - periodWithoutInterest);
                }
            }
            else if (customerType == "CompanyCustomer")
            {
                int periodWithHalfInterest = 12;
                if (periodInMonths <= periodWithHalfInterest)
                {
                    return base.CalculateInterest(periodInMonths) / 2;
                }
                else
                {
                    return base.CalculateInterest(periodInMonths) / 2 +
                        base.CalculateInterest(periodInMonths - periodWithHalfInterest);
                }
            }
            else
            {
                throw new NotImplementedException(
                    "This method is used for a type of customer that is not supported!");
            }
        }
    }
}
