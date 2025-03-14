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
        public List<Gene> geneStealed = new List<Gene>();



        public Fraction(string name, string description, List<FormOfLife> formsOfLife, List<Planet> planets)
        {
            this.name = name;
            this.description = description;
            this.formsOfLife = formsOfLife;
            this.formsOfLifeCount.Add(1000);
            this.planets = planets;
        }



        public string LastWarHistory;
        public void War(Fraction fraction) // Война
        {
            LastWarHistory = string.Empty;
            LastWarHistory += $"Война:{name} атака на {fraction.name}";
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
            LastWarHistory += $"\nхарактиристики({name}):\n\tатака - {attackerAT}\n\tзащита - {attackerPT}\n\tхит поинтов - {attackerHP}";
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
            LastWarHistory += $"\nхарактиристики({fraction.name}):\n\tатака - {defencerAT}\n\tзащита - {defencerPT}\n\tхит поинтов - {defencerHP}";
            //атака
            while (true)
            {
                Random random = new Random();
                if (random.Next(0, 11) < 2) // атака атакующего
                {
                    defencerHP = Convert.ToInt32(defencerHP - (attackerHP * (attackerAT / defencerPT) * 0.20));
                    LastWarHistory += $"\nКритическая атака -{Convert.ToInt32(defencerHP - (attackerHP * (attackerAT / defencerPT) * 0.20))}";
                }
                else
                {
                    defencerHP = Convert.ToInt32(defencerHP - (attackerHP * (attackerAT / defencerPT)));
                    LastWarHistory += $"\nАтака -{Convert.ToInt32(defencerHP - (attackerHP * (attackerAT / defencerPT)))}";
                }
                if (defencerHP < 0) // если защитник проиграл
                {
                    int rnd = random.Next(0, fraction.planets.Count);
                    Planet tempPlanet = fraction.planets[rnd];
                    fraction.planets.Remove(tempPlanet);
                    planets.Add(tempPlanet);
                    geneStealed.Add(fraction.formsOfLife[random.Next(formsOfLife.Count)].genes[random.Next(0, 3)]); // кража рандомного гена
                    break;

                }
                if (random.Next(0, 11) < 2) // атака защищающего
                {
                    defencerHP = attackerHP = Convert.ToInt32(attackerHP - (defencerHP * (defencerAT / attackerPT) * 0.20));
                    LastWarHistory += $"\nКритическая атака -{Convert.ToInt32(attackerHP - (defencerHP * (defencerAT / attackerPT) * 0.20))}";
                }
                else
                {
                    defencerHP = Convert.ToInt32(attackerHP - (defencerHP * (defencerAT / attackerPT)));
                    LastWarHistory += $"\nАтака -{Convert.ToInt32(attackerHP - (defencerHP * (defencerAT / attackerPT)))}";
                }
                if (attackerHP < 0) // если атакующий проиграл
                {
                    break;
                }
            }
            IsFractionLife();
        }



        private bool IsFractionLife()
        {
            if (planets.Count == 0)
            {
                isLife = false;
                return false;
            }
            else
            {
                isLife = true;
                return true;
            }
        }
    }
}
