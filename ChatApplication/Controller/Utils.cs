using System;
using System.Drawing;
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
