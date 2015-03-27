using System;

class BankAccountData
{
    static void Main()
    {
        //A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. 

        String firstName = "Ivan";
        String middleName = "Ivanov";
        String lastName = "Ivanov";
        decimal accountBalance = 10000.00m;
        string bankName = "Not an Evil Bank";
        string iban = "NAEBBG0000001524006510";
        ulong cardNumber1 = 4545545445545445u;
        ulong cardNumber2 = 4545545445545446u;
        ulong cardNumber3 = 4545545445545447u;
        
        Console.WriteLine("Bank account data:");
        Console.WriteLine();
        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Middle name: " + middleName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Account balance: " + accountBalance);
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("Credit card number 1: " + cardNumber1);
        Console.WriteLine("Credit card number 2: " + cardNumber2);
        Console.WriteLine("Credit card number 3: " + cardNumber3);
    }
}

