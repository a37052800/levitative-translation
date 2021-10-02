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
        public string translation;
        
        public bubble_NAER()
        {
            InitializeComponent();
        }
        public bubble_NAER(ArrayList[] result, int fontSize)
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Source", "學術領域/出處");
            dataGridView1.Columns.Add("EnName", "英文詞彙");
            dataGridView1.Columns.Add("ZhName", "中文詞彙");
            for (int i = 0; i < result[0].Count; i++)
            {
                dataGridView1.Rows.Add(result[0][i], result[1][i], result[2][i]);
            }
            dataGridView1.Font = new Font(dataGridView1.Font.FontFamily, fontSize);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            translation = dataGridView1.CurrentCell.Value.ToString();
            this.Close();
        }

        private void bubble_NAER_Load(object sender, EventArgs e)
        {
            this.Width = dataGridView1.Columns[0].Width + dataGridView1.Columns[1].Width + dataGridView1.Columns[2].Width + 21;
            this.Location = ShowLocation();
            //Form Shadow Func
            int value = 2;
            winAPI.DwmSetWindowAttribute(this.Handle, 2, ref value, 8);
            MARGINS marg = new MARGINS()
            {
                bottomHeight = 1,
                topHeight = 0,
                leftWidth = 0,
                rightWidth = 0
            };
            winAPI.DwmExtendFrameIntoClientArea(this.Handle, ref marg);
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
    }
}
