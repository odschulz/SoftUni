using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompanyHierarchy
{
    public class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;
        public Employee(string fName, string lName, string id, decimal salary, Department department)
            : base(fName, lName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                ValidationMethods.CheckDecimalIfZeroOrNegative("Employee Salary", value);
                this.salary = value;
            }
        }
        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\nSalary: {0} EUR\nDepartment: {1}", this.Salary, this.Department);
        }
    }
}
