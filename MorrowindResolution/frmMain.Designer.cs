namespace MorrowindResolution
{
  partial class frmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.txtX = new System.Windows.Forms.TextBox();
      this.txtY = new System.Windows.Forms.TextBox();
      this.btnApply = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtX
      // 
      this.txtX.Location = new System.Drawing.Point(12, 12);
      this.txtX.Name = "txtX";
      this.txtX.Size = new System.Drawing.Size(100, 20);
      this.txtX.TabIndex = 0;
      // 
      // txtY
      // 
      this.txtY.Location = new System.Drawing.Point(136, 12);
      this.txtY.Name = "txtY";
      this.txtY.Size = new System.Drawing.Size(100, 20);
      this.txtY.TabIndex = 1;
      // 
      // btnApply
      // 
      this.btnApply.Location = new System.Drawing.Point(12, 38);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(224, 23);
      this.btnApply.TabIndex = 2;
      this.btnApply.Text = "Apply";
      this.btnApply.UseVisualStyleBackColor = true;
      this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(118, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(12, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "x";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(248, 73);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnApply);
      this.Controls.Add(this.txtY);
      this.Controls.Add(this.txtX);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmMain";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.Shown += new System.EventHandler(this.frmMain_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtX;
    private System.Windows.Forms.TextBox txtY;
    private System.Windows.Forms.Button btnApply;
    private System.Windows.Forms.Label label1;
  }
}

