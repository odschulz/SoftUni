using System;
using System.Text;

public class MainProgram
{
    public static void Main()
    {
        StringBuilder str = new StringBuilder("Abcab");

        Console.WriteLine(str.Substring(0, 2));
        Console.WriteLine(str.RemoveText("aB"));
        Console.WriteLine(str.AppendAll(new int[] { 1, 2, }));
    }
}