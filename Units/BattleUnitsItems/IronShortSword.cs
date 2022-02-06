using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units.BattleUnitsItems
{
    struct IronShortSword : IBattleUnitWeapon
    {
        public int MinDamage => 2;

        public int MaxDamage => 6;
    }
}
