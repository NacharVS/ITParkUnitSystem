using MongoDB.Driver;
using System;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units
{
    internal class MongoDataBase
    {
        public static void AddArcherToDataBase(Archer archer)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<Archer>("RangeUnits");
            collection.InsertOne(archer);
        }

        public static void AddFootmanToDataBase(Footman footman)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<Footman>("RangeUnits");
            collection.InsertOne(footman);
        }
        public static void AddToDataBase(IUnit unit)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<IUnit>("AllUnitsInterfaces");
            collection.InsertOne(unit);
        }
        public static void AddWeaponToDataBase(IBattleUnitWeapon weapon)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<IBattleUnitWeapon>("WeaponsInterfaces");
            collection.InsertOne(weapon);
        }

        
    }
}
