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
    public partial class Chat : UserControl
    {
        public Chat()
        {
            InitializeComponent();
        }


        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; lblChat.Text = value; }
        }

        void AddHeighttext()
        {
            Chat user = new Chat();
            user.BringToFront();
            lblChat.Height = UiList.GetTextHeight(lblChat) + 10;
            user.Height = lblChat.Top + lblChat.Height;
            this.Height = user.Bottom + 10;
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            AddHeighttext();
        }
    }
}
