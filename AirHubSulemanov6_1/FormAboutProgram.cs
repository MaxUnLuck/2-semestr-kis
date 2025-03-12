using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirHubSulemanov6_1
{
    public partial class FormAboutProgram : Form
    {
        public FormAboutProgram()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://web.telegram.org/k/#@BackSpacePeek",
                    UseShellExecute = true
                }
            );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
