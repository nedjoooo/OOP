using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    public class Validation
    {
        public static void Name(string value)
        {
            if(value.Length < 3)
            {
                throw new ArgumentException("Name length should be minimum three letters!");
            }
        }
        public static void ID(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("Id value can not be negative or zero!");
            }
        }
        public static void Salary(decimal salary)
        {
            if(salary < 340)
            {
                throw new ArgumentOutOfRangeException("Salary should be greater than 340 BGN!");
            }
        }
        public static void NetPurshaceAmount(decimal netPurshaceAmount)
        {
            if (netPurshaceAmount < 0)
            {
                throw new ArgumentOutOfRangeException("Sum of net purshace amount can not be negative!");
            }
        }
        public static void Employee(List<Employee> employees)
        {
            if(employees == null)
            {
                throw new ArgumentNullException("Employee list can not be empty!");
            }
        }
        public static void Sale(List<Sale> sales)
        {
            if (sales == null)
            {
                throw new ArgumentNullException("Sales list can not be empty!");
            }
        }
        public static void Projects(List<Project> projects)
        {
            if (projects == null)
            {
                throw new ArgumentNullException("Project list can not be empty!");
            }
        }
        public static void Date(DateTime date, string name)
        {
            if(date == null)
            {
                throw new ArgumentNullException(name + " date can not be empty!");
            }
        }
        public static void Price(decimal price)
        {
            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException("Price can not be negative or zero!");
            }
        }
        public static void ProjectName(string value)
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Project name length should be minimum three letters!");
            }
        }
        public static void Details(string value)
        {
            if (value.Length < 1)
            {
                throw new ArgumentException("Details length should be minimum one letter!");
            }
        }
    }
}
