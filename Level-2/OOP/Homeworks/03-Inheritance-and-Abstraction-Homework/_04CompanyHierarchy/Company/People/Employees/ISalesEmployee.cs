using System;
using System.Collections.Generic;
namespace _04CompanyHierarchy
{
    public interface ISalesEmployee :IEmployee
    {
        void AddSale(ISale sale);
        IList<ISale> Sales { get; set; }
    }
}
