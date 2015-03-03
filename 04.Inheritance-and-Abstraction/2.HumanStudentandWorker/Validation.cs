using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentandWorker
{
    public static class Validation
    {
        public static void Name(string validation, string name)
        {
            if (name.Length < 3)
            {
                throw new AggregateException(name + " can not be less than three characters!");
            }
        }
        public static void FacultyNumber(int number)
        {
            if(number < 100 || number > 9999)
            {
                throw new ArgumentOutOfRangeException("Number can not less than 100 and greather than 9999!");
            }
        }
        public static void Salary(decimal salary)
        {
            if(salary < 400 || salary > 2000)
            {
                throw new ArgumentOutOfRangeException("The company does not pay weekly wages less than 400 BGN and greather than 2000 BGN!");
            }
        }
        public static void WorkHoursPerDay(byte hours)
        {
            if(hours > 12)
            {
                throw new ArgumentOutOfRangeException("The company wokers can not be works grether 12 hours per day!");
            }
            if(hours < 0)
            {
                throw new ArgumentOutOfRangeException("Work hours can not be negative!");
            }
        }
    }
}
