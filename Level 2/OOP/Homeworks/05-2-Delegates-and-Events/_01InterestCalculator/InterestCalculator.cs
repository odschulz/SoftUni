using System;

public delegate decimal CalclulateInterest(decimal moneySum, decimal interest, byte years);

public class InterestCalculator
{
    private decimal money;
    private decimal interestRate;
    private byte years;
    private CalclulateInterest interestDelegate;

    public InterestCalculator(decimal money, decimal interestRate, byte years, CalclulateInterest interestDelegate)
    {
        this.Money = money;
        this.InterestRate = interestRate;
        this.Years = years;
        this.InterestDelegate = interestDelegate;
    }

    public decimal Money
    {
        get
        {
            return this.money;
        }

        set
        {
            ValidationMethods.CheckIfNumberIsNegative("Money", value);
            this.money = value;
        }
    }

    public decimal InterestRate
    {
        get
        {
            return this.interestRate;
        }

        set
        {
            ValidationMethods.CheckIfNumberIsNegative("Interest", value);
            this.interestRate = value;
        }
    }

    public byte Years
    {
        get
        {
            return this.years;
        }

        set
        {
            ValidationMethods.CheckIfNumberIsNegative("Years", value);
            this.years = value;
        }
    }

    public CalclulateInterest InterestDelegate
    {
        get { return this.interestDelegate; }
        set { this.interestDelegate = value; }
    }

    public string GetCalculatedInterest()
    {
        decimal calculaterInterest = this.InterestDelegate(this.Money, this.InterestRate, this.Years);
        return calculaterInterest.ToString("F4");
    }
}