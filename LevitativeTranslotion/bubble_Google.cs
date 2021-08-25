using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.Size = label1.Size;
            Point point = new Point();
            winAPI.GetCursorPos(ref point);
            point.Y -= this.Height;
            this.Location = point;
            timer1.Enabled = true;
            //ShouldClose();
        }

        private void ShouldClose()
        {
            Point point = new Point();
            winAPI.GetCursorPos(ref point);
            Point temp = point;
            while (winAPI.GetCursorPos(ref point))
            {
                if (point != temp)
                {
                    timer1.Enabled = true;
                    break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
