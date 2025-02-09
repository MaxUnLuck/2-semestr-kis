using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1_Sulemanov
{
    internal class Country:Union
    {
        string message;
        string nameOfCountry;
        string typeOfAuthority; // тип власти
        public Country(string nameOfUnion, string purposeOfTheUnion, string nameOfCountry_, string typeOfAuthority_) 
            :base (nameOfUnion, purposeOfTheUnion)
        {
            nameOfCountry = nameOfCountry_;
            typeOfAuthority = typeOfAuthority_;
            GetInfoCountry();
            CountryEvent();
        }
        void CountryEvent()
        {
            string[] events = { $"Страна {nameOfCountry} процветает и процветает!", 
                                $"Страна {nameOfCountry} решает вылеоить гуманитарную помощь в африку!", 
                                $"Страна {nameOfCountry} вошла в экономический кризис!"};
            Random rnd = new Random();
            int chance = rnd.Next();
        }
        void GetInfoCountry()
        {
            MessageBox.Show("Страна создана!", 
                $"Страна: {nameOfCountry}\nТип власти: {typeOfAuthority}\nСостоит в слюзе: {nameOfUnion}\nС целью: {purposeOfTheUnion}", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
