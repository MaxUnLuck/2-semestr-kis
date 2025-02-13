using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSulemanov4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyMatrix<int> newMyMatrix;
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToUInt32(textBoxWeight.Text);
                Convert.ToInt32(textBoxA.Text);
                Convert.ToInt32(textBoxB.Text);
                newMyMatrix = new MyMatrix<int>(Convert.ToUInt32(textBoxWeight.Text), Convert.ToInt32(textBoxA.Text), Convert.ToInt32(textBoxB.Text));
                Random rand = new Random();
                for (uint x = 0; x < Convert.ToUInt32(textBoxWeight.Text); x++)
                {
                    for (uint y = 0; y < Convert.ToUInt32(textBoxWeight.Text); y++)
                    {
                        newMyMatrix.SetCell(rand.Next(1, 100), x, y);
                    }
                }
                FillDataGridViev(newMyMatrix.matrix, Convert.ToInt32(textBoxWeight.Text), Convert.ToInt32(textBoxWeight.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillDataGridViev(int[,] matrix, int m, int n)
        {
            DataTable table = new DataTable();
            for (int i = 0; i < n; i++)
            {
                table.Columns.Add($"Столбец {i + 1}", typeof(int));
            }
            for (int i = 0; i < m; i++)
            {
                DataRow row = table.NewRow();
                for (int j = 0; j < n; j++)
                {
                    row[j] = matrix[i, j];
                }
                table.Rows.Add(row);
            }
            dataGridView.DataSource = table;
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProgramInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            newMyMatrix.EnabelFunction();
            FillDataGridViev(newMyMatrix.matrix, Convert.ToInt32(textBoxWeight.Text), Convert.ToInt32(textBoxWeight.Text));
        }
    }
}
