using DataManager;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClientManager
{
    public partial class LoginForm : Form
    {
        private LibraryContext _db;

        public LoginForm(LibraryContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                MessageBox.Show("Enter login, please");
            }
            else if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Enter password, please");
            }
            else
            {
                Client client = _db.Clients
                       .FirstOrDefault(c => c.Login == textBoxLogin.Text.Trim() && c.Password == textBoxPassword.Text.Trim());
                if (client != null)
                {                       
                    MainForm main = (MainForm)Owner;                    
                    main.Client = client;

                    main.UpdateBooks();

                    main.btnLogin.Enabled = false;
                    main.btnRegister.Enabled = false;

                    main.btnAllBooks.Enabled = true;
                    main.btnBookBorrow.Enabled = true;
                    main.btnBookSearch.Enabled = true;
                    main.btnReturn.Enabled = true;
                    main.btnHistory.Enabled = true;

                    this.Close();
                }
                else
                    MessageBox.Show("No such user, register first");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
