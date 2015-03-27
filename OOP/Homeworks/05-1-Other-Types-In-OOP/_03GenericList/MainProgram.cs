using System;

public class MainProgram
{
    public static void Main(string[] args)
    {
        GenericList<int> customList = new GenericList<int>(1);

        customList.AddELement(1);
        customList.AddELement(2);
        Console.WriteLine(customList);

        customList.RemoveByIndex(0);
        Console.WriteLine("Removed element at index 0: " + customList);

        customList.AddELement(3);
        Console.WriteLine("Added 3: " + customList);

        customList.InsertAtIndex(9, 0);
        Console.WriteLine("Inserted 9 at index 0: " + customList);

        Console.WriteLine("Index of 3: " + customList.FindIndex(3)); // will return -1 if index is not found

        Console.WriteLine("List contains 3: " + customList.ContainsElement(3));

        Console.WriteLine(customList);
        Console.WriteLine("Max element in list: " + customList.Max());

        Console.WriteLine();
        var allAttribues = typeof(GenericList<int>).GetCustomAttributes(typeof(VersionAttribute), false);
        Console.WriteLine("Version: " + allAttribues[0]);
    }
}