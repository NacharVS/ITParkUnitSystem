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
            var shamanBoris = new Shaman();
            var weaponNew = new Halberd();
            var rangeUnit = building2.CreateArcher();
            var unit = building2.CreatePeasant();
            var unit2 = building2.CreateFootman(weaponNew);
            unit.UnitInfo();
            building1.Blessing(unit);
            unit.UnitInfo();
            unit2.ChangeWeapon(weaponNew);
            rangeUnit.Attack(unit);
            rangeUnit.Attack(unit);
            rangeUnit.Attack(unit);
            rangeUnit.Attack(unit);
            unit.UnitInfo();
            shamanBoris.Buff(shamanBoris);
            shamanBoris.UnitInfo();
        }
    }
}
