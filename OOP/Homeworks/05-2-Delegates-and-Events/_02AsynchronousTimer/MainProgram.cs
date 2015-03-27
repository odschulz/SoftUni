using System;

public class MainProgram
{
    public static void Main()
    {
        AsyncTimer a = new AsyncTimer(WriteTicks, 5, 1000);
        a.StartThread();
    }

    public static void WriteTicks(string str)
    {
        Console.WriteLine(str);
    }
}