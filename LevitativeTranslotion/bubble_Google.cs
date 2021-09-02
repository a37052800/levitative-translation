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

        public bubble_Google(string str)
        {
            InitializeComponent();
            label1.Text = str;
        }

        private void bubble_Google_Load(object sender, EventArgs e)
        {
            this.Size = label1.Size + this.Padding.Size;
            this.Location = ShowLocation();
            /*int rad = 28;
            IntPtr rgnHwnd = winAPI.CreateRoundRectRgn(-1, -1, this.Width + 2, this.Height + 2, rad, rad);
            winAPI.SetWindowRgn(this.Handle, rgnHwnd, true);
            winAPI.DeleteObject(rgnHwnd);*/
        }

        private Point ShowLocation()
        {
            Point location = new Point();
            winAPI.GetCursorPos(ref location);
            Rectangle screen = SystemInformation.WorkingArea;
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
            this.Opacity -= Math.Pow(1.1 - this.Opacity, 0.5);
            if (this.Opacity < 0.05)
                this.Close();
        }

        private void Close(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void bubble_Google_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath gPath = new GraphicsPath();
            int dia = 49;
            gPath.AddArc(-2, -2, dia, dia, 180, 90);
            gPath.AddArc(this.Width - dia +1, -2, dia, dia, 270, 90);
            gPath.AddArc(this.Width - dia +1, this.Height +1 - dia, dia, dia, 0, 90);
            gPath.AddArc(-2, this.Height +1 - dia, dia, dia, 90, 90);
            gPath.CloseAllFigures();
            this.Region = new Region(gPath);*/
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath gPath = new GraphicsPath();
            int dia = 16;
            gPath.AddArc(0, 0, dia, dia, 182, 86);
            gPath.AddArc(this.Width - dia, 0, dia, dia, 272, 86);
            gPath.AddArc(this.Width - dia, this.Height - dia, dia, dia, 2, 86);
            gPath.AddArc(0, this.Height - dia, dia, dia, 92, 86);
            gPath.CloseAllFigures();
            this.Region = new Region(gPath);
        }
    }
}
