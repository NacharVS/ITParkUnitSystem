using System;
using UnitImplementation;
using Units.BattleUnitsItems;
using Units;

namespace Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var castle = ClassFactory.CreateCastle();
            var blacksmith = castle.CreateBlacksmith();
            var shaman = new Shaman();
            blacksmith.UnitInfo();
            blacksmith.Move();
            shaman.Buff(blacksmith);
            blacksmith.UnitInfo();
            var halberd = blacksmith.ProductionHalberd();
            var ironShortSword = blacksmith.ProductionHalberd();

            //var building1 = new Church();

            //var shamanBoris = new Shaman();
            //var weaponNew = new Halberd();
            //var unit = building2.CreatePeasant();
            //var unit2 = building2.CreateFootman();
            //unit.UnitInfo();
            //building1.Blessing(unit);
            //unit.UnitInfo();

            //unit2.Attack(unit);
            //unit.UnitInfo();
            //shamanBoris.Buff(shamanBoris);
            //shamanBoris.UnitInfo();
        }
    }
}
