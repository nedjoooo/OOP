using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base (name, age, Gender.Male)
        {

        }
        public override string ProduceSound()
        {
            return "Meow";
        }
        public override string ToString()
        {
            return String.Format("Tomcat / ") + base.ToString() + " /";
        }
    }
}
