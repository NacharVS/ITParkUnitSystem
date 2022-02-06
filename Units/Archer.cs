using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    public class Archer : Unit, IMovableUnit, IBattleUnit, IBufable
    {
        private int _armor;
        public int Armor { get => _armor; set => _armor = value; }
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public int WalkingSpeed => 5;

        IBattleUnitWeapon currentWeapon;
        public Archer(double currentHealth, double maxHealth, IBattleUnitWeapon weaponParameter)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
            currentWeapon = weaponParameter;
        }
       
        public void Attack(IUnit unit)
        {
            Random rnd = new Random();
            var currentDamage = rnd.Next(currentWeapon.MinDamage, currentWeapon.MaxDamage);
            Console.WriteLine($"Archer inflicted {currentDamage}");
            unit.CurrentHealth -= currentDamage;
            unit.UnitInfo();
        }

        public void ChangeWeapon(IBattleUnitWeapon newWeapon)
        {
            currentWeapon = newWeapon;
        }

        public void Move()
        {
            Console.WriteLine($"Archer moving with {WalkingSpeed}");
        }

        public void StoneSkin()
        {
            Armor += 10;
            CurrentHealth += 30;
            MaxHealth += 30;
        }

        public void UnitInfo()
        {
            Console.WriteLine($"{GetType().Name}: Health- {CurrentHealth}, maxHealth- {MaxHealth} armor {Armor}");
        }
    }
}
