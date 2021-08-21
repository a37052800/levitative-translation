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
            button1.DialogResult = DialogResult.OK;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.empty;
            button1.Cursor = new Cursor(GetType(), "aim.cur");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.aim;
            button1.Cursor = Cursors.Default;
        }
    }
}
