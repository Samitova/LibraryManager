using DataManager;
using System;
using System.Windows.Forms;

namespace ClientManager
{
    public partial class BookSearchForm : Form
    {
        public BookSearchForm()
        {
            InitializeComponent();
            checkedListBoxSearchGenre.DataSource = Enum.GetNames(typeof(BookGenre));
        }
    }
}
