using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;
        private int p1;
        private string p2;
        private string p3;
        private int p4;

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                Validation.Salary(value);
                this.salary = value;
            }
        }
        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public Employee(int id, string firstName, string lastName, decimal salary, Department department)
            : base (id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Salary: {0} ; Department: {1};", this.Salary, this.Department);
        }
    }
}
