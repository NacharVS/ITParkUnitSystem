using MongoDB.Driver;
using System.Collections.Generic;
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

        public static Archer GetSingleArcherFromDataBase(string searcName)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<Archer>("RangeUnits");
            var resuilt = collection.Find(x => x.Name == searcName).FirstOrDefault();
            if (resuilt == null)
            {
               
                return null;
            }
            else
                return resuilt;
        }

        public static List<IUnit> GetFromDataBase()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<IUnit>("RangeUnits");
            return collection.Find(x => true).ToList();
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

        public static List<Unit> GetAllUnitsFromCollection()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITParkUnitSystem");
            var collection = database.GetCollection<Unit>("AllUnitsInterfaces");
            return collection.Find(x => true).ToList();
        }
    }
}
