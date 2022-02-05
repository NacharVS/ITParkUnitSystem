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
            var shaman = new Shaman(40, 40);
            blacksmith.UnitInfo();
            blacksmith.Move();
            shaman.Buff(blacksmith);
            blacksmith.UnitInfo();
            var halberd = blacksmith.ProductionHalberd();
            var ironShortSword = blacksmith.ProductionHalberd();

            var footman1 = castle.CreateFootman(ironShortSword);
            footman1.UnitInfo();
            var footman2 = castle.CreateFootman(halberd);
            footman2.UnitInfo();
            footman1.Attack(footman2);
            footman2.UnitInfo();
            footman2.Attack(footman1);
            footman1.UnitInfo();
            


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
