using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    class Peasant : Unit, IMovableUnit, IBufable
    {
        public Peasant(double currentHealth, double maxHealth)
        {
            _currentHealth = currentHealth;
            _maxHealth = maxHealth;
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
        public int WalkingSpeed { get => 5;  }

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
            MaxHealth += 30;
            CurrentHealth += 30;
        }

        public void UnitInfo()
        {
            Console.WriteLine($"Peasants health {CurrentHealth} maxHealth {MaxHealth}");
        }
    }
}
