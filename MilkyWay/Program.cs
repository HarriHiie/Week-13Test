using System;
using System.Collections.Generic;
using System.IO;

namespace Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string StarsPath = @"\Users\opilane\samples\Milky\Stars.txt";
            string PlanetsPath = @"\Users\opilane\samples\Milky\Planets.txt";
            string MilkyWayPath = @"\Users\opilane\samples\Milky\MilkyWay.txt";
            List<string> stars = new List<string>();
            List<string> planets = new List<string>();

            string[] sourceData = File.ReadAllLines(MilkyWayPath);

            foreach (string element in sourceData)
            {
                if (element.Contains("star"))
                {
                    stars.Add(element);
                }
                if (element.Contains("planet"))
                {
                    planets.Add(element);
                }
                File.WriteAllLines(StarsPath, stars);
                File.WriteAllLines(PlanetsPath, planets);
            }
        }
    }
}
