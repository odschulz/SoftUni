using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompanyHierarchy
{
    public class Project : _04CompanyHierarchy.IProject
    {
        private string projectName;
        private DateTime startDate;
        private string details;
        private ProjectState state;
        public Project(string projectName, DateTime startDate, string details, ProjectState state)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }
        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                ValidationMethods.CheckIfStringIsEmpty("Project Name", value);
                projectName = value;
            }
        }
        public DateTime StartDate
        {
            get { return this.startDate; }
            set { startDate = value; }
        }
        public string Details
        {
            get { return this.details; }
            set
            {
                ValidationMethods.CheckIfStringIsEmpty("Project Details", value);
                details = value;
            }
        }
        public ProjectState State
        {
            get { return this.state; }
            private set { state = value; }
        }

        public void CloseProject(ProjectState state)
        {
            this.State = state;
        }

        public override string ToString()
        {
            return String.Format(
                "Project Name: {0}\nStart Date: {1}\nDetails: {2}\nState: {3}",
                this.ProjectName, this.StartDate.ToShortDateString(), this.Details, this.State);
        }
    }
}
