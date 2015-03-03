using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    abstract class Cat : Animal
    {
        public Cat(string name, int age, Gender gender) : base(name, age, gender)
        {

        }
    }
}
