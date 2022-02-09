using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units.BattleUnitsItem
{
    internal class Stone : IRangeWeapon
    {
        private int _stones;

        public Stone(int ammunition)
        {
            Ammunition = ammunition;
        }

        public int Ammunition { get => _stones; set => _stones = value; }
        public int MinDamage => 2;

        public int MaxDamage => 6;

        public int RangeDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int RangeAttack()
        {
            throw new NotImplementedException();
        }
    }
}
