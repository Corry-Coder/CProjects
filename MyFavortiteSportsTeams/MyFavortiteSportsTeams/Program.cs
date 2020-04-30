using System;
using System.Data.Entity;

namespace MyFavortiteSportsTeams
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SurveyContext())
            {
                db.Teams.Add(new Survey { Name = "Corry", BasketBall = "Phoenix Suns", Football = "Green Bay Packers" });
                db.SaveChanges();

                foreach (var survey in db.Teams)
                {
                    Console.WriteLine(db.Teams);
                }
            }
        }      
    }
}
