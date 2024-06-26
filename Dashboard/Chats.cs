﻿using Iris_V1._1.Chat_components;
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
                    userControls[index].Click += new System.EventHandler(this.contacts1_Load); // Move this line outside of the loop
                    index++;
                }
            }
        }


        private void Chats_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (10 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            lblEmail.Text = _emailname;
            UserItem();
            MessageChat();
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

            using (SqlConnection con = new SqlConnection(constring))
            {

                string q = "INSERT INTO Chat (userone, usertwo, message) VALUES (@userone, @usertwo, @message)";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@userone", fname);
                cmd.Parameters.AddWithValue("@usertwo", lblUserTwo.Text);
                cmd.Parameters.AddWithValue("@message", tbChatbox.Text);
                con.Open();
                cmd.ExecuteNonQuery(); // Execute the query here
                con.Close();
            }

            MessageChat();
            tbChatbox.Clear();
        }


        /*private void MessageChat()
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
                if (table.Rows.Count > 0)
                {

                }
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
        }*/

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

            flowLayoutPanel2.Controls.Clear();  // Clear existing controls before adding new ones

            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    if ((lblUserTwo.Text == row["usertwo"].ToString() && fname == row["userone"].ToString()) ||
                        (lblUserTwo.Text == row["userone"].ToString() && fname == row["usertwo"].ToString()))
                    {
                        if (lblUserTwo.Text == row["usertwo"].ToString())
                        {
                            Chat chat = new Chat();
                            chat.Dock = DockStyle.Top;
                            chat.BringToFront();
                            chat.Title = row["message"].ToString();

                            flowLayoutPanel2.Controls.Add(chat);
                            flowLayoutPanel2.ScrollControlIntoView(chat);
                        }
                        else
                        {
                            Reply reply = new Reply();
                            reply.Dock = DockStyle.Top;
                            reply.BringToFront();
                            reply.Title = row["message"].ToString();
                            reply.Icon = pbUserTwo.Image;

                            flowLayoutPanel2.Controls.Add(reply);
                            flowLayoutPanel2.ScrollControlIntoView(reply);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageChat();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
