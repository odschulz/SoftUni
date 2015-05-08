using System;

namespace _04SULS
{
	public class CurrentStudent : Student
	{
		private string currentCourse;
		public CurrentStudent (string firstName, string lastName, int age, string studentNumber, 
		                       double averageGrade, string currentCourse) 
			: base(firstName, lastName, age, studentNumber, averageGrade)
		{
			this.CurrentCourse = currentCourse;
		}
		public string CurrentCourse {
			get { return this.currentCourse; }
			set
			{
				ValidationMethods.ValidateStrOrDigit (value, "Current Course");
				this.currentCourse = value;
			}
		}
		public override string ToString ()
		{
			return base.ToString () + "Current Course: " + this.CurrentCourse + "\n";
		}
	}
}

