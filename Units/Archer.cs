using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units 
{
    internal class Archer : Unit, IMovableUnit, IBattleUnit, IBufable
    {
        List<IBattleUnitWeapon> weapons = new List<IBattleUnitWeapon>();
        public Archer(double currentHealth, double maxHealth, IBattleUnitWeapon weaponParameter)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
            currentWeapon = weaponParameter;
            weapons.Add(weaponParameter);
        }
        public int WalkingSpeed => 6;

        private int _armor;
        
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int Armor { get => _armor; set => _armor = value; }

        IBattleUnitWeapon currentWeapon;

        public void Attack(IUnit unit)
        {
            if (currentWeapon != null)
            {
                Random rnd = new Random();
                var currentDamage = rnd.Next(currentWeapon.MinDamage, currentWeapon.MaxDamage);
                Console.WriteLine($"Footman inflicted {currentDamage}");
                unit.CurrentHealth -= currentDamage;
                unit.UnitInfo();
            }
            
        }

        public void ChangeWeapon(IBattleUnitWeapon newWeapon)
        {
            currentWeapon = newWeapon;
            weapons.Add(newWeapon);
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
            Console.WriteLine($"{GetType().Name} health {CurrentHealth} maxHealth {MaxHealth}");
        }
    }
}
