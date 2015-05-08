using System;

namespace _04SULS
{
	public class OnsiteStudent : CurrentStudent
	{
		private int numberOfVisits;
		public OnsiteStudent (string firstName, string lastName, int age, string studentNumber, 
		                      double averageGrade, string currentCourse, int numberOfVisits) 
			: base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
		{
			this.NumberOfVisits = numberOfVisits;	
		}
		public int NumberOfVisits {
			get {return this.numberOfVisits; }
			set
			{
				ValidationMethods.ValidateStrOrDigit(value, "Number of Visits");
				this.numberOfVisits = value;
			}
		}
		public override string ToString ()
		{
			return base.ToString () + "Number of Visits: " + this.NumberOfVisits + "\n";
		}
	}
}

