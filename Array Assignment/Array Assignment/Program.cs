using System;
using System.Collections.Generic;


namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a name.");
            //string[] names = new string[4];

            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Your names listed in an array are...");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i] + "");

            //}
            //Console.ReadLine();


            //for (int a = 0; a < 100; a++) changed "a--" to "a++" to fix infinite loop.
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();


            //List<int> birthYears= new List<int>();
            //birthYears.Add(1991);
            //birthYears.Add(1992);
            //birthYears.Add(1989);
            //birthYears.Add(1979);
            //birthYears.Add(1998);
            //birthYears.Add(1994);

            //foreach (int year in birthYears)
            //{
            //    if (year < 1991)
            //    {
            //        Console.WriteLine("The birth years are:" + year);
            //    }
            //}
            //Console.ReadLine();


            //List<int> birthYears = new List<int>();
            //birthYears.Add(1991);
            //birthYears.Add(1992);
            //birthYears.Add(1989);
            //birthYears.Add(1979);
            //birthYears.Add(1998);
            //birthYears.Add(1994);

            //foreach (int year in birthYears)
            //{
            //    if (year <= 1994)
            //    {
            //        Console.WriteLine("The birth years are:" + year);
            //    }
            //}
            //Console.ReadLine();


            //List<string> zooAnimals = new List<string>();
            //zooAnimals.Add("zebra");
            //zooAnimals.Add("snake");
            //zooAnimals.Add("bear");
            //zooAnimals.Add("elephant");

            //Console.WriteLine("Please enter an animal you would find at the zoo.");
            //string animal = Console.ReadLine();
            //bool animalFound = false;

            //do
            //{
            //    switch (animal)
            //    {
            //        case "zebra":
            //            Console.WriteLine("Congratulations you picked the right animal! "+ animal);
            //            Console.ReadLine();
            //            animalFound = true;
            //            break;

            //        case "snake":
            //            Console.WriteLine("Congratulations you picked the right animal " + animal);
            //            Console.ReadLine();
            //            animalFound = true;
            //            break;

            //        case "bear":
            //            Console.WriteLine("Congratulations you picked the right animal! "+ animal);
            //            Console.ReadLine();
            //            animalFound = true;
            //            break;

            //        case "elephant":
            //            Console.WriteLine("Congratulations you picked the right animal! "+ animal);
            //            Console.ReadLine();
            //            animalFound = true;
            //            break;

            //        default:
            //            Console.WriteLine("Try again. Please enter an animal you would find at a zoo.");
            //            animal = Console.ReadLine();
            //            break;
            //    }
            //}
            //while (!animalFound);


            //List<string> favoriteTeams = new List<string>();
            //favoriteTeams.Add("Packers");
            //favoriteTeams.Add("Packers");
            //favoriteTeams.Add("Suns");
            //favoriteTeams.Add("RedWings");

            //Console.WriteLine("Please enter one of my favorite teams.");
            //string team = Console.ReadLine();
            //bool teamFound = false;
            //for (int i = 0; i < favoriteTeams.Count; i++)
            //{
            //    if (favoriteTeams[i] == team)
            //    {
            //        Console.WriteLine("Congratulations you picked the right team!" + team);
            //        teamFound = true;
            //        Console.ReadLine();
            //    }
            //    else if (!teamFound)
            //    {
            //        Console.WriteLine("Sorry you entered a team that is not in the list. Try again.");
            //        Console.ReadLine();




            List<string> fruitNames = new List<string>();
            fruitNames.Add("orange");
            fruitNames.Add("banana");
            fruitNames.Add("apple");
            fruitNames.Add("orange");

            foreach (string name in fruitNames)
            {
                if (name == "orange")
                {
                    Console.WriteLine(name);
                }
                
            }
            Console.WriteLine("This fruit has already appeared in the list.");
            Console.ReadLine();
         }
        
      }
    }



    
