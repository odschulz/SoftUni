using System;

namespace _04SULS
{
	public class Student : Person
	{
		private string studentNumber;
		private double averageGrade;
		public Student (string firstName, string lastName, int age, string studentNumber, double averageGrade) 
			: base(firstName, lastName, age)
		{
			this.StudentNumber = studentNumber;
			this.AverageGrade = averageGrade;
		}
		public string StudentNumber {
			get { return this.studentNumber; }
			set
			{
				ValidationMethods.ValidateStudentNumber (value);
				this.studentNumber = value;
			}
		}
		public double AverageGrade {
			get { return this.averageGrade; }
			set
			{
				ValidationMethods.ValidateGrade (value);
				this.averageGrade = value;
			}
		}

		public override string ToString ()
		{
			return base.ToString() + String.Format ("Student Number: {0}\nAverage Grade: {1}\n",
			                                        this.StudentNumber, this.AverageGrade.ToString("F"));
		}
	}
}

