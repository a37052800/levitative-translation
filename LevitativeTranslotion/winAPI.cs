using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace LevitativeTranslotion
{
    public struct NativeMessage
    {
        public IntPtr handle;
        public uint msg;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public System.Drawing.Point p;
    }
    class winAPI
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "RegisterHotKey", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll", EntryPoint = "GetMessage", SetLastError = true)]
        public static extern int GetMessage(ref NativeMessage lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
        [DllImport("user32.dll", EntryPoint = "PeekMessage", SetLastError = true)]
        public static extern bool PeekMessage(ref NativeMessage lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
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
        public static void KeyOperate(Keys keys1,Keys keys2,int sleep)
        {
            KeyOperate(keys1, (byte)0);
            KeyOperate(keys2, (byte)2);
            KeyOperate(keys1, (byte)1);
            Thread.Sleep(sleep);
        }

        public static void SendString(IntPtr hwnd, string str)
        {
            foreach (char ch in str)
            {
                SendMessage(hwnd, 0x0102, (IntPtr)(byte)ch, (IntPtr)1);  //0x0102 = WM_CHAR
            }
        }
    }
}
