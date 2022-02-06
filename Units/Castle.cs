using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    public class Castle : Unit, IBuilding
    {
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double Wall { get => 1000; }

        public Peasant CreatePeasant()
        {
            return new Peasant(30, 30);
        }


        public Archer CreateArcher()
        {
            return new Archer (50, 60, new BowAndArrows());
        }
        public Footman CreateFootman()
        {
            return new Footman(60, 60, new IronShortSword());
        }
        public Shooter CreateShooter()
        {
            return new Shooter(60, 60, new IronShortSword());
        }
        public void UnitInfo()
        {
            Console.WriteLine($"{GetType().Name}: health - {CurrentHealth}, wall - {Wall}");
        }
    }
}
