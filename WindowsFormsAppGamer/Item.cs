using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGamer
{
    internal class Item
    {
        public string Name { get; protected set; } = "неизвестно";
        public string Description { get; protected set; } = "неизвестно";
        public string Category { get; protected set; } = "не определено";
        public Item (string name_, string description_, string Category_)
        {
            if (string.IsNullOrEmpty(name_))
            {
                Name = "Неизвестно";
            }
            else
            {
                Name = name_;
            }
            if (string.IsNullOrEmpty(description_))
            {
                Description = "Неизвестно";
            }
            else
            {
                Description = description_;
            }
            if (string.IsNullOrEmpty(Category_))
            {
                Category = "Незнаю";
            }
            else
            {
                Category = Category_;
            }
        }
    }
}
