using KsenomorphGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xenomorph2._0
{
    public partial class FormLore : Form
    {
        public FormLore()
        {
            InitializeComponent();
            comboBoxCommander.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void comboBoxCommander_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBoxCommander.SelectedIndex == 0)
            {
                textBoxWarLore.Text = Game.getInstance().GetFractionsLore();
            }
            if (comboBoxCommander.SelectedIndex == 1)
            {
                textBoxWarLore.Text = Game.getInstance().GetFormsOfLifeLore();
            }
            if (comboBoxCommander.SelectedIndex == 2)
            {
                textBoxWarLore.Text = Game.getInstance().GetGenesLore();
            }
            if (comboBoxCommander.SelectedIndex == 3)
            {
                textBoxWarLore.Text = Game.getInstance().GetPlanetsLore();
            }
            if (comboBoxCommander.SelectedIndex == 4)
            {
                textBoxWarLore.Text = Game.getInstance().GetSpaceFleetLore();
            }
        }

        private void comboBoxCommander_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
