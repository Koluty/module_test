using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_test
{
    internal abstract class Unit : InterfaceUnit
    {
        protected int cost { get; set; }
        protected int speed { get; set; }
        protected string name { get; set; }

        public abstract int GetCost();
        public abstract int GetSpeed();
        public abstract string GetName();
    }
}
