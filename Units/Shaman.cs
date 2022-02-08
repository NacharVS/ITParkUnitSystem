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
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }
        public int WalkingSpeed => throw new NotImplementedException();

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public void Move()
        {
            throw new NotImplementedException();
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
    }
}
