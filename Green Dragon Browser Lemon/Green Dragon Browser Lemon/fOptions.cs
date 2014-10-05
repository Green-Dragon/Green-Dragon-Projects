// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.fOptions
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
  public class fOptions : Form
  {
    private IContainer components;
    [AccessedThroughProperty("txtHomepage")]
    private Label _txtHomepage;
    [AccessedThroughProperty("tbHomepage")]
    private TextBox _tbHomepage;
    [AccessedThroughProperty("bCurrentPage")]
    private Button _bCurrentPage;
    [AccessedThroughProperty("bSetHomepage")]
    private Button _bSetHomepage;
    [AccessedThroughProperty("txtSearchEngine")]
    private Label _txtSearchEngine;
    [AccessedThroughProperty("txtTheme")]
    private Label _txtTheme;
    [AccessedThroughProperty("comboTheme")]
    private ComboBox _comboTheme;
    [AccessedThroughProperty("comboSearch")]
    private ComboBox _comboSearch;
    [AccessedThroughProperty("cbTopSearchBar")]
    private CheckBox _cbTopSearchBar;
    [AccessedThroughProperty("bChangePassword")]
    private Button _bChangePassword;
    [AccessedThroughProperty("tbOldPassword")]
    private TextBox _tbOldPassword;
    [AccessedThroughProperty("txtOldPassword")]
    private Label _txtOldPassword;
    [AccessedThroughProperty("tbNewPassword")]
    private TextBox _tbNewPassword;
    [AccessedThroughProperty("txtNewPassword")]
    private Label _txtNewPassword;
    [AccessedThroughProperty("gbPreferences")]
    private GroupBox _gbPreferences;

    internal virtual Label txtHomepage
    {
      get
      {
        return this._txtHomepage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtHomepage = value;
      }
    }

    internal virtual TextBox tbHomepage
    {
      get
      {
        return this._tbHomepage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.tbHomepage_KeyDown);
        if (this._tbHomepage != null)
          this._tbHomepage.KeyDown -= keyEventHandler;
        this._tbHomepage = value;
        if (this._tbHomepage == null)
          return;
        this._tbHomepage.KeyDown += keyEventHandler;
      }
    }

    internal virtual Button bCurrentPage
    {
      get
      {
        return this._bCurrentPage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bCurrentPage_Click);
        if (this._bCurrentPage != null)
          this._bCurrentPage.Click -= eventHandler;
        this._bCurrentPage = value;
        if (this._bCurrentPage == null)
          return;
        this._bCurrentPage.Click += eventHandler;
      }
    }

    internal virtual Button bSetHomepage
    {
      get
      {
        return this._bSetHomepage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bSetHomepage_Click);
        if (this._bSetHomepage != null)
          this._bSetHomepage.Click -= eventHandler;
        this._bSetHomepage = value;
        if (this._bSetHomepage == null)
          return;
        this._bSetHomepage.Click += eventHandler;
      }
    }

    internal virtual Label txtSearchEngine
    {
      get
      {
        return this._txtSearchEngine;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtSearchEngine = value;
      }
    }

    internal virtual Label txtTheme
    {
      get
      {
        return this._txtTheme;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtTheme = value;
      }
    }

    internal virtual ComboBox comboTheme
    {
      get
      {
        return this._comboTheme;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.comboTheme_SelectedIndexChanged);
        if (this._comboTheme != null)
          this._comboTheme.SelectedIndexChanged -= eventHandler;
        this._comboTheme = value;
        if (this._comboTheme == null)
          return;
        this._comboTheme.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox comboSearch
    {
      get
      {
        return this._comboSearch;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.comboSearch_SelectedIndexChanged);
        if (this._comboSearch != null)
          this._comboSearch.SelectedIndexChanged -= eventHandler;
        this._comboSearch = value;
        if (this._comboSearch == null)
          return;
        this._comboSearch.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox cbTopSearchBar
    {
      get
      {
        return this._cbTopSearchBar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cbTopSearchBar_CheckedChanged);
        if (this._cbTopSearchBar != null)
          this._cbTopSearchBar.CheckedChanged -= eventHandler;
        this._cbTopSearchBar = value;
        if (this._cbTopSearchBar == null)
          return;
        this._cbTopSearchBar.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button bChangePassword
    {
      get
      {
        return this._bChangePassword;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bChangePassword_Click);
        if (this._bChangePassword != null)
          this._bChangePassword.Click -= eventHandler;
        this._bChangePassword = value;
        if (this._bChangePassword == null)
          return;
        this._bChangePassword.Click += eventHandler;
      }
    }

    internal virtual TextBox tbOldPassword
    {
      get
      {
        return this._tbOldPassword;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tbOldPassword = value;
      }
    }

    internal virtual Label txtOldPassword
    {
      get
      {
        return this._txtOldPassword;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtOldPassword = value;
      }
    }

    internal virtual TextBox tbNewPassword
    {
      get
      {
        return this._tbNewPassword;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.tbNewPassword_KeyDown);
        if (this._tbNewPassword != null)
          this._tbNewPassword.KeyDown -= keyEventHandler;
        this._tbNewPassword = value;
        if (this._tbNewPassword == null)
          return;
        this._tbNewPassword.KeyDown += keyEventHandler;
      }
    }

    internal virtual Label txtNewPassword
    {
      get
      {
        return this._txtNewPassword;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtNewPassword = value;
      }
    }

    internal virtual GroupBox gbPreferences
    {
      get
      {
        return this._gbPreferences;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gbPreferences = value;
      }
    }

    public fOptions()
    {
      this.Load += new EventHandler(this.fOptions_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fOptions));
      this.txtHomepage = new Label();
      this.tbHomepage = new TextBox();
      this.bCurrentPage = new Button();
      this.bSetHomepage = new Button();
      this.txtSearchEngine = new Label();
      this.txtTheme = new Label();
      this.comboTheme = new ComboBox();
      this.comboSearch = new ComboBox();
      this.cbTopSearchBar = new CheckBox();
      this.bChangePassword = new Button();
      this.tbOldPassword = new TextBox();
      this.txtOldPassword = new Label();
      this.tbNewPassword = new TextBox();
      this.txtNewPassword = new Label();
      this.gbPreferences = new GroupBox();
      this.gbPreferences.SuspendLayout();
      this.SuspendLayout();
      this.txtHomepage.AutoSize = true;
      Label txtHomepage1 = this.txtHomepage;
      Point point1 = new Point(8, 13);
      Point point2 = point1;
      txtHomepage1.Location = point2;
      this.txtHomepage.Name = "txtHomepage";
      Label txtHomepage2 = this.txtHomepage;
      Size size1 = new Size(85, 21);
      Size size2 = size1;
      txtHomepage2.Size = size2;
      this.txtHomepage.TabIndex = 0;
      this.txtHomepage.Text = "Homepage";
      this.tbHomepage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
      this.tbHomepage.AutoCompleteMode = AutoCompleteMode.Append;
      this.tbHomepage.AutoCompleteSource = AutoCompleteSource.CustomSource;
      this.tbHomepage.BackColor = Color.DimGray;
      this.tbHomepage.BorderStyle = BorderStyle.None;
      this.tbHomepage.ForeColor = Color.White;
      TextBox tbHomepage1 = this.tbHomepage;
      point1 = new Point(12, 37);
      Point point3 = point1;
      tbHomepage1.Location = point3;
      this.tbHomepage.Name = "tbHomepage";
      TextBox tbHomepage2 = this.tbHomepage;
      size1 = new Size(356, 22);
      Size size3 = size1;
      tbHomepage2.Size = size3;
      this.tbHomepage.TabIndex = 1;
      this.bCurrentPage.Anchor = AnchorStyles.Right;
      this.bCurrentPage.BackgroundImageLayout = ImageLayout.Stretch;
      this.bCurrentPage.FlatStyle = FlatStyle.Flat;
      this.bCurrentPage.ForeColor = Color.White;
      Button bCurrentPage1 = this.bCurrentPage;
      point1 = new Point(412, 31);
      Point point4 = point1;
      bCurrentPage1.Location = point4;
      this.bCurrentPage.Name = "bCurrentPage";
      Button bCurrentPage2 = this.bCurrentPage;
      size1 = new Size(110, 32);
      Size size4 = size1;
      bCurrentPage2.Size = size4;
      this.bCurrentPage.TabIndex = 3;
      this.bCurrentPage.Text = "Current Page";
      this.bCurrentPage.UseVisualStyleBackColor = true;
      this.bSetHomepage.Anchor = AnchorStyles.Right;
      this.bSetHomepage.BackgroundImage = (Image) Resources.accept_light;
      this.bSetHomepage.BackgroundImageLayout = ImageLayout.Stretch;
      this.bSetHomepage.FlatStyle = FlatStyle.Flat;
      this.bSetHomepage.ForeColor = Color.FromArgb(64, 64, 64);
      Button bSetHomepage1 = this.bSetHomepage;
      point1 = new Point(374, 31);
      Point point5 = point1;
      bSetHomepage1.Location = point5;
      this.bSetHomepage.Name = "bSetHomepage";
      Button bSetHomepage2 = this.bSetHomepage;
      size1 = new Size(32, 32);
      Size size5 = size1;
      bSetHomepage2.Size = size5;
      this.bSetHomepage.TabIndex = 2;
      this.bSetHomepage.UseVisualStyleBackColor = true;
      this.txtSearchEngine.AutoSize = true;
      Label txtSearchEngine1 = this.txtSearchEngine;
      point1 = new Point(248, 193);
      Point point6 = point1;
      txtSearchEngine1.Location = point6;
      this.txtSearchEngine.Name = "txtSearchEngine";
      Label txtSearchEngine2 = this.txtSearchEngine;
      size1 = new Size(105, 21);
      Size size6 = size1;
      txtSearchEngine2.Size = size6;
      this.txtSearchEngine.TabIndex = 6;
      this.txtSearchEngine.Text = "Search Engine";
      this.txtTheme.AutoSize = true;
      Label txtTheme1 = this.txtTheme;
      point1 = new Point(8, 193);
      Point point7 = point1;
      txtTheme1.Location = point7;
      this.txtTheme.Name = "txtTheme";
      Label txtTheme2 = this.txtTheme;
      size1 = new Size(56, 21);
      Size size7 = size1;
      txtTheme2.Size = size7;
      this.txtTheme.TabIndex = 7;
      this.txtTheme.Text = "Theme";
      this.comboTheme.BackColor = Color.DimGray;
      this.comboTheme.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboTheme.FlatStyle = FlatStyle.Flat;
      this.comboTheme.ForeColor = Color.White;
      this.comboTheme.FormattingEnabled = true;
      this.comboTheme.Items.AddRange(new object[2]
      {
        (object) "Light",
        (object) "Dark"
      });
      ComboBox comboTheme1 = this.comboTheme;
      point1 = new Point(12, 217);
      Point point8 = point1;
      comboTheme1.Location = point8;
      this.comboTheme.Name = "comboTheme";
      ComboBox comboTheme2 = this.comboTheme;
      size1 = new Size(150, 29);
      Size size8 = size1;
      comboTheme2.Size = size8;
      this.comboTheme.TabIndex = 7;
      this.comboSearch.BackColor = Color.DimGray;
      this.comboSearch.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboSearch.FlatStyle = FlatStyle.Flat;
      this.comboSearch.ForeColor = Color.White;
      this.comboSearch.FormattingEnabled = true;
      this.comboSearch.Items.AddRange(new object[3]
      {
        (object) "Google",
        (object) "Bing",
        (object) "YouTube"
      });
      ComboBox comboSearch1 = this.comboSearch;
      point1 = new Point(252, 217);
      Point point9 = point1;
      comboSearch1.Location = point9;
      this.comboSearch.Name = "comboSearch";
      ComboBox comboSearch2 = this.comboSearch;
      size1 = new Size(150, 29);
      Size size9 = size1;
      comboSearch2.Size = size9;
      this.comboSearch.TabIndex = 8;
      this.cbTopSearchBar.AutoSize = true;
      this.cbTopSearchBar.FlatStyle = FlatStyle.Flat;
      CheckBox cbTopSearchBar1 = this.cbTopSearchBar;
      point1 = new Point(6, 28);
      Point point10 = point1;
      cbTopSearchBar1.Location = point10;
      this.cbTopSearchBar.Name = "cbTopSearchBar";
      CheckBox cbTopSearchBar2 = this.cbTopSearchBar;
      size1 = new Size(125, 25);
      Size size10 = size1;
      cbTopSearchBar2.Size = size10;
      this.cbTopSearchBar.TabIndex = 9;
      this.cbTopSearchBar.Text = "Top search bar";
      this.cbTopSearchBar.UseVisualStyleBackColor = true;
      this.bChangePassword.Anchor = AnchorStyles.Right;
      this.bChangePassword.BackgroundImage = (Image) Resources.accept_light;
      this.bChangePassword.BackgroundImageLayout = ImageLayout.Stretch;
      this.bChangePassword.FlatStyle = FlatStyle.Flat;
      this.bChangePassword.ForeColor = Color.FromArgb(64, 64, 64);
      Button bChangePassword1 = this.bChangePassword;
      point1 = new Point(490, 121);
      Point point11 = point1;
      bChangePassword1.Location = point11;
      this.bChangePassword.Name = "bChangePassword";
      Button bChangePassword2 = this.bChangePassword;
      size1 = new Size(32, 32);
      Size size11 = size1;
      bChangePassword2.Size = size11;
      this.bChangePassword.TabIndex = 6;
      this.bChangePassword.UseVisualStyleBackColor = true;
      this.tbOldPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
      this.tbOldPassword.AutoCompleteMode = AutoCompleteMode.Append;
      this.tbOldPassword.AutoCompleteSource = AutoCompleteSource.CustomSource;
      this.tbOldPassword.BackColor = Color.DimGray;
      this.tbOldPassword.BorderStyle = BorderStyle.None;
      this.tbOldPassword.ForeColor = Color.White;
      TextBox tbOldPassword1 = this.tbOldPassword;
      point1 = new Point(12, (int) sbyte.MaxValue);
      Point point12 = point1;
      tbOldPassword1.Location = point12;
      this.tbOldPassword.Name = "tbOldPassword";
      TextBox tbOldPassword2 = this.tbOldPassword;
      size1 = new Size(232, 22);
      Size size12 = size1;
      tbOldPassword2.Size = size12;
      this.tbOldPassword.TabIndex = 4;
      this.txtOldPassword.AutoSize = true;
      Label txtOldPassword1 = this.txtOldPassword;
      point1 = new Point(8, 103);
      Point point13 = point1;
      txtOldPassword1.Location = point13;
      this.txtOldPassword.Name = "txtOldPassword";
      Label txtOldPassword2 = this.txtOldPassword;
      size1 = new Size(101, 21);
      Size size13 = size1;
      txtOldPassword2.Size = size13;
      this.txtOldPassword.TabIndex = 12;
      this.txtOldPassword.Text = "Old Password";
      this.tbNewPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
      this.tbNewPassword.AutoCompleteMode = AutoCompleteMode.Append;
      this.tbNewPassword.AutoCompleteSource = AutoCompleteSource.CustomSource;
      this.tbNewPassword.BackColor = Color.DimGray;
      this.tbNewPassword.BorderStyle = BorderStyle.None;
      this.tbNewPassword.ForeColor = Color.White;
      TextBox tbNewPassword1 = this.tbNewPassword;
      point1 = new Point(252, (int) sbyte.MaxValue);
      Point point14 = point1;
      tbNewPassword1.Location = point14;
      this.tbNewPassword.Name = "tbNewPassword";
      TextBox tbNewPassword2 = this.tbNewPassword;
      size1 = new Size(232, 22);
      Size size14 = size1;
      tbNewPassword2.Size = size14;
      this.tbNewPassword.TabIndex = 5;
      this.txtNewPassword.AutoSize = true;
      Label txtNewPassword1 = this.txtNewPassword;
      point1 = new Point(248, 103);
      Point point15 = point1;
      txtNewPassword1.Location = point15;
      this.txtNewPassword.Name = "txtNewPassword";
      Label txtNewPassword2 = this.txtNewPassword;
      size1 = new Size(107, 21);
      Size size15 = size1;
      txtNewPassword2.Size = size15;
      this.txtNewPassword.TabIndex = 15;
      this.txtNewPassword.Text = "New Password";
      this.gbPreferences.Controls.Add((Control) this.cbTopSearchBar);
      this.gbPreferences.FlatStyle = FlatStyle.Flat;
      this.gbPreferences.ForeColor = Color.White;
      GroupBox gbPreferences1 = this.gbPreferences;
      point1 = new Point(12, 296);
      Point point16 = point1;
      gbPreferences1.Location = point16;
      this.gbPreferences.Name = "gbPreferences";
      GroupBox gbPreferences2 = this.gbPreferences;
      size1 = new Size(510, 103);
      Size size16 = size1;
      gbPreferences2.Size = size16;
      this.gbPreferences.TabIndex = 17;
      this.gbPreferences.TabStop = false;
      this.gbPreferences.Text = "Preferences";
      this.AutoScaleDimensions = new SizeF(8f, 21f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(64, 64, 64);
      size1 = new Size(534, 412);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.gbPreferences);
      this.Controls.Add((Control) this.tbNewPassword);
      this.Controls.Add((Control) this.txtNewPassword);
      this.Controls.Add((Control) this.bChangePassword);
      this.Controls.Add((Control) this.tbOldPassword);
      this.Controls.Add((Control) this.txtOldPassword);
      this.Controls.Add((Control) this.comboSearch);
      this.Controls.Add((Control) this.comboTheme);
      this.Controls.Add((Control) this.txtTheme);
      this.Controls.Add((Control) this.txtSearchEngine);
      this.Controls.Add((Control) this.bSetHomepage);
      this.Controls.Add((Control) this.bCurrentPage);
      this.Controls.Add((Control) this.tbHomepage);
      this.Controls.Add((Control) this.txtHomepage);
      this.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      size1 = new Size(550, 450);
      this.MaximumSize = size1;
      size1 = new Size(550, 450);
      this.MinimumSize = size1;
      this.Name = "fOptions";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Options";
      this.TopMost = true;
      this.gbPreferences.ResumeLayout(false);
      this.gbPreferences.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void fOptions_Load(object sender, EventArgs e)
    {
      if (Operators.CompareString(MySettingsProperty.Settings.varPassword, "", false) == 0)
      {
        this.txtOldPassword.Text = "Set Password";
        this.txtNewPassword.Text = "Confirm Password";
      }
      else
      {
        this.txtOldPassword.Text = "Old Password";
        this.txtNewPassword.Text = "New Password";
      }
      if (Conversions.ToBoolean(MySettingsProperty.Settings.themeLight))
      {
        this.comboTheme.SelectedItem = (object) "Light";
        MySettingsProperty.Settings.themeLight = Conversions.ToString(true);
        MySettingsProperty.Settings.themeDark = Conversions.ToString(false);
      }
      else
      {
        this.comboTheme.SelectedItem = (object) "Dark";
        MySettingsProperty.Settings.themeLight = Conversions.ToString(false);
        MySettingsProperty.Settings.themeDark = Conversions.ToString(true);
      }
      this.comboSearch.SelectedItem = !Conversions.ToBoolean(MySettingsProperty.Settings.searchBing) ? (!Conversions.ToBoolean(MySettingsProperty.Settings.searchYoutube) ? (object) "Google" : (object) "YouTube") : (object) "Bing";
      this.tbHomepage.Text = MySettingsProperty.Settings.varHomepage;
      this.cbTopSearchBar.Checked = Conversions.ToBoolean(MySettingsProperty.Settings.varTopSearch);
      MyProject.Forms.fMain.loadVar();
    }

    private void bSetHomepage_Click(object sender, EventArgs e)
    {
      this.tbHomepage.Text = MySettingsProperty.Settings.varHomepage;
      MySettingsProperty.Settings.Save();
      MyProject.Forms.fMain.loadVar();
    }

    private void bCurrentPage_Click(object sender, EventArgs e)
    {
      MySettingsProperty.Settings.varHomepage = MyProject.Forms.fMain.tbSearch.Text;
      this.tbHomepage.Text = MySettingsProperty.Settings.varHomepage;
      MySettingsProperty.Settings.Save();
      MyProject.Forms.fMain.loadVar();
    }

    private void bChangePassword_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(MySettingsProperty.Settings.varPassword, "", false) == 0)
      {
        if (Operators.CompareString(this.tbOldPassword.Text, this.tbNewPassword.Text, false) == 0)
        {
          MySettingsProperty.Settings.varPassword = this.tbNewPassword.Text;
          this.txtOldPassword.Text = "Old Password";
          this.txtNewPassword.Text = "New Password";
          this.tbOldPassword.Text = "";
          this.tbNewPassword.Text = "";
        }
        else
        {
          int num1 = (int) MessageBox.Show("Passwords do not match.", "Notice");
        }
      }
      else if (Operators.CompareString(MySettingsProperty.Settings.varPassword, this.tbOldPassword.Text, false) == 0)
      {
        MySettingsProperty.Settings.varPassword = this.tbNewPassword.Text;
        this.tbOldPassword.Text = "";
        this.tbNewPassword.Text = "";
      }
      else
      {
        int num2 = (int) MessageBox.Show("Incorrect password.", "Notice");
      }
      MySettingsProperty.Settings.Save();
      this.Refresh();
    }

    private void comboTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(this.comboTheme.SelectedItem, (object) "Light", false))
      {
        MySettingsProperty.Settings.themeLight = Conversions.ToString(true);
        MySettingsProperty.Settings.themeDark = Conversions.ToString(false);
      }
      else
      {
        MySettingsProperty.Settings.themeLight = Conversions.ToString(false);
        MySettingsProperty.Settings.themeDark = Conversions.ToString(true);
      }
      MySettingsProperty.Settings.Save();
      MyProject.Forms.fMain.loadTheme();
    }

    private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(this.comboSearch.SelectedItem, (object) "Bing", false))
      {
        MySettingsProperty.Settings.searchGoogle = Conversions.ToString(false);
        MySettingsProperty.Settings.searchBing = Conversions.ToString(true);
        MySettingsProperty.Settings.searchYoutube = Conversions.ToString(false);
      }
      else if (Operators.ConditionalCompareObjectEqual(this.comboSearch.SelectedItem, (object) "YouTube", false))
      {
        MySettingsProperty.Settings.searchGoogle = Conversions.ToString(false);
        MySettingsProperty.Settings.searchBing = Conversions.ToString(false);
        MySettingsProperty.Settings.searchYoutube = Conversions.ToString(true);
      }
      else
      {
        MySettingsProperty.Settings.searchGoogle = Conversions.ToString(true);
        MySettingsProperty.Settings.searchBing = Conversions.ToString(false);
        MySettingsProperty.Settings.searchYoutube = Conversions.ToString(false);
      }
      MySettingsProperty.Settings.Save();
      MyProject.Forms.fMain.loadVar();
    }

    private void cbTopSearchBar_CheckedChanged(object sender, EventArgs e)
    {
      MySettingsProperty.Settings.varTopSearch = !this.cbTopSearchBar.Checked ? Conversions.ToString(false) : Conversions.ToString(true);
      MySettingsProperty.Settings.Save();
      MyProject.Forms.fMain.loadVar();
    }

    private void cbEarlyReleases_CheckedChanged(object sender, EventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.cbEarlyReleases(), (System.Type) null, "Checked", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) true, false))
        MySettingsProperty.Settings.varEarlyReleases = Conversions.ToString(true);
      else
        MySettingsProperty.Settings.varEarlyReleases = Conversions.ToString(false);
    }

    private void tbHomepage_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.bSetHomepage.PerformClick();
    }

    private void tbNewPassword_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.bChangePassword.PerformClick();
    }

    private object cbEarlyReleases()
    {
      throw new NotImplementedException();
    }
  }
}
