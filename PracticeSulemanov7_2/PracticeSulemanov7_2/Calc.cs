using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracticeSulemanov7_2
{
    internal class Calc
    {
        static Calc calc;
        public Calc() { }
        public int radius;
        public bool square;
        public bool lenght;
        public bool sectorArea;
        public string GetAnswer()
        {
            string answer = string.Empty;
            if (square)
            {
                answer += "Square = " + (Math.PI * (radius * radius));
            }
            if (lenght)
            {
                answer += "Lenght = " + (2 * Math.PI * radius);
            }
            if (sectorArea)
            {
                answer += "Sector area = " + (0.25 * Math.PI * (radius * radius));
            }
            if (!square && !lenght && !sectorArea)
            {
                answer += "There is nothing to output.";
            }
            return answer;
        }
        public static Calc GetInstance()
        {
            if (calc == null)
            {
                calc = new Calc();
            }
            return calc;
        }
    }
}
