using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_test
{
    internal class Army
    {
        private List<InterfaceUnit> units;
        public Army() { units = new List<InterfaceUnit>(); }
        public void AddUnit(InterfaceUnit unit) { units.Add(unit); }
        public List<InterfaceUnit> GetUnit() { return units; }
        public int TotalCost()
        {
            int totalCost = 0;
            foreach (var unit in units) 
                totalCost += unit.GetCost(); 

            return totalCost;
        }
        public double GetAverageSpeed()
        {
            double totalSpeed = 0;

            if (units.Count == 0) return 0;
            foreach (var unit in units)
                totalSpeed += unit.GetSpeed();

            return totalSpeed / units.Count;
        }
    }
}
