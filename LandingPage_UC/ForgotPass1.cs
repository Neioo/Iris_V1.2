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
    public partial class ForgotPass1 : UserControl
    {

        string constring = "Data Source=sqldatabase-iris.database.windows.net;Initial Catalog=iris;Persist Security Info=True;User ID=iris;Password=LanceNeoJeremy1";
        public ForgotPass1()
        {
            InitializeComponent();
        }

        private void ForgotPass1_Load(object sender, EventArgs e)
        {

        }

        private void btnFpContinue1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "SELECT * FROM users WHERE email = '" + tbFpEmail.Text + "'";

            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows == true)
            {
                ForgotPass3 forgotControl = new ForgotPass3();
                forgotControl.userEmail = tbFpEmail.Text;
                Form1 form = this.FindForm() as Form1;

                if (form != null)
                {
                    form.addUserControl(forgotControl);
                }
            }
            else
            {
                MessageBox.Show("No account registered under this email");
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
