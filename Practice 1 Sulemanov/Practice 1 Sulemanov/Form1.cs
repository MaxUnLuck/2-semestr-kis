
using System.Threading.Channels;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practice_1_Sulemanov
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Country newcountry;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            bool isNoError = true;
            if (textBoxNameOfUnion.Text == string.Empty)
            {
                MessageBox.Show("В поле ввода имени союза пусто!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isNoError = false;
            }
            if (textBoxPurposeOfTheUnion.Text == string.Empty && isNoError == true)
            {
                MessageBox.Show("В поле ввода Цель страны пусто!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isNoError = false;
            }
            if (textBoxNameOfCountry.Text == string.Empty && isNoError == true)
            {
                MessageBox.Show("В поле ввода имени страны пусто!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isNoError = false;
            }
            if (textBoxTypeOfAuthority.Text == string.Empty && isNoError == true)
            {
                MessageBox.Show("В поле ввода типа власти пусто!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isNoError = false;
            }
            try
            {
                if (Convert.ToUInt32(textBoxPopulation.Text) < 0 && isNoError == true)
                {
                    MessageBox.Show("В поле ввода население должно быть больше нуля!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isNoError = false;
                }
                if (Convert.ToUInt32(textBoxPopulation.Text) == 0 && isNoError == true)
                {
                    MessageBox.Show("В поле ввода населении должно быть больше 0!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isNoError = false;
                }
                if (Convert.ToUInt32(textBoxPopulation.Text) < 100 && isNoError == true)
                {
                    MessageBox.Show("В поле ввода населении сликом мало!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isNoError = false;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (isNoError)
            {
                try
                {
                    newcountry = new Country(textBoxNameOfUnion.Text, textBoxPurposeOfTheUnion.Text, Convert.ToUInt32(textBoxPopulation.Text), textBoxNameOfCountry.Text, textBoxTypeOfAuthority.Text);
                    textBoxPopulation.Text = Convert.ToString(newcountry.GetPopulation());
                    textBoxNameOfCountry.Enabled = false;
                    textBoxTypeOfAuthority.Enabled = false;
                    textBoxNameOfUnion.Enabled = false;
                    textBoxPurposeOfTheUnion.Enabled = false;
                    textBoxPopulation.Enabled = false;
                    ClearToolStripMenuItem.Enabled = false;
                    buttonStart.Enabled = false;
                    buttonEvent.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNameOfUnion.Text = string.Empty;
            textBoxNameOfCountry.Text = string.Empty;
            textBoxTypeOfAuthority.Text = string.Empty;
            textBoxPurposeOfTheUnion.Text = string.Empty;
            textBoxPopulation.Text = string.Empty;
        }

        private void LeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEvent_Click(object sender, EventArgs e)
        {
            newcountry.CountryEvent();
            textBoxPopulation.Text = Convert.ToString(newcountry.GetPopulation());
            if (newcountry.GetPopulation() == 0)
            {
                MessageBox.Show("Страна из-за вашей власти исчезла с карты мира", "Поражение!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
            if (newcountry.GetPopulation() < 100)
            {
                MessageBox.Show("Население Слишком мало и страна не смогла существовать", "Поражение!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm form = new AboutProgramForm();
            form.ShowDialog();
        }
    }
}
