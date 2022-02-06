using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItem;

namespace Units
{
    internal class Archer : Unit, IBattleUnit,IBuffable,IRangeUnit
    {
        IRangeWeapon _rangeWeapon;
        IBattleUnitWeapon _extraWeapon=new IronShortSword();
        private int _armor;
        public int Armor { get => _armor; set => _armor = value; }

        public Archer(IRangeWeapon rangeWeapon)
        {
            this._rangeWeapon = rangeWeapon;
        }
        public int WalkingSpeed => 8;
        public double CurrentHealth { get => _currentHealth; set => _currentHealth=value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth=value; }

        public void Attack(IUnit unit)
        {
            if (_rangeWeapon.Ammunition <= 0)
            {
                var rnd = new Random();
                var currentDamage = rnd.Next(_extraWeapon.MinDamage, _extraWeapon.MaxDamage);
                unit.CurrentHealth -= currentDamage;
                Console.WriteLine($"{GetType().Name} inflicted {currentDamage} damage to {unit.GetType().Name}");
                unit.UnitInfo();
                Console.WriteLine("Weapon is changed");
            }
            else
            {
                var rnd = new Random();
                var currentDamage = rnd.Next(_rangeWeapon.MinDamage, _rangeWeapon.MaxDamage);
                unit.CurrentHealth -= currentDamage;
                Console.WriteLine($"{GetType().Name} inflicted {currentDamage} damage to {unit.GetType().Name}");
                _rangeWeapon.Ammunition--;
                unit.UnitInfo();
            }
        }

        public void ChangeWeapon(IBattleUnitWeapon newWeapon)
        {
            throw new NotImplementedException();
        }

        public void UnitInfo()
        {
            throw new NotImplementedException();
        }

        public void StoneSkin()
        {
            throw new NotImplementedException();
        }
    }
}
