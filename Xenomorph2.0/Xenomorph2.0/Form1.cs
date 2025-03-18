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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Game.getInstance();
            Game.getInstance().GameLoad();
            listBoxFraction.Items.Clear();
            for (int i = 0; i < Game.getInstance().GetActiveFractions().Count; i++) {
                listBoxFraction.Items.Add(Game.getInstance().GetActiveFractions()[i]);
            }
        }

        private void buttonWar_Click(object sender, EventArgs e)
        {
            war war = new war();
            war.Show();
            listBoxFraction.Items.Clear();
            for (int i = 0; i < Game.getInstance().GetActiveFractions().Count; i++)
            {
                listBoxFraction.Items.Add(Game.getInstance().GetActiveFractions()[i]);
            }
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            Game.getInstance().PlayerSkip();
            listBoxFraction.Items.Clear();
            for (int i = 0; i < Game.getInstance().GetActiveFractions().Count; i++)
            {
                listBoxFraction.Items.Add(Game.getInstance().GetActiveFractions()[i]);
            }
        }

        private void listBoxFraction_Click(object sender, EventArgs e)
        {
            textBoxFractionLore.Text = Game.getInstance().GetLoreFraction(listBoxFraction.SelectedIndex);
        }
    }
}
