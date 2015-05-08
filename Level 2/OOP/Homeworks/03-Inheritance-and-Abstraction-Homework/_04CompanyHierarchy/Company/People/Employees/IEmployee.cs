using System;
namespace _04CompanyHierarchy
{
    public interface IEmployee : IPerson
    {
        Department Department { get; set; }
        decimal Salary { get; set; }
    }
}
