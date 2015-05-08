using System;

namespace _04SULS
{
	public class Trainer : Person
	{
		public Trainer (string firstName, string lastName, int age) 
			: base(firstName, lastName, age)
		{
		}

		public void CreateCourse(string courseName)
		{
			Console.WriteLine ("Course \'" + courseName + "\' has been created!");
		}
		public override string ToString ()
		{
			return base.ToString ();
		}
	}
}

