// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.CreateFolderDialogue
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
using System.Threading;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  [DesignerGenerated]
  public class CreateFolderDialogue : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("cancelOperationButton")]
    private Button _cancelOperationButton;
    [AccessedThroughProperty("CreateButton")]
    private Button _CreateButton;
    [AccessedThroughProperty("FolderNameTextBox")]
    private TextBox _FolderNameTextBox;
    [AccessedThroughProperty("FavouritesComboBox")]
    private ComboBox _FavouritesComboBox;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    public FavouriteDirectoryInfo newFavouriteDirectoryInfo;

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

    internal virtual Button CreateButton
    {
      [DebuggerNonUserCode] get
      {
        return this._CreateButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CreateButton_Click);
        if (this._CreateButton != null)
          this._CreateButton.Click -= eventHandler;
        this._CreateButton = value;
        if (this._CreateButton == null)
          return;
        this._CreateButton.Click += eventHandler;
      }
    }

    internal virtual TextBox FolderNameTextBox
    {
      [DebuggerNonUserCode] get
      {
        return this._FolderNameTextBox;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._FolderNameTextBox = value;
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
        this._FavouritesComboBox = value;
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

    [DebuggerNonUserCode]
    static CreateFolderDialogue()
    {
    }

    [DebuggerNonUserCode]
    public CreateFolderDialogue()
    {
      this.Load += new EventHandler(this.CreateFolderDialogue_Load);
      CreateFolderDialogue.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      List<WeakReference> list = CreateFolderDialogue.__ENCList;
      Monitor.Enter((object) list);
      try
      {
        if (CreateFolderDialogue.__ENCList.Count == CreateFolderDialogue.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (CreateFolderDialogue.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (CreateFolderDialogue.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                CreateFolderDialogue.__ENCList[index1] = CreateFolderDialogue.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          CreateFolderDialogue.__ENCList.RemoveRange(index1, checked (CreateFolderDialogue.__ENCList.Count - index1));
          CreateFolderDialogue.__ENCList.Capacity = CreateFolderDialogue.__ENCList.Count;
        }
        CreateFolderDialogue.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CreateFolderDialogue));
      this.cancelOperationButton = new Button();
      this.CreateButton = new Button();
      this.FolderNameTextBox = new TextBox();
      this.FavouritesComboBox = new ComboBox();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.SuspendLayout();
      this.cancelOperationButton.DialogResult = DialogResult.Cancel;
      Button cancelOperationButton1 = this.cancelOperationButton;
      Point point1 = new Point(186, 67);
      Point point2 = point1;
      cancelOperationButton1.Location = point2;
      this.cancelOperationButton.Name = "cancelOperationButton";
      Button cancelOperationButton2 = this.cancelOperationButton;
      Size size1 = new Size(75, 23);
      Size size2 = size1;
      cancelOperationButton2.Size = size2;
      this.cancelOperationButton.TabIndex = 11;
      this.cancelOperationButton.Text = "Cancel";
      this.cancelOperationButton.UseVisualStyleBackColor = true;
      this.CreateButton.DialogResult = DialogResult.OK;
      Button createButton1 = this.CreateButton;
      point1 = new Point(105, 67);
      Point point3 = point1;
      createButton1.Location = point3;
      this.CreateButton.Name = "CreateButton";
      Button createButton2 = this.CreateButton;
      size1 = new Size(75, 23);
      Size size3 = size1;
      createButton2.Size = size3;
      this.CreateButton.TabIndex = 10;
      this.CreateButton.Text = "Create";
      this.CreateButton.UseVisualStyleBackColor = true;
      TextBox folderNameTextBox1 = this.FolderNameTextBox;
      point1 = new Point(88, 14);
      Point point4 = point1;
      folderNameTextBox1.Location = point4;
      this.FolderNameTextBox.Name = "FolderNameTextBox";
      TextBox folderNameTextBox2 = this.FolderNameTextBox;
      size1 = new Size(173, 20);
      Size size4 = size1;
      folderNameTextBox2.Size = size4;
      this.FolderNameTextBox.TabIndex = 9;
      this.FavouritesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      this.FavouritesComboBox.FormattingEnabled = true;
      this.FavouritesComboBox.Items.AddRange(new object[1]
      {
        (object) "Favourites"
      });
      ComboBox favouritesComboBox1 = this.FavouritesComboBox;
      point1 = new Point(88, 40);
      Point point5 = point1;
      favouritesComboBox1.Location = point5;
      this.FavouritesComboBox.Name = "FavouritesComboBox";
      ComboBox favouritesComboBox2 = this.FavouritesComboBox;
      size1 = new Size(173, 21);
      Size size5 = size1;
      favouritesComboBox2.Size = size5;
      this.FavouritesComboBox.TabIndex = 8;
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(12, 43);
      Point point6 = point1;
      label2_1.Location = point6;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(52, 13);
      Size size6 = size1;
      label2_2.Size = size6;
      this.Label2.TabIndex = 7;
      this.Label2.Text = "Create in:";
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(12, 17);
      Point point7 = point1;
      label1_1.Location = point7;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(70, 13);
      Size size7 = size1;
      label1_2.Size = size7;
      this.Label1.TabIndex = 6;
      this.Label1.Text = "Folder Name:";
      this.AcceptButton = (IButtonControl) this.CreateButton;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.cancelOperationButton;
      size1 = new Size(273, 105);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.cancelOperationButton);
      this.Controls.Add((Control) this.CreateButton);
      this.Controls.Add((Control) this.FolderNameTextBox);
      this.Controls.Add((Control) this.FavouritesComboBox);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CreateFolderDialogue";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Create Folder";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void CreateFolderDialogue_Load(object sender, EventArgs e)
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
      this.FavouritesComboBox.SelectedIndex = 0;
    }

    private void CreateButton_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.FolderNameTextBox.Text, string.Empty, false) == 0)
      {
        int num = (int) MessageBox.Show("You must provide a Name for the new folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
      }
      else
      {
        this.newFavouriteDirectoryInfo = new FavouriteDirectoryInfo();
        this.newFavouriteDirectoryInfo.DirectoryName = this.FolderNameTextBox.Text;
        if (Operators.CompareString(this.FavouritesComboBox.Text, "Favourites", false) == 0)
        {
          this.newFavouriteDirectoryInfo.FullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Favorites), this.FolderNameTextBox.Text);
        }
        else
        {
          FavouriteDirectoryInfo favouriteDirectoryInfo = (FavouriteDirectoryInfo) this.FavouritesComboBox.SelectedItem;
          this.newFavouriteDirectoryInfo.FullPath = Path.Combine(this.newFavouriteDirectoryInfo.FullPath, this.FolderNameTextBox.Text);
        }
        Directory.CreateDirectory(this.newFavouriteDirectoryInfo.FullPath);
      }
    }
  }
}
