using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    internal class Shaman : Unit, IMovableUnit
    {
        public int WalkingSpeed => throw new NotImplementedException();

        public double CurrentHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void UnitInfo()
        {
            throw new NotImplementedException();
        }
        public void Buff(IBuffable unit) 
        {
            Console.WriteLine("Casting stoneSkinSpell");
            unit.StoneSkin();
        }
    }
}
