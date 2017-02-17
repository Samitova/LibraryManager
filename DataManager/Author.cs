using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName { get { return $"{FirstName} {SecondName}"; } }
        public DateTime BirthDate { get; set; }
        
        public virtual ICollection<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }

        public override string ToString()
        {
            return FullName;
        }

    }
}
