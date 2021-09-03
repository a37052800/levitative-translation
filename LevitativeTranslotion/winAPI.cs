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
    public struct MARGINS
    {
        public int leftWidth;
        public int rightWidth;
        public int topHeight;
        public int bottomHeight;
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
        [DllImport("user32.dll", EntryPoint = "SendMessageA", SetLastError = true)]
        public static extern IntPtr SendMessageA(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", EntryPoint = "SendMessageW", SetLastError = true)]
        public static extern IntPtr SendMessageW(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", EntryPoint = "PostMessage", SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", EntryPoint = "PostThreadMessage", SetLastError = true)]
        public static extern bool PostThreadMessage(uint threadId, uint msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", EntryPoint = "WaitMessage", SetLastError = true)]
        public static extern bool WaitMessage();
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
        [DllImport("user32.dll", EntryPoint = "SetProcessDPIAware", SetLastError = true)]
        public static extern bool SetProcessDPIAware();
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn", SetLastError = true)]
        public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);
        [DllImport("user32.dll", EntryPoint = "SetWindowRgn", SetLastError = true)]
        public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);
        [DllImport("gdi32.dll", EntryPoint = "DeleteObject", SetLastError = true)]
        public static extern bool DeleteObject(IntPtr hObject);
        [DllImport("user32.dll", EntryPoint = "GetClassLong", SetLastError = true)]
        public static extern IntPtr GetClassLongPtr32(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", EntryPoint = "SetClassLong", SetLastError = true)]
        public static extern IntPtr SetClassLongPtr32(IntPtr hWnd, int nIndex, IntPtr dwNewLong);
        [DllImport("dwmapi.dll", EntryPoint = "DwmExtendFrameIntoClientArea", SetLastError = true)]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS margins);
        [DllImport("dwmapi.dll", EntryPoint = "DwmSetWindowAttribute", SetLastError = true)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

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
        public static void KeyOperate(Keys keys1, Keys keys2, int sleep)
        {
            KeyOperate(keys1, (byte)0);
            KeyOperate(keys2, (byte)2);
            KeyOperate(keys1, (byte)1);
            Thread.Sleep(sleep);
        }

        public static void SendString(IntPtr hwnd, string str)
        {
            foreach (char ch in str)
                SendMessageW(hwnd, 0x0286, (IntPtr)ch, IntPtr.Zero);  //0x0286 = WM_IME_CHAR
        }
    }
}
