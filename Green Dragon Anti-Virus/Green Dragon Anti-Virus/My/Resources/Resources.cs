// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Anti_Virus.My.Resources.Resources
// Assembly: Green Dragon Anti-Virus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CFA5EC03-2D59-4DD3-A998-F57603AE3008
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Anti-Virus.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Green_Dragon_Anti_Virus.My.Resources
{
  [StandardModule]
  [HideModuleName]
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) Resources.resourceMan, (object) null))
          Resources.resourceMan = new ResourceManager("Green_Dragon_Anti_Virus.Resources", typeof (Resources).Assembly);
        return Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Resources.resourceCulture;
      }
      set
      {
        Resources.resourceCulture = value;
      }
    }
  }
}
