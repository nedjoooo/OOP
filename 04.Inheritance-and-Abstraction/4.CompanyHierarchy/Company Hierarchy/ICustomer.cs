using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public interface ICustomer : IPerson
    {
        decimal NetPurshaceAmount { get; set; }
    }
}
