using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompanyHierarchy
{
    public abstract class RegularEmployee : Employee
    {
        public RegularEmployee(string fName, string lName, string id, decimal salary,
            Department department)
            : base(fName, lName, id, salary, department)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
