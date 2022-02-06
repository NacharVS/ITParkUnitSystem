using System;
using UnitImplementation;

namespace Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var building1 = new Church();
            building1.UnitInfo();
            var building2 = new Castle();
            var shamanBoris = new Shaman();
            var weaponNew = new Halberd();
            var unit = building2.CreatePeasant();
            var unit2 = building2.CreateFootman();
            unit.UnitInfo();
            unit2.Attack(unit);
          
            unit.UnitInfo();
            shamanBoris.UnitInfo();
            shamanBoris.Buff(shamanBoris);
            shamanBoris.UnitInfo();
        }
    }
}
