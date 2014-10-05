// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.My.MyProject
// Assembly: Green Dragon Browser, Version=1.0.3.0, Culture=neutral, PublicKeyToken=0706e68831d27660
// MVID: 73704739-5485-4C15-86EF-C4F58132E058
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser.exe

using Green_Dragon_Browser;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Green_Dragon_Browser.My
{
  [GeneratedCode("MyTemplate", "11.0.0.0")]
  [HideModuleName]
  [StandardModule]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get
      {
        return MyProject.m_ComputerObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get
      {
        return MyProject.m_AppObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get
      {
        return MyProject.m_UserObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyFormsObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyWebServicesObjectProvider.GetInstance;
      }
    }

    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyForms
    {
      public fBookmarks m_fBookmarks;
      public fDownloads m_fDownloads;
      public fHistory m_fHistory;
      public fLogin m_fLogin;
      public fMain m_fMain;
      public fNotepad m_fNotepad;
      public fOptions m_fOptions;
      public fScreenshot m_fScreenshot;
      public fSplash m_fSplash;
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;

      public fBookmarks fBookmarks
      {
        get
        {
          this.m_fBookmarks = MyProject.MyForms.Create__Instance__<fBookmarks>(this.m_fBookmarks);
          return this.m_fBookmarks;
        }
        set
        {
          if (value == this.m_fBookmarks)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<fBookmarks>(ref this.m_fBookmarks);
        }
      }

      public fDownloads fDownloads
      {
        get
        {
          this.m_fDownloads = MyProject.MyForms.Create__Instance__<fDownloads>(this.m_fDownloads);
          return this.m_fDownloads;
        }
        set
        {
          if (value == this.m_fDownloads)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<fDownloads>(ref this.m_fDownloads);
        }
      }

      public fHistory fHistory
      {
        get
        {
          this.m_fHistory = MyProject.MyForms.Create__Instance__<fHistory>(this.m_fHistory);
          return this.m_fHistory;
        }
        set
        {
          if (value == this.m_fHistory)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<fHistory>(ref this.m_fHistory);
        }
      }

      public fLogin fLogin
      {
        get
        {
          this.m_fLogin = MyProject.MyForms.Create__Instance__<fLogin>(this.m_fLogin);
          return this.m_fLogin;
        }
        set
        {
          if (value == this.m_fLogin)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<fLogin>(ref this.m_fLogin);
        }
      }

      public fMain fMain
      {
        get
        {
          this.m_fMain = MyProject.MyForms.Create__Instance__<fMain>(this.m_fMain);
          return this.m_fMain;
        }
        set
        {
          if (value == this.m_fMain)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<fMain>(ref this.m_fMain);
        }
      }

      public fNotepad fNotepad
      {
        get
        {
          this.m_fNotepad = MyProject.MyForms.Create__Instance__<fNotepad>(this.m_fNotepad);
          return this.m_fNotepad;
        }
        set
        {
          if (value == this.m_fNotepad)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<fNotepad>(ref this.m_fNotepad);
        }
      }

      public fOptions fOptions
      {
        get
        {
          this.m_fOptions = MyProject.MyForms.Create__Instance__<fOptions>(this.m_fOptions);
          return this.m_fOptions;
        }
        set
        {
          if (value == this.m_fOptions)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<fOptions>(ref this.m_fOptions);
        }
      }

      public fScreenshot fScreenshot
      {
        get
        {
          this.m_fScreenshot = MyProject.MyForms.Create__Instance__<fScreenshot>(this.m_fScreenshot);
          return this.m_fScreenshot;
        }
        set
        {
          if (value == this.m_fScreenshot)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<fScreenshot>(ref this.m_fScreenshot);
        }
      }

      public fSplash fSplash
      {
        get
        {
          this.m_fSplash = MyProject.MyForms.Create__Instance__<fSplash>(this.m_fSplash);
          return this.m_fSplash;
        }
        set
        {
          if (value == this.m_fSplash)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<fSplash>(ref this.m_fSplash);
        }
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyForms()
      {
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        // ISSUE: unable to decompile the method.
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType()
      {
        return typeof (MyProject.MyForms);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString()
      {
        return base.ToString();
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    internal sealed class MyWebServices
    {
      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyWebServices()
      {
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType()
      {
        return typeof (MyProject.MyWebServices);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override string ToString()
      {
        return base.ToString();
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new()
      {
        if ((object) instance == null)
          return Activator.CreateInstance<T>();
        else
          return instance;
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance)
      {
        instance = default (T);
      }
    }

    [ComVisible(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
