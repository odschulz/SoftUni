using System;

namespace _01Persons
{
	public class Person
	{
		private string name;
		private byte age;
		private string email;

		public Person(string name, byte age, string email)
		{
			this.Name = name;
			this.Age = age;
			this.Email = email;
		}
		public Person(string name, byte age) 
			: this(name, age, null)
		{
		}

		public string Name {
			get {return this.name; }
			set
			{
				if (string.IsNullOrEmpty(value)) {
					throw new ArgumentNullException ("Please, enter a name!");
				}
				this.name = value;
			}
		}
		public byte Age {
			get {return this.age; }
			set
			{
				if (value < 1 || value > 100) {
					throw new ArgumentOutOfRangeException ("Age must be a number in the range 1...100!");
				}
				this.age = value;
			}
		}
		public string Email {
			get {return this.email; }
			set
			{
				if (!string.IsNullOrEmpty(value) && !value.Contains("@")) {
					throw new ArgumentException ("Please, enter a valid email!");
				}
				this.email = value;
			}
		}
		public override string ToString ()
		{
			string name = this.name;
			byte age = this.age;
			string email = (!string.IsNullOrEmpty(this.email)) ? this.email : "N/A";
			return String.Format("Name: {0}, Age: {1}, Email: {2}", name, age, email);
		}
	}
}

