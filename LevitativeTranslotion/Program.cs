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

        public SetConfig(string gIn, string gOut)  //for google
        {
            _type = "Google";
            _gSitting[0] = gIn;
            _gSitting[1] = gOut;
        }

        public SetConfig(bool sClass, bool sEn, bool sZh, int searchNum)  //for NAER
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

    public delegate void HotkeyPressEvent();
    public class HotkeyThread
    {
        public static bool threadRun = true;

        public static event HotkeyPressEvent HotkeyPress;

        private class threadInfo
        {
            public byte index { get; set; }
            public Keys Keys { get; set; }

            public threadInfo(byte index, Keys keys)
            {
                this.index = index;
                this.Keys = keys;
            }
        }

        public static void startNewThread(byte index, Keys keys)
        {
            threadInfo obj = new threadInfo(index, keys);
            Thread hotkeyThread = new Thread(newHotkey);
            hotkeyThread.Start(obj);
        }

        private static void newHotkey(object obj)
        {
            threadInfo info = (threadInfo)obj; 
            if (winAPI.RegisterHotKey(IntPtr.Zero, 0, 0, (uint)info.Keys))
            {
                NativeMessage msg = new NativeMessage();
                while (threadRun)
                {
                    winAPI.PeekMessage(ref msg, IntPtr.Zero, 0x0312, 0x0312, 1);
                    if (msg.msg == 0x0312)  //0x0312 = Hotkey Messenge
                    {
                        HotkeyPress?.Invoke();
                        msg.msg = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("按鍵 " + info.Keys.ToString() + " 已被占用，請更換快捷鍵");
            }
        }
    }
}
