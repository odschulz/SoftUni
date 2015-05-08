using System;

namespace _01Persons
{
	class Persons
	{
		public static void Main (string[] args)
		{
			Person p1 = new Person("Gosho", 20);
			Person p2 = new Person("Pesho", 30, "pesho@mente.bg");
			Console.WriteLine (p1);
			Console.WriteLine (p2);
		}
	}
}
