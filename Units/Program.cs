using System;
using UnitImplementation;
using Units.BattleUnitsItem;

namespace Units
{
    class Program
    {
        static void Main(string[] args)
        {
            //var church1 = new Church();
            var castle1 = new Castle();
            //var shamanBoris = new Shaman();
            var weaponNew = new Halberd();
            var archer1 = castle1.CreateArcher(); //создание лучников
            //lection 10.01.2022
            var footman1 = castle1.CreateFootman(); //создаем пехотинца
            MongoDataBase.AddArcherToDataBase(archer1);
            footman1.ChangeWeapon(weaponNew);
            MongoDataBase.AddFootmanToDataBase(footman1);
            MongoDataBase.AddToDataBase(castle1);
            MongoDataBase.AddWeaponToDataBase(weaponNew);
            var footman2 = castle1.CreateFootman(weaponNew);
            MongoDataBase.AddFootmanToDataBase(footman2);




            //var slinger7 = castle1.CreateSlinger(); //создание пращера
            //var archer2 = castle1.CreateArcher();
            //var archer3 = castle1.CreateArcher();
            //var archer4 = castle1.CreateArcher();
            //var archer5 = castle1.CreateArcher();
            //Console.WriteLine($"archer1 RangeDamage: {archer1.RangeAttack()}");
            //Console.WriteLine($"slinger1 RangeDamage: {slinger7.RangeAttack()}");
            //var slinger1 = castle1.CreateSlinger(); //создание пращеров
            //var slinger2 = castle1.CreateSlinger();
            //var slinger3 = castle1.CreateSlinger();
            //var slinger4 = castle1.CreateSlinger();
            //var slinger5 = castle1.CreateSlinger();
            //var slinger6 = castle1.CreateSlinger();


            //var peasant1 = castle1.CreatePeasant();
            //peasant1.UnitInfo();
            //var footman1 = castle1.CreateFootman(); //создаем пехотинца
            //footman1.UnitInfo();

            //for (int i = 0; i < 11; i++)
            //{
            //    slinger1.Attack(footman1);
            //}
            //church1.Blessing(peasant1);  //церковь колдует Благославление (+50% ХП)
            //peasant1.UnitInfo();
            //var blackSmith1 = castle1.CreateBlacksmith();
            //blackSmith1.UnitInfo();
            //blackSmith1.CreateIronShortSword();

            ////лекция 06.02.2022
            //footman1.Attack(peasant1);
            //shamanBoris.Buff(peasant1); //шаман кастует каменную кожу на крестьянина
            //peasant1.UnitInfo();
            //footman1.ChangeWeapon(weaponNew);
            //footman1.Attack(peasant1);
            //peasant1.UnitInfo();

            //archer1.Attack(peasant1);
            //archer1.Attack(peasant1);
            //archer1.Attack(peasant1);
            //archer1.Attack(peasant1);

            //var archerTower = new ArcherTower(); //создание стрелковой вышки
            //archerTower.LoadRangeUnit(archer1); //загрузка стрелков в гарнизон вышки
            //archerTower.LoadRangeUnit(archer2);
            //archerTower.LoadRangeUnit(archer3);
            //archerTower.LoadRangeUnit(archer4);
            //archerTower.LoadRangeUnit(archer5);
            //archerTower.LoadRangeUnit(slinger1);
            //archerTower.LoadRangeUnit(slinger2);
            //archerTower.LoadRangeUnit(slinger3);
            //archerTower.LoadRangeUnit(slinger4);
            //archerTower.LoadRangeUnit(slinger5);
            //archerTower.LoadRangeUnit(slinger6);

            //foreach (var item in archerTower._garrison) //показ гарнизона
            //{
            //    Console.WriteLine($"  {archerTower._garrison.IndexOf(item) + 1:00}) Garrison: {item}");
            //}
            //footman1.UnitInfo();
            //archerTower.Attack(footman1); //атака вышкой пехотинца
            //footman1.UnitInfo();
            //peasant1.UnitInfo();
            //archerTower.Attack(peasant1); //атака стрелковой вышки по крестьянину
            //peasant1.UnitInfo();

            //shamanBoris.Buff(shamanBoris);
            //shamanBoris.UnitInfo();
        }
    }
}
