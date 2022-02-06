﻿using System;
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
            var unit = building2.CreatePeasant();
            var unit2 = building2.CreateFootman();
            var unit3 = building2.CreateMaster();
            
            var weapon1 = unit3.CreateKnife();
            unit2.ChangeWeapon(weapon1);
            unit.UnitInfo();
            unit2.UnitInfo();
            unit3.UnitInfo();
            //building1.Blessing(unit);
            //unit.UnitInfo();

            unit2.Attack(unit);
            //unit.UnitInfo();
            //shamanBoris.Buff(shamanBoris);
            //shamanBoris.UnitInfo();
        }
    }
}
