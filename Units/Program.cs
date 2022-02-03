using System;
using UnitImplementation;

namespace Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = new Castle().CreatePeasant();
            unit.UnitInfo();
            Church.Blessing(unit);
            unit.UnitInfo();
        }
    }
}
