using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    class ArcherTower: IRangeUnit
    {
        
        private List<IRangeUnit> garnizon=new List<IRangeUnit>();

        public IRangeWeapon RangeWeapon => throw new NotImplementedException();

        public void UpLoadRangeUnit (IRangeUnit rangeUnit)
        {
            if (garnizon.Count <10)
            { 
                garnizon.Add(rangeUnit);
            }
            else
            {
                Console.WriteLine($"ArcherTower is full");
            }
            
        }


        public void Attack(IUnit unit)
        {
            if (garnizon.Any()) //условие если в горнизоне есть RangeUnit
            {
               
                    var currentDamage = RangeDamage();
                    Console.WriteLine($"ArcherTower inflicted {currentDamage}");
                    unit.CurrentHealth -= currentDamage;
                    unit.UnitInfo();
            }
            else
            {
                Console.WriteLine($"ArcherTower is empty");
            }
        }

        public int RangeDamage()
        {
            int damage = 0;
            foreach (var item in garnizon)
            {
               damage += item.RangeDamage();
                item.RangeWeapon.Ammunition--; 
            }
            return damage;
        }

        //1. Переделать интерфейс iRangeWEapon. Добавить свойства rangeDamage, и добавить метода дальней атаки возвращающий урон
        //2 создать итерфейс IRangeUnit, для всех дальнобойных юнитов. Здесь реализовать свойство типа IRangeWeapon, и, метод для атаки
        //3 перенаследовать дальнобойных юнитов от нового интерфейса и реализовать его
        // 3.5 создать внутренний метод для башни с загрузкой дальнобойных юнитов в гарнизон
        //4 Башню наследует от IrangeUnit и реализовываем подсчет суммарного урона от всех юнитов в гарнизоне
        //4.1 Создаем для башни метод подсчета суммарного урона, с возвращаемым значением. 

        //* не запрещено менять текущие интерфейсы/классы.
    }
}
