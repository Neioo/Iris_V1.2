using Iris_V1._1.Dashboard;
using Iris_V1._1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Iris_V1._1
{
    public partial class Main : Form
    {

        public string emailname { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }

        private string _fname;

        public string Firstname
        {
            get { return _fname; }
        }

        string constring = "Data Source=sqldatabase-iris.database.windows.net;Initial Catalog=iris;Persist Security Info=True;User ID=iris;Password=LanceNeoJeremy1";

        public Main()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            applicationPanel.Controls.Clear();
            applicationPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //guna2CirclePictureBox1
        private void Main_Load(object sender, EventArgs e)
        {

            label1.Text = emailname;
            byte[] getimage = new byte[0];
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "select * from users WHERE email = '" + label1.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);

            SqlConnection con2 = new SqlConnection(constring);
            con2.Open();
            string fnameQuery = "select firstname from users WHERE email = '" + label1.Text + "'";
            SqlCommand cmd2 = new SqlCommand(fnameQuery, con2);
            string fname = cmd2.ExecuteScalar() as string;
            btnGreet.Text = "Hello, " + fname;
            con2.Close();


            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                label1.Text = dataReader[0].ToString();
                byte[] images = (byte[])dataReader["image"];
                if (images == null)
                {
                    pbProfilePic.Image = null;
                }
                else
                {
                    MemoryStream me = new MemoryStream(images);
                    pbProfilePic.Image = Image.FromStream(me);
                }
            }
            con.Close();
        }

        private bool check;
        

        private void pbBurger_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void is_Clicked(object sender, EventArgs e)
        {
            string emailname = label1.Text;
            Account account = new Account(emailname);
            Chats chats = new Chats(emailname);
            addUserControl(account);
        }

        private void gbtnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            addUserControl(home);
        }

        private void gbtnChats_Click(object sender, EventArgs e)
        {
            Chats chats = new Chats(emailname);
            addUserControl(chats);
        }

        private void gbtnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            addUserControl(settings);
        }

        private void gbtnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            addUserControl(about);
        }

        private void gbtnLogOut_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            bool loggedout = true;
            if (loggedout = true)
            {
                this.Dispose();
                loggedout = false;
            }
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            string emailname = label1.Text;
            Account account = new Account(emailname);
            addUserControl(account);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
