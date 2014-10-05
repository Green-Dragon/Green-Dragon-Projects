// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.My.MyApplication
// Assembly: Green Dragon Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d25b577927d337c7
// MVID: 43B6EF03-694B-4A1E-BE9F-3F26039BA1DF
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser Simple.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Green_Dragon_Browser.My
{
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal class MyApplication : WindowsFormsApplicationBase
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();

    [DebuggerNonUserCode]
    static MyApplication()
    {
    }

    [DebuggerStepThrough]
    public MyApplication()
      : base(AuthenticationMode.Windows)
    {
      MyApplication.__ENCAddToList((object) this);
      this.IsSingleInstance = false;
      this.EnableVisualStyles = true;
      this.SaveMySettingsOnExit = true;
      this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      List<WeakReference> list = MyApplication.__ENCList;
      Monitor.Enter((object) list);
      try
      {
        if (MyApplication.__ENCList.Count == MyApplication.__ENCList.Capacity)
        {
          int index1 = 0;
          int num1 = 0;
          int num2 = checked (MyApplication.__ENCList.Count - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (MyApplication.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                MyApplication.__ENCList[index1] = MyApplication.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          MyApplication.__ENCList.RemoveRange(index1, checked (MyApplication.__ENCList.Count - index1));
          MyApplication.__ENCList.Capacity = MyApplication.__ENCList.Count;
        }
        MyApplication.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
      finally
      {
        Monitor.Exit((object) list);
      }
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [STAThread]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    internal static void Main(string[] Args)
    {
      try
      {
        Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
      }
      finally
      {
      }
      MyProject.Application.Run(Args);
    }

    [DebuggerStepThrough]
    protected override void OnCreateMainForm()
    {
      this.MainForm = (Form) MyProject.Forms.MainWindow;
    }

    [DebuggerStepThrough]
    protected override void OnCreateSplashScreen()
    {
      this.SplashScreen = (Form) MyProject.Forms.SplashScreen1;
    }
  }
}
