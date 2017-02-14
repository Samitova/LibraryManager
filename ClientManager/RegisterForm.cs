using LibraryManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManager
{
    public partial class RegisterForm : Form
    {
        private LibraryContext _db;

        public RegisterForm(LibraryContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRegPassword.Text)
                || string.IsNullOrWhiteSpace(textBoxRegComfPaswd.Text)
                || string.IsNullOrWhiteSpace(textBoxRegLogin.Text)
                || string.IsNullOrWhiteSpace(textBoxFirstName.Text)
                || string.IsNullOrWhiteSpace(textBoxSecondName.Text))
                MessageBox.Show("Input information, please");
            else if (textBoxRegPassword.Text != textBoxRegComfPaswd.Text)
                MessageBox.Show("Wrong password confirmation");
            else if (_db.Clients.FirstOrDefault(c => c.Login == textBoxRegLogin.Text) != null)
                MessageBox.Show("Such user is existed allready. Choose another login, please");
            else
            {
                Client client = new Client();
                client.FirstName = textBoxFirstName.Text;
                client.SecondName = textBoxSecondName.Text;
                client.Login = textBoxRegLogin.Text;
                client.Password = textBoxRegPassword.Text;

                _db.Clients.Add(client);
                _db.SaveChanges();

                this.Close();
                MessageBox.Show("Thank you for registration");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
