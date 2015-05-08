using System;

class EmployeeData
{
    static void Main()
    {
        String firstName = "Ivan";
        String lastName = "Ivanov";
        byte age = 51;
        char gender = 'm';
        ulong personalID = 6301021020u; 
        uint employeeNumber = 27569999u;

        Console.WriteLine("Employee data:");
        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID number: " + personalID);
        Console.WriteLine("Employee number: " + employeeNumber);
    }
}

