using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02HumanStudentAndWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                ValidationMethods.CheckIfStringEmpty("First Name", value);
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                ValidationMethods.CheckIfStringEmpty("Last Name", value);
                this.lastName = value;
            }
        }
        public override string ToString()
        {
            return "Name: " + this.FirstName + " " + this.LastName;
        }
    }
}
