using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNames
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookContext())
            {
                db.Books.Add(new Book { Title = "Introduction to Programming" });
                db.SaveChanges();

                foreach (var book in db.Books)
                {
                    Console.WriteLine(book.Title);
                    Console.ReadLine();
                }
            }
        }
    }
}
