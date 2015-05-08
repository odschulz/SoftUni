using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // to display '≤'
        int a;
        do
        {
            Console.WriteLine("Enter a (0 ≤ a ≤ 500): ");
            a = int.Parse(Console.ReadLine());
        } while (a > 500 || a < 0);

        Console.WriteLine("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0}|{1}|{2,10:0.##}|{3,-10:0.###}|", (a.ToString("X").PadRight(10)), (Convert.ToString(a, 2).PadLeft(10, '0')), b,c);
    }
}

