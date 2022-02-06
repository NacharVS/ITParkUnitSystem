using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItem;

namespace Units
{
    internal class Blacksmith : Unit, IMovableUnit, IBuffable
    {
        public Blacksmith(double currentHealth, double maxHealth)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int WalkingSpeed { get => 5; }

        public IronShortSword CreateIronShortSword()
        {
            Console.WriteLine($"{GetType().Name} create the IronShortSword");
            return new IronShortSword();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void StoneSkin()
        {
            throw new NotImplementedException();
        }

        public void UnitInfo()
        {
            Console.WriteLine($"   {GetType().Name} health {CurrentHealth} maxHealth {MaxHealth}");
        }
    }
}
