using System;

public class Payment
{
    private string productName;
    private decimal price;

    public Payment(string productName, decimal price)
    {
        this.ProductName = productName;
        this.Price = price;
    }

    public string ProductName
    {
        get
        {
            return this.productName;
        }

        set
        {
            ValidationMethods.CheckIfStringIsNullOrEmpty("Product Name", value);
            this.productName = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }

        set
        {
            ValidationMethods.CheckIfNumIsZeroOrNegative("Price", value);
            this.price = value;
        }
    }

    public override string ToString()
    {
        return String.Format(this.ProductName + ": " + this.Price + "EUR");
    }
}