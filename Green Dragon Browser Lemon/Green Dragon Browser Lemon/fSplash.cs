// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.fSplash
// Assembly: Green Dragon Browser, Version=1.0.3.0, Culture=neutral, PublicKeyToken=0706e68831d27660
// MVID: 73704739-5485-4C15-86EF-C4F58132E058
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser.exe

using Green_Dragon_Browser.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  [DesignerGenerated]
  public class fSplash : Form
  {
    private IContainer components;
    [AccessedThroughProperty("txtLemonBrowser")]
    private Label _txtLemonBrowser;
    [AccessedThroughProperty("txtVersion")]
    private Label _txtVersion;

    internal virtual Label txtLemonBrowser
    {
      get
      {
        return this._txtLemonBrowser;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtLemonBrowser = value;
      }
    }

    internal virtual Label txtVersion
    {
      get
      {
        return this._txtVersion;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtVersion = value;
      }
    }

    public fSplash()
    {
      this.Load += new EventHandler(this.fSplash_Load);
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
      this.txtLemonBrowser = new Label();
      this.txtVersion = new Label();
      this.SuspendLayout();
      this.txtLemonBrowser.AutoSize = true;
      this.txtLemonBrowser.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label txtLemonBrowser1 = this.txtLemonBrowser;
      Point point1 = new Point(6, 8);
      Point point2 = point1;
      txtLemonBrowser1.Location = point2;
      Label txtLemonBrowser2 = this.txtLemonBrowser;
      Padding padding1 = new Padding(2, 0, 2, 0);
      Padding padding2 = padding1;
      txtLemonBrowser2.Margin = padding2;
      this.txtLemonBrowser.Name = "txtLemonBrowser";
      Label txtLemonBrowser3 = this.txtLemonBrowser;
      Size size1 = new Size(520, 55);
      Size size2 = size1;
      txtLemonBrowser3.Size = size2;
      this.txtLemonBrowser.TabIndex = 1;
      this.txtLemonBrowser.Text = "Green Dragon Browser";
      this.txtVersion.AutoSize = true;
      Label txtVersion1 = this.txtVersion;
      point1 = new Point(218, 72);
      Point point3 = point1;
      txtVersion1.Location = point3;
      this.txtVersion.Name = "txtVersion";
      Label txtVersion2 = this.txtVersion;
      size1 = new Size(76, 21);
      Size size3 = size1;
      txtVersion2.Size = size3;
      this.txtVersion.TabIndex = 2;
      this.txtVersion.Text = "Loading...";
      this.txtVersion.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleDimensions = new SizeF(8f, 21f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(64, 64, 64);
      size1 = new Size(534, 102);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.txtVersion);
      this.Controls.Add((Control) this.txtLemonBrowser);
      this.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.FormBorderStyle = FormBorderStyle.None;
      padding1 = new Padding(4);
      this.Margin = padding1;
      this.Name = "fSplash";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "fSplash";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void fSplash_Load(object sender, EventArgs e)
    {
      this.txtVersion.Text = MyProject.Application.Info.Version.ToString();
    }
  }
}
