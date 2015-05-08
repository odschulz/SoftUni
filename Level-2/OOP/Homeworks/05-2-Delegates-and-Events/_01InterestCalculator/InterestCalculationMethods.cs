using System;

public class InterestCalcMethods
{
    public static decimal GetSimpleInterest(decimal moneySum, decimal interestRate, byte years)
    {
        decimal simpleInterest = moneySum * (1 + (interestRate / 100) * years);
        return simpleInterest;
    }

    public static decimal GetCompoundInterest(decimal moneySum, decimal interestRate, byte years)
    {
        double n = 12;
        decimal compoundInterest = moneySum * (decimal)Math.Pow(1 + ((double)interestRate / 100) / n, years * n);
        return compoundInterest;
    }
}
