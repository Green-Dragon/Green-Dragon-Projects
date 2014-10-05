// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.MainWindow
// Assembly: Green Dragon Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d25b577927d337c7
// MVID: 43B6EF03-694B-4A1E-BE9F-3F26039BA1DF
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser Simple.exe

using Green_Dragon_Browser.My;
using Green_Dragon_Browser.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  [DesignerGenerated]
  public class MainWindow : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("backButton")]
    private ToolStripButton _backButton;
    [AccessedThroughProperty("forwardButton")]
    private ToolStripButton _forwardButton;
    [AccessedThroughProperty("refreshButton")]
    private ToolStripButton _refreshButton;
    [AccessedThroughProperty("stopButton")]
    private ToolStripButton _stopButton;
    [AccessedThroughProperty("closeTabMenuItem")]
    private ToolStripMenuItem _closeTabMenuItem;
    [AccessedThroughProperty("closeTabButton")]
    private ToolStripButton _closeTabButton;
    [AccessedThroughProperty("refreshMenuItem")]
    private ToolStripMenuItem _refreshMenuItem;
    [AccessedThroughProperty("stopMenuItem")]
    private ToolStripMenuItem _stopMenuItem;
    [AccessedThroughProperty("backMenuItem")]
    private ToolStripMenuItem _backMenuItem;
    [AccessedThroughProperty("forwardMenuItem")]
    private ToolStripMenuItem _forwardMenuItem;
    [AccessedThroughProperty("newTabMenuItem")]
    private ToolStripMenuItem _newTabMenuItem;
    [AccessedThroughProperty("addressCombo")]
    private ToolStripComboBox _addressCombo;
    [AccessedThroughProperty("mainMenu")]
    private MenuStrip _mainMenu;
    [AccessedThroughProperty("toolbar")]
    private ToolStrip _toolbar;
    [AccessedThroughProperty("statusbar")]
    private StatusStrip _statusbar;
    [AccessedThroughProperty("tabs")]
    private WebBrowserTabControl _tabs;
    [AccessedThroughProperty("goButton")]
    private ToolStripButton _goButton;
    [AccessedThroughProperty("browserStatusTextLabel")]
    private ToolStripStatusLabel _browserStatusTextLabel;
    [AccessedThroughProperty("pageLoadProgress")]
    private ToolStripProgressBar _pageLoadProgress;
    [AccessedThroughProperty("homeMenuItem")]
    private ToolStripMenuItem _homeMenuItem;
    [AccessedThroughProperty("favouritesButton")]
    private ToolStripSplitButton _favouritesButton;
    [AccessedThroughProperty("AddToFavouritesMenuItem")]
    private ToolStripMenuItem _AddToFavouritesMenuItem;
    [AccessedThroughProperty("MainSplitContainer")]
    private SplitContainer _MainSplitContainer;
    [AccessedThroughProperty("FavouritesTabControl")]
    private TabControl _FavouritesTabControl;
    [AccessedThroughProperty("FavouritesTabPage")]
    private TabPage _FavouritesTabPage;
    [AccessedThroughProperty("FavouritesTreeView")]
    private TreeView _FavouritesTreeView;
    [AccessedThroughProperty("favouritesContextMenu")]
    private ContextMenuStrip _favouritesContextMenu;
    [AccessedThroughProperty("DeleteFavouriteToolStripMenuItem")]
    private ToolStripMenuItem _DeleteFavouriteToolStripMenuItem;
    [AccessedThroughProperty("EditFavouriteToolStripMenuItem")]
    private ToolStripMenuItem _EditFavouriteToolStripMenuItem;
    [AccessedThroughProperty("FeedsTabPage")]
    private TabPage _FeedsTabPage;
    [AccessedThroughProperty("HistoryTabPage")]
    private TabPage _HistoryTabPage;
    private readonly int addressFieldSizeOffset;
    [AccessedThroughProperty("currentBrowser")]
    private WebBrowser _currentBrowser;
    private StringBuilder sb;
    private int result;

    private virtual ToolStripButton backButton
    {
      [DebuggerNonUserCode] get
      {
        return this._backButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.backButton_Click);
        if (this._backButton != null)
          this._backButton.Click -= eventHandler;
        this._backButton = value;
        if (this._backButton == null)
          return;
        this._backButton.Click += eventHandler;
      }
    }

    private virtual ToolStripButton forwardButton
    {
      [DebuggerNonUserCode] get
      {
        return this._forwardButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.forwardButton_Click);
        if (this._forwardButton != null)
          this._forwardButton.Click -= eventHandler;
        this._forwardButton = value;
        if (this._forwardButton == null)
          return;
        this._forwardButton.Click += eventHandler;
      }
    }

    private virtual ToolStripButton refreshButton
    {
      [DebuggerNonUserCode] get
      {
        return this._refreshButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.refreshButton_Click);
        if (this._refreshButton != null)
          this._refreshButton.Click -= eventHandler;
        this._refreshButton = value;
        if (this._refreshButton == null)
          return;
        this._refreshButton.Click += eventHandler;
      }
    }

    private virtual ToolStripButton stopButton
    {
      [DebuggerNonUserCode] get
      {
        return this._stopButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.stopButton_Click);
        if (this._stopButton != null)
          this._stopButton.Click -= eventHandler;
        this._stopButton = value;
        if (this._stopButton == null)
          return;
        this._stopButton.Click += eventHandler;
      }
    }

    private virtual ToolStripMenuItem closeTabMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._closeTabMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.closeTabMenuItem_Click);
        if (this._closeTabMenuItem != null)
          this._closeTabMenuItem.Click -= eventHandler;
        this._closeTabMenuItem = value;
        if (this._closeTabMenuItem == null)
          return;
        this._closeTabMenuItem.Click += eventHandler;
      }
    }

    private virtual ToolStripButton closeTabButton
    {
      [DebuggerNonUserCode] get
      {
        return this._closeTabButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.closeTabButton_Click);
        if (this._closeTabButton != null)
          this._closeTabButton.Click -= eventHandler;
        this._closeTabButton = value;
        if (this._closeTabButton == null)
          return;
        this._closeTabButton.Click += eventHandler;
      }
    }

    private virtual ToolStripMenuItem refreshMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._refreshMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.refreshMenuItem_Click);
        if (this._refreshMenuItem != null)
          this._refreshMenuItem.Click -= eventHandler;
        this._refreshMenuItem = value;
        if (this._refreshMenuItem == null)
          return;
        this._refreshMenuItem.Click += eventHandler;
      }
    }

    private virtual ToolStripMenuItem stopMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._stopMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.stopMenuItem_Click);
        if (this._stopMenuItem != null)
          this._stopMenuItem.Click -= eventHandler;
        this._stopMenuItem = value;
        if (this._stopMenuItem == null)
          return;
        this._stopMenuItem.Click += eventHandler;
      }
    }

    private virtual ToolStripMenuItem backMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._backMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.backMenuItem_Click);
        if (this._backMenuItem != null)
          this._backMenuItem.Click -= eventHandler;
        this._backMenuItem = value;
        if (this._backMenuItem == null)
          return;
        this._backMenuItem.Click += eventHandler;
      }
    }

    private virtual ToolStripMenuItem forwardMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._forwardMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.forwardMenuItem_Click);
        if (this._forwardMenuItem != null)
          this._forwardMenuItem.Click -= eventHandler;
        this._forwardMenuItem = value;
        if (this._forwardMenuItem == null)
          return;
        this._forwardMenuItem.Click += eventHandler;
      }
    }

    private virtual ToolStripMenuItem newTabMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._newTabMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.newTabMenuItem_Click);
        if (this._newTabMenuItem != null)
          this._newTabMenuItem.Click -= eventHandler;
        this._newTabMenuItem = value;
        if (this._newTabMenuItem == null)
          return;
        this._newTabMenuItem.Click += eventHandler;
      }
    }

    private virtual ToolStripComboBox addressCombo
    {
      [DebuggerNonUserCode] get
      {
        return this._addressCombo;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.addressCombo_KeyDown);
        if (this._addressCombo != null)
          this._addressCombo.KeyDown -= keyEventHandler;
        this._addressCombo = value;
        if (this._addressCombo == null)
          return;
        this._addressCombo.KeyDown += keyEventHandler;
      }
    }

    private virtual MenuStrip mainMenu
    {
      [DebuggerNonUserCode] get
      {
        return this._mainMenu;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._mainMenu = value;
      }
    }

    private virtual ToolStrip toolbar
    {
      [DebuggerNonUserCode] get
      {
        return this._toolbar;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._toolbar = value;
      }
    }

    private virtual StatusStrip statusbar
    {
      [DebuggerNonUserCode] get
      {
        return this._statusbar;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._statusbar = value;
      }
    }

    private virtual WebBrowserTabControl tabs
    {
      [DebuggerNonUserCode] get
      {
        return this._tabs;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tabs_SelectedIndexChanged);
        if (this._tabs != null)
          this._tabs.SelectedIndexChanged -= eventHandler;
        this._tabs = value;
        if (this._tabs == null)
          return;
        this._tabs.SelectedIndexChanged += eventHandler;
      }
    }

    private virtual ToolStripButton goButton
    {
      [DebuggerNonUserCode] get
      {
        return this._goButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.goButton_Click);
        if (this._goButton != null)
          this._goButton.Click -= eventHandler;
        this._goButton = value;
        if (this._goButton == null)
          return;
        this._goButton.Click += eventHandler;
      }
    }

    private virtual ToolStripStatusLabel browserStatusTextLabel
    {
      [DebuggerNonUserCode] get
      {
        return this._browserStatusTextLabel;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._browserStatusTextLabel = value;
      }
    }

    private virtual ToolStripProgressBar pageLoadProgress
    {
      [DebuggerNonUserCode] get
      {
        return this._pageLoadProgress;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.pageLoadProgress_VisibleChanged);
        if (this._pageLoadProgress != null)
          this._pageLoadProgress.VisibleChanged -= eventHandler;
        this._pageLoadProgress = value;
        if (this._pageLoadProgress == null)
          return;
        this._pageLoadProgress.VisibleChanged += eventHandler;
      }
    }

    private virtual ToolStripMenuItem homeMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._homeMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.homeMenuItem_Click);
        if (this._homeMenuItem != null)
          this._homeMenuItem.Click -= eventHandler;
        this._homeMenuItem = value;
        if (this._homeMenuItem == null)
          return;
        this._homeMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripSplitButton favouritesButton
    {
      [DebuggerNonUserCode] get
      {
        return this._favouritesButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.favouritesButton_ButtonClick);
        if (this._favouritesButton != null)
          this._favouritesButton.ButtonClick -= eventHandler;
        this._favouritesButton = value;
        if (this._favouritesButton == null)
          return;
        this._favouritesButton.ButtonClick += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem AddToFavouritesMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._AddToFavouritesMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AddToFavouritesMenuItem_Click);
        if (this._AddToFavouritesMenuItem != null)
          this._AddToFavouritesMenuItem.Click -= eventHandler;
        this._AddToFavouritesMenuItem = value;
        if (this._AddToFavouritesMenuItem == null)
          return;
        this._AddToFavouritesMenuItem.Click += eventHandler;
      }
    }

    internal virtual SplitContainer MainSplitContainer
    {
      [DebuggerNonUserCode] get
      {
        return this._MainSplitContainer;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MainSplitContainer = value;
      }
    }

    internal virtual TabControl FavouritesTabControl
    {
      [DebuggerNonUserCode] get
      {
        return this._FavouritesTabControl;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._FavouritesTabControl = value;
      }
    }

    internal virtual TabPage FavouritesTabPage
    {
      [DebuggerNonUserCode] get
      {
        return this._FavouritesTabPage;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._FavouritesTabPage = value;
      }
    }

    internal virtual TreeView FavouritesTreeView
    {
      [DebuggerNonUserCode] get
      {
        return this._FavouritesTreeView;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        TreeNodeMouseClickEventHandler clickEventHandler1 = new TreeNodeMouseClickEventHandler(this.FavouritesTreeView_NodeMouseClick);
        TreeNodeMouseClickEventHandler clickEventHandler2 = new TreeNodeMouseClickEventHandler(this.FavouritesTreeView_NodeMouseDoubleClick);
        TreeViewCancelEventHandler cancelEventHandler = new TreeViewCancelEventHandler(this.FavouritesTreeView_BeforeExpand);
        if (this._FavouritesTreeView != null)
        {
          this._FavouritesTreeView.NodeMouseClick -= clickEventHandler1;
          this._FavouritesTreeView.NodeMouseDoubleClick -= clickEventHandler2;
          this._FavouritesTreeView.BeforeExpand -= cancelEventHandler;
        }
        this._FavouritesTreeView = value;
        if (this._FavouritesTreeView == null)
          return;
        this._FavouritesTreeView.NodeMouseClick += clickEventHandler1;
        this._FavouritesTreeView.NodeMouseDoubleClick += clickEventHandler2;
        this._FavouritesTreeView.BeforeExpand += cancelEventHandler;
      }
    }

    internal virtual ContextMenuStrip favouritesContextMenu
    {
      [DebuggerNonUserCode] get
      {
        return this._favouritesContextMenu;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._favouritesContextMenu = value;
      }
    }

    internal virtual ToolStripMenuItem DeleteFavouriteToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._DeleteFavouriteToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DeleteFavouriteToolStripMenuItem_Click);
        if (this._DeleteFavouriteToolStripMenuItem != null)
          this._DeleteFavouriteToolStripMenuItem.Click -= eventHandler;
        this._DeleteFavouriteToolStripMenuItem = value;
        if (this._DeleteFavouriteToolStripMenuItem == null)
          return;
        this._DeleteFavouriteToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem EditFavouriteToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._EditFavouriteToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EditFavouriteToolStripMenuItem_Click);
        if (this._EditFavouriteToolStripMenuItem != null)
          this._EditFavouriteToolStripMenuItem.Click -= eventHandler;
        this._EditFavouriteToolStripMenuItem = value;
        if (this._EditFavouriteToolStripMenuItem == null)
          return;
        this._EditFavouriteToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual TabPage FeedsTabPage
    {
      [DebuggerNonUserCode] get
      {
        return this._FeedsTabPage;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._FeedsTabPage = value;
      }
    }

    internal virtual TabPage HistoryTabPage
    {
      [DebuggerNonUserCode] get
      {
        return this._HistoryTabPage;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._HistoryTabPage = value;
      }
    }

    private virtual WebBrowser currentBrowser
    {
      [DebuggerNonUserCode] get
      {
        return this._currentBrowser;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        WebBrowserDocumentCompletedEventHandler completedEventHandler = new WebBrowserDocumentCompletedEventHandler(this.currentBrowser_DocumentCompleted);
        EventHandler eventHandler1 = new EventHandler(this.currentBrowser_DocumentTitleChanged);
        WebBrowserProgressChangedEventHandler changedEventHandler = new WebBrowserProgressChangedEventHandler(this.currentBrowser_ProgressChanged);
        EventHandler eventHandler2 = new EventHandler(this.currentBrowser_CanGoForwardChanged);
        EventHandler eventHandler3 = new EventHandler(this.currentBrowser_CanGoBackChanged);
        WebBrowserNavigatedEventHandler navigatedEventHandler = new WebBrowserNavigatedEventHandler(this.currentBrowser_Navigated);
        EventHandler eventHandler4 = new EventHandler(this.currentBrowser_StatusTextChanged);
        if (this._currentBrowser != null)
        {
          this._currentBrowser.DocumentCompleted -= completedEventHandler;
          this._currentBrowser.DocumentTitleChanged -= eventHandler1;
          this._currentBrowser.ProgressChanged -= changedEventHandler;
          this._currentBrowser.CanGoForwardChanged -= eventHandler2;
          this._currentBrowser.CanGoBackChanged -= eventHandler3;
          this._currentBrowser.Navigated -= navigatedEventHandler;
          this._currentBrowser.StatusTextChanged -= eventHandler4;
        }
        this._currentBrowser = value;
        if (this._currentBrowser == null)
          return;
        this._currentBrowser.DocumentCompleted += completedEventHandler;
        this._currentBrowser.DocumentTitleChanged += eventHandler1;
        this._currentBrowser.ProgressChanged += changedEventHandler;
        this._currentBrowser.CanGoForwardChanged += eventHandler2;
        this._currentBrowser.CanGoBackChanged += eventHandler3;
        this._currentBrowser.Navigated += navigatedEventHandler;
        this._currentBrowser.StatusTextChanged += eventHandler4;
      }
    }

    [DebuggerNonUserCode]
    static MainWindow()
    {
    }

    public MainWindow()
    {
      this.Load += new EventHandler(this.MainWindow_Load);
      this.SizeChanged += new EventHandler(this.MainWindow_SizeChanged);
      MainWindow.__ENCAddToList((object) this);
      this.sb = new StringBuilder(500);
      this.InitializeComponent();
      this.addressFieldSizeOffset = checked (this.Width - this.addressCombo.Width);
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      List<WeakReference> list = MainWindow.__ENCList;
      Monitor.Enter((object) list);
      try
      {
        if (MainWindow.__ENCList.Count == MainWindow.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (MainWindow.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (MainWindow.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                MainWindow.__ENCList[index1] = MainWindow.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          MainWindow.__ENCList.RemoveRange(index1, checked (MainWindow.__ENCList.Count - index1));
          MainWindow.__ENCList.Capacity = MainWindow.__ENCList.Count;
        }
        MainWindow.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MainWindow));
      this.newTabMenuItem = new ToolStripMenuItem();
      this.closeTabMenuItem = new ToolStripMenuItem();
      this.refreshMenuItem = new ToolStripMenuItem();
      this.stopMenuItem = new ToolStripMenuItem();
      this.backMenuItem = new ToolStripMenuItem();
      this.forwardMenuItem = new ToolStripMenuItem();
      this.homeMenuItem = new ToolStripMenuItem();
      this.goButton = new ToolStripButton();
      this.mainMenu = new MenuStrip();
      this.toolbar = new ToolStrip();
      this.backButton = new ToolStripButton();
      this.forwardButton = new ToolStripButton();
      this.refreshButton = new ToolStripButton();
      this.stopButton = new ToolStripButton();
      this.favouritesButton = new ToolStripSplitButton();
      this.AddToFavouritesMenuItem = new ToolStripMenuItem();
      this.closeTabButton = new ToolStripButton();
      this.addressCombo = new ToolStripComboBox();
      this.statusbar = new StatusStrip();
      this.browserStatusTextLabel = new ToolStripStatusLabel();
      this.pageLoadProgress = new ToolStripProgressBar();
      this.MainSplitContainer = new SplitContainer();
      this.FavouritesTabControl = new TabControl();
      this.FavouritesTabPage = new TabPage();
      this.FavouritesTreeView = new TreeView();
      this.favouritesContextMenu = new ContextMenuStrip(this.components);
      this.DeleteFavouriteToolStripMenuItem = new ToolStripMenuItem();
      this.EditFavouriteToolStripMenuItem = new ToolStripMenuItem();
      this.FeedsTabPage = new TabPage();
      this.HistoryTabPage = new TabPage();
      this.tabs = new WebBrowserTabControl();
      ToolStripSeparator toolStripSeparator1 = new ToolStripSeparator();
      ToolStripButton toolStripButton1 = new ToolStripButton();
      ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
      ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
      ToolStripSeparator toolStripSeparator2 = new ToolStripSeparator();
      ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
      ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
      ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem();
      ToolStripSeparator toolStripSeparator3 = new ToolStripSeparator();
      ToolStripLabel toolStripLabel1 = new ToolStripLabel();
      ToolStripButton toolStripButton2 = new ToolStripButton();
      ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem();
      ToolStripMenuItem toolStripMenuItem7 = new ToolStripMenuItem();
      this.mainMenu.SuspendLayout();
      this.toolbar.SuspendLayout();
      this.statusbar.SuspendLayout();
      this.MainSplitContainer.Panel1.SuspendLayout();
      this.MainSplitContainer.Panel2.SuspendLayout();
      this.MainSplitContainer.SuspendLayout();
      this.FavouritesTabControl.SuspendLayout();
      this.FavouritesTabPage.SuspendLayout();
      this.favouritesContextMenu.SuspendLayout();
      this.SuspendLayout();
      toolStripSeparator1.Name = "toolbarSeparator1";
      ToolStripSeparator toolStripSeparator4 = toolStripSeparator1;
      Size size1 = new Size(6, 25);
      Size size2 = size1;
      toolStripSeparator4.Size = size2;
      toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      toolStripButton1.Image = (Image) componentResourceManager.GetObject("newTabButton.Image");
      toolStripButton1.ImageTransparentColor = Color.Magenta;
      toolStripButton1.Name = "newTabButton";
      ToolStripButton toolStripButton3 = toolStripButton1;
      size1 = new Size(23, 22);
      Size size3 = size1;
      toolStripButton3.Size = size3;
      toolStripButton1.Text = "New Tab";
      toolStripButton1.Click += new EventHandler(this.newTabButton_Click);
      toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.newTabMenuItem,
        (ToolStripItem) toolStripMenuItem2,
        (ToolStripItem) this.closeTabMenuItem,
        (ToolStripItem) toolStripSeparator2,
        (ToolStripItem) toolStripMenuItem3
      });
      toolStripMenuItem1.Name = "fileMenuItem";
      ToolStripMenuItem toolStripMenuItem8 = toolStripMenuItem1;
      size1 = new Size(37, 20);
      Size size4 = size1;
      toolStripMenuItem8.Size = size4;
      toolStripMenuItem1.Text = "&File";
      this.newTabMenuItem.Image = (Image) componentResourceManager.GetObject("newTabMenuItem.Image");
      this.newTabMenuItem.Name = "newTabMenuItem";
      this.newTabMenuItem.ShortcutKeys = Keys.N | Keys.Control;
      ToolStripMenuItem newTabMenuItem = this.newTabMenuItem;
      size1 = new Size(164, 22);
      Size size5 = size1;
      newTabMenuItem.Size = size5;
      this.newTabMenuItem.Text = "&New Tab";
      toolStripMenuItem2.Enabled = false;
      toolStripMenuItem2.Name = "openMenuItem";
      toolStripMenuItem2.ShortcutKeys = Keys.O | Keys.Control;
      ToolStripMenuItem toolStripMenuItem9 = toolStripMenuItem2;
      size1 = new Size(164, 22);
      Size size6 = size1;
      toolStripMenuItem9.Size = size6;
      toolStripMenuItem2.Text = "&Open...";
      toolStripMenuItem2.Click += new EventHandler(this.openMenuItem_Click);
      this.closeTabMenuItem.Enabled = false;
      this.closeTabMenuItem.Image = (Image) componentResourceManager.GetObject("closeTabMenuItem.Image");
      this.closeTabMenuItem.Name = "closeTabMenuItem";
      ToolStripMenuItem closeTabMenuItem = this.closeTabMenuItem;
      size1 = new Size(164, 22);
      Size size7 = size1;
      closeTabMenuItem.Size = size7;
      this.closeTabMenuItem.Text = "&Close Tab";
      toolStripSeparator2.Name = "fileMenuSeparator1";
      ToolStripSeparator toolStripSeparator5 = toolStripSeparator2;
      size1 = new Size(161, 6);
      Size size8 = size1;
      toolStripSeparator5.Size = size8;
      toolStripMenuItem3.Image = (Image) componentResourceManager.GetObject("exitMenuItem.Image");
      toolStripMenuItem3.Name = "exitMenuItem";
      ToolStripMenuItem toolStripMenuItem10 = toolStripMenuItem3;
      size1 = new Size(164, 22);
      Size size9 = size1;
      toolStripMenuItem10.Size = size9;
      toolStripMenuItem3.Text = "E&xit";
      toolStripMenuItem3.Click += new EventHandler(this.exitMenuItem_Click);
      toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.refreshMenuItem,
        (ToolStripItem) this.stopMenuItem
      });
      toolStripMenuItem4.Name = "viewMenuItem";
      ToolStripMenuItem toolStripMenuItem11 = toolStripMenuItem4;
      size1 = new Size(44, 20);
      Size size10 = size1;
      toolStripMenuItem11.Size = size10;
      toolStripMenuItem4.Text = "&View";
      this.refreshMenuItem.Enabled = false;
      this.refreshMenuItem.Image = (Image) componentResourceManager.GetObject("refreshMenuItem.Image");
      this.refreshMenuItem.Name = "refreshMenuItem";
      this.refreshMenuItem.ShortcutKeys = Keys.R | Keys.Control;
      ToolStripMenuItem refreshMenuItem = this.refreshMenuItem;
      size1 = new Size(154, 22);
      Size size11 = size1;
      refreshMenuItem.Size = size11;
      this.refreshMenuItem.Text = "&Refresh";
      this.stopMenuItem.Enabled = false;
      this.stopMenuItem.Image = (Image) componentResourceManager.GetObject("stopMenuItem.Image");
      this.stopMenuItem.Name = "stopMenuItem";
      ToolStripMenuItem stopMenuItem = this.stopMenuItem;
      size1 = new Size(154, 22);
      Size size12 = size1;
      stopMenuItem.Size = size12;
      this.stopMenuItem.Text = "&Stop";
      toolStripMenuItem5.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.backMenuItem,
        (ToolStripItem) this.forwardMenuItem,
        (ToolStripItem) this.homeMenuItem
      });
      toolStripMenuItem5.Name = "historyMenuItem";
      ToolStripMenuItem toolStripMenuItem12 = toolStripMenuItem5;
      size1 = new Size(57, 20);
      Size size13 = size1;
      toolStripMenuItem12.Size = size13;
      toolStripMenuItem5.Text = "Hi&story";
      this.backMenuItem.Enabled = false;
      this.backMenuItem.Image = (Image) componentResourceManager.GetObject("backMenuItem.Image");
      this.backMenuItem.Name = "backMenuItem";
      this.backMenuItem.ShortcutKeys = Keys.Left | Keys.Control;
      ToolStripMenuItem backMenuItem = this.backMenuItem;
      size1 = new Size(179, 22);
      Size size14 = size1;
      backMenuItem.Size = size14;
      this.backMenuItem.Text = "&Back";
      this.forwardMenuItem.Enabled = false;
      this.forwardMenuItem.Image = (Image) componentResourceManager.GetObject("forwardMenuItem.Image");
      this.forwardMenuItem.Name = "forwardMenuItem";
      this.forwardMenuItem.ShortcutKeys = Keys.Right | Keys.Control;
      ToolStripMenuItem forwardMenuItem = this.forwardMenuItem;
      size1 = new Size(179, 22);
      Size size15 = size1;
      forwardMenuItem.Size = size15;
      this.forwardMenuItem.Text = "For&ward";
      this.homeMenuItem.Image = (Image) componentResourceManager.GetObject("homeMenuItem.Image");
      this.homeMenuItem.Name = "homeMenuItem";
      this.homeMenuItem.ShortcutKeys = Keys.H | Keys.Control;
      ToolStripMenuItem homeMenuItem = this.homeMenuItem;
      size1 = new Size(179, 22);
      Size size16 = size1;
      homeMenuItem.Size = size16;
      this.homeMenuItem.Text = "H&ome";
      toolStripSeparator3.Name = "toolbarSeparator2";
      ToolStripSeparator toolStripSeparator6 = toolStripSeparator3;
      size1 = new Size(6, 25);
      Size size17 = size1;
      toolStripSeparator6.Size = size17;
      toolStripLabel1.Name = "addressLabel";
      ToolStripLabel toolStripLabel2 = toolStripLabel1;
      size1 = new Size(52, 22);
      Size size18 = size1;
      toolStripLabel2.Size = size18;
      toolStripLabel1.Text = "Address:";
      toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
      toolStripButton2.Image = (Image) componentResourceManager.GetObject("homeButton.Image");
      toolStripButton2.ImageTransparentColor = Color.Magenta;
      toolStripButton2.Name = "homeButton";
      ToolStripButton toolStripButton4 = toolStripButton2;
      size1 = new Size(23, 22);
      Size size19 = size1;
      toolStripButton4.Size = size19;
      toolStripButton2.Text = "Home";
      toolStripButton2.Click += new EventHandler(this.homeButton_Click);
      toolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) toolStripMenuItem7
      });
      toolStripMenuItem6.Name = "toolsMenuItem";
      ToolStripMenuItem toolStripMenuItem13 = toolStripMenuItem6;
      size1 = new Size(48, 20);
      Size size20 = size1;
      toolStripMenuItem13.Size = size20;
      toolStripMenuItem6.Text = "&Tools";
      toolStripMenuItem7.Image = (Image) componentResourceManager.GetObject("optionsMenuItem.Image");
      toolStripMenuItem7.Name = "optionsMenuItem";
      ToolStripMenuItem toolStripMenuItem14 = toolStripMenuItem7;
      size1 = new Size(125, 22);
      Size size21 = size1;
      toolStripMenuItem14.Size = size21;
      toolStripMenuItem7.Text = "&Options...";
      toolStripMenuItem7.Click += new EventHandler(this.optionsMenuItem_Click);
      this.goButton.Image = (Image) componentResourceManager.GetObject("goButton.Image");
      this.goButton.ImageTransparentColor = Color.Magenta;
      this.goButton.Name = "goButton";
      ToolStripButton goButton = this.goButton;
      size1 = new Size(42, 22);
      Size size22 = size1;
      goButton.Size = size22;
      this.goButton.Text = "Go";
      this.goButton.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.mainMenu.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) toolStripMenuItem1,
        (ToolStripItem) toolStripMenuItem4,
        (ToolStripItem) toolStripMenuItem5,
        (ToolStripItem) toolStripMenuItem6
      });
      MenuStrip mainMenu1 = this.mainMenu;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      mainMenu1.Location = point2;
      this.mainMenu.Name = "mainMenu";
      MenuStrip mainMenu2 = this.mainMenu;
      size1 = new Size(897, 24);
      Size size23 = size1;
      mainMenu2.Size = size23;
      this.mainMenu.TabIndex = 0;
      this.mainMenu.Text = "MenuStrip1";
      this.toolbar.Items.AddRange(new ToolStripItem[13]
      {
        (ToolStripItem) this.backButton,
        (ToolStripItem) this.forwardButton,
        (ToolStripItem) this.refreshButton,
        (ToolStripItem) this.stopButton,
        (ToolStripItem) this.favouritesButton,
        (ToolStripItem) toolStripButton2,
        (ToolStripItem) toolStripSeparator1,
        (ToolStripItem) toolStripButton1,
        (ToolStripItem) this.closeTabButton,
        (ToolStripItem) toolStripSeparator3,
        (ToolStripItem) toolStripLabel1,
        (ToolStripItem) this.addressCombo,
        (ToolStripItem) this.goButton
      });
      ToolStrip toolbar1 = this.toolbar;
      point1 = new Point(0, 24);
      Point point3 = point1;
      toolbar1.Location = point3;
      this.toolbar.Name = "toolbar";
      ToolStrip toolbar2 = this.toolbar;
      size1 = new Size(897, 25);
      Size size24 = size1;
      toolbar2.Size = size24;
      this.toolbar.TabIndex = 1;
      this.toolbar.Text = "ToolStrip1";
      this.backButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.backButton.Enabled = false;
      this.backButton.Image = (Image) componentResourceManager.GetObject("backButton.Image");
      this.backButton.ImageTransparentColor = Color.Magenta;
      this.backButton.Name = "backButton";
      ToolStripButton backButton = this.backButton;
      size1 = new Size(23, 22);
      Size size25 = size1;
      backButton.Size = size25;
      this.backButton.Text = "Back";
      this.forwardButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.forwardButton.Enabled = false;
      this.forwardButton.Image = (Image) componentResourceManager.GetObject("forwardButton.Image");
      this.forwardButton.ImageTransparentColor = Color.Magenta;
      this.forwardButton.Name = "forwardButton";
      ToolStripButton forwardButton = this.forwardButton;
      size1 = new Size(23, 22);
      Size size26 = size1;
      forwardButton.Size = size26;
      this.forwardButton.Text = "Forward";
      this.refreshButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.refreshButton.Enabled = false;
      this.refreshButton.Image = (Image) componentResourceManager.GetObject("refreshButton.Image");
      this.refreshButton.ImageTransparentColor = Color.Magenta;
      this.refreshButton.Name = "refreshButton";
      ToolStripButton refreshButton = this.refreshButton;
      size1 = new Size(23, 22);
      Size size27 = size1;
      refreshButton.Size = size27;
      this.refreshButton.Text = "Refresh";
      this.stopButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.stopButton.Enabled = false;
      this.stopButton.Image = (Image) componentResourceManager.GetObject("stopButton.Image");
      this.stopButton.ImageTransparentColor = Color.Magenta;
      this.stopButton.Name = "stopButton";
      ToolStripButton stopButton = this.stopButton;
      size1 = new Size(23, 22);
      Size size28 = size1;
      stopButton.Size = size28;
      this.stopButton.Text = "Stop";
      this.favouritesButton.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.AddToFavouritesMenuItem
      });
      this.favouritesButton.Image = (Image) Resources.star;
      this.favouritesButton.ImageTransparentColor = Color.Magenta;
      this.favouritesButton.Name = "favouritesButton";
      ToolStripSplitButton favouritesButton = this.favouritesButton;
      size1 = new Size(93, 22);
      Size size29 = size1;
      favouritesButton.Size = size29;
      this.favouritesButton.Text = "Favourites";
      this.AddToFavouritesMenuItem.Name = "AddToFavouritesMenuItem";
      ToolStripMenuItem favouritesMenuItem = this.AddToFavouritesMenuItem;
      size1 = new Size(179, 22);
      Size size30 = size1;
      favouritesMenuItem.Size = size30;
      this.AddToFavouritesMenuItem.Text = "Add To Favourites...";
      this.closeTabButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.closeTabButton.Enabled = false;
      this.closeTabButton.Image = (Image) componentResourceManager.GetObject("closeTabButton.Image");
      this.closeTabButton.ImageTransparentColor = Color.Magenta;
      this.closeTabButton.Name = "closeTabButton";
      ToolStripButton closeTabButton = this.closeTabButton;
      size1 = new Size(23, 22);
      Size size31 = size1;
      closeTabButton.Size = size31;
      this.closeTabButton.Text = "Close Tab";
      this.addressCombo.AutoSize = false;
      this.addressCombo.Name = "addressCombo";
      ToolStripComboBox addressCombo = this.addressCombo;
      size1 = new Size(510, 23);
      Size size32 = size1;
      addressCombo.Size = size32;
      this.statusbar.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.browserStatusTextLabel,
        (ToolStripItem) this.pageLoadProgress
      });
      StatusStrip statusbar1 = this.statusbar;
      point1 = new Point(0, 544);
      Point point4 = point1;
      statusbar1.Location = point4;
      this.statusbar.Name = "statusbar";
      StatusStrip statusbar2 = this.statusbar;
      size1 = new Size(897, 22);
      Size size33 = size1;
      statusbar2.Size = size33;
      this.statusbar.TabIndex = 2;
      this.statusbar.Text = "StatusStrip1";
      this.browserStatusTextLabel.Name = "browserStatusTextLabel";
      ToolStripStatusLabel browserStatusTextLabel = this.browserStatusTextLabel;
      size1 = new Size(882, 17);
      Size size34 = size1;
      browserStatusTextLabel.Size = size34;
      this.browserStatusTextLabel.Spring = true;
      this.browserStatusTextLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.pageLoadProgress.Name = "pageLoadProgress";
      ToolStripProgressBar pageLoadProgress = this.pageLoadProgress;
      size1 = new Size(100, 16);
      Size size35 = size1;
      pageLoadProgress.Size = size35;
      this.pageLoadProgress.Visible = false;
      this.MainSplitContainer.Dock = DockStyle.Fill;
      SplitContainer mainSplitContainer1 = this.MainSplitContainer;
      point1 = new Point(0, 49);
      Point point5 = point1;
      mainSplitContainer1.Location = point5;
      this.MainSplitContainer.Name = "MainSplitContainer";
      this.MainSplitContainer.Panel1.Controls.Add((Control) this.FavouritesTabControl);
      this.MainSplitContainer.Panel2.Controls.Add((Control) this.tabs);
      SplitContainer mainSplitContainer2 = this.MainSplitContainer;
      size1 = new Size(897, 495);
      Size size36 = size1;
      mainSplitContainer2.Size = size36;
      this.MainSplitContainer.SplitterDistance = 299;
      this.MainSplitContainer.TabIndex = 4;
      this.FavouritesTabControl.Controls.Add((Control) this.FavouritesTabPage);
      this.FavouritesTabControl.Controls.Add((Control) this.FeedsTabPage);
      this.FavouritesTabControl.Controls.Add((Control) this.HistoryTabPage);
      this.FavouritesTabControl.Dock = DockStyle.Fill;
      TabControl favouritesTabControl1 = this.FavouritesTabControl;
      point1 = new Point(0, 0);
      Point point6 = point1;
      favouritesTabControl1.Location = point6;
      this.FavouritesTabControl.Name = "FavouritesTabControl";
      this.FavouritesTabControl.SelectedIndex = 0;
      TabControl favouritesTabControl2 = this.FavouritesTabControl;
      size1 = new Size(299, 495);
      Size size37 = size1;
      favouritesTabControl2.Size = size37;
      this.FavouritesTabControl.TabIndex = 0;
      this.FavouritesTabPage.Controls.Add((Control) this.FavouritesTreeView);
      TabPage favouritesTabPage1 = this.FavouritesTabPage;
      point1 = new Point(4, 22);
      Point point7 = point1;
      favouritesTabPage1.Location = point7;
      this.FavouritesTabPage.Name = "FavouritesTabPage";
      TabPage favouritesTabPage2 = this.FavouritesTabPage;
      Padding padding1 = new Padding(3);
      Padding padding2 = padding1;
      favouritesTabPage2.Padding = padding2;
      TabPage favouritesTabPage3 = this.FavouritesTabPage;
      size1 = new Size(291, 469);
      Size size38 = size1;
      favouritesTabPage3.Size = size38;
      this.FavouritesTabPage.TabIndex = 0;
      this.FavouritesTabPage.Text = "Favourites";
      this.FavouritesTabPage.UseVisualStyleBackColor = true;
      this.FavouritesTreeView.ContextMenuStrip = this.favouritesContextMenu;
      this.FavouritesTreeView.Dock = DockStyle.Fill;
      TreeView favouritesTreeView1 = this.FavouritesTreeView;
      point1 = new Point(3, 3);
      Point point8 = point1;
      favouritesTreeView1.Location = point8;
      this.FavouritesTreeView.Name = "FavouritesTreeView";
      TreeView favouritesTreeView2 = this.FavouritesTreeView;
      size1 = new Size(285, 463);
      Size size39 = size1;
      favouritesTreeView2.Size = size39;
      this.FavouritesTreeView.TabIndex = 0;
      this.favouritesContextMenu.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.DeleteFavouriteToolStripMenuItem,
        (ToolStripItem) this.EditFavouriteToolStripMenuItem
      });
      this.favouritesContextMenu.Name = "favouritesContextMenu";
      ContextMenuStrip favouritesContextMenu = this.favouritesContextMenu;
      size1 = new Size(160, 48);
      Size size40 = size1;
      favouritesContextMenu.Size = size40;
      this.DeleteFavouriteToolStripMenuItem.Name = "DeleteFavouriteToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem15 = this.DeleteFavouriteToolStripMenuItem;
      size1 = new Size(159, 22);
      Size size41 = size1;
      toolStripMenuItem15.Size = size41;
      this.DeleteFavouriteToolStripMenuItem.Text = "Delete Favourite";
      this.EditFavouriteToolStripMenuItem.Name = "EditFavouriteToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem16 = this.EditFavouriteToolStripMenuItem;
      size1 = new Size(159, 22);
      Size size42 = size1;
      toolStripMenuItem16.Size = size42;
      this.EditFavouriteToolStripMenuItem.Text = "Edit Favourite...";
      TabPage feedsTabPage1 = this.FeedsTabPage;
      point1 = new Point(4, 22);
      Point point9 = point1;
      feedsTabPage1.Location = point9;
      this.FeedsTabPage.Name = "FeedsTabPage";
      TabPage feedsTabPage2 = this.FeedsTabPage;
      padding1 = new Padding(3);
      Padding padding3 = padding1;
      feedsTabPage2.Padding = padding3;
      TabPage feedsTabPage3 = this.FeedsTabPage;
      size1 = new Size(291, 469);
      Size size43 = size1;
      feedsTabPage3.Size = size43;
      this.FeedsTabPage.TabIndex = 1;
      this.FeedsTabPage.Text = "Feeds";
      this.FeedsTabPage.UseVisualStyleBackColor = true;
      TabPage historyTabPage1 = this.HistoryTabPage;
      point1 = new Point(4, 22);
      Point point10 = point1;
      historyTabPage1.Location = point10;
      this.HistoryTabPage.Name = "HistoryTabPage";
      TabPage historyTabPage2 = this.HistoryTabPage;
      padding1 = new Padding(3);
      Padding padding4 = padding1;
      historyTabPage2.Padding = padding4;
      TabPage historyTabPage3 = this.HistoryTabPage;
      size1 = new Size(291, 469);
      Size size44 = size1;
      historyTabPage3.Size = size44;
      this.HistoryTabPage.TabIndex = 2;
      this.HistoryTabPage.Text = "History";
      this.HistoryTabPage.UseVisualStyleBackColor = true;
      this.tabs.Dock = DockStyle.Fill;
      WebBrowserTabControl tabs1 = this.tabs;
      point1 = new Point(0, 0);
      Point point11 = point1;
      tabs1.Location = point11;
      this.tabs.Name = "tabs";
      this.tabs.SelectedIndex = 0;
      WebBrowserTabControl tabs2 = this.tabs;
      size1 = new Size(594, 495);
      Size size45 = size1;
      tabs2.Size = size45;
      this.tabs.TabIndex = 3;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(897, 566);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.MainSplitContainer);
      this.Controls.Add((Control) this.statusbar);
      this.Controls.Add((Control) this.toolbar);
      this.Controls.Add((Control) this.mainMenu);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.mainMenu;
      this.Name = "MainWindow";
      this.Text = "Green Dragon Browser";
      this.mainMenu.ResumeLayout(false);
      this.mainMenu.PerformLayout();
      this.toolbar.ResumeLayout(false);
      this.toolbar.PerformLayout();
      this.statusbar.ResumeLayout(false);
      this.statusbar.PerformLayout();
      this.MainSplitContainer.Panel1.ResumeLayout(false);
      this.MainSplitContainer.Panel2.ResumeLayout(false);
      this.MainSplitContainer.ResumeLayout(false);
      this.FavouritesTabControl.ResumeLayout(false);
      this.FavouritesTabPage.ResumeLayout(false);
      this.favouritesContextMenu.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

    private void MainWindow_Load(object sender, EventArgs e)
    {
      this.tabs.AddTab();
      this.currentBrowser = this.tabs.SelectedWebBrowser;
      if (MySettingsProperty.Settings.StartWithHomePage && !string.IsNullOrEmpty(MySettingsProperty.Settings.HomePage))
        this.currentBrowser.Navigate(MySettingsProperty.Settings.HomePage);
      this.GetFavourites();
    }

    private void MainWindow_SizeChanged(object sender, EventArgs e)
    {
      if (this.addressFieldSizeOffset <= 0)
        return;
      this.addressCombo.Width = Math.Max(100, checked (this.Width - this.addressFieldSizeOffset));
    }

    private void addressCombo_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.currentBrowser.Navigate(this.addressCombo.Text);
      e.SuppressKeyPress = true;
    }

    private void goButton_Click(object sender, EventArgs e)
    {
      this.currentBrowser.Navigate(this.addressCombo.Text);
    }

    private void tabs_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.currentBrowser = this.tabs.SelectedWebBrowser;
      this.DisplayPageTitle();
      if (this.tabs.TabCount == 1)
      {
        this.closeTabMenuItem.Enabled = false;
        this.closeTabButton.Enabled = false;
      }
      else
      {
        this.closeTabMenuItem.Enabled = true;
        this.closeTabButton.Enabled = true;
      }
      Uri url = this.currentBrowser.Url;
      if (url == null)
      {
        this.addressCombo.Text = string.Empty;
        this.refreshMenuItem.Enabled = false;
        this.refreshButton.Enabled = false;
      }
      else
      {
        this.addressCombo.Text = url.ToString();
        this.refreshMenuItem.Enabled = true;
        this.refreshButton.Enabled = true;
      }
      this.browserStatusTextLabel.Text = this.currentBrowser.StatusText;
      WebBrowserTabPage webBrowserTabPage = this.tabs.SelectedWebBrowserTabPage;
      long lastCurrentProgress = webBrowserTabPage.LastCurrentProgress;
      long lastMaximumProgress = webBrowserTabPage.LastMaximumProgress;
      if (lastMaximumProgress > 0L && lastCurrentProgress > 0L)
      {
        this.pageLoadProgress.Visible = true;
        this.pageLoadProgress.Value = checked ((int) Math.Round(Math.Round(unchecked ((double) checked (100L * lastCurrentProgress) / (double) lastMaximumProgress))));
      }
      else
      {
        this.pageLoadProgress.Visible = false;
        this.pageLoadProgress.Value = 0;
      }
    }

    private void pageLoadProgress_VisibleChanged(object sender, EventArgs e)
    {
      bool visible = this.pageLoadProgress.Visible;
      this.stopMenuItem.Enabled = visible;
      this.stopButton.Enabled = visible;
    }

    private void FavouritesTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
      if (Operators.CompareString(e.Node.Nodes[0].Text, "*", false) != 0)
        return;
      e.Node.Nodes.Clear();
      this.GetFavouritesForDirectory(new DirectoryInfo(e.Node.Tag.ToString()), e.Node);
    }

    private void FavouritesTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      this.currentBrowser.Navigate(((FavouriteTreeNode) e.Node).Url);
    }

    private void FavouritesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      if (e.Button != MouseButtons.Right)
        return;
      this.FavouritesTreeView.SelectedNode = e.Node;
    }

    private void newTabMenuItem_Click(object sender, EventArgs e)
    {
      this.tabs.AddTab();
    }

    private void openMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void closeTabMenuItem_Click(object sender, EventArgs e)
    {
      this.tabs.RemoveCurrentTab();
    }

    private void exitMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void refreshMenuItem_Click(object sender, EventArgs e)
    {
      this.currentBrowser.Refresh();
      this.pageLoadProgress.Visible = true;
    }

    private void stopMenuItem_Click(object sender, EventArgs e)
    {
      this.currentBrowser.Stop();
    }

    private void backMenuItem_Click(object sender, EventArgs e)
    {
      this.currentBrowser.GoBack();
    }

    private void forwardMenuItem_Click(object sender, EventArgs e)
    {
      this.currentBrowser.GoForward();
    }

    private void homeMenuItem_Click(object sender, EventArgs e)
    {
      this.currentBrowser.Navigate(MySettingsProperty.Settings.HomePage);
    }

    private void optionsMenuItem_Click(object sender, EventArgs e)
    {
      using (OptionsDialogue optionsDialogue = new OptionsDialogue(this.currentBrowser.Url.ToString()))
      {
        int num = (int) optionsDialogue.ShowDialog();
      }
    }

    private void backButton_Click(object sender, EventArgs e)
    {
      this.backMenuItem.PerformClick();
    }

    private void forwardButton_Click(object sender, EventArgs e)
    {
      this.forwardMenuItem.PerformClick();
    }

    private void refreshButton_Click(object sender, EventArgs e)
    {
      this.refreshMenuItem.PerformClick();
    }

    private void stopButton_Click(object sender, EventArgs e)
    {
      this.stopMenuItem.PerformClick();
    }

    private void homeButton_Click(object sender, EventArgs e)
    {
      this.homeMenuItem.PerformClick();
    }

    private void newTabButton_Click(object sender, EventArgs e)
    {
      this.newTabMenuItem.PerformClick();
    }

    private void closeTabButton_Click(object sender, EventArgs e)
    {
      this.closeTabMenuItem.PerformClick();
    }

    private void favouritesButton_ButtonClick(object sender, EventArgs e)
    {
      this.MainSplitContainer.Panel1Collapsed = !this.MainSplitContainer.Panel1Collapsed;
    }

    private void AddToFavouritesMenuItem_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.addressCombo.Text, "about:blank", false) == 0)
        return;
      using (AddFavouriteDialogue favouriteDialogue = new AddFavouriteDialogue(this.addressCombo.Text, this.Text))
      {
        int num = (int) favouriteDialogue.ShowDialog();
        if (favouriteDialogue.DialogResult == DialogResult.OK)
          this.GetFavourites();
      }
    }

    private void currentBrowser_StatusTextChanged(object sender, EventArgs e)
    {
      this.browserStatusTextLabel.Text = this.currentBrowser.StatusText;
    }

    private void currentBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
    {
      this.pageLoadProgress.Visible = true;
      this.addressCombo.Text = this.currentBrowser.Url.ToString();
    }

    private void currentBrowser_CanGoBackChanged(object sender, EventArgs e)
    {
      bool canGoBack = this.currentBrowser.CanGoBack;
      this.backButton.Enabled = canGoBack;
      this.backMenuItem.Enabled = canGoBack;
    }

    private void currentBrowser_CanGoForwardChanged(object sender, EventArgs e)
    {
      bool canGoForward = this.currentBrowser.CanGoForward;
      this.forwardButton.Enabled = canGoForward;
      this.forwardMenuItem.Enabled = canGoForward;
    }

    private void currentBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
    {
      this.pageLoadProgress.Visible = true;
      if (e.MaximumProgress > 0L && e.CurrentProgress > 0L)
      {
        this.pageLoadProgress.Value = checked ((int) Math.Round(Math.Round(unchecked ((double) checked (100L * e.CurrentProgress) / (double) e.MaximumProgress))));
      }
      else
      {
        if ((e.MaximumProgress != 0L || e.CurrentProgress != 0L) && !false)
          return;
        this.pageLoadProgress.Visible = false;
        this.pageLoadProgress.Value = 0;
      }
    }

    private void currentBrowser_DocumentTitleChanged(object sender, EventArgs e)
    {
      this.DisplayPageTitle();
    }

    private void currentBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      this.refreshMenuItem.Enabled = true;
      this.refreshButton.Enabled = true;
    }

    private void DeleteFavouriteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show(string.Format("Are you sure you want to delete {0}", (object) this.FavouritesTreeView.SelectedNode.Text), "Deletion Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes || !(this.FavouritesTreeView.SelectedNode is FavouriteTreeNode))
        return;
      string path = this.FavouritesTreeView.SelectedNode.Tag.ToString();
      if (File.Exists(path))
      {
        File.Delete(path);
        this.FavouritesTreeView.SelectedNode.Remove();
      }
    }

    private void EditFavouriteToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void DisplayPageTitle()
    {
      string documentTitle = this.currentBrowser.DocumentTitle;
      if (Operators.CompareString(documentTitle, string.Empty, false) == 0)
        this.Text = Application.ProductName;
      else
        this.Text = string.Format("{0} - {1}", (object) documentTitle, (object) Application.ProductName);
    }

    private void GetFavouritesForDirectory(DirectoryInfo di, TreeNode dirNode)
    {
      FileInfo[] files = di.GetFiles();
      int index = 0;
      while (index < files.Length)
      {
        FileInfo fileInfo = files[index];
        this.result = MainWindow.GetPrivateProfileString("InternetShortcut", "URL", "", this.sb, this.sb.Capacity, fileInfo.FullName);
        if (this.result > 0)
        {
          FavouriteTreeNode favouriteTreeNode = new FavouriteTreeNode();
          favouriteTreeNode.Text = Path.GetFileNameWithoutExtension(fileInfo.FullName);
          favouriteTreeNode.Url = new Uri(this.sb.ToString());
          favouriteTreeNode.Tag = (object) fileInfo.FullName;
          if (dirNode == null)
            this.FavouritesTreeView.Nodes.Add((TreeNode) favouriteTreeNode);
          else
            dirNode.Nodes.Add((TreeNode) favouriteTreeNode);
        }
        checked { ++index; }
      }
    }

    private void GetFavourites()
    {
      this.FavouritesTreeView.Nodes.Clear();
      string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Favorites));
      int index = 0;
      while (index < directories.Length)
      {
        DirectoryInfo directoryInfo = new DirectoryInfo(directories[index]);
        TreeNode node = new TreeNode();
        node.Text = directoryInfo.Name;
        node.Tag = (object) directoryInfo.FullName;
        this.FavouritesTreeView.Nodes.Add(node);
        node.Nodes.Add("*");
        checked { ++index; }
      }
      this.GetFavouritesForDirectory(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Favorites)), (TreeNode) null);
    }
  }
}
