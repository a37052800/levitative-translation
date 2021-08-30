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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void bubble_NAER_Load(object sender, EventArgs e)
        {
            Point point = new Point();
            winAPI.GetCursorPos(ref point);
            point.Y -= this.Height;
            this.Location = point;
            this.Width = dataGridView1.Columns[0].Width + dataGridView1.Columns[1].Width + dataGridView1.Columns[2].Width + 21;
        }
    }
}
