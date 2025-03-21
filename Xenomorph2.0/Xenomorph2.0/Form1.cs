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
        public void UpdateFraction()
        {
            listBoxFraction.Items.Clear();
            Game.getInstance().UpdateActiveFraction();
            for (int i = 0; i < Game.getInstance().GetActiveFractions().Count; i++)
            {
                listBoxFraction.Items.Add(Game.getInstance().GetActiveFractions()[i]);
            }
        }
        public Form1()
        {
            InitializeComponent();
            Game.getInstance();
            Game.getInstance().GameLoad();
            UpdateFraction();
        }
        private void buttonWar_Click(object sender, EventArgs e)
        {
            
            if (!Game.getInstance().GetIsAtacked())
            {
                war war = new war();
                war.Show();
                
            }
            else
            {
                MessageBox.Show("Вы уже воевали в этом ходе!", "Забыли?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateFraction();
            textBoxStep.Text = Convert.ToString(Game.getInstance().GetGameStep());
        }
        private void buttonSkip_Click(object sender, EventArgs e)
        {
            Game.getInstance().PlayerSkip();
            UpdateFraction();
            Game.getInstance().SkillPointsUp(1);
            textBoxStep.Text = Convert.ToString(Game.getInstance().GetGameStep());
            if (!Game.getInstance().GetIsAtacked())
            {
                buttonWar.Enabled = true;
            }
        }

        private void listBoxFraction_Click(object sender, EventArgs e)
        {
            Game.getInstance().UpdateActiveFraction();
            textBoxFractionLore.Text = Game.getInstance().GetLoreFraction(Game.getInstance().GetActiveFractionsIndex()[listBoxFraction.SelectedIndex]);
        }

        private void FormOfLifeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateFormOfLife formCreateFormOfLife = new FormCreateFormOfLife();
            formCreateFormOfLife.ShowDialog();
        }

        private void lvlUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLvlUp formLvlUp = new FormLvlUp();
            formLvlUp.ShowDialog();
        }

        private void buttonUpdateList_Click(object sender, EventArgs e)
        {
            UpdateFraction();
            textBoxStep.Text = Convert.ToString(Game.getInstance().GetGameStep());
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            UpdateFraction();
        }

        private void LoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLore formLore = new FormLore();
            formLore.ShowDialog();
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.ShowDialog();
        }
    }
}
