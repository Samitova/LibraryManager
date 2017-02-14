using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public enum BookGenre
    {
        Love,
        History,
        Sciense,
        Fantasy,
        Advanture
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public BookGenre Genre { get; set; }
        public int PublishingDate { get; set; }        

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public int? ClientId { get; set; }
        public virtual Client Client { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
