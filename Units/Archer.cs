using System;
using UnitImplementation;
using Units.BattleUnitsItem;

namespace Units
{
    internal class Archer : Unit, IBattleUnit,IBuffable,IRangeUnit,IRangeWeapon
    {
        IRangeWeapon _rangeWeapon;
        public IBattleUnitWeapon _extraWeapon=new IronShortSword();
        private int _rangeDamage;
        private int _armor;
        private int _amunition;
        public int Armor { get => _armor; set => _armor = value; }

        public Archer(IRangeWeapon rangeWeapon)
        {
            this._rangeWeapon = rangeWeapon;
        }
        public int WalkingSpeed => 8;
        public double CurrentHealth { get => _currentHealth; set => _currentHealth=value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth=value; }
        public int Ammunition { get => _amunition; set => throw new NotImplementedException(); }
        public int RangeDamage { get => _rangeDamage; set => _rangeDamage = value; }

        public int MinDamage => throw new NotImplementedException();

        public int MaxDamage => throw new NotImplementedException();
        public IRangeWeapon RangeWeapon => _rangeWeapon;

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
            Console.WriteLine($"   {GetType().Name} health {CurrentHealth} maxHealth {MaxHealth} armor {Armor}");
        }

        public void StoneSkin()
        {
            throw new NotImplementedException();
        }

        public int RangeAttack()
        {
            var rnd = new Random();
            return RangeDamage = rnd.Next(_rangeWeapon.MinDamage, _rangeWeapon.MaxDamage);
        }
    }
}
