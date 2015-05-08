using System;
namespace _04CompanyHierarchy
{
    public interface ISale
    {
        DateTime Date { get; set; }
        decimal Price { get; set; }
        string ProductName { get; set; }
    }
}
