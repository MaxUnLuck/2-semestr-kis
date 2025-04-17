using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7_1
{
    internal class Program
    {
        static private Program program;
        private Program() { }
        public class Food
        {
            public string name;
            public string description;
            public Food(string name, string description)
            {
                this.name = name;
                this.description = description;
            }
        }
        public List<Food> foodList = new List<Food>();
        static public Program GetInstance()
        {
            if (program == null)
            {
                program = new Program();
            }
            return program;
        }
        public bool settisngOpen = false;
        public bool aboutProgram = false;
    }
}
