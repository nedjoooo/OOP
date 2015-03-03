using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public class Developer : RegularEmployee
    {
        private List<Project> projects = new List<Project>();
        public List<Project> Projects
        {
            get { return this.projects; }
            set
            {
                Validation.Projects(value);
                this.projects = value;
            }
        }
        public Developer(int id, string firstName, string lastName, decimal salary, Department department, List<Project> projects)
            : base (id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }
        public override string ToString()
        {
            StringBuilder developer = new StringBuilder();
            developer.AppendLine(base.ToString());
            foreach (var project in projects)
            {
                developer.AppendLine(project.ToString());
            }
            return developer.ToString();
        }
    }
}
