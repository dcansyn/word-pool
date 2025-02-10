using System;
using System.Runtime.InteropServices;

namespace WordPool.UI.Api
{
    public class WindowsApi
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int i);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
    }
}
