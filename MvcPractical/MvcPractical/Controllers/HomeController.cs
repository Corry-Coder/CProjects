using MvcPractical.Models;
using MvcPractical.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPractical.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Insurance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, string carMake, string carModel, string Coverage, string dateOfBirth, int carYear, int DUI, int speedingTickets)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {

                DateTime birthday = Convert.ToDateTime(dateOfBirth);
                DateTime today = DateTime.Today;
                int age = today.Year - birthday.Year;
                int baseTotal = 50;
                int monthlyTotal = 0;
                int QuotePrice = 0;

                if (carYear < 2000)
                {
                    monthlyTotal = baseTotal + 25;
                }
                if (carYear > 2015)
                {
                    monthlyTotal = monthlyTotal + 25;
                }
                if (carMake == "Porsche" && carModel == "911 Carrera")
                {
                    monthlyTotal = monthlyTotal + 25;
                }
                if (carMake == "Porsche")
                {
                    monthlyTotal = monthlyTotal + 25;
                }
                if (Coverage == "full")
                {
                    monthlyTotal = monthlyTotal + 50 / 100;
                }
                if (DUI > 0)
                {
                    monthlyTotal = monthlyTotal + 25 / 100;
                }
                if (speedingTickets > 0)
                {
                    monthlyTotal = monthlyTotal + (10 * speedingTickets);
                }
                if (age < 25)
                {
                    monthlyTotal = monthlyTotal + 25;
                }
                if (age < 18)
                {
                    monthlyTotal = monthlyTotal + 100;
                }
                if (age > 100)
                {
                    monthlyTotal = monthlyTotal + 25;
                }
                monthlyTotal = monthlyTotal + baseTotal;
                QuotePrice = monthlyTotal;

                var quote = new Quote();
                quote.FirstName = firstName;
                quote.LastName = lastName;
                quote.EmailAddress = emailAddress;
                quote.CarMake = carMake;
                quote.CarModel = carModel;
                quote.Coverage = Coverage;
                quote.DateOfBirth = dateOfBirth;
                quote.CarYear = carYear;
                quote.DUI = DUI;
                quote.SpeedingTickets = speedingTickets;
                quote.QuotePrice = QuotePrice;
                db.Quotes.Add(quote);               
                db.SaveChanges();
            }

            return View("Success");
        }
    }
}