using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace LevitativeTranslotion
{
    public partial class mainForm : Form
    {
        private Thread thread;
        private bool opened = false;

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
                        SetConfig config = new SetConfig(saveFileDialog1.FileName);
                        comboBox.Tag = config;
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
                case "Export":
                    FileStream file = new FileStream(config.config2.filename, FileMode.Append);
                    byte[] text = Encoding.UTF8.GetBytes(config.text + '\n');
                    file.Write(text, 0, text.Length);
                    file.Close();
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
            //switch (index)
            //{
            //    case 1:
            //        if (comboBox1.Tag != null)
            //            set1 = (SetConfig)comboBox1.Tag;
            //        if (comboBox2.Tag != null)
            //            set2 = (SetConfig)comboBox2.Tag;
            //        break;
            //    case 2:
            //        if (comboBox3.Tag != null)
            //            set1 = (SetConfig)comboBox3.Tag;
            //        if (comboBox4.Tag != null)
            //            set2 = (SetConfig)comboBox4.Tag;
            //        break;
            //    case 3:
            //        if (comboBox5.Tag != null)
            //            set1 = (SetConfig)comboBox5.Tag;
            //        if (comboBox6.Tag != null)
            //            set2 = (SetConfig)comboBox6.Tag;
            //        break;
            //}
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
            if (thread != null)
            {
                thread.Abort();
                winAPI.KeyOperate((Keys)More.Tag, 2);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
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

            //initial setting
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            notifyIcon1.Visible = false;
            Environment.Exit(0);
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        //Item interaction
        private void More_MouseEnter(object sender, EventArgs e)
        {
            More.BackgroundImage = Properties.Resources.more_enter;
        }

        private void More_MouseLeave(object sender, EventArgs e)
        {
            More.BackgroundImage = Properties.Resources.more_normal;
        }

        private void Switch_MouseEnter(object sender, EventArgs e)
        {
            if (opened)
                Switch.BackgroundImage = Properties.Resources.switch_on_enter;
            else
                Switch.BackgroundImage = Properties.Resources.switch_off_enter;
        }

        private void Switch_MouseLeave(object sender, EventArgs e)
        {
            if (opened)
                Switch.BackgroundImage = Properties.Resources.switch_on_normal;
            else
                Switch.BackgroundImage = Properties.Resources.switch_off_normal;
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            opened = !opened;
            if (opened)
                Switch.BackgroundImage = Properties.Resources.switch_on_enter;
            else
                Switch.BackgroundImage = Properties.Resources.switch_off_enter;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.minimize_enter;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.minimize_normal;
        }

        private void Minimize_MouseDown(object sender, MouseEventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.minimize_click;
        }

        private void Minimize_MouseUp(object sender, MouseEventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.minimize_enter;
        }

        private void Hotkey_MouseEnter(object sender, EventArgs e)
        {
            if (!Hotkey.Focused)
                Hotkey.BackgroundImage = Properties.Resources.hotkey_enter;
        }

        private void Hotkey_MouseLeave(object sender, EventArgs e)
        {
            if (!Hotkey.Focused)
                Hotkey.BackgroundImage = Properties.Resources.hotkey_normal;
        }

        private void Hotkey_Enter(object sender, EventArgs e)
        {
            Hotkey.BackgroundImage = Properties.Resources.hotkey_click;
        }

        private void Hotkey_Leave(object sender, EventArgs e)
        {
            Hotkey.BackgroundImage = Properties.Resources.hotkey_normal;
        }

        private void Trancore_MouseEnter(object sender, EventArgs e)
        {
            Trancore.BackgroundImage = Properties.Resources.trancore_enter;
        }

        private void Trancore_MouseLeave(object sender, EventArgs e)
        {
            Trancore.BackgroundImage = Properties.Resources.trancore_normal;
        }

        private void Trancore_MouseDown(object sender, MouseEventArgs e)
        {
            Trancore.BackgroundImage = Properties.Resources.trancore_click;
        }

        private void Trancore_MouseUp(object sender, MouseEventArgs e)
        {
            Trancore.BackgroundImage = Properties.Resources.trancore_enter;
        }
        //Form move
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
        }

        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkGray, 1);
            int y = 55;
            Point p1 = new Point(0, y);
            Point p2 = new Point(this.Width, y);
            e.Graphics.DrawLine(pen, p1, p2);
        }
    }
}
