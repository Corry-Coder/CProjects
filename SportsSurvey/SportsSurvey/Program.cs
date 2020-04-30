using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSurvey
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SurveyContext())
            {
                db.Teams.Add(new Survey { Name = "Corry" });
                db.SaveChanges();

                foreach (var survey in db.Teams)
                {
                    Console.WriteLine(survey);
                    Console.ReadLine();
                }
            }
        }
    }
}
