using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class LibraryContext : DbContext
    {
        static LibraryContext()
        {
            Database.SetInitializer(new LibraryContextInitializer());
        }

        public LibraryContext() : base("DefaultConnection")
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
