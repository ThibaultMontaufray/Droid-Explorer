using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Explorer
{
    public class RichProgressBar : ProgressBar
    {
        public RichProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // None... Helps control the flicker.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            const int inset = 0; // A single inset value to control teh sizing of the inner rect.

            using (Image offscreenImage = new Bitmap(this.Width, this.Height))
            {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage))
                {
                    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                    if (ProgressBarRenderer.IsSupported)
                        ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);

                    rect.Inflate(new Size(-inset, -inset)); // Deflate inner rect.
                    rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));
                    if (rect.Width == 0) rect.Width = 1; // Can't draw rec with width of 0.

                    this.BackColor = Color.White;

                    int r, g, b;
                    r = this.ForeColor.R;
                    g = this.ForeColor.G;
                    b = this.ForeColor.B;
                    Color firstColor = Color.FromArgb(170, r, g, b);

                    r = this.ForeColor.R - 60 > 0 ? this.ForeColor.R - 120 : 0;
                    g = this.ForeColor.G - 60 > 0 ? this.ForeColor.G - 120 : 0;
                    b = this.ForeColor.B - 60 > 0 ? this.ForeColor.B - 120 : 0;
                    Color secondColor = Color.FromArgb(170, r, g, b);

                    LinearGradientBrush brush = new LinearGradientBrush(rect, firstColor, secondColor, LinearGradientMode.Vertical);
                    offscreen.FillRectangle(brush, inset, inset, rect.Width, rect.Height);

                    e.Graphics.DrawImage(offscreenImage, 0, 0);
                    offscreenImage.Dispose();
                }
            }
        }
    }
}