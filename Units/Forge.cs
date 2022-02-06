using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units
{
    class Forge : Unit, IBuilding
    {
        public double Wall => 500;

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public void UnitInfo()
        {
            Console.WriteLine($"health - {CurrentHealth} wall - {Wall}");
        }

        public Blacksmith CreateBlacksmith()
        {
            Console.WriteLine($"Blacksmith has been created");
            return new Blacksmith(30, 30);
            
        }

        
    }
}
