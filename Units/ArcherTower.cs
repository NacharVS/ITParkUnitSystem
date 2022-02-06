using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    internal class ArcherTower : Unit, IBuilding , IBattleUnit

    {
        private int _armor;
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double Wall { get => 1500; }
        public int Armor { get => _armor; set => _armor = value; }

        private List<Archer> archers = new List<Archer>();
        public bool IsFull { get; set; }
        public bool CanAttack { get; private set; }

        public void LoadArchers(Archer archer)
        {
            if (archers.Count >= 10)
            {
                Console.WriteLine("Tower is full");
                IsFull = true;
            }
            else
            {
                archers.Add(archer);
                CanAttack = true;
            }

        }
                

        public void Attack(IUnit unit)
        {
            foreach (var item in archers)
            {
                item.Attack(unit);
            }
            
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
    }
}
