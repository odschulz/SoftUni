using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompanyHierarchy
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private IList<ISale> sales;
        public SalesEmployee(string fName, string lName, string id, decimal salary)
            : base(fName, lName, id, salary, Department.Sales)
        {
            //I think a sales employee can be instantiated before they have made a sale
            //Thus I don't include the sales in the constructor
            this.Sales = new List<ISale>();  
                                                
        }
        public IList<ISale> Sales
        {
            get { return this.sales; }
            set
            {
                this.sales = value;
            }
        }

        public void AddSale(ISale sale)
        {
            this.Sales.Add(sale);
        }

        public override string ToString()
        {
            StringBuilder sales = new StringBuilder();
            foreach (var s in this.Sales)
            {
                sales.AppendLine(s.ProductName + " " + s.Date + " " + s.Price);
            }

            return base.ToString() + "\nSales Made:\n" + sales.ToString().Trim();
        }
    }
}
