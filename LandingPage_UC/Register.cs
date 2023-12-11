using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Iris_V1._1.LandingPage_UC
{
    public partial class Register : UserControl
    {

        Main main = new Main();

        private Panel loginCPanel;

        string constring = "Data Source=DESKTOP-C7QE51M\\SQLEXPRESS;Initial Catalog=iris;Integrated Security=True";
        public Register()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            loginCPanel.Controls.Clear();
            loginCPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private string GenerateUniqueUid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();

                string query = "SELECT TOP 1 uid FROM users ORDER BY uid DESC"; //select last UID
                SqlCommand cmd = new SqlCommand(query, con);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    int lastUid = Convert.ToInt32(result);
                    int newUid = lastUid + 1;
                    return newUid.ToString();
                }
                else
                {
                    return "0"; //If the db is fresh and no records found
                }
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (pbProfile.Image == null)
            {
                MessageBox.Show("Select photo");
            }
            else
            {

                #region ---Error Handling for Textboxes ---

                if (string.IsNullOrEmpty(tbFirstName.Text.Trim()))
                {
                    errorProvider1.SetError(tbFirstName, "Firstname is required");
                    return;
                }
                else
                {
                    errorProvider1.SetError(tbFirstName, string.Empty);
                }

                if (string.IsNullOrEmpty(tbLastName.Text.Trim()))
                {
                    errorProvider1.SetError(tbLastName, "Lastname is required");
                    return;
                }
                else
                {
                    errorProvider1.SetError(tbLastName, string.Empty);
                }

                if (string.IsNullOrEmpty(tbEmailRegister.Text.Trim()))
                {
                    errorProvider1.SetError(tbEmailRegister, "Email is required");
                    return;
                }
                else
                {
                    errorProvider1.SetError(tbEmailRegister, string.Empty);
                }

                if (string.IsNullOrEmpty(tbPasswordRegister.Text.Trim()))
                {
                    errorProvider1.SetError(tbPasswordRegister, "Password is required");
                    return;
                }
                else
                {
                    errorProvider1.SetError(tbPasswordRegister, string.Empty);
                }

                if (string.IsNullOrEmpty(tbConfPass.Text.Trim()))
                {
                    errorProvider1.SetError(tbConfPass, "Confirm password before proceeding");
                    return;
                }
                else
                {
                    errorProvider1.SetError(tbConfPass, string.Empty);
                }

                if (tbConfPass.Text != tbPasswordRegister.Text)
                {
                    MessageBox.Show("Passwords are not the same.");
                }
                else
                {

                }

                #endregion


                string newUid = GenerateUniqueUid();

                SqlConnection con = new SqlConnection(constring);
                string q = "insert into users(firstname, lastname, email, password, uid, birthdate, image)values(@firstname,@lastname,@email,@password, @uid, @birthdate,@image)";
                SqlCommand cmd = new SqlCommand(q, con);
                MemoryStream me = new MemoryStream();
                pbProfile.Image.Save(me, pbProfile.Image.RawFormat);

                //Get the values in the textbox
                cmd.Parameters.AddWithValue("firstname", tbFirstName.Text);
                cmd.Parameters.AddWithValue("lastname", tbLastName.Text);
                cmd.Parameters.AddWithValue("email", tbEmailRegister.Text);
                cmd.Parameters.AddWithValue("birthdate", dtpBirthdate.Value);

                if (tbPasswordRegister.Text == tbConfPass.Text)
                {
                    cmd.Parameters.AddWithValue("password", tbPasswordRegister.Text);
                }
                cmd.Parameters.AddWithValue("uid", newUid);
                cmd.Parameters.AddWithValue("image", me.ToArray());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registration successful");

                tbFirstName.Clear();
                tbLastName.Clear();
                tbEmailRegister.Clear();
                tbPasswordRegister.Clear();
                tbConfPass.Clear();
                pbProfile.Image = null;


                Login loginControl = new Login();
                Form1 form = this.FindForm() as Form1;

                if (form != null)
                {
                    form.addUserControl(loginControl);
                }
            }


        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "select image(*Jpg; *.png; *Gif| *.Jpg; *.png; *Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbProfile.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
