using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units
{
    class Castle : Unit, IBuilding
    {
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double Wall { get => 1000; }
        public string _t { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Peasant CreatePeasant()
        {
            return new Peasant(30, 30);
        }

        public Footman CreateFootman(IBattleUnitWeapon weapon)
        {
            return new Footman(60, 60, weapon);
        }

        public Archer CreateArcher()
        {
            return new Archer(new ShortBow(3), "Legolas");
        }

        public void UnitInfo()
        {
            Console.WriteLine($"health - {CurrentHealth} wall - {Wall}");
        }
    }
}
