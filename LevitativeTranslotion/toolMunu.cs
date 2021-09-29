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
    public partial class toolMunu : Form
    {
        public toolMunu()
        {
            InitializeComponent();
            Paste.Tag = false;
            Export.Tag = false;
        }

        private void toolMunu_Load(object sender, EventArgs e)
        {
            this.Size = new Size(144, 132);
            this.Location = Control.MousePosition;
        }

        private void toolMunu_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkbutton_MouseEnter(object sender, EventArgs e)
        {
            Button checkbutton = (Button)sender;
            if ((bool)checkbutton.Tag)
                checkbutton.BackgroundImage = Properties.Resources.checkbutton_on_enter;
            else
                checkbutton.BackgroundImage = Properties.Resources.checkbutton_off_enter;
        }

        private void checkbutton_MouseLeave(object sender, EventArgs e)
        {
            Button checkbutton = (Button)sender;
            if ((bool)checkbutton.Tag)
                checkbutton.BackgroundImage = Properties.Resources.checkbutton_on_normal;
            else
                checkbutton.BackgroundImage = Properties.Resources.checkbutton_off_normal;
        }

        private void Up_MouseEnter(object sender, EventArgs e)
        {
            Up.BackgroundImage = Properties.Resources.up_enter;
        }

        private void Up_MouseLeave(object sender, EventArgs e)
        {
            Up.BackgroundImage = Properties.Resources.up_normal;
        }

        private void Up_MouseDown(object sender, MouseEventArgs e)
        {
            Up.BackgroundImage = Properties.Resources.up_click;
        }

        private void Up_MouseUp(object sender, MouseEventArgs e)
        {
            Up.BackgroundImage = Properties.Resources.up_enter;
        }

        private void Down_MouseEnter(object sender, EventArgs e)
        {
            Down.BackgroundImage = Properties.Resources.down_enter;
        }

        private void Down_MouseLeave(object sender, EventArgs e)
        {
            Down.BackgroundImage = Properties.Resources.down_normal;
        }

        private void Down_MouseDown(object sender, MouseEventArgs e)
        {
            Down.BackgroundImage = Properties.Resources.down_click;
        }

        private void Down_MouseUp(object sender, MouseEventArgs e)
        {
            Down.BackgroundImage = Properties.Resources.down_enter;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.BackgroundImage = Properties.Resources.menubutton_enter;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackgroundImage = null;
        }
    }
}
