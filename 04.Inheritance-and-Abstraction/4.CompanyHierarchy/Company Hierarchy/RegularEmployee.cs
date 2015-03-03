using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public abstract class RegularEmployee : Employee
    {
        public RegularEmployee(int id, string firstName, string lastName, decimal salary, Department department)
            : base (id, firstName, lastName, salary, department)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
