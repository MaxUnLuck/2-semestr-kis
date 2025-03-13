using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsenomorphGame
{
    internal class FormOfLife
    {
        //описание
        string name;
        string description;
        //гены
        string stats = string.Empty;
        Gene[] genes = new Gene[3];
        public float attack;
        public float protection;
        public float survivalRate;
        public float intelligence;
        public FormOfLife(string name_, string description_, Gene gene0)
        {
            name = name_;
            description = description_;
            genes[0] = gene0;
            genes[1] = gene0;
            genes[2] = gene0;
            UpdateStats();
        }
        public void UpdateStats()
        {
            float buff = 1 + (1 / (genes[0].intelligence + genes[1].intelligence + genes[2].intelligence));
            attack = (((genes[0].attack + genes[1].attack + genes[2].attack) / 3) * buff);
            protection = (((genes[0].protection + genes[1].protection + genes[2].protection) / 3) * buff);
            survivalRate = (((genes[0].survivalRate + genes[1].survivalRate + genes[2].survivalRate) / 3) * buff);
            intelligence = ((buff - 1) * 100);
            UpdateStatsString();
        }
        private void UpdateStatsString()
        {
            stats = string.Empty;
            stats += " - " + "Описание формы жизни:" + Environment.NewLine;
            stats += " - " + "\t" + name + Environment.NewLine;
            stats += " - " + "\t" + description + Environment.NewLine;
            stats += " - " + "\tГены:" + Environment.NewLine;
            stats += " - " + "\t\tатака =\t" + attack + Environment.NewLine;
            stats += " - " + "\t\tзащита =\t" + protection + Environment.NewLine;
            stats += " - " + "\t\tвыжеваемость =\t" + survivalRate + Environment.NewLine;
            stats += " - " + "\t\tинтелект =\t" + intelligence + " %" + Environment.NewLine;
        }
    }
}
