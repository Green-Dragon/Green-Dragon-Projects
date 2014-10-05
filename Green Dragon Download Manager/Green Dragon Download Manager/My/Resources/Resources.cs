// Decompiled with JetBrains decompiler
// Type: WindowsApplication1.My.Resources.Resources
// Assembly: Green Dragon Download Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 718D136A-FDF9-419F-8458-6E3F7A26C7B8
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Download Manager.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsApplication1.My.Resources
{
  [HideModuleName]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [StandardModule]
  [DebuggerNonUserCode]
  [CompilerGenerated]
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
          Resources.resourceMan = new ResourceManager("WindowsApplication1.Resources", typeof (Resources).Assembly);
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
