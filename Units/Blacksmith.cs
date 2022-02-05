using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units
{
    class Blacksmith : Unit, IMovableUnit, IBufable
    {
        public Blacksmith(double currentHealth, double maxHealth)
        {
            _currentHealth = currentHealth;
            _maxHealth = maxHealth;
        }

        public int WalkingSpeed { get => 5; }

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

        public void StoneSkin()
        {
            MaxHealth += 30;
            CurrentHealth += 30;
        }

        public Halberd ProductionHalberd()
        {
            return new Halberd();
        }

        public IronShortSword ProductionIronShortSword()
        {
            return new IronShortSword();
        }

        public void UnitInfo()
        {
            Console.WriteLine($"{GetType().Name} health {CurrentHealth} maxHealth {MaxHealth}");
        }

        public void GetWound(double damage)
        {
            CurrentHealth -= damage;
        }
    }
}
