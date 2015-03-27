using System;

namespace _04SULS
{
	public class Person
	{
		private string firstName;
		private string lastName;
		private int age;
		public Person (string firstName, string lastName, int age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}
		public string FirstName {
			get { return this.firstName; }
			set
			{
				ValidationMethods.ValidateStrOrDigit ( value, "First Name");
				this.firstName = value;
			}
		}
		public string LastName {
			get { return this.lastName; }
			set
			{
				ValidationMethods.ValidateStrOrDigit ( value, "Last Name");
				this.lastName = value;
			}
		}
		public int Age {
			get { return this.age; }
			set
			{
				ValidationMethods.ValidateStrOrDigit ( value, "Age");
				this.age = value;
			}
		}
		public override string ToString ()
		{
			return String.Format ("First Name: {0}\nLast Name: {1}\nAge: {2}\n",this.FirstName, this.LastName, this.Age);
		}
	}
}

