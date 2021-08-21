using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace LevitativeTranslotion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }

    public class SetConfig
    {
        private string _type;
        private string[] _gSitting = new string[2];
        private bool[] _nDisplay = new bool[3];
        private int _nSearch;

        public SetConfig() { }

        public SetConfig(string gIn, string gOut)
        {
            _type = "Google";
            _gSitting[0] = gIn;
            _gSitting[1] = gOut;
        }

        public SetConfig(bool sClass, bool sEn, bool sZh, int searchNum)
        {
            _type = "NAER";
            _nDisplay[0] = sClass;
            _nDisplay[1] = sEn;
            _nDisplay[2] = sZh;
            _nSearch = searchNum;
        }

        public string type { get => _type; }

        public string gIn { get => _gSitting[0]; }
        public string gOut { get => _gSitting[1]; }

        public bool nClass { get => _nDisplay[0]; }
        public bool nEnglish { get => _nDisplay[0]; }
        public bool nChinese { get => _nDisplay[0]; }
        public int nSearchNum { get => _nSearch; }
    }

    public class Translator
    {
        public static string googleTranslatedText(string inLanguage, string outLanguage, string text)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string result = webClient.DownloadString("https://translate.googleapis.com/translate_a/single?" +
                                                     $"client=gtx&dt=t&sl={inLanguage}&tl={outLanguage}&q={text}");
            string[] splitResult = new string[2];
            splitResult = result.Split('"');
            return splitResult[1];
        }
    }

    delegate void HotkeyPressEvent();
    class Hotkey
    {
        public event HotkeyPressEvent HotkeyPress;

        public Hotkey(/*Keys keys*/)
        {
            /*Thread listenThread = new Thread(listenHotkey);
            listenThread.Start();*/
        }

        public bool regHotkey(Keys keys)
        {
            if (winAPI.RegisterHotKey(IntPtr.Zero, 0, 0, (uint)keys))
            {
                MessageBox.Show("設置成功");
                return true;
            }
            else
            {
                MessageBox.Show("按鍵 " + keys.ToString() + " 已被占用" + '\n' + "請更換快捷鍵");
                return false;
            }
        }

        public void listenHotkey()
        {
            regHotkey(Keys.F6);
            NativeMessage msg = new NativeMessage();
            while (true)  //0x0312 = Hotkey Messenge
            {
                winAPI.PeekMessage(ref msg, IntPtr.Zero, 0x0312, 0x0312, 1);
                if (msg.msg == 0x0312)
                {
                    HotkeyPress();
                    msg.msg = 0;
                }

            }
        }
    }
}
