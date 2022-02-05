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
        List<IBattleRemoteUnit> garrisonArchers = new List<IBattleRemoteUnit>();
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

        public void ChangeRemoteWeapon(IBattleUnitRemoteWeapon newBow)
        {
            throw new NotImplementedException();
        }

        public int CurrentDamage()
        {
            int currentDamage = 0;
            foreach (var item in garrisonArchers)
            {
                currentDamage += item.CurrentDamage();
            }
            return currentDamage;
        }

        public void DistanceAttack(IMovableUnit unit)
        {
            if (garrisonArchers.Count() > 0)
            {
               Console.WriteLine($"{GetType().Name} shoots with a bow {CurrentDamage()}");
               unit.GetWound(CurrentDamage());
            }
            else Console.WriteLine("Garrison empty.");
        }

        public void ReloadBuilding(IBattleRemoteUnit unit)
        {
            garrisonArchers.Add(unit);
        }

        public void UnitInfo()
        {
            Console.WriteLine($"health - {CurrentHealth} wall - {Wall}");
        }
    }
}
