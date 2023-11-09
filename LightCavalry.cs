using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_test
{
    internal class LightCavalry : Unit
    {
        public LightCavalry()
        {
            name = "Легка кавалерія";
            cost = 5;
            speed = 15;
        }
        public override int GetCost() { return cost; }
        public override int GetSpeed() { return speed; }
        public override string GetName() { return name; }
    }
}
