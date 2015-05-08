using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
    //  The string “t” for leap year or “f” for year that is not leap.
    //	The number p – number of holidays in the year (which are not Saturday or Sunday).
    //	The number h – number of weekends that Joro spends in his hometown.

        string leap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int weekendsInAYear = 52;
        int normalWeekends = weekendsInAYear - h;
        double gamesPerYear = (2d * (normalWeekends / 3d)) + h + (p / 2d);
        if (leap == "t")
        {
            gamesPerYear = gamesPerYear + 3;
        }
        Console.WriteLine((int)gamesPerYear);
    }
}

