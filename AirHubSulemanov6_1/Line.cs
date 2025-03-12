using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHubSulemanov6_1
{
    internal class Line
    {
        private List<string> listOfPlane = new List<string> {
            "Взлетная полоса на тех. обслуживании.",
            "На взлетной полосе авария, вызваны спасатели!",
            "Взлетная полоса пустует",
            "Взлетную полосу захватили террористы!",
            "Ан-12",
            "Airbus A320",
            "Sukhoi Superjet 100",
            "Ан-124",
            "Ан-72",
            "Ил-78М",
            "Ил-18",
            "Су-27",
            "Су-34",
            "МиГ-29",
            "МиГ-31",
            "Су-25",
            "Ан-22 Антей",
            "Ми-8",
            "Airbus A320"};
            
        private string truePlane = null;
        public int GetCountOfListOfPlane()
        {
            return listOfPlane.Count;
        }
        public Line(int rand) 
        {
            UpDate(rand);
        }
        public void UpDate(int rand)
        {
            truePlane = listOfPlane[rand];
        }
        public string GetPlane()
        {
            return truePlane;
        }
    }
}
