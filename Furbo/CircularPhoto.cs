using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Furbo
{
    internal class CircularPhoto : PictureBox
    {
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle bordeLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;
        public CircularPhoto()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }
        public Color BorderColor2
        {
            get { return borderColor2; }
            set { borderColor2 = value; this.Invalidate(); }
        }
        public DashStyle BordeLineStyle
        {
            get { return bordeLineStyle; }
            set { bordeLineStyle = value; this.Invalidate(); }
        }
        public DashCap BorderCapStyle
        {
            get { return borderCapStyle; }
            set { borderCapStyle = value; this.Invalidate(); }
        }
        public float GradientAngle
        {
            get { return gradientAngle; }
            set { gradientAngle = value; this.Invalidate(); }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Width);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -BorderSize, -borderSize);
            var smothieSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor, smothieSize))
            using (var PenBorder = new Pen(borderGColor, borderSize))
            {
                PenBorder.DashStyle = BordeLineStyle;
                PenBorder.DashCap = BorderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);
                this.Region = new Region(pathRegion);
                graph.SmoothingMode = SmoothingMode.AntiAlias;

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                {
                    graph.DrawEllipse(PenBorder, rectBorder);
                }
            }

        }
    }
}
