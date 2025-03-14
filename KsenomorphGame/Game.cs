using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsenomorphGame
{
    internal class Game // фасад
    {
        private int GameStep = 0;
        private List<Fraction> fractions = new List<Fraction>();



        public void GameLoad() 
        {
            // планеты
            Planet PTerra = new Planet("Терра", "Загрезненная, но любимая планета империума, так как там зарадился империум.", 10);
            Planet PUpeter = new Planet("марс", "Пусстынная планета, пустая и не приспасобленна к жизни.", 1);
            Planet PHorrud = new Planet("Хоруд", "Теплая, влажная планета с кислотными дождями.", 5);
            // листы планет
            List<Planet> LPXenomorph = new List<Planet>(); LPXenomorph.Add(PHorrud);
            List<Planet> LPHuman = new List<Planet>(); LPHuman.Add(PTerra);
            List<Planet> LPXen = new List<Planet>(); LPXen.Add(PUpeter);
            // гены
            Gene GXenomorph = new Gene("Ксеноморф", "Стандартный ген ксеноморфов.", 12, 8, 10, 100);
            Gene GHuman = new Gene("Хомосапиенс", "Хомосапиенс, существо слабое но очень умное.", 8, 2, 2, 2);
            Gene GXen = new Gene("Зен", "Неизвестно откуда, но они появились в галактике.", 10, 4, 20, 60);
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
            Fraction FPlayer = new Fraction("Рой", "Общий разум под управлением королев.", LFOLXenomorph, LPXenomorph);
            Fraction FHuman = new Fraction("Империум Человечества", "Доминирующий разумный вид Галактики.", LFOLHuman, LPHuman);
            Fraction FXen = new Fraction("Зен", "Группа видов с огромной выживаемостью, управляется огромным друвним существом из другого мира", LFOLXen, LPXen);
            // лист фракций
            fractions.Add(FPlayer);
            fractions.Add(FHuman);
            fractions.Add(FXen);
        }



        public void IsGameOver()
        {
            if (fractions[0].isLife == false)
            {
                MessageBox.Show("Вы проиграли...", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }



        public void GameUpdate()
        {
            IsGameOver();
            GameStep++;
            // STUPED AI
            Random random = new Random();
            for (int i = 1; i < fractions.Count; i++)
            {
                fractions[i].War(fractions[random.Next(0, fractions.Count)]);
            }
        }



        public string PlayerWar(Fraction fraction)
        {
            IsGameOver();
            fractions[0].War(fraction);
            GameUpdate();
            return fractions[0].LastWarHistory;
        }



        public void PlayerSkip()
        {
            IsGameOver();
            GameUpdate();
        }



        public bool PlayerCreateFormOfLife(string name, string description, Gene gene2, Gene gene3)
        {
            IsGameOver();
            if (fractions[0].formsOfLifeCount[0] > 2000)
            {
                FormOfLife newFormOfLive = new FormOfLife(name, description, fractions[0].formsOfLife[0].genes[0]);
                newFormOfLive.genes[1] = gene2;
                newFormOfLive.genes[2] = gene3;
                fractions[0].formsOfLife.Add(newFormOfLive);
                fractions[0].formsOfLifeCount[0] -= 1000;
                fractions[0].formsOfLifeCount.Add(1000);
                return true;
            }
            else
            {
                return false;
            }
        }



        //ChetsMenu)))))

        public string InputComand(string comand)
        {
            try
            {
                string[] commands = comand.Split(' ', '(', ')', ',');
                if (commands[0] == "PAddFOLCount") // PAddFOLCount(FOLName, INT) Увелечение своей армии
                {
                    bool isSearched = false;
                    for (int i = 1; i < fractions[0].formsOfLife.Count; i++)
                    {
                        if (fractions[0].formsOfLife[i].name == commands[1])
                        {
                            fractions[0].formsOfLifeCount[i] = Convert.ToInt32(commands[2]);
                            isSearched = true;
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
}
