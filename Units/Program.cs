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
            //var weaponNew = new Halberd();
            var unit = building2.CreatePeasant();
            var unit2 = building2.CreateFootman();
            unit.UnitInfo();
            building1.Blessing(unit);
            unit.UnitInfo();
            
            unit2.Attack(unit);
            unit.UnitInfo();
            shamanBoris.Buff(shamanBoris);
            shamanBoris.UnitInfo();

            var building3 = new Forge();
            var smith = building3.CreateBlacksmith();
            smith.UnitInfo();
            var ironShortSword = smith.CreateIronShortSword();
            var halberd = smith.CreateHalberd();
            Console.WriteLine();

            var archer1 = building2.CreateArcher(1);
            var archer2 = building2.CreateArcher(2);
            var archer3 = building2.CreateArcher();
            var slinger1 = building2.CreateSlinger(2);
            var slinger2 = building2.CreateSlinger(3);

            //var archerTower = new ArcherTower();
            //archerTower.LoadRangeUnits(archer1);
            //archerTower.LoadRangeUnits(archer2);
            //archerTower.LoadRangeUnits(archer3);
            //archerTower.LoadRangeUnits(slinger1);
            //archerTower.LoadRangeUnits(slinger2);

            //archerTower.Attack(unit2);
            //archerTower.Attack(unit2);
            //archerTower.Attack(unit2);
            //archerTower.Attack(unit2);  //было в луках по 3 стрелы, не должна атаковать
            //MongoDataBase.AddArcherToDataBase(archer1);
            //MongoDataBase.AddFootmanToDataBase(unit2);
            //MongoDataBase.AddToDataBase(unit);
            //MongoDataBase.AddToDataBase(shamanBoris);
            //MongoDataBase.AddToDataBase(building1);
            //MongoDataBase.AddToDataBase(building2);
            //MongoDataBase.AddToDataBase(archer1);
            //MongoDataBase.AddWeaponToDataBase(archer1._extraWeapon);
            //MongoDataBase.AddWeaponToDataBase(archer1.RangeWeapon);
            //MongoDataBase.AddWeaponToDataBase(archer2._extraWeapon);
            //MongoDataBase.AddWeaponToDataBase(archer1.RangeWeapon);
            //MongoDataBase.AddWeaponToDataBase(ironShortSword);
            //MongoDataBase.AddWeaponToDataBase(halberd);
            MongoDataBase.AddWeaponToDataBase(slinger1.RangeWeapon);
            MongoDataBase.AddWeaponToDataBase(slinger2.RangeWeapon);
        }
    }
}


//private List</*IRangeUnit*/> garnizon;

//1. Переделать интерфейс iRangeWEapon. Добавить свойства rangeDamage, и добавить метода дальней атаки возвращающий урон
//2 создать итерфейс IRangeUnit, для всех дальнобойных юнитов. Здесь реализовать свойство типа IRangeWeapon, и, метод для атаки
//3 перенаследовать дальнобойных юнитов от нового интерфейса и реализовать его
// 3.5 создать внутренний метод для башни с загрузкой дальнобойных юнитов в гарнизон
//4 Башню наследует от IrangeUnit и реализовываем подсчет суммарного урона от всех юнитов в гарнизоне
//4.1 Создаем для башни метод подсчета суммарного урона, с возвращаемым значением. 

//* не запрещено менять текущие интерфейсы/классы.