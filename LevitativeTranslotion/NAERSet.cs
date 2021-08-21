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
    public partial class NAERSet : Form
    {
        public NAERSet()
        {
            InitializeComponent();
            button3.DialogResult = DialogResult.OK;
        }

        public SetConfig returnSetting()
        {
            SetConfig config = new SetConfig(checkBox1.Checked,
                                             checkBox2.Checked,
                                             checkBox3.Checked,
                                             (int)numericUpDown1.Value);
            return config;
        }
    }
}
