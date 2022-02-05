﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
    public interface IBattleRemoteUnit
    {
        int CurrentDamage();

        void DistanceAttack(IMovableUnit unit);

        void ChangeRemoteWeapon(IBattleUnitRemoteWeapon newBow);
    }
}
