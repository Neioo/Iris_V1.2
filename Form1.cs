using Iris_V1._1.LandingPage_UC;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;

namespace Iris_V1._1
{

    public partial class Form1 : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


        public Form1()
        {
            InitializeComponent();
            Login login = new Login();
            addUserControl(login);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        string constring = "Data Source=ROGSTRIX\\SQLEXPRESS;Initial Catalog=iris;Integrated Security=True";


        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            loginCPanel.Controls.Clear();
            loginCPanel.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void dragForm(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void dragMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void dragStop(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}