using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsenomorphGame
{
    internal class Fraction
    {
        string name;
        string description;
        List<FormOfLife> formsOfLife = new List<FormOfLife> ();
        public Fraction(string name, string description, List<FormOfLife> formsOfLife)
        {
            this.name = name;
            this.description = description;
            this.formsOfLife = formsOfLife;
        }
    }
}
