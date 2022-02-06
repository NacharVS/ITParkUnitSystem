using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    internal class ArcherTower : Unit, IBuilding
    {
        private List<IRangeUnit> _garrison; //от 1 до 10 стрелков. Атака, если хотя бы 1 стрелок. Атака складывается из кол-ва стрелков.

        public ArcherTower()
        {
            IsFull = false;
            CanAttack = false;
        }

        public bool IsFull { get; set; }
        public bool CanAttack { get; private set; }
        public void LoadRangeUnit(IRangeUnit rangeUnit) //load range units
        {
            if (_garrison.Count >= 10)
            {
                Console.WriteLine("ArcherTower is full");
                IsFull = true;
            }
            else
            {
                _garrison.Add(rangeUnit);
                CanAttack = true;
            }
        }
        public double Attack(Random rnd) //attack
        {
            double totalDamage = 0;
            foreach (var item in _garrison)
            {
                totalDamage += 2;
                //totalDamage += item.RangeAttack(rnd);
            }
            return totalDamage;
        }
        public void Attack(IUnit unit, int Garrison)
        {
            if (Garrison == null)
            {
                int multipleDamage = _garrison.Count;
                var currentDamage = 2 * multipleDamage;
                unit.CurrentHealth -= currentDamage;
                Console.WriteLine($"{GetType().Name} inflicted {currentDamage} damage to {unit.GetType().Name}");
                unit.UnitInfo();
            }
            else
                Console.WriteLine("Garrison is empty!");
        }
        public double Wall => throw new NotImplementedException();

        public double CurrentHealth { get => 1000; set => throw new NotImplementedException(); }
        public double MaxHealth { get => 1000; set => throw new NotImplementedException(); }

        public void UnitInfo()
        {
            Console.WriteLine($"   {GetType().Name} health {CurrentHealth} maxHealth {MaxHealth}");
        }
    }
}
