using Iris_V1._1.Chat_components;
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
            /*flowLayoutPanel1.Controls.Clear();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from users", constring);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table != null)
            {
                if (table.Rows.Count > 0)
                {
                    Contacts[] userControl = new Contacts[table.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            userControl[i] = new Contacts();
                            MemoryStream stream = new MemoryStream((byte[])row["image"]);
                            userControl[i].Icon = new Bitmap(stream);
                            userControl[i].Title = row["firstname"].ToString();
                            if (userControl[i].Title == lblEmail.Text)
                            {
                                flowLayoutPanel1.Controls.Remove(userControl[i]);
                            }
                            else
                            {
                                flowLayoutPanel1.Controls.Add(userControl[i]);
                            }

                        }
                    }
                }
            }*/

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

    }
}
