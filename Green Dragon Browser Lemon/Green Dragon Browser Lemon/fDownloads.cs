// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.fDownloads
// Assembly: Green Dragon Browser, Version=1.0.3.0, Culture=neutral, PublicKeyToken=0706e68831d27660
// MVID: 73704739-5485-4C15-86EF-C4F58132E058
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser.exe

using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  [DesignerGenerated]
  public class fDownloads : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    public fDownloads()
    {
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fDownloads));
      this.Label1 = new Label();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(199, 178);
      this.Label1.Name = "Label1";
      Label label1 = this.Label1;
      Size size1 = new Size(124, 21);
      Size size2 = size1;
      label1.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Planned Feature!";
      this.AutoScaleDimensions = new SizeF(8f, 21f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(64, 64, 64);
      size1 = new Size(534, 412);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label1);
      this.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      size1 = new Size(780, 450);
      this.MaximumSize = size1;
      size1 = new Size(550, 450);
      this.MinimumSize = size1;
      this.Name = "fDownloads";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Downloads";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
