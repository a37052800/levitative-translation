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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void hotKeySlector_KeyUp(object sender, KeyEventArgs e)
        {
            Button button = (Button)sender;
            button.Text = e.KeyCode.ToString();
        }

        private void comboBoxChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            switch (comboBox.Text)
            {
                case "無":
                    comboBox.Tag = null;
                    break;
                case "Google":
                    googleSet GSForm = new googleSet();
                    if (GSForm.ShowDialog() == DialogResult.OK)
                    {
                        comboBox.Tag = GSForm.returnSitting();
                    }
                    else
                    {
                        comboBox.Text = "無";
                    }
                    break;
                case "NAER":
                    NAERSet NSForm = new NAERSet();
                    if (NSForm.ShowDialog() == DialogResult.OK)
                    {
                        comboBox.Tag = NSForm.returnSetting();
                    }
                    else
                    {
                        comboBox.Text = "無";
                    }
                    break;
                case "輸出至文件":
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {

                    }
                    else
                    {
                        comboBox.Text = "無";
                    }
                    break;
                case "貼上到視窗":
                    selectedWindow SelForm = new selectedWindow();
                    if (SelForm.ShowDialog() == DialogResult.OK)
                    {

                    }
                    else
                    {
                        comboBox.Text = "無";
                    }
                    break;
            }

        }
    }
}
