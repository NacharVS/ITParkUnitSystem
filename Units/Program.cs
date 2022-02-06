using System;
using UnitImplementation;
using Units.BattleUnitsItem;

namespace Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var building1 = new Church();
            var building2 = new Castle();
            var shamanBoris = new Shaman();
            var weaponNew = new Halberd();
            var rangeUnit = building2.CreateArcher(ShortBow(3));

            var unit = building2.CreatePeasant();
            unit.UnitInfo();
            var unit2 = building2.CreateFootman();
            unit2.UnitInfo();
            
            building1.Blessing(unit);
            unit.UnitInfo();
            
            unit2.Attack(unit);
            //unit.UnitInfo();
            shamanBoris.Buff(unit);
            unit.UnitInfo();
            rangeUnit.Attack(unit);
            rangeUnit.Attack(unit);
            rangeUnit.Attack(unit);
            rangeUnit.Attack(unit);

            var blackSmith1 = building2.CreateBlacksmith();
            blackSmith1.UnitInfo();
            blackSmith1.CreateIronShortSword();

            //shamanBoris.Buff(shamanBoris);
            //shamanBoris.UnitInfo();
        }
    }
}
