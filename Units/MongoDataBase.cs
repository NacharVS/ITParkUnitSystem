using MongoDB.Driver;

namespace Units
{
    class MongoDataBase
    {
        public static void AddArcherToDataBace(Archer archer)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var databace = client.GetDatabase("ITParkUnitSystem");
            var collection = databace.GetCollection<Archer>("RangeUnits");
            collection.InsertOne(archer);

        }

    }


}
