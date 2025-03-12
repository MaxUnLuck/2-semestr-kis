using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirHubSulemanov6_1
{
    public partial class FormMain : Form
    {
        int hour = 0;
        public void HourUpdate() 
        { 
            hour++; 
            textBoxCountHour.Text = Convert.ToString(hour);
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBoxCountOfLines.Text);
                if (Convert.ToInt32(textBoxCountOfLines.Text) > 0)
                {
                    if (Convert.ToInt32(textBoxCountOfLines.Text) < 1001)
                    {
                        AirHub airHub;
                        AirHub.GetInstance(Convert.ToInt32(textBoxCountOfLines.Text));
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = true;
                        HourUpdate();
                        AirHub.GetInstance(0).CreateLines();
                        textBoxListOut.Text = AirHub.GetInstance(0).GetInfo();
                    }
                    else
                    {
                        MessageBox.Show("Не может быть такой большой авиа хаб", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Не может быть авиахаб с меньше чем одной полосой", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNextPlane_Click(object sender, EventArgs e)
        {
            HourUpdate();
            AirHub.GetInstance( 0 ).updateLines();
            textBoxListOut.Text = AirHub.GetInstance(0).GetInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HourUpdate();
        }

        private void buttonCloseHub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Авиа хаб больше не работает.", "Закрыто.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutProgram form = new FormAboutProgram();
            form.ShowDialog();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
