using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
    public interface IBattleUnitRemoteWeapon
    {
        public int MinDamage { get; }
        public int MaxDamage { get; }
        public int Arrow { get; set; }
        public int MaxArrow { get; set; }
    }
}
