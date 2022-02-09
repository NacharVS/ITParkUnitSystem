using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units.BattleUnitsItems
{
    internal class Slingshot : IRangeWeapon
    {
        private int _arrows;

        public Slingshot(int ammunition)
        {
            Ammunition = ammunition;
        }
        public int Ammunition { get => _arrows; set => _arrows=value; }

        public int MinDamage => 3;

        public int MaxDamage => 7;

        public int Damage()
        {
            Random rnd = new Random();
            var currentDamage = rnd.Next(MinDamage, MaxDamage);
            return currentDamage;
        }
    }
}
