using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
     public class Footman : Unit, IMovableUnit, IBattleUnit, IBufable
    {
        public Footman(double currentHealth, double maxHealth, IBattleUnitWeapon weaponParameter)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
            currentWeapon = weaponParameter;
        }

        private int _armor;
        public int WalkingSpeed => 6;

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int Armor { get => _armor; set => _armor = value; }

        IBattleUnitWeapon currentWeapon;
        public void Attack(IUnit unit)
        {
            Random rnd = new Random();
            var currentDamage = rnd.Next(currentWeapon.MinDamage, currentWeapon.MaxDamage);
            Console.WriteLine($"Footman inflicted {currentDamage}");
            unit.CurrentHealth -= currentDamage;
            unit.UnitInfo();
        }

        public void StoneSkin()
        {
            Armor += 10;
            CurrentHealth += 30;
            MaxHealth += 30;
        }

        public void UnitInfo()
        {
            Console.WriteLine($"Footmans: Health- {CurrentHealth}, maxHealth- {MaxHealth} armor {Armor}");
        }

       public void Move()
        {
            Console.WriteLine($"Footman moving with {WalkingSpeed}");
        }

        
        public void ChangeWeapon(IBattleUnitWeapon newWeapon)
        {
            currentWeapon = newWeapon;
        }
    }
}
