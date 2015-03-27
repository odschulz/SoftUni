using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompanyHierarchy
{
    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;
        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }
        public string ProductName
        {
            get { return this.productName; }
            set
            {
                ValidationMethods.CheckIfStringIsEmpty("Product Name", value);
                this.productName = value;
            }
        }
        public DateTime Date
        {
            get { return this.date; }
            set
            {
                this.date = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                ValidationMethods.CheckDecimalIfZeroOrNegative("Sale Price", value);
                this.price = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Product Name: {0}\nSale Date: {1}\nSale Price: {2}", 
                this.ProductName, this.Date.ToShortDateString(), this.Price);
        }

    }
}
