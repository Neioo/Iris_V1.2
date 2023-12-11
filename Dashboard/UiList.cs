using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iris_V1._1.Dashboard
{
    internal class UiList
    {
        public static int GetTextHeight(Label lbl)
        {
            using(Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 495);
                return(int)Math.Ceiling(size.Height);
            }
        }


    }
}
