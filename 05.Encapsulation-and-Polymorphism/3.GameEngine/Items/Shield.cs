using System;

namespace _3.GameEngine.Items
{
    class Shield : Item
    {
        public Shield(string id, int healthEffect, int defenseEffect, int attackEffect) :
            base (id, healthEffect = 0, defenseEffect = 50, attackEffect = 0)
        {

        }
    }
}
