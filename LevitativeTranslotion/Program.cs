using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevitativeTranslotion
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
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

        public void gSet(string gIn, string gOut)
        {
            _type = "Google";
            _gSitting[0] = gIn;
            _gSitting[1] = gOut;
        }

        public void nSet(bool sClass, bool sEn, bool sZh, int searchNum)
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
}
