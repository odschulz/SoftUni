using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                ValidationMethods.ValidateFacultyNumber(value);
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\nFaculty Number: " + this.facultyNumber;
        }
    }
}
