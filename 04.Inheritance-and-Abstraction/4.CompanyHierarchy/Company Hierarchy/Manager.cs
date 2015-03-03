using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public class Manager : Employee
    {
        private List<Employee> employees = new List<Employee>();
        public List<Employee> Employees
        {
            get { return this.employees; }
            set
            {
                Validation.Employee(value);
                this.employees = value;
            }
        }
        public Manager(int id, string firstName, string lastName, decimal salary, Department department, List<Employee> employees)
            : base (id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }
        public override string ToString()
        {
            StringBuilder manager = new StringBuilder();
            manager.AppendLine(base.ToString());
            foreach (var employee in employees)
            {
                manager.AppendLine(employee.ToString());
            }
            return manager.ToString();
        }
    }
}
