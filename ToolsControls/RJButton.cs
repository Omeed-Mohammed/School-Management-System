using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.ToolsControls
{
    /// <summary>
    /// A custom WinForms Button with rounded corners and
    /// different color states (Normal, Hover, Pressed, Disabled).
    /// </summary>
    class RJButton : Button
    {
        private int borderSize = 1;
        private int borderRadius = 30;
        private Color borderColor = Color.PaleVioletRed;

        private Color normalBackColor = Color.MediumSlateBlue;
        private Color pressedBackColor = Color.DarkSlateBlue;
        private Color disabledBackColor = Color.Gray;

        //private bool isHovered = false;
        //private bool isPressed = false;


        // Properties
        /// <summary>
        /// Gets or sets the border thickness of the button.
        /// </summary>

        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the corner radius of the button.
        /// The higher the value, the more rounded the button becomes.
        /// </summary>
        
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the button border.
        /// </summary>
        
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        
        public Color NormalBackColor
        {
            get => normalBackColor;
            set { normalBackColor = value; Invalidate(); }
        }

       

        [Category("RJ Code Advance - Colors")]
        public Color PressedBackColor
        {
            get => pressedBackColor;
            set { pressedBackColor = value; Invalidate(); }
        }

        [Category("RJ Code Advance - Colors")]
        public Color DisabledBackColor
        {
            get => disabledBackColor;
            set { disabledBackColor = value; Invalidate(); }
        }


        public RJButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
            DoubleBuffered = true;
            ResizeRedraw = true;
        }


        /// <summary>
        /// Creates a rounded rectangle path for the button.
        /// </summary>
        /// <param name="rect">The rectangle area of the button.</param>
        /// <param name="radius">The radius of the corners.</param>
        /// <returns>A <see cref="GraphicsPath"/> representing the rounded shape.</returns>
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }


        /// <summary>
        /// Draws the button with smooth rounded corners.
        /// </summary>
        /// <param name="e">Paint event data used to draw the button.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;

            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetFigurePath(rectSurface, borderRadius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(path);
                    if (borderSize > 0)
                        e.Graphics.DrawPath(penBorder, path);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize > 0)
                {
                    using (Pen pen = new Pen(borderColor, borderSize))
                        e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
                }
            }
        }



 

       
    }

}
