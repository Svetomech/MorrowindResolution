using static Microsoft.Win32.Registry;

namespace SimpleMaid
{
  public static class SimpleApp
  {
    public static bool IsElevated()
    {
      try { using (LocalMachine.OpenSubKey("Software\\", true)) ; }
      catch { return false; }
      return true;
    }

    public static void SetResolution(int W, int H)
    {
      using (var regKey = ClassesRoot.OpenSubKey(
        @"VirtualStore\MACHINE\SOFTWARE\Wow6432Node\Bethesda Softworks\Morrowind", true))
      {
        regKey.SetValue("Screen Width", W);
        regKey.SetValue("Screen Height", H);
      }
    }

    public static string GetResolution()
    {
      string regRes = null;

      using (var regKey = ClassesRoot.OpenSubKey(
        @"VirtualStore\MACHINE\SOFTWARE\Wow6432Node\Bethesda Softworks\Morrowind"))
      {
        string W = regKey.GetValue("Screen Width")?.ToString();
        string H = regKey.GetValue("Screen Height")?.ToString();

        regRes = $"{W}x{H}";
      }

      return regRes;
    }
  }
}
