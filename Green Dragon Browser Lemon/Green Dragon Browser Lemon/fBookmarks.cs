// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.fBookmarks
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
  public class fBookmarks : Form
  {
    private IContainer components;
    [AccessedThroughProperty("listBookmarks")]
    private ListBox _listBookmarks;
    [AccessedThroughProperty("txtName")]
    private Label _txtName;
    [AccessedThroughProperty("tbName")]
    private TextBox _tbName;
    [AccessedThroughProperty("txtUrl")]
    private Label _txtUrl;
    [AccessedThroughProperty("tbUrl")]
    private TextBox _tbUrl;
    [AccessedThroughProperty("bAdd")]
    private Button _bAdd;
    [AccessedThroughProperty("cmBookmarks")]
    private ContextMenuStrip _cmBookmarks;
    [AccessedThroughProperty("iEditBookmarks")]
    private ToolStripMenuItem _iEditBookmarks;
    [AccessedThroughProperty("space1")]
    private ToolStripSeparator _space1;
    [AccessedThroughProperty("iClearBookmarks")]
    private ToolStripMenuItem _iClearBookmarks;

    internal virtual ListBox listBookmarks
    {
      get
      {
        return this._listBookmarks;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._listBookmarks = value;
      }
    }

    internal virtual Label txtName
    {
      get
      {
        return this._txtName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtName = value;
      }
    }

    internal virtual TextBox tbName
    {
      get
      {
        return this._tbName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tbName = value;
      }
    }

    internal virtual Label txtUrl
    {
      get
      {
        return this._txtUrl;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtUrl = value;
      }
    }

    internal virtual TextBox tbUrl
    {
      get
      {
        return this._tbUrl;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.tbUrl_KeyDown);
        if (this._tbUrl != null)
          this._tbUrl.KeyDown -= keyEventHandler;
        this._tbUrl = value;
        if (this._tbUrl == null)
          return;
        this._tbUrl.KeyDown += keyEventHandler;
      }
    }

    internal virtual Button bAdd
    {
      get
      {
        return this._bAdd;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bAdd_Click);
        if (this._bAdd != null)
          this._bAdd.Click -= eventHandler;
        this._bAdd = value;
        if (this._bAdd == null)
          return;
        this._bAdd.Click += eventHandler;
      }
    }

    internal virtual ContextMenuStrip cmBookmarks
    {
      get
      {
        return this._cmBookmarks;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cmBookmarks = value;
      }
    }

    internal virtual ToolStripMenuItem iEditBookmarks
    {
      get
      {
        return this._iEditBookmarks;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iEditBookmarks_Click);
        if (this._iEditBookmarks != null)
          this._iEditBookmarks.Click -= eventHandler;
        this._iEditBookmarks = value;
        if (this._iEditBookmarks == null)
          return;
        this._iEditBookmarks.Click += eventHandler;
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

    internal virtual ToolStripMenuItem iClearBookmarks
    {
      get
      {
        return this._iClearBookmarks;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iClearBookmarks_Click);
        if (this._iClearBookmarks != null)
          this._iClearBookmarks.Click -= eventHandler;
        this._iClearBookmarks = value;
        if (this._iClearBookmarks == null)
          return;
        this._iClearBookmarks.Click += eventHandler;
      }
    }

    public fBookmarks()
    {
      this.Load += new EventHandler(this.fBookmarks_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fBookmarks));
      this.listBookmarks = new ListBox();
      this.cmBookmarks = new ContextMenuStrip(this.components);
      this.iEditBookmarks = new ToolStripMenuItem();
      this.space1 = new ToolStripSeparator();
      this.iClearBookmarks = new ToolStripMenuItem();
      this.txtName = new Label();
      this.tbName = new TextBox();
      this.txtUrl = new Label();
      this.tbUrl = new TextBox();
      this.bAdd = new Button();
      this.cmBookmarks.SuspendLayout();
      this.SuspendLayout();
      this.listBookmarks.BackColor = Color.FromArgb(64, 64, 64);
      this.listBookmarks.BorderStyle = BorderStyle.None;
      this.listBookmarks.ContextMenuStrip = this.cmBookmarks;
      this.listBookmarks.Dock = DockStyle.Left;
      this.listBookmarks.Font = new Font("Segoe UI Light", 12f);
      this.listBookmarks.ForeColor = Color.White;
      this.listBookmarks.FormattingEnabled = true;
      this.listBookmarks.HorizontalScrollbar = true;
      this.listBookmarks.ItemHeight = 21;
      ListBox listBookmarks1 = this.listBookmarks;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      listBookmarks1.Location = point2;
      this.listBookmarks.Name = "listBookmarks";
      ListBox listBookmarks2 = this.listBookmarks;
      Size size1 = new Size(534, 412);
      Size size2 = size1;
      listBookmarks2.Size = size2;
      this.listBookmarks.TabIndex = 5;
      this.cmBookmarks.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.iEditBookmarks,
        (ToolStripItem) this.space1,
        (ToolStripItem) this.iClearBookmarks
      });
      this.cmBookmarks.Name = "cmBookmarks";
      ContextMenuStrip cmBookmarks = this.cmBookmarks;
      size1 = new Size(164, 54);
      Size size3 = size1;
      cmBookmarks.Size = size3;
      this.iEditBookmarks.Image = (Image) Resources.edit_dark;
      this.iEditBookmarks.Name = "iEditBookmarks";
      ToolStripMenuItem iEditBookmarks = this.iEditBookmarks;
      size1 = new Size(163, 22);
      Size size4 = size1;
      iEditBookmarks.Size = size4;
      this.iEditBookmarks.Text = "Edit bookmarks";
      this.space1.Name = "space1";
      ToolStripSeparator space1 = this.space1;
      size1 = new Size(160, 6);
      Size size5 = size1;
      space1.Size = size5;
      this.iClearBookmarks.Image = (Image) Resources.remove_dark;
      this.iClearBookmarks.Name = "iClearBookmarks";
      ToolStripMenuItem iClearBookmarks = this.iClearBookmarks;
      size1 = new Size(163, 22);
      Size size6 = size1;
      iClearBookmarks.Size = size6;
      this.iClearBookmarks.Text = "Clear bookmarks";
      this.txtName.Anchor = AnchorStyles.Left;
      this.txtName.AutoSize = true;
      Label txtName1 = this.txtName;
      point1 = new Point(541, 12);
      Point point3 = point1;
      txtName1.Location = point3;
      this.txtName.Name = "txtName";
      Label txtName2 = this.txtName;
      size1 = new Size(50, 21);
      Size size7 = size1;
      txtName2.Size = size7;
      this.txtName.TabIndex = 6;
      this.txtName.Text = "Name";
      this.tbName.Anchor = AnchorStyles.Left;
      this.tbName.BackColor = Color.DimGray;
      this.tbName.BorderStyle = BorderStyle.None;
      this.tbName.ForeColor = Color.White;
      TextBox tbName1 = this.tbName;
      point1 = new Point(597, 11);
      Point point4 = point1;
      tbName1.Location = point4;
      this.tbName.Name = "tbName";
      TextBox tbName2 = this.tbName;
      size1 = new Size(155, 22);
      Size size8 = size1;
      tbName2.Size = size8;
      this.tbName.TabIndex = 0;
      this.txtUrl.Anchor = AnchorStyles.Left;
      this.txtUrl.AutoSize = true;
      Label txtUrl1 = this.txtUrl;
      point1 = new Point(563, 53);
      Point point5 = point1;
      txtUrl1.Location = point5;
      this.txtUrl.Name = "txtUrl";
      Label txtUrl2 = this.txtUrl;
      size1 = new Size(28, 21);
      Size size9 = size1;
      txtUrl2.Size = size9;
      this.txtUrl.TabIndex = 8;
      this.txtUrl.Text = "Url";
      this.tbUrl.Anchor = AnchorStyles.Left;
      this.tbUrl.AutoCompleteMode = AutoCompleteMode.Append;
      this.tbUrl.AutoCompleteSource = AutoCompleteSource.CustomSource;
      this.tbUrl.BackColor = Color.DimGray;
      this.tbUrl.BorderStyle = BorderStyle.None;
      this.tbUrl.ForeColor = Color.White;
      TextBox tbUrl1 = this.tbUrl;
      point1 = new Point(597, 52);
      Point point6 = point1;
      tbUrl1.Location = point6;
      this.tbUrl.Name = "tbUrl";
      TextBox tbUrl2 = this.tbUrl;
      size1 = new Size(155, 22);
      Size size10 = size1;
      tbUrl2.Size = size10;
      this.tbUrl.TabIndex = 1;
      this.bAdd.Anchor = AnchorStyles.Left;
      this.bAdd.BackgroundImage = (Image) Resources.add_light;
      this.bAdd.BackgroundImageLayout = ImageLayout.Stretch;
      this.bAdd.FlatStyle = FlatStyle.Flat;
      this.bAdd.ForeColor = Color.FromArgb(64, 64, 64);
      Button bAdd1 = this.bAdd;
      point1 = new Point(720, 80);
      Point point7 = point1;
      bAdd1.Location = point7;
      this.bAdd.Name = "bAdd";
      Button bAdd2 = this.bAdd;
      size1 = new Size(32, 32);
      Size size11 = size1;
      bAdd2.Size = size11;
      this.bAdd.TabIndex = 2;
      this.bAdd.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(8f, 21f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(64, 64, 64);
      size1 = new Size(534, 412);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.bAdd);
      this.Controls.Add((Control) this.tbUrl);
      this.Controls.Add((Control) this.txtUrl);
      this.Controls.Add((Control) this.tbName);
      this.Controls.Add((Control) this.txtName);
      this.Controls.Add((Control) this.listBookmarks);
      this.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      size1 = new Size(780, 450);
      this.MaximumSize = size1;
      size1 = new Size(550, 450);
      this.MinimumSize = size1;
      this.Name = "fBookmarks";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Bookmarks";
      this.TopMost = true;
      this.cmBookmarks.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void fBookmarks_Load(object sender, EventArgs e)
    {
      this.listBookmarks.Items.Clear();
      foreach (object obj in MySettingsProperty.Settings.varBookmark)
        this.listBookmarks.Items.Add(obj);
    }

    private void bAdd_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.tbUrl.Text, "", false) == 0)
        return;
      this.listBookmarks.Items.Add((object) this.tbName.Text);
      MySettingsProperty.Settings.varBookmark.Add(this.tbName.Text);
      MySettingsProperty.Settings.varUrl.Add(this.tbUrl.Text);
      MySettingsProperty.Settings.Save();
      this.tbName.Text = "";
      this.tbUrl.Text = "";
      MyProject.Forms.fMain.loadFavicon();
      MyProject.Forms.fMain.loadBookmarks();
      this.listBookmarks.Items.Clear();
      foreach (object obj in MySettingsProperty.Settings.varBookmark)
        this.listBookmarks.Items.Add(obj);
    }

    private void tbUrl_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.bAdd.PerformClick();
    }

    private void iEditBookmarks_Click(object sender, EventArgs e)
    {
      this.Width = 780;
    }

    private void iClearBookmarks_Click(object sender, EventArgs e)
    {
      this.listBookmarks.Items.Clear();
      MySettingsProperty.Settings.varBookmark.Clear();
      MySettingsProperty.Settings.varUrl.Clear();
      MySettingsProperty.Settings.Save();
      MyProject.Forms.fMain.loadFavicon();
      MyProject.Forms.fMain.loadBookmarks();
    }
  }
}
