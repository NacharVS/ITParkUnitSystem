using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    internal class ArcherTower : Unit, IBuilding,IRangeUnit    
    {
        public  List<IRangeUnit> _garrison=new List<IRangeUnit>(); //от 1 до 10 стрелков. Атака, если хотя бы 1 стрелок. Атака складывается из кол-ва стрелков.

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
                Console.WriteLine($"  {GetType().Name} load {rangeUnit.GetType().Name} in garrison.");
                CanAttack = true;
            }
        }
        public void Attack(IUnit unit)
        {
            
            if (_garrison != null)
            {
                int totalDamage = 0;
                foreach (var item in _garrison)
                {
                    totalDamage += item.RangeAttack();
                }
                unit.CurrentHealth -= totalDamage;
                Console.WriteLine($"{GetType().Name} inflicted {totalDamage} total damage to {unit.GetType().Name}");
            }
            else
                Console.WriteLine("Garrison is empty!");
        }
        public double Wall => throw new NotImplementedException();

        public double CurrentHealth { get => 1000; set => throw new NotImplementedException(); }
        public double MaxHealth { get => 1000; set => throw new NotImplementedException(); }

        public IRangeWeapon RangeWeapon => throw new NotImplementedException();

        public int Ammunition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int RangeDamage => throw new NotImplementedException();

        public int MinDamage => throw new NotImplementedException();

        public int MaxDamage => throw new NotImplementedException();

        public void UnitInfo()
        {
            Console.WriteLine($"   {GetType().Name} health {CurrentHealth} maxHealth {MaxHealth}");
        }

        public int RangeAttack()
        {
            throw new NotImplementedException();
        }
    }
}
