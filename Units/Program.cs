using System;
using UnitImplementation;

namespace Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var building = new Church();
            var unit = new Castle().CreatePeasant();
            unit.UnitInfo();
            building.Blessing(unit);
            unit.UnitInfo();
        }
    }
}
