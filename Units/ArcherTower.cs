﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
    class ArcherTower
    {
        private List</*IRangeUnit*/> garnizon;

        //1. Переделать интерфейс iRangeWEapon. Добавить свойства rangeDamage, и добавить метода дальней атаки возвращающий урон
        //2 создать итерфейс IRangeUnit, для всех дальнобойных юнитов. Здесь реализовать свойство типа IRangeWeapon, и, метод для атаки
        //3 перенаследовать дальнобойных юнитов от нового интерфейса и реализовать его
        // 3.5 создать внутренний метод для башни с загрузкой дальнобойных юнитов в гарнизон
        //4 Башню наследует от IrangeUnit и реализовываем подсчет суммарного урона от всех юнитов в гарнизоне
        //4.1 Создаем для башни метод подсчета суммарного урона, с возвращаемым значением. 

        //* не запрещено менять текущие интерфейсы/классы.
    }
}