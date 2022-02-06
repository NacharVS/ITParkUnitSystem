using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    class ArcherTower : Unit, IBuilding, IInBuilding, IBattleRemoteUnit
    {
        List<IBattleRemoteUnit> garrison = new List<IBattleRemoteUnit>();
        public double Wall => 300;

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
        public int MaxGarrison => 10;

        public void DistanceAttack(IMovableUnit unit)
        {
            if (garrison.Count() > 0)
            {
                foreach (var item in garrison)
                {
                    item.DistanceAttack(unit);
                }
            }

            else Console.WriteLine("Garrison empty.");
        }

        public void ReloadBuilding(IBattleRemoteUnit unit)
        {
            if (garrison.Count() < MaxGarrison)
            {
                garrison.Add(unit);
            }
            else Console.WriteLine("ArcherTower is fuul.");
            
        }

        public void UnitInfo()
        {
            Console.WriteLine($"health - {CurrentHealth} wall - {Wall}");
        }
    }
}
