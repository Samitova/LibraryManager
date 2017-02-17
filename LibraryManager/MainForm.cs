using DataManager;
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

namespace LibraryManager
{
    public partial class MainForm : Form
    {
        private LibraryContext _db;
        public List<Book> SearchedBooks { get; set; }
        public List<Author> SearchedAuthors { get; set; }
        
        public MainForm()
        {
            InitializeComponent();
            _db = new LibraryContext();
            SearchedBooks = new List<Book>();
            SearchedAuthors = new List<Author>();
            _db.Books.Load();
            _db.Authors.Load();
            dataGridViewBooks.DataSource = _db.Books.Local.ToBindingList();
            dataGridViewAuthors.DataSource = _db.Authors.Local.ToBindingList();            
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(_db);
            bookForm.Owner = this;
            bookForm.Show();

            bindingSourceBookSearch.DataSource = null;
            bindingSourceBookSearch.DataSource = SearchedBooks;
        }

        private void btnBookChange_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int index = dataGridViewBooks.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewBooks[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Book book = _db.Books.Find(id);

                BookForm bookForm = new BookForm(_db);
                bookForm.textBoxTitle.Text = book.Title;
                bookForm.textBoxPublishing.Text = book.PublishingDate.ToString();

                bookForm.comboBoxGenre.SelectedIndex = (int)book.Genre;

                if (book.Author != null)
                    bookForm.comboBoxAuthor.SelectedValue = book.Author.Id;

                DialogResult result = bookForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                book.Title = bookForm.textBoxTitle.Text;
                book.Author = (Author)bookForm.comboBoxAuthor.SelectedItem;
                book.Genre = (BookGenre)Enum.Parse(typeof(BookGenre), bookForm.comboBoxGenre.SelectedValue.ToString());

                int publishingDate = 0;
                if (int.TryParse(bookForm.textBoxPublishing.Text, out publishingDate))
                {
                    book.PublishingDate = publishingDate;
                    _db.Entry(book).State = EntityState.Modified;
                    _db.SaveChanges();

                    MessageBox.Show($"Book \"{book.Title}\" was updated");
                }                                               
            }
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int index = dataGridViewBooks.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewBooks[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Book book = _db.Books.Find(id);
                _db.Books.Remove(book);
                _db.SaveChanges();

                // delete book from search result
                if (SearchedBooks.Find(b => b.Id == id) != null)
                    SearchedBooks.Remove(book);

                bindingSourceBookSearch.DataSource = null;
                bindingSourceBookSearch.DataSource = SearchedBooks;

                MessageBox.Show($"Book \"{book.Title}\" was deleted");
            }
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm(_db);           
            authorForm.Owner = this;
            authorForm.Show();            
        }
     
        private void btnAuthorChange_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthors.SelectedRows.Count > 0)
            {
                int index = dataGridViewAuthors.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewAuthors[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Author author = _db.Authors.Find(id);

                AuthorForm authorForm = new AuthorForm(_db);
                authorForm.textBoxFirstName.Text = author.FirstName;
                authorForm.textBoxSecondName.Text = author.SecondName;
                authorForm.textBoxBirthDate.Text = author.BirthDate.ToString("dd.MM.yyyy");

                DialogResult result = authorForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                author.FirstName = authorForm.textBoxFirstName.Text;
                author.SecondName = authorForm.textBoxSecondName.Text;

                DateTime birthDate = DateTime.Now;
                if (DateTime.TryParse(authorForm.textBoxBirthDate.Text, out birthDate))
                {
                    author.BirthDate = birthDate;
                    _db.Entry(author).State = EntityState.Modified;
                    _db.SaveChanges();

                    MessageBox.Show($"Author {author.FullName} was updated");
                }                                         
            }
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthors.SelectedRows.Count > 0)
            {
                int index = dataGridViewAuthors.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewAuthors[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Author author = _db.Authors.Find(id);
                _db.Authors.Remove(author);
                _db.SaveChanges();

                // delete author from search result
                if (SearchedAuthors.Find(a => a.Id == id) != null)
                    SearchedAuthors.Remove(author);

                bindingSourceAuthorSearch.DataSource = null;
                bindingSourceAuthorSearch.DataSource = SearchedAuthors;

                MessageBox.Show($"Author {author.FullName} was deleted");
            }
        }

        private async void btnBookSearch_Click(object sender, EventArgs e)
        {
            BookSearchForm bookSearchForm = new BookSearchForm();

            DialogResult result = bookSearchForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            SearchedBooks.Clear();

            SearchedBooks = await SearchBooks(bookSearchForm);

            bindingSourceBookSearch.DataSource = SearchedBooks;
            dataGridViewBooks.DataSource = bindingSourceBookSearch;
        }

        private Task<List<Book>> SearchBooks(BookSearchForm bookSearchForm)
        {
            return Task.Run(() => {
                List<Book> searchResult = new List<Book>();
                IQueryable<Book> bookIQuer = _db.Books;
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

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = _db.Books.Local.ToBindingList();
        }

        private async void btnAuthorSearch_Click(object sender, EventArgs e)
        {
            AuthorSearchForm authorSearchForm = new AuthorSearchForm();

            DialogResult result = authorSearchForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            SearchedAuthors.Clear();

            SearchedAuthors = await SearchAuthors(authorSearchForm);

            bindingSourceAuthorSearch.DataSource = SearchedAuthors;
            dataGridViewAuthors.DataSource = bindingSourceAuthorSearch;
        }

        private Task<List<Author>> SearchAuthors(AuthorSearchForm authorSearchForm)
        {
            return Task.Run(() => {
                IQueryable<Author> authorIQuer = _db.Authors;
                List<Author> searchedResult = new List<Author>();
                if (!string.IsNullOrWhiteSpace(authorSearchForm.textBoxSearchFirstName.Text))
                    authorIQuer = authorIQuer.Where(p => p.FirstName.Contains(authorSearchForm.textBoxSearchFirstName.Text));

                if (!string.IsNullOrWhiteSpace(authorSearchForm.textBoxSearchSecondName.Text))
                    authorIQuer = authorIQuer.Where(p => p.SecondName.Contains(authorSearchForm.textBoxSearchSecondName.Text));

                DateTime birthDate = DateTime.Now;
                if (!string.IsNullOrWhiteSpace(authorSearchForm.textBoxSearchBirth.Text)
                    && DateTime.TryParse(authorSearchForm.textBoxSearchBirth.Text, out birthDate))
                    authorIQuer = authorIQuer.Where(p => p.BirthDate == birthDate);

                searchedResult.AddRange(authorIQuer.ToList<Author>());

                return searchedResult;
            });          
        }

        private void btnAllAuthors_Click(object sender, EventArgs e)
        {
            dataGridViewAuthors.DataSource = _db.Authors.Local.ToBindingList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Dispose();
        }
    }
}
