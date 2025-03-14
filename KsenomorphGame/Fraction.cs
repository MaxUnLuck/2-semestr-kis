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
        public bool isLife = true;
        public List<FormOfLife> formsOfLife;
        public List<int> formsOfLifeCount = new List<int>();
        public List<Planet> planets = new List<Planet>();
        public Fraction(string name, string description, List<FormOfLife> formsOfLife, List<Planet> planets)
        {
            this.name = name;
            this.description = description;
            this.formsOfLife = formsOfLife;
            this.formsOfLifeCount.Add(1000);
            this.planets = planets;
        }
        public void War(Fraction fraction)
        {
            //атакующий
            int attackerHP = 0;
            for (int i = 0; i < formsOfLifeCount.Count; i++)
            {
                attackerHP += formsOfLifeCount[i];
            }
            float attackerAT = 0;
            for (int i = 0; i < formsOfLife.Count; i++)
            {
                attackerAT += formsOfLife[i].attack;
            }
            attackerAT = attackerAT / formsOfLife.Count;
            float attackerPT = 0;
            for (int i = 0; i < formsOfLife.Count; i++)
            {
                attackerPT += formsOfLife[i].protection;
            }
            attackerPT = attackerPT / formsOfLife.Count;
            //защищающий
            int defencerHP = 0;
            for (int i = 0;i < fraction.formsOfLife.Count;i++)
            {
                defencerHP += fraction.formsOfLifeCount[i];
            }
            float defencerAT = 0;
            for (int i = 0; i < fraction.formsOfLife.Count; i++)
            {
                defencerAT += fraction.formsOfLife[i].attack;
            }
            defencerAT = defencerAT / fraction.formsOfLife.Count;
            float defencerPT = 0;
            for (int i = 0; i < fraction.formsOfLife.Count; i++)
            {
                defencerPT += fraction.formsOfLife[i].protection;
            }
            defencerPT = defencerPT / fraction.formsOfLife.Count;
            //атака
            while (true)
            {
                defencerHP = Convert.ToInt32(defencerHP * (attackerAT / defencerPT));
                if (defencerHP < 0)
                {
                    Random random = new Random();
                    int rnd = random.Next(0, fraction.planets.Count);
                    Planet tempPlanet = fraction.planets[rnd];
                    
                }
            }
        }
    }
}
