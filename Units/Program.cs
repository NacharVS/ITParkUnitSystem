using System;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var building1 = new Church();
            var building2 = new Castle();
            var unitShaman = building2.CreateShaman();
            var unitPeasant = building2.CreatePeasant();
            var unitFootman = building2.CreateFootman(new Halberd());
            var unitArcher = building2.CreateArcher();
            var unitMaster = building2.CreateMaster();

            var weaponKnife = unitMaster.CreateKnife();

            //var weaponNew = new Halberd();
            //var rangeUnit = building2.CreateArcher();
            //var unit = building2.CreatePeasant();
            //var unit2 = building2.CreateFootman(weaponNew);
            //unit.UnitInfo();
            //building1.Blessing(unit);
            //unit.UnitInfo();
            //unit2.ChangeWeapon(weaponNew);
            //rangeUnit.Attack(unit);
            //rangeUnit.Attack(unit);
            //rangeUnit.Attack(unit);
            //rangeUnit.Attack(unit);
            //unit.UnitInfo();
            //shamanBoris.Buff(shamanBoris);
            //shamanBoris.UnitInfo();
        }
    }
}
