﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units
{
    class Archer : Unit, IBattleUnit, IBufable, IMovableUnit, IRangeUnit
    {
        IRangeWeapon _rangeWeapon;
        IBattleUnitWeapon _extraWeapon = new Knife();

        public Archer(IRangeWeapon rangeWeapon)
        {
            this._rangeWeapon = rangeWeapon;
        }
        private int _armor;
        public int Armor { get => _armor; set => _armor = value; }
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public int WalkingSpeed => 8;

        public IRangeWeapon RangeWeapon { get => _rangeWeapon; set => _rangeWeapon = value; }

        public void Attack(IUnit unit)
        {
            if (_rangeWeapon.Ammunition <= 0)
            {
                Random rnd = new Random();
                var currentDamage = rnd.Next(_extraWeapon.MinDamage, _extraWeapon.MaxDamage);
                Console.WriteLine($"Archer inflicted {currentDamage}");
                unit.CurrentHealth -= currentDamage;
                unit.UnitInfo();
                Console.WriteLine("weapon has changed");
            }
            else
            {
                var currentDamage = RangeWeapon.Damage();
                Console.WriteLine($"Archer inflicted {currentDamage}");
                unit.CurrentHealth -= currentDamage;
                _rangeWeapon.Ammunition--;
                unit.UnitInfo();
            }
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

        public int RangeDamage()
        {
            if (_rangeWeapon.Ammunition > 0)
            {
                return _rangeWeapon.Damage(); 
            }
            else
            {
                return 0;  
            }
        }
    }
}
