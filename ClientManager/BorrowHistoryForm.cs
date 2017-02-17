using System;
using System.Windows.Forms;

namespace ClientManager
{
    public partial class BorrowHistoryForm : Form
    {
        public BorrowHistoryForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
