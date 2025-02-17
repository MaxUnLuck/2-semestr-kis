using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGamer
{
    internal interface IGame
    {
        void AddItem(Item item);
        void DeleteItem(string name);
        void FindItem(string name);
    }
}
