using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        int? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);

        a += 1;
        b += 2;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

