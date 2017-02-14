using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class BookForm : Form
    {
        private LibraryContext _db;
        public BookForm(LibraryContext db)
        {
            InitializeComponent();
            _db = db;
            comboBoxGenre.DataSource = Enum.GetNames(typeof(BookGenre));

            List<Author> authors = _db.Authors.ToList();
            comboBoxAuthor.DataSource = authors;
            comboBoxAuthor.ValueMember = "Id";
            comboBoxAuthor.DisplayMember = "FullName";
        }

      
        private void btnOK_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            int publishingDate = 0;

            if (string.IsNullOrWhiteSpace(textBoxTitle.Text)
            || string.IsNullOrWhiteSpace(textBoxPublishing.Text))
            {
                MessageBox.Show("Input data, please");
            }
            else if (!int.TryParse(textBoxPublishing.Text, out publishingDate))
            {
                MessageBox.Show("Incorrect Publishing date");
            }
            else
            {
                book.Title = textBoxTitle.Text;
                book.Author = (Author)comboBoxAuthor.SelectedItem;
                book.Genre = (BookGenre)Enum.Parse(typeof(BookGenre), comboBoxGenre.SelectedValue.ToString());
                book.PublishingDate = publishingDate;

                _db.Books.Add(book);
                _db.SaveChanges();

                MainForm main = (MainForm)Owner;
                main.SearchedBooks.Add(book);
                this.Close();
                MessageBox.Show("New book was added");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
