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
        public double Wall => throw new NotImplementedException();

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public void UnitInfo()
        {
            throw new NotImplementedException();
        }

        public IronShortSword CreateIronSword()
        {
            return new IronShortSword(2, 6);
        }
    }
}
