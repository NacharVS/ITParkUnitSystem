using System;
using UnitImplementation;

namespace Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var building1 = new Church();
            var building2 = new Castle();
            var shamanBoris = new Shaman();
            var weaponNew=new IBattleUnitWeapon();
            var unit = building2.CreatePeasant();
            var unit2 = building2.CreateFootman();
            unit.UnitInfo();
            building1.Blessing(unit);
            unit.UnitInfo();
            unit2.Attack(unit);
            unit.UnitInfo();
            shamanBoris.Buff(unit);
            unit.UnitInfo();
        }
    }
}
