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
            weapon = weaponParametr;
        }
        private double _armor;
        public int WalkingSpeed => 6;
        IBattleUnitWeapon weapon;
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
            var currentDamage = rnd.Next(weapon.MinDamage, weapon.MaxDamage);
            unit.CurrentHealth-=Damage;
            Console.WriteLine($"Footman inflicted {Damage}");
            unit.UnitInfo();
        }
        public void Move()
        {
            Console.WriteLine($"Footman moving with {WalkingSpeed}");
        }
        public void UnitInfo()
        {
            Console.WriteLine($"health {CurrentHealth} maxHealth {MaxHealth} damage { Damage} stone {Armor}");
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
    }
}
