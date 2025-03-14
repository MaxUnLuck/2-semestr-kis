using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsenomorphGame
{
    internal class Game
    {
        public void GameLoad() 
        {
            // планеты
            Planet PTerra = new Planet("Терра", "Загрезненная, но любимая планета империума, так как там зарадился империум.", 10);
            Planet PUpeter = new Planet("марс", "Пусстынная планета, пустая и не приспасобленна к жизни.", 1);
            Planet PHorrud = new Planet("Хоруд", "Теплая, влажная планета с кислотными дождями.", 5);
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
            Fraction FPlayer = new Fraction("Рой", "Общий разум под управлением королев.", LFOLXenomorph);
            Fraction FHuman = new Fraction("Империум Человечества", "Доминирующий разумный вид Галактики.", LFOLHuman);
            Fraction FXen = new Fraction("Зен", "Группа видов с огромной выживаемостью, управляется огромным друвним существом из другого мира", LFOLXen);
            // лист фракций
            List<Fraction> fractions = new List<Fraction>();
            fractions.Add(FPlayer);
            fractions.Add(FHuman);
            fractions.Add(FXen);

        }
        
    }
}
