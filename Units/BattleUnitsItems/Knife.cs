using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units.BattleUnitsItems
{
    struct Knife : IBattleUnitWeapon
    {
        public int MinDamage => 1;

        public int MaxDamage => 3;
    }
}
