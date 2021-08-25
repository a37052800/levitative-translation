using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Collections;
using HtmlAgilityPack;

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
        private IntPtr _hwnd;

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

        public SetConfig(IntPtr hwnd)
        {
            _type = "Paste";
            _hwnd = hwnd;
        }  //for Paste to Window

        public string type { get => _type; }

        public string gIn { get => _gSitting[0]; }
        public string gOut { get => _gSitting[1]; }

        public bool nSource { get => _nDisplay[0]; }
        public bool nEnname { get => _nDisplay[0]; }
        public bool nZhtwname { get => _nDisplay[0]; }
        public int nSearchNum { get => _nSearch; }

        public IntPtr hwnd { get => _hwnd; }
    }

    public class Translator
    {
        public static string GoogleTranslatedText(string inLanguage, string outLanguage, string text)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string result = webClient.DownloadString("https://translate.googleapis.com/translate_a/single?" +
                                                     $"client=gtx&dt=t&sl={inLanguage}&tl={outLanguage}&q={text}");
            string[] splitResult = new string[2];
            splitResult = result.Split('"');
            return splitResult[1];
        }

        public static ArrayList[] NAERSearch(bool source, bool enname, bool zhtwname, int searchNum, string text)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument htmlDocument = htmlWeb.Load("https://terms.naer.edu.tw/search/?" +
                                                                     $"q={text}&num={searchNum}");
            ArrayList[] result = new ArrayList[3];
            result[0] = new ArrayList();
            result[1] = new ArrayList();
            result[2] = new ArrayList();
            if (source)
            {
                HtmlNodeCollection SoNodes = htmlDocument.DocumentNode.SelectNodes("//td[@class='sourceW']/a");
                foreach (HtmlNode So in SoNodes)
                    result[0].Add(So.InnerText);
            }
            if (enname)
            {
                HtmlNodeCollection EnNodes = htmlDocument.DocumentNode.SelectNodes("//td[@class='ennameW']/a");
                foreach (HtmlNode En in EnNodes)
                    result[1].Add(En.InnerText);
            }
            if (zhtwname)
            {
                HtmlNodeCollection ZhNodes = htmlDocument.DocumentNode.SelectNodes("//td[@class='zhtwnameW']/a");
                foreach (HtmlNode Zh in ZhNodes)
                    result[2].Add(Zh.InnerText);
            }
            return result;
        }
    }

    public delegate void HotkeyPressEvent(byte index);
    public class HotkeyThread
    {
        public static bool threadRun = true;

        public static event HotkeyPressEvent HotkeyPress;

        private class ThreadInfo
        {
            public byte index { get; set; }
            public Keys Keys { get; set; }

            public ThreadInfo(byte index, Keys keys)
            {
                this.index = index;
                this.Keys = keys;
            }
        }

        public static void StartNewThread(byte index, Keys keys)
        {
            ThreadInfo obj = new ThreadInfo(index, keys);
            Thread hotkeyThread = new Thread(NewHotkey);
            hotkeyThread.Start(obj);
        }

        private static void NewHotkey(object obj)
        {
            ThreadInfo info = (ThreadInfo)obj;
            if (winAPI.RegisterHotKey(IntPtr.Zero, 0, 0, (uint)info.Keys))
            {
                NativeMessage msg = new NativeMessage();
                while (threadRun)
                {
                    winAPI.PeekMessage(ref msg, IntPtr.Zero, 0x0312, 0x0312, 1);
                    if (msg.msg == 0x0312)  //0x0312 = Hotkey Messenge
                    {
                        HotkeyPress?.Invoke(info.index);
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
