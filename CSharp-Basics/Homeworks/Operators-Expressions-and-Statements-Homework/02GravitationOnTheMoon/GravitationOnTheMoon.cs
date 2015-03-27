using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        float weightOnEarth = float.Parse(Console.ReadLine());
        float weightOnMoon = (17f / 100f) * weightOnEarth;
        Console.WriteLine(weightOnMoon);
    }
}
