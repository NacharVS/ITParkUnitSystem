using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    public class IronShortSword : IBattleUnitWeapon
    {
        public int MinDamage => 2;
        public int MaxDamage => 6;
    }
}
