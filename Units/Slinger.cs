﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units
{
    class Slinger : Unit, IBattleUnit, IBufable, IMovableUnit, IRangeUnit
    {
        private int _stones;

        public int Armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CurrentHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int WalkingSpeed => throw new NotImplementedException();

        public IRangeWeapon RangeWeapon => throw new NotImplementedException();

        public void Attack(IUnit unit)
        {
            throw new NotImplementedException();
        }

        public void ChangeWeapon(IBattleUnitWeapon newWeapon)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void StoneSkin()
        {
            throw new NotImplementedException();
        }

        public void UnitInfo()
        {
            throw new NotImplementedException();
        }
    }
}
