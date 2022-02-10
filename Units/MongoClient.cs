using System;

namespace Units
{
    internal class MongoClient
    {
        private string v;

        public MongoClient(string v)
        {
            this.v = v;
        }

        internal object GetDatabase(string v)
        {
            throw new NotImplementedException();
        }
    }
}