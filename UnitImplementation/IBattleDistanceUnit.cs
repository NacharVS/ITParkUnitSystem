using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
    interface IBattleDistanceUnit
    {
        void DistanceAttack(IMovableUnit unit);

        void ChangeBow(IBattleUnitBow newBow);
    }
}
