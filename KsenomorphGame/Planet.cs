using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsenomorphGame
{
    internal class Planet
    {
        public string name;
        public string description;
        public int defence;
        public Planet(string name, string description, int defence)
        {
            this.name = name;
            this.description = description;
            this.defence = defence;
        }
        public float GetBuffDefence()
        {
            return (1 / defence);
        }
    }
}
