using System;

namespace _04SULS
{
	public class GraduateStudent : Student
	{
		public GraduateStudent (string firstName, string lastName, int age, string studentNumber, 
		                        double averageGrade) 
			: base(firstName, lastName, age, studentNumber, averageGrade)
		{
		}
		public override string ToString ()
		{
			return base.ToString();
		}
	}
}

