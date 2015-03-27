using System;

public class MainProgram
{
    public static void Main()
    {
        InterestCalculator compoundInterest = new InterestCalculator(
            500, 5.6m, 10, InterestCalcMethods.GetCompoundInterest);
        Console.WriteLine(compoundInterest.GetCalculatedInterest());

        InterestCalculator simpleInterest = new InterestCalculator(
            2500, 7.2m, 15, InterestCalcMethods.GetSimpleInterest);
        Console.WriteLine(simpleInterest.GetCalculatedInterest());
    }
}