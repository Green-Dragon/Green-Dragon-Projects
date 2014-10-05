// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.My.MySettings
// Assembly: Green Dragon Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d25b577927d337c7
// MVID: 43B6EF03-694B-4A1E-BE9F-3F26039BA1DF
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser Simple.exe

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Green_Dragon_Browser.My
{
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
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
          Monitor.Enter(Expression);
          try
          {
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
            Monitor.Exit(Expression);
          }
        }
        MySettings mySettings = MySettings.defaultInstance;
        return mySettings;
      }
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool StartWithHomePage
    {
      get
      {
        return Conversions.ToBoolean(this["StartWithHomePage"]);
      }
      set
      {
        this["StartWithHomePage"] = (object) (bool) (value ? 1 : 0);
      }
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("")]
    public string HomePage
    {
      get
      {
        return Conversions.ToString(this["HomePage"]);
      }
      set
      {
        this["HomePage"] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    public MySettings()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerNonUserCode]
    private static void AutoSaveSettings(object sender, EventArgs e)
    {
      if (!MyProject.Application.SaveMySettingsOnExit)
        return;
      MySettingsProperty.Settings.Save();
    }
  }
}
