using MongoDB.Driver;
using UnitImplementation;

namespace Units
{
    class MongoDataBase
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

        public static void AddDataBase(IUnit unit)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystemm");
            var collection = database.GetCollection<IUnit>("RangeUnits");
            collection.InsertOne(unit);
        }
    }
}