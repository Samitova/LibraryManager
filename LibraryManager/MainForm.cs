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

            MessageBox.Show("New book was added");
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

               
                if (_searchedBooks.Find(b => b.Id == id) != null)
                    _searchedBooks.Remove(book);

                dataGridViewBooks.Update();

                MessageBox.Show($"Book \"{book.Title}\" was deleted");
            }
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();

            DialogResult result = authorForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

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

            MessageBox.Show("New author was added");
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

                MessageBox.Show($"Author {author.FullName} was deleted");
            }
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            BookSearchForm bookSearchForm = new BookSearchForm();

            DialogResult result = bookSearchForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            _searchedBooks.Clear();

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
                    _searchedBooks.AddRange(bookIQuer.Where(p => p.Genre == genre).ToList<Book>());
                }
            }
            else
                _searchedBooks.AddRange(bookIQuer.ToList<Book>());

            dataGridViewBooks.DataSource = _searchedBooks;
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = db.Books.Local.ToBindingList();
        }
    }
}
