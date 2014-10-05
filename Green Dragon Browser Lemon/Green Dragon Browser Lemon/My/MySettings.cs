// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.My.MySettings
// Assembly: Green Dragon Browser, Version=1.0.3.0, Culture=neutral, PublicKeyToken=0706e68831d27660
// MVID: 73704739-5485-4C15-86EF-C4F58132E058
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser.exe

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Green_Dragon_Browser.My
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [CompilerGenerated]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
    private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
    private static bool addedHandler;

    public static MySettings Default
    {
      get
      {
        if (!MySettings.addedHandler)
        {
          object Expression = MySettings.addedHandlerLockObject;
          ObjectFlowControl.CheckForSyncLockOnValueType(Expression);
          bool lockTaken = false;
          try
          {
            Monitor.Enter(Expression, ref lockTaken);
            if (!MySettings.addedHandler)
            {
              MyProject.Application.Shutdown += (ShutdownEventHandler) ((sender, e) =>
              {
                if (!MyProject.Application.SaveMySettingsOnExit)
                  return;
                MySettingsProperty.Settings.Save();
              });
              MySettings.addedHandler = true;
            }
          }
          finally
          {
            if (lockTaken)
              Monitor.Exit(Expression);
          }
        }
        return MySettings.defaultInstance;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("google.com")]
    public string varHomepage
    {
      get
      {
        return Conversions.ToString(this["varHomepage"]);
      }
      set
      {
        this["varHomepage"] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("")]
    [DebuggerNonUserCode]
    public string varPassword
    {
      get
      {
        return Conversions.ToString(this["varPassword"]);
      }
      set
      {
        this["varPassword"] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string varUsername
    {
      get
      {
        return Conversions.ToString(this["varUsername"]);
      }
      set
      {
        this["varUsername"] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>Google</string>\r\n</ArrayOfString>")]
    [DebuggerNonUserCode]
    public StringCollection varBookmark
    {
      get
      {
        return (StringCollection) this["varBookmark"];
      }
      set
      {
        this["varBookmark"] = (object) value;
      }
    }

    [DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>google.com</string>\r\n</ArrayOfString>")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public StringCollection varHistory
    {
      get
      {
        return (StringCollection) this["varHistory"];
      }
      set
      {
        this["varHistory"] = (object) value;
      }
    }

    [DefaultSettingValue("Welcome to your personal notepad!  These notes will automatically save when you exit, however you may save them as a text file by right clicking.")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string varNotes
    {
      get
      {
        return Conversions.ToString(this["varNotes"]);
      }
      set
      {
        this["varNotes"] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>http://www.google.com</string>\r\n</ArrayOfString>")]
    [DebuggerNonUserCode]
    public StringCollection varUrl
    {
      get
      {
        return (StringCollection) this["varUrl"];
      }
      set
      {
        this["varUrl"] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>google.com</string>\r\n</ArrayOfString>")]
    [DebuggerNonUserCode]
    public StringCollection autoComplete
    {
      get
      {
        return (StringCollection) this["autoComplete"];
      }
      set
      {
        this["autoComplete"] = (object) value;
      }
    }

    [DefaultSettingValue("true")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string themeDark
    {
      get
      {
        return Conversions.ToString(this["themeDark"]);
      }
      set
      {
        this["themeDark"] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("false")]
    public string themeLight
    {
      get
      {
        return Conversions.ToString(this["themeLight"]);
      }
      set
      {
        this["themeLight"] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("false")]
    [DebuggerNonUserCode]
    public string varTopSearch
    {
      get
      {
        return Conversions.ToString(this["varTopSearch"]);
      }
      set
      {
        this["varTopSearch"] = (object) value;
      }
    }

    [DefaultSettingValue("true")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string searchGoogle
    {
      get
      {
        return Conversions.ToString(this["searchGoogle"]);
      }
      set
      {
        this["searchGoogle"] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("false")]
    public string searchBing
    {
      get
      {
        return Conversions.ToString(this["searchBing"]);
      }
      set
      {
        this["searchBing"] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("false")]
    public string searchYoutube
    {
      get
      {
        return Conversions.ToString(this["searchYoutube"]);
      }
      set
      {
        this["searchYoutube"] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("false")]
    public string varFullscreen
    {
      get
      {
        return Conversions.ToString(this["varFullscreen"]);
      }
      set
      {
        this["varFullscreen"] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("false")]
    public string cache
    {
      get
      {
        return Conversions.ToString(this["cache"]);
      }
      set
      {
        this["cache"] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("false")]
    [DebuggerNonUserCode]
    public string autoHideMenu
    {
      get
      {
        return Conversions.ToString(this["autoHideMenu"]);
      }
      set
      {
        this["autoHideMenu"] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("")]
    public string varSelectedFav
    {
      get
      {
        return Conversions.ToString(this["varSelectedFav"]);
      }
      set
      {
        this["varSelectedFav"] = (object) value;
      }
    }

    [DefaultSettingValue("false")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string autoLock
    {
      get
      {
        return Conversions.ToString(this["autoLock"]);
      }
      set
      {
        this["autoLock"] = (object) value;
      }
    }

    [DefaultSettingValue("false")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string autoClear
    {
      get
      {
        return Conversions.ToString(this["autoClear"]);
      }
      set
      {
        this["autoClear"] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("true")]
    public string varEarlyReleases
    {
      get
      {
        return Conversions.ToString(this["varEarlyReleases"]);
      }
      set
      {
        this["varEarlyReleases"] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    private static void AutoSaveSettings(object sender, EventArgs e)
    {
      if (!MyProject.Application.SaveMySettingsOnExit)
        return;
      MySettingsProperty.Settings.Save();
    }
  }
}
