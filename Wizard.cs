using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_test
{
    internal class Wizard : Unit
    {
        private int MagicPowder { get; set; }

        public Wizard()
        {
            cost = 5;
            speed = 5;
            name = "Чарівник";
            MagicPowder = 1;
        }
        public override int GetCost() { return cost; }
        public override int GetSpeed() { return speed; }
        public override string GetName() { return name; }
        public int GetMagicPowder() { return MagicPowder; }
    }
}
