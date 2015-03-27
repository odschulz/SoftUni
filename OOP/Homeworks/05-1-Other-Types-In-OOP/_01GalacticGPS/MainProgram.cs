using System;

class MainProgram
{
    public static void Main(string[] args)
    {
        try
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
        }
        catch (ArgumentOutOfRangeException ex)
        {

            Console.WriteLine(ex.ParamName);
        }
        catch (FormatException ex)
        {

            Console.WriteLine("Latitude and Longitude must be of type double!");
        }
    }
}

