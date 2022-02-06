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
            var rangeUnit = building2.CreateArcher();
            var rangeUnit2 = building2.CreateArcher();
            var rangeUnit3 = building2.CreateArcher();
            var rangeUnit4 = building2.CreateArcher();
            var rangeUnit5 = building2.CreateArcher();

            var unit = building2.CreatePeasant();
            unit.UnitInfo();
            var unit2 = building2.CreateFootman();
            unit2.UnitInfo();
            
            building1.Blessing(unit);
            unit.UnitInfo();
            var blackSmith1 = building2.CreateBlacksmith();
            blackSmith1.UnitInfo();
            blackSmith1.CreateIronShortSword();
            
            //лекция 06.02.2022
            unit2.Attack(unit);
            shamanBoris.Buff(unit);
            unit.UnitInfo();
            rangeUnit.Attack(unit);
            rangeUnit.Attack(unit);
            rangeUnit.Attack(unit);
            rangeUnit.Attack(unit);

            var archerTower = new ArcherTower();
            archerTower.LoadRangeUnit(rangeUnit);
            archerTower.LoadRangeUnit(rangeUnit2);
            archerTower.LoadRangeUnit(rangeUnit3);
            archerTower.LoadRangeUnit(rangeUnit4);
            archerTower.LoadRangeUnit(rangeUnit5);

            unit.UnitInfo();
            archerTower.Attack(unit);
            unit.UnitInfo();

            //shamanBoris.Buff(shamanBoris);
            //shamanBoris.UnitInfo();
        }
    }
}
