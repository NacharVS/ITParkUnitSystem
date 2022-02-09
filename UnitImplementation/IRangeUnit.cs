using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
    public interface IRangeUnit : IUnit,IRangeWeapon
    {
        public IRangeWeapon RangeWeapon { get; }
        void Attack(IUnit unit);
    }
}
