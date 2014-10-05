// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.fNotepad
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
  public class fNotepad : Form
  {
    private IContainer components;
    [AccessedThroughProperty("tbNotes")]
    private TextBox _tbNotes;
    [AccessedThroughProperty("cmNotes")]
    private ContextMenuStrip _cmNotes;
    [AccessedThroughProperty("iSaveAs")]
    private ToolStripMenuItem _iSaveAs;
    [AccessedThroughProperty("space1")]
    private ToolStripSeparator _space1;
    [AccessedThroughProperty("iClearAll")]
    private ToolStripMenuItem _iClearAll;
    [AccessedThroughProperty("save")]
    private SaveFileDialog _save;

    internal virtual TextBox tbNotes
    {
      get
      {
        return this._tbNotes;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tbNotes = value;
      }
    }

    internal virtual ContextMenuStrip cmNotes
    {
      get
      {
        return this._cmNotes;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cmNotes = value;
      }
    }

    internal virtual ToolStripMenuItem iSaveAs
    {
      get
      {
        return this._iSaveAs;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iSaveAs_Click);
        if (this._iSaveAs != null)
          this._iSaveAs.Click -= eventHandler;
        this._iSaveAs = value;
        if (this._iSaveAs == null)
          return;
        this._iSaveAs.Click += eventHandler;
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

    internal virtual ToolStripMenuItem iClearAll
    {
      get
      {
        return this._iClearAll;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iClearAll_Click);
        if (this._iClearAll != null)
          this._iClearAll.Click -= eventHandler;
        this._iClearAll = value;
        if (this._iClearAll == null)
          return;
        this._iClearAll.Click += eventHandler;
      }
    }

    internal virtual SaveFileDialog save
    {
      get
      {
        return this._save;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._save = value;
      }
    }

    public fNotepad()
    {
      this.Load += new EventHandler(this.fNotepad_Load);
      this.FormClosing += new FormClosingEventHandler(this.fNotepad_Closing);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fNotepad));
      this.tbNotes = new TextBox();
      this.cmNotes = new ContextMenuStrip(this.components);
      this.iSaveAs = new ToolStripMenuItem();
      this.space1 = new ToolStripSeparator();
      this.iClearAll = new ToolStripMenuItem();
      this.save = new SaveFileDialog();
      this.cmNotes.SuspendLayout();
      this.SuspendLayout();
      this.tbNotes.BackColor = Color.DimGray;
      this.tbNotes.BorderStyle = BorderStyle.None;
      this.tbNotes.ContextMenuStrip = this.cmNotes;
      this.tbNotes.Dock = DockStyle.Fill;
      this.tbNotes.ForeColor = Color.White;
      this.tbNotes.Location = new Point(0, 0);
      this.tbNotes.Multiline = true;
      this.tbNotes.Name = "tbNotes";
      TextBox tbNotes = this.tbNotes;
      Size size1 = new Size(534, 411);
      Size size2 = size1;
      tbNotes.Size = size2;
      this.tbNotes.TabIndex = 0;
      this.cmNotes.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.iSaveAs,
        (ToolStripItem) this.space1,
        (ToolStripItem) this.iClearAll
      });
      this.cmNotes.Name = "cmNotes";
      ContextMenuStrip cmNotes = this.cmNotes;
      size1 = new Size(122, 54);
      Size size3 = size1;
      cmNotes.Size = size3;
      this.iSaveAs.Image = (Image) Resources.save_dark;
      this.iSaveAs.Name = "iSaveAs";
      ToolStripMenuItem iSaveAs = this.iSaveAs;
      size1 = new Size(121, 22);
      Size size4 = size1;
      iSaveAs.Size = size4;
      this.iSaveAs.Text = "Save as...";
      this.space1.Name = "space1";
      ToolStripSeparator space1 = this.space1;
      size1 = new Size(118, 6);
      Size size5 = size1;
      space1.Size = size5;
      this.iClearAll.Image = (Image) Resources.remove_dark;
      this.iClearAll.Name = "iClearAll";
      ToolStripMenuItem iClearAll = this.iClearAll;
      size1 = new Size(121, 22);
      Size size6 = size1;
      iClearAll.Size = size6;
      this.iClearAll.Text = "Clear all";
      this.AutoScaleDimensions = new SizeF(8f, 21f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(64, 64, 64);
      size1 = new Size(534, 411);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.tbNotes);
      this.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      size1 = new Size(50, 50);
      this.MinimumSize = size1;
      this.Name = "fNotepad";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Notepad";
      this.TopMost = true;
      this.cmNotes.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void fNotepad_Load(object sender, EventArgs e)
    {
      this.tbNotes.Text = MySettingsProperty.Settings.varNotes;
    }

    private void fNotepad_Closing(object sender, CancelEventArgs e)
    {
      MySettingsProperty.Settings.varNotes = this.tbNotes.Text;
    }

    private void iSaveAs_Click(object sender, EventArgs e)
    {
      this.save.Title = "Save File";
      this.save.FileName = "notes";
      this.save.Filter = "Text File|*.txt";
      string fileName = this.save.FileName;
      string text = this.tbNotes.Text;
      if (this.save.ShowDialog() != DialogResult.OK)
        return;
      MyProject.Computer.FileSystem.WriteAllText(this.save.FileName, text, false);
    }

    private void iClearAll_Click(object sender, EventArgs e)
    {
      this.tbNotes.Text = "";
    }
  }
}
