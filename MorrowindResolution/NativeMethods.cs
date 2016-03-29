using System;
using System.Runtime.InteropServices;

namespace MorrowindResolution
{
  internal static class NativeMethods
  {
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    internal static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lp);
  }
}
