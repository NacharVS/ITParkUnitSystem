using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    class Footman : Unit, IMovableUnit, IBattleUnit, IBattleUnitWeapon
    {
        public Footman(double currentHealth, double maxHealth, IBattleUnitWeapon weaponParametr)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
            currentWeapon = weaponParametr;
        }
        private double _armor;
        public int WalkingSpeed => 6;
        IBattleUnitWeapon currentWeapon;
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int Damage { get => 7; set => throw new NotImplementedException(); }
        public double Armor { get => _armor; set => _armor=value; }
        int IBattleUnit.Armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int MinDamage => throw new NotImplementedException();

        public int MaxDamage => throw new NotImplementedException();

        public void Attack(IUnit unit)
        {
            var rnd=new Random();
            var currentDamage = rnd.Next(currentWeapon.MinDamage, currentWeapon.MaxDamage);
            unit.CurrentHealth -= currentDamage;
            Console.WriteLine($"{GetType().Name} inflicted {currentDamage} damage to {unit.GetType().Name}");
            unit.UnitInfo();
        }
        public void Move()
        {
            Console.WriteLine($"Footman moving with {WalkingSpeed}");
        }
        public void UnitInfo()
        {
            Console.WriteLine($"   {GetType().Name} health {CurrentHealth} maxHealth {MaxHealth} damage { Damage} armor {Armor}");
        }
        public void StoneSkin()
        {
            Armor += 10;
            CurrentHealth += 30;
            MaxHealth+=30;
        }

        public void IUnit()
        {
            throw new NotImplementedException();
        }

        public void ChangeWeapon(IBattleUnitWeapon weapon)
        {
            throw new NotImplementedException();
        }
    }
}
