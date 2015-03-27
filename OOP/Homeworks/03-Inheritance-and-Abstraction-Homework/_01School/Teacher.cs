using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01School
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines = new List<Discipline>();
        public Teacher(string name, List<Discipline> disciplines, string details)
            : base(name, details)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set
            {
                ValidationMethods.CheckIfListIsNull("Disciplines List", value);
                this.disciplines = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Disciplines taught by this teacher:");
            foreach (var disc in this.Disciplines)
            {
                str.AppendLine(disc.ToString());
            }
            return base.ToString() + "\n" + str.ToString().Trim();
        }
    }
}
