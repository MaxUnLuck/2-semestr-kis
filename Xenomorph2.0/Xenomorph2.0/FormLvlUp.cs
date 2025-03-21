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
    public partial class FormLvlUp : Form
    {
        public FormLvlUp()
        {
            InitializeComponent();
            textBoxLvlStats.Text = Game.getInstance().GetStatsLvlLore();
            textBoxSkillPoits.Text = Convert.ToString(Game.getInstance().skillPoints);
            numericUpDownLVL1.Minimum = Game.getInstance().lvlMissChance + 1;
            numericUpDownLVL2.Minimum = Game.getInstance().lvlKritChance + 1;
            numericUpDownLVL3.Minimum = Game.getInstance().lvlKritNum + 1;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (!Game.getInstance().PlayerLVLUP(Convert.ToInt32(numericUpDownLVL1.Value - 1), Convert.ToInt32(numericUpDownLVL2.Value - 1), Convert.ToInt32(numericUpDownLVL3.Value - 1)))
            {
                MessageBox.Show("Вам не хватает очков прокачки!", "Забыли?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxLvlStats.Text = Game.getInstance().GetStatsLvlLore();
            textBoxSkillPoits.Text = Convert.ToString(Game.getInstance().skillPoints);
            numericUpDownLVL1.Minimum = Game.getInstance().lvlMissChance + 1;
            numericUpDownLVL2.Minimum = Game.getInstance().lvlKritChance + 1;
            numericUpDownLVL3.Minimum = Game.getInstance().lvlKritNum + 1;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
