using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    class Unit 
    {
        public ObjectId _id { get; set; }
        internal double _currentHealth;
        internal double _maxHealth;

    }
}
