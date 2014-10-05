// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Photo.MDI
// Assembly: Green Dragon Photo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2417A2D4-86EC-4631-843E-52B32AEBFCAB
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Photo.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Green_Dragon_Photo
{
  public class MDI : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private Form PhotoInstance;
    public static StatusBar status;
    private IContainer components;
    [AccessedThroughProperty("MenuItem1")]
    private MenuItem _MenuItem1;
    [AccessedThroughProperty("MenuItem4")]
    private MenuItem _MenuItem4;
    [AccessedThroughProperty("MnuOpen")]
    private MenuItem _MnuOpen;
    [AccessedThroughProperty("MnuExit")]
    private MenuItem _MnuExit;
    [AccessedThroughProperty("OpenFileDialog1")]
    private OpenFileDialog _OpenFileDialog1;
    [AccessedThroughProperty("MainMenu1")]
    private MainMenu _MainMenu1;
    [AccessedThroughProperty("StatusBar1")]
    private StatusBar _StatusBar1;
    [AccessedThroughProperty("StatusBarPanel1")]
    private StatusBarPanel _StatusBarPanel1;
    [AccessedThroughProperty("StatusBarPanel2")]
    private StatusBarPanel _StatusBarPanel2;
    [AccessedThroughProperty("StatusBarPanel3")]
    private StatusBarPanel _StatusBarPanel3;

    internal virtual MenuItem MenuItem1
    {
      [DebuggerNonUserCode] get
      {
        return this._MenuItem1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MenuItem1 = value;
      }
    }

    internal virtual MenuItem MenuItem4
    {
      [DebuggerNonUserCode] get
      {
        return this._MenuItem4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MenuItem4 = value;
      }
    }

    internal virtual MenuItem MnuOpen
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuOpen;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuOpen_Click);
        if (this._MnuOpen != null)
          this._MnuOpen.Click -= eventHandler;
        this._MnuOpen = value;
        if (this._MnuOpen == null)
          return;
        this._MnuOpen.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuExit
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuExit;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuExit_Click);
        if (this._MnuExit != null)
          this._MnuExit.Click -= eventHandler;
        this._MnuExit = value;
        if (this._MnuExit == null)
          return;
        this._MnuExit.Click += eventHandler;
      }
    }

    internal virtual OpenFileDialog OpenFileDialog1
    {
      [DebuggerNonUserCode] get
      {
        return this._OpenFileDialog1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._OpenFileDialog1 = value;
      }
    }

    private virtual MainMenu MainMenu1
    {
      [DebuggerNonUserCode] get
      {
        return this._MainMenu1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MainMenu1 = value;
      }
    }

    internal virtual StatusBar StatusBar1
    {
      [DebuggerNonUserCode] get
      {
        return this._StatusBar1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._StatusBar1 = value;
      }
    }

    internal virtual StatusBarPanel StatusBarPanel1
    {
      [DebuggerNonUserCode] get
      {
        return this._StatusBarPanel1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._StatusBarPanel1 = value;
      }
    }

    internal virtual StatusBarPanel StatusBarPanel2
    {
      [DebuggerNonUserCode] get
      {
        return this._StatusBarPanel2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._StatusBarPanel2 = value;
      }
    }

    internal virtual StatusBarPanel StatusBarPanel3
    {
      [DebuggerNonUserCode] get
      {
        return this._StatusBarPanel3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._StatusBarPanel3 = value;
      }
    }

    [DebuggerNonUserCode]
    static MDI()
    {
    }

    public MDI()
    {
      this.Load += new EventHandler(this.MDI_Load);
      MDI.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      List<WeakReference> list = MDI.__ENCList;
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) list, ref lockTaken);
        if (MDI.__ENCList.Count == MDI.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (MDI.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (MDI.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                MDI.__ENCList[index1] = MDI.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          MDI.__ENCList.RemoveRange(index1, checked (MDI.__ENCList.Count - index1));
          MDI.__ENCList.Capacity = MDI.__ENCList.Count;
        }
        MDI.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) list);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MDI));
      this.MainMenu1 = new MainMenu(this.components);
      this.MenuItem1 = new MenuItem();
      this.MnuOpen = new MenuItem();
      this.MenuItem4 = new MenuItem();
      this.MnuExit = new MenuItem();
      this.OpenFileDialog1 = new OpenFileDialog();
      this.StatusBar1 = new StatusBar();
      this.StatusBarPanel1 = new StatusBarPanel();
      this.StatusBarPanel2 = new StatusBarPanel();
      this.StatusBarPanel3 = new StatusBarPanel();
      this.StatusBarPanel1.BeginInit();
      this.StatusBarPanel2.BeginInit();
      this.StatusBarPanel3.BeginInit();
      this.SuspendLayout();
      this.MainMenu1.MenuItems.AddRange(new MenuItem[1]
      {
        this.MenuItem1
      });
      this.MenuItem1.Index = 0;
      this.MenuItem1.MenuItems.AddRange(new MenuItem[3]
      {
        this.MnuOpen,
        this.MenuItem4,
        this.MnuExit
      });
      this.MenuItem1.MergeType = MenuMerge.MergeItems;
      this.MenuItem1.Text = "File";
      this.MnuOpen.Index = 0;
      this.MnuOpen.Text = "Open";
      this.MenuItem4.Index = 1;
      this.MenuItem4.Text = "-";
      this.MnuExit.Index = 2;
      this.MnuExit.MergeOrder = 99;
      this.MnuExit.Text = "Exit";
      this.OpenFileDialog1.Filter = componentResourceManager.GetString("OpenFileDialog1.Filter");
      this.StatusBar1.Location = new Point(0, 253);
      this.StatusBar1.Name = "StatusBar1";
      this.StatusBar1.Panels.AddRange(new StatusBarPanel[3]
      {
        this.StatusBarPanel1,
        this.StatusBarPanel2,
        this.StatusBarPanel3
      });
      StatusBar statusBar1 = this.StatusBar1;
      Size size1 = new Size(292, 20);
      Size size2 = size1;
      statusBar1.Size = size2;
      this.StatusBar1.TabIndex = 1;
      this.StatusBar1.Text = "No Picture";
      this.StatusBarPanel1.AutoSize = StatusBarPanelAutoSize.Contents;
      this.StatusBarPanel1.Name = "StatusBarPanel1";
      this.StatusBarPanel1.Text = "No Image";
      this.StatusBarPanel1.Width = 63;
      this.StatusBarPanel2.AutoSize = StatusBarPanelAutoSize.Contents;
      this.StatusBarPanel2.Name = "StatusBarPanel2";
      this.StatusBarPanel2.Text = "No Image";
      this.StatusBarPanel2.Width = 63;
      this.StatusBarPanel3.AutoSize = StatusBarPanelAutoSize.Contents;
      this.StatusBarPanel3.Name = "StatusBarPanel3";
      this.StatusBarPanel3.Width = 10;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(292, 273);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.StatusBar1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.IsMdiContainer = true;
      this.Menu = this.MainMenu1;
      this.Name = "MDI";
      this.Text = "Green Dragon Photo";
      this.WindowState = FormWindowState.Maximized;
      this.StatusBarPanel1.EndInit();
      this.StatusBarPanel2.EndInit();
      this.StatusBarPanel3.EndInit();
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void MnuExit_Click(object sender, EventArgs e)
    {
      this.Close();
      ProjectData.EndApp();
    }

    private void MnuOpen_Click(object sender, EventArgs e)
    {
      if (this.OpenFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.PhotoInstance = (Form) new FrmPhoto();
      this.PhotoInstance.MdiParent = (Form) this;
      this.PhotoInstance.Tag = (object) this.OpenFileDialog1.FileName;
      ((Control) this.PhotoInstance).Show();
    }

    private void MDI_Load(object sender, EventArgs e)
    {
      MDI.status = this.StatusBar1;
    }
  }
}
