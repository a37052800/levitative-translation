using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LevitativeTranslotion
{
    public partial class bubble_NAER : Form
    {
        public bubble_NAER()
        {
            InitializeComponent();
        }
        public bubble_NAER(ArrayList[] result)
        {
            InitializeComponent();
            for (int i = 0; i < result[0].Count; i++)
            {
                dataGridView1.Rows.Add(result[0][i], result[1][i], result[2][i]);
            }
            this.Size = dataGridView1.Size;
        }
    }
}
