using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
    public interface IMovableUnit : IUnit
    {
        
        int WalkingSpeed { get;  }
        void Move();
    }
}
