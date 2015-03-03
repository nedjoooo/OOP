using System;

namespace _3.GameEngine.Items
{
    class Axe : Item
    {
        public Axe(string id,
            int healthEffect,
            int defenseEffect,
            int attackEffect)
            : base(id,
            healthEffect = 0,
            defenseEffect = 0,
            attackEffect = 75)
        {
        }
    }
}
