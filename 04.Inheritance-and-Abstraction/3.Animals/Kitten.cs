﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age) : base (name, age, Gender.Female)
        {

        }
        public override string ProduceSound()
        {
            return "Miaow";
        }
        public override string ToString()
        {
            return String.Format("Kitten / ") + base.ToString() + " /";
        }
    }
}
