using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Приложение_для_БД
{
    public partial class App : Form
    {
        DatabaseContext _db;
        string currenttable = string.Empty;
        Point lastpoint;

        public App(DatabaseContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void AppCloseButton_Click(object sender, EventArgs e)
        {
            _db.CloseConnect();
            this.Close();
            Application.Exit();
        }

        private void AppCloseButton_MouseEnter(object sender, EventArgs e)
        {
            AppCloseButton.ForeColor = Color.Red;
        }

        private void AppCloseButton_MouseLeave(object sender, EventArgs e)
        {
            AppCloseButton.ForeColor = Color.Black;
        }

        private void Open_Table(object sender, EventArgs e) 
        {
            dataGrid.Columns.Clear();
            currenttable = ((Button)sender).Name;
            dataGrid.DataSource = _db.GetDataTableFromTableName(currenttable);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
