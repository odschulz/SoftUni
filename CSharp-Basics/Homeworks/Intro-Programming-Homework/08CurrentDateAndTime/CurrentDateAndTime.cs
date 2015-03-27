using System;

class CurrentDateAndTime
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        string format = "dd.MM.yyyy, HH:mm";
        Console.WriteLine(now.ToString(format));
    }
}

