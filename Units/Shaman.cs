using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    class Shaman : Unit, IMovableUnit, IBufable
    {
        public Shaman(double currentHealth, double maxHealth)
        {
            _currentHealth = currentHealth;
            _maxHealth = maxHealth;
        }

        public int WalkingSpeed => throw new NotImplementedException();

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

        public void Move()
        {
            Console.WriteLine($"{GetType().Name} moving with {WalkingSpeed}");
        }

        public void UnitInfo()
        {
            Console.WriteLine($"{GetType().Name} health {CurrentHealth} maxHealth {MaxHealth}");
        }

        public void Buff(IBufable unit)
        {
            Console.WriteLine("casting stoneSkinSpell");
            unit.StoneSkin();
        }

        public void StoneSkin()
        {
            CurrentHealth += 30;
            MaxHealth += 30;
        }

        public void GetWound(double damage)
        {
            CurrentHealth -= damage;
        }
    }
}
