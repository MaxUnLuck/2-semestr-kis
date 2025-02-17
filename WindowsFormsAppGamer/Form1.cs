using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGamer
{
    public partial class FormMain : Form
    {
        Inventary inventaryHero = new Inventary();
        Shop shop = new Shop();
        public FormMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            List<string> category = new List<string> { "Артефакт" , "Расходник", "Оружие", "Броня", "Нейтральный предмет", "другое"};
            for (int i = 0; i < category.Count; i++)
            {
                comboBoxCategory.Items.Add(category[i]);
            }
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            /////////////////////////////////////////// МАГАЗИН ///////////////////////////////////////////
            Item item1 = new Item("Посох темного короля", "Дает невидомую силу древних великанов", "Артефакт");
            shop.AddItem(item1);
            Item item2 = new Item("Манго", "Волшебный фрукт восполняющую ману", "Расходник");
            shop.AddItem(item2);
            Item item3 = new Item("Палка короля обезьян", "Гибкая палка не дает уклоняться от ударов", "Оружие");
            shop.AddItem(item3);
            Item item4 = new Item("Шива", "Морозный наплечник замораживающий врагов", "Броня");
            shop.AddItem(item4);
            Item item5 = new Item("танго", "Целебная еда в виде трех штук", "Расходник");
            shop.AddItem(item5);
            Item item6 = new Item("Великая рапира", "Дает огромный урон", "Оружие");
            shop.AddItem(item6);
            Item item7 = new Item("Посох свиньи", "Превращает владельца в свинью", "Нейтральный предмет");
            shop.AddItem(item7);
            Item item8 = new Item("Эгида бесмертия", "Сердце бессмертного монстра Рошана", "другое");
            shop.AddItem(item8);
            Item item9 = new Item("Посох Аганим", "Посох великого мага Аганима дающий магическую силу", "другое");
            shop.AddItem(item9);
            Item item11 = new Item("Яша", "Меч увеличевающий скорость владельца", "Оружие");
            shop.AddItem(item11);
            Item item12 = new Item("Кая", "Меч увеличевающий силу магии владельца", "Оружие");
            shop.AddItem(item12);
            Item item13 = new Item("Саша", "Меч увеличевающий здоровье владельца", "Оружие");
            shop.AddItem(item13);
            /////////////////////////////////////////// МАГАЗИН ///////////////////////////////////////////
            string msg = string.Empty;
            for (int i = 0; i < shop.items.Count; i++)
            {
                msg += shop.items[i].Name + " : " + shop.items[i].Description + " - (" + shop.items[i].Category + ")\n" + Environment.NewLine;
            }
            textBoxShopOutput.Text = msg;

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Item item;
                if (comboBoxCategory.SelectedItem == null)
                {
                    item = new Item(textBoxName.Text, textBoxDestrictionary.Text, "Неизвестно");
                }
                else
                {
                    item = new Item(textBoxName.Text, textBoxDestrictionary.Text, comboBoxCategory.SelectedItem.ToString());
                }
                inventaryHero.AddItem(item);
                if (item == null)
                {
                    MessageBox.Show("Обьект не создан", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string msg = string.Empty;
            for (int i = 0;i < inventaryHero.items.Count; i++)
            {
                msg += inventaryHero.items[i].Name + " : " + inventaryHero.items[i].Description + " - (" + inventaryHero.items[i].Category + ")" + Environment.NewLine;
            }
            textBoxInventaryOutput.Text = msg;
            textBoxName.Text = string.Empty;
            textBoxDestrictionary.Text = string.Empty;
            comboBoxCategory.SelectedIndex = -1;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxDestrictionary.Text = string.Empty;
            comboBoxCategory.SelectedIndex = -1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDelete.Text != null)
            {
                inventaryHero.DeleteItem(textBoxDelete.Text);
                string msg = string.Empty;
                for (int i = 0; i < inventaryHero.items.Count; i++)
                {
                    msg += inventaryHero.items[i].Name + " : " + inventaryHero.items[i].Description + " - (" + inventaryHero.items[i].Category + ")" + Environment.NewLine;
                }
                textBoxInventaryOutput.Text = msg;
            }
            textBoxDelete.Text = string.Empty;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                MessageBox.Show("В поле поиска пусто.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            inventaryHero.FindItem(textBoxSearch.Text);
            textBoxSearch.Text = string.Empty;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            shop.BuyItem(inventaryHero ,textBoxBuy.Text);
            string msg = string.Empty;
            for (int i = 0; i < inventaryHero.items.Count; i++)
            {
                msg += inventaryHero.items[i].Name + " : " + inventaryHero.items[i].Description + " - (" + inventaryHero.items[i].Category + ")" + Environment.NewLine;
            }
            textBoxInventaryOutput.Text = msg;
            msg = string.Empty;
            for (int i = 0; i < shop.items.Count; i++)
            {
                msg += shop.items[i].Name + " : " + shop.items[i].Description + " - (" + shop.items[i].Category + ")" + Environment.NewLine;
            }
            textBoxShopOutput.Text = msg;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram form = new AboutProgram();
            form.ShowDialog();
        }
    }
}
