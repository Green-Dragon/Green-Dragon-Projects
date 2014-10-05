// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.OptionsDialogue
// Assembly: Green Dragon Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d25b577927d337c7
// MVID: 43B6EF03-694B-4A1E-BE9F-3F26039BA1DF
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser Simple.exe

using Green_Dragon_Browser.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  [DesignerGenerated]
  internal class OptionsDialogue : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("homePageText")]
    private TextBox _homePageText;
    [AccessedThroughProperty("startupWithHomePageToggle")]
    private CheckBox _startupWithHomePageToggle;
    private string currentAddress;

    private virtual TextBox homePageText
    {
      [DebuggerNonUserCode] get
      {
        return this._homePageText;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._homePageText = value;
      }
    }

    private virtual CheckBox startupWithHomePageToggle
    {
      [DebuggerNonUserCode] get
      {
        return this._startupWithHomePageToggle;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._startupWithHomePageToggle = value;
      }
    }

    [DebuggerNonUserCode]
    static OptionsDialogue()
    {
    }

    public OptionsDialogue(string currentAddress)
    {
      this.Load += new EventHandler(this.OptionsDialogue_Load);
      OptionsDialogue.__ENCAddToList((object) this);
      this.InitializeComponent();
      this.currentAddress = currentAddress;
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      List<WeakReference> list = OptionsDialogue.__ENCList;
      Monitor.Enter((object) list);
      try
      {
        if (OptionsDialogue.__ENCList.Count == OptionsDialogue.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (OptionsDialogue.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (OptionsDialogue.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                OptionsDialogue.__ENCList[index1] = OptionsDialogue.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          OptionsDialogue.__ENCList.RemoveRange(index1, checked (OptionsDialogue.__ENCList.Count - index1));
          OptionsDialogue.__ENCList.Capacity = OptionsDialogue.__ENCList.Count;
        }
        OptionsDialogue.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
      finally
      {
        Monitor.Exit((object) list);
      }
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if ((!disposing || this.components == null) && !false)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (OptionsDialogue));
      this.homePageText = new TextBox();
      this.startupWithHomePageToggle = new CheckBox();
      Label label1 = new Label();
      Button button1 = new Button();
      Button button2 = new Button();
      Button button3 = new Button();
      Button button4 = new Button();
      this.SuspendLayout();
      label1.AutoSize = true;
      Label label2 = label1;
      Point point1 = new Point(12, 15);
      Point point2 = point1;
      label2.Location = point2;
      label1.Name = "homePageLabel";
      Label label3 = label1;
      Size size1 = new Size(66, 13);
      Size size2 = size1;
      label3.Size = size2;
      label1.TabIndex = 0;
      label1.Text = "&Home Page:";
      this.homePageText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TextBox homePageText1 = this.homePageText;
      point1 = new Point(84, 12);
      Point point3 = point1;
      homePageText1.Location = point3;
      this.homePageText.Name = "homePageText";
      TextBox homePageText2 = this.homePageText;
      size1 = new Size(250, 20);
      Size size3 = size1;
      homePageText2.Size = size3;
      this.homePageText.TabIndex = 1;
      Button button5 = button1;
      point1 = new Point(84, 38);
      Point point4 = point1;
      button5.Location = point4;
      button1.Name = "useCurrentAsHomePageButton";
      Button button6 = button1;
      size1 = new Size(75, 23);
      Size size4 = size1;
      button6.Size = size4;
      button1.TabIndex = 2;
      button1.Text = "Use &Current";
      button1.UseVisualStyleBackColor = true;
      button1.Click += new EventHandler(this.useCurrentAsHomePageButton_Click);
      Button button7 = button2;
      point1 = new Point(168, 38);
      Point point5 = point1;
      button7.Location = point5;
      button2.Name = "useBlankAsHomePageButton";
      Button button8 = button2;
      size1 = new Size(75, 23);
      Size size5 = size1;
      button8.Size = size5;
      button2.TabIndex = 3;
      button2.Text = "Use &Blank";
      button2.UseVisualStyleBackColor = true;
      button2.Click += new EventHandler(this.useBlankAsHomePageButton_Click);
      this.startupWithHomePageToggle.AutoSize = true;
      CheckBox withHomePageToggle1 = this.startupWithHomePageToggle;
      point1 = new Point(84, 67);
      Point point6 = point1;
      withHomePageToggle1.Location = point6;
      this.startupWithHomePageToggle.Name = "startupWithHomePageToggle";
      CheckBox withHomePageToggle2 = this.startupWithHomePageToggle;
      size1 = new Size(153, 17);
      Size size6 = size1;
      withHomePageToggle2.Size = size6;
      this.startupWithHomePageToggle.TabIndex = 5;
      this.startupWithHomePageToggle.Text = "&Load home page at startup";
      this.startupWithHomePageToggle.UseVisualStyleBackColor = true;
      button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      button3.DialogResult = DialogResult.OK;
      Button button9 = button3;
      point1 = new Point(178, 90);
      Point point7 = point1;
      button9.Location = point7;
      button3.Name = "okButton";
      Button button10 = button3;
      size1 = new Size(75, 23);
      Size size7 = size1;
      button10.Size = size7;
      button3.TabIndex = 6;
      button3.Text = "OK";
      button3.UseVisualStyleBackColor = true;
      button3.Click += new EventHandler(this.okButton_Click);
      button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      button4.DialogResult = DialogResult.Cancel;
      Button button11 = button4;
      point1 = new Point(259, 90);
      Point point8 = point1;
      button11.Location = point8;
      button4.Name = "cancelOperationButton";
      Button button12 = button4;
      size1 = new Size(75, 23);
      Size size8 = size1;
      button12.Size = size8;
      button4.TabIndex = 7;
      button4.Text = "Cancel";
      button4.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) button3;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) button4;
      size1 = new Size(346, 125);
      this.ClientSize = size1;
      this.Controls.Add((Control) button4);
      this.Controls.Add((Control) button3);
      this.Controls.Add((Control) this.startupWithHomePageToggle);
      this.Controls.Add((Control) button2);
      this.Controls.Add((Control) button1);
      this.Controls.Add((Control) this.homePageText);
      this.Controls.Add((Control) label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OptionsDialogue";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Options";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void OptionsDialogue_Load(object sender, EventArgs e)
    {
      this.homePageText.Text = MySettingsProperty.Settings.HomePage;
      this.startupWithHomePageToggle.Checked = MySettingsProperty.Settings.StartWithHomePage;
    }

    private void useCurrentAsHomePageButton_Click(object sender, EventArgs e)
    {
      this.homePageText.Text = this.currentAddress;
    }

    private void useBlankAsHomePageButton_Click(object sender, EventArgs e)
    {
      this.homePageText.Clear();
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      MySettingsProperty.Settings.HomePage = this.homePageText.Text;
      MySettingsProperty.Settings.StartWithHomePage = this.startupWithHomePageToggle.Checked;
    }
  }
}
