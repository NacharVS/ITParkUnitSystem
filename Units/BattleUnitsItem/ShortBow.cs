using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units.BattleUnitsItem
{
    internal class ShortBow : IRangeWeapon
    {
        private int _arrows;

        public ShortBow(int ammunition)
        {
            Ammunition = ammunition;
        }

        public int Ammunition { get => _arrows; set => _arrows = value; }
        public int MinDamage => 2;

        public int MaxDamage => 9;

      
    }
}
