using System;
using System.Collections.Generic;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units
{
    class Archer : Unit, IBattleUnit, IBufable, IMovableUnit
    {
        IRangeWeapon _rangeWeapon;
        public IronShortSword _extraWeapon = new IronShortSword(2, 6);

        public Archer(IRangeWeapon rangeWeapon)
        {
            this._rangeWeapon = rangeWeapon;
        }

        private int _armor;
        public int Armor { get => _armor; set => _armor = value; }
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public int WalkingSpeed => 8;

        public void Attack(IUnit unit)
        {
            if (_rangeWeapon.Ammunition <= 0)
            {
                Random rnd = new Random();
                var currentDamage = rnd.Next(_extraWeapon.MinDamage, _extraWeapon.MaxDamage);
                Console.WriteLine($"Footman inflicted {currentDamage}");
                unit.CurrentHealth -= currentDamage;
                unit.UnitInfo();
                Console.WriteLine("weapon has changed");
            }
            else
            {
                Random rnd = new Random();
                var currentDamage = rnd.Next(_rangeWeapon.MinDamage, _rangeWeapon.MaxDamage);
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
    }
}
