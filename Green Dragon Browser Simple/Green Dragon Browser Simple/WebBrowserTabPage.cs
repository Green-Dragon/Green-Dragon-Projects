// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.WebBrowserTabPage
// Assembly: Green Dragon Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d25b577927d337c7
// MVID: 43B6EF03-694B-4A1E-BE9F-3F26039BA1DF
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser Simple.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  internal class WebBrowserTabPage : TabPage
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private const string BLANK_PAGE_TITLE = "(Blank)";
    [AccessedThroughProperty("_browser")]
    private WebBrowser __browser;
    private long _lastCurrentProgress;
    private long _lastMaximumProgress;

    private virtual WebBrowser _browser
    {
      [DebuggerNonUserCode] get
      {
        return this.__browser;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        WebBrowserProgressChangedEventHandler changedEventHandler = new WebBrowserProgressChangedEventHandler(this._browser_ProgressChanged);
        EventHandler eventHandler = new EventHandler(this._browser_DocumentTitleChanged);
        if (this.__browser != null)
        {
          this.__browser.ProgressChanged -= changedEventHandler;
          this.__browser.DocumentTitleChanged -= eventHandler;
        }
        this.__browser = value;
        if (this.__browser == null)
          return;
        this.__browser.ProgressChanged += changedEventHandler;
        this.__browser.DocumentTitleChanged += eventHandler;
      }
    }

    public WebBrowser Browser
    {
      get
      {
        return this._browser;
      }
    }

    public long LastCurrentProgress
    {
      get
      {
        return this._lastCurrentProgress;
      }
    }

    public long LastMaximumProgress
    {
      get
      {
        return this._lastMaximumProgress;
      }
    }

    [DebuggerNonUserCode]
    static WebBrowserTabPage()
    {
    }

    public WebBrowserTabPage()
      : this(new WebBrowser())
    {
      this.Browser.Navigate(string.Empty);
    }

    public WebBrowserTabPage(WebBrowser browser)
    {
      WebBrowserTabPage.__ENCAddToList((object) this);
      browser.Dock = DockStyle.Fill;
      this.Controls.Add((Control) browser);
      this._browser = browser;
      this.DisplayPageTitle();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      List<WeakReference> list = WebBrowserTabPage.__ENCList;
      Monitor.Enter((object) list);
      try
      {
        if (WebBrowserTabPage.__ENCList.Count == WebBrowserTabPage.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (WebBrowserTabPage.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (WebBrowserTabPage.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                WebBrowserTabPage.__ENCList[index1] = WebBrowserTabPage.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          WebBrowserTabPage.__ENCList.RemoveRange(index1, checked (WebBrowserTabPage.__ENCList.Count - index1));
          WebBrowserTabPage.__ENCList.Capacity = WebBrowserTabPage.__ENCList.Count;
        }
        WebBrowserTabPage.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
      finally
      {
        Monitor.Exit((object) list);
      }
    }

    private void _browser_DocumentTitleChanged(object sender, EventArgs e)
    {
      this.DisplayPageTitle();
    }

    private void _browser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
    {
      this._lastCurrentProgress = e.CurrentProgress;
      this._lastMaximumProgress = e.MaximumProgress;
    }

    private void DisplayPageTitle()
    {
      string documentTitle = this.Browser.DocumentTitle;
      if (Operators.CompareString(documentTitle, string.Empty, false) == 0)
        this.Text = "(Blank)";
      else
        this.Text = documentTitle;
    }
  }
}
