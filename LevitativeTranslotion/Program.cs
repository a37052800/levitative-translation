using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Collections;
using HtmlAgilityPack;
using System.IO;

namespace LevitativeTranslotion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                winAPI.SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
            //Application.Run(new bubble_Google("Text for test",10));
            //Application.Run(new bubble_NAER(Translator.NAERSearch(true,true,true,30, "apple")));
        }
    }

    public class CoreConfig
    {
        private string _type;
        private string[] _gSitting = new string[2];
        private bool[] _nDisplay = new bool[3];
        private int _nSearch;
        private IntPtr _hwnd;
        private string _filename;

        public CoreConfig() { }

        public CoreConfig(string gIn, string gOut)  //for google
        {
            _type = "Google";
            _gSitting[0] = gIn;
            _gSitting[1] = gOut;
        }

        public CoreConfig(bool sClass, bool sEn, bool sZh, int searchNum)  //for NAER
        {
            _type = "NAER";
            _nDisplay[0] = sClass;
            _nDisplay[1] = sEn;
            _nDisplay[2] = sZh;
            _nSearch = searchNum;
        }

        public CoreConfig(IntPtr hwnd)
        {
            _type = "Paste";
            _hwnd = hwnd;
        }  //for Paste to Window

        public CoreConfig(string filename) //for Export to file
        {
            _type = "Export";
            _filename = filename;
        }

        public string type { get => _type; }

        public string gIn { get => _gSitting[0]; }
        public string gOut { get => _gSitting[1]; }

        public bool nSource { get => _nDisplay[0]; }
        public bool nEnname { get => _nDisplay[0]; }
        public bool nZhtwname { get => _nDisplay[0]; }
        public int nSearchNum { get => _nSearch; }

        public IntPtr hwnd { get => _hwnd; }

        public string filename { get => _filename; }
    }
    public class MoreConfig
    {
        public bool isPaste { get; }
        public bool isExport { get; }
        public IntPtr hwnd { get; }
        public string filename { get; }
        public int fontSize { get; }

        public MoreConfig() { }
        public MoreConfig(bool isPaste, bool isExport, IntPtr hwnd, string filename, int fontSize)
        {
            this.isPaste = isPaste;
            this.isExport = isExport;
            this.hwnd = hwnd;
            this.filename = filename;
            this.fontSize = fontSize;
        }
    }

    public class Translator
    {
        public static string GoogleTranslatedText(string inLanguage, string outLanguage, string text)
        {
            WebClient webClient = new WebClient { Encoding = Encoding.UTF8 };
            string result = webClient.DownloadString("https://translate.googleapis.com/translate_a/single?" +
                                                     $"client=gtx&dt=t&sl={inLanguage}&tl={outLanguage}&q={text}");
            JsonNode jsonNode = JsonNode.Parse(result);
            string translation = "";
            for (int i = 0; i < jsonNode[0].AsArray().Count; i++)
            {
                translation += jsonNode[0][i][0].ToString();
            }

            return translation;
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
                if (SoNodes != null)
                    foreach (HtmlNode So in SoNodes)
                        result[0].Add(So.InnerText);
            }
            if (enname)
            {
                HtmlNodeCollection EnNodes = htmlDocument.DocumentNode.SelectNodes("//td[@class='ennameW']/a");
                if (EnNodes != null)
                    foreach (HtmlNode En in EnNodes)
                        result[1].Add(En.InnerText);
            }
            if (zhtwname)
            {
                HtmlNodeCollection ZhNodes = htmlDocument.DocumentNode.SelectNodes("//td[@class='zhtwnameW']/a");
                if (ZhNodes != null)
                    foreach (HtmlNode Zh in ZhNodes)
                        result[2].Add(Zh.InnerText);
            }
            return result;
        }
    }

    public delegate void HotkeyPressEvent();
    public class HotkeyThread
    {
        public static event HotkeyPressEvent HotkeyPress;

        public static Thread StartNewThread(Keys keys)
        {
            Thread hotkeyThread = new Thread(NewHotkey);
            hotkeyThread.Start(keys);

            return hotkeyThread;
        }

        private static void NewHotkey(object obj)
        {
            Keys keys = (Keys)obj;
            if (winAPI.RegisterHotKey(IntPtr.Zero, 0, 0, (uint)keys))
            {
                NativeMessage msg = new NativeMessage();
                while (true)
                {
                    //winAPI.WaitMessage();
                    winAPI.GetMessage(ref msg, IntPtr.Zero, 0x0312, 0x0312);
                    HotkeyPress?.Invoke();
                    /*winAPI.PeekMessage(ref msg, IntPtr.Zero, 0x0312, 0x0312, 1);
                    if (msg.msg == 0x0312)  //0x0312 = Hotkey Messenge
                    {
                        HotkeyPress?.Invoke(info.index);
                        msg.msg = 0;
                    }*/
                }
            }
            else
            {
                MessageBox.Show("按鍵 " + keys.ToString() + " 已被占用，請更換快捷鍵");
            }
        }
    }
}
