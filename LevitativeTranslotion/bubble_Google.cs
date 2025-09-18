using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LevitativeTranslotion
{
    public partial class bubble_Google : Form
    {
        public bubble_Google()
        {
            InitializeComponent();
        }

        public bubble_Google(string str, int fontSize)
        {
            InitializeComponent();
            label1.Text = str;
            label1.Font = new Font(label1.Font.FontFamily, fontSize);
            label1.MaximumSize = new Size(500, 0);
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void bubble_Google_Load(object sender, EventArgs e)
        {
            this.Size = label1.Size + this.Padding.Size;
            this.Location = ShowLocation();
            this.TopMost = true;
            this.Activate();

            //Form Shadow Func
            int value = 2;
            winAPI.DwmSetWindowAttribute(this.Handle, 2, ref value, 8);
            MARGINS marg = new MARGINS()
            {
                bottomHeight = 1,
                topHeight = 0,
                leftWidth = 0,
                rightWidth = 0
            };
            winAPI.DwmExtendFrameIntoClientArea(this.Handle, ref marg);

            ////Form Shadow Func
            //winAPI.SetClassLongPtr32(this.Handle, -26, (IntPtr)((int)winAPI.GetClassLongPtr32(this.Handle, -26) | 0x00020000));

            ////RoundForm Func
            //int rad = 50;
            //IntPtr rgnHwnd = winAPI.CreateRoundRectRgn(-1, -1, this.Width + 2, this.Height + 2, rad, rad);
            //winAPI.SetWindowRgn(this.Handle, rgnHwnd, true);
            //winAPI.DeleteObject(rgnHwnd);
        }

        private Point ShowLocation()
        {
            Point location = new Point();
            winAPI.GetCursorPos(ref location);
            Rectangle screen = SystemInformation.VirtualScreen;
            if (location.X + this.Width > screen.Width)
            {
                location.X = screen.Width - this.Width;
            }
            if (location.Y - this.Height > 0)
            {
                location.Y -= this.Height;
            }
            return location;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= Math.Pow(1 - this.Opacity, 0.5);
            if (this.Opacity < 0.05)
                this.Close();
        }

        private void Close(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void bubble_Google_Paint(object sender, PaintEventArgs e)
        {
            //// Form Round
            //e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //GraphicsPath gPath = new GraphicsPath();
            //int dia = 28;
            //gPath.AddArc(0, 0, dia, dia, 182, 86);
            //gPath.AddArc(this.Width - dia, 0, dia, dia, 272, 86);
            //gPath.AddArc(this.Width - dia, this.Height - dia, dia, dia, 2, 86);
            //gPath.AddArc(0, this.Height - dia, dia, dia, 92, 86);
            //gPath.CloseAllFigures();
            //this.Region = new Region(gPath);

            //Pen pen = new Pen(Color.White, 3);
            //pen.LineJoin = LineJoin.Round;
            //e.Graphics.DrawPath(pen, gPath);
            //pen.Dispose();
        }
    }
}
