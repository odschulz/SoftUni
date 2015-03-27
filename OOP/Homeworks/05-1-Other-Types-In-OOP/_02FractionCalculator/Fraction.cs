using System;


public struct Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int numerator, int denominator) 
        : this()
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    public int Numerator
    {
        get { return this.numerator; }
        set
        {
            this.numerator = value;
        }
    }
    public int Denominator 
    {
        get { return this.denominator; }
        set
        {
            if (value == 0)
            {
                throw new ArgumentOutOfRangeException("The denominator cannot be zero! Division by zero is a big no-no!");
            }
            this.denominator = value;
        } 
    }

    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        Fraction result = new Fraction((f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator), 
            (f1.Denominator * f2.Denominator));
        if (Math.Max(result.Numerator, result.Denominator) % Math.Min(result.Numerator, result.Denominator) == 0)
        {
                
        }
        return result;
    }

    public static Fraction operator -(Fraction f1, Fraction f2)
    {
        Fraction result = new Fraction((f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator),
            (f1.Denominator * f2.Denominator));
        return result;
    }

    public override string ToString()
    {
        return ((decimal)this.Numerator / this.Denominator).ToString();

    }

    public void SimplifyFraction()
    {
        int a = this.Numerator;
        int b = this.Denominator;
        int c = 1;
        if (a >= b)
        {
            while (c != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            this.Numerator /= a;
            this.Denominator /=a;
        }
        else if (b > a)
        {
            while (c != 0)
            {
                c = b % a;
                b = a;
                a = c;
            }
            this.Numerator /= b;
            this.Denominator /= b;
        }
    }
}

