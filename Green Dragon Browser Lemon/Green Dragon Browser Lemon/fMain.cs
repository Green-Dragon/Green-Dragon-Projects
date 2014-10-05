// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.fMain
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
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  [DesignerGenerated]
  public class fMain : Form
  {
    private IContainer components;
    [AccessedThroughProperty("pHover")]
    private Panel _pHover;
    [AccessedThroughProperty("tbSearch")]
    private TextBox _tbSearch;
    [AccessedThroughProperty("pSearch")]
    private Panel _pSearch;
    [AccessedThroughProperty("tcWeb")]
    private TabControl _tcWeb;
    [AccessedThroughProperty("bWebForward")]
    private Button _bWebForward;
    [AccessedThroughProperty("bWebBack")]
    private Button _bWebBack;
    [AccessedThroughProperty("bBookmark")]
    private Button _bBookmark;
    [AccessedThroughProperty("pMenu")]
    private MenuStrip _pMenu;
    [AccessedThroughProperty("iFile")]
    private ToolStripMenuItem _iFile;
    [AccessedThroughProperty("iTools")]
    private ToolStripMenuItem _iTools;
    [AccessedThroughProperty("iView")]
    private ToolStripMenuItem _iView;
    [AccessedThroughProperty("iAddTab")]
    private ToolStripMenuItem _iAddTab;
    [AccessedThroughProperty("iRemoveTab")]
    private ToolStripMenuItem _iRemoveTab;
    [AccessedThroughProperty("space1")]
    private ToolStripSeparator _space1;
    [AccessedThroughProperty("iNewWindow")]
    private ToolStripMenuItem _iNewWindow;
    [AccessedThroughProperty("iLockWindow")]
    private ToolStripMenuItem _iLockWindow;
    [AccessedThroughProperty("space2")]
    private ToolStripSeparator _space2;
    [AccessedThroughProperty("iPrint")]
    private ToolStripMenuItem _iPrint;
    [AccessedThroughProperty("iPrintPreview")]
    private ToolStripMenuItem _iPrintPreview;
    [AccessedThroughProperty("space3")]
    private ToolStripSeparator _space3;
    [AccessedThroughProperty("iPageSetup")]
    private ToolStripMenuItem _iPageSetup;
    [AccessedThroughProperty("iProperties")]
    private ToolStripMenuItem _iProperties;
    [AccessedThroughProperty("space4")]
    private ToolStripSeparator _space4;
    [AccessedThroughProperty("iExit")]
    private ToolStripMenuItem _iExit;
    [AccessedThroughProperty("iNotepad")]
    private ToolStripMenuItem _iNotepad;
    [AccessedThroughProperty("iScreenshot")]
    private ToolStripMenuItem _iScreenshot;
    [AccessedThroughProperty("space5")]
    private ToolStripSeparator _space5;
    [AccessedThroughProperty("iOptions")]
    private ToolStripMenuItem _iOptions;
    [AccessedThroughProperty("iHistory")]
    private ToolStripMenuItem _iHistory;
    [AccessedThroughProperty("iBookmarks")]
    private ToolStripMenuItem _iBookmarks;
    [AccessedThroughProperty("space6")]
    private ToolStripSeparator _space6;
    [AccessedThroughProperty("iAutoHideMenu")]
    private ToolStripMenuItem _iAutoHideMenu;
    [AccessedThroughProperty("iFullscreen")]
    private ToolStripMenuItem _iFullscreen;
    [AccessedThroughProperty("bLock")]
    private Button _bLock;
    [AccessedThroughProperty("bSearch")]
    private Button _bSearch;
    [AccessedThroughProperty("picFavicon")]
    private PictureBox _picFavicon;
    [AccessedThroughProperty("cmFav")]
    private ContextMenuStrip _cmFav;
    [AccessedThroughProperty("iOpenInNewTab")]
    private ToolStripMenuItem _iOpenInNewTab;
    [AccessedThroughProperty("iBookmarksManager")]
    private ToolStripMenuItem _iBookmarksManager;
    [AccessedThroughProperty("cmSearch")]
    private ContextMenuStrip _cmSearch;
    [AccessedThroughProperty("iSearchBing")]
    private ToolStripMenuItem _iSearchBing;
    [AccessedThroughProperty("iSearchGoogle")]
    private ToolStripMenuItem _iSearchGoogle;
    [AccessedThroughProperty("iSearchYoutube")]
    private ToolStripMenuItem _iSearchYoutube;
    [AccessedThroughProperty("timerAutoLock")]
    private System.Windows.Forms.Timer _timerAutoLock;
    [AccessedThroughProperty("iDownloads")]
    private ToolStripMenuItem _iDownloads;
    [AccessedThroughProperty("iNewTab")]
    private ToolStripMenuItem _iNewTab;
    [AccessedThroughProperty("iDeleteTab")]
    private ToolStripMenuItem _iDeleteTab;
    [AccessedThroughProperty("cmTab")]
    private ContextMenuStrip _cmTab;
    private int tab;

    internal virtual Panel pHover
    {
      get
      {
        return this._pHover;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.pHover_MouseEnter);
        if (this._pHover != null)
          this._pHover.MouseEnter -= eventHandler;
        this._pHover = value;
        if (this._pHover == null)
          return;
        this._pHover.MouseEnter += eventHandler;
      }
    }

    internal virtual TextBox tbSearch
    {
      get
      {
        return this._tbSearch;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.tbSearch_KeyDown);
        EventHandler eventHandler = new EventHandler(this.tbSearch_DoubleClick);
        if (this._tbSearch != null)
        {
          this._tbSearch.KeyDown -= keyEventHandler;
          this._tbSearch.DoubleClick -= eventHandler;
        }
        this._tbSearch = value;
        if (this._tbSearch == null)
          return;
        this._tbSearch.KeyDown += keyEventHandler;
        this._tbSearch.DoubleClick += eventHandler;
      }
    }

    internal virtual Panel pSearch
    {
      get
      {
        return this._pSearch;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.pSearch_MouseEnter);
        if (this._pSearch != null)
          this._pSearch.MouseEnter -= eventHandler;
        this._pSearch = value;
        if (this._pSearch == null)
          return;
        this._pSearch.MouseEnter += eventHandler;
      }
    }

    internal virtual TabControl tcWeb
    {
      get
      {
        return this._tcWeb;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.tcWeb_MouseUp);
        EventHandler eventHandler = new EventHandler(this.tcWeb_SelectedIndexChanged);
        if (this._tcWeb != null)
        {
          this._tcWeb.MouseUp -= mouseEventHandler;
          this._tcWeb.SelectedIndexChanged -= eventHandler;
        }
        this._tcWeb = value;
        if (this._tcWeb == null)
          return;
        this._tcWeb.MouseUp += mouseEventHandler;
        this._tcWeb.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Button bWebForward
    {
      get
      {
        return this._bWebForward;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bWebForward_Click);
        if (this._bWebForward != null)
          this._bWebForward.Click -= eventHandler;
        this._bWebForward = value;
        if (this._bWebForward == null)
          return;
        this._bWebForward.Click += eventHandler;
      }
    }

    internal virtual Button bWebBack
    {
      get
      {
        return this._bWebBack;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bWebBack_Click);
        if (this._bWebBack != null)
          this._bWebBack.Click -= eventHandler;
        this._bWebBack = value;
        if (this._bWebBack == null)
          return;
        this._bWebBack.Click += eventHandler;
      }
    }

    internal virtual Button bBookmark
    {
      get
      {
        return this._bBookmark;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bBookmark_Click);
        if (this._bBookmark != null)
          this._bBookmark.Click -= eventHandler;
        this._bBookmark = value;
        if (this._bBookmark == null)
          return;
        this._bBookmark.Click += eventHandler;
      }
    }

    internal virtual MenuStrip pMenu
    {
      get
      {
        return this._pMenu;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.pMenu_MouseLeave);
        ToolStripItemClickedEventHandler clickedEventHandler = new ToolStripItemClickedEventHandler(this.pMenu_ItemClicked);
        if (this._pMenu != null)
        {
          this._pMenu.MouseLeave -= eventHandler;
          this._pMenu.ItemClicked -= clickedEventHandler;
        }
        this._pMenu = value;
        if (this._pMenu == null)
          return;
        this._pMenu.MouseLeave += eventHandler;
        this._pMenu.ItemClicked += clickedEventHandler;
      }
    }

    internal virtual ToolStripMenuItem iFile
    {
      get
      {
        return this._iFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._iFile = value;
      }
    }

    internal virtual ToolStripMenuItem iTools
    {
      get
      {
        return this._iTools;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._iTools = value;
      }
    }

    internal virtual ToolStripMenuItem iView
    {
      get
      {
        return this._iView;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._iView = value;
      }
    }

    internal virtual ToolStripMenuItem iAddTab
    {
      get
      {
        return this._iAddTab;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iAddTab_Click);
        if (this._iAddTab != null)
          this._iAddTab.Click -= eventHandler;
        this._iAddTab = value;
        if (this._iAddTab == null)
          return;
        this._iAddTab.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iRemoveTab
    {
      get
      {
        return this._iRemoveTab;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iRemoveTab_Click);
        if (this._iRemoveTab != null)
          this._iRemoveTab.Click -= eventHandler;
        this._iRemoveTab = value;
        if (this._iRemoveTab == null)
          return;
        this._iRemoveTab.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator space1
    {
      get
      {
        return this._space1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._space1 = value;
      }
    }

    internal virtual ToolStripMenuItem iNewWindow
    {
      get
      {
        return this._iNewWindow;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iNewWindow_Click);
        if (this._iNewWindow != null)
          this._iNewWindow.Click -= eventHandler;
        this._iNewWindow = value;
        if (this._iNewWindow == null)
          return;
        this._iNewWindow.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iLockWindow
    {
      get
      {
        return this._iLockWindow;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iLockWindow_Click);
        if (this._iLockWindow != null)
          this._iLockWindow.Click -= eventHandler;
        this._iLockWindow = value;
        if (this._iLockWindow == null)
          return;
        this._iLockWindow.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator space2
    {
      get
      {
        return this._space2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._space2 = value;
      }
    }

    internal virtual ToolStripMenuItem iPrint
    {
      get
      {
        return this._iPrint;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iPrint_Click);
        if (this._iPrint != null)
          this._iPrint.Click -= eventHandler;
        this._iPrint = value;
        if (this._iPrint == null)
          return;
        this._iPrint.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iPrintPreview
    {
      get
      {
        return this._iPrintPreview;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iPrintPreview_Click);
        if (this._iPrintPreview != null)
          this._iPrintPreview.Click -= eventHandler;
        this._iPrintPreview = value;
        if (this._iPrintPreview == null)
          return;
        this._iPrintPreview.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator space3
    {
      get
      {
        return this._space3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._space3 = value;
      }
    }

    internal virtual ToolStripMenuItem iPageSetup
    {
      get
      {
        return this._iPageSetup;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iPageSetup_Click);
        if (this._iPageSetup != null)
          this._iPageSetup.Click -= eventHandler;
        this._iPageSetup = value;
        if (this._iPageSetup == null)
          return;
        this._iPageSetup.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iProperties
    {
      get
      {
        return this._iProperties;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iProperties_Click);
        if (this._iProperties != null)
          this._iProperties.Click -= eventHandler;
        this._iProperties = value;
        if (this._iProperties == null)
          return;
        this._iProperties.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator space4
    {
      get
      {
        return this._space4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._space4 = value;
      }
    }

    internal virtual ToolStripMenuItem iExit
    {
      get
      {
        return this._iExit;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iExit_Click);
        if (this._iExit != null)
          this._iExit.Click -= eventHandler;
        this._iExit = value;
        if (this._iExit == null)
          return;
        this._iExit.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iNotepad
    {
      get
      {
        return this._iNotepad;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iNotepad_Click);
        if (this._iNotepad != null)
          this._iNotepad.Click -= eventHandler;
        this._iNotepad = value;
        if (this._iNotepad == null)
          return;
        this._iNotepad.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iScreenshot
    {
      get
      {
        return this._iScreenshot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iScreenshot_Click);
        if (this._iScreenshot != null)
          this._iScreenshot.Click -= eventHandler;
        this._iScreenshot = value;
        if (this._iScreenshot == null)
          return;
        this._iScreenshot.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator space5
    {
      get
      {
        return this._space5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._space5 = value;
      }
    }

    internal virtual ToolStripMenuItem iOptions
    {
      get
      {
        return this._iOptions;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iOptions_Click);
        if (this._iOptions != null)
          this._iOptions.Click -= eventHandler;
        this._iOptions = value;
        if (this._iOptions == null)
          return;
        this._iOptions.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iHistory
    {
      get
      {
        return this._iHistory;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iHistory_Click);
        if (this._iHistory != null)
          this._iHistory.Click -= eventHandler;
        this._iHistory = value;
        if (this._iHistory == null)
          return;
        this._iHistory.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iBookmarks
    {
      get
      {
        return this._iBookmarks;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iBookmarks_Click);
        if (this._iBookmarks != null)
          this._iBookmarks.Click -= eventHandler;
        this._iBookmarks = value;
        if (this._iBookmarks == null)
          return;
        this._iBookmarks.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator space6
    {
      get
      {
        return this._space6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._space6 = value;
      }
    }

    internal virtual ToolStripMenuItem iAutoHideMenu
    {
      get
      {
        return this._iAutoHideMenu;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iHideMenu_Click);
        if (this._iAutoHideMenu != null)
          this._iAutoHideMenu.Click -= eventHandler;
        this._iAutoHideMenu = value;
        if (this._iAutoHideMenu == null)
          return;
        this._iAutoHideMenu.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iFullscreen
    {
      get
      {
        return this._iFullscreen;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iFullscreen_Click);
        if (this._iFullscreen != null)
          this._iFullscreen.Click -= eventHandler;
        this._iFullscreen = value;
        if (this._iFullscreen == null)
          return;
        this._iFullscreen.Click += eventHandler;
      }
    }

    internal virtual Button bLock
    {
      get
      {
        return this._bLock;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bLock_Click);
        if (this._bLock != null)
          this._bLock.Click -= eventHandler;
        this._bLock = value;
        if (this._bLock == null)
          return;
        this._bLock.Click += eventHandler;
      }
    }

    internal virtual Button bSearch
    {
      get
      {
        return this._bSearch;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bSearch_Click);
        if (this._bSearch != null)
          this._bSearch.Click -= eventHandler;
        this._bSearch = value;
        if (this._bSearch == null)
          return;
        this._bSearch.Click += eventHandler;
      }
    }

    internal virtual PictureBox picFavicon
    {
      get
      {
        return this._picFavicon;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.picFavicon_Click);
        if (this._picFavicon != null)
          this._picFavicon.Click -= eventHandler;
        this._picFavicon = value;
        if (this._picFavicon == null)
          return;
        this._picFavicon.Click += eventHandler;
      }
    }

    internal virtual ContextMenuStrip cmFav
    {
      get
      {
        return this._cmFav;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cmFav = value;
      }
    }

    internal virtual ToolStripMenuItem iOpenInNewTab
    {
      get
      {
        return this._iOpenInNewTab;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iOpenInNewTab_Click);
        if (this._iOpenInNewTab != null)
          this._iOpenInNewTab.Click -= eventHandler;
        this._iOpenInNewTab = value;
        if (this._iOpenInNewTab == null)
          return;
        this._iOpenInNewTab.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iBookmarksManager
    {
      get
      {
        return this._iBookmarksManager;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iBookmarksManager_Click);
        if (this._iBookmarksManager != null)
          this._iBookmarksManager.Click -= eventHandler;
        this._iBookmarksManager = value;
        if (this._iBookmarksManager == null)
          return;
        this._iBookmarksManager.Click += eventHandler;
      }
    }

    internal virtual ContextMenuStrip cmSearch
    {
      get
      {
        return this._cmSearch;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cmSearch = value;
      }
    }

    internal virtual ToolStripMenuItem iSearchBing
    {
      get
      {
        return this._iSearchBing;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iSearchBing_Click);
        if (this._iSearchBing != null)
          this._iSearchBing.Click -= eventHandler;
        this._iSearchBing = value;
        if (this._iSearchBing == null)
          return;
        this._iSearchBing.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iSearchGoogle
    {
      get
      {
        return this._iSearchGoogle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iSearchGoogle_Click);
        if (this._iSearchGoogle != null)
          this._iSearchGoogle.Click -= eventHandler;
        this._iSearchGoogle = value;
        if (this._iSearchGoogle == null)
          return;
        this._iSearchGoogle.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iSearchYoutube
    {
      get
      {
        return this._iSearchYoutube;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iSearchYoutube_Click);
        if (this._iSearchYoutube != null)
          this._iSearchYoutube.Click -= eventHandler;
        this._iSearchYoutube = value;
        if (this._iSearchYoutube == null)
          return;
        this._iSearchYoutube.Click += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer timerAutoLock
    {
      get
      {
        return this._timerAutoLock;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.timerAutoLock_Tick);
        if (this._timerAutoLock != null)
          this._timerAutoLock.Tick -= eventHandler;
        this._timerAutoLock = value;
        if (this._timerAutoLock == null)
          return;
        this._timerAutoLock.Tick += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iDownloads
    {
      get
      {
        return this._iDownloads;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iDownloads_Click);
        if (this._iDownloads != null)
          this._iDownloads.Click -= eventHandler;
        this._iDownloads = value;
        if (this._iDownloads == null)
          return;
        this._iDownloads.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iNewTab
    {
      get
      {
        return this._iNewTab;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iNewTab_Click);
        if (this._iNewTab != null)
          this._iNewTab.Click -= eventHandler;
        this._iNewTab = value;
        if (this._iNewTab == null)
          return;
        this._iNewTab.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem iDeleteTab
    {
      get
      {
        return this._iDeleteTab;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.iDeleteTab_Click);
        if (this._iDeleteTab != null)
          this._iDeleteTab.Click -= eventHandler;
        this._iDeleteTab = value;
        if (this._iDeleteTab == null)
          return;
        this._iDeleteTab.Click += eventHandler;
      }
    }

    internal virtual ContextMenuStrip cmTab
    {
      get
      {
        return this._cmTab;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cmTab = value;
      }
    }

    public fMain()
    {
      this.FormClosing += new FormClosingEventHandler(this.fMain_Closing);
      this.Load += new EventHandler(this.fMain_Load);
      this.tab = 0;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fMain));
      this.pHover = new Panel();
      this.tbSearch = new TextBox();
      this.cmSearch = new ContextMenuStrip(this.components);
      this.iSearchBing = new ToolStripMenuItem();
      this.iSearchGoogle = new ToolStripMenuItem();
      this.iSearchYoutube = new ToolStripMenuItem();
      this.pSearch = new Panel();
      this.picFavicon = new PictureBox();
      this.bSearch = new Button();
      this.bLock = new Button();
      this.bBookmark = new Button();
      this.bWebForward = new Button();
      this.bWebBack = new Button();
      this.tcWeb = new TabControl();
      this.cmTab = new ContextMenuStrip(this.components);
      this.iNewTab = new ToolStripMenuItem();
      this.iDeleteTab = new ToolStripMenuItem();
      this.pMenu = new MenuStrip();
      this.iFile = new ToolStripMenuItem();
      this.iAddTab = new ToolStripMenuItem();
      this.iRemoveTab = new ToolStripMenuItem();
      this.space1 = new ToolStripSeparator();
      this.iNewWindow = new ToolStripMenuItem();
      this.iLockWindow = new ToolStripMenuItem();
      this.space2 = new ToolStripSeparator();
      this.iPrint = new ToolStripMenuItem();
      this.iPrintPreview = new ToolStripMenuItem();
      this.space3 = new ToolStripSeparator();
      this.iPageSetup = new ToolStripMenuItem();
      this.iProperties = new ToolStripMenuItem();
      this.space4 = new ToolStripSeparator();
      this.iExit = new ToolStripMenuItem();
      this.iTools = new ToolStripMenuItem();
      this.iNotepad = new ToolStripMenuItem();
      this.iScreenshot = new ToolStripMenuItem();
      this.space5 = new ToolStripSeparator();
      this.iOptions = new ToolStripMenuItem();
      this.iView = new ToolStripMenuItem();
      this.iHistory = new ToolStripMenuItem();
      this.iBookmarks = new ToolStripMenuItem();
      this.iDownloads = new ToolStripMenuItem();
      this.space6 = new ToolStripSeparator();
      this.iAutoHideMenu = new ToolStripMenuItem();
      this.iFullscreen = new ToolStripMenuItem();
      this.cmFav = new ContextMenuStrip(this.components);
      this.iOpenInNewTab = new ToolStripMenuItem();
      this.iBookmarksManager = new ToolStripMenuItem();
      this.timerAutoLock = new System.Windows.Forms.Timer(this.components);
      this.cmSearch.SuspendLayout();
      this.pSearch.SuspendLayout();
      ((ISupportInitialize) this.picFavicon).BeginInit();
      this.cmTab.SuspendLayout();
      this.pMenu.SuspendLayout();
      this.cmFav.SuspendLayout();
      this.SuspendLayout();
      this.pHover.BackColor = Color.Transparent;
      this.pHover.Dock = DockStyle.Bottom;
      Panel pHover1 = this.pHover;
      Point point1 = new Point(0, 749);
      Point point2 = point1;
      pHover1.Location = point2;
      this.pHover.Name = "pHover";
      Panel pHover2 = this.pHover;
      Size size1 = new Size(1184, 1);
      Size size2 = size1;
      pHover2.Size = size2;
      this.pHover.TabIndex = 1;
      this.pHover.Visible = false;
      this.tbSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
      this.tbSearch.AutoCompleteMode = AutoCompleteMode.Append;
      this.tbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
      this.tbSearch.BackColor = Color.DimGray;
      this.tbSearch.BorderStyle = BorderStyle.None;
      this.tbSearch.ContextMenuStrip = this.cmSearch;
      this.tbSearch.ForeColor = Color.White;
      TextBox tbSearch1 = this.tbSearch;
      point1 = new Point(101, 8);
      Point point3 = point1;
      tbSearch1.Location = point3;
      this.tbSearch.Name = "tbSearch";
      TextBox tbSearch2 = this.tbSearch;
      size1 = new Size(998, 22);
      Size size3 = size1;
      tbSearch2.Size = size3;
      this.tbSearch.TabIndex = 0;
      this.cmSearch.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.iSearchBing,
        (ToolStripItem) this.iSearchGoogle,
        (ToolStripItem) this.iSearchYoutube
      });
      this.cmSearch.Name = "cmBookmarks";
      ContextMenuStrip cmSearch = this.cmSearch;
      size1 = new Size(198, 70);
      Size size4 = size1;
      cmSearch.Size = size4;
      this.iSearchBing.Image = (Image) Resources.search_dark;
      this.iSearchBing.Name = "iSearchBing";
      this.iSearchBing.ShortcutKeys = Keys.B | Keys.Alt;
      ToolStripMenuItem iSearchBing = this.iSearchBing;
      size1 = new Size(197, 22);
      Size size5 = size1;
      iSearchBing.Size = size5;
      this.iSearchBing.Text = "Search Bing";
      this.iSearchGoogle.Image = (Image) Resources.search_dark;
      this.iSearchGoogle.Name = "iSearchGoogle";
      this.iSearchGoogle.ShortcutKeys = Keys.G | Keys.Alt;
      ToolStripMenuItem iSearchGoogle = this.iSearchGoogle;
      size1 = new Size(197, 22);
      Size size6 = size1;
      iSearchGoogle.Size = size6;
      this.iSearchGoogle.Text = "Search Google";
      this.iSearchYoutube.Image = (Image) Resources.search_dark;
      this.iSearchYoutube.Name = "iSearchYoutube";
      this.iSearchYoutube.ShortcutKeys = Keys.Y | Keys.Alt;
      ToolStripMenuItem iSearchYoutube = this.iSearchYoutube;
      size1 = new Size(197, 22);
      Size size7 = size1;
      iSearchYoutube.Size = size7;
      this.iSearchYoutube.Text = "Search YouTube";
      this.pSearch.BackColor = Color.FromArgb(64, 64, 64);
      this.pSearch.Controls.Add((Control) this.picFavicon);
      this.pSearch.Controls.Add((Control) this.bSearch);
      this.pSearch.Controls.Add((Control) this.bLock);
      this.pSearch.Controls.Add((Control) this.bBookmark);
      this.pSearch.Controls.Add((Control) this.bWebForward);
      this.pSearch.Controls.Add((Control) this.bWebBack);
      this.pSearch.Controls.Add((Control) this.tbSearch);
      this.pSearch.Dock = DockStyle.Bottom;
      Panel pSearch1 = this.pSearch;
      point1 = new Point(0, 711);
      Point point4 = point1;
      pSearch1.Location = point4;
      this.pSearch.Name = "pSearch";
      Panel pSearch2 = this.pSearch;
      size1 = new Size(1184, 38);
      Size size8 = size1;
      pSearch2.Size = size8;
      this.pSearch.TabIndex = 0;
      this.picFavicon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.picFavicon.BackColor = Color.DimGray;
      PictureBox picFavicon1 = this.picFavicon;
      point1 = new Point(79, 8);
      Point point5 = point1;
      picFavicon1.Location = point5;
      this.picFavicon.Name = "picFavicon";
      PictureBox picFavicon2 = this.picFavicon;
      size1 = new Size(22, 22);
      Size size9 = size1;
      picFavicon2.Size = size9;
      this.picFavicon.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picFavicon.TabIndex = 6;
      this.picFavicon.TabStop = false;
      this.bSearch.Anchor = AnchorStyles.Right;
      this.bSearch.BackColor = Color.DimGray;
      this.bSearch.BackgroundImage = (Image) Resources.search_light;
      this.bSearch.BackgroundImageLayout = ImageLayout.Stretch;
      this.bSearch.FlatStyle = FlatStyle.Flat;
      this.bSearch.ForeColor = Color.DimGray;
      Button bSearch1 = this.bSearch;
      point1 = new Point(1099, 8);
      Point point6 = point1;
      bSearch1.Location = point6;
      this.bSearch.Name = "bSearch";
      Button bSearch2 = this.bSearch;
      size1 = new Size(22, 22);
      Size size10 = size1;
      bSearch2.Size = size10;
      this.bSearch.TabIndex = 1;
      this.bSearch.UseVisualStyleBackColor = false;
      this.bLock.Anchor = AnchorStyles.Right;
      this.bLock.BackgroundImage = (Image) Resources.lock_light;
      this.bLock.BackgroundImageLayout = ImageLayout.Stretch;
      this.bLock.FlatStyle = FlatStyle.Flat;
      this.bLock.ForeColor = Color.FromArgb(64, 64, 64);
      Button bLock1 = this.bLock;
      point1 = new Point(1149, 3);
      Point point7 = point1;
      bLock1.Location = point7;
      this.bLock.Name = "bLock";
      Button bLock2 = this.bLock;
      size1 = new Size(32, 32);
      Size size11 = size1;
      bLock2.Size = size11;
      this.bLock.TabIndex = 3;
      this.bLock.UseVisualStyleBackColor = true;
      this.bBookmark.Anchor = AnchorStyles.Right;
      this.bBookmark.BackColor = Color.DimGray;
      this.bBookmark.BackgroundImage = (Image) Resources.star_light;
      this.bBookmark.BackgroundImageLayout = ImageLayout.Stretch;
      this.bBookmark.FlatStyle = FlatStyle.Flat;
      this.bBookmark.ForeColor = Color.DimGray;
      Button bBookmark1 = this.bBookmark;
      point1 = new Point(1121, 8);
      Point point8 = point1;
      bBookmark1.Location = point8;
      this.bBookmark.Name = "bBookmark";
      Button bBookmark2 = this.bBookmark;
      size1 = new Size(22, 22);
      Size size12 = size1;
      bBookmark2.Size = size12;
      this.bBookmark.TabIndex = 2;
      this.bBookmark.UseVisualStyleBackColor = false;
      this.bWebForward.Anchor = AnchorStyles.Left;
      this.bWebForward.BackgroundImage = (Image) Resources.forward_dark;
      this.bWebForward.BackgroundImageLayout = ImageLayout.Stretch;
      this.bWebForward.FlatStyle = FlatStyle.Flat;
      this.bWebForward.ForeColor = Color.FromArgb(64, 64, 64);
      Button bWebForward1 = this.bWebForward;
      point1 = new Point(41, 3);
      Point point9 = point1;
      bWebForward1.Location = point9;
      this.bWebForward.Name = "bWebForward";
      Button bWebForward2 = this.bWebForward;
      size1 = new Size(32, 32);
      Size size13 = size1;
      bWebForward2.Size = size13;
      this.bWebForward.TabIndex = 5;
      this.bWebForward.UseVisualStyleBackColor = true;
      this.bWebBack.Anchor = AnchorStyles.Left;
      this.bWebBack.BackgroundImage = (Image) Resources.back_dark;
      this.bWebBack.BackgroundImageLayout = ImageLayout.Stretch;
      this.bWebBack.FlatStyle = FlatStyle.Flat;
      this.bWebBack.ForeColor = Color.FromArgb(64, 64, 64);
      Button bWebBack1 = this.bWebBack;
      point1 = new Point(3, 3);
      Point point10 = point1;
      bWebBack1.Location = point10;
      this.bWebBack.Name = "bWebBack";
      Button bWebBack2 = this.bWebBack;
      size1 = new Size(32, 32);
      Size size14 = size1;
      bWebBack2.Size = size14;
      this.bWebBack.TabIndex = 4;
      this.bWebBack.UseVisualStyleBackColor = true;
      this.tcWeb.Alignment = TabAlignment.Bottom;
      this.tcWeb.ContextMenuStrip = this.cmTab;
      this.tcWeb.Dock = DockStyle.Fill;
      TabControl tcWeb1 = this.tcWeb;
      point1 = new Point(0, 0);
      Point point11 = point1;
      tcWeb1.Location = point11;
      this.tcWeb.Name = "tcWeb";
      this.tcWeb.SelectedIndex = 0;
      TabControl tcWeb2 = this.tcWeb;
      size1 = new Size(1184, 687);
      Size size15 = size1;
      tcWeb2.Size = size15;
      this.tcWeb.SizeMode = TabSizeMode.Fixed;
      this.tcWeb.TabIndex = 7;
      this.cmTab.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.iNewTab,
        (ToolStripItem) this.iDeleteTab
      });
      this.cmTab.Name = "cmBookmarks";
      ContextMenuStrip cmTab = this.cmTab;
      size1 = new Size(172, 48);
      Size size16 = size1;
      cmTab.Size = size16;
      this.iNewTab.Image = (Image) Resources.add_dark;
      this.iNewTab.Name = "iNewTab";
      this.iNewTab.ShortcutKeys = Keys.T | Keys.Control;
      ToolStripMenuItem iNewTab = this.iNewTab;
      size1 = new Size(171, 22);
      Size size17 = size1;
      iNewTab.Size = size17;
      this.iNewTab.Text = "New tab";
      this.iDeleteTab.Image = (Image) Resources.minimize_dark;
      this.iDeleteTab.Name = "iDeleteTab";
      this.iDeleteTab.ShortcutKeys = Keys.R | Keys.Control;
      ToolStripMenuItem iDeleteTab = this.iDeleteTab;
      size1 = new Size(171, 22);
      Size size18 = size1;
      iDeleteTab.Size = size18;
      this.iDeleteTab.Text = "Delete Tab";
      this.pMenu.BackColor = Color.FromArgb(64, 64, 64);
      this.pMenu.Dock = DockStyle.Bottom;
      this.pMenu.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.iFile,
        (ToolStripItem) this.iTools,
        (ToolStripItem) this.iView
      });
      MenuStrip pMenu1 = this.pMenu;
      point1 = new Point(0, 687);
      Point point12 = point1;
      pMenu1.Location = point12;
      this.pMenu.Name = "pMenu";
      MenuStrip pMenu2 = this.pMenu;
      size1 = new Size(1184, 24);
      Size size19 = size1;
      pMenu2.Size = size19;
      this.pMenu.TabIndex = 2;
      this.iFile.DropDownItems.AddRange(new ToolStripItem[13]
      {
        (ToolStripItem) this.iAddTab,
        (ToolStripItem) this.iRemoveTab,
        (ToolStripItem) this.space1,
        (ToolStripItem) this.iNewWindow,
        (ToolStripItem) this.iLockWindow,
        (ToolStripItem) this.space2,
        (ToolStripItem) this.iPrint,
        (ToolStripItem) this.iPrintPreview,
        (ToolStripItem) this.space3,
        (ToolStripItem) this.iPageSetup,
        (ToolStripItem) this.iProperties,
        (ToolStripItem) this.space4,
        (ToolStripItem) this.iExit
      });
      this.iFile.ForeColor = Color.White;
      this.iFile.Name = "iFile";
      ToolStripMenuItem iFile = this.iFile;
      size1 = new Size(37, 20);
      Size size20 = size1;
      iFile.Size = size20;
      this.iFile.Text = "File";
      this.iAddTab.Image = (Image) Resources.add_dark;
      this.iAddTab.Name = "iAddTab";
      this.iAddTab.ShortcutKeys = Keys.T | Keys.Control;
      ToolStripMenuItem iAddTab = this.iAddTab;
      size1 = new Size(187, 22);
      Size size21 = size1;
      iAddTab.Size = size21;
      this.iAddTab.Text = "Add tab";
      this.iRemoveTab.Image = (Image) Resources.minimize_dark;
      this.iRemoveTab.Name = "iRemoveTab";
      this.iRemoveTab.ShortcutKeys = Keys.R | Keys.Control;
      ToolStripMenuItem iRemoveTab = this.iRemoveTab;
      size1 = new Size(187, 22);
      Size size22 = size1;
      iRemoveTab.Size = size22;
      this.iRemoveTab.Text = "Remove tab";
      this.space1.ForeColor = SystemColors.ControlText;
      this.space1.Name = "space1";
      ToolStripSeparator space1 = this.space1;
      size1 = new Size(184, 6);
      Size size23 = size1;
      space1.Size = size23;
      this.iNewWindow.Image = (Image) Resources.new_dark;
      this.iNewWindow.Name = "iNewWindow";
      ToolStripMenuItem iNewWindow = this.iNewWindow;
      size1 = new Size(187, 22);
      Size size24 = size1;
      iNewWindow.Size = size24;
      this.iNewWindow.Text = "New window";
      this.iLockWindow.Image = (Image) Resources.lock_dark;
      this.iLockWindow.Name = "iLockWindow";
      this.iLockWindow.ShortcutKeys = Keys.Q | Keys.Control;
      ToolStripMenuItem iLockWindow = this.iLockWindow;
      size1 = new Size(187, 22);
      Size size25 = size1;
      iLockWindow.Size = size25;
      this.iLockWindow.Text = "Lock window";
      this.space2.ForeColor = SystemColors.ControlText;
      this.space2.Name = "space2";
      ToolStripSeparator space2 = this.space2;
      size1 = new Size(184, 6);
      Size size26 = size1;
      space2.Size = size26;
      this.iPrint.Image = (Image) Resources.print_dark;
      this.iPrint.Name = "iPrint";
      this.iPrint.ShortcutKeys = Keys.P | Keys.Control;
      ToolStripMenuItem iPrint = this.iPrint;
      size1 = new Size(187, 22);
      Size size27 = size1;
      iPrint.Size = size27;
      this.iPrint.Text = "Print";
      this.iPrintPreview.Image = (Image) Resources.preview_dark;
      this.iPrintPreview.Name = "iPrintPreview";
      ToolStripMenuItem iPrintPreview = this.iPrintPreview;
      size1 = new Size(187, 22);
      Size size28 = size1;
      iPrintPreview.Size = size28;
      this.iPrintPreview.Text = "Print preview";
      this.space3.ForeColor = SystemColors.ControlText;
      this.space3.Name = "space3";
      ToolStripSeparator space3 = this.space3;
      size1 = new Size(184, 6);
      Size size29 = size1;
      space3.Size = size29;
      this.iPageSetup.Image = (Image) Resources.setup_dark;
      this.iPageSetup.Name = "iPageSetup";
      ToolStripMenuItem iPageSetup = this.iPageSetup;
      size1 = new Size(187, 22);
      Size size30 = size1;
      iPageSetup.Size = size30;
      this.iPageSetup.Text = "Page setup";
      this.iProperties.Image = (Image) Resources.properties_dark;
      this.iProperties.Name = "iProperties";
      ToolStripMenuItem iProperties = this.iProperties;
      size1 = new Size(187, 22);
      Size size31 = size1;
      iProperties.Size = size31;
      this.iProperties.Text = "Properties";
      this.space4.ForeColor = SystemColors.ControlText;
      this.space4.Name = "space4";
      ToolStripSeparator space4 = this.space4;
      size1 = new Size(184, 6);
      Size size32 = size1;
      space4.Size = size32;
      this.iExit.Image = (Image) Resources.cancel_dark;
      this.iExit.Name = "iExit";
      ToolStripMenuItem iExit = this.iExit;
      size1 = new Size(187, 22);
      Size size33 = size1;
      iExit.Size = size33;
      this.iExit.Text = "Exit";
      this.iTools.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.iNotepad,
        (ToolStripItem) this.iScreenshot,
        (ToolStripItem) this.space5,
        (ToolStripItem) this.iOptions
      });
      this.iTools.ForeColor = Color.White;
      this.iTools.Name = "iTools";
      ToolStripMenuItem iTools = this.iTools;
      size1 = new Size(48, 20);
      Size size34 = size1;
      iTools.Size = size34;
      this.iTools.Text = "Tools";
      this.iNotepad.Image = (Image) Resources.notes_dark;
      this.iNotepad.Name = "iNotepad";
      ToolStripMenuItem iNotepad = this.iNotepad;
      size1 = new Size(132, 22);
      Size size35 = size1;
      iNotepad.Size = size35;
      this.iNotepad.Text = "Notepad";
      this.iScreenshot.Image = (Image) Resources.camera_dark;
      this.iScreenshot.Name = "iScreenshot";
      ToolStripMenuItem iScreenshot = this.iScreenshot;
      size1 = new Size(132, 22);
      Size size36 = size1;
      iScreenshot.Size = size36;
      this.iScreenshot.Text = "Screenshot";
      this.space5.ForeColor = SystemColors.ControlText;
      this.space5.Name = "space5";
      ToolStripSeparator space5 = this.space5;
      size1 = new Size(129, 6);
      Size size37 = size1;
      space5.Size = size37;
      this.iOptions.Image = (Image) Resources.settings_dark;
      this.iOptions.Name = "iOptions";
      ToolStripMenuItem iOptions = this.iOptions;
      size1 = new Size(132, 22);
      Size size38 = size1;
      iOptions.Size = size38;
      this.iOptions.Text = "Options";
      this.iView.DropDownItems.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.iHistory,
        (ToolStripItem) this.iBookmarks,
        (ToolStripItem) this.iDownloads,
        (ToolStripItem) this.space6,
        (ToolStripItem) this.iAutoHideMenu,
        (ToolStripItem) this.iFullscreen
      });
      this.iView.ForeColor = Color.White;
      this.iView.Name = "iView";
      ToolStripMenuItem iView = this.iView;
      size1 = new Size(44, 20);
      Size size39 = size1;
      iView.Size = size39;
      this.iView.Text = "View";
      this.iHistory.Image = (Image) Resources.history_dark;
      this.iHistory.Name = "iHistory";
      this.iHistory.ShortcutKeys = Keys.H | Keys.Control;
      ToolStripMenuItem iHistory = this.iHistory;
      size1 = new Size(174, 22);
      Size size40 = size1;
      iHistory.Size = size40;
      this.iHistory.Text = "History";
      this.iBookmarks.Image = (Image) Resources.bookmark_dark;
      this.iBookmarks.Name = "iBookmarks";
      this.iBookmarks.ShortcutKeys = Keys.B | Keys.Control;
      ToolStripMenuItem iBookmarks = this.iBookmarks;
      size1 = new Size(174, 22);
      Size size41 = size1;
      iBookmarks.Size = size41;
      this.iBookmarks.Text = "Bookmarks";
      this.iDownloads.Image = (Image) Resources.download_dark;
      this.iDownloads.Name = "iDownloads";
      this.iDownloads.ShortcutKeys = Keys.J | Keys.Control;
      ToolStripMenuItem iDownloads = this.iDownloads;
      size1 = new Size(174, 22);
      Size size42 = size1;
      iDownloads.Size = size42;
      this.iDownloads.Text = "Downloads";
      this.space6.ForeColor = SystemColors.ControlText;
      this.space6.Name = "space6";
      ToolStripSeparator space6 = this.space6;
      size1 = new Size(171, 6);
      Size size43 = size1;
      space6.Size = size43;
      this.iAutoHideMenu.Image = (Image) Resources.menu_dark;
      this.iAutoHideMenu.Name = "iAutoHideMenu";
      ToolStripMenuItem iAutoHideMenu = this.iAutoHideMenu;
      size1 = new Size(174, 22);
      Size size44 = size1;
      iAutoHideMenu.Size = size44;
      this.iAutoHideMenu.Text = "Auto hide menu";
      this.iFullscreen.Image = (Image) Resources.expand_dark;
      this.iFullscreen.Name = "iFullscreen";
      this.iFullscreen.ShortcutKeys = Keys.F11;
      ToolStripMenuItem iFullscreen = this.iFullscreen;
      size1 = new Size(174, 22);
      Size size45 = size1;
      iFullscreen.Size = size45;
      this.iFullscreen.Text = "Fullscreen";
      this.cmFav.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.iOpenInNewTab,
        (ToolStripItem) this.iBookmarksManager
      });
      this.cmFav.Name = "cmBookmarks";
      ContextMenuStrip cmFav = this.cmFav;
      size1 = new Size(184, 48);
      Size size46 = size1;
      cmFav.Size = size46;
      this.iOpenInNewTab.Image = (Image) Resources.add_dark;
      this.iOpenInNewTab.Name = "iOpenInNewTab";
      ToolStripMenuItem iOpenInNewTab = this.iOpenInNewTab;
      size1 = new Size(183, 22);
      Size size47 = size1;
      iOpenInNewTab.Size = size47;
      this.iOpenInNewTab.Text = "Open in new tab";
      this.iBookmarksManager.Image = (Image) Resources.bookmark_dark;
      this.iBookmarksManager.Name = "iBookmarksManager";
      ToolStripMenuItem bookmarksManager = this.iBookmarksManager;
      size1 = new Size(183, 22);
      Size size48 = size1;
      bookmarksManager.Size = size48;
      this.iBookmarksManager.Text = "Bookmarks manager";
      this.timerAutoLock.Interval = 1800000;
      this.AutoScaleDimensions = new SizeF(8f, 21f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.DimGray;
      size1 = new Size(1184, 750);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.tcWeb);
      this.Controls.Add((Control) this.pMenu);
      this.Controls.Add((Control) this.pSearch);
      this.Controls.Add((Control) this.pHover);
      this.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.pMenu;
      this.Margin = new Padding(4);
      this.Name = "fMain";
      this.Text = "Green Dragon Browser";
      this.WindowState = FormWindowState.Maximized;
      this.cmSearch.ResumeLayout(false);
      this.pSearch.ResumeLayout(false);
      this.pSearch.PerformLayout();
      ((ISupportInitialize) this.picFavicon).EndInit();
      this.cmTab.ResumeLayout(false);
      this.pMenu.ResumeLayout(false);
      this.pMenu.PerformLayout();
      this.cmFav.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void fMain_Load(object sender, EventArgs e)
    {
      WebBrowser webBrowser = new WebBrowser();
      this.tcWeb.TabPages.Add("New Tab");
      this.tcWeb.SelectTab(this.tab);
      webBrowser.Dock = DockStyle.Fill;
      this.tcWeb.SelectedTab.Controls.Add((Control) webBrowser);
      webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.loadComplete);
      this.tab = checked (this.tab + 1);
      webBrowser.Navigate(MySettingsProperty.Settings.varHomepage);
      webBrowser.ScriptErrorsSuppressed = true;
      if (Conversions.ToBoolean(MySettingsProperty.Settings.varFullscreen))
        this.pSearch.Hide();
      this.loadVar();
      this.loadOptions();
      this.loadTheme();
      this.loadBookmarks();
      this.loadCache();
    }

    private void fMain_Closing(object sender, CancelEventArgs e)
    {
      if (!Conversions.ToBoolean(MySettingsProperty.Settings.autoClear))
        return;
      MySettingsProperty.Settings.varHistory.Clear();
      MySettingsProperty.Settings.autoComplete.Clear();
      MySettingsProperty.Settings.Save();
    }

    private void pHover_MouseEnter(object sender, EventArgs e)
    {
      if (!Conversions.ToBoolean(MySettingsProperty.Settings.varFullscreen))
        return;
      this.pSearch.Show();
      this.pMenu.Show();
    }

    private void pSearch_MouseEnter(object sender, EventArgs e)
    {
      if (Conversions.ToBoolean(MySettingsProperty.Settings.varFullscreen) || this.pMenu.Visible)
        return;
      this.pMenu.Visible = true;
    }

    private void pMenu_MouseLeave(object sender, EventArgs e)
    {
      if (!Conversions.ToBoolean(MySettingsProperty.Settings.varFullscreen))
      {
        if (!Conversions.ToBoolean(MySettingsProperty.Settings.autoHideMenu))
          return;
        this.pMenu.Visible = false;
      }
      else
      {
        if (this.ClientRectangle.Contains(this.pMenu.PointToClient(Cursor.Position)))
          return;
        this.pMenu.Visible = false;
        this.pSearch.Hide();
      }
    }

    private void loadComplete(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      try
      {
        this.tcWeb.SelectedTab.Text = ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).DocumentTitle;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (Conversions.ToBoolean(MySettingsProperty.Settings.themeDark))
      {
        if (((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).CanGoBack)
          this.bWebBack.BackgroundImage = (Image) Resources.back_light;
        else
          this.bWebBack.BackgroundImage = (Image) Resources.back_dark;
        if (((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).CanGoForward)
          this.bWebForward.BackgroundImage = (Image) Resources.forward_light;
        else
          this.bWebForward.BackgroundImage = (Image) Resources.forward_dark;
        if (MySettingsProperty.Settings.varBookmark.Contains(((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).DocumentTitle))
          this.bBookmark.BackgroundImage = (Image) Resources.bookmark_light;
        else
          this.bBookmark.BackgroundImage = (Image) Resources.star_light;
      }
      else
      {
        if (((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).CanGoBack)
          this.bWebBack.BackgroundImage = (Image) Resources.back_dark;
        else
          this.bWebBack.BackgroundImage = (Image) Resources.back_light;
        if (((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).CanGoForward)
          this.bWebForward.BackgroundImage = (Image) Resources.forward_dark;
        else
          this.bWebForward.BackgroundImage = (Image) Resources.forward_light;
        if (MySettingsProperty.Settings.varBookmark.Contains(((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).DocumentTitle))
          this.bBookmark.BackgroundImage = (Image) Resources.bookmark_dark;
        else
          this.bBookmark.BackgroundImage = (Image) Resources.star_dark;
      }
      try
      {
        this.tbSearch.Text = ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Url.ToString();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).ScriptErrorsSuppressed = true;
      this.loadFavicon();
    }

    internal void loadVar()
    {
      foreach (string str in MySettingsProperty.Settings.varHistory)
      {
        MyProject.Forms.fHistory.listHistory.Items.Clear();
        MyProject.Forms.fHistory.listHistory.Items.Add((object) str);
      }
      foreach (string str in MySettingsProperty.Settings.autoComplete)
        this.tbSearch.AutoCompleteCustomSource.Add(str);
      if (Conversions.ToBoolean(MySettingsProperty.Settings.varTopSearch))
      {
        this.tcWeb.Alignment = TabAlignment.Top;
        this.pMenu.Dock = DockStyle.Top;
        this.pSearch.Dock = DockStyle.Top;
        this.pHover.Dock = DockStyle.Top;
      }
      else
      {
        this.tcWeb.Alignment = TabAlignment.Bottom;
        this.pMenu.Dock = DockStyle.Bottom;
        this.pSearch.Dock = DockStyle.Bottom;
        this.pHover.Dock = DockStyle.Bottom;
      }
      if (Conversions.ToBoolean(MySettingsProperty.Settings.autoLock) & Conversions.ToBoolean(MySettingsProperty.Settings.autoClear))
        this.Text = "Green Dragon Browser | Auto Lock | Incognito";
      else if (Conversions.ToBoolean(MySettingsProperty.Settings.autoLock))
      {
        this.timerAutoLock.Enabled = true;
        this.Text = "Green Dragon Browser | Auto Lock";
      }
      else if (Conversions.ToBoolean(MySettingsProperty.Settings.autoClear))
      {
        this.timerAutoLock.Enabled = false;
        this.Text = "Green Dragon Browser | Incognito";
      }
      else
        this.Text = "Green Dragon Browser";
      MySettingsProperty.Settings.Save();
    }

    internal void loadOptions()
    {
      if (Conversions.ToBoolean(MySettingsProperty.Settings.varFullscreen))
      {
        this.pSearch.Visible = false;
        this.pMenu.Visible = false;
        this.pHover.Visible = true;
        this.iFullscreen.Checked = true;
        this.WindowState = FormWindowState.Normal;
        this.FormBorderStyle = FormBorderStyle.None;
        this.WindowState = FormWindowState.Maximized;
      }
      else
      {
        if (Conversions.ToBoolean(MySettingsProperty.Settings.autoHideMenu))
        {
          this.pMenu.Visible = false;
          this.iAutoHideMenu.Checked = true;
        }
        else
        {
          this.pMenu.Visible = true;
          this.iAutoHideMenu.Checked = false;
        }
        this.pSearch.Visible = true;
        this.pMenu.Visible = true;
        this.pHover.Visible = false;
        this.iFullscreen.Checked = false;
        this.WindowState = FormWindowState.Normal;
        this.FormBorderStyle = FormBorderStyle.Sizable;
        this.WindowState = FormWindowState.Maximized;
      }
    }

    internal void loadTheme()
    {
      Color color = Color.FromArgb(64, 64, 64);
      Color dimGray = Color.DimGray;
      Color white = Color.White;
      Color lightSkyBlue = Color.LightSkyBlue;
      Color darkViolet = Color.DarkViolet;
      Color gainsboro = Color.Gainsboro;
      Color silver = Color.Silver;
      if (Conversions.ToBoolean(MySettingsProperty.Settings.themeDark))
      {
        this.BackColor = dimGray;
        this.ForeColor = white;
        this.pSearch.BackColor = color;
        this.pSearch.ForeColor = white;
        this.pMenu.BackColor = color;
        this.pMenu.ForeColor = white;
        this.iFile.ForeColor = white;
        this.iTools.ForeColor = white;
        this.iView.ForeColor = white;
        NewLateBinding.LateSetComplex(this.fav0(), (System.Type) null, "ForeColor", new object[1]
        {
          (object) lightSkyBlue
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav1(), (System.Type) null, "ForeColor", new object[1]
        {
          (object) lightSkyBlue
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav2(), (System.Type) null, "ForeColor", new object[1]
        {
          (object) lightSkyBlue
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav3(), (System.Type) null, "ForeColor", new object[1]
        {
          (object) lightSkyBlue
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav4(), (System.Type) null, "ForeColor", new object[1]
        {
          (object) lightSkyBlue
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav5(), (System.Type) null, "ForeColor", new object[1]
        {
          (object) lightSkyBlue
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav6(), (System.Type) null, "ForeColor", new object[1]
        {
          (object) lightSkyBlue
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav7(), (System.Type) null, "ForeColor", new object[1]
        {
          (object) lightSkyBlue
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav8(), (System.Type) null, "ForeColor", new object[1]
        {
          (object) lightSkyBlue
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav9(), (System.Type) null, "ForeColor", new object[1]
        {
          (object) lightSkyBlue
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        this.bWebBack.BackgroundImage = (Image) Resources.back_light;
        this.bWebBack.ForeColor = color;
        this.bWebForward.BackgroundImage = (Image) Resources.forward_light;
        this.bWebForward.ForeColor = color;
        this.bSearch.BackgroundImage = (Image) Resources.search_light;
        this.bSearch.BackColor = dimGray;
        this.bSearch.ForeColor = dimGray;
        this.bBookmark.BackgroundImage = (Image) Resources.bookmark_light;
        this.bBookmark.BackColor = dimGray;
        this.bBookmark.ForeColor = dimGray;
        this.bLock.BackgroundImage = (Image) Resources.lock_light;
        this.bLock.ForeColor = color;
        this.tbSearch.BackColor = dimGray;
        this.tbSearch.ForeColor = white;
        this.picFavicon.BackColor = dimGray;
        MyProject.Forms.fSplash.BackColor = color;
        MyProject.Forms.fSplash.ForeColor = white;
        MyProject.Forms.fScreenshot.BackColor = color;
        MyProject.Forms.fScreenshot.ForeColor = white;
        MyProject.Forms.fScreenshot.picScreenshot.BackColor = dimGray;
        MyProject.Forms.fScreenshot.bScreenshot.BackgroundImage = (Image) Resources.camera_light;
        MyProject.Forms.fScreenshot.bScreenshot.ForeColor = color;
        MyProject.Forms.fScreenshot.bShare.BackgroundImage = (Image) Resources.share_light;
        MyProject.Forms.fScreenshot.bShare.ForeColor = color;
        MyProject.Forms.fScreenshot.bSave.BackgroundImage = (Image) Resources.save_light;
        MyProject.Forms.fScreenshot.bSave.ForeColor = color;
        MyProject.Forms.fNotepad.BackColor = color;
        MyProject.Forms.fNotepad.ForeColor = white;
        MyProject.Forms.fNotepad.tbNotes.BackColor = dimGray;
        MyProject.Forms.fNotepad.tbNotes.ForeColor = white;
        MyProject.Forms.fLogin.BackColor = color;
        MyProject.Forms.fLogin.ForeColor = white;
        MyProject.Forms.fLogin.bClose.BackgroundImage = (Image) Resources.cancel_light;
        MyProject.Forms.fLogin.bClose.ForeColor = color;
        MyProject.Forms.fLogin.bMinimize.BackgroundImage = (Image) Resources.minimize_light;
        MyProject.Forms.fLogin.bMinimize.ForeColor = color;
        MyProject.Forms.fLogin.bUser.Image = (Image) Resources.user_light;
        MyProject.Forms.fLogin.bUser.ForeColor = gainsboro;
        NewLateBinding.LateSetComplex(fLogin.bGuest(), (System.Type) null, "Image", new object[1]
        {
          (object) Resources.user_light
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(fLogin.bGuest(), (System.Type) null, "ForeColor", new object[1]
        {
          (object) gainsboro
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        MyProject.Forms.fLogin.bIncognito.Image = (Image) Resources.user_light;
        MyProject.Forms.fLogin.bIncognito.ForeColor = gainsboro;
        MyProject.Forms.fLogin.bUnlock.BackgroundImage = (Image) Resources.user_light;
        MyProject.Forms.fLogin.bUnlock.ForeColor = color;
        MyProject.Forms.fLogin.tbPassword.BackColor = color;
        MyProject.Forms.fLogin.tbPassword.ForeColor = white;
        MyProject.Forms.fHistory.BackColor = color;
        MyProject.Forms.fHistory.ForeColor = white;
        MyProject.Forms.fHistory.cbAutoClear.ForeColor = white;
        MyProject.Forms.fHistory.cbAutoLock.ForeColor = white;
        MyProject.Forms.fHistory.txtAutoClear.ForeColor = white;
        MyProject.Forms.fHistory.txtAutoLock.ForeColor = white;
        MyProject.Forms.fHistory.listHistory.BackColor = color;
        MyProject.Forms.fHistory.listHistory.ForeColor = white;
        MyProject.Forms.fDownloads.BackColor = color;
        MyProject.Forms.fDownloads.ForeColor = white;
        MyProject.Forms.fBookmarks.BackColor = color;
        MyProject.Forms.fBookmarks.ForeColor = white;
        MyProject.Forms.fBookmarks.txtName.ForeColor = white;
        MyProject.Forms.fBookmarks.txtUrl.ForeColor = white;
        MyProject.Forms.fBookmarks.tbName.BackColor = dimGray;
        MyProject.Forms.fBookmarks.tbName.ForeColor = white;
        MyProject.Forms.fBookmarks.tbUrl.BackColor = dimGray;
        MyProject.Forms.fBookmarks.tbUrl.ForeColor = white;
        MyProject.Forms.fBookmarks.bAdd.BackgroundImage = (Image) Resources.add_light;
        MyProject.Forms.fBookmarks.bAdd.ForeColor = color;
        MyProject.Forms.fBookmarks.listBookmarks.BackColor = color;
        MyProject.Forms.fBookmarks.listBookmarks.ForeColor = white;
        MyProject.Forms.fOptions.BackColor = color;
        MyProject.Forms.fOptions.ForeColor = white;
        MyProject.Forms.fOptions.txtHomepage.ForeColor = white;
        MyProject.Forms.fOptions.txtNewPassword.ForeColor = white;
        MyProject.Forms.fOptions.txtOldPassword.ForeColor = white;
        MyProject.Forms.fOptions.txtSearchEngine.ForeColor = white;
        MyProject.Forms.fOptions.txtTheme.ForeColor = white;
        MyProject.Forms.fOptions.tbHomepage.BackColor = dimGray;
        MyProject.Forms.fOptions.tbHomepage.ForeColor = white;
        MyProject.Forms.fOptions.tbNewPassword.BackColor = dimGray;
        MyProject.Forms.fOptions.tbNewPassword.ForeColor = white;
        MyProject.Forms.fOptions.tbOldPassword.BackColor = dimGray;
        MyProject.Forms.fOptions.tbOldPassword.ForeColor = white;
        MyProject.Forms.fOptions.bSetHomepage.BackgroundImage = (Image) Resources.accept_light;
        MyProject.Forms.fOptions.bSetHomepage.ForeColor = color;
        MyProject.Forms.fOptions.bCurrentPage.ForeColor = white;
        MyProject.Forms.fOptions.bChangePassword.BackgroundImage = (Image) Resources.accept_light;
        MyProject.Forms.fOptions.bChangePassword.ForeColor = color;
        MyProject.Forms.fOptions.comboTheme.BackColor = dimGray;
        MyProject.Forms.fOptions.comboTheme.ForeColor = white;
        MyProject.Forms.fOptions.comboSearch.BackColor = dimGray;
        MyProject.Forms.fOptions.comboSearch.ForeColor = white;
        MyProject.Forms.fOptions.gbPreferences.ForeColor = white;
        MyProject.Forms.fOptions.cbTopSearchBar.ForeColor = white;
      }
      if (!Conversions.ToBoolean(MySettingsProperty.Settings.themeLight))
        return;
      this.BackColor = silver;
      this.ForeColor = color;
      this.pSearch.BackColor = gainsboro;
      this.pSearch.ForeColor = color;
      this.pMenu.BackColor = gainsboro;
      this.pMenu.ForeColor = color;
      this.iFile.ForeColor = color;
      this.iTools.ForeColor = color;
      this.iView.ForeColor = color;
      NewLateBinding.LateSetComplex(this.fav0(), (System.Type) null, "ForeColor", new object[1]
      {
        (object) darkViolet
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      NewLateBinding.LateSetComplex(this.fav1(), (System.Type) null, "ForeColor", new object[1]
      {
        (object) darkViolet
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      NewLateBinding.LateSetComplex(this.fav2(), (System.Type) null, "ForeColor", new object[1]
      {
        (object) darkViolet
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      NewLateBinding.LateSetComplex(this.fav3(), (System.Type) null, "ForeColor", new object[1]
      {
        (object) darkViolet
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      NewLateBinding.LateSetComplex(this.fav4(), (System.Type) null, "ForeColor", new object[1]
      {
        (object) darkViolet
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      NewLateBinding.LateSetComplex(this.fav5(), (System.Type) null, "ForeColor", new object[1]
      {
        (object) darkViolet
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      NewLateBinding.LateSetComplex(this.fav6(), (System.Type) null, "ForeColor", new object[1]
      {
        (object) darkViolet
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      NewLateBinding.LateSetComplex(this.fav7(), (System.Type) null, "ForeColor", new object[1]
      {
        (object) darkViolet
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      NewLateBinding.LateSetComplex(this.fav8(), (System.Type) null, "ForeColor", new object[1]
      {
        (object) darkViolet
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      NewLateBinding.LateSetComplex(this.fav9(), (System.Type) null, "ForeColor", new object[1]
      {
        (object) darkViolet
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      this.bWebBack.BackgroundImage = (Image) Resources.back_dark;
      this.bWebBack.ForeColor = gainsboro;
      this.bWebForward.BackgroundImage = (Image) Resources.forward_dark;
      this.bWebForward.ForeColor = gainsboro;
      this.bSearch.BackgroundImage = (Image) Resources.search_dark;
      this.bSearch.BackColor = silver;
      this.bSearch.ForeColor = silver;
      this.bBookmark.BackgroundImage = (Image) Resources.bookmark_dark;
      this.bBookmark.BackColor = silver;
      this.bBookmark.ForeColor = silver;
      this.bLock.BackgroundImage = (Image) Resources.lock_dark;
      this.bLock.ForeColor = gainsboro;
      this.tbSearch.BackColor = silver;
      this.tbSearch.ForeColor = color;
      this.picFavicon.BackColor = silver;
      MyProject.Forms.fSplash.BackColor = gainsboro;
      MyProject.Forms.fSplash.ForeColor = color;
      MyProject.Forms.fScreenshot.BackColor = gainsboro;
      MyProject.Forms.fScreenshot.ForeColor = color;
      MyProject.Forms.fScreenshot.picScreenshot.BackColor = silver;
      MyProject.Forms.fScreenshot.bScreenshot.BackgroundImage = (Image) Resources.camera_dark;
      MyProject.Forms.fScreenshot.bScreenshot.ForeColor = gainsboro;
      MyProject.Forms.fScreenshot.bShare.BackgroundImage = (Image) Resources.share_dark;
      MyProject.Forms.fScreenshot.bShare.ForeColor = gainsboro;
      MyProject.Forms.fScreenshot.bSave.BackgroundImage = (Image) Resources.save_dark;
      MyProject.Forms.fScreenshot.bSave.ForeColor = gainsboro;
      MyProject.Forms.fNotepad.BackColor = gainsboro;
      MyProject.Forms.fNotepad.ForeColor = color;
      MyProject.Forms.fNotepad.tbNotes.BackColor = gainsboro;
      MyProject.Forms.fNotepad.tbNotes.ForeColor = color;
      MyProject.Forms.fLogin.BackColor = gainsboro;
      MyProject.Forms.fLogin.ForeColor = color;
      MyProject.Forms.fLogin.bClose.BackgroundImage = (Image) Resources.cancel_dark;
      MyProject.Forms.fLogin.bClose.ForeColor = gainsboro;
      MyProject.Forms.fLogin.bMinimize.BackgroundImage = (Image) Resources.minimize_dark;
      MyProject.Forms.fLogin.bMinimize.ForeColor = gainsboro;
      MyProject.Forms.fLogin.bUser.Image = (Image) Resources.user_dark;
      MyProject.Forms.fLogin.bUser.ForeColor = color;
      NewLateBinding.LateSetComplex(fLogin.bGuest(), (System.Type) null, "Image", new object[1]
      {
        (object) Resources.user_dark
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      NewLateBinding.LateSetComplex(fLogin.bGuest(), (System.Type) null, "ForeColor", new object[1]
      {
        (object) color
      }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      MyProject.Forms.fLogin.bIncognito.Image = (Image) Resources.user_dark;
      MyProject.Forms.fLogin.bIncognito.ForeColor = color;
      MyProject.Forms.fLogin.bUnlock.BackgroundImage = (Image) Resources.user_dark;
      MyProject.Forms.fLogin.bUnlock.ForeColor = gainsboro;
      MyProject.Forms.fLogin.tbPassword.BackColor = gainsboro;
      MyProject.Forms.fLogin.tbPassword.ForeColor = color;
      MyProject.Forms.fHistory.BackColor = gainsboro;
      MyProject.Forms.fHistory.ForeColor = color;
      MyProject.Forms.fHistory.cbAutoClear.ForeColor = color;
      MyProject.Forms.fHistory.cbAutoLock.ForeColor = color;
      MyProject.Forms.fHistory.txtAutoClear.ForeColor = color;
      MyProject.Forms.fHistory.txtAutoLock.ForeColor = color;
      MyProject.Forms.fHistory.listHistory.BackColor = gainsboro;
      MyProject.Forms.fHistory.listHistory.ForeColor = color;
      MyProject.Forms.fDownloads.BackColor = gainsboro;
      MyProject.Forms.fDownloads.ForeColor = color;
      MyProject.Forms.fBookmarks.BackColor = gainsboro;
      MyProject.Forms.fBookmarks.ForeColor = color;
      MyProject.Forms.fBookmarks.txtName.ForeColor = color;
      MyProject.Forms.fBookmarks.txtUrl.ForeColor = color;
      MyProject.Forms.fBookmarks.tbName.BackColor = silver;
      MyProject.Forms.fBookmarks.tbName.ForeColor = color;
      MyProject.Forms.fBookmarks.tbUrl.BackColor = silver;
      MyProject.Forms.fBookmarks.tbUrl.ForeColor = color;
      MyProject.Forms.fBookmarks.bAdd.BackgroundImage = (Image) Resources.add_dark;
      MyProject.Forms.fBookmarks.bAdd.ForeColor = gainsboro;
      MyProject.Forms.fBookmarks.listBookmarks.BackColor = gainsboro;
      MyProject.Forms.fBookmarks.listBookmarks.ForeColor = color;
      MyProject.Forms.fOptions.BackColor = gainsboro;
      MyProject.Forms.fOptions.ForeColor = color;
      MyProject.Forms.fOptions.txtHomepage.ForeColor = color;
      MyProject.Forms.fOptions.txtNewPassword.ForeColor = color;
      MyProject.Forms.fOptions.txtOldPassword.ForeColor = color;
      MyProject.Forms.fOptions.txtSearchEngine.ForeColor = color;
      MyProject.Forms.fOptions.txtTheme.ForeColor = color;
      MyProject.Forms.fOptions.tbHomepage.BackColor = silver;
      MyProject.Forms.fOptions.tbHomepage.ForeColor = color;
      MyProject.Forms.fOptions.tbNewPassword.BackColor = silver;
      MyProject.Forms.fOptions.tbNewPassword.ForeColor = color;
      MyProject.Forms.fOptions.tbOldPassword.BackColor = silver;
      MyProject.Forms.fOptions.tbOldPassword.ForeColor = color;
      MyProject.Forms.fOptions.bSetHomepage.BackgroundImage = (Image) Resources.accept_dark;
      MyProject.Forms.fOptions.bSetHomepage.ForeColor = gainsboro;
      MyProject.Forms.fOptions.bCurrentPage.ForeColor = color;
      MyProject.Forms.fOptions.bChangePassword.BackgroundImage = (Image) Resources.accept_dark;
      MyProject.Forms.fOptions.bChangePassword.ForeColor = gainsboro;
      MyProject.Forms.fOptions.comboTheme.BackColor = silver;
      MyProject.Forms.fOptions.comboTheme.ForeColor = color;
      MyProject.Forms.fOptions.comboSearch.BackColor = silver;
      MyProject.Forms.fOptions.comboSearch.ForeColor = color;
      MyProject.Forms.fOptions.gbPreferences.ForeColor = color;
      MyProject.Forms.fOptions.cbTopSearchBar.ForeColor = color;
    }

    internal void loadFavicon()
    {
      try
      {
        Uri uri = new Uri(((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Url.ToString());
        if (uri.HostNameType != UriHostNameType.Dns)
          return;
        this.picFavicon.Image = Image.FromStream(((HttpWebResponse) WebRequest.Create("http://" + uri.Host + "/favicon.ico").GetResponse()).GetResponseStream());
        this.picFavicon.SizeMode = PictureBoxSizeMode.CenterImage;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.picFavicon.Image = (Image) Resources.favicon;
        this.picFavicon.SizeMode = PictureBoxSizeMode.CenterImage;
        ProjectData.ClearProjectError();
      }
    }

    internal void loadNewTab()
    {
      WebBrowser webBrowser = new WebBrowser();
      this.tcWeb.TabPages.Add("New Tab");
      this.tcWeb.SelectTab(this.tab);
      webBrowser.Dock = DockStyle.Fill;
      this.tcWeb.SelectedTab.Controls.Add((Control) webBrowser);
      webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.loadComplete);
      this.tab = checked (this.tab + 1);
    }

    internal void loadRemoveTab()
    {
      if (this.tcWeb.TabPages.Count == 1)
        return;
      this.tcWeb.TabPages.RemoveAt(this.tcWeb.SelectedIndex);
      this.tcWeb.SelectTab(checked (this.tcWeb.TabPages.Count - 1));
      this.tab = checked (this.tab - 1);
    }

    internal void loadBookmarks()
    {
      MyProject.Forms.fBookmarks.listBookmarks.Items.Clear();
      foreach (object obj in MySettingsProperty.Settings.varBookmark)
        MyProject.Forms.fBookmarks.listBookmarks.Items.Add(obj);
      try
      {
        NewLateBinding.LateSetComplex(this.fav0(), (System.Type) null, "Visible", new object[1]
        {
          (object) true
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav0(), (System.Type) null, "Text", new object[1]
        {
          (object) MySettingsProperty.Settings.varBookmark[0]
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        NewLateBinding.LateSetComplex(this.fav0(), (System.Type) null, "Visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        ProjectData.ClearProjectError();
      }
      try
      {
        NewLateBinding.LateSetComplex(this.fav1(), (System.Type) null, "Visible", new object[1]
        {
          (object) true
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav1(), (System.Type) null, "Text", new object[1]
        {
          (object) MySettingsProperty.Settings.varBookmark[1]
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        NewLateBinding.LateSetComplex(this.fav1(), (System.Type) null, "Visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        ProjectData.ClearProjectError();
      }
      try
      {
        NewLateBinding.LateSetComplex(this.fav2(), (System.Type) null, "Visible", new object[1]
        {
          (object) true
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav2(), (System.Type) null, "Text", new object[1]
        {
          (object) MySettingsProperty.Settings.varBookmark[2]
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        NewLateBinding.LateSetComplex(this.fav2(), (System.Type) null, "Visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        ProjectData.ClearProjectError();
      }
      try
      {
        NewLateBinding.LateSetComplex(this.fav3(), (System.Type) null, "Visible", new object[1]
        {
          (object) true
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav3(), (System.Type) null, "Text", new object[1]
        {
          (object) MySettingsProperty.Settings.varBookmark[3]
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        NewLateBinding.LateSetComplex(this.fav3(), (System.Type) null, "Visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        ProjectData.ClearProjectError();
      }
      try
      {
        NewLateBinding.LateSetComplex(this.fav4(), (System.Type) null, "Visible", new object[1]
        {
          (object) true
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav4(), (System.Type) null, "Text", new object[1]
        {
          (object) MySettingsProperty.Settings.varBookmark[4]
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        NewLateBinding.LateSetComplex(this.fav4(), (System.Type) null, "Visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        ProjectData.ClearProjectError();
      }
      try
      {
        NewLateBinding.LateSetComplex(this.fav5(), (System.Type) null, "Visible", new object[1]
        {
          (object) true
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav5(), (System.Type) null, "Text", new object[1]
        {
          (object) MySettingsProperty.Settings.varBookmark[5]
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        NewLateBinding.LateSetComplex(this.fav5(), (System.Type) null, "Visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        ProjectData.ClearProjectError();
      }
      try
      {
        NewLateBinding.LateSetComplex(this.fav6(), (System.Type) null, "Visible", new object[1]
        {
          (object) true
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav6(), (System.Type) null, "Text", new object[1]
        {
          (object) MySettingsProperty.Settings.varBookmark[6]
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        NewLateBinding.LateSetComplex(this.fav6(), (System.Type) null, "Visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        ProjectData.ClearProjectError();
      }
      try
      {
        NewLateBinding.LateSetComplex(this.fav7(), (System.Type) null, "Visible", new object[1]
        {
          (object) true
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav7(), (System.Type) null, "Text", new object[1]
        {
          (object) MySettingsProperty.Settings.varBookmark[7]
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        NewLateBinding.LateSetComplex(this.fav7(), (System.Type) null, "Visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        ProjectData.ClearProjectError();
      }
      try
      {
        NewLateBinding.LateSetComplex(this.fav8(), (System.Type) null, "Visible", new object[1]
        {
          (object) true
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav8(), (System.Type) null, "Text", new object[1]
        {
          (object) MySettingsProperty.Settings.varBookmark[8]
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        NewLateBinding.LateSetComplex(this.fav8(), (System.Type) null, "Visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        ProjectData.ClearProjectError();
      }
      try
      {
        NewLateBinding.LateSetComplex(this.fav9(), (System.Type) null, "Visible", new object[1]
        {
          (object) true
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        NewLateBinding.LateSetComplex(this.fav9(), (System.Type) null, "Text", new object[1]
        {
          (object) MySettingsProperty.Settings.varBookmark[9]
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        NewLateBinding.LateSetComplex(this.fav9(), (System.Type) null, "Visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null, 0 != 0, 1 != 0);
        ProjectData.ClearProjectError();
      }
    }

    internal void loadCache()
    {
      if (Conversions.ToBoolean(MySettingsProperty.Settings.cache))
        return;
      int num = (int) MessageBox.Show("Welcome to Green Dragon Browser!  Just a quick tip, version 1.0 includes many visual enhancements.  To clean up the interface, some options have been hidden.  You may see many extra options by right clicking on some items.  For any questions, please email me!", "Welcome");
      MySettingsProperty.Settings.cache = Conversions.ToString(true);
      MySettingsProperty.Settings.Save();
    }

    private void fav_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem) sender;
      if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav0())))
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[0]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[0];
      }
      else if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav1())))
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[1]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[1];
      }
      else if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav2())))
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[2]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[2];
      }
      else if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav3())))
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[3]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[3];
      }
      else if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav4())))
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[4]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[4];
      }
      else if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav5())))
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[5]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[5];
      }
      else if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav6())))
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[6]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[6];
      }
      else if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav7())))
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[7]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[7];
      }
      else if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav8())))
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[8]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[8];
      }
      else
      {
        if (!toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav9())))
          return;
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[9]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[9];
      }
    }

    private void fav_MouseUp(object sender, MouseEventArgs e)
    {
      ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem) sender;
      if (e.Button == MouseButtons.Right)
      {
        if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav0())))
          MySettingsProperty.Settings.varSelectedFav = "fav0";
        if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav1())))
          MySettingsProperty.Settings.varSelectedFav = "fav1";
        if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav2())))
          MySettingsProperty.Settings.varSelectedFav = "fav2";
        if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav3())))
          MySettingsProperty.Settings.varSelectedFav = "fav3";
        if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav4())))
          MySettingsProperty.Settings.varSelectedFav = "fav4";
        if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav5())))
          MySettingsProperty.Settings.varSelectedFav = "fav5";
        if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav6())))
          MySettingsProperty.Settings.varSelectedFav = "fav6";
        if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav7())))
          MySettingsProperty.Settings.varSelectedFav = "fav7";
        if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav8())))
          MySettingsProperty.Settings.varSelectedFav = "fav8";
        if (toolStripMenuItem.Equals(RuntimeHelpers.GetObjectValue(this.fav9())))
          MySettingsProperty.Settings.varSelectedFav = "fav9";
        this.cmFav.Show(Cursor.Position.X, Cursor.Position.Y);
      }
      MySettingsProperty.Settings.Save();
    }

    private void iAddTab_Click(object sender, EventArgs e)
    {
      this.loadNewTab();
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varHomepage);
    }

    private void iRemoveTab_Click(object sender, EventArgs e)
    {
      this.loadRemoveTab();
    }

    private void iNewWindow_Click(object sender, EventArgs e)
    {
      ((Control) new fMain()).Show();
    }

    private void iLockWindow_Click(object sender, EventArgs e)
    {
      ((Control) MyProject.Forms.fLogin).Show();
      MyProject.Forms.fLogin.WindowState = FormWindowState.Normal;
      MyProject.Forms.fLogin.BringToFront();
    }

    private void iPrint_Click(object sender, EventArgs e)
    {
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).ShowPrintDialog();
    }

    private void iPrintPreview_Click(object sender, EventArgs e)
    {
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).ShowPrintPreviewDialog();
    }

    private void iPageSetup_Click(object sender, EventArgs e)
    {
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).ShowPageSetupDialog();
    }

    private void iProperties_Click(object sender, EventArgs e)
    {
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).ShowPropertiesDialog();
    }

    private void iExit_Click(object sender, EventArgs e)
    {
      MySettingsProperty.Settings.Save();
      Application.Exit();
    }

    private void iNotepad_Click(object sender, EventArgs e)
    {
      ((Control) MyProject.Forms.fNotepad).Show();
      MyProject.Forms.fNotepad.WindowState = FormWindowState.Normal;
      MyProject.Forms.fNotepad.BringToFront();
    }

    private void iScreenshot_Click(object sender, EventArgs e)
    {
      ((Control) MyProject.Forms.fScreenshot).Show();
      MyProject.Forms.fScreenshot.WindowState = FormWindowState.Normal;
      MyProject.Forms.fScreenshot.BringToFront();
    }

    private void iOptions_Click(object sender, EventArgs e)
    {
      ((Control) MyProject.Forms.fOptions).Show();
      MyProject.Forms.fOptions.WindowState = FormWindowState.Normal;
      MyProject.Forms.fOptions.BringToFront();
    }

    private void iHistory_Click(object sender, EventArgs e)
    {
      ((Control) MyProject.Forms.fHistory).Show();
      MyProject.Forms.fHistory.WindowState = FormWindowState.Normal;
      MyProject.Forms.fHistory.BringToFront();
    }

    private void iBookmarks_Click(object sender, EventArgs e)
    {
      ((Control) MyProject.Forms.fBookmarks).Show();
      MyProject.Forms.fBookmarks.WindowState = FormWindowState.Normal;
      MyProject.Forms.fBookmarks.BringToFront();
    }

    private void iDownloads_Click(object sender, EventArgs e)
    {
      ((Control) MyProject.Forms.fDownloads).Show();
      MyProject.Forms.fDownloads.WindowState = FormWindowState.Normal;
      MyProject.Forms.fDownloads.BringToFront();
    }

    private void iHideMenu_Click(object sender, EventArgs e)
    {
      if (this.pMenu.Visible)
      {
        this.pMenu.Visible = false;
        this.iAutoHideMenu.Checked = true;
        MySettingsProperty.Settings.autoHideMenu = Conversions.ToString(true);
        MySettingsProperty.Settings.Save();
      }
      else
      {
        this.pMenu.Visible = true;
        this.iAutoHideMenu.Checked = false;
        MySettingsProperty.Settings.autoHideMenu = Conversions.ToString(false);
        MySettingsProperty.Settings.Save();
      }
    }

    private void iFullscreen_Click(object sender, EventArgs e)
    {
      if (!this.pHover.Visible)
      {
        this.pSearch.Visible = false;
        this.pMenu.Visible = false;
        this.pHover.Visible = true;
        this.iFullscreen.Checked = true;
        this.WindowState = FormWindowState.Normal;
        this.FormBorderStyle = FormBorderStyle.None;
        this.WindowState = FormWindowState.Maximized;
        MySettingsProperty.Settings.varFullscreen = Conversions.ToString(true);
        MySettingsProperty.Settings.Save();
      }
      else
      {
        this.pSearch.Visible = true;
        this.pMenu.Visible = true;
        this.pHover.Visible = false;
        this.iFullscreen.Checked = false;
        this.WindowState = FormWindowState.Normal;
        this.FormBorderStyle = FormBorderStyle.Sizable;
        this.WindowState = FormWindowState.Maximized;
        MySettingsProperty.Settings.varFullscreen = Conversions.ToString(false);
        MySettingsProperty.Settings.Save();
      }
    }

    private void bWebBack_Click(object sender, EventArgs e)
    {
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).GoBack();
    }

    private void bWebForward_Click(object sender, EventArgs e)
    {
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).GoForward();
    }

    private void bSearch_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.tbSearch.Text, "#_debug", false) == 0)
      {
        MySettingsProperty.Settings.Reset();
        MySettingsProperty.Settings.Save();
        Application.Exit();
      }
      MySettingsProperty.Settings.autoComplete.Add(this.tbSearch.Text);
      try
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(this.tbSearch.Text);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(this.tbSearch.Text);
        ProjectData.ClearProjectError();
      }
      MySettingsProperty.Settings.varHistory.Add(((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Url.ToString());
      this.loadVar();
    }

    private void bBookmark_Click(object sender, EventArgs e)
    {
      if (MySettingsProperty.Settings.varBookmark.Contains(((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).DocumentTitle))
        return;
      if (Conversions.ToBoolean(MySettingsProperty.Settings.themeDark))
        this.bBookmark.BackgroundImage = (Image) Resources.bookmark_light;
      else
        this.bBookmark.BackgroundImage = (Image) Resources.bookmark_dark;
      MySettingsProperty.Settings.varBookmark.Add(((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).DocumentTitle);
      MySettingsProperty.Settings.varUrl.Add(((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Url.ToString());
      MySettingsProperty.Settings.Save();
      this.loadBookmarks();
    }

    private void bLock_Click(object sender, EventArgs e)
    {
      ((Control) MyProject.Forms.fLogin).Show();
      MyProject.Forms.fLogin.WindowState = FormWindowState.Normal;
      MyProject.Forms.fLogin.BringToFront();
      MySettingsProperty.Settings.Save();
    }

    private void tbSearch_DoubleClick(object sender, EventArgs e)
    {
      this.tbSearch.SelectAll();
    }

    private void tbSearch_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      MySettingsProperty.Settings.autoComplete.Add(this.tbSearch.Text);
      if (this.tbSearch.Text.Contains("www.") | this.tbSearch.Text.Contains(".com") | this.tbSearch.Text.Contains(".net") | this.tbSearch.Text.Contains(".org") | this.tbSearch.Text.Contains(".edu"))
      {
        try
        {
          ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(this.tbSearch.Text);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(this.tbSearch.Text);
          ProjectData.ClearProjectError();
        }
      }
      else if (Conversions.ToBoolean(MySettingsProperty.Settings.searchBing))
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate("http://www.bing.com/search?q=" + this.tbSearch.Text);
      else if (Conversions.ToBoolean(MySettingsProperty.Settings.searchYoutube))
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate("http://www.youtube.com/results?search_query=" + this.tbSearch.Text + "&aq=f");
      else
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate("http://www.google.com/search?hl=en&q=" + this.tbSearch.Text + "&btnG=Google+Search&meta=");
      MySettingsProperty.Settings.varHistory.Add(((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Url.ToString());
      this.loadVar();
    }

    private void picFavicon_Click(object sender, EventArgs e)
    {
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Refresh();
    }

    private void tcWeb_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        this.tbSearch.Text = ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Url.ToString();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.loadFavicon();
    }

    private void tcWeb_MouseUp(object sender, MouseEventArgs e)
    {
      try
      {
        if (e.Button != MouseButtons.Right)
          return;
        int num1 = 0;
        int num2 = checked (this.tcWeb.TabCount - 1);
        int index = num1;
        while (index <= num2)
        {
          if (this.tcWeb.GetTabRect(index).Contains(e.Location))
            this.tcWeb.SelectTab(index);
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void timerAutoLock_Tick(object sender, EventArgs e)
    {
      this.bLock.PerformClick();
    }

    private void iOpenInNewTab_Click(object sender, EventArgs e)
    {
      this.loadNewTab();
      if (Operators.CompareString(MySettingsProperty.Settings.varSelectedFav, "fav0", false) == 0)
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[0]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[0];
      }
      else if (Operators.CompareString(MySettingsProperty.Settings.varSelectedFav, "fav1", false) == 0)
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[1]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[1];
      }
      else if (Operators.CompareString(MySettingsProperty.Settings.varSelectedFav, "fav2", false) == 0)
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[2]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[2];
      }
      else if (Operators.CompareString(MySettingsProperty.Settings.varSelectedFav, "fav3", false) == 0)
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[3]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[3];
      }
      else if (Operators.CompareString(MySettingsProperty.Settings.varSelectedFav, "fav4", false) == 0)
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[4]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[4];
      }
      else if (Operators.CompareString(MySettingsProperty.Settings.varSelectedFav, "fav5", false) == 0)
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[5]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[5];
      }
      else if (Operators.CompareString(MySettingsProperty.Settings.varSelectedFav, "fav6", false) == 0)
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[6]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[6];
      }
      else if (Operators.CompareString(MySettingsProperty.Settings.varSelectedFav, "fav7", false) == 0)
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[7]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[7];
      }
      else if (Operators.CompareString(MySettingsProperty.Settings.varSelectedFav, "fav8", false) == 0)
      {
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[8]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[8];
      }
      else
      {
        if (Operators.CompareString(MySettingsProperty.Settings.varSelectedFav, "fav9", false) != 0)
          return;
        ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varUrl[9]);
        this.tbSearch.Text = MySettingsProperty.Settings.varUrl[9];
      }
    }

    private void iBookmarksManager_Click(object sender, EventArgs e)
    {
      this.iBookmarks.PerformClick();
    }

    private void iSearchBing_Click(object sender, EventArgs e)
    {
      MySettingsProperty.Settings.autoComplete.Add(this.tbSearch.Text);
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate("http://www.bing.com/search?q=" + this.tbSearch.Text);
    }

    private void iSearchGoogle_Click(object sender, EventArgs e)
    {
      MySettingsProperty.Settings.autoComplete.Add(this.tbSearch.Text);
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate("http://www.google.com/search?hl=en&q=" + this.tbSearch.Text + "&btnG=Google+Search&meta=");
    }

    private void iSearchYoutube_Click(object sender, EventArgs e)
    {
      MySettingsProperty.Settings.autoComplete.Add(this.tbSearch.Text);
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate("http://www.youtube.com/results?search_query=" + this.tbSearch.Text + "&aq=f");
    }

    private void iNewTab_Click(object sender, EventArgs e)
    {
      this.loadNewTab();
      ((WebBrowser) this.tcWeb.SelectedTab.Controls[0]).Navigate(MySettingsProperty.Settings.varHomepage);
    }

    private void iDeleteTab_Click(object sender, EventArgs e)
    {
      this.loadRemoveTab();
    }

    private void pMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private object fav0()
    {
      throw new NotImplementedException();
    }

    private object fav1()
    {
      throw new NotImplementedException();
    }

    private object fav2()
    {
      throw new NotImplementedException();
    }

    private object fav3()
    {
      throw new NotImplementedException();
    }

    private object fav4()
    {
      throw new NotImplementedException();
    }

    private object fav5()
    {
      throw new NotImplementedException();
    }

    private object fav6()
    {
      throw new NotImplementedException();
    }

    private object fav7()
    {
      throw new NotImplementedException();
    }

    private object fav8()
    {
      throw new NotImplementedException();
    }

    private object fav9()
    {
      throw new NotImplementedException();
    }
  }
}
