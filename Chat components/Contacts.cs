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
    public partial class Contacts : UserControl
    {
        public Contacts()
        {
            InitializeComponent();
        }



        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; lblName.Text = value; }
        }

        private Image _icon;

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pbImageIcon.Image = value; }
        }
    }
}
