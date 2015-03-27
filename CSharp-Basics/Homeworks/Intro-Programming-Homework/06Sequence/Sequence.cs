using System;

class Sequence
{
    static void Main()
    {
        for (int i = 2; i <= 11; i++)
        {
            Console.Write(i * (Math.Pow(-1, i)) + ", ");
        }
    }
}
