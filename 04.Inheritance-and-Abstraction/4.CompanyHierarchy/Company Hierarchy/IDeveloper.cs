using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public interface IDeveloper : IRegularEmployee
    {
        List<Project> projects { get; set; }
    }
}
