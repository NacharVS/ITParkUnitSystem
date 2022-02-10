using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItem;

namespace Units
{
    class Castle : Unit, IBuilding
    {
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double Wall { get => 1000; }

        public Slinger CreateSlinger() //создание Пращера
        {
            Console.WriteLine($"{GetType().Name} create the Slinger");
            return new Slinger(new Stone(6));
        }
        public Archer CreateArcher() //создание Лучника
        {
            Console.WriteLine($"{GetType().Name} create the Archer");
            return new Archer(new ShortBow(3));
        }
        public Blacksmith CreateBlacksmith() //создание Кузнеца
        {
            Console.WriteLine($"{GetType().Name} create the Blacksmith");
            return new Blacksmith(45, 45);
        }
        public Peasant CreatePeasant() //создание Крестьянина
        {
            Console.WriteLine($"{GetType().Name} create the Peasant");
            return new Peasant(30, 30);
        }
        public Footman CreateFootman() //создание Пехотинца
        {
            Console.WriteLine($"{GetType().Name} create the Footman");
            return new Footman(60, 60, new IronShortSword());
        }
        public Footman CreateFootman(IBattleUnitWeapon weapon) //создание Пехотинца
        {
            Console.WriteLine($"{GetType().Name} create the Footman");
            return new Footman(60, 60, weapon);
        }
        public void UnitInfo()
        {
            Console.WriteLine($"{GetType().Name} health - {CurrentHealth} wall - {Wall}");
        }
        public void ChangeWeapon(IBattleUnitWeapon weapon)
        {

        }
    }
}
