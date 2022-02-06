using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units
{
    internal class Master : Unit, IMovableUnit //Кузнец
    {
        public Master (double currentHealth, double maxHealth)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int WalkingSpeed { get => 2; }

        public void Move()
        {
            Console.WriteLine($"Master moving with {WalkingSpeed}");
        }

        public void UnitInfo()
        {
            Console.WriteLine($"Master health {CurrentHealth} maxHealth {MaxHealth}");
        }

        public Knife CreateKnife()
        {
            return new Knife();
        }

        public Halberd CreateHalberd()
        {
            return new Halberd();
        }

        public IronShortSword CreateIronShortSword()
        {
            return new IronShortSword();
        }
    }
}
