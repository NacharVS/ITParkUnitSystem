using MongoDB.Driver;
using System.Collections.Generic;
using UnitImplementation;

namespace Units
{
    class MongoDataBase
    {
        public static void AddArcherToDataBase(Archer archer)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<Archer>("RangeUnits");
            collection.InsertOne(archer);
        }
        public static List<Archer> GeArcherFromDataBase()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<Archer>("RangeUnits");
            return collection.Find(x => true).ToList();
        }
        public static void AddFootmanToDataBase(Footman footman)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<Footman>("RangeUnits");
            collection.InsertOne(footman);
        }
        public static void AddToDataBase(IUnit unit)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<IUnit>("AllUnitsInterfaces");
            collection.InsertOne(unit);
        }
        public static void AddWeaponToDataBase(IBattleUnitWeapon weapon)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<IBattleUnitWeapon>("AllUnitsWeapons");
            collection.InsertOne(weapon);
        }
        public static List<Unit> GetAllUnitsFromCollection()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<Unit>("RangeUnits");
            return collection.Find(x=>true).ToList();
        }
    }
}
