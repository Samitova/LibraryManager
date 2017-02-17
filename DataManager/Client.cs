using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName { get { return $"{FirstName} {SecondName}"; } }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Book> BorrowedBooks { get; set; }

        public Client()
        {
            BorrowedBooks = new List<Book>();
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
