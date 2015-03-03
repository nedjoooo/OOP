using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GameEngine
{
    public class Injection : Bonus
    {
        public Injection(string id, int healthEffect, int defenseEffect, int attackEffect)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {

        }
    }
}
