using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppGamer
{
    internal class Shop : IGame
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
                    flag = false;
                    break;
                }
            }
        }
        public void FindItem(string name)
        {
            
        }
        public void BuyItem(Inventary inventary, string name)
        {
            try
            {
                for (int j = 0; j < inventary.items.Count; j++)
                {
                    if (inventary.items[j].Name == "Монета")
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            if (items[i].Name == name)
                            {
                                inventary.AddItem(items[i]);
                                items.Remove(items[i]);
                                inventary.items.Remove(inventary.items[j]);
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            catch { }
        }
        public Shop()
        {

        }
    }
}
