// Decompiled with JetBrains decompiler
// Type: Green_Dragon.Form1
// Assembly: Green Dragon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72C6BEE2-CC2C-43BF-AE11-CDF506D6CD3B
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon.exe

using Green_Dragon.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("TextBox2")]
    private TextBox _TextBox2;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;

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

    public Form1()
    {
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
      this.Label1 = new Label();
      this.TextBox1 = new TextBox();
      this.Label2 = new Label();
      this.TextBox2 = new TextBox();
      this.Button1 = new Button();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      Point point1 = new Point(12, 53);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(58, 13);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Username:";
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(76, 53);
      Point point3 = point1;
      textBox1_1.Location = point3;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(248, 20);
      Size size3 = size1;
      textBox1_2.Size = size3;
      this.TextBox1.TabIndex = 1;
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(12, 94);
      Point point4 = point1;
      label2_1.Location = point4;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(56, 13);
      Size size4 = size1;
      label2_2.Size = size4;
      this.Label2.TabIndex = 2;
      this.Label2.Text = "Password:";
      TextBox textBox2_1 = this.TextBox2;
      point1 = new Point(76, 91);
      Point point5 = point1;
      textBox2_1.Location = point5;
      this.TextBox2.Name = "TextBox2";
      TextBox textBox2_2 = this.TextBox2;
      size1 = new Size(248, 20);
      Size size5 = size1;
      textBox2_2.Size = size5;
      this.TextBox2.TabIndex = 3;
      this.Button1.FlatStyle = FlatStyle.Flat;
      Button button1_1 = this.Button1;
      point1 = new Point(145, 164);
      Point point6 = point1;
      button1_1.Location = point6;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(75, 23);
      Size size6 = size1;
      button1_2.Size = size6;
      this.Button1.TabIndex = 4;
      this.Button1.Text = "Login";
      this.Button1.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(368, 226);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.TextBox2);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.TextBox1);
      this.Controls.Add((Control) this.Label1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.TextBox2.PasswordChar = '*';
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.TextBox1.Text, "Green Dragon", false) == 0 & Operators.CompareString(this.TextBox2.Text, "passwrd", false) == 0)
      {
        int num = (int) Interaction.MsgBox((object) "Successful Login!", MsgBoxStyle.OkOnly, (object) "");
        ((Control) MyProject.Forms.Form2).Show();
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Failed Login!", MsgBoxStyle.OkOnly, (object) "");
        this.TextBox1.Clear();
        this.TextBox2.Clear();
      }
    }
  }
}
