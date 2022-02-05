﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units.BattleUnitsItems
{
    class ShortBow : IBattleUnitRemoteWeapon
    {
        private int _arrow;

        private int _maxArrow;

        public ShortBow(int maxArrow)
        {
            _maxArrow = maxArrow;
            _arrow = maxArrow;
        }

        public int MinDamage => 5;

        public int MaxDamage => 10;
        
        public int Arrow { get => _arrow; set => _arrow = value; }

        public int MaxArrow { get => _maxArrow; set => _maxArrow = value; }
    }
}
