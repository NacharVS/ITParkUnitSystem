using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units.BattleUnitsItems
{
    class ShortBow : IRangeWeapon
    {
        private int _stones;

        public ShortBow(int ammunition)
        {
            Ammunition = ammunition;
        }

        public int Ammunition { get => _stones; set => _stones = value; }

        public int MinDamage => 2;

        public int MaxDamage => 9;
    }
}
