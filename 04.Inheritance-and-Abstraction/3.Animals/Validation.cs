using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    public static class Validation
    {
        public static void Name(string name)
        {
            if (name.Length < 3)
            {
                throw new AggregateException("Name can not be less than three characters!");
            }
        }
        public static void Age(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException("Age can not be negative!");
            }
        }
    }
}
