// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Anti_Virus.Form2
// Assembly: Green Dragon Anti-Virus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CFA5EC03-2D59-4DD3-A998-F57603AE3008
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Anti-Virus.exe

using Green_Dragon_Anti_Virus.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon_Anti_Virus
{
  [DesignerGenerated]
  public class Form2 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("ListBox1")]
    private ListBox _ListBox1;
    [AccessedThroughProperty("ListBox2")]
    private ListBox _ListBox2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("ProgressBar1")]
    private ProgressBar _ProgressBar1;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("NotifyIcon1")]
    private NotifyIcon _NotifyIcon1;
    private int VirusCount;

    internal virtual ListBox ListBox1
    {
      get
      {
        return this._ListBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ListBox1 = value;
      }
    }

    internal virtual ListBox ListBox2
    {
      get
      {
        return this._ListBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ListBox2 = value;
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

    internal virtual Label Label2
    {
      get
      {
        return this._Label2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label2 = value;
      }
    }

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

    internal virtual Label Label3
    {
      get
      {
        return this._Label3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label3 = value;
      }
    }

    internal virtual NotifyIcon NotifyIcon1
    {
      get
      {
        return this._NotifyIcon1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._NotifyIcon1 = value;
      }
    }

    public Form2()
    {
      this.FormClosed += new FormClosedEventHandler(this.Form2_FormClosed);
      this.Load += new EventHandler(this.Form2_Load);
      this.VirusCount = 0;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form2));
      this.ListBox1 = new ListBox();
      this.ListBox2 = new ListBox();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.ProgressBar1 = new ProgressBar();
      this.Button1 = new Button();
      this.Label3 = new Label();
      this.NotifyIcon1 = new NotifyIcon(this.components);
      this.SuspendLayout();
      this.ListBox1.FormattingEnabled = true;
      ListBox listBox1_1 = this.ListBox1;
      Point point1 = new Point(38, (int) sbyte.MaxValue);
      Point point2 = point1;
      listBox1_1.Location = point2;
      this.ListBox1.Name = "ListBox1";
      ListBox listBox1_2 = this.ListBox1;
      Size size1 = new Size(120, 147);
      Size size2 = size1;
      listBox1_2.Size = size2;
      this.ListBox1.TabIndex = 0;
      this.ListBox2.FormattingEnabled = true;
      ListBox listBox2_1 = this.ListBox2;
      point1 = new Point(211, (int) sbyte.MaxValue);
      Point point3 = point1;
      listBox2_1.Location = point3;
      this.ListBox2.Name = "ListBox2";
      ListBox listBox2_2 = this.ListBox2;
      size1 = new Size(120, 147);
      Size size3 = size1;
      listBox2_2.Size = size3;
      this.ListBox2.TabIndex = 1;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(35, 111);
      Point point4 = point1;
      label1_1.Location = point4;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(103, 13);
      Size size4 = size1;
      label1_2.Size = size4;
      this.Label1.TabIndex = 2;
      this.Label1.Text = "Major Viruses Found";
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(208, 111);
      Point point5 = point1;
      label2_1.Location = point5;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(64, 13);
      Size size5 = size1;
      label2_2.Size = size5;
      this.Label2.TabIndex = 3;
      this.Label2.Text = "Total Found";
      ProgressBar progressBar1_1 = this.ProgressBar1;
      point1 = new Point(38, 313);
      Point point6 = point1;
      progressBar1_1.Location = point6;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      size1 = new Size(293, 14);
      Size size6 = size1;
      progressBar1_2.Size = size6;
      this.ProgressBar1.TabIndex = 4;
      this.Button1.Enabled = false;
      Button button1_1 = this.Button1;
      point1 = new Point(63, 280);
      Point point7 = point1;
      button1_1.Location = point7;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(75, 23);
      Size size7 = size1;
      button1_2.Size = size7;
      this.Button1.TabIndex = 5;
      this.Button1.Text = "Clean";
      this.Button1.UseVisualStyleBackColor = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.ControlText;
      Label label3_1 = this.Label3;
      point1 = new Point(38, 9);
      Point point8 = point1;
      label3_1.Location = point8;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(293, 78);
      Size size8 = size1;
      label3_2.Size = size8;
      this.Label3.TabIndex = 7;
      this.Label3.TextAlign = ContentAlignment.MiddleCenter;
      this.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
      this.NotifyIcon1.BalloonTipText = "The Results are here!";
      this.NotifyIcon1.BalloonTipTitle = "Scan Results";
      this.NotifyIcon1.Text = "Green Dragon Anti-Virus";
      this.NotifyIcon1.Visible = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(380, 347);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.ProgressBar1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.ListBox2);
      this.Controls.Add((Control) this.ListBox1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = "Form2";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Virus Scan";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      this.NotifyIcon1.ShowBalloonTip(99);
      this.ListBox1.Items.Clear();
      this.ListBox2.Items.Clear();
      this.VirusCount = checked (MyProject.Forms.Form1.FoundFiles.Count + MyProject.Forms.Form1.FoundDirs.Count);
      if ((uint) (MyProject.Forms.Form1.FoundDirs.Count | -((uint) (MyProject.Forms.Form1.FoundFiles.Count > 0) > 0U ? 1 : 0)) > 0U)
      {
        int num1 = 0;
        int num2 = checked (MyProject.Forms.Form1.FoundDirs.Count - 1);
        int index1 = num1;
        while (index1 <= num2)
        {
          this.ListBox1.Items.Add(RuntimeHelpers.GetObjectValue(MyProject.Forms.Form1.FoundDirs[index1]));
          checked { ++index1; }
        }
        int num3 = 0;
        int num4 = checked (MyProject.Forms.Form1.FoundFiles.Count - 1);
        int index2 = num3;
        while (index2 <= num4)
        {
          this.ListBox1.Items.Add(RuntimeHelpers.GetObjectValue(MyProject.Forms.Form1.FoundFiles[index2]));
          checked { ++index2; }
        }
        this.Label3.ForeColor = Color.Red;
        this.Label3.Text = "Your computer is a major risk, Anti-Virus suggests you clean the spotted viruses.";
        this.Button1.Enabled = true;
      }
      else
      {
        this.Label3.ForeColor = Color.Green;
        this.Label3.Text = "No viruses found. Your computer is clean.";
        this.Button1.Enabled = false;
      }
      switch (MyProject.Forms.Form1.ComboBox1.SelectedIndex)
      {
        case 0:
          this.ListBox2.Items.Add((object) ("Viruses Found " + Conversions.ToString(MyProject.Forms.Form1.VirusesFound)));
          break;
        case 1:
          this.ListBox2.Items.Add((object) ("Spyware Found " + Conversions.ToString(MyProject.Forms.Form1.SpywareFound)));
          break;
        case 2:
          this.ListBox2.Items.Add((object) ("Adware Found " + Conversions.ToString(MyProject.Forms.Form1.AdwareFound)));
          break;
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      try
      {
        int num1 = 0;
        int num2 = checked (MyProject.Forms.Form1.FoundDirs.Count - 1);
        int index1 = num1;
        while (index1 <= num2)
        {
          Directory.Delete(Conversions.ToString(MyProject.Forms.Form1.FoundDirs[index1]));
          checked { ++index1; }
        }
        int num3 = 0;
        int num4 = checked (MyProject.Forms.Form1.FoundFiles.Count - 1);
        int index2 = num3;
        while (index2 <= num4)
        {
          File.Delete(Conversions.ToString(MyProject.Forms.Form1.FoundFiles[index2]));
          checked { ++index2; }
        }
        int num5 = (int) MessageBox.Show("Your computer has been cleaned!", "Successs", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show((IWin32Window) ex, "Error", Conversions.ToString(0), (MessageBoxButtons) 16);
        ProjectData.ClearProjectError();
      }
    }

    private void Form2_FormClosed(object sender, FormClosedEventArgs e)
    {
      ((Control) MyProject.Forms.Form1).Show();
    }
  }
}
