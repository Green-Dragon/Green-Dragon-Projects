// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Anti_Virus.My.MyApplication
// Assembly: Green Dragon Anti-Virus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CFA5EC03-2D59-4DD3-A998-F57603AE3008
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Anti-Virus.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Green_Dragon_Anti_Virus.My
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
      this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
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
  }
}
