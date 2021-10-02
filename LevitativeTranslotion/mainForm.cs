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
        private bool running = false;
        private string[] coretype = { "Null", "Google", "NAER" };
        private int coreIndex = 0;
        private toolMenu menu = new toolMenu();

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

        private void Trancore_Click(object sender, EventArgs e)
        {
            coreIndex = (coreIndex + 1) % 3;
            switch (coretype[coreIndex])
            {
                case "Null":
                    Trancore.Text = "無";
                    Trancore.Tag = null;
                    coreIndex = 0;
                    break;
                case "Google":
                    Trancore.Text = "Google 翻譯";
                    googleSet GSForm = new googleSet();
                    if (GSForm.ShowDialog() == DialogResult.OK)
                    {
                        Trancore.Tag = GSForm.returnSitting();
                    }
                    else
                    {
                        Trancore.Text = "無";
                        Trancore.Tag = null;
                        coreIndex = 0;
                    }
                    break;
                case "NAER":
                    Trancore.Text = "雙語詞彙學術名詞暨辭書資訊網";
                    NAERSet NSForm = new NAERSet();
                    if (NSForm.ShowDialog() == DialogResult.OK)
                    {
                        Trancore.Tag = NSForm.returnSetting();
                    }
                    else
                    {
                        Trancore.Text = "無";
                        Trancore.Tag = null;
                        coreIndex = 0;
                    }
                    break;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (running)
                notifyIcon1.ShowBalloonTip(3, "運行中", "縮小至系統匣", ToolTipIcon.None);
            else
                notifyIcon1.ShowBalloonTip(3, "未運行", "縮小至系統匣", ToolTipIcon.None);
        }

        private void More_Click(object sender, EventArgs e)
        {
            menu.Show();
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            //interaction
            running = !running;
            if (running)
                Switch.BackgroundImage = Properties.Resources.switch_on_enter;
            else
                Switch.BackgroundImage = Properties.Resources.switch_off_enter;

            //Function
            if (running)
            {
                if (Hotkey.Tag != null)
                    thread = HotkeyThread.StartNewThread((Keys)Hotkey.Tag);
                else
                {
                    running = false;
                    MessageBox.Show("請設置快捷鍵"); //notice by brush flash
                }
            }
            else
            {
                if (thread != null)
                {
                    thread.Abort();
                    winAPI.KeyOperate((Keys)Hotkey.Tag, 2);
                }
            }
        }

        private void Hotkey_Press()
        {
            winAPI.KeyOperate(Keys.ControlKey, Keys.C, 100);
            object obj = Invoke(new mainThread(GetConfig));
            Config config = (Config)obj;
            if (config.trancore.type != null)
                switch (config.trancore.type)
                {
                    case "Google":
                        bubble_Google gBubble = new bubble_Google(Translator.GoogleTranslatedText(config.trancore.gIn,
                                                                                                 config.trancore.gOut,
                                                                                                 config.text));
                        gBubble.ShowDialog();
                        break;
                    case "NAER":
                        bubble_NAER nBubble = new bubble_NAER(Translator.NAERSearch(config.trancore.nSource,
                                                                                    config.trancore.nEnname,
                                                                                    config.trancore.nZhtwname,
                                                                                    config.trancore.nSearchNum,
                                                                                    config.text));
                        nBubble.ShowDialog();
                        break;
                }
            if(config.morefunction.isPaste)
                winAPI.SendString(config.morefunction.hwnd, config.text);
            if(config.morefunction.isExport)
            {
                FileStream file = new FileStream(config.morefunction.filename, FileMode.Append);
                byte[] text = Encoding.UTF8.GetBytes(config.text + '\n');
                file.Write(text, 0, text.Length);
                file.Close();
            }
        }

        private delegate Config mainThread();

        private struct Config
        {
            public string text;
            public CoreConfig trancore;
            public MoreConfig morefunction;
        }

        private Config GetConfig()
        {
            CoreConfig trancoreTag = new CoreConfig();
            MoreConfig moreTag = new MoreConfig();

            trancoreTag = (CoreConfig)Trancore.Tag;
            moreTag = menu.GetConfig();

            Config config = new Config
            {
                text = Clipboard.GetText(),
                trancore = trancoreTag,
                morefunction = moreTag
            };
            return config;
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
            menu.Owner = this;
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        public void CloseForm()
        {
            notifyIcon1.Visible = false;
            Environment.Exit(0);
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }   //change to Menuform

        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Gray, 1);
            int y = 55;
            Point p1 = new Point(0, y);
            Point p2 = new Point(this.Width, y);
            e.Graphics.DrawLine(pen, p1, p2);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                menu.Show();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
