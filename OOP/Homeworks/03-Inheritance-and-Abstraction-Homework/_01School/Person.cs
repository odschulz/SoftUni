using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01School
{
    public class Person : IDetailable
    {
        private string name;
        private string details;

        public Person(string name, string details = null)
        {
            this.Name = name;
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                ValidationMethods.CheckIfStringNullOrEmpty("Name", value);
                this.name = value;
            }
        }
        public string Details
        {
            get { return this.details; }
            set
            {
                ValidationMethods.CheckIfStringEmpty("Details", value);
                this.details = value;
            }
        }

        public override string ToString()
        {
            return "Name: " + this.Name
                + (this.Details != null ? "\nDetails: " + this.Details : null);
        }
    }
}
