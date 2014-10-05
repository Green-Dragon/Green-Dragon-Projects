// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Writer.SplashScreen1
// Assembly: Green Dragon Writer, Version=4.0.0.0, Culture=neutral, PublicKeyToken=f92e69f0319eaf84
// MVID: 722C2D38-0399-4F2F-8284-6B57384604E3
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Writer\Green Dragon Writer.exe

using Green_Dragon_Writer.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon_Writer
{
  [DesignerGenerated]
  public sealed class SplashScreen1 : Form
  {
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
      get
      {
        return this._ApplicationTitle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ApplicationTitle = value;
      }
    }

    internal virtual Label Version
    {
      get
      {
        return this._Version;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Version = value;
      }
    }

    internal virtual Label Copyright
    {
      get
      {
        return this._Copyright;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Copyright = value;
      }
    }

    internal virtual TableLayoutPanel MainLayoutPanel
    {
      get
      {
        return this._MainLayoutPanel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MainLayoutPanel = value;
      }
    }

    internal virtual TableLayoutPanel DetailsLayoutPanel
    {
      get
      {
        return this._DetailsLayoutPanel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._DetailsLayoutPanel = value;
      }
    }

    public SplashScreen1()
    {
      this.Load += new EventHandler(this.SplashScreen1_Load);
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
      this.MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));
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
      this.Version.Font = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.Version.Text = "Version 4.0.0.0";
      this.Copyright.Anchor = AnchorStyles.None;
      this.Copyright.BackColor = Color.Transparent;
      this.Copyright.Font = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.Copyright.Text = "Copyright Green Dragon";
      this.ApplicationTitle.Anchor = AnchorStyles.None;
      this.ApplicationTitle.BackColor = Color.Transparent;
      this.ApplicationTitle.Font = new Font("Goudy Old Style", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.ApplicationTitle.Text = "Green Dragon Writer";
      this.ApplicationTitle.TextAlign = ContentAlignment.BottomLeft;
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
  }
}
