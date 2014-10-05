// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Anti_Virus.Form1
// Assembly: Green Dragon Anti-Virus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CFA5EC03-2D59-4DD3-A998-F57603AE3008
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Anti-Virus.exe

using Green_Dragon_Anti_Virus.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon_Anti_Virus
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("ProgressBar1")]
    private ProgressBar _ProgressBar1;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("Button3")]
    private Button _Button3;
    [AccessedThroughProperty("Timer1")]
    private Timer _Timer1;
    [AccessedThroughProperty("ComboBox1")]
    private ComboBox _ComboBox1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("label3")]
    private Label _label3;
    [AccessedThroughProperty("Button4")]
    private Button _Button4;
    public ArrayList FoundFiles;
    public ArrayList FoundDirs;
    private string[] Worms_Files;
    private string[] Worms_Dirs;
    private string[] Spyware_Files;
    private string[] Spyware_Dirs;
    private string[] Adware_Files;
    private string[] Adware_Dirs;
    public int VirusesFound;
    public int SpywareFound;
    public int AdwareFound;
    private int FileDirCount;
    private int FileCount;

    internal virtual ProgressBar ProgressBar1
    {
      get
      {
        return this._ProgressBar1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ProgressBar1 = value;
      }
    }

    internal virtual Button Button1
    {
      get
      {
        return this._Button1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
    }

    internal virtual Button Button2
    {
      get
      {
        return this._Button2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        if (this._Button2 != null)
          this._Button2.Click -= eventHandler;
        this._Button2 = value;
        if (this._Button2 == null)
          return;
        this._Button2.Click += eventHandler;
      }
    }

    internal virtual Button Button3
    {
      get
      {
        return this._Button3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        if (this._Button3 != null)
          this._Button3.Click -= eventHandler;
        this._Button3 = value;
        if (this._Button3 == null)
          return;
        this._Button3.Click += eventHandler;
      }
    }

    internal virtual Timer Timer1
    {
      get
      {
        return this._Timer1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        if (this._Timer1 != null)
          this._Timer1.Tick -= eventHandler;
        this._Timer1 = value;
        if (this._Timer1 == null)
          return;
        this._Timer1.Tick += eventHandler;
      }
    }

    internal virtual ComboBox ComboBox1
    {
      get
      {
        return this._ComboBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ComboBox1 = value;
      }
    }

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    internal virtual Label label3
    {
      get
      {
        return this._label3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._label3 = value;
      }
    }

    internal virtual Button Button4
    {
      get
      {
        return this._Button4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        if (this._Button4 != null)
          this._Button4.Click -= eventHandler;
        this._Button4 = value;
        if (this._Button4 == null)
          return;
        this._Button4.Click += eventHandler;
      }
    }

    private MsgBoxResult Response { get; set; }

    public Form1()
    {
      this.Load += new EventHandler(this.Form1_Load);
      this.FoundFiles = new ArrayList();
      this.FoundDirs = new ArrayList();
      this.Worms_Files = new string[3]
      {
        "c:\\Program Files\\Archive.exe",
        "c:\\Program Files\\Archive.exe",
        "c:\\avtest.txt"
      };
      this.Worms_Dirs = new string[3]
      {
        "c:\\Program Files\\aolx",
        "c:\\Program Files\\BTV",
        "c:\\avtest"
      };
      this.Spyware_Files = new string[22]
      {
        "C:\\Program Files\\AdStatComm.dll",
        "C:\\Program Files\\0er8k4va\\0er8k4va.exe",
        "C:\\WINDOWS\\System32\\Mkfxut.exe",
        "C:\\WINDOWS\\system32\\pkdacs.exe",
        "C:\\WINDOWS\\System32\\ywrqku.exe",
        "C:\\windows\\system32\\msnavc32.exe",
        "C:\\Program Files\\AutoUpdate\\AutoUpdate.exe",
        "C:\\WINDOWS\\System32\\vwix32.exe",
        "C:\\WINDOWS\\System32\\winntcreate.exe",
        "C:\\WINDOWS\\System32\\sysmonnt.exe",
        "C:\\WINDOWS\\System32\\winhcek32.exe",
        "C:\\WINDOWS\\System32\\qlykdnb.dll",
        "C:\\WINDOWS\\System32\\rypgvtoimrl.exe",
        "C:\\WINDOWS\\System32\\spwgoc.exe",
        "C:\\windows\\system32\\msnavc32.exe",
        "C:\\WINDOWS\\System32\\sysmonnt",
        "C:\\Program Files\\hpdll\\hpdll.exe",
        "C:\\WINDOWS\\System32\\w?wexec.exe",
        "C:\\WINDOWS\\isrvs\\ffisearch.exe",
        "c:\\Program Files\\Autosearch.dll",
        "c:\\Program Files\\Archive.exe",
        "c:\\Program Files\\Archive.exe"
      };
      this.Spyware_Dirs = new string[17]
      {
        "c:\\Program Files\\180 SearchAssistant",
        "c:\\Program Files\\2Search",
        "c:\\Program Files\\5whgue21",
        "c:\\Program Files\\aolx",
        "c:\\Program Files\\ACM",
        "c:\\Program Files\\Browser Pal",
        "c:\\Program Files\\Activity Keylogger",
        "c:\\Program Files\\Activity Logger",
        "c:\\Program Files\\Actual Spy",
        "c:\\Program Files\\AdvSearch",
        "c:\\Program Files\\AppsTraka",
        "c:\\Program Files\\Ardamax Keylogger",
        "c:\\Program Files\\Auto Keylogger",
        "c:\\Program Files\\BazookaBar",
        "c:\\Program Files\\Blackbox7",
        "c:\\Program Files\\Blackbox7",
        "c:\\Program Files\\BTV"
      };
      this.Adware_Files = new string[20]
      {
        "c:\\Program Files\\AdStatComm.dll",
        "C:\\Program Files\\0er8k4va\\0er8k4va.exe",
        " C:\\WINDOWS\\System32\\Mkfxut.exe",
        " C:\\WINDOWS\\system32\\pkdacs.exe",
        "C:\\WINDOWS\\System32\\ywrqku.exe",
        " C:\\windows\\system32\\msnavc32.exe",
        "C:\\Program Files\\AutoUpdate\\AutoUpdate.exe",
        " C:\\WINDOWS\\System32\\winntcreate.exe",
        "C:\\WINDOWS\\System32\\vwix32.exe",
        " C:\\WINDOWS\\System32\\sysmonnt.exe",
        "C:\\WINDOWS\\System32\\winhcek32.exe",
        " C:\\WINDOWS\\System32\\qlykdnb.dll",
        "C:\\WINDOWS\\System32\\rypgvtoimrl.exe",
        " C:\\WINDOWS\\System32\\spwgoc.exe ",
        "C:\\windows\\system32\\msnavc32.exe",
        " C:\\WINDOWS\\System32\\sysmonnt",
        "C:\\Program Files\\hpdll\\hpdll.exe ",
        " C:\\WINDOWS\\System32\\w?wexec.exe",
        "C:\\WINDOWS\\isrvs\\ffisearch.exe",
        "c:\\Program Files\\Autosearch.dll"
      };
      this.Adware_Dirs = new string[17]
      {
        "c:\\Program Files\\180 SearchAssistant",
        "c:\\Program Files\\2Search",
        "c:\\Program Files\\5whgue21",
        "c:\\Program Files\\aolx",
        "c:\\Program Files\\ACM",
        "c:\\Program Files\\Browser Pal",
        "c:\\Program Files\\Activity Keylogger",
        "c:\\Program Files\\Activity Logger",
        "c:\\Program Files\\Actual Spy",
        "c:\\Program Files\\AdvSearch",
        "c:\\Program Files\\AppsTraka",
        "c:\\Program Files\\Ardamax Keylogger",
        "c:\\Program Files\\Auto Keylogger",
        "c:\\Program Files\\BazookaBar",
        "c:\\Program Files\\Blackbox7",
        "c:\\Program Files\\Blackbox7",
        "c:\\Program Files\\BTV"
      };
      this.VirusesFound = 0;
      this.SpywareFound = 0;
      this.AdwareFound = 0;
      this.FileDirCount = 0;
      this.FileCount = 0;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.ProgressBar1 = new ProgressBar();
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.Button3 = new Button();
      this.Timer1 = new Timer(this.components);
      this.ComboBox1 = new ComboBox();
      this.Label1 = new Label();
      this.label3 = new Label();
      this.Button4 = new Button();
      this.SuspendLayout();
      ProgressBar progressBar1_1 = this.ProgressBar1;
      Point point1 = new Point(23, 82);
      Point point2 = point1;
      progressBar1_1.Location = point2;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      Size size1 = new Size(334, 16);
      Size size2 = size1;
      progressBar1_2.Size = size2;
      this.ProgressBar1.TabIndex = 0;
      Button button1_1 = this.Button1;
      point1 = new Point(23, 53);
      Point point3 = point1;
      button1_1.Location = point3;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(75, 23);
      Size size3 = size1;
      button1_2.Size = size3;
      this.Button1.TabIndex = 1;
      this.Button1.Text = "Scan";
      this.Button1.UseVisualStyleBackColor = true;
      Button button2_1 = this.Button2;
      point1 = new Point(104, 53);
      Point point4 = point1;
      button2_1.Location = point4;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(91, 23);
      Size size4 = size1;
      button2_2.Size = size4;
      this.Button2.TabIndex = 2;
      this.Button2.Text = "Clean Viruses";
      this.Button2.UseVisualStyleBackColor = true;
      this.Button3.Enabled = false;
      Button button3_1 = this.Button3;
      point1 = new Point(201, 53);
      Point point5 = point1;
      button3_1.Location = point5;
      this.Button3.Name = "Button3";
      Button button3_2 = this.Button3;
      size1 = new Size(75, 23);
      Size size5 = size1;
      button3_2.Size = size5;
      this.Button3.TabIndex = 3;
      this.Button3.Text = "Stop Scan";
      this.Button3.UseVisualStyleBackColor = true;
      this.Timer1.Interval = 500;
      this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox1.FormattingEnabled = true;
      this.ComboBox1.Items.AddRange(new object[3]
      {
        (object) "Scan for Virus(es)",
        (object) "Scan for Spyware",
        (object) "Scan for Adware"
      });
      ComboBox comboBox1_1 = this.ComboBox1;
      point1 = new Point(104, 17);
      Point point6 = point1;
      comboBox1_1.Location = point6;
      this.ComboBox1.Name = "ComboBox1";
      ComboBox comboBox1_2 = this.ComboBox1;
      size1 = new Size(121, 21);
      Size size6 = size1;
      comboBox1_2.Size = size6;
      this.ComboBox1.TabIndex = 5;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(20, 20);
      Point point7 = point1;
      label1_1.Location = point7;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(59, 13);
      Size size7 = size1;
      label1_2.Size = size7;
      this.Label1.TabIndex = 6;
      this.Label1.Text = "Scan Type";
      this.label3.AutoSize = true;
      Label label3_1 = this.label3;
      point1 = new Point(20, 106);
      Point point8 = point1;
      label3_1.Location = point8;
      this.label3.Name = "label3";
      Label label3_2 = this.label3;
      size1 = new Size(0, 13);
      Size size8 = size1;
      label3_2.Size = size8;
      this.label3.TabIndex = 7;
      Button button4_1 = this.Button4;
      point1 = new Point(283, 53);
      Point point9 = point1;
      button4_1.Location = point9;
      this.Button4.Name = "Button4";
      Button button4_2 = this.Button4;
      size1 = new Size(75, 23);
      Size size9 = size1;
      button4_2.Size = size9;
      this.Button4.TabIndex = 8;
      this.Button4.Text = "Exit";
      this.Button4.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(380, 128);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.ComboBox1);
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.ProgressBar1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = "Form1";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Green Dragon Anti-Virus";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.ComboBox1.SelectedIndex = 0;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.FoundDirs.Clear();
      this.FoundFiles.Clear();
      this.FileDirCount = 0;
      this.FileCount = 0;
      this.ProgressBar1.Value = 0;
      switch (this.ComboBox1.SelectedIndex)
      {
        case 0:
          this.ProgressBar1.Maximum = checked (this.Worms_Dirs.Length + this.Worms_Files.Length);
          break;
        case 1:
          this.ProgressBar1.Maximum = checked (this.Spyware_Dirs.Length + this.Spyware_Files.Length);
          break;
        case 2:
          this.ProgressBar1.Maximum = checked (this.Adware_Dirs.Length + this.Adware_Files.Length);
          break;
      }
      this.Timer1.Enabled = true;
      this.label3.Text = "Scan Started";
      this.Button1.Enabled = false;
      this.Button2.Enabled = false;
      this.Button3.Enabled = true;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if ((uint) (this.FoundDirs.Count | -((uint) (this.FoundFiles.Count == 0) > 0U ? 1 : 0)) > 0U)
      {
        int num = (int) MessageBox.Show("There are either no viruses found or you have not scanned. ", "Oh-Oh!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        this.Hide();
        ((Control) MyProject.Forms.Form2).Show();
      }
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      switch (this.ComboBox1.SelectedIndex)
      {
        case 0:
          if (this.FileCount < this.Worms_Files.GetUpperBound(0) && File.Exists(this.Worms_Files[this.FileCount]))
          {
            this.FoundFiles.Add((object) this.Worms_Files[this.FileCount]);
            this.VirusesFound = checked (this.VirusesFound + 1);
          }
          if (this.FileDirCount < this.Worms_Dirs.GetUpperBound(0) && Directory.Exists(this.Worms_Dirs[this.FileDirCount]))
          {
            this.FoundDirs.Add((object) this.Worms_Dirs[this.FileDirCount]);
            this.VirusesFound = checked (this.VirusesFound + 1);
            break;
          }
          else
            break;
        case 1:
          if (this.FileCount < this.Spyware_Files.GetUpperBound(0) && File.Exists(this.Spyware_Files[this.FileCount]))
          {
            this.FoundFiles.Add((object) this.Spyware_Files[this.FileCount]);
            this.VirusesFound = checked (this.VirusesFound + 1);
          }
          if (this.FileDirCount < this.Spyware_Dirs.GetUpperBound(0) && Directory.Exists(this.Spyware_Dirs[this.FileDirCount]))
          {
            this.FoundDirs.Add((object) this.Spyware_Dirs[this.FileDirCount]);
            this.VirusesFound = checked (this.VirusesFound + 1);
            break;
          }
          else
            break;
        case 2:
          if (this.FileCount < this.Adware_Files.GetUpperBound(0) && File.Exists(this.Adware_Files[this.FileCount]))
          {
            this.FoundFiles.Add((object) this.Adware_Files[this.FileCount]);
            this.VirusesFound = checked (this.VirusesFound + 1);
          }
          if (this.FileDirCount < this.Adware_Dirs.GetUpperBound(0) && Directory.Exists(this.Adware_Dirs[this.FileDirCount]))
          {
            this.FoundDirs.Add((object) this.Adware_Dirs[this.FileDirCount]);
            this.VirusesFound = checked (this.VirusesFound + 1);
            break;
          }
          else
            break;
      }
      if (this.ProgressBar1.Value == this.ProgressBar1.Maximum)
      {
        this.Timer1.Enabled = false;
        this.label3.Text = "Scan Completed";
        int num = (int) MessageBox.Show("Your computer has been scanned!  Click the Clean Viruses Button, and you will see the results!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.Button1.Enabled = true;
        this.Button2.Enabled = true;
        this.Button3.Enabled = false;
      }
      else
      {
        this.FileDirCount = checked (this.FileDirCount + 1);
        ProgressBar progressBar1 = this.ProgressBar1;
        progressBar1.Value = checked (progressBar1.Value + 1);
      }
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      this.Timer1.Enabled = false;
      this.label3.Text = "Scan Stopped";
      this.ProgressBar1.Value = 0;
      this.Button1.Enabled = true;
      this.Button2.Enabled = true;
      this.Button3.Enabled = false;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      this.Button3.PerformClick();
      if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      Application.Exit();
    }
  }
}
