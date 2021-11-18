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
    public partial class toolMenu : Form
    {
        private IntPtr hwnd;
        private string filename;

        public toolMenu()
        {
            InitializeComponent();
            Paste.Tag = false;
            Export.Tag = false;
            FontSize.Tag = 10;
        }

        private void toolMenu_Load(object sender, EventArgs e)
        {
            this.Activate();
            this.Size = new Size(122, 104);
            Point location = Control.MousePosition;
            if (location.Y + this.Height > SystemInformation.WorkingArea.Height)
                location.Y -= this.Height;
            if (location.X + this.Width > SystemInformation.WorkingArea.Width)
                location.X -= this.Width;
            this.Location = location;
        }

        private void toolMenu_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ExitP_Click(object sender, EventArgs e)
        {
            mainForm mForm = (mainForm)this.Owner;
            mForm.CloseForm();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            //interaction
            Button checkbutton = (Button)sender;
            checkbutton.Tag = !(bool)checkbutton.Tag;

            //function
            if ((bool)checkbutton.Tag)
            {
                selectedWindow selectWin = new selectedWindow();
                if (selectWin.ShowDialog() == DialogResult.OK)
                    hwnd = selectWin.returnHWND();
                else
                    Paste.Tag = false;
            }
            checkbutton_MouseEnter(sender, e);
        }

        private void Export_Click(object sender, EventArgs e)
        {
            //interaction
            Button checkbutton = (Button)sender;
            checkbutton.Tag = !(bool)checkbutton.Tag;

            //function
            if ((bool)checkbutton.Tag)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    filename = saveFileDialog1.FileName;
                else
                    Export.Tag = false;
            }
            checkbutton_MouseEnter(sender, e);
        }

        public MoreConfig GetConfig()
        {
            MoreConfig config = new MoreConfig((bool)Paste.Tag, (bool)Export.Tag, hwnd, filename, (int)FontSize.Tag);
            return config;
        }
        //Item interaction
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
            ExitP.BackgroundImage = Properties.Resources.menubutton_enter;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            ExitP.BackgroundImage = null;
        }

        private void Up_Click(object sender, EventArgs e)
        {
            int size = (int)FontSize.Tag;
            if (size < 99)
                size++;
            FontSize.Tag = size;
            FontSize.Text = size.ToString();
        }

        private void Down_Click(object sender, EventArgs e)
        {
            int size = (int)FontSize.Tag;
            if (size > 6)
                size--;
            FontSize.Tag = size;
            FontSize.Text = size.ToString();
        }
    }
}
