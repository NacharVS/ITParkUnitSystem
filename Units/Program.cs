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
            ArcherTower archerTower = new ArcherTower();

         

            var unit = building2.CreatePeasant();
            var unit2 = building2.CreateFootman(weaponNew);
            unit2.UnitInfo();
            unit.UnitInfo();
            unit2.Attack(unit);
          
            unit.UnitInfo();
            shamanBoris.UnitInfo();
            shamanBoris.Buff(shamanBoris);
            shamanBoris.UnitInfo();
            var archer = building2.CreateArcher();
            archer.UnitInfo();
            archer.RangeUnitAttack(unit2);
            unit2.UnitInfo();
            archer.UnitInfo();
            archer.RangeUnitAttack(unit2);
            unit2.UnitInfo();
            archer.RangeUnitAttack(unit2);

            archerTower.LoadingUnit(archer); 
            archerTower.LoadingUnit(archer);
            archerTower.LoadingUnit(archer);
            archerTower.RangeWeaponAttack();




        }
    }
}
