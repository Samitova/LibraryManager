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
            BookForm bookForm = new BookForm();

            List<Author> authors = db.Authors.ToList();
            bookForm.comboBoxAuthor.DataSource = authors;
            bookForm.comboBoxAuthor.ValueMember = "Id";
            bookForm.comboBoxAuthor.DisplayMember = "FullName";

            DialogResult result = bookForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Book book = new Book();
            book.Title = bookForm.textBoxTitle.Text;
            book.Author = (Author)bookForm.comboBoxAuthor.SelectedItem;

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

                BookForm bookForm = new BookForm();
                bookForm.textBoxTitle.Text = book.Title;
                bookForm.textBoxPublishing.Text = book.PublishingDate.ToString();
                

                List<Author> authors = db.Authors.ToList();
                bookForm.comboBoxAuthor.DataSource = authors;
                bookForm.comboBoxAuthor.ValueMember = "Id";
                bookForm.comboBoxAuthor.DisplayMember = "FullName";

                if (book.Author != null)
                    bookForm.comboBoxAuthor.SelectedValue = book.Author.Id;

                DialogResult result = bookForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                book.Title = bookForm.textBoxTitle.Text;
                book.Author = (Author)bookForm.comboBoxAuthor.SelectedItem;

                int publishingDate = 0;
                if (int.TryParse(bookForm.textBoxPublishing.Text, out publishingDate))
                    book.PublishingDate = publishingDate;
                else
                    MessageBox.Show("Incorrect Publishing date");

                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Book was updated");
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

                MessageBox.Show("Book was deleted");
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

                MessageBox.Show("Author was updated");
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

                MessageBox.Show("Author was deleted");
            }
        }
    }
}
