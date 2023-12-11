using Iris_V1._1.Dashboard;
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

namespace Iris_V1._1.LandingPage_UC
{
    public partial class Login : UserControl
    {
        private Panel loginCPanel;

        string constring = "Data Source=sqldatabase-iris.database.windows.net;Initial Catalog=iris;Persist Security Info=True;User ID=iris;Password=LanceNeoJeremy1";

        private void userLogIn()
        {
            if (string.IsNullOrEmpty(tbEmail.Text.Trim()))
            {
                errorProvider1.SetError(tbEmail, "Email is required");
                return;
            }
            else
            {
                errorProvider1.SetError(tbEmail, string.Empty);
            }

            if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                errorProvider1.SetError(tbPassword, "Password is required");
                return;
            }
            else
            {
                errorProvider1.SetError(tbPassword, string.Empty);
            }

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "SELECT * FROM users WHERE email = '" + tbEmail.Text + "' AND password = '" + tbPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows == true)
            {
                Main main = new Main();
                main.emailname = tbEmail.Text;
                main.Show();
                if (this.FindForm() is Form1 form)
                {
                    form.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please check your email and password.");
            }
            con.Close();
        }

        public Login()
        {
            InitializeComponent();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            loginCPanel.Controls.Clear();
            loginCPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Register registerControl = new Register();
            Form1 form = this.FindForm() as Form1;

            if (form != null)
            {
                form.addUserControl(registerControl);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userLogIn();

        }

        private void login_enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                userLogIn();
                e.Handled = true; //this will disable a sound when pressing enter
            }
        }
    }
}




