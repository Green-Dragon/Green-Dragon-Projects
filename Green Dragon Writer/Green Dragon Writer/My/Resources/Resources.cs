// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Writer.My.Resources.Resources
// Assembly: Green Dragon Writer, Version=4.0.0.0, Culture=neutral, PublicKeyToken=f92e69f0319eaf84
// MVID: 722C2D38-0399-4F2F-8284-6B57384604E3
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Writer\Green Dragon Writer.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Green_Dragon_Writer.My.Resources
{
  [DebuggerNonUserCode]
  [StandardModule]
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [HideModuleName]
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
          Resources.resourceMan = new ResourceManager("Green_Dragon_Writer.Resources", typeof (Resources).Assembly);
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
