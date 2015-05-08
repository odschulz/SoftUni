using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompanyHierarchy
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private IList<IProject> projects;


        public Developer(string fName, string lName, string id, decimal salary, IList<IProject> projects)
            : base(fName, lName, id, salary, Department.IT)
        {
            this.Projects = projects;
        }
        public IList<IProject> Projects
        {
            get { return this.projects; }
            set { this.projects = value; }
        }
        public void AddProject(IProject project)
        {
            this.Projects.Add(project);
        }

        public override string ToString()
        {
            StringBuilder projects = new StringBuilder();
            foreach (var p in this.Projects)
            {
                projects.AppendLine(
                    p.ProjectName + ";\n" 
                    + p.Details + ";\n" 
                    + "Start Date: " + p.StartDate + ";\n" 
                    + "State of project: " + p.State + ";");
            }

            return base.ToString() + "\nProjects:\n" + projects.ToString().Trim();
        }
    }
}
