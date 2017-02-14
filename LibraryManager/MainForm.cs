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
        LibraryContext db;
        List<Book> _searchedBooks = new List<Book>();
        List<Author> _searchedAuthors = new List<Author>();

        public MainForm()
        {
            InitializeComponent();
            db = new LibraryContext();
            db.Books.Load();
            db.Authors.Load();
            dataGridViewBooks.DataSource = db.Books.Local.ToBindingList();
            dataGridViewAuthors.DataSource = db.Authors.Local.ToBindingList();            
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(db);

            DialogResult result = bookForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            AddBook(bookForm);

            MessageBox.Show("New book was added");
        }

        private void AddBook(BookForm bookForm)
        {
            Book book = new Book();
            book.Title = bookForm.textBoxTitle.Text;
            book.Author = (Author)bookForm.comboBoxAuthor.SelectedItem;
            book.Genre = (BookGenre)Enum.Parse(typeof(BookGenre), bookForm.comboBoxGenre.SelectedValue.ToString());

            int publishingDate = 0;
            if (int.TryParse(bookForm.textBoxPublishing.Text, out publishingDate))
                book.PublishingDate = publishingDate;
            else
                MessageBox.Show("Incorrect Publishing date");

            db.Books.Add(book);
            db.SaveChanges();

            _searchedBooks.Add(book);

            bindingSourceBookSearch.DataSource = null;
            bindingSourceBookSearch.DataSource = _searchedBooks;
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

                Book book = db.Books.Find(id);

                BookForm bookForm = new BookForm(db);
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
                    book.PublishingDate = publishingDate;
                else
                    MessageBox.Show("Incorrect Publishing date");

                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show($"Book \"{book.Title}\" was updated");
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

                Book book = db.Books.Find(id);
                db.Books.Remove(book);
                db.SaveChanges();

                // delete book from search result
                if (_searchedBooks.Find(b => b.Id == id) != null)
                    _searchedBooks.Remove(book);

                bindingSourceBookSearch.DataSource = null;
                bindingSourceBookSearch.DataSource = _searchedBooks;

                MessageBox.Show($"Book \"{book.Title}\" was deleted");
            }
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();

            DialogResult result = authorForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            AddAuthor(authorForm);

            MessageBox.Show("New author was added");
        }

        private void AddAuthor(AuthorForm authorForm)
        {
            Author author = new Author();
            author.FirstName = authorForm.textBoxFirstName.Text;
            author.SecondName = authorForm.textBoxSecondName.Text;

            DateTime birthDate = DateTime.Now;
            if (DateTime.TryParse(authorForm.textBoxBirthDate.Text, out birthDate))
                author.BirthDate = birthDate;
            else
                MessageBox.Show("Incorrect Birth date");

            db.Authors.Add(author);
            db.SaveChanges();

            _searchedAuthors.Add(author);

            bindingSourceAuthorSearch.DataSource = null;
            bindingSourceAuthorSearch.DataSource = _searchedAuthors;
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

                Author author = db.Authors.Find(id);

                AuthorForm authorForm = new AuthorForm();
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
                    author.BirthDate = birthDate;
                else
                    MessageBox.Show("Incorrect Birth date");

                db.Entry(author).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show($"Author {author.FullName} was updated");
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

                Author author = db.Authors.Find(id);
                db.Authors.Remove(author);
                db.SaveChanges();

                // delete author from search result
                if (_searchedAuthors.Find(a => a.Id == id) != null)
                    _searchedAuthors.Remove(author);

                bindingSourceAuthorSearch.DataSource = null;
                bindingSourceAuthorSearch.DataSource = _searchedAuthors;

                MessageBox.Show($"Author {author.FullName} was deleted");
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
            dataGridViewBooks.DataSource = bindingSourceBookSearch;
        }

        private Task<List<Book>> SearchBooks(BookSearchForm bookSearchForm)
        {
            return Task.Run(() => {
                List<Book> searchResult = new List<Book>();
                IQueryable<Book> bookIQuer = db.Books;
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
            dataGridViewBooks.DataSource = db.Books.Local.ToBindingList();
        }

        private async void btnAuthorSearch_Click(object sender, EventArgs e)
        {
            AuthorSearchForm authorSearchForm = new AuthorSearchForm();

            DialogResult result = authorSearchForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            _searchedAuthors.Clear();

            _searchedAuthors = await SearchAuthors(authorSearchForm);

            bindingSourceAuthorSearch.DataSource = _searchedAuthors;
            dataGridViewAuthors.DataSource = bindingSourceAuthorSearch;
        }

        private Task<List<Author>> SearchAuthors(AuthorSearchForm authorSearchForm)
        {
            return Task.Run(() => {
                IQueryable<Author> authorIQuer = db.Authors;
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
            dataGridViewAuthors.DataSource = db.Authors.Local.ToBindingList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }
}
