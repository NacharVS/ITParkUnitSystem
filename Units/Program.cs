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
            var crossBow = blacksmith.ProductionCrossBow();


            ArcherTower archerTower = new ArcherTower();

            var ironShortSword = blacksmith.ProductionIronShortSword();
            var shortbow = blacksmith.ProductionShortBow();

            var footman1 = castle.CreateFootman(ironShortSword);
            var archer1 = castle.CreateArcher(ironShortSword, shortbow);

            footman1.UnitInfo();
            archer1.UnitInfo();


            //var archer2 = castle.CreateArcher(ironShortSword, shortbow);
            //var archer3 = castle.CreateArcher(ironShortSword, shortbow);
            //var archer4 = castle.CreateArcher(ironShortSword, shortbow);
            //var slinger = castle.CreateSlinger(crossBow);

            //archerTower.ReloadBuilding(archer1);
            //archerTower.ReloadBuilding(archer2);
            //archerTower.ReloadBuilding(archer3);
            //archerTower.ReloadBuilding(archer4);
            //archerTower.ReloadBuilding(slinger);

            //archerTower.DistanceAttack(footman1);

            MongoDataBase.AddArcherToDataBase(archer1);

            MongoDataBase.AddFootmanToDataBase(footman1);

            MongoDataBase.AddWeaponToDataBase(ironShortSword);

            MongoDataBase.AddUnitToDataBase(archer1);
            MongoDataBase.AddUnitToDataBase(footman1);
            
            //footman1.UnitInfo();












            //var footman2 = castle.CreateFootman(halberd);
            //footman2.UnitInfo();
            //footman1.Attack(footman2);
            //footman2.UnitInfo();
            //footman2.Attack(footman1);
            //footman1.UnitInfo();



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
