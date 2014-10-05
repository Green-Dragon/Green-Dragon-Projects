// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.fHistory
// Assembly: Green Dragon Browser, Version=1.0.3.0, Culture=neutral, PublicKeyToken=0706e68831d27660
// MVID: 73704739-5485-4C15-86EF-C4F58132E058
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser.exe

using Green_Dragon_Browser.My;
using Green_Dragon_Browser.My.Resources;
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
  public class fHistory : Form
  {
    private IContainer components;
    [AccessedThroughProperty("listHistory")]
    private ListBox _listHistory;
    [AccessedThroughProperty("cmHistory")]
    private ContextMenuStrip _cmHistory;
    [AccessedThroughProperty("iClearHistory")]
    private ToolStripMenuItem _iClearHistory;
    [AccessedThroughProperty("iEditHistory")]
    private ToolStripMenuItem _iEditHistory;
    [AccessedThroughProperty("space1")]
    private ToolStripSeparator _space1;
    [AccessedThroughProperty("cbAutoLock")]
    private CheckBox _cbAutoLock;
    [AccessedThroughProperty("txtAutoLock")]
    private Label _txtAutoLock;
    [AccessedThroughProperty("txtAutoClear")]
    private Label _txtAutoClear;
    [AccessedThroughProperty("cbAutoClear")]
    private CheckBox _cbAutoClear;

    internal virtual ListBox listHistory
    {
      get
      {
        return this._listHistory;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.listHistory_DoubleClick);
        if (this._listHistory != null)
          this._listHistory.DoubleClick -= eventHandler;
        this._listHistory = value;
        if (this._listHistory == null)
          return;
        this._listHistory.DoubleClick += eventHandler;
      }
    }

    internal virtual ContextMenuStrip cmHistory
    {
      get
      {
        return this._cmHistory;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cmHistory = value;
      }
    }

    internal virtual ToolStripMenuItem iClearHistory
    {
      get
      {
        return this._iClearHistory;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iClearHistory_Click);
        if (this._iClearHistory != null)
          this._iClearHistory.Click -= eventHandler;
        this._iClearHistory = value;
        if (this._iClearHistory == null)
          return;
        this._iClearHistory.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iEditHistory
    {
      get
      {
        return this._iEditHistory;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iEditHistory_Click);
        if (this._iEditHistory != null)
          this._iEditHistory.Click -= eventHandler;
        this._iEditHistory = value;
        if (this._iEditHistory == null)
          return;
        this._iEditHistory.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator space1
    {
      get
      {
        return this._space1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._space1 = value;
      }
    }

    internal virtual CheckBox cbAutoLock
    {
      get
      {
        return this._cbAutoLock;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cbAutoLock_CheckedChanged);
        if (this._cbAutoLock != null)
          this._cbAutoLock.CheckedChanged -= eventHandler;
        this._cbAutoLock = value;
        if (this._cbAutoLock == null)
          return;
        this._cbAutoLock.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label txtAutoLock
    {
      get
      {
        return this._txtAutoLock;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtAutoLock = value;
      }
    }

    internal virtual Label txtAutoClear
    {
      get
      {
        return this._txtAutoClear;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtAutoClear = value;
      }
    }

    internal virtual CheckBox cbAutoClear
    {
      get
      {
        return this._cbAutoClear;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cbAutoClear_CheckedChanged);
        if (this._cbAutoClear != null)
          this._cbAutoClear.CheckedChanged -= eventHandler;
        this._cbAutoClear = value;
        if (this._cbAutoClear == null)
          return;
        this._cbAutoClear.CheckedChanged += eventHandler;
      }
    }

    public fHistory()
    {
      this.Load += new EventHandler(this.fHistory_Load);
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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHistory));
      this.listHistory = new ListBox();
      this.cmHistory = new ContextMenuStrip(this.components);
      this.iEditHistory = new ToolStripMenuItem();
      this.space1 = new ToolStripSeparator();
      this.iClearHistory = new ToolStripMenuItem();
      this.cbAutoLock = new CheckBox();
      this.txtAutoLock = new Label();
      this.txtAutoClear = new Label();
      this.cbAutoClear = new CheckBox();
      this.cmHistory.SuspendLayout();
      this.SuspendLayout();
      this.listHistory.BackColor = Color.FromArgb(64, 64, 64);
      this.listHistory.BorderStyle = BorderStyle.None;
      this.listHistory.ContextMenuStrip = this.cmHistory;
      this.listHistory.Dock = DockStyle.Left;
      this.listHistory.ForeColor = Color.White;
      this.listHistory.FormattingEnabled = true;
      this.listHistory.HorizontalScrollbar = true;
      this.listHistory.ItemHeight = 21;
      ListBox listHistory1 = this.listHistory;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      listHistory1.Location = point2;
      this.listHistory.Name = "listHistory";
      ListBox listHistory2 = this.listHistory;
      Size size1 = new Size(534, 412);
      Size size2 = size1;
      listHistory2.Size = size2;
      this.listHistory.TabIndex = 1;
      this.cmHistory.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.iEditHistory,
        (ToolStripItem) this.space1,
        (ToolStripItem) this.iClearHistory
      });
      this.cmHistory.Name = "cmHistory";
      ContextMenuStrip cmHistory = this.cmHistory;
      size1 = new Size(141, 54);
      Size size3 = size1;
      cmHistory.Size = size3;
      this.iEditHistory.Image = (Image) Resources.edit_dark;
      this.iEditHistory.Name = "iEditHistory";
      ToolStripMenuItem iEditHistory = this.iEditHistory;
      size1 = new Size(140, 22);
      Size size4 = size1;
      iEditHistory.Size = size4;
      this.iEditHistory.Text = "Edit history";
      this.space1.Name = "space1";
      ToolStripSeparator space1 = this.space1;
      size1 = new Size(137, 6);
      Size size5 = size1;
      space1.Size = size5;
      this.iClearHistory.Image = (Image) Resources.remove_dark;
      this.iClearHistory.Name = "iClearHistory";
      ToolStripMenuItem iClearHistory = this.iClearHistory;
      size1 = new Size(140, 22);
      Size size6 = size1;
      iClearHistory.Size = size6;
      this.iClearHistory.Text = "Clear history";
      this.cbAutoLock.AutoSize = true;
      CheckBox cbAutoLock1 = this.cbAutoLock;
      point1 = new Point(540, 126);
      Point point3 = point1;
      cbAutoLock1.Location = point3;
      this.cbAutoLock.Name = "cbAutoLock";
      CheckBox cbAutoLock2 = this.cbAutoLock;
      size1 = new Size(96, 25);
      Size size7 = size1;
      cbAutoLock2.Size = size7;
      this.cbAutoLock.TabIndex = 4;
      this.cbAutoLock.Text = "Auto Lock";
      this.cbAutoLock.UseVisualStyleBackColor = true;
      this.txtAutoLock.AutoSize = true;
      Label txtAutoLock1 = this.txtAutoLock;
      point1 = new Point(540, 154);
      Point point4 = point1;
      txtAutoLock1.Location = point4;
      this.txtAutoLock.Name = "txtAutoLock";
      Label txtAutoLock2 = this.txtAutoLock;
      size1 = new Size(204, 84);
      Size size8 = size1;
      txtAutoLock2.Size = size8;
      this.txtAutoLock.TabIndex = 5;
      this.txtAutoLock.Text = "When checked, this browser\r\nwill automatically lock itself\r\nevery 30 minutes.  This is a\r\nnewly added security feature.";
      this.txtAutoLock.TextAlign = ContentAlignment.MiddleLeft;
      this.txtAutoClear.AutoSize = true;
      Label txtAutoClear1 = this.txtAutoClear;
      point1 = new Point(540, 40);
      Point point5 = point1;
      txtAutoClear1.Location = point5;
      this.txtAutoClear.Name = "txtAutoClear";
      Label txtAutoClear2 = this.txtAutoClear;
      size1 = new Size(196, 63);
      Size size9 = size1;
      txtAutoClear2.Size = size9;
      this.txtAutoClear.TabIndex = 7;
      this.txtAutoClear.Text = "When checked, ALL history\r\nand auto complete memory\r\nwill be deleted on exit.";
      this.txtAutoClear.TextAlign = ContentAlignment.MiddleLeft;
      this.cbAutoClear.AutoSize = true;
      CheckBox cbAutoClear1 = this.cbAutoClear;
      point1 = new Point(540, 12);
      Point point6 = point1;
      cbAutoClear1.Location = point6;
      this.cbAutoClear.Name = "cbAutoClear";
      CheckBox cbAutoClear2 = this.cbAutoClear;
      size1 = new Size(100, 25);
      Size size10 = size1;
      cbAutoClear2.Size = size10;
      this.cbAutoClear.TabIndex = 6;
      this.cbAutoClear.Text = "Auto Clear";
      this.cbAutoClear.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(8f, 21f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(64, 64, 64);
      size1 = new Size(534, 412);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.txtAutoClear);
      this.Controls.Add((Control) this.cbAutoClear);
      this.Controls.Add((Control) this.txtAutoLock);
      this.Controls.Add((Control) this.cbAutoLock);
      this.Controls.Add((Control) this.listHistory);
      this.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      size1 = new Size(780, 450);
      this.MaximumSize = size1;
      size1 = new Size(550, 450);
      this.MinimumSize = size1;
      this.Name = "fHistory";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "History";
      this.TopMost = true;
      this.cmHistory.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void fHistory_Load(object sender, EventArgs e)
    {
      this.listHistory.Items.Clear();
      foreach (object obj in MySettingsProperty.Settings.varHistory)
        this.listHistory.Items.Add(obj);
      this.cbAutoClear.Checked = Conversions.ToBoolean(MySettingsProperty.Settings.autoClear);
      if (Conversions.ToBoolean(MySettingsProperty.Settings.autoLock))
        this.cbAutoLock.Checked = true;
      else
        this.cbAutoLock.Checked = false;
    }

    private void listHistory_DoubleClick(object sender, EventArgs e)
    {
      WebBrowser webBrowser = (WebBrowser) MyProject.Forms.fMain.tcWeb.SelectedTab.Controls[0];
      // ISSUE: variable of the null type
      __Null local1 = null;
      string MemberName = "Navigate";
      object[] objArray1 = new object[1];
      object[] objArray2 = objArray1;
      int index = 0;
      ListBox listHistory = this.listHistory;
      object objectValue = RuntimeHelpers.GetObjectValue(listHistory.SelectedItem);
      objArray2[index] = objectValue;
      object[] objArray3 = objArray1;
      object[] Arguments = objArray3;
      // ISSUE: variable of the null type
      __Null local2 = null;
      // ISSUE: variable of the null type
      __Null local3 = null;
      bool[] flagArray = new bool[1]
      {
        true
      };
      bool[] CopyBack = flagArray;
      int num = 1;
      NewLateBinding.LateCall((object) webBrowser, (System.Type) local1, MemberName, Arguments, (string[]) local2, (System.Type[]) local3, CopyBack, num != 0);
      if (!flagArray[0])
        return;
      listHistory.SelectedItem = RuntimeHelpers.GetObjectValue(objArray3[0]);
    }

    private void cbAutoClear_CheckedChanged(object sender, EventArgs e)
    {
      MySettingsProperty.Settings.autoClear = !this.cbAutoClear.Checked ? Conversions.ToString(false) : Conversions.ToString(true);
      MyProject.Forms.fMain.loadVar();
    }

    private void cbAutoLock_CheckedChanged(object sender, EventArgs e)
    {
      MySettingsProperty.Settings.autoLock = !this.cbAutoLock.Checked ? Conversions.ToString(false) : Conversions.ToString(true);
      MyProject.Forms.fMain.loadVar();
    }

    private void iEditHistory_Click(object sender, EventArgs e)
    {
      this.Width = 780;
    }

    private void iClearHistory_Click(object sender, EventArgs e)
    {
      this.listHistory.Items.Clear();
      MySettingsProperty.Settings.autoComplete.Clear();
      MySettingsProperty.Settings.varHistory.Clear();
      MySettingsProperty.Settings.Save();
      MyProject.Forms.fMain.loadVar();
    }
  }
}
