using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01School
{
    public class SchoolClass : IDetailable
    {
        private string uniqueTextIdentifier;
        private List<Teacher> teachers;
        private List<Student> students;
        private string details;
        private static List<string> assignedTextIdentifiers = new List<string>();

        public SchoolClass(string uniqueTextIdentifier, List<Teacher> teachers,
            List<Student> students, string details = null)
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
            this.Teachers = teachers;
            this.Students = students;
            this.Details = details;
        }


        public string UniqueTextIdentifier
        {
            get { return this.uniqueTextIdentifier; }

            set
            {
                ValidationMethods.CheckIfStringNullOrEmpty("Unique Text Identifier", value);
                ValidationMethods.CheckIfValueExistsInList("Unique Text Identifier", value, assignedTextIdentifiers);
                this.uniqueTextIdentifier = value;
                assignedTextIdentifiers.Add(value);
            }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }

            set
            {
                ValidationMethods.CheckIfListIsNull("Teachers List", value);
                this.teachers = value;
            }
        }

        public List<Student> Students
        {
            get { return this.students; }

            set
            {
                ValidationMethods.CheckIfListIsNull("Students List", value);
                this.students = value;
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
            StringBuilder str = new StringBuilder();
            str.AppendLine("School Class Information:");
            str.AppendLine("Unique Text Identifier: " + this.UniqueTextIdentifier);
            str.AppendLine("Teachers:");
            foreach (var teacher in this.Teachers)
            {
                str.AppendLine(teacher.Name);
            }
            str.AppendLine("Students:");
            foreach (var student in this.Students)
            {
                str.AppendLine(student.Name);
            }
            if (this.Details != null)
            {
                str.AppendLine("Details: " + this.Details);
            }
            return str.ToString();
        }


    }
}
