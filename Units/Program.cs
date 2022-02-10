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
            MongoDataBase.AddToDataBase(unit);
            MongoDataBase.AddToDataBase(unit2);
            MongoDataBase.AddToDataBase(rangeUnit);
            MongoDataBase.AddToDataBase(building2);
        }
    }
}
