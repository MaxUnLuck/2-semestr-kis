using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsenomorphGame
{
    internal class Game
    {
        static Gene GXenomorph = new Gene("Ксеноморф", "Стандартный ген ксеноморфов.", 12, 8, 10, 1);
        FormOfLife FOLXenomorph = new FormOfLife("Ксеноморф стандарт",
            "Пугающий захватчик галактик, идеальный хищник, в крови котоого циркулирует кислота!",
            GXenomorph);
        List<FormOfLife> LFOLXenomorph = new List<FormOfLife>();
        Fraction player = new Fraction(0, 0);
        public Game() 
        {
            LFOLXenomorph.Add();
        }
        
    }
}
