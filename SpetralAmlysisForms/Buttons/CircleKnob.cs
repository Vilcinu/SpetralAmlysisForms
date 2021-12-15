﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SpetralAmlysisForms.Buttons
{
    public class CircleKnob : Button
    {
        //Apperance
        private int borderSize = 2;
        private int borderRadius =40;
        private Color borderColor = Color.White;

        public CircleKnob()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.FromArgb(80,80,80);
            this.ForeColor = Color.White;
        }

        //Methods
        private GraphicsPath GetGraphicsPath(RectangleF rect,float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180,90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270,90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height-radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width-0.8F, this.Height-1);

            if (borderRadius > 2)//Rounded
            {
                using (GraphicsPath pathSurface = GetGraphicsPath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetGraphicsPath(rectSurface, borderRadius-1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    //Draw Border
                    pevent.Graphics.DrawPath(penSurface,pathSurface);
                    //
                    if(borderSize>=1)
                    pevent.Graphics.DrawPath(penBorder, pathBorder); 
                }
            }
            else//Squered
            {
                this.Region = new Region(rectSurface);
                if(borderSize>=1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if(this.DesignMode)
            {
                this.Invalidate();
            }
        }
    }
}
