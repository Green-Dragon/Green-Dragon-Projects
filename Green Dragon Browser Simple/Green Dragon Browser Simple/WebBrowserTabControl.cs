// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.WebBrowserTabControl
// Assembly: Green Dragon Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d25b577927d337c7
// MVID: 43B6EF03-694B-4A1E-BE9F-3F26039BA1DF
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser Simple.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  internal class WebBrowserTabControl : TabControl
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();

    public WebBrowserTabPage SelectedWebBrowserTabPage
    {
      get
      {
        return (WebBrowserTabPage) this.SelectedTab;
      }
    }

    public WebBrowser SelectedWebBrowser
    {
      get
      {
        return this.SelectedWebBrowserTabPage.Browser;
      }
    }

    [DebuggerNonUserCode]
    static WebBrowserTabControl()
    {
    }

    [DebuggerNonUserCode]
    public WebBrowserTabControl()
    {
      WebBrowserTabControl.__ENCAddToList((object) this);
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      List<WeakReference> list = WebBrowserTabControl.__ENCList;
      Monitor.Enter((object) list);
      try
      {
        if (WebBrowserTabControl.__ENCList.Count == WebBrowserTabControl.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (WebBrowserTabControl.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (WebBrowserTabControl.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                WebBrowserTabControl.__ENCList[index1] = WebBrowserTabControl.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          WebBrowserTabControl.__ENCList.RemoveRange(index1, checked (WebBrowserTabControl.__ENCList.Count - index1));
          WebBrowserTabControl.__ENCList.Capacity = WebBrowserTabControl.__ENCList.Count;
        }
        WebBrowserTabControl.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
      finally
      {
        Monitor.Exit((object) list);
      }
    }

    public WebBrowserTabPage AddTab()
    {
      WebBrowserTabPage webBrowserTabPage = new WebBrowserTabPage();
      this.TabPages.Add((TabPage) webBrowserTabPage);
      this.SelectedTab = (TabPage) webBrowserTabPage;
      return webBrowserTabPage;
    }

    public WebBrowserTabPage AddTab(string address)
    {
      WebBrowserTabPage webBrowserTabPage = this.AddTab();
      webBrowserTabPage.Browser.Navigate(address);
      return webBrowserTabPage;
    }

    public bool RemoveCurrentTab()
    {
      bool flag = this.TabCount > 1;
      if (flag)
      {
        WebBrowserTabPage webBrowserTabPage = this.SelectedWebBrowserTabPage;
        this.TabPages.Remove((TabPage) webBrowserTabPage);
        webBrowserTabPage.Dispose();
      }
      return flag;
    }
  }
}
