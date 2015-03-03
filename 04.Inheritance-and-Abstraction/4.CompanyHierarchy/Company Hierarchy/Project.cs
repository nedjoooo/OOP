using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public class Project
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private ProjectState projectState;
        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                Validation.ProjectName(value);
                this.projectName = value;
            }
        }
        public DateTime ProjectStartDate
        {
            get { return this.projectStartDate; }
            set
            {
                Validation.Date(value, "Project");
                this.projectStartDate = value;
            }
        }
        public string Details
        {
            get { return this.details; }
            set
            {
                Validation.Details(value);
                this.details = value;
            }
        }
        public ProjectState ProjectState
        {
            get { return this.projectState; }
            set { this.projectState = value; }
        }
        public Project(string projectName, DateTime projectStartDate, string details, ProjectState projectState)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.ProjectState = projectState;
        }

        public void CloseProject()
        {
            if(this.ProjectState == ProjectState.Open)
            {
                this.ProjectState = ProjectState.Closed;
            }
            else
            {
                Console.WriteLine("This project is already closed!");
            }
        }
        public override string ToString()
        {
            return String.Format("Project name: {0}; Start date: {1}; Details: {2}; State: {3}",
                this.ProjectName, this.ProjectStartDate, this.Details, this.ProjectState);
        }

    }
}
