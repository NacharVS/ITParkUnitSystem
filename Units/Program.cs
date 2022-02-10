using System;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var building1 = new Church();
            var building2 = new Castle();
            var shamanBoris = new Shaman();
            var weaponNew = new Halberd();
            var rangeUnit = building2.CreateArcher();
            var unit = building2.CreatePeasant();
            var unit2 = building2.CreateFootman(weaponNew);

            Archer archer = MongoDataBase.GetSingleArcherFromDataBase("Ivan");
            if (archer == null)
            {
                Console.WriteLine("Not found");
            }
            else
                Console.WriteLine(archer.MaxHealth);

            //var list = MongoDataBase.GetArcherFromDataBase();
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item._currentHealth} {item._maxHealth} {item._id} {item._extraWeapon.MinDamage}");
            //}
        }
    }
}
