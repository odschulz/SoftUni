using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01School
{
    public class Discipline : IDetailable
    {

        private string name;
        private int numberOfLectures;
        private List<Student> students = new List<Student>();
        private string details;

        public Discipline(string name, int numberOfLectures, List<Student> students, string details = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.Students = students;
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                ValidationMethods.CheckIfStringNullOrEmpty("Discipline Name", value);
                this.name = value;
            }
        }
        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                ValidationMethods.CheckIfZeroOrNegative("Number of Lectures", value);
                this.numberOfLectures = value;
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

        public void AddStudent(Student student)
        {
            ValidationMethods.CheckIfValueExistsInList("Student", student, this.Students);
            this.Students.Add(student);
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\nNumberOfLectures: {1}{2}",
                this.Name,
                this.NumberOfLectures,
                (this.Details != null ? "\nDetails: " + this.Details : null));
        }
    }
}
