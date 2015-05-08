namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name, string teacherName = null, IList<string> students = null, string town = null)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        public string Town 
        {
            get
            {
                return this.town;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Parameter Town cannot be an empty string.");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
