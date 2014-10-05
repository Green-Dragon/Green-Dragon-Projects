// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.fLogin
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
  public class fLogin : Form
  {
    private IContainer components;
    [AccessedThroughProperty("txtTitle")]
    private Label _txtTitle;
    [AccessedThroughProperty("bUnlock")]
    private Button _bUnlock;
    [AccessedThroughProperty("bClose")]
    private Button _bClose;
    [AccessedThroughProperty("tbPassword")]
    private TextBox _tbPassword;
    [AccessedThroughProperty("bUser")]
    private Button _bUser;
    [AccessedThroughProperty("bIncognito")]
    private Button _bIncognito;
    [AccessedThroughProperty("txtPassword")]
    private Label _txtPassword;
    [AccessedThroughProperty("bMinimize")]
    private Button _bMinimize;

    internal virtual Label txtTitle
    {
      get
      {
        return this._txtTitle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtTitle = value;
      }
    }

    internal virtual Button bUnlock
    {
      get
      {
        return this._bUnlock;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bUnlock_Click);
        if (this._bUnlock != null)
          this._bUnlock.Click -= eventHandler;
        this._bUnlock = value;
        if (this._bUnlock == null)
          return;
        this._bUnlock.Click += eventHandler;
      }
    }

    internal virtual Button bClose
    {
      get
      {
        return this._bClose;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bClose_Click);
        if (this._bClose != null)
          this._bClose.Click -= eventHandler;
        this._bClose = value;
        if (this._bClose == null)
          return;
        this._bClose.Click += eventHandler;
      }
    }

    internal virtual TextBox tbPassword
    {
      get
      {
        return this._tbPassword;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.tbPassword_KeyDown);
        if (this._tbPassword != null)
          this._tbPassword.KeyDown -= keyEventHandler;
        this._tbPassword = value;
        if (this._tbPassword == null)
          return;
        this._tbPassword.KeyDown += keyEventHandler;
      }
    }

    internal virtual Button bUser
    {
      get
      {
        return this._bUser;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bUser_Click);
        if (this._bUser != null)
          this._bUser.Click -= eventHandler;
        this._bUser = value;
        if (this._bUser == null)
          return;
        this._bUser.Click += eventHandler;
      }
    }

    internal virtual Button bIncognito
    {
      get
      {
        return this._bIncognito;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bIncognito_Click);
        if (this._bIncognito != null)
          this._bIncognito.Click -= eventHandler;
        this._bIncognito = value;
        if (this._bIncognito == null)
          return;
        this._bIncognito.Click += eventHandler;
      }
    }

    internal virtual Label txtPassword
    {
      get
      {
        return this._txtPassword;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtPassword = value;
      }
    }

    internal virtual Button bMinimize
    {
      get
      {
        return this._bMinimize;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bMinimize_Click);
        if (this._bMinimize != null)
          this._bMinimize.Click -= eventHandler;
        this._bMinimize = value;
        if (this._bMinimize == null)
          return;
        this._bMinimize.Click += eventHandler;
      }
    }

    public fLogin()
    {
      this.Load += new EventHandler(this.fLogin_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fLogin));
      this.txtTitle = new Label();
      this.bUnlock = new Button();
      this.bClose = new Button();
      this.tbPassword = new TextBox();
      this.bUser = new Button();
      this.bIncognito = new Button();
      this.txtPassword = new Label();
      this.bMinimize = new Button();
      this.SuspendLayout();
      this.txtTitle.AutoSize = true;
      this.txtTitle.Font = new Font("Segoe UI Light", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label txtTitle1 = this.txtTitle;
      Point point1 = new Point(12, 9);
      Point point2 = point1;
      txtTitle1.Location = point2;
      this.txtTitle.Name = "txtTitle";
      Label txtTitle2 = this.txtTitle;
      Size size1 = new Size(172, 32);
      Size size2 = size1;
      txtTitle2.Size = size2;
      this.txtTitle.TabIndex = 0;
      this.txtTitle.Text = "Browser Locked";
      this.bUnlock.BackgroundImage = (Image) Resources.unlock_light;
      this.bUnlock.BackgroundImageLayout = ImageLayout.Stretch;
      this.bUnlock.FlatStyle = FlatStyle.Flat;
      this.bUnlock.ForeColor = Color.FromArgb(64, 64, 64);
      Button bUnlock1 = this.bUnlock;
      point1 = new Point(280, 206);
      Point point3 = point1;
      bUnlock1.Location = point3;
      this.bUnlock.Name = "bUnlock";
      Button bUnlock2 = this.bUnlock;
      size1 = new Size(32, 32);
      Size size3 = size1;
      bUnlock2.Size = size3;
      this.bUnlock.TabIndex = 4;
      this.bUnlock.UseVisualStyleBackColor = true;
      this.bClose.Anchor = AnchorStyles.Top;
      this.bClose.BackgroundImage = (Image) Resources.cancel_light;
      this.bClose.BackgroundImageLayout = ImageLayout.Stretch;
      this.bClose.FlatStyle = FlatStyle.Flat;
      this.bClose.ForeColor = Color.FromArgb(64, 64, 64);
      Button bClose1 = this.bClose;
      point1 = new Point(280, 12);
      Point point4 = point1;
      bClose1.Location = point4;
      this.bClose.Name = "bClose";
      Button bClose2 = this.bClose;
      size1 = new Size(32, 32);
      Size size4 = size1;
      bClose2.Size = size4;
      this.bClose.TabIndex = 6;
      this.bClose.UseVisualStyleBackColor = true;
      this.tbPassword.AutoCompleteSource = AutoCompleteSource.CustomSource;
      this.tbPassword.BackColor = Color.DimGray;
      this.tbPassword.BorderStyle = BorderStyle.None;
      this.tbPassword.ForeColor = Color.White;
      TextBox tbPassword1 = this.tbPassword;
      point1 = new Point(12, 212);
      Point point5 = point1;
      tbPassword1.Location = point5;
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      TextBox tbPassword2 = this.tbPassword;
      size1 = new Size(260, 22);
      Size size5 = size1;
      tbPassword2.Size = size5;
      this.tbPassword.TabIndex = 7;
      this.bUser.Anchor = AnchorStyles.Top;
      this.bUser.BackgroundImageLayout = ImageLayout.Center;
      this.bUser.FlatStyle = FlatStyle.Flat;
      this.bUser.ForeColor = Color.White;
      this.bUser.Image = (Image) Resources.user_light;
      this.bUser.ImageAlign = ContentAlignment.TopCenter;
      Button bUser1 = this.bUser;
      point1 = new Point(12, 65);
      Point point6 = point1;
      bUser1.Location = point6;
      this.bUser.Name = "bUser";
      Button bUser2 = this.bUser;
      size1 = new Size(96, 96);
      Size size6 = size1;
      bUser2.Size = size6;
      this.bUser.TabIndex = 8;
      this.bUser.Text = "User";
      this.bUser.TextAlign = ContentAlignment.BottomCenter;
      this.bUser.UseVisualStyleBackColor = true;
      this.bIncognito.Anchor = AnchorStyles.Top;
      this.bIncognito.BackgroundImageLayout = ImageLayout.Center;
      this.bIncognito.FlatStyle = FlatStyle.Flat;
      this.bIncognito.ForeColor = Color.White;
      this.bIncognito.Image = (Image) componentResourceManager.GetObject("bIncognito.Image");
      this.bIncognito.ImageAlign = ContentAlignment.TopCenter;
      Button bIncognito1 = this.bIncognito;
      point1 = new Point(114, 65);
      Point point7 = point1;
      bIncognito1.Location = point7;
      this.bIncognito.Name = "bIncognito";
      Button bIncognito2 = this.bIncognito;
      size1 = new Size(96, 96);
      Size size7 = size1;
      bIncognito2.Size = size7;
      this.bIncognito.TabIndex = 10;
      this.bIncognito.Text = "Incognito";
      this.bIncognito.TextAlign = ContentAlignment.BottomCenter;
      this.bIncognito.UseVisualStyleBackColor = true;
      this.txtPassword.AutoSize = true;
      this.txtPassword.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPassword.ForeColor = Color.LightSkyBlue;
      Label txtPassword1 = this.txtPassword;
      point1 = new Point(8, 188);
      Point point8 = point1;
      txtPassword1.Location = point8;
      this.txtPassword.Name = "txtPassword";
      Label txtPassword2 = this.txtPassword;
      size1 = new Size(73, 21);
      Size size8 = size1;
      txtPassword2.Size = size8;
      this.txtPassword.TabIndex = 11;
      this.txtPassword.Text = "Password";
      this.bMinimize.Anchor = AnchorStyles.Top;
      this.bMinimize.BackgroundImage = (Image) Resources.minimize_light;
      this.bMinimize.BackgroundImageLayout = ImageLayout.Stretch;
      this.bMinimize.FlatStyle = FlatStyle.Flat;
      this.bMinimize.ForeColor = Color.FromArgb(64, 64, 64);
      Button bMinimize1 = this.bMinimize;
      point1 = new Point(242, 12);
      Point point9 = point1;
      bMinimize1.Location = point9;
      this.bMinimize.Name = "bMinimize";
      Button bMinimize2 = this.bMinimize;
      size1 = new Size(32, 32);
      Size size9 = size1;
      bMinimize2.Size = size9;
      this.bMinimize.TabIndex = 12;
      this.bMinimize.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(8f, 21f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(64, 64, 64);
      size1 = new Size(324, 175);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.bMinimize);
      this.Controls.Add((Control) this.txtPassword);
      this.Controls.Add((Control) this.bIncognito);
      this.Controls.Add((Control) this.bUser);
      this.Controls.Add((Control) this.tbPassword);
      this.Controls.Add((Control) this.bClose);
      this.Controls.Add((Control) this.bUnlock);
      this.Controls.Add((Control) this.txtTitle);
      this.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      size1 = new Size(324, 250);
      this.MaximumSize = size1;
      size1 = new Size(324, 175);
      this.MinimumSize = size1;
      this.Name = "fLogin";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void fLogin_Load(object sender, EventArgs e)
    {
      MyProject.Forms.fMain.WindowState = FormWindowState.Minimized;
      MyProject.Forms.fMain.ShowInTaskbar = false;
    }

    private void bUser_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(MySettingsProperty.Settings.varPassword, "", false) == 0)
      {
        this.Close();
        MyProject.Forms.fMain.ShowInTaskbar = true;
        MyProject.Forms.fMain.WindowState = FormWindowState.Maximized;
      }
      else
        this.Height = 250;
    }

    private void bIncognito_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Incognito means that browsing history is not saved, You can enable incognito mode by loging into User and going to View > History and right click > Edit History > Auto Clear.", "Notice");
    }

    private void bUnlock_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.tbPassword.Text, MySettingsProperty.Settings.varPassword, false) != 0)
        return;
      this.Close();
      MyProject.Forms.fMain.ShowInTaskbar = true;
      MyProject.Forms.fMain.WindowState = FormWindowState.Maximized;
    }

    private void bMinimize_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void bClose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void tbPassword_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.bUnlock.PerformClick();
    }

    public static object bGuest()
    {
      throw new NotImplementedException();
    }
  }
}
