// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.fScreenshot
// Assembly: Green Dragon Browser, Version=1.0.3.0, Culture=neutral, PublicKeyToken=0706e68831d27660
// MVID: 73704739-5485-4C15-86EF-C4F58132E058
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser.exe

using Green_Dragon_Browser.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  [DesignerGenerated]
  public class fScreenshot : Form
  {
    private IContainer components;
    [AccessedThroughProperty("picScreenshot")]
    private PictureBox _picScreenshot;
    [AccessedThroughProperty("bSave")]
    private Button _bSave;
    [AccessedThroughProperty("bScreenshot")]
    private Button _bScreenshot;
    [AccessedThroughProperty("bShare")]
    private Button _bShare;
    [AccessedThroughProperty("save")]
    private SaveFileDialog _save;
    [AccessedThroughProperty("cmPicture")]
    private ContextMenuStrip _cmPicture;
    [AccessedThroughProperty("iToggleFullscreen")]
    private ToolStripMenuItem _iToggleFullscreen;

    internal virtual PictureBox picScreenshot
    {
      get
      {
        return this._picScreenshot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picScreenshot = value;
      }
    }

    internal virtual Button bSave
    {
      get
      {
        return this._bSave;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bSave_Click);
        if (this._bSave != null)
          this._bSave.Click -= eventHandler;
        this._bSave = value;
        if (this._bSave == null)
          return;
        this._bSave.Click += eventHandler;
      }
    }

    internal virtual Button bScreenshot
    {
      get
      {
        return this._bScreenshot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bScreenshot_Click);
        if (this._bScreenshot != null)
          this._bScreenshot.Click -= eventHandler;
        this._bScreenshot = value;
        if (this._bScreenshot == null)
          return;
        this._bScreenshot.Click += eventHandler;
      }
    }

    internal virtual Button bShare
    {
      get
      {
        return this._bShare;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bShare_Click);
        if (this._bShare != null)
          this._bShare.Click -= eventHandler;
        this._bShare = value;
        if (this._bShare == null)
          return;
        this._bShare.Click += eventHandler;
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

    internal virtual ContextMenuStrip cmPicture
    {
      get
      {
        return this._cmPicture;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cmPicture = value;
      }
    }

    internal virtual ToolStripMenuItem iToggleFullscreen
    {
      get
      {
        return this._iToggleFullscreen;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iToggleFullscreen_Click);
        if (this._iToggleFullscreen != null)
          this._iToggleFullscreen.Click -= eventHandler;
        this._iToggleFullscreen = value;
        if (this._iToggleFullscreen == null)
          return;
        this._iToggleFullscreen.Click += eventHandler;
      }
    }

    public fScreenshot()
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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fScreenshot));
      this.cmPicture = new ContextMenuStrip(this.components);
      this.iToggleFullscreen = new ToolStripMenuItem();
      this.save = new SaveFileDialog();
      this.bShare = new Button();
      this.bScreenshot = new Button();
      this.bSave = new Button();
      this.picScreenshot = new PictureBox();
      this.cmPicture.SuspendLayout();
      ((ISupportInitialize) this.picScreenshot).BeginInit();
      this.SuspendLayout();
      this.cmPicture.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.iToggleFullscreen
      });
      this.cmPicture.Name = "cmPicture";
      ContextMenuStrip cmPicture = this.cmPicture;
      Size size1 = new Size(166, 26);
      Size size2 = size1;
      cmPicture.Size = size2;
      this.iToggleFullscreen.Image = (Image) Resources.expand_dark;
      this.iToggleFullscreen.Name = "iToggleFullscreen";
      ToolStripMenuItem toggleFullscreen = this.iToggleFullscreen;
      size1 = new Size(165, 22);
      Size size3 = size1;
      toggleFullscreen.Size = size3;
      this.iToggleFullscreen.Text = "Toggle fullscreen";
      this.bShare.Anchor = AnchorStyles.Bottom;
      this.bShare.BackgroundImage = (Image) Resources.share_light;
      this.bShare.BackgroundImageLayout = ImageLayout.Stretch;
      this.bShare.FlatStyle = FlatStyle.Flat;
      this.bShare.ForeColor = Color.FromArgb(64, 64, 64);
      Button bShare1 = this.bShare;
      Point point1 = new Point(502, 317);
      Point point2 = point1;
      bShare1.Location = point2;
      this.bShare.Name = "bShare";
      Button bShare2 = this.bShare;
      size1 = new Size(32, 32);
      Size size4 = size1;
      bShare2.Size = size4;
      this.bShare.TabIndex = 7;
      this.bShare.UseVisualStyleBackColor = true;
      this.bScreenshot.Anchor = AnchorStyles.Bottom;
      this.bScreenshot.BackgroundImage = (Image) Resources.camera_light;
      this.bScreenshot.BackgroundImageLayout = ImageLayout.Stretch;
      this.bScreenshot.FlatStyle = FlatStyle.Flat;
      this.bScreenshot.ForeColor = Color.FromArgb(64, 64, 64);
      Button bScreenshot1 = this.bScreenshot;
      point1 = new Point(464, 317);
      Point point3 = point1;
      bScreenshot1.Location = point3;
      this.bScreenshot.Name = "bScreenshot";
      Button bScreenshot2 = this.bScreenshot;
      size1 = new Size(32, 32);
      Size size5 = size1;
      bScreenshot2.Size = size5;
      this.bScreenshot.TabIndex = 5;
      this.bScreenshot.UseVisualStyleBackColor = true;
      this.bSave.Anchor = AnchorStyles.Bottom;
      this.bSave.BackgroundImage = (Image) Resources.save_light;
      this.bSave.BackgroundImageLayout = ImageLayout.Stretch;
      this.bSave.FlatStyle = FlatStyle.Flat;
      this.bSave.ForeColor = Color.FromArgb(64, 64, 64);
      Button bSave1 = this.bSave;
      point1 = new Point(540, 317);
      Point point4 = point1;
      bSave1.Location = point4;
      this.bSave.Name = "bSave";
      Button bSave2 = this.bSave;
      size1 = new Size(32, 32);
      Size size6 = size1;
      bSave2.Size = size6;
      this.bSave.TabIndex = 4;
      this.bSave.UseVisualStyleBackColor = true;
      this.picScreenshot.BackColor = Color.DimGray;
      this.picScreenshot.ContextMenuStrip = this.cmPicture;
      this.picScreenshot.Dock = DockStyle.Top;
      PictureBox picScreenshot1 = this.picScreenshot;
      point1 = new Point(0, 0);
      Point point5 = point1;
      picScreenshot1.Location = point5;
      this.picScreenshot.Name = "picScreenshot";
      PictureBox picScreenshot2 = this.picScreenshot;
      size1 = new Size(584, 311);
      Size size7 = size1;
      picScreenshot2.Size = size7;
      this.picScreenshot.TabIndex = 0;
      this.picScreenshot.TabStop = false;
      this.AutoScaleDimensions = new SizeF(8f, 21f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(64, 64, 64);
      size1 = new Size(584, 362);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.bShare);
      this.Controls.Add((Control) this.bScreenshot);
      this.Controls.Add((Control) this.bSave);
      this.Controls.Add((Control) this.picScreenshot);
      this.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      size1 = new Size(600, 400);
      this.MinimumSize = size1;
      this.Name = "fScreenshot";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Screenshot";
      this.TopMost = true;
      this.cmPicture.ResumeLayout(false);
      ((ISupportInitialize) this.picScreenshot).EndInit();
      this.ResumeLayout(false);
    }

    private void bScreenshot_Click(object sender, EventArgs e)
    {
      this.Opacity = 0.0;
      Rectangle bounds = Screen.PrimaryScreen.Bounds;
      Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
      Graphics.FromImage((Image) bitmap).CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
      this.Opacity = 100.0;
      this.picScreenshot.Image = (Image) bitmap;
      this.picScreenshot.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void bShare_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Coming Soon...", "Notice");
    }

    private void bSave_Click(object sender, EventArgs e)
    {
      this.save.Title = "Save File";
      this.save.FileName = "screenshot";
      this.save.Filter = "Bitmap |*.bmp";
      if (this.save.ShowDialog() != DialogResult.OK)
        return;
      this.picScreenshot.Image.Save(this.save.FileName, ImageFormat.Bmp);
    }

    private void iToggleFullscreen_Click(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Normal)
      {
        this.picScreenshot.Dock = DockStyle.Fill;
        this.FormBorderStyle = FormBorderStyle.None;
        this.WindowState = FormWindowState.Maximized;
        this.picScreenshot.BringToFront();
      }
      else
      {
        this.picScreenshot.Dock = DockStyle.Top;
        this.FormBorderStyle = FormBorderStyle.Sizable;
        this.WindowState = FormWindowState.Normal;
        this.picScreenshot.SendToBack();
      }
    }
  }
}
