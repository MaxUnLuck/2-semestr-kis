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
    public partial class war : Form
    {
        public war()
        {
            InitializeComponent();
            listBoxFraction.Items.Clear();
            for (int i = 1; i < Game.getInstance().GetActiveFractions().Count; i++)
            {
                listBoxFraction.Items.Add(Game.getInstance().GetActiveFractions()[i]);
            }
            comboBoxSpaceFeet.Items.Clear();
            for (int i = 0; i < Game.getInstance().GetSpaceFleetList().Count; i++)
            {
                comboBoxSpaceFeet.Items.Add(Game.getInstance().GetSpaceFleetList()[i]);
            }
            comboBoxCommander.Items.Clear();
            for (int i = 0; i < Game.getInstance().GetComanderList().Count; i++)
            {
                comboBoxCommander.Items.Add(Game.getInstance().GetComanderList()[i]);
            }
            comboBoxBioWeapon.Items.Clear();
            for (int i = 0; i < Game.getInstance().GetBioWeaponList().Count; i++)
            {
                comboBoxBioWeapon.Items.Add(Game.getInstance().GetBioWeaponList()[i]);
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (listBoxFraction.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали фракцию!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBoxCommander.SelectedIndex == -1)
                {
                    MessageBox.Show("Вы не выбрали коммандира!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBoxBioWeapon.SelectedIndex == -1)
                    {
                        MessageBox.Show("Вы не выбрали био оружие!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        textBoxWarLore.Text = Game.getInstance().PlayerWar(Game.getInstance().GetActiveFractionsIndex()[listBoxFraction.SelectedIndex + 1],comboBoxCommander.SelectedIndex,comboBoxBioWeapon.SelectedIndex, comboBoxSpaceFeet.SelectedIndex);
                        buttonAccept.Enabled = false;
                        listBoxFraction.Enabled = false;
                        comboBoxBioWeapon.Enabled = false;
                        comboBoxCommander.Enabled = false;
                        comboBoxSpaceFeet.Enabled = false;
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
