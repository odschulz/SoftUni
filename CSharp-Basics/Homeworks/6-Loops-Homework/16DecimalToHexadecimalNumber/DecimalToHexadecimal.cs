using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        long n = long.Parse(Console.ReadLine());
        string s = "";
        do
        {
            long temp = n % 16;
            switch (temp)
            {
                case 10:
                    s = 'A' + s;
                    break;
                case 11:
                    s = 'B' + s;
                    break;
                case 12:
                    s = 'C' + s;
                    break;
                case 13:
                    s = 'D' + s;
                    break;
                case 14:
                    s = 'E' + s;
                    break;
                case 15:
                    s = 'F' + s;
                    break;
                default:
                    s = temp + s;
                    break;
            }
            n = n / 16;
        } while (n > 0);
        Console.WriteLine(s);
    }
}

