using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\Corry\source\repos\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tscore = 0.0;

            Console.WriteLine("/nStudent Scores: \n");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tscore += score;
            }


            double avgScore = tscore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);


            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
