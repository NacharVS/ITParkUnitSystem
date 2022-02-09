using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    internal class ArcherTower : Unit, IBuilding , IBattleUnit, IRangeUnit

    {
        private int _armor;
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double Wall { get => 1500; }
        public int Armor { get => _armor; set => _armor = value; }

        private List<IRangeUnit> garnizon = new List<IRangeUnit>();
        public bool IsFull { get; set; }
        public bool CanAttack { get; private set; }
        public IRangeWeapon RangeWeapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void LoadRangeUnits(IRangeUnit rangeUnit)
        {
            if (garnizon.Count >= 10)
            {
                Console.WriteLine("Tower is full");
                IsFull = true;
            }
            else
            {
                garnizon.Add(rangeUnit);
                CanAttack = true;
            }

        }
                

        public void Attack(IUnit unit)
        {
            double currentDamage = this.RangeAttack();
            Console.WriteLine($"ArcherTower inflicted {currentDamage}");
            unit.CurrentHealth -= currentDamage;
            unit.UnitInfo(); 
        }

        public void ChangeWeapon(IBattleUnitWeapon newWeapon)
        {
            throw new NotImplementedException();
        }

        public void UnitInfo()
        {
            Console.WriteLine($"health - {CurrentHealth} wall - {Wall}");
        }

        public double RangeAttack()
        {
            double rangeDamage = 0;
            foreach (var item in garnizon)
            {
                if (item.RangeWeapon.Ammunition > 0) rangeDamage += item.RangeAttack();
            }
            return rangeDamage;
        }
    }
}
