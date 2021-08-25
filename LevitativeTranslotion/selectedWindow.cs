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
    public partial class selectedWindow : Form
    {
        public selectedWindow()
        {
            InitializeComponent();
            button2.DialogResult = DialogResult.OK;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.empty;
            button1.Cursor = new Cursor(GetType(), "aim.cur");
            timer1.Enabled = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.aim;
            button1.Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point point = new Point();
            winAPI.GetCursorPos(ref point);
            IntPtr HWND = winAPI.WindowFromPoint(point);
            textBox1.Tag = HWND;
            if (winAPI.GetAncestor(HWND, 2) != IntPtr.Zero)
            {
                StringBuilder iptrString = new StringBuilder(512);
                winAPI.GetWindowTextA(winAPI.GetAncestor(HWND, 2),
                                      iptrString,
                                      iptrString.Capacity);
                textBox1.Text = iptrString.ToString();
            }
            else
            {
                StringBuilder iptrString = new StringBuilder(512);
                winAPI.GetWindowTextA(HWND,
                                      iptrString,
                                      iptrString.Capacity);
                textBox1.Text = iptrString.ToString();
            }
        }

        public SetConfig returnHWND()
        {
            IntPtr HWND = IntPtr.Zero;
            if (textBox1.Tag != null)
                HWND = (IntPtr)textBox1.Tag;
            SetConfig config = new SetConfig(HWND);
            return config;
        }
    }
}
