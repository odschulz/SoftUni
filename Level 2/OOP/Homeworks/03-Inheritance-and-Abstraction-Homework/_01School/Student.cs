using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01School
{
    public class Student : Person
    {
        private string uniqueClassNumber;
        private static List<string> assignedClassNumbers = new List<string>();

        public Student(string name, string details, string uniqueClassNumber)
            : base(name, details)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public string UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }
            set
            {
                ValidationMethods.CheckIfStringNullOrEmpty("Unique Class Number", value);
                ValidationMethods.CheckIfValueExistsInList("Unique Class Number", value, assignedClassNumbers);
                this.uniqueClassNumber = value;
                assignedClassNumbers.Add(value);
            }
        }

        public static List<string> GetUniqueClassNumbers
        {
            get { return assignedClassNumbers; }
        }

        public override string ToString()
        {
            return base.ToString() + "\nUnique Class Number: " + this.UniqueClassNumber;
        }
    }
}
