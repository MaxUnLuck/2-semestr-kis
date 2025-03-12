using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AirHubSulemanov6_1
{
    internal class AirHub
    {
        private static AirHub instance;
        private List<Line> lines;
        private int CountOfLines;
        private AirHub(int CountOfLines_) 
        {
            CountOfLines = CountOfLines_;
            lines = new List<Line>();
        }
        public void updateLines()
        {
            Random random = new Random();
            for (int i = 0; i < CountOfLines; i++)
            {
                lines[i].UpDate(random.Next(lines[i].GetCountOfListOfPlane()));
            }
        }
        public void CreateLines()
        {
            Random random = new Random();
            for (int i = 0; i < CountOfLines; i++)
            {
                Line line = new Line(1);
                line.UpDate(random.Next(line.GetCountOfListOfPlane()));
                lines.Add(line);
            }
        }
        public string GetInfo()
        {
            string listOfPlane = string.Empty;
            listOfPlane += "*-------------------------------------cписок-------------------------------------*" + Environment.NewLine;
            for (int i = 0; i < lines.Count; i++)
            {
                listOfPlane += " [ " + (i + 1) + " ] - " + lines[i].GetPlane() + Environment.NewLine;
                listOfPlane += "*------------------------------------------------------------------------------------*" + Environment.NewLine;
            }
            return listOfPlane;
        }
        public static AirHub GetInstance(int CountOfLines)
        {
            if (instance == null)
            {
                instance = new AirHub(CountOfLines);
            }
            return instance;
        }
    }
}
