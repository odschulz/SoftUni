using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter date in format 'dd.MM.yyyy': ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(DaysBetween(firstDate, secondDate).Days);
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid date");
        }
    }
    static TimeSpan DaysBetween(DateTime firstDate, DateTime secondDate)
    {
        TimeSpan days = secondDate - firstDate;
        return days;
    }
}

