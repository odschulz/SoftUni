using System;

class MainProgram
{
    public static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(22, 7);
        Fraction fraction2 = new Fraction(40, 4);
        Fraction result = fraction1 + fraction2;
        Console.WriteLine(result.Numerator);
        Console.WriteLine(result.Denominator);
        Console.WriteLine(result);
        Console.WriteLine();

        //as fractions should always be simplified, I included a method that does it
        result.SimplifyFraction();
        Console.WriteLine("Simplified Fraction:");
        Console.WriteLine(result.Numerator);
        Console.WriteLine(result.Denominator);
        Console.WriteLine(result);
    }
}

