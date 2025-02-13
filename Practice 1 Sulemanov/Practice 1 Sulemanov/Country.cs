using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1_Sulemanov
{
    internal class Country:Union
    {
        uint population;
        string message;
        string nameOfCountry;
        string typeOfAuthority; // тип власти
        string flag; // ссылка на флаг внутри пк
        public Country(string nameOfUnion, string purposeOfTheUnion, uint population_, string nameOfCountry_, string typeOfAuthority_) 
            :base (nameOfUnion, purposeOfTheUnion)
        {
            nameOfCountry = nameOfCountry_;
            typeOfAuthority = typeOfAuthority_;
            population = population_;
            GetInfoCountry();
            CountryEvent();
        }
        public void CountryEvent()
        {
            int wait = 0;
            wait++;
            const string PopulationMessage = " Население изменилось на "; 
            string[] events = { $"Страна {nameOfCountry}\n процветает и процветает!\n"+PopulationMessage+"+10%", 
                                $"Страна {nameOfCountry}\n решает спонсировать медецину!\n"+PopulationMessage+"+20%", 
                                $"Страна {nameOfCountry}\n вошла в экономический кризис!"+PopulationMessage+"-5%",
                                $"Страна {nameOfCountry}\n АЭС взорвалось, но его успели потушть!\n",
                                $"Страна {nameOfCountry}\n АЭС взорвалось, Экология страны весьма ухудшилась!\n"+PopulationMessage+"-80%",
                                $"Страна {nameOfCountry}\n Началось земелетресение, Люди гибнут!\n"+PopulationMessage+"-30%",
                                $"Страна {nameOfCountry}\n В стране запретили средства контрацепции, население взлетело!\n"+PopulationMessage+"+50%",
                                $"Страна {nameOfCountry}\n Алкоголь запретили, люди начали сходить с ума!\n"+PopulationMessage+"-15%",
                                $"Страна {nameOfCountry}\n Новая неизвестная болезнь, вакцину не могут создать!\n"+PopulationMessage+"-70%",
                                $"Страна {nameOfCountry}\n По ошибке власти ядерные бомбы взорвались сами, везде радиация!\n"+"население Вымерло",
                                $"Страна {nameOfCountry}\n Курс валюты обвалился, население в панике!\n"+PopulationMessage+"-10",
                                $"Страна {nameOfCountry}\n В страну втроглись нелегалы, выросла преступность!\n"+PopulationMessage+"+20",
                                $"Страна {nameOfCountry}\n Открыт новый вид энергии, редстоун, страна развивается!\n",
                                $"Страна {nameOfCountry}\n Новые реформы правительства оказались отмыванием денег!\n",
                                $"Страна {nameOfCountry}\n В стране выросли акцизы на табачную продукцию!\n",
                                $"Страна {nameOfCountry}\n В стране революция, вас сместили с власти и началась гражданская война!\n Страна распалась."};
            int[] eventsPreCent = { 10, 20, -5, 0, -80, -30, 50, -15, -70, 404, -10, 20, 0, 0, 0, 404};
            Random rnd = new Random();
            int chance = rnd.Next(events.Length);
            if (eventsPreCent[chance] == 404 && wait < 5)
            {
                chance = rnd.Next(events.Length);
            }
            MessageBox.Show(events[chance],
                               "В стране новшества!",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (eventsPreCent[chance] == 404)
            {
                population = 0;
            }
            if (eventsPreCent[chance] > 0 && eventsPreCent[chance] != 404)
            {
                population = Convert.ToUInt32(population / 100 * (100 + Convert.ToUInt32(eventsPreCent[chance])));
            }
            if (eventsPreCent[chance] < 0 && eventsPreCent[chance] != 404)
            {
                population = Convert.ToUInt32(population + population / 100 * eventsPreCent[chance]);
            }
        }
        void GetInfoCountry()
        {
            MessageBox.Show("Страна создана!", 
                $"Страна: {nameOfCountry}\nТип власти: {typeOfAuthority}\nСостоит в слюзе: {nameOfUnion}\nС целью: {purposeOfTheUnion}", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public uint GetPopulation()
        {
            return population;
        }
    }
}
