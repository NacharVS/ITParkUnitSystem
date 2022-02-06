using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units.BattleUnitsItems
{
    struct Сrossbow : IBattleUnitRemoteSimpleWeapon
    {
        private int _stone;

        private int _maxStone;

        public Сrossbow(int maxstone)
        {
            _stone = maxstone;
            _maxStone = maxstone;
        }

        public int MinDamage => 1;

        public int MaxDamage => 3;

        public int Arrow { get => _stone; set => _stone = value; }

        public int MaxArrow { get => _maxStone; }
    }
}
