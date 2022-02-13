using MongoDB.Driver;
using UnitImplementation;

namespace Units
{
    class MongoDataBase
    {
        public static void AddArcherToDataBase(Archer archer)
        {
            var client = new MongoClient("mongodb://localhost");
            var dataBase = client.GetDatabase("ITUnitSystem");
            var collection = dataBase.GetCollection<Archer>("Archers");
            collection.InsertOne(archer);
        }

        public static void AddFootmanToDataBase(Footman footman)
        {
            var client = new MongoClient("mongodb://localhost");
            var dataBase = client.GetDatabase("ITUnitSystem");
            var collection = dataBase.GetCollection<Footman>("Footman");
            collection.InsertOne(footman);
        }

        public static void AddUnitToDataBase(Unit unit)
        {
            var client = new MongoClient("mongodb://localhost");
            var dataBase = client.GetDatabase("ITUnitSystem");
            var collection = dataBase.GetCollection<Unit>("Unit");
            collection.InsertOne(unit);
        }

        public static void AddWeaponToDataBase(IBattleUnitWeapon weapon)
        {
            var client = new MongoClient("mongodb://localhost");
            var dataBase = client.GetDatabase("ITUnitSystem");
            var collection = dataBase.GetCollection<IBattleUnitWeapon>("Weapon");
            collection.InsertOne(weapon);

        }
    }
}
