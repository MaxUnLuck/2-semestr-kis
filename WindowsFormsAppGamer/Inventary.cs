using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppGamer
{
    internal class Inventary : IGame
    {
        public List<Item> items = new List<Item>();
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public void DeleteItem(string name)
        {
            bool flag = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Name == name)
                {
                    items.Remove(items[i]);
                    MessageBox.Show($"Удален предмет {name}", "Удаление!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                MessageBox.Show($"Не найден предмет {name}", "Поиск!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //items.Remove(item);
        }
        public void FindItem(string name)
        {
            bool flag = false;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Name == name)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                MessageBox.Show($"Найден предмет {name}", "Поиск!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show($"Не найден предмет {name}", "Поиск!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PrintInventary()
        {
            string inventary = string.Empty;
            for (int i = 0; i < items.Count; i++)
            {
                inventary += items[i].Name + " : " + items[i].Description + " - (" + items[i].Category + ")\n";
            }
            MessageBox.Show(inventary, "Инвентарь!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Inventary()
        {

        }
    }
}
