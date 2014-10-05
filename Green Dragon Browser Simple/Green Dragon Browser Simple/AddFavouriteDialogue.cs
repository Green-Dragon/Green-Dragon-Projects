// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.AddFavouriteDialogue
// Assembly: Green Dragon Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d25b577927d337c7
// MVID: 43B6EF03-694B-4A1E-BE9F-3F26039BA1DF
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser Simple.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  [DesignerGenerated]
  public class AddFavouriteDialogue : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("NameTextBox")]
    private TextBox _NameTextBox;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("FavouritesComboBox")]
    private ComboBox _FavouritesComboBox;
    [AccessedThroughProperty("AddButton")]
    private Button _AddButton;
    [AccessedThroughProperty("cancelOperationButton")]
    private Button _cancelOperationButton;
    [AccessedThroughProperty("NewFolderButton")]
    private Button _NewFolderButton;
    private string currentAddress;
    private string currentName;

    internal virtual Label Label4
    {
      [DebuggerNonUserCode] get
      {
        return this._Label4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label4 = value;
      }
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get
      {
        return this._Label3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label3 = value;
      }
    }

    internal virtual TextBox NameTextBox
    {
      [DebuggerNonUserCode] get
      {
        return this._NameTextBox;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._NameTextBox = value;
      }
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get
      {
        return this._Label2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label2 = value;
      }
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get
      {
        return this._Label1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    internal virtual ComboBox FavouritesComboBox
    {
      [DebuggerNonUserCode] get
      {
        return this._FavouritesComboBox;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FavouritesComboBox_SelectedIndexChanged);
        if (this._FavouritesComboBox != null)
          this._FavouritesComboBox.SelectedIndexChanged -= eventHandler;
        this._FavouritesComboBox = value;
        if (this._FavouritesComboBox == null)
          return;
        this._FavouritesComboBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Button AddButton
    {
      [DebuggerNonUserCode] get
      {
        return this._AddButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AddButton_Click);
        if (this._AddButton != null)
          this._AddButton.Click -= eventHandler;
        this._AddButton = value;
        if (this._AddButton == null)
          return;
        this._AddButton.Click += eventHandler;
      }
    }

    internal virtual Button cancelOperationButton
    {
      [DebuggerNonUserCode] get
      {
        return this._cancelOperationButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cancelOperationButton = value;
      }
    }

    internal virtual Button NewFolderButton
    {
      [DebuggerNonUserCode] get
      {
        return this._NewFolderButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.NewFolderButton_Click);
        if (this._NewFolderButton != null)
          this._NewFolderButton.Click -= eventHandler;
        this._NewFolderButton = value;
        if (this._NewFolderButton == null)
          return;
        this._NewFolderButton.Click += eventHandler;
      }
    }

    [DebuggerNonUserCode]
    static AddFavouriteDialogue()
    {
    }

    public AddFavouriteDialogue(string currentAddress, string currentName)
    {
      this.Load += new EventHandler(this.AddFavouriteDialogue_Load);
      AddFavouriteDialogue.__ENCAddToList((object) this);
      this.InitializeComponent();
      this.currentAddress = currentAddress;
      this.currentName = currentName;
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      List<WeakReference> list = AddFavouriteDialogue.__ENCList;
      Monitor.Enter((object) list);
      try
      {
        if (AddFavouriteDialogue.__ENCList.Count == AddFavouriteDialogue.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (AddFavouriteDialogue.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (AddFavouriteDialogue.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                AddFavouriteDialogue.__ENCList[index1] = AddFavouriteDialogue.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          AddFavouriteDialogue.__ENCList.RemoveRange(index1, checked (AddFavouriteDialogue.__ENCList.Count - index1));
          AddFavouriteDialogue.__ENCList.Capacity = AddFavouriteDialogue.__ENCList.Count;
        }
        AddFavouriteDialogue.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddFavouriteDialogue));
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.NameTextBox = new TextBox();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.FavouritesComboBox = new ComboBox();
      this.AddButton = new Button();
      this.cancelOperationButton = new Button();
      this.NewFolderButton = new Button();
      this.SuspendLayout();
      Label label4_1 = this.Label4;
      Point point1 = new Point(83, 41);
      Point point2 = point1;
      label4_1.Location = point2;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      Size size1 = new Size(261, 32);
      Size size2 = size1;
      label4_2.Size = size2;
      this.Label4.TabIndex = 17;
      this.Label4.Text = "Add this webpage as a favourite.  To access your favourites, visit the Favourites Center";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label3_1 = this.Label3;
      point1 = new Point(83, 17);
      Point point3 = point1;
      label3_1.Location = point3;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(97, 13);
      Size size3 = size1;
      label3_2.Size = size3;
      this.Label3.TabIndex = 16;
      this.Label3.Text = "Add a Favourite";
      TextBox nameTextBox1 = this.NameTextBox;
      point1 = new Point(86, 76);
      Point point4 = point1;
      nameTextBox1.Location = point4;
      this.NameTextBox.Name = "NameTextBox";
      TextBox nameTextBox2 = this.NameTextBox;
      size1 = new Size(258, 20);
      Size size4 = size1;
      nameTextBox2.Size = size4;
      this.NameTextBox.TabIndex = 15;
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(16, 79);
      Point point5 = point1;
      label2_1.Location = point5;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(38, 13);
      Size size5 = size1;
      label2_2.Size = size5;
      this.Label2.TabIndex = 14;
      this.Label2.Text = "Name:";
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(16, 107);
      Point point6 = point1;
      label1_1.Location = point6;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(52, 13);
      Size size6 = size1;
      label1_2.Size = size6;
      this.Label1.TabIndex = 13;
      this.Label1.Text = "Create in:";
      this.FavouritesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      this.FavouritesComboBox.FormattingEnabled = true;
      this.FavouritesComboBox.Items.AddRange(new object[1]
      {
        (object) "Favourites"
      });
      ComboBox favouritesComboBox1 = this.FavouritesComboBox;
      point1 = new Point(86, 102);
      Point point7 = point1;
      favouritesComboBox1.Location = point7;
      this.FavouritesComboBox.Name = "FavouritesComboBox";
      ComboBox favouritesComboBox2 = this.FavouritesComboBox;
      size1 = new Size(177, 21);
      Size size7 = size1;
      favouritesComboBox2.Size = size7;
      this.FavouritesComboBox.TabIndex = 12;
      this.AddButton.DialogResult = DialogResult.OK;
      Button addButton1 = this.AddButton;
      point1 = new Point(188, 131);
      Point point8 = point1;
      addButton1.Location = point8;
      this.AddButton.Name = "AddButton";
      Button addButton2 = this.AddButton;
      size1 = new Size(75, 23);
      Size size8 = size1;
      addButton2.Size = size8;
      this.AddButton.TabIndex = 11;
      this.AddButton.Text = "Add";
      this.AddButton.UseVisualStyleBackColor = true;
      this.cancelOperationButton.DialogResult = DialogResult.Cancel;
      Button cancelOperationButton1 = this.cancelOperationButton;
      point1 = new Point(269, 132);
      Point point9 = point1;
      cancelOperationButton1.Location = point9;
      this.cancelOperationButton.Name = "cancelOperationButton";
      Button cancelOperationButton2 = this.cancelOperationButton;
      size1 = new Size(75, 23);
      Size size9 = size1;
      cancelOperationButton2.Size = size9;
      this.cancelOperationButton.TabIndex = 10;
      this.cancelOperationButton.Text = "Cancel";
      this.cancelOperationButton.UseVisualStyleBackColor = true;
      Button newFolderButton1 = this.NewFolderButton;
      point1 = new Point(269, 102);
      Point point10 = point1;
      newFolderButton1.Location = point10;
      this.NewFolderButton.Name = "NewFolderButton";
      Button newFolderButton2 = this.NewFolderButton;
      size1 = new Size(75, 23);
      Size size10 = size1;
      newFolderButton2.Size = size10;
      this.NewFolderButton.TabIndex = 9;
      this.NewFolderButton.Text = "New Folder";
      this.NewFolderButton.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.AddButton;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.cancelOperationButton;
      size1 = new Size(361, 172);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.NameTextBox);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.FavouritesComboBox);
      this.Controls.Add((Control) this.AddButton);
      this.Controls.Add((Control) this.cancelOperationButton);
      this.Controls.Add((Control) this.NewFolderButton);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AddFavouriteDialogue";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Add A Favourite";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern int WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

    private void AddFavouriteDialogue_Load(object sender, EventArgs e)
    {
      string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Favorites));
      int index = 0;
      while (index < directories.Length)
      {
        string path = directories[index];
        DirectoryInfo directoryInfo = new DirectoryInfo(path);
        this.FavouritesComboBox.Items.Add((object) new FavouriteDirectoryInfo()
        {
          DirectoryName = directoryInfo.Name,
          FullPath = path
        });
        checked { ++index; }
      }
      this.NameTextBox.Text = this.currentName;
      this.FavouritesComboBox.SelectedIndex = 0;
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.NameTextBox.Text, string.Empty, false) == 0)
      {
        int num1 = (int) MessageBox.Show("You must provide a Display Name for the Favourite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
      }
      else if (Operators.CompareString(this.currentAddress, string.Empty, false) == 0)
      {
        int num2 = (int) MessageBox.Show("You must provide a Url for the Favourite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
      }
      else
      {
        Uri result = (Uri) null;
        if (!Uri.TryCreate(this.currentAddress, UriKind.RelativeOrAbsolute, out result))
        {
          int num3 = (int) MessageBox.Show("Please provide a valid Url", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        }
        else
        {
          string lpFileName = Operators.CompareString(this.FavouritesComboBox.Text, "Favourites", false) != 0 ? Path.Combine(((FavouriteDirectoryInfo) this.FavouritesComboBox.SelectedItem).FullPath, this.NameTextBox.Text + ".url") : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Favorites), this.NameTextBox.Text + ".url");
          AddFavouriteDialogue.WritePrivateProfileString("InternetShortcut", "URL", result.ToString(), lpFileName);
        }
      }
    }

    private void NewFolderButton_Click(object sender, EventArgs e)
    {
      using (CreateFolderDialogue createFolderDialogue = new CreateFolderDialogue())
      {
        int num = (int) createFolderDialogue.ShowDialog();
        if (createFolderDialogue.DialogResult != DialogResult.OK)
          return;
        this.FavouritesComboBox.Items.Add((object) createFolderDialogue.newFavouriteDirectoryInfo);
        this.FavouritesComboBox.SelectedIndex = checked (this.FavouritesComboBox.Items.Count - 1);
      }
    }

    private void FavouritesComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
  }
}
