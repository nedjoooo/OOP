using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Dog : Animal
    {
        public Dog(string name, int age, Gender gender) : base(name, age, gender)
        {

        }

        public override string ProduceSound()
        {
            return "Barking";
        }
        public override string ToString()
        {
            return String.Format("Dog / ") + base.ToString() + " /";
        }
    }
}
