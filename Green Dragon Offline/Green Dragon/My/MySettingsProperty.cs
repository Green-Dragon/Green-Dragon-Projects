// Decompiled with JetBrains decompiler
// Type: Green_Dragon.My.MySettingsProperty
// Assembly: Green Dragon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 72C6BEE2-CC2C-43BF-AE11-CDF506D6CD3B
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Green_Dragon.My
{
  [DebuggerNonUserCode]
  [CompilerGenerated]
  [StandardModule]
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
