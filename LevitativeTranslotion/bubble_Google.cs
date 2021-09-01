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
    }
}
