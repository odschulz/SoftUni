using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        private string fName;
        private string lName;
        private string id;

        public Person(string fName, string lName, string id)
        {
            this.FName = fName;
            this.LName = lName;
            this.Id = id;
        }
        public string FName
        {
            get { return this.fName; }
            set
            {
                ValidationMethods.CheckIfStringIsEmpty("First Name", value);
                this.fName = value;
            }
        }
        public string LName
        {
            get { return this.lName; }
            set
            {
                ValidationMethods.CheckIfStringIsEmpty("Last Name", value);
                this.lName = value;
            }
        }
        public string Id
        {
            get { return this.id; }
            set
            {
                ValidationMethods.CheckIfStringIsEmpty("ID", value);
                this.id = value;
            }
        }

        public override string ToString()
        {
            return String.Format("First Name: {0}\nLast Name: {1}\nID: {2}", this.FName, this.LName, this.Id);
        }

    }
}
