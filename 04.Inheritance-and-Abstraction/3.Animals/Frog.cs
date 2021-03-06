﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Frog : Animal
    {
        public Frog(string name, int age, Gender gender) : base(name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            return "Gobble";
        }
        public override string ToString()
        {
            return String.Format("Frog / ") + base.ToString() + " /";
        }
    }
}
