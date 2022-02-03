using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    class ClassFactory
    {
        public static Castle CreateCastle()
        {
            return new Castle();
        }
    }
}
