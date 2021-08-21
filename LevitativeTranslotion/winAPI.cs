using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace LevitativeTranslotion
{
    struct MSG
    {
        public IntPtr Hwnd;
        public uint Message;
        public IntPtr WParam;
        public IntPtr LParam;
        public uint Time;
    }
    class winAPI
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "RegisterHotKey", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll", EntryPoint = "GetMessage", SetLastError = true)]
        public static extern bool GetMessage(ref MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
        [DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", EntryPoint = "GetForegroundWindow", SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, IntPtr dwExtraInfo);
        [DllImport("user32.dll", EntryPoint = "WindowFromPoint", SetLastError = true)]
        public static extern IntPtr WindowFromPoint(Point point);
        [DllImport("user32.dll", EntryPoint = "GetCursorPos", SetLastError = true)]
        public static extern bool GetCursorPos(ref Point rpoint);
        [DllImport("user32.dll", EntryPoint = "GetWindowTextA", SetLastError = true)]
        public static extern int GetWindowTextA(IntPtr hWnd, StringBuilder lptrString, int nMaxCount);
        [DllImport("user32.dll", EntryPoint = "GetAncestor", SetLastError = true)]
        public static extern IntPtr GetAncestor(IntPtr hWnd, uint gaFlags);

        public static void KeyOperate(Keys keys, byte type)
        {
            switch (type)  //0:keydown 1:keyup 2:keypress
            {
                case 0:
                    keybd_event((byte)keys, 0, 0, IntPtr.Zero);
                    break;
                case 1:
                    keybd_event((byte)keys, 0, 2, IntPtr.Zero);
                    break;
                case 2:
                    keybd_event((byte)keys, 0, 0, IntPtr.Zero);
                    keybd_event((byte)keys, 0, 2, IntPtr.Zero);
                    break;
            }
        }
    }
}
