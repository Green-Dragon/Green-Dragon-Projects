// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.FavouriteTreeNode
// Assembly: Green Dragon Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d25b577927d337c7
// MVID: 43B6EF03-694B-4A1E-BE9F-3F26039BA1DF
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser Simple.exe

using System;
using System.Windows.Forms;

namespace Green_Dragon_Browser
{
  public class FavouriteTreeNode : TreeNode
  {
    private Uri _url;
    private string _directoryPath;

    public Uri Url
    {
      get
      {
        return this._url;
      }
      set
      {
        this._url = value;
      }
    }

    public string DirectoryPath
    {
      get
      {
        return this._directoryPath;
      }
      set
      {
        this._directoryPath = value;
      }
    }

    public FavouriteTreeNode()
    {
    }

    public FavouriteTreeNode(string displayText, Uri url)
    {
      this.Text = displayText;
      this.Url = url;
    }
  }
}
