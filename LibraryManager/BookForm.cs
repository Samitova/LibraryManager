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
        public BookForm(LibraryContext db)
        {
            InitializeComponent();
            comboBoxGenre.DataSource = Enum.GetNames(typeof(BookGenre));

            List<Author> authors = db.Authors.ToList();
            comboBoxAuthor.DataSource = authors;
            comboBoxAuthor.ValueMember = "Id";
            comboBoxAuthor.DisplayMember = "FullName";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
