using System;

class PrintMyAge
{
    static void Main()
    {
        DateTime birthday = new DateTime(1985, 01, 27);
        DateTime now = DateTime.Now;
        int age = now.Day - birthday.Day;
        int period = 365;
        Console.WriteLine("Your current age is: " + age);
        Console.WriteLine("Your age after " + period + " years will be: " + (age+10));
    }
}

