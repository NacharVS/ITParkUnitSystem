using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    class Archer : Unit, IMovableUnit, IBattleUnit, IBattleRemoteUnit, IBufable
    {
        private int _armor;
        IBattleUnitWeapon currentWeapon;
        IBattleUnitRemoteWeapon currentRemoteWeapon;
        
        public Archer(double currentHealth, double maxHealth, IBattleUnitWeapon weapon, IBattleUnitRemoteWeapon remoteWeapon)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
            currentWeapon = weapon;
            currentRemoteWeapon = remoteWeapon;
        }

        public int WalkingSpeed => 7;

        public double CurrentHealth
        {
            get => _currentHealth;
            set
            {
                if (value >= MaxHealth)
                {
                    _currentHealth = MaxHealth;
                }
                else if (value <= 0)
                {
                    _currentHealth = 0;
                }
                else _currentHealth = value;
            }
        }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int Armor { get => _armor; set => _armor = value; }

        public void Attack(IMovableUnit unit)
        {
            if (currentWeapon != null)
            {
                Random rnd = new Random();
                var currentDamage = rnd.Next(currentWeapon.MinDamage, currentWeapon.MaxDamage);
                Console.WriteLine($"{GetType().Name} inflicted {currentDamage}");
                unit.GetWound(currentDamage);
            }

        }

        public int CurrentDamage()
        {
            Random rnd = new Random();
            var currentDamage = rnd.Next(currentRemoteWeapon.MinDamage, currentRemoteWeapon.MaxDamage);
            return currentDamage;
        }

        public void DistanceAttack(IMovableUnit unit)
        {
            if (currentRemoteWeapon != null)
            {
                if (currentRemoteWeapon.Arrow > 0)
                {
                    currentRemoteWeapon.Arrow -= 1;
                    Console.WriteLine($"{GetType().Name} shoots with a bow {CurrentDamage()}");
                    unit.GetWound(CurrentDamage());
                }
                else Console.WriteLine("Arrow is run out.");
            }

        }
        public void ChangeWeapon(IBattleUnitWeapon newWeapon)
        {
            currentWeapon = newWeapon;
        }

        public void ChangeRemoteWeapon(IBattleUnitRemoteWeapon newWeapon)
        {
            currentRemoteWeapon = newWeapon;
        }
        public void GetWound(double damage)
        {
            CurrentHealth -= damage;
        }

        public void Move()
        {
            Console.WriteLine($"{GetType().Name} moving with {WalkingSpeed}");
        }

        public void StoneSkin()
        {
            Armor += 2;
            MaxHealth += 10;
            CurrentHealth += 10;
        }

        public void UnitInfo()
        {
            Console.WriteLine($"{GetType().Name} health {CurrentHealth} maxHealth {MaxHealth} armor {Armor}");
        }

        
    }
}
