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
        }
    }
}
