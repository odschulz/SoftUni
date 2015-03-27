using System;
namespace _02BankOfKurtovoKonare
{
    public interface IAccount
    {
        decimal Balance { get; set; }
        ICustomer Customer { get; set; }
        decimal MonthlyInterestRate { get; set; }
        decimal CalculateInterest(int periodInMonths);
    }
}
