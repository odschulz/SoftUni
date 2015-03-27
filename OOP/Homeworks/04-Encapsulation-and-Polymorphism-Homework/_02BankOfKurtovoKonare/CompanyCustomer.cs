using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare
{
    public class CompanyCustomer : Customer
    {
        private string companyIdentificationNumber;
        public CompanyCustomer(string name, string companyIdentificationNumber)
            : base(name)
        {
            this.CompanyIdentificationNumber = companyIdentificationNumber;
        }

        public string CompanyIdentificationNumber
        {
            get { return this.companyIdentificationNumber; }
            set
            {
                ValidationMethods.CheckIfStringEmpty("Company Identification Number", value);
                this.companyIdentificationNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nCompany Identification Number: " + this.CompanyIdentificationNumber;
        }
    }
}
