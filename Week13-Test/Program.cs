using System;
using System.IO;

namespace Week13_Test
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Radnom facts so interesting you'll say omg
            Console.WriteLine(GetRandomFact());
        }

        public static string GetRandomFact()
        {
            string filePath = @"C:\Users\opilane\Samples\RandomFactsSoInteresting.txt";
            string[] RandomFact = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, RandomFact.Length);

            return RandomFact[randomIndex];


            



        }
    }
}
