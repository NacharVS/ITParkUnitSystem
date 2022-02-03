﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
    public interface IBattleUnit : IUnit
    {
        public int Armor { get; set; }
        public double Damage { get; set; }

        void Attack(IUnit unit);


    }
}
