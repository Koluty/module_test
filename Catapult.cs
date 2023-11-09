using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_test
{
    internal class Catapult : Unit
    {
        public Catapult()
        {
            name = "Катапульта";
            cost = 0;
            speed = 3;
        }

        public override int GetCost() { return cost; }
        public override int GetSpeed() { return speed; }
        public override string GetName() { return name; }
    }
}
