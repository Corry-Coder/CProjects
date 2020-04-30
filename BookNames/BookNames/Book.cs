using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNames
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
    }
    public class BookContext : DbContext
    {
        public BookContext() : base("BookContext")
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
