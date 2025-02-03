using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложение_для_БД
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.loginField.AutoSize = false;
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 60);
            this.loginField.Size = new Size(this.loginField.Size.Width, 60);
        }

        private void closebutton_Click(object sender, EventArgs e)
        {

            if (!db.Equals(null))
                db.CloseConnect();
            this.Close();
            Application.Exit();
        }

        private void closebutton_MouseEnter(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Red;
        }

        private void closebutton_MouseLeave(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Black;
        }

        Point lastpoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        DatabaseContext db = new();
        private void button1_Click(object sender, EventArgs e)
        {

            string login = loginField.Text;
            string password = passField.Text;
            if (string.IsNullOrEmpty(login) | string.IsNullOrEmpty(password))
                MessageBox.Show("Поля логина и пароля обязательны к заполнению");
            else
            {
                try
                {
                    db.CreateConnect(login, password);
                    Hide();
                    App manager = new(db);
                    manager.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
