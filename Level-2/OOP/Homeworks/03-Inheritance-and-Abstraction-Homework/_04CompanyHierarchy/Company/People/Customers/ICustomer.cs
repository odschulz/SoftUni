using System;
namespace _04CompanyHierarchy
{
    public interface ICustomer : IPerson
    {
        void AddPurchaseAmount(decimal newAmount);
        decimal NetPurchaseAmount { get; set; }
    }
}
