// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Writer.My.MyApplication
// Assembly: Green Dragon Writer, Version=4.0.0.0, Culture=neutral, PublicKeyToken=f92e69f0319eaf84
// MVID: 722C2D38-0399-4F2F-8284-6B57384604E3
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Writer\Green Dragon Writer.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon_Writer.My
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [GeneratedCode("MyTemplate", "11.0.0.0")]
  internal class MyApplication : WindowsFormsApplicationBase
  {
    [DebuggerStepThrough]
    public MyApplication()
      : base(AuthenticationMode.Windows)
    {
      this.IsSingleInstance = false;
      this.EnableVisualStyles = true;
      this.SaveMySettingsOnExit = true;
      this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerHidden]
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
      this.MainForm = (Form) MyProject.Forms.Form1;
    }

    [DebuggerStepThrough]
    protected override void OnCreateSplashScreen()
    {
      this.SplashScreen = (Form) MyProject.Forms.SplashScreen1;
    }
  }
}
