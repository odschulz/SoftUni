using System;
namespace _04CompanyHierarchy
{
    public interface IManager : IEmployee
    {
        void AddSubordinate(IEmployee newSubordinate);
        void RemoveSubordinate(IEmployee subordinateToRemove);
        System.Collections.Generic.IList<IEmployee> Subordinates { get; set; }
    }
}
