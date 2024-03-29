﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units.BattleUnitsItems
{
    class IronShortSword : IBattleUnitWeapon
    {
        private int _minDamage;
        private int _maxDamage;

        public IronShortSword(int minDamage, int maxDamage)
        {
            MinDamage = minDamage;
            _maxDamage = maxDamage;
        }

        public int MinDamage
        {
            get
            {
                return _minDamage;
            }
            set
            {
                _minDamage = value;
            }
        }

        public int MaxDamage => 6;
    }
}
