using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class RoundButton : Button
    {
        private Color borderColor = Color.Black; // Default border color
        private Image buttonImage;

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate(); // Redraw the button when the border color changes
            }
        }
        public Image ButtonImage
        {
            get { return buttonImage; }
            set
            {
                buttonImage = value;
                Invalidate(); // Redraw the button when the image changes
            }
        }
        public RoundButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphicsPath);
            base.OnPaint(e);
        }

    }
}
