using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
   public interface IBattleRangeUnit: IRangeWeapon
    {
        void Attack(IUnit unit);

        void RangeDamage(IUnit unit);
        asdf
    }
}
