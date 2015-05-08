using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompanyHierarchy
{
    class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;


        public Customer(string fName, string lName, string id, decimal netPurchaseAmount)
            : base(fName, lName, id)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                ValidationMethods.CheckDecimalIfZeroOrNegative("Customer Net Purchase Amount", value);
                this.netPurchaseAmount = value;
            }
        }
        public void AddPurchaseAmount(decimal newAmount)
        {
            ValidationMethods.CheckDecimalIfZeroOrNegative("Purchase Amount to be Added", newAmount);
            this.NetPurchaseAmount += newAmount;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Net Purchase Amount: {0:N2} EUR", this.NetPurchaseAmount);
        }
    }
}
