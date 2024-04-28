using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Model
{
    public static class ControlExtensions
    {
        public static void RoundedCorners(this Control control, int borderRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(control.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, control.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}
