using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare
{
    public abstract class Customer : ICustomer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                ValidationMethods.CheckIfStringEmpty("First Name", value);
                this.name = value;
            }
        }


        public override string ToString()
        {
            return String.Format("Name: {0}", this.Name);
        }
    }
}
