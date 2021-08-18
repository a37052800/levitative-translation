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

        private void comboBoxTextChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            switch (comboBox.Text)
            {
                case "無":
                    comboBox.Tag = null;
                    break;
                case "Google":
                    googleSet GSForm = new googleSet();
                    GSForm.Show();
                    break;
                case "NEAR":
                    
                    break;

            }
        }
    }
}
