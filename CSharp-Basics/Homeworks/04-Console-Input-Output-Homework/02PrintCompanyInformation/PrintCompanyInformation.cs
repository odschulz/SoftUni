using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        if (faxNumber == "")
        {
            faxNumber = "(no fax)";
        }
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string ManagerFirst = Console.ReadLine();
        Console.Write("Manager last name: ");
        string ManagerLast = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string ManagerPhone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", companyName, companyAddress, phoneNumber, faxNumber, webSite, ManagerFirst, ManagerLast, managerAge, ManagerPhone);
    }
}

