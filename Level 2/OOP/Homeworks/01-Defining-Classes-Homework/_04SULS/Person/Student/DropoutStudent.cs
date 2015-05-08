using System;

namespace _04SULS
{
	public class DropoutStudent : Student
	{
		private string dropoutReason;
		public DropoutStudent (string firstName, string lastName, int age, string studentNumber, 
		                       double averageGrade, string dropoutReason) 
			: base(firstName, lastName, age, studentNumber, averageGrade)
		{
			this.DropoutReason = dropoutReason;
		}
		public string DropoutReason {
			get { return this.dropoutReason; }
			set
			{
				ValidationMethods.ValidateStrOrDigit (value, "Dropout Reason");
				this.dropoutReason = value;
			}
		}

		public override string ToString ()
		{
			return base.ToString () + "Dropout Reason: " + this.DropoutReason;
		}

		public void Reapply()
		{
			Console.WriteLine ("Dropout Student Information:\n" + base.ToString () + "Dropout Reason: " + 
			                   this.DropoutReason + "\n");
		}
	}
}

