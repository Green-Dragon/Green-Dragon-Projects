// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Writer.My.MySettings
// Assembly: Green Dragon Writer, Version=4.0.0.0, Culture=neutral, PublicKeyToken=f92e69f0319eaf84
// MVID: 722C2D38-0399-4F2F-8284-6B57384604E3
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Writer\Green Dragon Writer.exe

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Green_Dragon_Writer.My
{
  [CompilerGenerated]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
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
