
using MongoDB.Driver;

namespace Units
{
    class MongoDataBase
    {
        public static void AddArcherToDataBase(Archer archer)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ITUnitSystem");
            var collection = database.GetCollection<Archer>("RangeUnits");
            collection.InsertOne(archer);
        }
    }
}
