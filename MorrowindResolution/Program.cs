using System;
using System.Windows.Forms;
using SimpleMaid;

namespace MorrowindResolution
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      if (SimplePlatform.runningPlatform() != SimplePlatform.Platform.Windows)
        return;

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new frmMain());
    }
  }
}
