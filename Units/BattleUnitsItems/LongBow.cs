using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units.BattleUnitsItems
{
    class LongBow : IBattleUnitBow, IBattleUnitArrow
    {
        private int _arrow;

        private int _maxArrow;

        public int MinDamage => 8;

        public int MaxDamage => 16;

        public int Arrow { get => _arrow; set => _arrow = value; }

        public int MaxArrow { get => _maxArrow; set => _maxArrow = value; }
    }
}
