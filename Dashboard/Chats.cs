using Iris_V1._1.Chat_components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iris_V1._1.Dashboard
{
    public partial class Chats : UserControl
    {
        private string _emailname;
        public Chats(string email)
        {
            InitializeComponent();
            _emailname = email;
        }

        string constring = "Data Source=sqldatabase-iris.database.windows.net;Initial Catalog=iris;Persist Security Info=True;User ID=iris;Password=LanceNeoJeremy1";

        private void UserItem()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from users", constring);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table != null && table.Rows.Count > 0)
            {
                Contacts[] userControls = new Contacts[table.Rows.Count];
                int index = 0;

                foreach (DataRow row in table.Rows)
                {
                    string userEmail = row["email"].ToString();

                    // Skip the current user
                    if (userEmail == lblEmail.Text)
                        continue;

                    userControls[index] = new Contacts();
                    MemoryStream stream = new MemoryStream((byte[])row["image"]);
                    userControls[index].Icon = new Bitmap(stream);
                    userControls[index].Title = row["firstname"].ToString();
                    flowLayoutPanel1.Controls.Add(userControls[index]);
                    index++;
                }
            }
        }

        private void Chats_Load(object sender, EventArgs e)
        {
            lblEmail.Text = _emailname;
            UserItem();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            SqlConnection con2 = new SqlConnection(constring);
            con2.Open();
            string fnameQuery = "select firstname from users WHERE email = '" + _emailname + "'";
            SqlCommand cmd2 = new SqlCommand(fnameQuery, con2);
            string fname = cmd2.ExecuteScalar() as string;
            con2.Close();

            SqlConnection con = new SqlConnection(constring);
            con.Open();

            string q = "insert into Chat(userone, usertwo, message)values(userone=@userone, usertwo=@usertwo, message=@message)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@userone", fname);
            cmd.Parameters.AddWithValue("@usertwo", lblUserTwo.Text);
            cmd.Parameters.AddWithValue("@message", tbChatbox.Text);

            con.Close();

            MessageChat();
            tbChatbox.Clear();
        }

        private void MessageChat()
        {

            SqlConnection con2 = new SqlConnection(constring);
            con2.Open();
            string fnameQuery = "select firstname from users WHERE email = '" + _emailname + "'";
            SqlCommand cmd2 = new SqlCommand(fnameQuery, con2);
            string fname = cmd2.ExecuteScalar() as string;
            con2.Close();


            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from Chat", constring);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table != null)
            {
                Chat[] chats = new Chat[table.Rows.Count];
                Reply[] replies = new Reply[table.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        if (lblUserTwo.Text == row["usertwo"].ToString() && fname == row["userone"].ToString())
                        {
                            chats[i] = new Chat();
                            chats[i].Dock = DockStyle.Top;
                            chats[i].BringToFront();
                            chats[i].Title = row["message"].ToString();

                            flowLayoutPanel2.Controls.Add(chats[i]);
                            flowLayoutPanel2.ScrollControlIntoView(chats[i]);
                        }
                        else if (lblUserTwo.Text == row["userone"].ToString() && fname == row["usertwo"].ToString())
                        {
                            replies[i] = new Reply();
                            replies[i].Dock = DockStyle.Top;
                            replies[i].BringToFront();
                            replies[i].Title = row["message"].ToString();
                            replies[i].Icon = pbUserTwo.Image;

                            flowLayoutPanel2.Controls.Add(replies[i]);
                            flowLayoutPanel2.ScrollControlIntoView(replies[i]);

                        }
                    }
                }
            }
        }

        private void contacts1_Load(object sender, EventArgs e)
        {
            if (panel1.Visible == false && panel2.Visible == false && flowLayoutPanel2.Visible == false)
            {
                panel1.Visible = true;
                panel2.Visible = true;
                flowLayoutPanel2.Visible = true;
            }
            Contacts control = (Contacts)sender;
            lblUserTwo.Text = control.Title;
            pbUserTwo.Image = control.Icon;
            MessageChat();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true && panel2.Visible == true && flowLayoutPanel2.Visible == true)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                flowLayoutPanel2.Visible = false;
            }
        }
    }
}
