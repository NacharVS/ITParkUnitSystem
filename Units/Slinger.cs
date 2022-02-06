using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    class Slinger : Unit, IMovableUnit, IBufable, IBattleRemoteUnit
    {
        private IBattleUnitRemoteSimpleWeapon currentRemoteWeapon;
        public Slinger(double currentHealth, double maxHealth, IBattleUnitRemoteSimpleWeapon remoteWeapon)
        {
            _currentHealth = currentHealth;
            _maxHealth = maxHealth;
            currentRemoteWeapon = remoteWeapon;
        }

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
        public int WalkingSpeed { get => 5; }

        public void DistanceAttack(IMovableUnit unit)
        {
            if (currentRemoteWeapon != null)
            {
                if (currentRemoteWeapon.Arrow > 0)
                {
                    Random rnd = new Random();
                    var currentDamage = rnd.Next(currentRemoteWeapon.MinDamage, currentRemoteWeapon.MaxDamage);
                    currentRemoteWeapon.Arrow -= 1;
                    Console.WriteLine($"{GetType().Name} shoots with a bow {currentDamage}");
                    unit.GetWound(currentDamage);
                }
                else Console.WriteLine("Arrow is run out.");
            }

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
            MaxHealth += 10;
            CurrentHealth += 10;
        }

        public void UnitInfo()
        {
            Console.WriteLine($"Slinger health {CurrentHealth} maxHealth {MaxHealth}");
        }
    }
}
