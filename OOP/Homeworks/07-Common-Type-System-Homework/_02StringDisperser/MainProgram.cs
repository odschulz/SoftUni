using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MainProgram
{
    public static void Main()
    {
        StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
        StringDisperser stringDisperserClone = new StringDisperser("gosho", "pesho", "tanio");

        Console.WriteLine("String disperser and clone are equal: " + (stringDisperser == stringDisperserClone));

        stringDisperserClone.AddString("valio");

        Console.WriteLine("String disperser and clone are equal after clone changed: " + 
            (stringDisperser == stringDisperserClone));

        foreach (var ch in stringDisperser)
        {
            Console.Write(ch + " ");
        }

        Console.WriteLine();

        foreach (var ch in stringDisperserClone)
        {
            Console.Write(ch + " ");
        }

        Console.WriteLine();
    }
}
