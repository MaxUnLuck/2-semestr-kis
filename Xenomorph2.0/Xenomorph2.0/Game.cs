﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsenomorphGame
{
    internal class Game // фасад
    {
        ////////////////////////////////////// фасад //////////////////////////////////////
        private static Game game; // я сделал паттерн фасад с паттерном одиночка что бы он был один и доступен во всем проеке
        private Game() { }
        public static Game getInstance()
        {
            if (game == null)
            {
                game = new Game();
            }
            return game;
        }
        //*////////////////////////////////|//////////////|////////////////////////////////*//
        //*////////////////////////////////|/// классы ///|////////////////////////////////*//
        //*////////////////////////////////V//////////////V////////////////////////////////*//

        /////////////////////////////// ген ///////////////////////////////
        protected class Gene
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
            public string GetLore() // получение лора
            {
                string lore = string.Empty;
                lore += "ген:" + name + Environment.NewLine;
                lore += "Название - " + name + Environment.NewLine;
                lore += "Описание - " + description + Environment.NewLine;
                return lore;
            }
        }
        /////////////////////////////// форма жизни ///////////////////////////////
        protected class FormOfLife
        {
            //описание
            public string name;
            public string description;
            //гены
            public Gene[] genes = new Gene[3];
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
            public void UpdateStats() // обновление статов с генами
            {
                float buff = 1 + (1 / (genes[0].intelligence + genes[1].intelligence + genes[2].intelligence));
                attack = (((genes[0].attack + genes[1].attack + genes[2].attack) / 3) * buff);
                protection = (((genes[0].protection + genes[1].protection + genes[2].protection) / 3) * buff);
                survivalRate = (((genes[0].survivalRate + genes[1].survivalRate + genes[2].survivalRate) / 3) * buff);
                intelligence = ((buff - 1) * 100);
            }
            public Gene GeneSteal() // кража гена
            {
                Random random = new Random();
                return genes[random.Next(0, 3)];
            }
            public string GetLore() //получение информации
            {
                string lore = string.Empty;
                lore += "Описание формы жизни:" + Environment.NewLine;
                lore += "название - " + name + Environment.NewLine;
                lore += "описание - " + description + Environment.NewLine;
                lore += "Гены:" + Environment.NewLine;
                genes[0].GetLore();
                genes[1].GetLore();
                genes[2].GetLore();
                lore += "Статы:" + Environment.NewLine;
                lore += "атака =\t" + attack + Environment.NewLine;
                lore += "защита =\t" + protection + Environment.NewLine;
                lore += "выжеваемость =\t" + survivalRate + Environment.NewLine;
                lore += "интелект =\t" + intelligence + " %" + Environment.NewLine;
                return lore;
            }
        }
        /////////////////////////////// планета ///////////////////////////////
        protected class Planet
        {
            public string name;
            public string description;
            public Planet(string name, string description)
            {
                this.name = name;
                this.description = description;
            }
            public string GetLore()
            {
                string lore = string.Empty;
                lore += "Планета:" + Environment.NewLine;
                lore += "Название - " + name + Environment.NewLine;
                lore += "Описание - " + description + Environment.NewLine;
                return lore;
            }
        }
        /////////////////////////////// коммандир ///////////////////////////////
        protected class Comander
        {
            public string name;
            public string description;
            public float buffAttack;
            public float buffProtected;
            public Comander(string name, string description, float buffAttack, float buffProtected)
            {
                this.name = name;
                this.description = description;
                this.buffAttack = buffAttack;
                this.buffProtected = buffProtected;
            }
            public string GetLore()
            {
                string lore = string.Empty;
                lore += "Командир:" + name + Environment.NewLine;
                lore += "имя - " + name + Environment.NewLine;
                lore += "история - " + description + Environment.NewLine;
                lore += "бафы:" + Environment.NewLine;
                lore += "атака - " + buffAttack + Environment.NewLine;
                lore += "защита - " + buffProtected + Environment.NewLine;
                return lore;
            }
        }
        /////////////////////////////// био оружие ///////////////////////////////
        protected class BioWeapon
        {
            public string name;
            public Gene[] genes = new Gene[3];
            public float Attack;
            public float intelegence;
            public BioWeapon(string name, Gene gene0, Gene gene1, Gene gene2, List<FormOfLife> formsOfLife)
            {
                this.name = name;
                genes[0] = gene0;
                genes[1] = gene1;
                genes[2] = gene2;
                for (int i = 0; i < formsOfLife.Count; i++)
                {
                    intelegence = formsOfLife[i].intelligence;
                }
                intelegence = intelegence / formsOfLife.Count;
                UpdateAttack();
            }
            private void UpdateAttack()
            {
                Random random = new Random();
                Attack = 1 / ((genes[0].attack + genes[1].attack + genes[2].attack) / 3 / intelegence);
            }
            public double GetAttack()
            {
                return Attack;
            }
            public string GetLore()
            {
                string lore = string.Empty;
                lore += "ген:" + name + Environment.NewLine;
                lore += "Название - " + name + Environment.NewLine;
                lore += "Гены:" + Environment.NewLine;
                genes[0].GetLore();
                genes[1].GetLore();
                genes[2].GetLore();
                return lore;
            }
        }
            //*////////////////////////////////|///////////////|////////////////////////////////*//
            //*////////////////////////////////|/// фракция ///|////////////////////////////////*//
            //*////////////////////////////////V///////////////V////////////////////////////////*//
            protected class Fraction
            {
                public string name;
                public string description;
                public bool isLife = true;
                public List<FormOfLife> formsOfLife;
                public List<int> formsOfLifeCount = new List<int>();
                public List<Planet> planets = new List<Planet>();
                public List<Gene> geneStealed = new List<Gene>();
                public List<Comander> comanders = new List<Comander>();
                public List<BioWeapon> bioWeapons = new List<BioWeapon>();
                private const double criticalAttack = 1.2;
                private const double partOfFOLCountAttack = 0.05;
                public Fraction(string name, string description, List<FormOfLife> formsOfLife, List<Planet> planets)
                {
                    this.name = name;
                    this.description = description;
                    this.formsOfLife = formsOfLife;
                    geneStealed.Add(formsOfLife[0].genes[0]);
                    formsOfLifeCount.Add(1000);
                    this.planets = planets;
                    BioWeapon bioWeapon = new BioWeapon("Стандартное", formsOfLife[0].genes[0], formsOfLife[0].genes[0], formsOfLife[0].genes[0], formsOfLife);
                    bioWeapons.Add(bioWeapon);
                }
                public string LastWarHistory;
                public string War(Fraction fraction, Comander comander, BioWeapon bioWeapon) // Война
                {
                    LastWarHistory = string.Empty;
                    LastWarHistory += $"Война:{name} атака на {fraction.name}";
                    //атакующий
                    double attackerHP = 0;
                    for (int i = 0; i < formsOfLifeCount.Count; i++)
                    {
                        attackerHP += formsOfLifeCount[i];
                    }
                    double attackerAT = 0;
                    for (int i = 0; i < formsOfLife.Count; i++)
                    {
                        attackerAT += formsOfLife[i].attack;
                    }
                    attackerAT = attackerAT / formsOfLife.Count + comander.buffAttack + bioWeapon.Attack;
                    double attackerPT = 0;
                    for (int i = 0; i < formsOfLife.Count; i++)
                    {
                        attackerPT += formsOfLife[i].protection + comander.buffProtected;
                    }
                    attackerPT = attackerPT / formsOfLife.Count;
                    LastWarHistory += Environment.NewLine +
                        $"характиристики({name}):" + Environment.NewLine +
                        $"атака - {Math.Round(attackerAT, 2)}" + Environment.NewLine +
                        $"защита - {Math.Round(attackerPT, 2)}" + Environment.NewLine +
                        $"хит поинтов - {attackerHP}" + Environment.NewLine;
                    //защищающий
                    double defencerHP = 0;
                    for (int i = 0; i < fraction.formsOfLife.Count; i++)
                    {
                        defencerHP += fraction.formsOfLifeCount[i];
                    }
                    double defencerAT = 0;
                    for (int i = 0; i < fraction.formsOfLife.Count; i++)
                    {
                        defencerAT += fraction.formsOfLife[i].attack;
                    }
                    defencerAT = defencerAT / fraction.formsOfLife.Count;
                    double defencerPT = 0;
                    for (int i = 0; i < fraction.formsOfLife.Count; i++)
                    {
                        defencerPT += fraction.formsOfLife[i].protection;
                    }
                    defencerPT = defencerPT / fraction.formsOfLife.Count;
                    LastWarHistory += Environment.NewLine +
                        $"характиристики({fraction.name}):" + Environment.NewLine +
                        $"атака - {Math.Round(defencerAT, 2)}" + Environment.NewLine +
                        $"защита - {Math.Round(defencerPT, 2)}" + Environment.NewLine +
                        $"хит поинтов - {defencerHP}" + Environment.NewLine + Environment.NewLine;
                    Random random = new Random();
                    int step = 0;
                    while (true)
                    {
                        step++;
                        switch (random.Next(0, 3)) // атака атакующего
                        {
                            case 0: // крит атака
                                defencerHP -= attackerAT / defencerPT * attackerHP * partOfFOLCountAttack * criticalAttack;
                                LastWarHistory += $"Крит атака ({name}) = " + Math.Round(attackerAT / defencerPT * attackerHP * partOfFOLCountAttack * criticalAttack, 3) + Environment.NewLine + Environment.NewLine;
                                break;
                            case 1: // простая атака
                                defencerHP -= attackerAT / defencerPT * attackerHP * partOfFOLCountAttack;
                                LastWarHistory += $"Атака ({name}) = " + Math.Round(attackerAT / defencerPT * attackerHP * partOfFOLCountAttack, 3) + Environment.NewLine + Environment.NewLine;
                                break;
                            case 2: // промах
                                LastWarHistory += $"промах ({name})" + Environment.NewLine + Environment.NewLine;
                                break;
                        }
                        if (defencerHP < 0)
                        {
                            LastWarHistory += Environment.NewLine + $"!победа ({name})!"; // Обьявление победы

                            Planet tempPlanet;// передача планеты
                            tempPlanet = fraction.planets[fraction.planets.Count - 1];
                            fraction.planets.Remove(tempPlanet);
                            planets.Add(tempPlanet);

                            geneStealed.Add(fraction.formsOfLife[random.Next(formsOfLife.Count)].genes[random.Next(0, 3)]); // кража рандомного гена

                            for (int i = 0; i < fraction.formsOfLifeCount.Count; i++)
                            {
                                fraction.formsOfLifeCount[i] = Convert.ToInt32(fraction.formsOfLifeCount[i] * 0.8);
                            }

                            for (int i = 0; i < formsOfLifeCount.Count; i++)
                            {
                                formsOfLifeCount[i] = Convert.ToInt32(formsOfLifeCount[i] * 0.9);
                            }

                            break;
                        }
                        switch (random.Next(0, 3)) // атака защищающегося
                        {
                            case 0: // крит атака
                                attackerHP -= defencerAT / defencerPT * defencerHP * partOfFOLCountAttack * criticalAttack;
                                LastWarHistory += $"Крит атака ({fraction.name}) = " + Math.Round(defencerAT / defencerPT * defencerHP * partOfFOLCountAttack * criticalAttack, 3) + Environment.NewLine + Environment.NewLine;
                                break;
                            case 1: // простая атака
                                attackerHP -= defencerAT / defencerPT * defencerHP * partOfFOLCountAttack;
                                LastWarHistory += $"Атака ({fraction.name}) = " + Math.Round(defencerAT / defencerPT * defencerHP * partOfFOLCountAttack, 3) + Environment.NewLine + Environment.NewLine;
                                break;
                            case 2: // промах
                                LastWarHistory += $"промах ({fraction.name})" + Environment.NewLine + Environment.NewLine;
                                break;
                        }
                        if (attackerHP < 0)
                        {
                            LastWarHistory += Environment.NewLine + $"!победа ({fraction.name})!";

                            for (int i = 0; i < fraction.formsOfLifeCount.Count; i++)
                            {
                                fraction.formsOfLifeCount[i] = Convert.ToInt32(fraction.formsOfLifeCount[i] * 0.9);
                            }

                            for (int i = 0; i < formsOfLifeCount.Count; i++)
                            {
                                formsOfLifeCount[i] = Convert.ToInt32(formsOfLifeCount[i] * 0.8);
                            }

                            break;
                        }
                        if (step > 100)
                        {
                            LastWarHistory += Environment.NewLine + "ничья?";
                            break;
                        }
                    }
                    IsFractionLife();
                    fraction.IsFractionLife();
                    return LastWarHistory;
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
                public bool CreateFormOfLive(string name, string description, Gene gene2, Gene gene3)
                {
                    if (formsOfLifeCount[0] > 1000)
                    {
                        FormOfLife newFormOfLive = new FormOfLife(name, description, formsOfLife[0].genes[0]);
                        newFormOfLive.genes[1] = gene2;
                        newFormOfLive.genes[2] = gene3;
                        formsOfLife.Add(newFormOfLive);
                        formsOfLifeCount[0] -= 1000;
                        formsOfLifeCount.Add(1000);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                public void CreateBioWeapon(string name, Gene gene0, Gene gene1, Gene gene2)
                {
                    bioWeapons.Add(new BioWeapon(name, gene0, gene1, gene2, formsOfLife));
                }
                public void ReproductionFormOfLive()
                {
                    for (int i = 0; i < formsOfLife.Count; i++)
                    {
                        formsOfLifeCount[i] = Convert.ToInt32(formsOfLifeCount[i] * (1 + formsOfLife[i].survivalRate / 10));
                    }
                }
                public string GetLore()
                {
                    string lore = string.Empty;
                    lore += "Фракция:" + Environment.NewLine;
                    lore += "Название - " + name + Environment.NewLine;
                    lore += "Описание - " + description + Environment.NewLine;
                    return lore;
                }
            }
        //*////////////////////////////////^///////////////^////////////////////////////////*//
        //*////////////////////////////////|/// фракция ///|////////////////////////////////*//
        //*////////////////////////////////|///////////////|////////////////////////////////*//
        /////////////////////////////// коммандир ///////////////////////////////
        protected class DebugMenu
        {
            public string InputComand(string comand, Fraction fraction)
            {
                try
                {
                    string[] commands = comand.Split(' ', '(', ')', ',');
                    if (commands[0] == "PAddFOLCount") // PAddFOLCount(FOLName, INT) Увелечение своей армии
                    {
                        for (int i = 1; i < fraction.formsOfLife.Count; i++)
                        {
                            if (fraction.formsOfLife[i].name == commands[1])
                            {
                                fraction.formsOfLifeCount[i] = Convert.ToInt32(commands[2]);
                                return "УСПЕХ!";
                            }
                        }
                        return "Error(Несуществующая форма жизни)!";
                    }
                    return "Error(Неизвестная команда)!";
                }
                catch (FormatException)
                {
                    return "Error(Числа либо нет либо оно не правильно)!";
                }
                catch (Exception)
                {
                    return "Error(Неизвестная ошибка)!";
                }
            }
        }
        //*////////////////////////////////^//////////////^////////////////////////////////*//
        //*////////////////////////////////|/// классы ///|////////////////////////////////*//
        //*////////////////////////////////|//////////////|////////////////////////////////*//
        ////////////////////////////////////// ходы //////////////////////////////////////
        private int gameStep = 0;
        public int GetGameStep()
        {
            return gameStep;
        }
        ////////////////////////////////////// чит меню //////////////////////////////////////
        private DebugMenu debugMenu = new DebugMenu();
        public string DebugMenuInput(string command)//ChetsMenu)))))
        {
            return debugMenu.InputComand(command, fractions[0]);
        }
        ////////////////////////////////////// фракции //////////////////////////////////////
        private List<Fraction> fractions = new List<Fraction>(); // главный лист фракций
        private List<string> ActiveFraction = new List<string>(); // лист еще живых фракций
        private List<int> ActiveFractionIndex = new List<int>(); // индекс еще живых фракций
        public void UpdateActiveFraction() // обновление списка имен фракций
        {
            ActiveFraction.Clear();
            for (int i = 0; i < fractions.Count; i++)
            {
                if (fractions[i].isLife)
                {
                    ActiveFraction.Add(fractions[i].name);
                    ActiveFractionIndex.Add(i);
                }
            }
        }
        public List<string> GetActiveFractions() // получение списка имен фракций
        {
            UpdateActiveFraction();
            return ActiveFraction;
        }
        public List<int> GetActiveFractionsIndex() // получение
        {
            UpdateActiveFraction();
            return ActiveFractionIndex;
        }
        public void GameLoad() // наполнение мира всяким многим в лист fractions
        {
            // планеты
            Planet PTerra = new Planet("Терра", "Загрезненная, но любимая планета империума, так как там зарадился империум.");
            Planet PUpeter = new Planet("марс", "Пусстынная планета, пустая и не приспасобленна к жизни.");
            Planet PHorrud = new Planet("Хоруд", "Теплая, влажная планета с кислотными дождями.");
            // листы планет
            List<Planet> LPXenomorph = new List<Planet>(); LPXenomorph.Add(PHorrud);
            List<Planet> LPHuman = new List<Planet>(); LPHuman.Add(PTerra);
            List<Planet> LPXen = new List<Planet>(); LPXen.Add(PUpeter);
            // гены
            Gene GXenomorph = new Gene("Ксеноморф", "Стандартный ген ксеноморфов.", 12, 8, 10, 3);
            Gene GHuman = new Gene("Хомосапиенс", "Хомосапиенс, существо слабое но очень умное.", 8, 2, 2, 2);
            Gene GXen = new Gene("Зен", "Неизвестно откуда, но они появились в галактике.", 10, 4, 20, 4);
            // формы жизни
            FormOfLife FOLXenomorph = new FormOfLife("Ксеноморф стандарт", "Пугающий захватчик галактик, идеальный хищник, в крови котоого циркулирует кислота!", GXenomorph);
            FormOfLife FOLHuman = new FormOfLife("Человек", "Умственно развитый социальный ораганизм, но очень слабый.", GHuman);
            FormOfLife FOLXen = new FormOfLife("Зен", "Захватчики из другого мира, бмногое неизвестно!", GXen);
            // листы формы жизни
            List<FormOfLife> LFOLXenomorph = new List<FormOfLife>();
            List<FormOfLife> LFOLHuman = new List<FormOfLife>();
            List<FormOfLife> LFOLXen = new List<FormOfLife>();
            // заполнение литса
            LFOLXenomorph.Add(FOLXenomorph);
            LFOLHuman.Add(FOLHuman);
            LFOLXen.Add(FOLXen);
            // фракции
            Fraction FPlayer = new Fraction("Рой", "Общий разум под управлением королев и короля.", LFOLXenomorph, LPXenomorph);
            Fraction FHuman = new Fraction("Империум Человечества", "Доминирующий разумный вид Галактики.", LFOLHuman, LPHuman);
            Fraction FXen = new Fraction("Зен", "Группа видов с огромной выживаемостью, управляется огромным друвним существом из другого мира", LFOLXen, LPXen);
            // командиры
            Comander CXking = new Comander("Император ксеноморфов", "Король хорошо командует атакой, но и защищает", 3, 1);
            Comander CXqueen1 = new Comander("Императрица кримсон", "Власть королевы на поле битвы дает защиту", 0, 4);
            Comander CXqueen2 = new Comander("Императрица даедалус", "Власть королевы воодушевляет атаку", 4, 0);
            Comander CXqueen3 = new Comander("Императрица диадема", "Власть королевы, которая во всем хороша", 2, 2);
            Comander CHImperator = new Comander("Бессмертный мператор", "Родился примерно за 9 000 лет до н.э. Именно он объединил враждующие остатки человечества и повёл их на путь возрождения утраченной звёздной империи.", 5, 0);
            Comander CXGabenBaby = new Comander("Неизвестный", "Не известное огромное и сильное сущетсво.", 2, 1);
            // заполнение командиров
            FPlayer.comanders.Add(CXking);
            FPlayer.comanders.Add(CXqueen1);
            FPlayer.comanders.Add(CXqueen2);
            FPlayer.comanders.Add(CXqueen3);
            FHuman.comanders.Add(CHImperator);
            FXen.comanders.Add(CXGabenBaby);
            // лист фракций
            fractions.Add(FPlayer);
            fractions.Add(FHuman);
            fractions.Add(FXen);
        }
        ////////////////////////////////////// вывод списков //////////////////////////////////////
        public List<string> GetComanderList() // список командиров
        {
            List<string> comanders = new List<string>();
            for (int i = 0; i < fractions[0].comanders.Count; i++)
            {
                comanders.Add(fractions[0].comanders[i].name);
            }
            return comanders;
        }
        public List<string> GetBioWeaponList() // список био оружия
        {
            List<string> bioWeapons = new List<string>();
            for (int i = 0; i < fractions[0].bioWeapons.Count; i++)
            {
                bioWeapons.Add(fractions[0].bioWeapons[i].name);
            }
            return bioWeapons;
        }
        public List<string> GetGeneList() // список генов
        {
            List<string> genes = new List<string>();
            for (int i = 0; i < fractions[0].geneStealed.Count; i++)
            {
                genes.Add(fractions[0].geneStealed[i].name);
            }
            return genes;
        }
        ////////////////////////////////////// управление //////////////////////////////////////
        public void IsGameOver()
        {
            if (fractions[0].isLife == false)
            {
                MessageBox.Show($"Вы проиграли... Поздравляю с тем что ты дошел до {gameStep} хода!", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
        public void GameUpdate()
        {
            gameStep++;
            IsGameOver();
            for (int i = 0; i < fractions.Count; i++)
            {
                fractions[i].ReproductionFormOfLive();
            }
        }
        public void PlayerSkip() // пропуск хода
        {
            GameUpdate();
        }
        public string PlayerWar(int indexFraction, int indexComander, int indexBioWeapon) // война
        {
            GameUpdate();
            return fractions[0].War(fractions[indexFraction], fractions[0].comanders[indexComander], fractions[0].bioWeapons[indexBioWeapon]);
        }
        public bool PlayerCreateFormOfLife(string name, string description, int indexGene1, int indexGene2)
        {
            return fractions[0].CreateFormOfLive(name, description, fractions[0].geneStealed[indexGene1], fractions[0].geneStealed[indexGene2]);
        }
        /////////////////////////////////////// вывод информации ///////////////////////////////////////
        public string GetLoreFraction(int indexFraction) // лор своей фракции
        {
            Fraction fraction = fractions[indexFraction];
            string Lore = string.Empty;
            Lore += "-----*:фракция:*-----" + Environment.NewLine;
            Lore += fraction.GetLore();
            Lore += Environment.NewLine; Lore += Environment.NewLine;
            Lore += "*-*Командование*-*:" + Environment.NewLine;
            for (int i = 0; i < fraction.comanders.Count; i++)
            {
                Lore += fraction.comanders[i].GetLore();
            }
            Lore += Environment.NewLine; Lore += Environment.NewLine;
            Lore += "*-*Формы жизни*-*:" + Environment.NewLine;
            for (int i = 0; i < fraction.formsOfLife.Count; i++)
            {
                Lore += fraction.formsOfLife[i].GetLore();
                Lore += "Население = " + fraction.formsOfLifeCount[i] + Environment.NewLine;
            }
            Lore += Environment.NewLine; Lore += Environment.NewLine;
            Lore += "*-*Технологии био оружия*-*:" + Environment.NewLine;
            for (int i = 0; i < fraction.bioWeapons.Count; i++)
            {
                Lore += fraction.bioWeapons[i].GetLore();
            }
            Lore += Environment.NewLine; Lore += Environment.NewLine;
            Lore += "*-*Украденые гены*-*:" + Environment.NewLine;
            for (int i = 0; i < fraction.geneStealed.Count; i++)
            {
                Lore += Lore += fraction.geneStealed[i].GetLore();
            }
            Lore += Environment.NewLine; Lore += Environment.NewLine;
            Lore += "*-*Планеты*-*:" + Environment.NewLine;
            for (int i = 0; i < fraction.planets.Count; i++)
            {
                Lore += fraction.planets[i].GetLore();
            }
            return Lore;
        }
        public List<string> GetLoreFractionName()
        {
            List<string> names = new List<string>();
            for (int i = 0; i < fractions.Count; i++)
            {
                names.Add(fractions[i].name);
            }
            return names;
        }
        public int GetLoreCountOfFractions()
        {
            return fractions.Count;
        }
    }
}