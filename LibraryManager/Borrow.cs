using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class Borrow
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public string AutorFullName { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public DateTime Borrowed { get; set; }
        public DateTime? Returned { get; set; }
    }
}
