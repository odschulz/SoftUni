using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Write("Please choose a method\n1 --> int\n2 --> double\n3 --> string\n");
        int method = int.Parse(Console.ReadLine());
        switch (method)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a+1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b+1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string c = Console.ReadLine();
                Console.WriteLine("{0}*", c);
                break;
            default:
                Console.WriteLine("invalid type");
                break;
        }
    }
}

