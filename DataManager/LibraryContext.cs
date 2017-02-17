using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
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
        public DbSet<Client> Clients { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
    }
}
