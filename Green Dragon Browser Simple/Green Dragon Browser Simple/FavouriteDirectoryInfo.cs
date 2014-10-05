// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.FavouriteDirectoryInfo
// Assembly: Green Dragon Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d25b577927d337c7
// MVID: 43B6EF03-694B-4A1E-BE9F-3F26039BA1DF
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser Simple.exe

using System.Diagnostics;

namespace Green_Dragon_Browser
{
  public class FavouriteDirectoryInfo
  {
    private string _directoryName;
    private string _fullPath;

    public string DirectoryName
    {
      get
      {
        return this._directoryName;
      }
      set
      {
        this._directoryName = value;
      }
    }

    public string FullPath
    {
      get
      {
        return this._fullPath;
      }
      set
      {
        this._fullPath = value;
      }
    }

    [DebuggerNonUserCode]
    public FavouriteDirectoryInfo()
    {
    }

    public override string ToString()
    {
      return this.DirectoryName;
    }
  }
}
