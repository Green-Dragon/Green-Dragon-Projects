// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Photo.FrmPhoto
// Assembly: Green Dragon Photo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2417A2D4-86EC-4631-843E-52B32AEBFCAB
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Photo.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Green_Dragon_Photo
{
  public class FrmPhoto : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private string extension;
    private Image undoImage;
    private IContainer components;
    [AccessedThroughProperty("MyPicture")]
    private PictureBox _MyPicture;
    [AccessedThroughProperty("MnuFile")]
    private MenuItem _MnuFile;
    [AccessedThroughProperty("MnuSaveAs")]
    private MenuItem _MnuSaveAs;
    [AccessedThroughProperty("MnuSave")]
    private MenuItem _MnuSave;
    [AccessedThroughProperty("MainMenu1")]
    private MainMenu _MainMenu1;
    [AccessedThroughProperty("MenuItem1")]
    private MenuItem _MenuItem1;
    [AccessedThroughProperty("SaveFileDialog1")]
    private SaveFileDialog _SaveFileDialog1;
    [AccessedThroughProperty("MenuItem2")]
    private MenuItem _MenuItem2;
    [AccessedThroughProperty("MenuItem6")]
    private MenuItem _MenuItem6;
    [AccessedThroughProperty("MenuItem8")]
    private MenuItem _MenuItem8;
    [AccessedThroughProperty("MenuItem9")]
    private MenuItem _MenuItem9;
    [AccessedThroughProperty("MnuCopy")]
    private MenuItem _MnuCopy;
    [AccessedThroughProperty("MnuCut")]
    private MenuItem _MnuCut;
    [AccessedThroughProperty("MnuPaste")]
    private MenuItem _MnuPaste;
    [AccessedThroughProperty("MnuClose")]
    private MenuItem _MnuClose;
    [AccessedThroughProperty("MnuZoom")]
    private MenuItem _MnuZoom;
    [AccessedThroughProperty("MnuZoomAuto")]
    private MenuItem _MnuZoomAuto;
    [AccessedThroughProperty("MnuZoom200")]
    private MenuItem _MnuZoom200;
    [AccessedThroughProperty("MnuZoom100")]
    private MenuItem _MnuZoom100;
    [AccessedThroughProperty("MnuZoom75")]
    private MenuItem _MnuZoom75;
    [AccessedThroughProperty("MnuZoom50")]
    private MenuItem _MnuZoom50;
    [AccessedThroughProperty("MnuZoom25")]
    private MenuItem _MnuZoom25;
    [AccessedThroughProperty("MnuRotateLeft")]
    private MenuItem _MnuRotateLeft;
    [AccessedThroughProperty("MnuRotateRight")]
    private MenuItem _MnuRotateRight;
    [AccessedThroughProperty("MnuFlipHorizontally")]
    private MenuItem _MnuFlipHorizontally;
    [AccessedThroughProperty("MnuFlipVertically")]
    private MenuItem _MnuFlipVertically;
    [AccessedThroughProperty("MnuEmboss")]
    private MenuItem _MnuEmboss;
    [AccessedThroughProperty("MnuSharpen")]
    private MenuItem _MnuSharpen;
    [AccessedThroughProperty("MnuSmooth")]
    private MenuItem _MnuSmooth;
    [AccessedThroughProperty("MnuDiffuse")]
    private MenuItem _MnuDiffuse;
    [AccessedThroughProperty("MnuUndo")]
    private MenuItem _MnuUndo;
    [AccessedThroughProperty("MenuItem4")]
    private MenuItem _MenuItem4;

    internal virtual PictureBox MyPicture
    {
      [DebuggerNonUserCode] get
      {
        return this._MyPicture;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MyPicture = value;
      }
    }

    internal virtual MenuItem MnuFile
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuFile;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MnuFile = value;
      }
    }

    internal virtual MenuItem MnuSaveAs
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuSaveAs;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuSaveAs_Click);
        if (this._MnuSaveAs != null)
          this._MnuSaveAs.Click -= eventHandler;
        this._MnuSaveAs = value;
        if (this._MnuSaveAs == null)
          return;
        this._MnuSaveAs.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuSave
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuSave;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuSave_Click);
        if (this._MnuSave != null)
          this._MnuSave.Click -= eventHandler;
        this._MnuSave = value;
        if (this._MnuSave == null)
          return;
        this._MnuSave.Click += eventHandler;
      }
    }

    private virtual MainMenu MainMenu1
    {
      [DebuggerNonUserCode] get
      {
        return this._MainMenu1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MainMenu1 = value;
      }
    }

    internal virtual MenuItem MenuItem1
    {
      [DebuggerNonUserCode] get
      {
        return this._MenuItem1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MenuItem1 = value;
      }
    }

    internal virtual SaveFileDialog SaveFileDialog1
    {
      [DebuggerNonUserCode] get
      {
        return this._SaveFileDialog1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._SaveFileDialog1 = value;
      }
    }

    internal virtual MenuItem MenuItem2
    {
      [DebuggerNonUserCode] get
      {
        return this._MenuItem2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MenuItem2 = value;
      }
    }

    internal virtual MenuItem MenuItem6
    {
      [DebuggerNonUserCode] get
      {
        return this._MenuItem6;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MenuItem6 = value;
      }
    }

    internal virtual MenuItem MenuItem8
    {
      [DebuggerNonUserCode] get
      {
        return this._MenuItem8;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MenuItem8 = value;
      }
    }

    internal virtual MenuItem MenuItem9
    {
      [DebuggerNonUserCode] get
      {
        return this._MenuItem9;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MenuItem9 = value;
      }
    }

    internal virtual MenuItem MnuCopy
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuCopy;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuCopy_Click);
        if (this._MnuCopy != null)
          this._MnuCopy.Click -= eventHandler;
        this._MnuCopy = value;
        if (this._MnuCopy == null)
          return;
        this._MnuCopy.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuCut
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuCut;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuCut_Click);
        if (this._MnuCut != null)
          this._MnuCut.Click -= eventHandler;
        this._MnuCut = value;
        if (this._MnuCut == null)
          return;
        this._MnuCut.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuPaste
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuPaste;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuPaste_Click);
        if (this._MnuPaste != null)
          this._MnuPaste.Click -= eventHandler;
        this._MnuPaste = value;
        if (this._MnuPaste == null)
          return;
        this._MnuPaste.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuClose
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuClose;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuClose_Click);
        if (this._MnuClose != null)
          this._MnuClose.Click -= eventHandler;
        this._MnuClose = value;
        if (this._MnuClose == null)
          return;
        this._MnuClose.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuZoom
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuZoom;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MnuZoom = value;
      }
    }

    internal virtual MenuItem MnuZoomAuto
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuZoomAuto;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuZoomAuto_Click);
        if (this._MnuZoomAuto != null)
          this._MnuZoomAuto.Click -= eventHandler;
        this._MnuZoomAuto = value;
        if (this._MnuZoomAuto == null)
          return;
        this._MnuZoomAuto.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuZoom200
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuZoom200;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuZoom_Click);
        if (this._MnuZoom200 != null)
          this._MnuZoom200.Click -= eventHandler;
        this._MnuZoom200 = value;
        if (this._MnuZoom200 == null)
          return;
        this._MnuZoom200.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuZoom100
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuZoom100;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuZoom_Click);
        if (this._MnuZoom100 != null)
          this._MnuZoom100.Click -= eventHandler;
        this._MnuZoom100 = value;
        if (this._MnuZoom100 == null)
          return;
        this._MnuZoom100.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuZoom75
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuZoom75;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuZoom_Click);
        if (this._MnuZoom75 != null)
          this._MnuZoom75.Click -= eventHandler;
        this._MnuZoom75 = value;
        if (this._MnuZoom75 == null)
          return;
        this._MnuZoom75.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuZoom50
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuZoom50;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuZoom_Click);
        if (this._MnuZoom50 != null)
          this._MnuZoom50.Click -= eventHandler;
        this._MnuZoom50 = value;
        if (this._MnuZoom50 == null)
          return;
        this._MnuZoom50.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuZoom25
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuZoom25;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuZoom_Click);
        if (this._MnuZoom25 != null)
          this._MnuZoom25.Click -= eventHandler;
        this._MnuZoom25 = value;
        if (this._MnuZoom25 == null)
          return;
        this._MnuZoom25.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuRotateLeft
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuRotateLeft;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuRotateLeft_Click);
        if (this._MnuRotateLeft != null)
          this._MnuRotateLeft.Click -= eventHandler;
        this._MnuRotateLeft = value;
        if (this._MnuRotateLeft == null)
          return;
        this._MnuRotateLeft.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuRotateRight
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuRotateRight;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuRotateRight_Click);
        if (this._MnuRotateRight != null)
          this._MnuRotateRight.Click -= eventHandler;
        this._MnuRotateRight = value;
        if (this._MnuRotateRight == null)
          return;
        this._MnuRotateRight.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuFlipHorizontally
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuFlipHorizontally;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuFlipHorizontally_Click);
        if (this._MnuFlipHorizontally != null)
          this._MnuFlipHorizontally.Click -= eventHandler;
        this._MnuFlipHorizontally = value;
        if (this._MnuFlipHorizontally == null)
          return;
        this._MnuFlipHorizontally.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuFlipVertically
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuFlipVertically;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuFlipVertically_Click);
        if (this._MnuFlipVertically != null)
          this._MnuFlipVertically.Click -= eventHandler;
        this._MnuFlipVertically = value;
        if (this._MnuFlipVertically == null)
          return;
        this._MnuFlipVertically.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuEmboss
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuEmboss;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuEmboss_Click);
        if (this._MnuEmboss != null)
          this._MnuEmboss.Click -= eventHandler;
        this._MnuEmboss = value;
        if (this._MnuEmboss == null)
          return;
        this._MnuEmboss.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuSharpen
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuSharpen;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuSharpen_Click);
        if (this._MnuSharpen != null)
          this._MnuSharpen.Click -= eventHandler;
        this._MnuSharpen = value;
        if (this._MnuSharpen == null)
          return;
        this._MnuSharpen.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuSmooth
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuSmooth;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuSmooth_Click);
        if (this._MnuSmooth != null)
          this._MnuSmooth.Click -= eventHandler;
        this._MnuSmooth = value;
        if (this._MnuSmooth == null)
          return;
        this._MnuSmooth.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuDiffuse
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuDiffuse;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuDiffuse_Click);
        if (this._MnuDiffuse != null)
          this._MnuDiffuse.Click -= eventHandler;
        this._MnuDiffuse = value;
        if (this._MnuDiffuse == null)
          return;
        this._MnuDiffuse.Click += eventHandler;
      }
    }

    internal virtual MenuItem MnuUndo
    {
      [DebuggerNonUserCode] get
      {
        return this._MnuUndo;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MnuUndo_Click);
        if (this._MnuUndo != null)
          this._MnuUndo.Click -= eventHandler;
        this._MnuUndo = value;
        if (this._MnuUndo == null)
          return;
        this._MnuUndo.Click += eventHandler;
      }
    }

    internal virtual MenuItem MenuItem4
    {
      [DebuggerNonUserCode] get
      {
        return this._MenuItem4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MenuItem4 = value;
      }
    }

    [DebuggerNonUserCode]
    static FrmPhoto()
    {
    }

    public FrmPhoto()
    {
      this.Load += new EventHandler(this.FrmPhoto_Load);
      this.Enter += new EventHandler(this.FrmPhoto_Enter);
      this.Closing += new CancelEventHandler(this.FrmPhoto_Closing);
      FrmPhoto.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      List<WeakReference> list = FrmPhoto.__ENCList;
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) list, ref lockTaken);
        if (FrmPhoto.__ENCList.Count == FrmPhoto.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (FrmPhoto.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (FrmPhoto.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                FrmPhoto.__ENCList[index1] = FrmPhoto.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          FrmPhoto.__ENCList.RemoveRange(index1, checked (FrmPhoto.__ENCList.Count - index1));
          FrmPhoto.__ENCList.Capacity = FrmPhoto.__ENCList.Count;
        }
        FrmPhoto.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) list);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmPhoto));
      this.MyPicture = new PictureBox();
      this.MainMenu1 = new MainMenu(this.components);
      this.MnuFile = new MenuItem();
      this.MnuSave = new MenuItem();
      this.MnuSaveAs = new MenuItem();
      this.MnuClose = new MenuItem();
      this.MenuItem1 = new MenuItem();
      this.MenuItem2 = new MenuItem();
      this.MnuUndo = new MenuItem();
      this.MenuItem4 = new MenuItem();
      this.MnuCopy = new MenuItem();
      this.MnuCut = new MenuItem();
      this.MnuPaste = new MenuItem();
      this.MenuItem6 = new MenuItem();
      this.MnuZoom = new MenuItem();
      this.MnuZoomAuto = new MenuItem();
      this.MnuZoom200 = new MenuItem();
      this.MnuZoom100 = new MenuItem();
      this.MnuZoom75 = new MenuItem();
      this.MnuZoom50 = new MenuItem();
      this.MnuZoom25 = new MenuItem();
      this.MenuItem8 = new MenuItem();
      this.MnuRotateLeft = new MenuItem();
      this.MnuRotateRight = new MenuItem();
      this.MnuFlipHorizontally = new MenuItem();
      this.MnuFlipVertically = new MenuItem();
      this.MenuItem9 = new MenuItem();
      this.MnuEmboss = new MenuItem();
      this.MnuSharpen = new MenuItem();
      this.MnuSmooth = new MenuItem();
      this.MnuDiffuse = new MenuItem();
      this.SaveFileDialog1 = new SaveFileDialog();
      ((ISupportInitialize) this.MyPicture).BeginInit();
      this.SuspendLayout();
      this.MyPicture.BorderStyle = BorderStyle.FixedSingle;
      this.MyPicture.Location = new Point(4, 4);
      this.MyPicture.Name = "MyPicture";
      PictureBox myPicture = this.MyPicture;
      Size size1 = new Size(283, 43);
      Size size2 = size1;
      myPicture.Size = size2;
      this.MyPicture.SizeMode = PictureBoxSizeMode.AutoSize;
      this.MyPicture.TabIndex = 0;
      this.MyPicture.TabStop = false;
      this.MyPicture.Visible = false;
      this.MainMenu1.MenuItems.AddRange(new MenuItem[3]
      {
        this.MnuFile,
        this.MenuItem2,
        this.MenuItem6
      });
      this.MnuFile.Index = 0;
      this.MnuFile.MenuItems.AddRange(new MenuItem[4]
      {
        this.MnuSave,
        this.MnuSaveAs,
        this.MnuClose,
        this.MenuItem1
      });
      this.MnuFile.MergeType = MenuMerge.MergeItems;
      this.MnuFile.Text = "File";
      this.MnuSave.Enabled = false;
      this.MnuSave.Index = 0;
      this.MnuSave.Text = "Save";
      this.MnuSaveAs.Index = 1;
      this.MnuSaveAs.Text = "Save as...";
      this.MnuClose.Index = 2;
      this.MnuClose.Text = "Close Image";
      this.MenuItem1.Index = 3;
      this.MenuItem1.Text = "-";
      this.MenuItem2.Index = 1;
      this.MenuItem2.MenuItems.AddRange(new MenuItem[5]
      {
        this.MnuUndo,
        this.MenuItem4,
        this.MnuCopy,
        this.MnuCut,
        this.MnuPaste
      });
      this.MenuItem2.Text = "Edit";
      this.MnuUndo.Enabled = false;
      this.MnuUndo.Index = 0;
      this.MnuUndo.Text = "Undo";
      this.MenuItem4.Index = 1;
      this.MenuItem4.Text = "-";
      this.MnuCopy.Index = 2;
      this.MnuCopy.Text = "Copy";
      this.MnuCut.Index = 3;
      this.MnuCut.Text = "Cut";
      this.MnuPaste.Enabled = false;
      this.MnuPaste.Index = 4;
      this.MnuPaste.Text = "Paste";
      this.MenuItem6.Index = 2;
      this.MenuItem6.MenuItems.AddRange(new MenuItem[3]
      {
        this.MnuZoom,
        this.MenuItem8,
        this.MenuItem9
      });
      this.MenuItem6.Text = "Image Options";
      this.MnuZoom.Index = 0;
      this.MnuZoom.MenuItems.AddRange(new MenuItem[6]
      {
        this.MnuZoomAuto,
        this.MnuZoom200,
        this.MnuZoom100,
        this.MnuZoom75,
        this.MnuZoom50,
        this.MnuZoom25
      });
      this.MnuZoom.Text = "Zoom";
      this.MnuZoomAuto.Checked = true;
      this.MnuZoomAuto.Index = 0;
      this.MnuZoomAuto.Text = "Auto";
      this.MnuZoom200.Index = 1;
      this.MnuZoom200.Text = "200%";
      this.MnuZoom100.Index = 2;
      this.MnuZoom100.Text = "100%";
      this.MnuZoom75.Index = 3;
      this.MnuZoom75.Text = "75%";
      this.MnuZoom50.Index = 4;
      this.MnuZoom50.Text = "50%";
      this.MnuZoom25.Index = 5;
      this.MnuZoom25.Text = "25%";
      this.MenuItem8.Index = 1;
      this.MenuItem8.MenuItems.AddRange(new MenuItem[4]
      {
        this.MnuRotateLeft,
        this.MnuRotateRight,
        this.MnuFlipHorizontally,
        this.MnuFlipVertically
      });
      this.MenuItem8.Text = "Rotate";
      this.MnuRotateLeft.Index = 0;
      this.MnuRotateLeft.Text = "Rotate Left";
      this.MnuRotateRight.Index = 1;
      this.MnuRotateRight.Text = "Rotate Right";
      this.MnuFlipHorizontally.Index = 2;
      this.MnuFlipHorizontally.Text = "Flip Horizontally";
      this.MnuFlipVertically.Index = 3;
      this.MnuFlipVertically.Text = "Flip Vertically";
      this.MenuItem9.Index = 2;
      this.MenuItem9.MenuItems.AddRange(new MenuItem[4]
      {
        this.MnuEmboss,
        this.MnuSharpen,
        this.MnuSmooth,
        this.MnuDiffuse
      });
      this.MenuItem9.Text = "Effects";
      this.MnuEmboss.Index = 0;
      this.MnuEmboss.Text = "Emboss";
      this.MnuSharpen.Index = 1;
      this.MnuSharpen.Text = "Sharpen";
      this.MnuSmooth.Index = 2;
      this.MnuSmooth.Text = "Smooth";
      this.MnuDiffuse.Index = 3;
      this.MnuDiffuse.Text = "Diffuse";
      this.SaveFileDialog1.FileName = "image";
      this.SaveFileDialog1.Filter = componentResourceManager.GetString("SaveFileDialog1.Filter");
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      this.AutoScroll = true;
      size1 = new Size(332, 169);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.MyPicture);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Menu = this.MainMenu1;
      this.Name = "FrmPhoto";
      this.Text = "Green Dragon Photo";
      ((ISupportInitialize) this.MyPicture).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void FrmPhoto_Load(object sender, EventArgs e)
    {
      this.Text = Conversions.ToString(this.Tag);
      this.extension = this.Text.Substring(checked (this.Text.IndexOf(".") + 1));
      this.MyPicture.Image = Image.FromFile(Conversions.ToString(this.Tag));
      this.ResizePicture();
      this.SetFormSize();
      this.SetForm();
      this.MyPicture.Visible = true;
      if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Bitmap))
        this.MnuPaste.Enabled = true;
      MDI.status.ShowPanels = true;
    }

    private void FrmPhoto_Enter(object sender, EventArgs e)
    {
      try
      {
        MDI.status.Panels[0].Text = "Size: " + Conversions.ToString(this.MyPicture.Image.Width) + "*" + Conversions.ToString(this.MyPicture.Image.Height);
        MDI.status.Panels[1].Text = "Color Depth: " + Conversions.ToString(Image.GetPixelFormatSize(this.MyPicture.Image.PixelFormat)) + " bpp";
        MDI.status.Panels[2].Text = "Image Resolution: " + Conversions.ToString(checked ((int) Math.Round((double) this.MyPicture.Image.HorizontalResolution))) + "*" + Conversions.ToString(checked ((int) Math.Round((double) this.MyPicture.Image.VerticalResolution)));
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }

    private void MnuClose_Click(object sender, EventArgs e)
    {
      this.MyPicture.Image = (Image) null;
      this.Close();
    }

    private void FrmPhoto_Closing(object sender, CancelEventArgs e)
    {
      if (this.ParentForm.MdiChildren.Length == 1)
        MDI.status.ShowPanels = false;
      this.MyPicture.Image = (Image) null;
    }

    private void ResizePicture()
    {
      if (this.MyPicture.Image.Width < this.MyPicture.Width & this.MyPicture.Image.Height < this.MyPicture.Height)
        this.MyPicture.SizeMode = PictureBoxSizeMode.CenterImage;
      else if (this.MyPicture.Image.Width > this.MyPicture.Image.Height)
        this.MyPicture.Height = checked ((int) Math.Round((double) unchecked ((float) this.MyPicture.Width / (float) this.MyPicture.Image.Width / (float) this.MyPicture.Image.Height)));
      else
        this.MyPicture.Height = checked ((int) Math.Round((double) unchecked ((float) this.MyPicture.Width / (float) this.MyPicture.Image.Height / (float) this.MyPicture.Image.Width)));
    }

    private void SetFormSize()
    {
      if ((double) this.MyPicture.Width < (double) Screen.PrimaryScreen.Bounds.Width * 0.8)
        this.Width = checked (this.MyPicture.Width + 20);
      else
        this.Width = checked ((int) Math.Round(unchecked ((double) Screen.PrimaryScreen.Bounds.Width * 0.8)));
      if ((double) this.MyPicture.Height < (double) Screen.PrimaryScreen.Bounds.Height * 0.75)
        this.Height = checked (this.MyPicture.Height + 40);
      else
        this.Height = checked ((int) Math.Round(unchecked ((double) Screen.PrimaryScreen.Bounds.Height * 0.75)));
    }

    private void SetForm()
    {
      this.Top = checked ((int) Math.Round(unchecked ((double) checked (this.MdiParent.Height - this.Height) / 2.0)));
      this.Left = checked ((int) Math.Round(unchecked ((double) checked (this.MdiParent.Width - this.Width) / 2.0)));
    }

    private void MnuSave_Click(object sender, EventArgs e)
    {
      this.UnsetModified();
      try
      {
        int num = (int) Interaction.MsgBox((object) this.Text, MsgBoxStyle.OkOnly, (object) null);
        this.MyPicture.Image.Save(this.Text);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (ex.Message + "\r\nTry with Save as..."), MsgBoxStyle.Information, (object) "ERROR");
        ProjectData.ClearProjectError();
      }
    }

    private void MnuSaveAs_Click(object sender, EventArgs e)
    {
      string Left = this.extension;
      if (Operators.CompareString(Left, "bmp", false) == 0)
        this.SaveFileDialog1.FilterIndex = 2;
      else if (Operators.CompareString(Left, "emf", false) == 0)
        this.SaveFileDialog1.FilterIndex = 3;
      else if (Operators.CompareString(Left, "exif", false) == 0)
        this.SaveFileDialog1.FilterIndex = 4;
      else if (Operators.CompareString(Left, "gif", false) == 0)
        this.SaveFileDialog1.FilterIndex = 5;
      else if (Operators.CompareString(Left, "ico", false) == 0)
        this.SaveFileDialog1.FilterIndex = 6;
      else if (Operators.CompareString(Left, "jpg", false) == 0)
        this.SaveFileDialog1.FilterIndex = 7;
      else if (Operators.CompareString(Left, "jepg", false) == 0)
        this.SaveFileDialog1.FilterIndex = 7;
      else if (Operators.CompareString(Left, "png", false) == 0)
        this.SaveFileDialog1.FilterIndex = 8;
      else if (Operators.CompareString(Left, "tif", false) == 0)
        this.SaveFileDialog1.FilterIndex = 9;
      else if (Operators.CompareString(Left, "wmf", false) == 0)
        this.SaveFileDialog1.FilterIndex = 10;
      else
        this.SaveFileDialog1.FilterIndex = 1;
      if (this.Text.EndsWith("*"))
        this.Text = this.Text.Substring(0, this.Text.IndexOf("*"));
      this.SaveFileDialog1.FileName = this.Text.Substring(checked (this.Text.LastIndexOf("\\") + 1));
      if (this.SaveFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.MyPicture.Image.Save(this.SaveFileDialog1.FileName);
    }

    private void SetModified()
    {
      if (!Operators.ConditionalCompareObjectNotEqual(this.Tag, (object) "Modified", false))
        return;
      this.Text = this.Text + "*";
      this.MainMenu1.MenuItems[0].MenuItems[0].Enabled = true;
      this.Tag = (object) "Modified";
    }

    private void UnsetModified()
    {
      if (!Operators.ConditionalCompareObjectEqual(this.Tag, (object) "Modified", false))
        return;
      this.Text = this.Text.Substring(0, this.Text.IndexOf("*"));
      this.MainMenu1.MenuItems[0].MenuItems[0].Enabled = false;
      this.Tag = (object) this.Text;
    }

    private void MnuUndo_Click(object sender, EventArgs e)
    {
      this.MnuUndo.Enabled = false;
      this.MyPicture.Image = this.undoImage;
      this.MyPicture.Refresh();
    }

    private void MnuCopy_Click(object sender, EventArgs e)
    {
      Clipboard.SetDataObject((object) this.MyPicture.Image);
      this.MnuPaste.Enabled = true;
    }

    private void MnuPaste_Click(object sender, EventArgs e)
    {
      if (!Clipboard.GetDataObject().GetDataPresent(DataFormats.Bitmap))
        return;
      this.MyPicture.Image = (Image) Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
      this.MnuPaste.Enabled = false;
    }

    private void MnuCut_Click(object sender, EventArgs e)
    {
      Clipboard.SetDataObject((object) this.MyPicture.Image);
      this.MyPicture.CreateGraphics().Clear(Color.White);
      this.MnuPaste.Enabled = true;
    }

    private void MnuZoomAuto_Click(object sender, EventArgs e)
    {
      this.MyPicture.SizeMode = PictureBoxSizeMode.AutoSize;
      this.ResizePicture();
    }

    private void MnuZoom_Click(object sender, EventArgs e)
    {
      this.UncheckZoomMenu();
      this.MyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
      this.MyPicture.Width = checked ((int) Math.Round(unchecked ((double) this.MyPicture.Image.Width * Conversion.Val(((MenuItem) sender).Text) / 100.0)));
      this.MyPicture.Height = checked ((int) Math.Round(unchecked ((double) this.MyPicture.Image.Height * Conversion.Val(((MenuItem) sender).Text) / 100.0)));
      this.SetFormSize();
      this.SetForm();
      ((MenuItem) sender).Checked = true;
    }

    private void UncheckZoomMenu()
    {
      try
      {
        foreach (MenuItem menuItem in this.MainMenu1.MenuItems[2].MenuItems[0].MenuItems)
          menuItem.Checked = false;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void MnuRotateRight_Click(object sender, EventArgs e)
    {
      this.MyPicture.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
      this.MyPicture.Invalidate();
      int width = this.MyPicture.Width;
      this.MyPicture.Width = this.MyPicture.Height;
      this.MyPicture.Height = width;
    }

    private void MnuRotateLeft_Click(object sender, EventArgs e)
    {
      this.MyPicture.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
      this.MyPicture.Invalidate();
      int width = this.MyPicture.Width;
      this.MyPicture.Width = this.MyPicture.Height;
      this.MyPicture.Height = width;
    }

    private void MnuFlipHorizontally_Click(object sender, EventArgs e)
    {
      this.MyPicture.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
      this.MyPicture.Invalidate();
    }

    private void MnuFlipVertically_Click(object sender, EventArgs e)
    {
      this.MyPicture.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
      this.MyPicture.Invalidate();
    }

    private void MnuEmboss_Click(object sender, EventArgs e)
    {
      this.undoImage = this.MyPicture.Image;
      this.MnuUndo.Enabled = true;
      Bitmap bitmap1 = new Bitmap(this.MyPicture.Image);
      this.MyPicture.Image = (Image) bitmap1;
      Bitmap bitmap2 = new Bitmap(this.MyPicture.Image);
      int num1 = 1;
      int num2 = 1;
      Bitmap bitmap3 = bitmap2;
      int num3 = 0;
      int num4 = checked (bitmap3.Height - 2);
      int y = num3;
      while (y <= num4)
      {
        int num5 = 0;
        int num6 = checked (bitmap3.Width - 2);
        int x = num5;
        while (x <= num6)
        {
          Color pixel1 = bitmap3.GetPixel(x, y);
          Color pixel2 = bitmap3.GetPixel(checked (x + num1), checked (y + num2));
          int red = Math.Min(checked (Math.Abs((int) pixel1.R - (int) pixel2.R) + 128), (int) byte.MaxValue);
          int green = Math.Min(checked (Math.Abs((int) pixel1.G - (int) pixel2.G) + 128), (int) byte.MaxValue);
          int blue = Math.Min(checked (Math.Abs((int) pixel1.B - (int) pixel2.B) + 128), (int) byte.MaxValue);
          bitmap1.SetPixel(x, y, Color.FromArgb(red, green, blue));
          checked { ++x; }
        }
        if (y % 10 == 0)
        {
          this.MyPicture.Invalidate();
          this.MyPicture.Refresh();
          this.MyPicture.CreateGraphics().DrawString("Now Processing... " + Conversion.Int((double) checked (100 * y) / (double) checked (this.MyPicture.Image.Height - 2)).ToString() + "%", new Font("Verdana", 12f, FontStyle.Bold), Brushes.White, 10f, 25f);
        }
        checked { ++y; }
      }
      this.MyPicture.Refresh();
      this.SetModified();
    }

    private void MnuSharpen_Click(object sender, EventArgs e)
    {
      this.undoImage = this.MyPicture.Image;
      this.MnuUndo.Enabled = true;
      Bitmap bitmap1 = new Bitmap(this.MyPicture.Image);
      this.MyPicture.Image = (Image) bitmap1;
      Bitmap bitmap2 = new Bitmap(this.MyPicture.Image);
      int num1 = 1;
      int num2 = 1;
      Bitmap bitmap3 = bitmap2;
      int num3 = num1;
      int num4 = checked (bitmap3.Height - num1 - 1);
      int y = num3;
      while (y <= num4)
      {
        int num5 = num2;
        int num6 = checked (bitmap3.Width - num2 - 1);
        int x = num5;
        while (x <= num6)
        {
          Color pixel1 = bitmap3.GetPixel(x, y);
          double num7 = (double) pixel1.R;
          double num8 = 0.5;
          int num9 = (int) bitmap3.GetPixel(x, y).R;
          Color pixel2 = bitmap3.GetPixel(checked (x - num1), checked (y - num2));
          int num10 = (int) pixel2.R;
          double num11 = (double) checked (num9 - num10);
          double num12 = num8 * num11;
          int val1_1 = checked ((int) Math.Round(unchecked (num7 + num12)));
          pixel2 = bitmap3.GetPixel(x, y);
          double num13 = (double) pixel2.G;
          double num14 = 0.7;
          int num15 = (int) bitmap3.GetPixel(x, y).G;
          pixel1 = bitmap3.GetPixel(checked (x - num1), checked (y - num2));
          int num16 = (int) pixel1.G;
          double num17 = (double) checked (num15 - num16);
          double num18 = num14 * num17;
          int val1_2 = checked ((int) Math.Round(unchecked (num13 + num18)));
          pixel2 = bitmap3.GetPixel(x, y);
          double num19 = (double) pixel2.B;
          double num20 = 0.5;
          int num21 = (int) bitmap3.GetPixel(x, y).B;
          pixel1 = bitmap3.GetPixel(checked (x - num1), checked (y - num2));
          int num22 = (int) pixel1.B;
          double num23 = (double) checked (num21 - num22);
          double num24 = num20 * num23;
          int val1_3 = checked ((int) Math.Round(unchecked (num19 + num24)));
          int red = Math.Min(Math.Max(val1_1, 0), (int) byte.MaxValue);
          int green = Math.Min(Math.Max(val1_2, 0), (int) byte.MaxValue);
          int blue = Math.Min(Math.Max(val1_3, 0), (int) byte.MaxValue);
          bitmap1.SetPixel(x, y, Color.FromArgb(red, green, blue));
          checked { ++x; }
        }
        if (y % 10 == 0)
        {
          this.MyPicture.Invalidate();
          this.MyPicture.Refresh();
          this.MyPicture.CreateGraphics().DrawString("Now Processing... " + Conversion.Int((double) checked (100 * y) / (double) checked (this.MyPicture.Image.Height - 2)).ToString() + "%", new Font("Verdana", 12f, FontStyle.Bold), Brushes.White, 10f, 25f);
        }
        checked { ++y; }
      }
      this.MyPicture.Refresh();
      this.SetModified();
    }

    private void MnuSmooth_Click(object sender, EventArgs e)
    {
      this.undoImage = this.MyPicture.Image;
      this.MnuUndo.Enabled = true;
      Bitmap bitmap1 = new Bitmap(this.MyPicture.Image);
      this.MyPicture.Image = (Image) bitmap1;
      Bitmap bitmap2 = new Bitmap(this.MyPicture.Image);
      int num1 = 1;
      int num2 = 1;
      Bitmap bitmap3 = bitmap2;
      int num3 = num1;
      int num4 = checked (bitmap3.Height - num1 - 1);
      int y = num3;
      while (y <= num4)
      {
        int num5 = num2;
        int num6 = checked (bitmap3.Width - num2 - 1);
        int x = num5;
        while (x <= num6)
        {
          Color pixel1 = bitmap3.GetPixel(checked (x - 1), checked (y - 1));
          int num7 = checked ((int) pixel1.R + (int) bitmap3.GetPixel(x - 1, y).R + (int) bitmap3.GetPixel(x - 1, y + 1).R);
          Color pixel2 = bitmap3.GetPixel(x, checked (y - 1));
          int num8 = (int) pixel2.R;
          int val1_1 = checked ((int) Math.Round(unchecked ((double) checked (num7 + num8 + (int) bitmap3.GetPixel(x, y).R + (int) bitmap3.GetPixel(x, y + 1).R + (int) bitmap3.GetPixel(x + 1, y - 1).R + (int) bitmap3.GetPixel(x + 1, y).R + (int) bitmap3.GetPixel(x + 1, y + 1).R) / 9.0)));
          int num9 = checked ((int) bitmap3.GetPixel(x - 1, y - 1).G + (int) bitmap3.GetPixel(x - 1, y).G + (int) bitmap3.GetPixel(x - 1, y + 1).G + (int) bitmap3.GetPixel(x, y - 1).G + (int) bitmap3.GetPixel(x, y).G);
          pixel2 = bitmap3.GetPixel(x, checked (y + 1));
          int num10 = (int) pixel2.G;
          int num11 = checked (num9 + num10 + (int) bitmap3.GetPixel(x + 1, y - 1).G + (int) bitmap3.GetPixel(x + 1, y).G);
          pixel1 = bitmap3.GetPixel(checked (x + 1), checked (y + 1));
          int num12 = (int) pixel1.G;
          int val1_2 = checked ((int) Math.Round(unchecked ((double) checked (num11 + num12) / 9.0)));
          int num13 = checked ((int) bitmap3.GetPixel(x - 1, y - 1).B + (int) bitmap3.GetPixel(x - 1, y).B + (int) bitmap3.GetPixel(x - 1, y + 1).B + (int) bitmap3.GetPixel(x, y - 1).B + (int) bitmap3.GetPixel(x, y).B);
          pixel2 = bitmap3.GetPixel(x, checked (y + 1));
          int num14 = (int) pixel2.B;
          int num15 = checked (num13 + num14 + (int) bitmap3.GetPixel(x + 1, y - 1).B + (int) bitmap3.GetPixel(x + 1, y).B);
          pixel1 = bitmap3.GetPixel(checked (x + 1), checked (y + 1));
          int num16 = (int) pixel1.B;
          int val1_3 = checked ((int) Math.Round(unchecked ((double) checked (num15 + num16) / 9.0)));
          int red = Math.Min(Math.Max(val1_1, 0), (int) byte.MaxValue);
          int green = Math.Min(Math.Max(val1_2, 0), (int) byte.MaxValue);
          int blue = Math.Min(Math.Max(val1_3, 0), (int) byte.MaxValue);
          bitmap1.SetPixel(x, y, Color.FromArgb(red, green, blue));
          checked { ++x; }
        }
        if (y % 10 == 0)
        {
          this.MyPicture.Invalidate();
          this.MyPicture.Refresh();
          this.MyPicture.CreateGraphics().DrawString("Now Processing... " + Conversion.Int((double) checked (100 * y) / (double) checked (this.MyPicture.Image.Height - 2)).ToString() + "%", new Font("Verdana", 12f, FontStyle.Bold), Brushes.White, 10f, 25f);
        }
        checked { ++y; }
      }
      this.MyPicture.Refresh();
      this.SetModified();
    }

    private void MnuDiffuse_Click(object sender, EventArgs e)
    {
      this.undoImage = this.MyPicture.Image;
      this.MnuUndo.Enabled = true;
      Bitmap bitmap1 = new Bitmap(this.MyPicture.Image);
      this.MyPicture.Image = (Image) bitmap1;
      Bitmap bitmap2 = new Bitmap(this.MyPicture.Image);
      int num1 = 3;
      int num2 = checked (bitmap2.Height - 3);
      int y = num1;
      while (y <= num2)
      {
        int num3 = 3;
        int num4 = checked (bitmap2.Width - 3);
        int x = num3;
        while (x <= num4)
        {
          int num5 = checked ((int) Math.Round(unchecked ((double) VBMath.Rnd() * 4.0 - 2.0)));
          int num6 = checked ((int) Math.Round(unchecked ((double) VBMath.Rnd() * 4.0 - 2.0)));
          Color pixel = bitmap2.GetPixel(checked (x + num5), checked (y + num6));
          int red = (int) pixel.R;
          pixel = bitmap2.GetPixel(checked (x + num5), checked (y + num6));
          int green = (int) pixel.G;
          pixel = bitmap2.GetPixel(checked (x + num5), checked (y + num6));
          int blue = (int) pixel.B;
          bitmap1.SetPixel(x, y, Color.FromArgb(red, green, blue));
          checked { ++x; }
        }
        if (y % 10 == 0)
        {
          this.MyPicture.Invalidate();
          this.MyPicture.Refresh();
          this.MyPicture.CreateGraphics().DrawString("Now Processing... " + Conversion.Int((double) checked (100 * y) / (double) checked (this.MyPicture.Image.Height - 2)).ToString() + "%", new Font("Verdana", 12f, FontStyle.Bold), SystemBrushes.Control, 10f, 20f);
        }
        checked { ++y; }
      }
      this.MyPicture.Refresh();
      this.SetModified();
    }
  }
}
