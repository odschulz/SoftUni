using System;
namespace _04CompanyHierarchy
{
    public interface IProject
    {
        void CloseProject(ProjectState state);
        string Details { get; set; }
        string ProjectName { get; set; }
        DateTime StartDate { get; set; }
        ProjectState State { get; }
    }
}
