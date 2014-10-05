// Decompiled with JetBrains decompiler
// Type: WindowsApplication1.Form1
// Assembly: Green Dragon Download Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 718D136A-FDF9-419F-8458-6E3F7A26C7B8
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Download Manager.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsApplication1
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("ProgressBar1")]
    private ProgressBar _ProgressBar1;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("TextBox2")]
    private TextBox _TextBox2;
    [AccessedThroughProperty("SaveFileDialog1")]
    private SaveFileDialog _SaveFileDialog1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("download")]
    private WebClient _download;

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

    internal virtual TextBox TextBox1
    {
      get
      {
        return this._TextBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox1 = value;
      }
    }

    internal virtual TextBox TextBox2
    {
      get
      {
        return this._TextBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox2 = value;
      }
    }

    internal virtual SaveFileDialog SaveFileDialog1
    {
      get
      {
        return this._SaveFileDialog1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._SaveFileDialog1 = value;
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

    internal virtual Label Label4
    {
      get
      {
        return this._Label4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label4 = value;
      }
    }

    internal virtual Panel Panel1
    {
      get
      {
        return this._Panel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel1 = value;
      }
    }

    public virtual WebClient download
    {
      get
      {
        return this._download;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DownloadProgressChangedEventHandler changedEventHandler = new DownloadProgressChangedEventHandler(this.download_DownloadProgressChanged);
        AsyncCompletedEventHandler completedEventHandler = new AsyncCompletedEventHandler(this.download_DownloadFileCompleted);
        if (this._download != null)
        {
          this._download.DownloadProgressChanged -= changedEventHandler;
          this._download.DownloadFileCompleted -= completedEventHandler;
        }
        this._download = value;
        if (this._download == null)
          return;
        this._download.DownloadProgressChanged += changedEventHandler;
        this._download.DownloadFileCompleted += completedEventHandler;
      }
    }

    public Form1()
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.ProgressBar1 = new ProgressBar();
      this.TextBox1 = new TextBox();
      this.TextBox2 = new TextBox();
      this.SaveFileDialog1 = new SaveFileDialog();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Panel1 = new Panel();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.BackColor = Color.Transparent;
      this.Label1.ForeColor = SystemColors.ControlText;
      Label label1_1 = this.Label1;
      Point point1 = new Point(12, 51);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(60, 13);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "URL of File";
      this.Label2.AutoSize = true;
      this.Label2.BackColor = Color.Transparent;
      Label label2_1 = this.Label2;
      point1 = new Point(12, 110);
      Point point3 = point1;
      label2_1.Location = point3;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(51, 13);
      Size size3 = size1;
      label2_2.Size = size3;
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Save File";
      Button button1_1 = this.Button1;
      point1 = new Point(370, 252);
      Point point4 = point1;
      button1_1.Location = point4;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(75, 23);
      Size size4 = size1;
      button1_2.Size = size4;
      this.Button1.TabIndex = 2;
      this.Button1.Text = "Download";
      this.Button1.UseVisualStyleBackColor = true;
      Button button2_1 = this.Button2;
      point1 = new Point(410, 105);
      Point point5 = point1;
      button2_1.Location = point5;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(75, 23);
      Size size5 = size1;
      button2_2.Size = size5;
      this.Button2.TabIndex = 3;
      this.Button2.Text = "...";
      this.Button2.UseVisualStyleBackColor = true;
      ProgressBar progressBar1_1 = this.ProgressBar1;
      point1 = new Point(15, 252);
      Point point6 = point1;
      progressBar1_1.Location = point6;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      size1 = new Size(336, 23);
      Size size6 = size1;
      progressBar1_2.Size = size6;
      this.ProgressBar1.TabIndex = 4;
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(95, 48);
      Point point7 = point1;
      textBox1_1.Location = point7;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(390, 20);
      Size size7 = size1;
      textBox1_2.Size = size7;
      this.TextBox1.TabIndex = 5;
      TextBox textBox2_1 = this.TextBox2;
      point1 = new Point(95, 107);
      Point point8 = point1;
      textBox2_1.Location = point8;
      this.TextBox2.Name = "TextBox2";
      TextBox textBox2_2 = this.TextBox2;
      size1 = new Size(288, 20);
      Size size8 = size1;
      textBox2_2.Size = size8;
      this.TextBox2.TabIndex = 6;
      this.Label3.AutoSize = true;
      this.Label3.BackColor = Color.Transparent;
      Label label3_1 = this.Label3;
      point1 = new Point(164, 183);
      Point point9 = point1;
      label3_1.Location = point9;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(187, 13);
      Size size9 = size1;
      label3_2.Size = size9;
      this.Label3.TabIndex = 7;
      this.Label3.Text = "Warning! Invalid URL causes a crash!";
      this.Label4.AutoSize = true;
      this.Label4.BackColor = Color.Transparent;
      Label label4_1 = this.Label4;
      point1 = new Point(79, 215);
      Point point10 = point1;
      label4_1.Location = point10;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(347, 13);
      Size size10 = size1;
      label4_2.Size = size10;
      this.Label4.TabIndex = 8;
      this.Label4.Text = "When you select Other make sure you add an extension like example.txt";
      Panel panel1_1 = this.Panel1;
      point1 = new Point(123, 75);
      Point point11 = point1;
      panel1_1.Location = point11;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(67, 26);
      Size size11 = size1;
      panel1_2.Size = size11;
      this.Panel1.TabIndex = 9;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveBorder;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      this.BackgroundImageLayout = ImageLayout.Zoom;
      size1 = new Size(549, 359);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.TextBox2);
      this.Controls.Add((Control) this.TextBox1);
      this.Controls.Add((Control) this.ProgressBar1);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.DoubleBuffered = true;
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = "Form1";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Green Dragon Download Manager";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      this.SaveFileDialog1.Filter = "JPEG Image|*.jpg|.exe|*.exe|.rar|*.rar|.zip|*.zip|.mp3|*.mp3|Other|*.";
      int num = (int) this.SaveFileDialog1.ShowDialog();
      this.TextBox2.Text = this.SaveFileDialog1.FileName;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.download = new WebClient();
      this.download.DownloadFileAsync(new Uri(this.TextBox1.Text), this.TextBox2.Text);
    }

    private void download_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
    {
      int num = (int) MessageBox.Show("Download Completed!");
      this.ProgressBar1.Value = 0;
      this.TextBox1.Text = "";
      this.TextBox2.Text = "";
    }

    private void download_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
      this.ProgressBar1.Value = e.ProgressPercentage;
    }
  }
}
