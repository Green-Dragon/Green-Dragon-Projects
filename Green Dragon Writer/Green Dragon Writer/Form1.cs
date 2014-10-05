// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Writer.Form1
// Assembly: Green Dragon Writer, Version=4.0.0.0, Culture=neutral, PublicKeyToken=f92e69f0319eaf84
// MVID: 722C2D38-0399-4F2F-8284-6B57384604E3
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Writer\Green Dragon Writer.exe

using Green_Dragon_Writer.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon_Writer
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("ToolStrip1")]
    private ToolStrip _ToolStrip1;
    [AccessedThroughProperty("ToolStripDropDownButton1")]
    private ToolStripDropDownButton _ToolStripDropDownButton1;
    [AccessedThroughProperty("SaveToolStripMenuItem")]
    private ToolStripMenuItem _SaveToolStripMenuItem;
    [AccessedThroughProperty("OpenToolStripMenuItem")]
    private ToolStripMenuItem _OpenToolStripMenuItem;
    [AccessedThroughProperty("ToolStripDropDownButton2")]
    private ToolStripDropDownButton _ToolStripDropDownButton2;
    [AccessedThroughProperty("UndoToolStripMenuItem")]
    private ToolStripMenuItem _UndoToolStripMenuItem;
    [AccessedThroughProperty("RedoToolStripMenuItem")]
    private ToolStripMenuItem _RedoToolStripMenuItem;
    [AccessedThroughProperty("CutToolStripMenuItem")]
    private ToolStripMenuItem _CutToolStripMenuItem;
    [AccessedThroughProperty("CopyToolStripMenuItem")]
    private ToolStripMenuItem _CopyToolStripMenuItem;
    [AccessedThroughProperty("PasteToolStripMenuItem")]
    private ToolStripMenuItem _PasteToolStripMenuItem;
    [AccessedThroughProperty("ClearToolStripMenuItem")]
    private ToolStripMenuItem _ClearToolStripMenuItem;
    [AccessedThroughProperty("SelectAllToolStripMenuItem")]
    private ToolStripMenuItem _SelectAllToolStripMenuItem;
    [AccessedThroughProperty("RichTextBox1")]
    private RichTextBox _RichTextBox1;
    [AccessedThroughProperty("ToolStripDropDownButton3")]
    private ToolStripDropDownButton _ToolStripDropDownButton3;
    [AccessedThroughProperty("ToolStripMenuItem1")]
    private ToolStripMenuItem _ToolStripMenuItem1;
    [AccessedThroughProperty("ToolStripMenuItem2")]
    private ToolStripMenuItem _ToolStripMenuItem2;
    [AccessedThroughProperty("ToolStripDropDownButton4")]
    private ToolStripDropDownButton _ToolStripDropDownButton4;
    [AccessedThroughProperty("ToolStripDropDownButton5")]
    private ToolStripDropDownButton _ToolStripDropDownButton5;
    [AccessedThroughProperty("CheckForUpdateToolStripMenuItem")]
    private ToolStripMenuItem _CheckForUpdateToolStripMenuItem;
    [AccessedThroughProperty("WordWrapToolStripMenuItem")]
    private ToolStripMenuItem _WordWrapToolStripMenuItem;
    [AccessedThroughProperty("WordWrapOffToolStripMenuItem")]
    private ToolStripMenuItem _WordWrapOffToolStripMenuItem;

    internal virtual ToolStrip ToolStrip1
    {
      get
      {
        return this._ToolStrip1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ToolStrip1 = value;
      }
    }

    internal virtual ToolStripDropDownButton ToolStripDropDownButton1
    {
      get
      {
        return this._ToolStripDropDownButton1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripDropDownButton1_Click);
        if (this._ToolStripDropDownButton1 != null)
          this._ToolStripDropDownButton1.Click -= eventHandler;
        this._ToolStripDropDownButton1 = value;
        if (this._ToolStripDropDownButton1 == null)
          return;
        this._ToolStripDropDownButton1.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem SaveToolStripMenuItem
    {
      get
      {
        return this._SaveToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveToolStripMenuItem_Click);
        if (this._SaveToolStripMenuItem != null)
          this._SaveToolStripMenuItem.Click -= eventHandler;
        this._SaveToolStripMenuItem = value;
        if (this._SaveToolStripMenuItem == null)
          return;
        this._SaveToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem OpenToolStripMenuItem
    {
      get
      {
        return this._OpenToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OpenToolStripMenuItem_Click);
        if (this._OpenToolStripMenuItem != null)
          this._OpenToolStripMenuItem.Click -= eventHandler;
        this._OpenToolStripMenuItem = value;
        if (this._OpenToolStripMenuItem == null)
          return;
        this._OpenToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripDropDownButton ToolStripDropDownButton2
    {
      get
      {
        return this._ToolStripDropDownButton2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ToolStripDropDownButton2 = value;
      }
    }

    internal virtual ToolStripMenuItem UndoToolStripMenuItem
    {
      get
      {
        return this._UndoToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.UndoToolStripMenuItem_Click);
        if (this._UndoToolStripMenuItem != null)
          this._UndoToolStripMenuItem.Click -= eventHandler;
        this._UndoToolStripMenuItem = value;
        if (this._UndoToolStripMenuItem == null)
          return;
        this._UndoToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem RedoToolStripMenuItem
    {
      get
      {
        return this._RedoToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RedoToolStripMenuItem_Click);
        if (this._RedoToolStripMenuItem != null)
          this._RedoToolStripMenuItem.Click -= eventHandler;
        this._RedoToolStripMenuItem = value;
        if (this._RedoToolStripMenuItem == null)
          return;
        this._RedoToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem CutToolStripMenuItem
    {
      get
      {
        return this._CutToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CutToolStripMenuItem_Click);
        if (this._CutToolStripMenuItem != null)
          this._CutToolStripMenuItem.Click -= eventHandler;
        this._CutToolStripMenuItem = value;
        if (this._CutToolStripMenuItem == null)
          return;
        this._CutToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem CopyToolStripMenuItem
    {
      get
      {
        return this._CopyToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CopyToolStripMenuItem_Click);
        if (this._CopyToolStripMenuItem != null)
          this._CopyToolStripMenuItem.Click -= eventHandler;
        this._CopyToolStripMenuItem = value;
        if (this._CopyToolStripMenuItem == null)
          return;
        this._CopyToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem PasteToolStripMenuItem
    {
      get
      {
        return this._PasteToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PasteToolStripMenuItem_Click);
        if (this._PasteToolStripMenuItem != null)
          this._PasteToolStripMenuItem.Click -= eventHandler;
        this._PasteToolStripMenuItem = value;
        if (this._PasteToolStripMenuItem == null)
          return;
        this._PasteToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ClearToolStripMenuItem
    {
      get
      {
        return this._ClearToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ClearToolStripMenuItem_Click);
        if (this._ClearToolStripMenuItem != null)
          this._ClearToolStripMenuItem.Click -= eventHandler;
        this._ClearToolStripMenuItem = value;
        if (this._ClearToolStripMenuItem == null)
          return;
        this._ClearToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem SelectAllToolStripMenuItem
    {
      get
      {
        return this._SelectAllToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SelectAllToolStripMenuItem_Click);
        if (this._SelectAllToolStripMenuItem != null)
          this._SelectAllToolStripMenuItem.Click -= eventHandler;
        this._SelectAllToolStripMenuItem = value;
        if (this._SelectAllToolStripMenuItem == null)
          return;
        this._SelectAllToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual RichTextBox RichTextBox1
    {
      get
      {
        return this._RichTextBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RichTextBox1 = value;
      }
    }

    internal virtual ToolStripDropDownButton ToolStripDropDownButton3
    {
      get
      {
        return this._ToolStripDropDownButton3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ToolStripDropDownButton3 = value;
      }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem1
    {
      get
      {
        return this._ToolStripMenuItem1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem1_Click);
        if (this._ToolStripMenuItem1 != null)
          this._ToolStripMenuItem1.Click -= eventHandler;
        this._ToolStripMenuItem1 = value;
        if (this._ToolStripMenuItem1 == null)
          return;
        this._ToolStripMenuItem1.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem2
    {
      get
      {
        return this._ToolStripMenuItem2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem2_Click);
        if (this._ToolStripMenuItem2 != null)
          this._ToolStripMenuItem2.Click -= eventHandler;
        this._ToolStripMenuItem2 = value;
        if (this._ToolStripMenuItem2 == null)
          return;
        this._ToolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripDropDownButton ToolStripDropDownButton4
    {
      get
      {
        return this._ToolStripDropDownButton4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripDropDownButton4_Click);
        if (this._ToolStripDropDownButton4 != null)
          this._ToolStripDropDownButton4.Click -= eventHandler;
        this._ToolStripDropDownButton4 = value;
        if (this._ToolStripDropDownButton4 == null)
          return;
        this._ToolStripDropDownButton4.Click += eventHandler;
      }
    }

    internal virtual ToolStripDropDownButton ToolStripDropDownButton5
    {
      get
      {
        return this._ToolStripDropDownButton5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripDropDownButton5_Click);
        if (this._ToolStripDropDownButton5 != null)
          this._ToolStripDropDownButton5.Click -= eventHandler;
        this._ToolStripDropDownButton5 = value;
        if (this._ToolStripDropDownButton5 == null)
          return;
        this._ToolStripDropDownButton5.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem CheckForUpdateToolStripMenuItem
    {
      get
      {
        return this._CheckForUpdateToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckForUpdateToolStripMenuItem_Click);
        if (this._CheckForUpdateToolStripMenuItem != null)
          this._CheckForUpdateToolStripMenuItem.Click -= eventHandler;
        this._CheckForUpdateToolStripMenuItem = value;
        if (this._CheckForUpdateToolStripMenuItem == null)
          return;
        this._CheckForUpdateToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem WordWrapToolStripMenuItem
    {
      get
      {
        return this._WordWrapToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.WordWrapToolStripMenuItem_Click);
        if (this._WordWrapToolStripMenuItem != null)
          this._WordWrapToolStripMenuItem.Click -= eventHandler;
        this._WordWrapToolStripMenuItem = value;
        if (this._WordWrapToolStripMenuItem == null)
          return;
        this._WordWrapToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem WordWrapOffToolStripMenuItem
    {
      get
      {
        return this._WordWrapOffToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.WordWrapOffToolStripMenuItem_Click);
        if (this._WordWrapOffToolStripMenuItem != null)
          this._WordWrapOffToolStripMenuItem.Click -= eventHandler;
        this._WordWrapOffToolStripMenuItem = value;
        if (this._WordWrapOffToolStripMenuItem == null)
          return;
        this._WordWrapOffToolStripMenuItem.Click += eventHandler;
      }
    }

    public Form1()
    {
      this.Closing += new CancelEventHandler(this.UrForms_Closing);
      this.Load += new EventHandler(this.Form1_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.ToolStrip1 = new ToolStrip();
      this.ToolStripDropDownButton1 = new ToolStripDropDownButton();
      this.SaveToolStripMenuItem = new ToolStripMenuItem();
      this.OpenToolStripMenuItem = new ToolStripMenuItem();
      this.CheckForUpdateToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripDropDownButton2 = new ToolStripDropDownButton();
      this.UndoToolStripMenuItem = new ToolStripMenuItem();
      this.RedoToolStripMenuItem = new ToolStripMenuItem();
      this.CutToolStripMenuItem = new ToolStripMenuItem();
      this.CopyToolStripMenuItem = new ToolStripMenuItem();
      this.PasteToolStripMenuItem = new ToolStripMenuItem();
      this.ClearToolStripMenuItem = new ToolStripMenuItem();
      this.SelectAllToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripDropDownButton3 = new ToolStripDropDownButton();
      this.ToolStripMenuItem1 = new ToolStripMenuItem();
      this.ToolStripMenuItem2 = new ToolStripMenuItem();
      this.WordWrapToolStripMenuItem = new ToolStripMenuItem();
      this.WordWrapOffToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripDropDownButton4 = new ToolStripDropDownButton();
      this.ToolStripDropDownButton5 = new ToolStripDropDownButton();
      this.RichTextBox1 = new RichTextBox();
      this.ToolStrip1.SuspendLayout();
      this.SuspendLayout();
      this.ToolStrip1.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.ToolStripDropDownButton1,
        (ToolStripItem) this.ToolStripDropDownButton2,
        (ToolStripItem) this.ToolStripDropDownButton3,
        (ToolStripItem) this.ToolStripDropDownButton4,
        (ToolStripItem) this.ToolStripDropDownButton5
      });
      ToolStrip toolStrip1_1 = this.ToolStrip1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      toolStrip1_1.Location = point2;
      this.ToolStrip1.Name = "ToolStrip1";
      ToolStrip toolStrip1_2 = this.ToolStrip1;
      Size size1 = new Size(284, 25);
      Size size2 = size1;
      toolStrip1_2.Size = size2;
      this.ToolStrip1.TabIndex = 0;
      this.ToolStrip1.Text = "ToolStrip1";
      this.ToolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.SaveToolStripMenuItem,
        (ToolStripItem) this.OpenToolStripMenuItem,
        (ToolStripItem) this.CheckForUpdateToolStripMenuItem
      });
      this.ToolStripDropDownButton1.Image = (Image) componentResourceManager.GetObject("ToolStripDropDownButton1.Image");
      this.ToolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
      this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
      ToolStripDropDownButton stripDropDownButton1 = this.ToolStripDropDownButton1;
      size1 = new Size(38, 22);
      Size size3 = size1;
      stripDropDownButton1.Size = size3;
      this.ToolStripDropDownButton1.Text = "File";
      this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem1 = this.SaveToolStripMenuItem;
      size1 = new Size(168, 22);
      Size size4 = size1;
      toolStripMenuItem1.Size = size4;
      this.SaveToolStripMenuItem.Text = "Save";
      this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem2 = this.OpenToolStripMenuItem;
      size1 = new Size(168, 22);
      Size size5 = size1;
      toolStripMenuItem2.Size = size5;
      this.OpenToolStripMenuItem.Text = "Open";
      this.CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem3 = this.CheckForUpdateToolStripMenuItem;
      size1 = new Size(168, 22);
      Size size6 = size1;
      toolStripMenuItem3.Size = size6;
      this.CheckForUpdateToolStripMenuItem.Text = "Check For Update";
      this.ToolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.UndoToolStripMenuItem,
        (ToolStripItem) this.RedoToolStripMenuItem,
        (ToolStripItem) this.CutToolStripMenuItem,
        (ToolStripItem) this.CopyToolStripMenuItem,
        (ToolStripItem) this.PasteToolStripMenuItem,
        (ToolStripItem) this.ClearToolStripMenuItem,
        (ToolStripItem) this.SelectAllToolStripMenuItem
      });
      this.ToolStripDropDownButton2.Image = (Image) componentResourceManager.GetObject("ToolStripDropDownButton2.Image");
      this.ToolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
      this.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2";
      ToolStripDropDownButton stripDropDownButton2 = this.ToolStripDropDownButton2;
      size1 = new Size(40, 22);
      Size size7 = size1;
      stripDropDownButton2.Size = size7;
      this.ToolStripDropDownButton2.Text = "Edit";
      this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem4 = this.UndoToolStripMenuItem;
      size1 = new Size(122, 22);
      Size size8 = size1;
      toolStripMenuItem4.Size = size8;
      this.UndoToolStripMenuItem.Text = "Undo";
      this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem5 = this.RedoToolStripMenuItem;
      size1 = new Size(122, 22);
      Size size9 = size1;
      toolStripMenuItem5.Size = size9;
      this.RedoToolStripMenuItem.Text = "Redo";
      this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem6 = this.CutToolStripMenuItem;
      size1 = new Size(122, 22);
      Size size10 = size1;
      toolStripMenuItem6.Size = size10;
      this.CutToolStripMenuItem.Text = "Cut";
      this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem7 = this.CopyToolStripMenuItem;
      size1 = new Size(122, 22);
      Size size11 = size1;
      toolStripMenuItem7.Size = size11;
      this.CopyToolStripMenuItem.Text = "Copy";
      this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem8 = this.PasteToolStripMenuItem;
      size1 = new Size(122, 22);
      Size size12 = size1;
      toolStripMenuItem8.Size = size12;
      this.PasteToolStripMenuItem.Text = "Paste";
      this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem9 = this.ClearToolStripMenuItem;
      size1 = new Size(122, 22);
      Size size13 = size1;
      toolStripMenuItem9.Size = size13;
      this.ClearToolStripMenuItem.Text = "Clear";
      this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem10 = this.SelectAllToolStripMenuItem;
      size1 = new Size(122, 22);
      Size size14 = size1;
      toolStripMenuItem10.Size = size14;
      this.SelectAllToolStripMenuItem.Text = "Select All";
      this.ToolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.ToolStripMenuItem1,
        (ToolStripItem) this.ToolStripMenuItem2,
        (ToolStripItem) this.WordWrapToolStripMenuItem,
        (ToolStripItem) this.WordWrapOffToolStripMenuItem
      });
      this.ToolStripDropDownButton3.Image = (Image) componentResourceManager.GetObject("ToolStripDropDownButton3.Image");
      this.ToolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
      this.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3";
      ToolStripDropDownButton stripDropDownButton3 = this.ToolStripDropDownButton3;
      size1 = new Size(58, 22);
      Size size15 = size1;
      stripDropDownButton3.Size = size15;
      this.ToolStripDropDownButton3.Text = "Format";
      this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
      ToolStripMenuItem toolStripMenuItem1_1 = this.ToolStripMenuItem1;
      size1 = new Size(154, 22);
      Size size16 = size1;
      toolStripMenuItem1_1.Size = size16;
      this.ToolStripMenuItem1.Text = "Font";
      this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
      ToolStripMenuItem toolStripMenuItem2_1 = this.ToolStripMenuItem2;
      size1 = new Size(154, 22);
      Size size17 = size1;
      toolStripMenuItem2_1.Size = size17;
      this.ToolStripMenuItem2.Text = "Color";
      this.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem11 = this.WordWrapToolStripMenuItem;
      size1 = new Size(154, 22);
      Size size18 = size1;
      toolStripMenuItem11.Size = size18;
      this.WordWrapToolStripMenuItem.Text = "Word Wrap On";
      this.WordWrapOffToolStripMenuItem.Name = "WordWrapOffToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem12 = this.WordWrapOffToolStripMenuItem;
      size1 = new Size(154, 22);
      Size size19 = size1;
      toolStripMenuItem12.Size = size19;
      this.WordWrapOffToolStripMenuItem.Text = "Word Wrap Off";
      this.ToolStripDropDownButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripDropDownButton4.Image = (Image) componentResourceManager.GetObject("ToolStripDropDownButton4.Image");
      this.ToolStripDropDownButton4.ImageTransparentColor = Color.Magenta;
      this.ToolStripDropDownButton4.Name = "ToolStripDropDownButton4";
      ToolStripDropDownButton stripDropDownButton4 = this.ToolStripDropDownButton4;
      size1 = new Size(38, 22);
      Size size20 = size1;
      stripDropDownButton4.Size = size20;
      this.ToolStripDropDownButton4.Text = "Exit";
      this.ToolStripDropDownButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripDropDownButton5.Image = (Image) componentResourceManager.GetObject("ToolStripDropDownButton5.Image");
      this.ToolStripDropDownButton5.ImageTransparentColor = Color.Magenta;
      this.ToolStripDropDownButton5.Name = "ToolStripDropDownButton5";
      ToolStripDropDownButton stripDropDownButton5 = this.ToolStripDropDownButton5;
      size1 = new Size(53, 22);
      Size size21 = size1;
      stripDropDownButton5.Size = size21;
      this.ToolStripDropDownButton5.Text = "About";
      this.RichTextBox1.Dock = DockStyle.Fill;
      RichTextBox richTextBox1_1 = this.RichTextBox1;
      point1 = new Point(0, 25);
      Point point3 = point1;
      richTextBox1_1.Location = point3;
      this.RichTextBox1.Name = "RichTextBox1";
      RichTextBox richTextBox1_2 = this.RichTextBox1;
      size1 = new Size(284, 237);
      Size size22 = size1;
      richTextBox1_2.Size = size22;
      this.RichTextBox1.TabIndex = 1;
      this.RichTextBox1.Text = "";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(284, 262);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.RichTextBox1);
      this.Controls.Add((Control) this.ToolStrip1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = "Form1";
      this.Text = "Green Dragon Writer";
      this.ToolStrip1.ResumeLayout(false);
      this.ToolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "Save";
        saveFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf";
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        this.RichTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Open";
        openFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf";
        if (openFileDialog.ShowDialog() != DialogResult.OK)
          return;
        this.RichTextBox1.LoadFile(openFileDialog.FileName);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.RichTextBox1.Undo();
    }

    private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.RichTextBox1.Redo();
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.RichTextBox1.Cut();
    }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.RichTextBox1.Copy();
    }

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ((TextBoxBase) this.RichTextBox1).Paste();
    }

    private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.RichTextBox1.Clear();
    }

    private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.RichTextBox1.SelectAll();
    }

    private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        ColorDialog colorDialog = new ColorDialog();
        colorDialog.Color = this.RichTextBox1.ForeColor;
        if (colorDialog.ShowDialog() != DialogResult.OK)
          return;
        this.RichTextBox1.ForeColor = colorDialog.Color;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void FontToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        FontDialog fontDialog = new FontDialog();
        fontDialog.Font = this.RichTextBox1.Font;
        if (fontDialog.ShowDialog() != DialogResult.OK)
          return;
        this.RichTextBox1.Font = fontDialog.Font;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      try
      {
        ColorDialog colorDialog = new ColorDialog();
        colorDialog.Color = this.RichTextBox1.ForeColor;
        if (colorDialog.ShowDialog() != DialogResult.OK)
          return;
        this.RichTextBox1.ForeColor = colorDialog.Color;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      try
      {
        FontDialog fontDialog = new FontDialog();
        fontDialog.Font = this.RichTextBox1.Font;
        if (fontDialog.ShowDialog() != DialogResult.OK)
          return;
        this.RichTextBox1.Font = fontDialog.Font;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void UrForms_Closing(object sender, CancelEventArgs e)
    {
      if (MessageBox.Show("Are you sure you want to exit?", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        e.Cancel = false;
      else
        e.Cancel = true;
    }

    private void ToolStripDropDownButton4_Click(object sender, EventArgs e)
    {
      this.Close();
      Application.Exit();
    }

    private void ToolStripDropDownButton5_Click(object sender, EventArgs e)
    {
      ((Control) MyProject.Forms.AboutBox1).Show();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.RichTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
    }

    private void ToolStripDropDownButton1_Click(object sender, EventArgs e)
    {
    }

    private void CheckForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CheckForUpdates();
    }

    public void CheckForUpdates()
    {
      if (new StreamReader(((HttpWebResponse) ((HttpWebRequest) WebRequest.Create("https://dl.dropboxusercontent.com/s/04b9803d65n8f5l/version.txt?token_hash=AAEwzusPrLF5G5nc22mZxxKdCBZwXXHKfOQhokprAmXmDw&dl=1")).GetResponse()).GetResponseStream()).ReadToEnd().Contains(Application.ProductVersion))
      {
        int num1 = (int) Interaction.MsgBox((object) "You are up to date!", MsgBoxStyle.OkOnly, (object) null);
      }
      else
      {
        int num2 = (int) Interaction.MsgBox((object) "There is a new update it will now download.", MsgBoxStyle.OkOnly, (object) null);
        Process.Start("https://dl.dropboxusercontent.com/s/oefflu9yx7cjdcu/Green%20Dragon%20Writer.exe?token_hash=AAHrF77pim50gNFGNrV3pjme054N6AQRUQYgIzgZkTHGdw&dl=1");
      }
    }

    private void WordWrapToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.RichTextBox1.WordWrap = true;
    }

    private void WordWrapOffToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.RichTextBox1.WordWrap = false;
    }
  }
}
