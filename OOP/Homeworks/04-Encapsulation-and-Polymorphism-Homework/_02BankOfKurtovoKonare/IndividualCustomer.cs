using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare
{
    class IndividualCustomer : Customer
    {
        private string personalIdentificationNumber;
        public IndividualCustomer(string name, string personalIdentificationNumber)
            : base(name)
        {
            this.PersonalIdentificationNumber = personalIdentificationNumber;
        }
        public string PersonalIdentificationNumber
        {
            get { return this.personalIdentificationNumber; }
            set
            {
                ValidationMethods.CheckIfStringEmpty("Personal Identification Number", value);
                this.personalIdentificationNumber = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\nPersonal Identification Number: " + this.PersonalIdentificationNumber;
        }
    }
}
