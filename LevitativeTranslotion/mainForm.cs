using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LevitativeTranslotion
{
    public partial class mainForm : Form
    {
        Thread thread1, thread2, thread3;

        public mainForm()
        {
            InitializeComponent();
            HotkeyThread.HotkeyPress += new HotkeyPressEvent(Hotkey_Press);
        }

        private void HotKeySlector_KeyUp(object sender, KeyEventArgs e)
        {
            Button button = (Button)sender;
            button.Text = e.KeyCode.ToString();
            button.Tag = e.KeyCode;
        }

        private void ComboBoxChanged(object sender, EventArgs e)
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
                    else comboBox.Text = "無";
                    break;
                case "NAER":
                    NAERSet NSForm = new NAERSet();
                    if (NSForm.ShowDialog() == DialogResult.OK)
                    {
                        comboBox.Tag = NSForm.returnSetting();
                    }
                    else comboBox.Text = "無";
                    break;
                case "輸出至文件":
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {

                    }
                    else comboBox.Text = "無";
                    break;
                case "貼上到視窗":
                    selectedWindow SelForm = new selectedWindow();
                    if ((SelForm.ShowDialog() == DialogResult.OK) && (SelForm.returnHWND().hwnd != IntPtr.Zero))
                    {
                        comboBox.Tag = SelForm.returnHWND();
                    }
                    else comboBox.Text = "無";
                    break;
            }
            if (comboBox.Text == "無")
                comboBox.Tag = null;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            thread1 = HotkeyThread.StartNewThread(1, (Keys)button1.Tag);
            this.Hide();
        }

        private void Hotkey_Press(byte index)
        {
            winAPI.KeyOperate(Keys.ControlKey, Keys.C, 100);
            object obj = Invoke(new mainThread(GetConfig), new object[] { index });
            Config config = (Config)obj;
            switch (config.config1.type)
            {
                case "Google":
                    bubble_Google gBubble = new bubble_Google(Translator.GoogleTranslatedText(config.config1.gIn,
                                                                                             config.config1.gOut,
                                                                                             config.text));
                    gBubble.ShowDialog();
                    break;
                case "NAER":
                    bubble_NAER nBubble = new bubble_NAER(Translator.NAERSearch(config.config1.nSource,
                                                                                config.config1.nEnname,
                                                                                config.config1.nZhtwname,
                                                                                config.config1.nSearchNum,
                                                                                config.text));
                    nBubble.ShowDialog();
                    break;
            }
            switch (config.config2.type)
            {
                case "Paste":
                    winAPI.SendString(config.config2.hwnd, config.text);
                    break;
            }
        }

        private delegate Config mainThread(byte index);

        private struct Config
        {
            public string text;
            public SetConfig config1;
            public SetConfig config2;
        }

        private Config GetConfig(byte index)
        {
            SetConfig set1 = new SetConfig();
            SetConfig set2 = new SetConfig();
            switch (index)
            {
                case 1:
                    if (comboBox1.Tag != null)
                        set1 = (SetConfig)comboBox1.Tag;
                    if (comboBox2.Tag != null)
                        set2 = (SetConfig)comboBox2.Tag;
                    break;
                case 2:
                    if (comboBox3.Tag != null)
                        set1 = (SetConfig)comboBox3.Tag;
                    if (comboBox4.Tag != null)
                        set2 = (SetConfig)comboBox4.Tag;
                    break;
                case 3:
                    if (comboBox5.Tag != null)
                        set1 = (SetConfig)comboBox5.Tag;
                    if (comboBox6.Tag != null)
                        set2 = (SetConfig)comboBox6.Tag;
                    break;
            }
            Config config = new Config
            {
                text = Clipboard.GetText(),
                config1 = set1,
                config2 = set2
            };
            return config;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            winAPI.KeyOperate((Keys)button1.Tag, 2);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //initial setting
            button1.Tag = Keys.F2;
            button2.Tag = Keys.F3;
            button3.Tag = Keys.F4;
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Visible = false;
            Environment.Exit(0);
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
