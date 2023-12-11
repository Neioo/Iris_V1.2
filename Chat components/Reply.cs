using Iris_V1._1.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iris_V1._1.Chat_components
{
    public partial class Reply : UserControl
    {
        public Reply()
        {
            InitializeComponent();
        }


        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; lblReply.Text = value; }
        }

        private Image _icon;

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; guna2CirclePictureBox1.Image = value; AddHeighttext(); }
        }

        void AddHeighttext()
        {
            Reply user = new Reply();
            user.BringToFront();
            lblReply.Height = UiList.GetTextHeight(lblReply) + 10;
            user.Height = lblReply.Top + lblReply.Height;
            this.Height = user.Bottom + 10;

        }

        private void Reply_Load(object sender, EventArgs e)
        {
            AddHeighttext();
        }
    }
}
