using Iris_V1._1.LandingPage_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iris_V1._1.Dashboard
{
    public partial class Account : UserControl
    {
        private string _emailname;
        private string _password;

        string constring = "Data Source=sqldatabase-iris.database.windows.net;Initial Catalog=iris;Persist Security Info=True;User ID=iris;Password=LanceNeoJeremy1";

        public Account(string email)
        {
            InitializeComponent();
            _emailname = email;
        }

        public void SetPassword(string password)
        {
            _password = password;
            // You can use the received password value as needed here
        }

        private void Account_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "select * from users WHERE firstname = '" + _emailname + "'";
            SqlCommand cmd = new SqlCommand(q, con);

            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                gtbFirstName.Text = dataReader["firstname"].ToString();
                gtbLastName.Text = dataReader["lastname"].ToString();
                gtbEmail.Text = dataReader["email"].ToString();
                gtbPassword.Text = dataReader["password"].ToString();
                gtbBirthdate.Text = dataReader["birthdate"].ToString();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void showProfile()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "select * from users WHERE firstname = '" + gtbEmail.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);

            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                gtbFirstName.Text = dataReader["firstname"].ToString();
                gtbLastName.Text = dataReader["lastname"].ToString();
                gtbEmail.Text = dataReader["email"].ToString();
                gtbBirthdate.Text = dataReader["birthdate"].ToString();
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

        private void gbtnUpdateProfile_Click(object sender, EventArgs e)
        {
            gbtnUpdateProfile.Visible = false;
            btnSaveChanges.Visible = true;

            gtbFirstName.Enabled = true;
            gtbLastName.Enabled = true;
            gtbPassword.Enabled = true;
            pbProfilePic.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = false;
            gbtnUpdateProfile.Visible = true;

            gtbFirstName.Enabled = false;
            gtbLastName.Enabled = false;
            gtbPassword.Enabled = false;
            pbProfilePic.Enabled = false;

            if (string.IsNullOrEmpty(gtbFirstName.Text.Trim()))
            {
                errorProvider1.SetError(gtbFirstName, "First Name is required");
                return;
            }
            else
            {
                errorProvider1.SetError(gtbFirstName, string.Empty);
            }

            if (string.IsNullOrEmpty(gtbLastName.Text.Trim()))
            {
                errorProvider1.SetError(gtbLastName, "Last Name is required");
                return;
            }
            else
            {
                errorProvider1.SetError(gtbLastName, string.Empty);
            }



            SqlConnection conn = new SqlConnection(constring);
            conn.Open();

            string userEmail = gtbEmail.Text;
            string qUid = "SELECT uid FROM users WHERE email = @email";
            SqlCommand cmdUid = new SqlCommand(qUid, conn);
            cmdUid.Parameters.AddWithValue("@email", userEmail);
            object userUid = cmdUid.ExecuteScalar();
            string uidToUpdate = userUid.ToString();

            string q = "UPDATE users SET firstname = @firstname, lastname = @lastname, email = @email, password = @password, image=@image WHERE uid = @uid";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@firstname", gtbFirstName.Text);
            cmd.Parameters.AddWithValue("@lastname", gtbLastName.Text);
            cmd.Parameters.AddWithValue("@email", gtbEmail.Text);
            cmd.Parameters.AddWithValue("@password", gtbPassword.Text);

            MemoryStream me = new MemoryStream();
            pbProfilePic.Image.Save(me, pbProfilePic.Image.RawFormat);
            cmd.Parameters.AddWithValue("@image", me.ToArray());

            cmd.Parameters.AddWithValue("@uid", uidToUpdate);

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully Updated!");
            showProfile();
        }

        private void pbProfilePic_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "select image(*Jpg; *.png; *Gif| *.Jpg; *.png; *Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbProfilePic.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
