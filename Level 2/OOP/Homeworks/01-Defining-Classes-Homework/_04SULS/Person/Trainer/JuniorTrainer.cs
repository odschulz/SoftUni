using System;

namespace _04SULS
{
	public class JuniorTrainer : Trainer
	{
		public JuniorTrainer (string firstName, string lastName, int age) 
			: base(firstName, lastName, age)
		{
		}
		public override string ToString ()
		{
			return base.ToString ();
		}
	}
}

