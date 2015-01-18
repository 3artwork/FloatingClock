using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clock
{
    class myTextBox : TextBox
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (Enabled)
            {
                //use normal realization
                base.OnPaint(e);
                return;
            }
            //custom drawing
            using (Brush aBrush = new SolidBrush(Color.LimeGreen))
            {
                e.Graphics.DrawString(Text, Font, aBrush, ClientRectangle);
            }
        }
    }
}
