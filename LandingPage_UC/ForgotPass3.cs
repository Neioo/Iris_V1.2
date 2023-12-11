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
    public partial class ForgotPass3 : UserControl
    {
        string constring = "Data Source=sqldatabase-iris.database.windows.net;Initial Catalog=iris;Persist Security Info=True;User ID=iris;Password=LanceNeoJeremy1";

        public string userEmail { get; set; }

        public ForgotPass3()
        {
            InitializeComponent();
        }

        private void ForgotPass3_Load(object sender, EventArgs e)
        {

        }

        private void btnFpContinue1_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text == tbFpConfPass.Text)
            {
                SqlConnection conn = new SqlConnection(constring);
                conn.Open();

                string q = "UPDATE users SET password = @password WHERE email = @email";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@password", tbNewPassword.Text);
                cmd.Parameters.AddWithValue("@email", userEmail);

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Successfully Updated!");


                Login loginUC = new Login();
                Form1 form = this.FindForm() as Form1;

                if (form != null)
                {
                    form.addUserControl(loginUC);
                }
            }
            else
            {
                MessageBox.Show("Password and Confirm Password does not match");
            }


        }
    
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login loginUC = new Login();
            Form1 form = this.FindForm() as Form1;

            if (form != null)
            {
                form.addUserControl(loginUC);
            }
        }
    }
}
