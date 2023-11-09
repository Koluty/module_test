using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Army army = new Army();

            for (int i = 0; i < (int)numberWizard.Value; i++)
                army.AddUnit(new Wizard());
            
            for (int i = 0; i < (int)numberLightCavalery.Value; i++)
                army.AddUnit(new LightCavalry());

            for (int i = 0; i < (int)numberCatapult.Value; i++)
                army.AddUnit(new Catapult());

            dataGridView1.Rows.Clear();
            foreach (var unit in army.GetUnit())
            {
                if(unit is Wizard wizard)
                {
                    dataGridView1.Rows.Add(wizard.GetName(), "Золото = " + wizard.GetCost().ToString() + ", Магічний порошок = " + wizard.GetMagicPowder(), wizard.GetSpeed().ToString());
                }
                if (unit is LightCavalry lightCavalary)
                {
                    dataGridView1.Rows.Add(lightCavalary.GetName(), "Золото = " + lightCavalary.GetCost().ToString(), lightCavalary.GetSpeed());
                }
                if (unit is Catapult catapult)
                {
                    dataGridView1.Rows.Add(catapult.GetName(), "Золото = " + catapult.GetCost().ToString(), catapult.GetSpeed());
                }
            }
            dataGridView1.Rows.Add("","Загальна вартість", "Загальна швидкість");
            dataGridView1.Rows.Add("",army.TotalCost(),army.GetAverageSpeed());
        }
    }
}
