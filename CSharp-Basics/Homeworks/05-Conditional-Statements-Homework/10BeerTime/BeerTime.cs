using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string userInput = Console.ReadLine();
        DateTime userTime;
        string firstString = "1:00 PM";
        string secondString = "3:00 AM";
        DateTime start = DateTime.Parse(firstString);
        DateTime end = DateTime.Parse(secondString);
        if (DateTime.TryParseExact(userInput, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out userTime))
        {
            if (userTime >= start || userTime < end)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

