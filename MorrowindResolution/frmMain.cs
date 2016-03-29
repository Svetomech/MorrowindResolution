using System;
using System.Windows.Forms;
using SimpleMaid;

namespace MorrowindResolution
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }


    private void frmMain_Load(object sender, EventArgs e)
    {
      this.Text = $"{Application.ProductName} ({SimpleApp.GetResolution()})";
      setTxtWatermark(txtX.Handle, "width");
      setTxtWatermark(txtY.Handle, "height");
    }

    private void frmMain_Shown(object sender, EventArgs e)
    {
      if (!SimpleApp.IsElevated())
      {
        MessageBox.Show("Run as administrator to modify registry values.", "Error",
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        btnApply.Enabled = false;
      }
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(txtX.Text + txtY.Text))
        return;

      int width; int height;

      if (int.TryParse(txtX.Text, out width) &&
        int.TryParse(txtY.Text, out height))
      {
        SimpleApp.SetResolution(width, height);
        this.Text = $"{Application.ProductName} ({width}x{height})";
        MessageBox.Show("Done!", Application.ProductName,
          MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show("Wrong values.", Application.ProductName,
          MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


    private void setTxtWatermark(IntPtr handle, string watermark)
    {
      NativeMethods.SendMessage(handle, 0x1501, (IntPtr)1, watermark);
    }
  }
}
