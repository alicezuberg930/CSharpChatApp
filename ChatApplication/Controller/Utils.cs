using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.Controller
{
    public static class Utils
    {
        public static int GetTextHeight(Label l)
        {
            using (Graphics g = l.CreateGraphics())
            {
                SizeF size = g.MeasureString(l.Text, l.Font, 500);
                return (int)Math.Ceiling(size.Height);
            }
        }
        public static int GetTextWidth(Label l)
        {
            using (Graphics g = l.CreateGraphics())
            {
                SizeF size = g.MeasureString(l.Text, l.Font, 500);
                return (int)Math.Ceiling(size.Width);
            }
        }
    }
}
