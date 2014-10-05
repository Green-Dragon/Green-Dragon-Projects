// Decompiled with JetBrains decompiler
// Type: Green_Dragon.Form2
// Assembly: Green Dragon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72C6BEE2-CC2C-43BF-AE11-CDF506D6CD3B
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon
{
  [DesignerGenerated]
  public class Form2 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("WebBrowser1")]
    private WebBrowser _WebBrowser1;

    internal virtual WebBrowser WebBrowser1
    {
      get
      {
        return this._WebBrowser1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._WebBrowser1 = value;
      }
    }

    public Form2()
    {
      this.Load += new EventHandler(this.Form2_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form2));
      this.WebBrowser1 = new WebBrowser();
      this.SuspendLayout();
      this.WebBrowser1.Dock = DockStyle.Fill;
      this.WebBrowser1.Location = new Point(0, 0);
      WebBrowser webBrowser1_1 = this.WebBrowser1;
      Size size1 = new Size(20, 20);
      Size size2 = size1;
      webBrowser1_1.MinimumSize = size2;
      this.WebBrowser1.Name = "WebBrowser1";
      WebBrowser webBrowser1_2 = this.WebBrowser1;
      size1 = new Size(1350, 730);
      Size size3 = size1;
      webBrowser1_2.Size = size3;
      this.WebBrowser1.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(1350, 730);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.WebBrowser1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = "Form2";
      this.Text = "Green Dragon";
      this.ResumeLayout(false);
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      this.WebBrowser1.Navigate("http://www.greendragonsearch.net/");
    }
  }
}
