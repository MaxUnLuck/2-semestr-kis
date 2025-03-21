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
    public partial class FormCreateFormOfLife : Form
    {
        public FormCreateFormOfLife()
        {
            InitializeComponent();
            comboBoxGene2.Items.Clear();
            for (int i = 0; i < Game.getInstance().GetGeneList().Count; i++)
            {
                comboBoxGene2.Items.Add(Game.getInstance().GetGeneList()[i]);
            }
            comboBoxGene3.Items.Clear();
            for (int i = 0; i < Game.getInstance().GetGeneList().Count; i++)
            {
                comboBoxGene3.Items.Add(Game.getInstance().GetGeneList()[i]);
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели название!", "Забыли?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxDescription.Text == string.Empty)
                {
                    MessageBox.Show("Вы не ввели Описание!", "Забыли?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBoxGene2.SelectedIndex == -1)
                    {
                        MessageBox.Show("Вы не выбрали первый ген!", "Забыли?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (comboBoxGene3.SelectedIndex == -1)
                        {
                            MessageBox.Show("Вы не выбрали второй ген!", "Забыли?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DialogResult dialogResult1 = MessageBox.Show("Вы уверены что правильно все заполнели?", "Уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogResult1 == DialogResult.Yes)
                            {
                                DialogResult dialogResult2 = MessageBox.Show("Вы уверены что хотите потерять 1000 от населения главной формы жизни?", "Уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (dialogResult2 == DialogResult.Yes)
                                {
                                    bool IsCreated = Game.getInstance().PlayerCreateFormOfLife(
                                        textBoxName.Text,
                                        textBoxDescription.Text,
                                        comboBoxGene2.SelectedIndex,
                                        comboBoxGene3.SelectedIndex);
                                    if (!IsCreated)
                                    {
                                        MessageBox.Show("Население главной формы жизни слишком мало!", "Проблема?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
