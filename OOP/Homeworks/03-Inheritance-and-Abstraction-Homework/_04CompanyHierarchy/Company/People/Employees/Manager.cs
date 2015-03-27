using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompanyHierarchy
{
    public class Manager : Employee, IManager
    {
        private IList<IEmployee> subordinates;
        public Manager(string fName, string lName, string id, decimal salary,
            Department department, IList<IEmployee> subordinates)
            : base(fName, lName, id, salary, department)
        {
            this.Subordinates = subordinates;
        }
        public IList<IEmployee> Subordinates
        {
            get { return this.subordinates; }
            set
            {
                ValidationMethods.CheckIfPersonListIsNull("Manager Subordinates", value);
                this.subordinates = value;
            }
        }

        public void AddSubordinate(IEmployee newSubordinate)
        {
            this.Subordinates.Add(newSubordinate);
        }

        public void RemoveSubordinate(IEmployee subordinateToRemove)
        {
            ValidationMethods.CheckIfPersonListContains(
                "Subordinates List", this.Subordinates, subordinateToRemove);

            this.Subordinates.Remove(subordinateToRemove);
        }

        public override string ToString()
        {
            StringBuilder subordinates = new StringBuilder();
            foreach (var e in this.Subordinates)
            {
                subordinates.AppendLine(e.FName + " " + e.LName + ", ID: " + e.Id + ";");
            }

            return base.ToString() + "\nSubordinate employees:\n" + subordinates.ToString().Trim();
        }

    }
}
