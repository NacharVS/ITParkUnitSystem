using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    public class Forge : Unit, IBuilding
    {
        public double Wall => 300;

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public void UnitInfo()
        {
            Console.WriteLine($"{GetType().Name}: health - {CurrentHealth}, wall - {Wall}");
        }
        public IronShortSword CreateIronSword()
        {
            return new IronShortSword();
        }
        public Halberd CreateHalberd()
        {
            return new Halberd();
        }
    }
}
