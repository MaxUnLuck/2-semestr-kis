using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsenomorphGame
{
    internal class Gene
    {
        public string name;
        public string description;
        public float attack;
        public float protection;
        public float survivalRate;
        public float intelligence;
        public Gene(string name_, string description_, int attack_, int protection_, int survivalRate_, int intelligence_) 
        { 
            name = name_;
            description = description_;
            attack = attack_;
            protection = protection_;
            survivalRate = survivalRate_;
            intelligence = intelligence_;
        }
    }
}
