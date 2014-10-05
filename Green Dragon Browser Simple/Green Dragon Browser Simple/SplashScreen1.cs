// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.SplashScreen1
// Assembly: Green Dragon Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d25b577927d337c7
// MVID: 43B6EF03-694B-4A1E-BE9F-3F26039BA1DF
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser Simple.exe

using Green_Dragon_Browser.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  [DesignerGenerated]
  public sealed class SplashScreen1 : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    [AccessedThroughProperty("ApplicationTitle")]
    private Label _ApplicationTitle;
    [AccessedThroughProperty("Version")]
    private Label _Version;
    [AccessedThroughProperty("Copyright")]
    private Label _Copyright;
    [AccessedThroughProperty("MainLayoutPanel")]
    private TableLayoutPanel _MainLayoutPanel;
    [AccessedThroughProperty("DetailsLayoutPanel")]
    private TableLayoutPanel _DetailsLayoutPanel;
    private IContainer components;

    internal virtual Label ApplicationTitle
    {
      [DebuggerNonUserCode] get
      {
        return this._ApplicationTitle;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ApplicationTitle_Click);
        if (this._ApplicationTitle != null)
          this._ApplicationTitle.Click -= eventHandler;
        this._ApplicationTitle = value;
        if (this._ApplicationTitle == null)
          return;
        this._ApplicationTitle.Click += eventHandler;
      }
    }

    internal virtual Label Version
    {
      [DebuggerNonUserCode] get
      {
        return this._Version;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Version_Click);
        if (this._Version != null)
          this._Version.Click -= eventHandler;
        this._Version = value;
        if (this._Version == null)
          return;
        this._Version.Click += eventHandler;
      }
    }

    internal virtual Label Copyright
    {
      [DebuggerNonUserCode] get
      {
        return this._Copyright;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Copyright = value;
      }
    }

    internal virtual TableLayoutPanel MainLayoutPanel
    {
      [DebuggerNonUserCode] get
      {
        return this._MainLayoutPanel;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MainLayoutPanel = value;
      }
    }

    internal virtual TableLayoutPanel DetailsLayoutPanel
    {
      [DebuggerNonUserCode] get
      {
        return this._DetailsLayoutPanel;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._DetailsLayoutPanel = value;
      }
    }

    [DebuggerNonUserCode]
    static SplashScreen1()
    {
    }

    [DebuggerNonUserCode]
    public SplashScreen1()
    {
      this.Load += new EventHandler(this.SplashScreen1_Load);
      SplashScreen1.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      List<WeakReference> list = SplashScreen1.__ENCList;
      Monitor.Enter((object) list);
      try
      {
        if (SplashScreen1.__ENCList.Count == SplashScreen1.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (SplashScreen1.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (SplashScreen1.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                SplashScreen1.__ENCList[index1] = SplashScreen1.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          SplashScreen1.__ENCList.RemoveRange(index1, checked (SplashScreen1.__ENCList.Count - index1));
          SplashScreen1.__ENCList.Capacity = SplashScreen1.__ENCList.Count;
        }
        SplashScreen1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
      finally
      {
        Monitor.Exit((object) list);
      }
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if ((!disposing || this.components == null) && !false)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SplashScreen1));
      this.MainLayoutPanel = new TableLayoutPanel();
      this.DetailsLayoutPanel = new TableLayoutPanel();
      this.Version = new Label();
      this.Copyright = new Label();
      this.ApplicationTitle = new Label();
      this.MainLayoutPanel.SuspendLayout();
      this.DetailsLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      this.MainLayoutPanel.BackgroundImage = (Image) componentResourceManager.GetObject("MainLayoutPanel.BackgroundImage");
      this.MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
      this.MainLayoutPanel.ColumnCount = 2;
      this.MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243f));
      this.MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 253f));
      this.MainLayoutPanel.Controls.Add((Control) this.DetailsLayoutPanel, 1, 1);
      this.MainLayoutPanel.Controls.Add((Control) this.ApplicationTitle, 1, 0);
      this.MainLayoutPanel.Dock = DockStyle.Fill;
      TableLayoutPanel mainLayoutPanel1 = this.MainLayoutPanel;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      mainLayoutPanel1.Location = point2;
      this.MainLayoutPanel.Name = "MainLayoutPanel";
      this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 218f));
      this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38f));
      TableLayoutPanel mainLayoutPanel2 = this.MainLayoutPanel;
      Size size1 = new Size(496, 303);
      Size size2 = size1;
      mainLayoutPanel2.Size = size2;
      this.MainLayoutPanel.TabIndex = 0;
      this.DetailsLayoutPanel.Anchor = AnchorStyles.None;
      this.DetailsLayoutPanel.BackColor = Color.Transparent;
      this.DetailsLayoutPanel.ColumnCount = 1;
      this.DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 247f));
      this.DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142f));
      this.DetailsLayoutPanel.Controls.Add((Control) this.Version, 0, 0);
      this.DetailsLayoutPanel.Controls.Add((Control) this.Copyright, 0, 1);
      TableLayoutPanel detailsLayoutPanel1 = this.DetailsLayoutPanel;
      point1 = new Point(246, 221);
      Point point3 = point1;
      detailsLayoutPanel1.Location = point3;
      this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
      this.DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
      this.DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
      TableLayoutPanel detailsLayoutPanel2 = this.DetailsLayoutPanel;
      size1 = new Size(247, 79);
      Size size3 = size1;
      detailsLayoutPanel2.Size = size3;
      this.DetailsLayoutPanel.TabIndex = 1;
      this.Version.Anchor = AnchorStyles.None;
      this.Version.BackColor = Color.Transparent;
      this.Version.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label version1 = this.Version;
      point1 = new Point(3, 9);
      Point point4 = point1;
      version1.Location = point4;
      this.Version.Name = "Version";
      Label version2 = this.Version;
      size1 = new Size(241, 20);
      Size size4 = size1;
      version2.Size = size4;
      this.Version.TabIndex = 1;
      this.Version.Text = "Green Dragon Browser Version 1.0";
      this.Copyright.Anchor = AnchorStyles.None;
      this.Copyright.BackColor = Color.Transparent;
      this.Copyright.Cursor = Cursors.AppStarting;
      this.Copyright.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label copyright1 = this.Copyright;
      point1 = new Point(3, 39);
      Point point5 = point1;
      copyright1.Location = point5;
      this.Copyright.Name = "Copyright";
      Label copyright2 = this.Copyright;
      size1 = new Size(241, 40);
      Size size5 = size1;
      copyright2.Size = size5;
      this.Copyright.TabIndex = 2;
      this.Copyright.Text = "Copyright © Emil Sayahi";
      this.ApplicationTitle.Anchor = AnchorStyles.None;
      this.ApplicationTitle.BackColor = Color.Transparent;
      this.ApplicationTitle.Font = new Font("Catull", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ApplicationTitle.ForeColor = Color.FromArgb(0, 192, 0);
      Label applicationTitle1 = this.ApplicationTitle;
      point1 = new Point(246, 3);
      Point point6 = point1;
      applicationTitle1.Location = point6;
      this.ApplicationTitle.Name = "ApplicationTitle";
      Label applicationTitle2 = this.ApplicationTitle;
      size1 = new Size(247, 212);
      Size size6 = size1;
      applicationTitle2.Size = size6;
      this.ApplicationTitle.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(496, 303);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.MainLayoutPanel);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SplashScreen1";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.MainLayoutPanel.ResumeLayout(false);
      this.DetailsLayoutPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void SplashScreen1_Load(object sender, EventArgs e)
    {
      this.ApplicationTitle.Text = Operators.CompareString(MyProject.Application.Info.Title, "", false) == 0 ? Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName) : MyProject.Application.Info.Title;
      this.Version.Text = string.Format(this.Version.Text, (object) MyProject.Application.Info.Version.Major, (object) MyProject.Application.Info.Version.Minor);
      this.Copyright.Text = MyProject.Application.Info.Copyright;
    }

    private void ApplicationTitle_Click(object sender, EventArgs e)
    {
    }

    private void Version_Click(object sender, EventArgs e)
    {
    }
  }
}
