using System;
using System.Collections.Generic;
namespace _04CompanyHierarchy
{
    public interface IDeveloper : IEmployee
    {
        void AddProject(IProject project);
        IList<IProject> Projects { get; set; }
    }
}
