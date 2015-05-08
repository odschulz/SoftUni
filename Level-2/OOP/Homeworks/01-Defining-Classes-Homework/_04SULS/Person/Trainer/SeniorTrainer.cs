using System;

namespace _04SULS
{
	public class SeniorTrainer : Trainer
	{
		public SeniorTrainer (string firstName, string lastName, int age) 
			: base(firstName, lastName, age)
		{
		}

		public void DeleteCourse(string courseName)
		{
			Console.WriteLine("Course \'" + courseName + "\' has been deleted!");
		}

		public override string ToString ()
		{
			return base.ToString ();
		}
	}
}

