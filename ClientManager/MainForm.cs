using LibraryManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManager
{
    public partial class MainForm : Form
    {
        private LibraryContext _db;

        List<Book> _searchedBooks = new List<Book>();

        public Client Client { get; set; }       

        public MainForm()
        {
            InitializeComponent();
            _db = new LibraryContext();
            _db.Clients.Load();
            _db.Books.Load();            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(_db);
            loginForm.Owner = this;
            loginForm.Show();           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_db);

            registerForm.Owner = this;
            registerForm.Show();

         
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            UpdateBooks();
        }

        internal void UpdateBooks()
        {
            IQueryable<Book> bookAllIQuer = _db.Books.Where(p => p.Client == null);             
            dataGridViewAllBooks.DataSource = bookAllIQuer.ToList<Book>();

            IQueryable<Book> bookClientIQuer = _db.Books.Where(p => p.ClientId == Client.Id);             
            dataGridViewClientBooks.DataSource = bookClientIQuer.ToList<Book>();
        }

        private void btnBookBorrow_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllBooks.SelectedRows.Count > 0)
            {
                int index = dataGridViewAllBooks.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewAllBooks[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Book book = _db.Books.Find(id);
                book.Client = Client;
                _db.Entry(book).State = EntityState.Modified;

                _db.SaveChanges();

                Borrow borrow = new Borrow();
                borrow.Book = book;
                borrow.AutorFullName = book.Author.FullName;               
                borrow.Client = Client;
                borrow.Borrowed = DateTime.Now;
                
                _db.Borrows.Add(borrow);

                _db.SaveChanges();

                UpdateBooks();               
            }
        }

        private async void btnBookSearch_Click(object sender, EventArgs e)
        {
            BookSearchForm bookSearchForm = new BookSearchForm();

            DialogResult result = bookSearchForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            _searchedBooks.Clear();

            _searchedBooks = await SearchBooks(bookSearchForm);

            bindingSourceBookSearch.DataSource = _searchedBooks;
            dataGridViewAllBooks.DataSource = bindingSourceBookSearch;
        }

        private Task<List<Book>> SearchBooks(BookSearchForm bookSearchForm)
        {
            return Task.Run(() => {
                List<Book> searchResult = new List<Book>();
                IQueryable<Book> bookIQuer = _db.Books.Where(p => p.Client == null); 
                if (!string.IsNullOrWhiteSpace(bookSearchForm.textBoxSearchTitle.Text))
                    bookIQuer = bookIQuer.Where(p => p.Title.Contains(bookSearchForm.textBoxSearchTitle.Text));

                if (!string.IsNullOrWhiteSpace(bookSearchForm.textBoxSearchAuthor.Text))
                    bookIQuer = bookIQuer.Where(p => p.Author.FirstName.Contains(bookSearchForm.textBoxSearchAuthor.Text) ||
                        p.Author.SecondName.Contains(bookSearchForm.textBoxSearchAuthor.Text));

                int year = 0;
                if (!string.IsNullOrWhiteSpace(bookSearchForm.textBoxSearchPublishing.Text)
                    && int.TryParse(bookSearchForm.textBoxSearchPublishing.Text, out year))
                    bookIQuer = bookIQuer.Where(p => p.PublishingDate == year);

                if (bookSearchForm.checkedListBoxSearchGenre.CheckedItems.Count > 0)
                {
                    foreach (var item in bookSearchForm.checkedListBoxSearchGenre.CheckedItems)
                    {
                        BookGenre genre = (BookGenre)Enum.Parse(typeof(BookGenre), item.ToString());
                        searchResult.AddRange(bookIQuer.Where(p => p.Genre == genre).ToList<Book>());
                    }
                }
                else
                    searchResult.AddRange(bookIQuer.ToList<Book>());

                return searchResult;
            });
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientBooks.SelectedRows.Count > 0)
            {
                int index = dataGridViewClientBooks.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewClientBooks[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Book book = _db.Books.Find(id);
                book.Client = null;

                _db.Entry(book).State = EntityState.Modified;

                Borrow borrow = _db.Borrows.First(b => b.BookId == id && b.Returned == null);
                borrow.Returned = DateTime.Now;
                _db.Entry(borrow).State = EntityState.Modified;

                _db.SaveChanges();
                UpdateBooks();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            BorrowHistoryForm borrowHistoryForm = new BorrowHistoryForm();
            IQueryable<Borrow> borrowIQuer = _db.Borrows.Where(b => b.Client.Id == Client.Id);
            List<Borrow> borrowList = borrowIQuer.ToList<Borrow>();
            borrowHistoryForm.dataGridViewBorrow.DataSource = borrowList;
            borrowHistoryForm.Show();
        }
    }
}
