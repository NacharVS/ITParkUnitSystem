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
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }

        public int WalkingSpeed { get => 5; }

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public void Move()
        {
            Console.WriteLine($"{GetType().Name} moving with {WalkingSpeed}");
        }

        public void StoneSkin()
        {
            CurrentHealth += 30;
            MaxHealth += 30;
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
    }
}
