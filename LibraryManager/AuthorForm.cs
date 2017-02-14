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
    public partial class AuthorForm : Form
    {
        private LibraryContext _db;

        public AuthorForm(LibraryContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime birthDate = DateTime.Now;
            Author author = new Author();

            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) || string.IsNullOrWhiteSpace(textBoxSecondName.Text)
                || string.IsNullOrWhiteSpace(textBoxBirthDate.Text))
            {
                MessageBox.Show("Input data, please");
            }
            else if (!DateTime.TryParse(textBoxBirthDate.Text, out birthDate))
            {
                MessageBox.Show("Incorrect Birth date");
            }
            else
            {
                author.FirstName = textBoxFirstName.Text;
                author.SecondName = textBoxSecondName.Text;
                author.BirthDate = birthDate;

                _db.Authors.Add(author);
                _db.SaveChanges();
                MainForm main = (MainForm)Owner;

                main.SearchedAuthors.Add(author);
                main.bindingSourceAuthorSearch.DataSource = null;
                main.bindingSourceAuthorSearch.DataSource = main.SearchedAuthors;

                this.Close();

                MessageBox.Show("New author was added");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
