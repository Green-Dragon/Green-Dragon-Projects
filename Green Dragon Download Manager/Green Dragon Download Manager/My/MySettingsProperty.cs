// Decompiled with JetBrains decompiler
// Type: WindowsApplication1.My.MySettingsProperty
// Assembly: Green Dragon Download Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 718D136A-FDF9-419F-8458-6E3F7A26C7B8
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Download Manager.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WindowsApplication1.My
{
  [StandardModule]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  [HideModuleName]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        return MySettings.Default;
      }
    }
  }
}
