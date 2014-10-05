
Public Class Data
    'Remove_Old_Icon_Images
    Shared Sub Clean_Icon_Images()
        Try
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Cleaning Game Icons" & vbCrLf) 'DEBUG ACTION LOG - 
            'Array User_Game_Icons
            Dim User_Game_Icons As New ArrayList
            For Each line In Directory.GetFiles(Application.StartupPath & "\Data\Icons\")
                User_Game_Icons.Add(Path.GetFileNameWithoutExtension(line))
            Next
            'Array Server_Game_Icons
            Dim Game As String
            Dim Server_Game_Icons As New ArrayList
            Dim Search_CFG_Line As String
            Dim Searchcfg_Split As String() = Split(Main.Searchcfg, vbCrLf.ToCharArray)
            For Each Search_CFG_Line In Searchcfg_Split
                If Search_CFG_Line.Contains(",") Then
                    Game = Search_CFG_Line.Remove(Search_CFG_Line.LastIndexOf(","))
                    Server_Game_Icons.Add(Game)
                End If
            Next
            'Compare Arrays
            Dim Game_Icon As String
            For Each Game_Icon In User_Game_Icons
                If Server_Game_Icons.Contains(Game_Icon) = False Then
                    File.Delete(Application.StartupPath & "\Data\Icons\" & Game_Icon & ".png")
                End If
            Next
            User_Game_Icons.Clear()
            Server_Game_Icons.Clear()
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Game Icons Cleaned" & vbCrLf) 'DEBUG ACTION LOG - 
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Game Image List
    Shared Sub Game_Image_List()
        Try
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Downloading Games Icons" & vbCrLf) 'DEBUG ACTION LOG - 
            Dim Search_CFG_Line As String
            Dim Category As String
            Dim Game As String
            'Clear Images
            Main.ImageList_Main.Images.Clear()
            Dim Searchcfg_Split As String() = Split(Main.Searchcfg, vbCrLf.ToCharArray)
            For Each Search_CFG_Line In Searchcfg_Split
                If Search_CFG_Line.Contains(",") Then
                    Game = Search_CFG_Line.Remove(Search_CFG_Line.LastIndexOf(","))
                    Category = Search_CFG_Line.Substring(Search_CFG_Line.LastIndexOf(",") + 1)
                    If Not File.Exists(Application.StartupPath & "\Data\Icons\" & Game & ".png") Then
                        Splash.Loading = "Downloading: " & Game & ".png"
                        Splash.Loading_AccessControl()
                        Main.CFG_WebClient.DownloadFile(New Uri("http://game-downloader.googlecode.com/svn/trunk/Data/Categories/" & Category & "/" & Game & "/Icon.png"), Application.StartupPath & "\Data\Icons\" & Game & ".png")
                    End If
                    Splash.Loading = "Loading: " & Game & ".png"
                    Splash.Loading_AccessControl()
                    Main.ImageList_Main.Images.Add(Game, Image.FromFile(Application.StartupPath & "\Data\Icons\" & Game & ".png"))
                End If
            Next
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Game Icons Downloaded" & vbCrLf) 'DEBUG ACTION LOG - 
        Catch Wx As System.Net.WebException
            Main.NotifyIcon_Main.BalloonTipText = "Connection Failed: " & Wx.Message
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Connection Failed (" & Wx.Message & ")" & vbCrLf) 'DEBUG ACTION LOG -
            'Update Variables on debug window
            Debug.Variables()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Game List
    Shared Sub Game_List()
        Try
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Loading Games From Category (" & Main.ComboBox_Category.SelectedItem.ToString & ")" & vbCrLf) 'DEBUG ACTION LOG - 
            Dim Search_CFG_Line As String
            Dim Category As String
            Dim Game As String
            'Clear ListView
            Main.ListView_Games.Items.Clear()
            Dim Searchcfg_Split As String() = Split(Main.Searchcfg, vbCrLf.ToCharArray)
            For Each Search_CFG_Line In Searchcfg_Split
                If Search_CFG_Line.Contains(",") Then
                    Game = Search_CFG_Line.Remove(Search_CFG_Line.LastIndexOf(","))
                    Category = Search_CFG_Line.Substring(Search_CFG_Line.LastIndexOf(",") + 1)
                    If Main.ComboBox_Category.SelectedItem.ToString = Category Then
                        Main.ListView_Games.Items.Add(Game, Game)
                    End If
                End If
            Next
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Games Loaded From Category (" & Main.ComboBox_Category.SelectedItem.ToString & ")" & vbCrLf) 'DEBUG ACTION LOG - 
        Catch Wx As System.Net.WebException
            Main.NotifyIcon_Main.BalloonTipText = "Connection Failed: " & Wx.Message
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Connection Failed (" & Wx.Message & ")" & vbCrLf) 'DEBUG ACTION LOG -
            'Update Variables on debug window
            Debug.Variables()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Category List
    Shared Sub Category_List()
        Try
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Loading Categories" & vbCrLf) 'DEBUG ACTION LOG - 
            Main.ComboBox_Category.Items.Clear() 'Clear Categories
            Dim Search_CFG_Line As String
            Dim Category As String
            Dim Game As String
            Dim Same_Category As String = Nothing
            Dim Searchcfg_Split As String() = Split(Main.Searchcfg, vbCrLf.ToCharArray)
            For Each Search_CFG_Line In Searchcfg_Split
                If Search_CFG_Line.Contains(",") Then
                    Game = Search_CFG_Line.Remove(Search_CFG_Line.LastIndexOf(","))
                    Category = Search_CFG_Line.Substring(Search_CFG_Line.LastIndexOf(",") + 1)
                    If Not Category = Same_Category Then
                        Main.ComboBox_Category.Items.Add(Category)
                        Same_Category = Category
                    End If
                End If
            Next
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Categories Loaded" & vbCrLf) 'DEBUG ACTION LOG - 
        Catch Wx As System.Net.WebException
            Main.NotifyIcon_Main.BalloonTipText = "Connection Failed: " & Wx.Message
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Connection Failed (" & Wx.Message & ")" & vbCrLf) 'DEBUG ACTION LOG -
            'Update Variables on debug window
            Debug.Variables()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Play Startup Sound
    Shared Sub Play_Startup_Sound()
        Try
            If Settings.CheckBox_Startup_Sound_Enabled.Checked Then 'User wants to hear sound
                If Settings.RadioButton_Startup_Sound_User.Checked Then 'User wants to hear there own selected sound
                    If File.Exists(Settings.TextBox_Startup_Sound_Path.Text) Then 'If the users selected sound exists
                        My.Computer.Audio.Play(Settings.TextBox_Startup_Sound_Path.Text) 'Play users selected sound
                    Else
                        Settings.RadioButton_Startup_Sound_Default.Checked = True 'Select default for the user
                    End If
                ElseIf Settings.RadioButton_Startup_Sound_Default.Checked Then 'User wants to hear the default sound
                    My.Computer.Audio.Play(My.Resources.Startup, AudioPlayMode.Background) 'Play default sound
                End If
            End If
        Catch Ex As Exception
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Default startup sound settings will be loaded." & vbCrLf) 'DEBUG ACTION LOG -
            Settings.RadioButton_Startup_Sound_Default.Checked = True 'Select default for the user
        End Try
    End Sub
    'Play Completed sound
    Shared Sub Play_Completed_Sound()
        Try
            If Settings.CheckBox_Download_Complete_Sound_Enabled.Checked Then ' User wants to hear sound
                If Settings.RadioButton_Download_Complete_Sound_User.Checked Then 'User wants to hear there own selected sound
                    If File.Exists(Settings.TextBox_Download_Complete_Sound_Path.Text) Then 'If the users selected sound exists
                        My.Computer.Audio.Play(Settings.TextBox_Download_Complete_Sound_Path.Text) 'Play users selected sound
                    Else
                        Settings.RadioButton_Download_Complete_Sound_Default.Checked = True 'Select default for the user
                    End If
                ElseIf Settings.RadioButton_Download_Complete_Sound_Default.Checked Then 'User want to hear the default sound
                    My.Computer.Audio.Play(My.Resources.Complete, AudioPlayMode.Background) 'Play default sound
                End If
            End If
        Catch Ex As Exception
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Default download complete sound settings will be loaded." & vbCrLf) 'DEBUG ACTION LOG -
            Settings.RadioButton_Download_Complete_Sound_Default.Checked = True 'Select default for the user
        End Try
    End Sub
    'Auto Select Random Category And Game
    Shared Sub Auto_Select_Random_Category_And_Game()
        Main.Auto_Selecting_Random_Category_And_Game = True
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Selecting Random Category" & vbCrLf) 'DEBUG ACTION LOG -
        Dim RandomClass As New Random()
        Dim RandomC As Integer = RandomClass.Next(Main.ComboBox_Category.Items.Count)
        If Not Main.ComboBox_Category.Items.Count = 0 Then
            Main.ComboBox_Category.SelectedIndex = RandomC
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Random Category Selected (" & Main.ComboBox_Category.Items(RandomC).ToString & ")" & vbCrLf) 'DEBUG ACTION LOG -
        End If
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Selecting Random Game" & vbCrLf) 'DEBUG ACTION LOG -
        Dim RandomG As Integer = RandomClass.Next(Main.ListView_Games.Items.Count)
        If Not Main.ListView_Games.Items.Count = 0 Then
            Main.ListView_Games.Items(RandomG).Selected = True
            Main.ListView_Games.Items(RandomG).EnsureVisible()
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Random Game Selected (" & Main.ListView_Games.Items(RandomG).Text & ")" & vbCrLf) 'DEBUG ACTION LOG -
        End If
        Main.Auto_Selecting_Random_Category_And_Game = False
    End Sub
    'Save Settings
    Shared Sub Save_Settings()
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("HH:mm:ss.fff tt") & "> " & "Action: Saving Settings" & vbCrLf) 'DEBUG ACTION LOG -
        If Not Directory.Exists(Application.StartupPath & "\Data\") Then
            Directory.CreateDirectory(Application.StartupPath & "\Data\")
        End If
        Dim Write_Settings_CFG As New StreamWriter(Application.StartupPath & "\Data\Settings.cfg")
        'Theme Color
        If Settings.RadioButton_Theme_Color_User.Checked = True Then
            Write_Settings_CFG.WriteLine("ThemeColor:" & Main.Theme_Color.ToArgb)
        Else
            Write_Settings_CFG.WriteLine("ThemeColor:")
        End If
        'Download Completed Option
        If Settings.RadioButton_Do_Nothing.Checked Then
            Write_Settings_CFG.WriteLine("DownloadCompletedOption:" & 1)
        ElseIf Settings.RadioButton_Open_Download_File.Checked Then
            Write_Settings_CFG.WriteLine("DownloadCompletedOption:" & 2)
        ElseIf Settings.RadioButton_Open_Download_Folder.Checked Then
            Write_Settings_CFG.WriteLine("DownloadCompletedOption:" & 3)
        End If
        'Download Enabled
        Write_Settings_CFG.WriteLine("DownloadEnabled:" & Settings.CheckBox_Download_Enabled.Checked.ToString)
        'Download Path
        If Settings.RadioButton_Download_User.Checked Then
            If Directory.Exists(Settings.TextBox_Download_Path.Text) Then
                Write_Settings_CFG.WriteLine("DownloadPath:" & Settings.TextBox_Download_Path.Text)
            Else
                Write_Settings_CFG.WriteLine("DownloadPath:")
            End If
        Else
            Write_Settings_CFG.WriteLine("DownloadPath:")
        End If
        'Startup Sound Enabled
        Write_Settings_CFG.WriteLine("StartupSoundEnabled:" & Settings.CheckBox_Startup_Sound_Enabled.Checked.ToString)
        'Startup Sound Path
        If File.Exists(Settings.TextBox_Startup_Sound_Path.Text) Then
            Write_Settings_CFG.WriteLine("StartupSoundPath:" & Settings.TextBox_Startup_Sound_Path.Text)
        Else
            Write_Settings_CFG.WriteLine("StartupSoundPath:")
        End If
        'Download Complete Sound Enabled
        Write_Settings_CFG.WriteLine("DownloadCompleteSoundEnabled:" & Settings.CheckBox_Download_Complete_Sound_Enabled.Checked.ToString)
        'Download Complete Sound Path
        If File.Exists(Settings.TextBox_Download_Complete_Sound_Path.Text) Then
            Write_Settings_CFG.WriteLine("DownloadCompleteSoundPath:" & Settings.TextBox_Download_Complete_Sound_Path.Text)
        Else
            Write_Settings_CFG.WriteLine("DownloadCompleteSoundPath:")
        End If
        Write_Settings_CFG.Close()
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("HH:mm:ss.fff tt") & "> " & "Information: Settings Saved" & vbCrLf) 'DEBUG ACTION LOG -
    End Sub
    'Load Settings
    Shared Sub Load_Settings()
        If File.Exists(Application.StartupPath & "\Data\Settings.cfg") Then
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Loading Settings" & vbCrLf) 'DEBUG ACTION LOG -
            Try
                Dim Application_Root_Directory As String = Directory.GetDirectoryRoot(Application.StartupPath)
                Dim Settings_CFG() As String = File.ReadAllLines(Application.StartupPath & "\Data\Settings.cfg")

                'Theme Color
                If Settings_CFG(0).StartsWith("ThemeColor:") Then
                    Settings_CFG(0) = Settings_CFG(0).Substring(11)
                    If Settings_CFG(0).Length > 0 Then
                        Settings.RadioButton_Theme_Color_User.Checked = True
                        Main.Theme_Color = Color.FromArgb(CInt(Settings_CFG(0)))
                        Settings.ColorDialog_Theme.Color = Main.Theme_Color
                        Set_Theme_Color()
                    End If
                Else
                    Settings_CFG = Nothing
                    Default_Settings()
                    Exit Sub
                End If

                'Download Completed Option
                If Settings_CFG(1).StartsWith("DownloadCompletedOption:") Then
                    Settings_CFG(1) = Settings_CFG(1).Substring(24)
                    If IsNumeric(Settings_CFG(1)) Then
                        If Settings_CFG(1) = "1" Then
                            Settings.RadioButton_Do_Nothing.Checked = True
                        ElseIf Settings_CFG(1) = "2" Then
                            Settings.RadioButton_Open_Download_File.Checked = True
                        ElseIf Settings_CFG(1) = "3" Then
                            Settings.RadioButton_Open_Download_Folder.Checked = True
                        Else
                            Settings_CFG = Nothing
                            Default_Settings()
                            Exit Sub
                        End If
                    End If
                Else
                    Settings_CFG = Nothing
                    Default_Settings()
                    Exit Sub
                End If
                'Download Enabled
                If Settings_CFG(2).StartsWith("DownloadEnabled:") Then
                    Settings_CFG(2) = Settings_CFG(2).Substring(16)
                    If (Settings_CFG(2)) = "True" Then
                        Settings.CheckBox_Download_Enabled.Checked = True
                    ElseIf (Settings_CFG(2)) = "False" Then
                        Settings.CheckBox_Download_Enabled.Checked = False
                    Else
                        Settings_CFG = Nothing
                        Default_Settings()
                        Exit Sub
                    End If
                Else
                    Settings_CFG = Nothing
                    Default_Settings()
                    Exit Sub
                End If
                'Download Path
                If Settings_CFG(3).StartsWith("DownloadPath:") Then
                    Settings_CFG(3) = Settings_CFG(3).Substring(13)
                    'if user dir Exists
                    If Directory.Exists(Settings_CFG(3)) Then
                        Settings.RadioButton_Download_User.Checked = True
                        Settings.TextBox_Download_Path.Text = Settings_CFG(3)
                        Main.Game_Download_Path = Settings.TextBox_Download_Path.Text
                    Else
                        If Not Settings_CFG(3) = Nothing Then
                            If File.Exists(Application_Root_Directory & Settings_CFG(3).Substring(3)) Then
                                Settings.RadioButton_Download_User.Checked = True
                                Settings.TextBox_Download_Path.Text = Application_Root_Directory & Settings_CFG(3).Substring(3)
                                Main.Game_Download_Path = Settings.TextBox_Download_Path.Text
                            End If
                        Else
                            Settings.RadioButton_Download_Default.Checked = True
                        End If
                    End If
                Else
                    Settings_CFG = Nothing
                    Default_Settings()
                    Exit Sub
                End If
                'Startup Sound Enabled
                If Settings_CFG(4).StartsWith("StartupSoundEnabled:") Then
                    Settings_CFG(4) = Settings_CFG(4).Substring(20)
                    If (Settings_CFG(4)) = "True" Then
                        Settings.CheckBox_Startup_Sound_Enabled.Checked = True
                    ElseIf (Settings_CFG(4)) = "False" Then
                        Settings.CheckBox_Startup_Sound_Enabled.Checked = False
                    Else
                        Settings_CFG = Nothing
                        Default_Settings()
                        Exit Sub
                    End If
                Else
                    Settings_CFG = Nothing
                    Default_Settings()
                    Exit Sub
                End If
                'Startup Sound Path
                If Settings_CFG(5).StartsWith("StartupSoundPath:") Then
                    Settings_CFG(5) = Settings_CFG(5).Substring(17)
                    If File.Exists(Settings_CFG(5)) Then
                        Settings.TextBox_Startup_Sound_Path.Text = Settings_CFG(5)
                        Settings.RadioButton_Startup_Sound_User.Checked = True
                    Else
                        If Not Settings_CFG(5) = Nothing Then
                            If File.Exists(Application_Root_Directory & Settings_CFG(5).Substring(3)) Then
                                Settings.TextBox_Startup_Sound_Path.Text = Settings_CFG(5)
                                Settings.RadioButton_Startup_Sound_User.Checked = True
                            End If
                        End If
                    End If
                Else
                    Settings_CFG = Nothing
                    Default_Settings()
                    Exit Sub
                End If
                'Download Complete Sound Enabled
                If Settings_CFG(6).StartsWith("DownloadCompleteSoundEnabled:") Then
                    Settings_CFG(6) = Settings_CFG(6).Substring(29)
                    If (Settings_CFG(6)) = "True" Then
                        Settings.CheckBox_Download_Complete_Sound_Enabled.Checked = True
                    ElseIf (Settings_CFG(6)) = "False" Then
                        Settings.CheckBox_Download_Complete_Sound_Enabled.Checked = False
                    Else
                        Settings_CFG = Nothing
                        Default_Settings()
                        Exit Sub
                    End If
                Else
                    Settings_CFG = Nothing
                    Default_Settings()
                    Exit Sub
                End If
                'Download Complete Sound Path
                If Settings_CFG(7).StartsWith("DownloadCompleteSoundPath:") Then
                    Settings_CFG(7) = Settings_CFG(7).Substring(26)
                    If File.Exists(Settings_CFG(7)) Then
                        Settings.TextBox_Download_Complete_Sound_Path.Text = Settings_CFG(7)
                        Settings.RadioButton_Download_Complete_Sound_User.Checked = True
                    Else
                        If Not Settings_CFG(7) = Nothing Then
                            If File.Exists(Application_Root_Directory & Settings_CFG(7).Substring(3)) Then
                                Settings.TextBox_Download_Complete_Sound_Path.Text = Application_Root_Directory & Settings_CFG(7).Substring(3)
                                Settings.RadioButton_Download_Complete_Sound_User.Checked = True
                            End If
                        End If
                    End If
                Else
                    Settings_CFG = Nothing
                    Default_Settings()
                    Exit Sub
                End If
                Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Settings Loaded" & vbCrLf) 'DEBUG ACTION LOG -
            Catch Ex As Exception
                Default_Settings()
            End Try
        Else
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: No Settings Found" & vbCrLf) 'DEBUG ACTION LOG - 
            Default_Settings()
        End If
    End Sub
    'Bad Game Folder
    Shared Sub Bad_Game_CFG()
        'Clear GUI And Data
        Clear_GUI_And_Data()
        'Remove game from list
        Main.ListView_Games.Items.Remove(Main.ListView_Games.Items.Item(Main.Selected_Index))
        Main.ImageList_Main.Images.RemoveByKey(Main.Selected_Item)
        'Notify
        Main.NotifyIcon_Main.BalloonTipText = Main.Selected_Game & " contains invalid data and has been removed from the list."
        Main.NotifyIcon_Main.ShowBalloonTip(1500)
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Bad Game CFG:" & Main.Selected_Game & vbCrLf) 'DEBUG ACTION LOG -
        Main.Selected_Game = Nothing
    End Sub
    'Search For Game
    Shared Sub Search_For_Game()
        Try
            Main.Searching_For_Game = True
            Main.NotifyIcon_Main.BalloonTipText = "Searching for game..."
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Searching for game..." & vbCrLf) 'DEBUG ACTION LOG -
            Dim Search_CFG_Line As String
            Dim Category As String
            Dim Game As String
            Dim Searchcfg_Split As String() = Split(Main.Searchcfg, vbCrLf.ToCharArray)
            For Each Search_CFG_Line In Searchcfg_Split
                If Search_CFG_Line.Contains(",") Then
                    Game = Search_CFG_Line.Remove(Search_CFG_Line.LastIndexOf(","))
                    Category = Search_CFG_Line.Substring(Search_CFG_Line.LastIndexOf(",") + 1)
                    If Main.TextBox_Search_For_Game.Text.ToLower = Game.ToLower Then
                        'Select the category
                        Main.ComboBox_Category.SelectedItem = Category
                        'Select the game
                        Dim item As ListViewItem
                        For Each item In Main.ListView_Games.Items
                            If Main.ListView_Games.Items(item.Index).Text = Game Then
                                Main.ListView_Games.Items(item.Index).Selected = True
                                Main.ListView_Games.Items(item.Index).EnsureVisible()
                                Main.ListView_Games.Select()
                            End If
                        Next
                        Main.Searching_For_Game = False
                        Main.NotifyIcon_Main.BalloonTipText = "Game found."
                        Main.NotifyIcon_Main.ShowBalloonTip(1500)
                        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Game found." & vbCrLf) 'DEBUG ACTION LOG -
                        If Main.Visible And Not Main.WindowState = FormWindowState.Minimized Then
                            Main.WindowState = FormWindowState.Normal
                        Else
                            Data.Show_Hide_Main_Window()
                        End If
                        Exit Sub
                    End If
                End If
            Next
            Main.NotifyIcon_Main.BalloonTipText = "Game not found."
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Game not found." & vbCrLf) 'DEBUG ACTION LOG -
            Main.Searching_For_Game = False
        Catch Wx As System.Net.WebException
            Main.NotifyIcon_Main.BalloonTipText = "Connection Failed: " & Wx.Message
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Connection Failed (" & Wx.Message & ")" & vbCrLf) 'DEBUG ACTION LOG -
            'Update Variables on debug window
            Debug.Variables()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Check For Updates
    Shared Sub Check_For_Updates()
        Try
            If Main.Games_Downloading.Count < 1 Then
                Dim Svn_Version As String
                Main.NotifyIcon_Requesting.Visible = True
                Main.NotifyIcon_Requesting.BalloonTipText = "Checking for updates..."
                Main.NotifyIcon_Requesting.ShowBalloonTip(1500)
                Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Checking for updates" & vbCrLf) 'DEBUG ACTION LOG - 
                'Store Stream
                Dim Games_CFG_Stream As Stream = Main.CFG_WebClient.OpenRead("https://www.dropbox.com/s/unkyiv6fsb8qdwe/Version.cfg?dl=1")
                'Read Stream
                Dim Version_Reader As New StreamReader(Games_CFG_Stream)
                Svn_Version = Version_Reader.ReadLine()
                Version_Reader.Close()
                Main.NotifyIcon_Requesting.Visible = False
                Dim Users_Version As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath.ToString)
                Dim response As MsgBoxResult
                If Users_Version.FileVersion < Svn_Version Then 'User Need Update
                    Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Update is available version " & Svn_Version & " Download update now?" & vbCrLf) 'DEBUG ACTION LOG - 
                    response = MsgBox("Update is available version " & Svn_Version & vbCrLf & "Download update now?", MsgBoxStyle.YesNo)
                    If response = MsgBoxResult.Yes Then
                        Main.NotifyIcon_Main.Visible = False
                        Main.Hide()
                        Main.NotifyIcon_Requesting.Visible = True
                        Main.NotifyIcon_Requesting.BalloonTipText = "Updating..."
                        Main.NotifyIcon_Requesting.ShowBalloonTip(1500)
                        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Updating..." & vbCrLf) 'DEBUG ACTION LOG - 
                        'Rename the old version
                        My.Computer.FileSystem.RenameFile(Application.ExecutablePath.ToString, "Green Dragon Game Downloader_OLD.exe")
                        'Download the new version
                        Main.CFG_WebClient.DownloadFile(New Uri("https://www.dropbox.com/sh/4xky4ml606980bx/AAAwZpXo4GHUmKVMhH3d0ACKa/Green%20Dragon%20Game%20Downloader.exe?dl=1"), Application.StartupPath & "\Green Dragon Game Downloader.exe")
                        'Start new version
                        Process.Start(Application.StartupPath & "\Green Dragon Game Downloader.exe")
                        'Close old version
                        Application.Exit()
                    End If
                Else 'User Does Not Need A Update
                    Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: You have the latest version." & vbCrLf) 'DEBUG ACTION LOG - 
                    MsgBox("You have the latest version.", MsgBoxStyle.Information)
                End If
                response = Nothing
                Svn_Version = Nothing
                Users_Version = Nothing
            Else
                MsgBox("Please close any downloads before trying to update.", MsgBoxStyle.Information)
            End If
        Catch Wx As System.Net.WebException
            Main.NotifyIcon_Requesting.Visible = False
            Main.NotifyIcon_Main.BalloonTipText = "Connection Failed: " & Wx.Message
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Connection Failed (" & Wx.Message & ")" & vbCrLf) 'DEBUG ACTION LOG -
            'Update Variables on debug window
            Debug.Variables()
        Catch Ex As Exception
            Main.NotifyIcon_Requesting.Visible = False
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Show / Hide Main Window
    Shared Sub Show_Hide_Main_Window()
        If Main.WindowState = FormWindowState.Normal Then
            Main.WindowState = FormWindowState.Minimized
            Main.Hide()
            Main.NotifyIcon_Main.BalloonTipText = "Minimized to tray."
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
        Else
            Main.Show()
            Main.WindowState = FormWindowState.Normal
            Main.BringToFront()
            Main.Activate()
        End If
    End Sub
    'Clear GUI And Data
    Shared Sub Clear_GUI_And_Data()
        If Not Main.PictureBox_Game_Image.ImageLocation = (Nothing) Or _
         Not Main.Website = Nothing Or _
         Not Main.Download = Nothing Or _
         Not Main.TextBox_About.Text = Nothing Or _
         Not Main.TextBox_Singleplayer.Text = Nothing Or _
         Not Main.TextBox_MultiPlayer.Text = Nothing Or _
         Not Main.TextBox_PlayOnline.Text = Nothing Or _
         Not Main.TextBox_RequiresAccount.Text = Nothing Or _
         Not Main.TextBox_Version.Text = Nothing Or _
         Not Main.TextBox_File_Size.Text = Nothing Or _
         Not Main.ToolTip_Main.GetToolTip(Main.Button_youtube) = Nothing Or _
         Not Main.ToolTip_Main.GetToolTip(Main.Button_Website) = Nothing Or _
         Not Main.ToolTip_Main.GetToolTip(Main.Button_Download) = Nothing Then
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Clearing GUI And Data" & vbCrLf) 'DEBUG ACTION LOG -
            'Clear Images
            Main.PictureBox_Game_Image.ImageLocation = (Nothing)
            'Main.ImageList_Main.Images.Clear()
            'Main.ListView1.Items.Clear()

            'Clear Strings
            Main.Website = Nothing
            Main.Download = Nothing
            'Clear GUI
            Main.TextBox_About.Clear()
            Main.TextBox_Singleplayer.Clear()
            Main.TextBox_MultiPlayer.Clear()
            Main.TextBox_PlayOnline.Clear()
            Main.TextBox_RequiresAccount.Clear()
            Main.TextBox_Version.Clear()
            Main.TextBox_File_Size.Clear()
            'Reset tooltips
            Main.ToolTip_Main.SetToolTip(Main.Button_youtube, Nothing)
            Main.ToolTip_Main.SetToolTip(Main.Button_Website, Nothing)
            Main.ToolTip_Main.SetToolTip(Main.Button_Download, Nothing)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: GUI And Data Cleared" & vbCrLf) 'DEBUG ACTION LOG -
        End If
    End Sub
    'Reconnect Category from server & Random Category And Game
    Shared Sub Reconnect()
        Main.NotifyIcon_Main.Visible = False
        Main.NotifyIcon_Requesting.Visible = True
        Main.Hide()
        Main.NotifyIcon_Requesting.BalloonTipText = "Reconnecting..."
        Main.NotifyIcon_Requesting.ShowBalloonTip(1500)
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Reconnecting" & vbCrLf) 'DEBUG ACTION LOG -
        'Checking Server Connection
        Main.NotifyIcon_Requesting.BalloonTipText = "Checking Server Connection..."
        Main.NotifyIcon_Requesting.ShowBalloonTip(1500)
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Checking Server Connection" & vbCrLf) 'DEBUG ACTION LOG -
        Data.Check_Connection()
        'Verifying Server Connection
        Main.NotifyIcon_Requesting.BalloonTipText = "Verifying Server Connection..."
        Main.NotifyIcon_Requesting.ShowBalloonTip(1500)
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Verifying Server Connection" & vbCrLf) 'DEBUG ACTION LOG -
        If Main.Connection = True Then
            'Load Games And Categories List
            Games_And_Categories_List()
            'Load Categories
            Category_List()
            'Auto Select Random Category And Game
            Auto_Select_Random_Category_And_Game()
            'Load Search Autocomplete
            Load_Search_Autocomplete()
            Main.NotifyIcon_Requesting.Visible = False
            Main.NotifyIcon_Main.Visible = True
            Main.Show()
            Main.NotifyIcon_Main.BalloonTipText = "Connected"
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Connected" & vbCrLf) 'DEBUG ACTION LOG -
        Else
            Main.NotifyIcon_Requesting.Visible = False
            Main.NotifyIcon_Main.Visible = True
            Main.Show()
            Main.NotifyIcon_Main.BalloonTipText = "Connection: Failed"
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Connection Failed" & vbCrLf) 'DEBUG ACTION LOG -
        End If
    End Sub
    'Default Settings
    Shared Sub Default_Settings()
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Loading Default Settings" & vbCrLf) 'DEBUG ACTION LOG - 
        Settings.RadioButton_Theme_Color_Default.Checked = True
        'Download Completed Option
        Settings.RadioButton_Do_Nothing.Checked = True
        'Download Enabled
        Settings.CheckBox_Download_Enabled.Checked = True
        'Default Download
        Settings.RadioButton_Download_Default.Checked = True
        'Startup Sound Enabled
        Settings.CheckBox_Startup_Sound_Enabled.Checked = True
        'Default Startup Sound 
        Settings.RadioButton_Startup_Sound_Default.Checked = True
        'Completed Sound Enabled
        Settings.CheckBox_Download_Complete_Sound_Enabled.Checked = True
        'Completed Sound Path
        Settings.RadioButton_Download_Complete_Sound_Default.Checked = True
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Default Settings Loaded" & vbCrLf) 'DEBUG ACTION LOG - 
    End Sub
    'Load Search Autocomplete
    Shared Sub Load_Search_Autocomplete()
        Try
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Loading Autocomplete List" & vbCrLf) 'DEBUG ACTION LOG - 
            Dim Search_CFG_Stream As Stream = Main.CFG_WebClient.OpenRead("http://game-downloader.googlecode.com/svn/trunk/Data/Search.cfg")
            'Create the list to use as the custom source.
            Dim AutoComplete_Games As New AutoCompleteStringCollection()
            Dim Game_For_AutoComplete As String
            Main.GameCount = 0
            Dim Search_CFG_Reader As New StreamReader(Search_CFG_Stream)
            Do While Search_CFG_Reader.EndOfStream = False
                Game_For_AutoComplete = Search_CFG_Reader.ReadLine
                If Game_For_AutoComplete.Contains(",") Then
                    Game_For_AutoComplete = Game_For_AutoComplete.Remove(Game_For_AutoComplete.LastIndexOf(","))
                    AutoComplete_Games.Add(Game_For_AutoComplete)
                    Main.GameCount = Main.GameCount + 1
                End If
            Loop
            Search_CFG_Reader.Close() 'Close StreamReader
            Main.TextBox_Search_For_Game.AutoCompleteCustomSource = AutoComplete_Games
            Main.Label_Title.Text = Main.Text & " - " & Main.GameCount.ToString & " Games"
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Autocomplete List Loaded" & vbCrLf) 'DEBUG ACTION LOG - 
        Catch Wx As System.Net.WebException
            Main.NotifyIcon_Main.BalloonTipText = "Connection Failed: " & Wx.Message
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Connection Failed (" & Wx.Message & ")" & vbCrLf) 'DEBUG ACTION LOG -
            'Update Variables on debug window
            Debug.Variables()
        Catch Ex As Exception
            Main.NotifyIcon_Requesting.Visible = False
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Theme Color
    Shared Sub Set_Theme_Color()
        'Main
        Main.GroupBox_About.ForeColor = Main.Theme_Color
        Main.GroupBox_Category.ForeColor = Main.Theme_Color
        Main.GroupBox_Games.ForeColor = Main.Theme_Color
        Main.GroupBox_Screen_Shot.ForeColor = Main.Theme_Color
        Main.GroupBox_Search_For_Game.ForeColor = Main.Theme_Color
        Main.Button_Download.ForeColor = Main.Theme_Color
        Main.Button_Website.ForeColor = Main.Theme_Color
        Main.Button_youtube.ForeColor = Main.Theme_Color
        Main.MenuStrip_Main.ForeColor = Main.Theme_Color
        Main.ContextMenuStrip_Menu.ForeColor = Main.Theme_Color
        Main.ContextMenuItem_About.ForeColor = Main.Theme_Color
        Main.ContextMenuItem_CheckForUpdates.ForeColor = Main.Theme_Color
        Main.ContextMenuItem_Exit.ForeColor = Main.Theme_Color
        Main.ContextMenuItem_News.ForeColor = Main.Theme_Color
        Main.ContextMenuItem_Settings.ForeColor = Main.Theme_Color
        Main.ContextMenuItem_Downloads.ForeColor = Main.Theme_Color
        Main.AboutToolStripMenuItem.ForeColor = Main.Theme_Color
        Main.CheckForUpdatesToolStripMenuItem.ForeColor = Main.Theme_Color
        Main.ReconnectToolStripMenuItem.ForeColor = Main.Theme_Color
        Main.SettingsToolStripMenuItem.ForeColor = Main.Theme_Color
        Main.ToolStripSeparator1.ForeColor = Main.Theme_Color
        Main.DownloadsToolStripMenuItem.ForeColor = Main.Theme_Color
        Main.Label_Version.ForeColor = Main.Theme_Color
        Main.Label_FileSize.ForeColor = Main.Theme_Color
        'Settings
        Settings.GroupBox_Download_Complete_Sound.ForeColor = Main.Theme_Color
        Settings.GroupBox_Download_Directory.ForeColor = Main.Theme_Color
        Settings.GroupBox_On_Download_Complete.ForeColor = Main.Theme_Color
        Settings.GroupBox_Startup_Sound.ForeColor = Main.Theme_Color
        Settings.GroupBox_Theme_Color.ForeColor = Main.Theme_Color

        If Settings.RadioButton_Theme_Color_User.Checked Then
            Settings.RadioButton_Theme_Color_User.FlatAppearance.BorderColor = Main.Theme_Color
        End If
        If Settings.RadioButton_Download_User.Checked Then
            Settings.RadioButton_Download_User.FlatAppearance.BorderColor = Main.Theme_Color
        End If
        If Settings.RadioButton_Startup_Sound_User.Checked Then
            Settings.RadioButton_Startup_Sound_User.FlatAppearance.BorderColor = Main.Theme_Color
        End If
        If Settings.RadioButton_Download_Complete_Sound_User.Checked Then
            Settings.RadioButton_Download_Complete_Sound_User.FlatAppearance.BorderColor = Main.Theme_Color
        End If
        'About
        About.GroupBox_About.ForeColor = Main.Theme_Color
        About.Button_Project_Page.ForeColor = Main.Theme_Color
        'Debug
        Debug.GroupBox_Action_Log.ForeColor = Main.Theme_Color
        Debug.GroupBox_Variables.ForeColor = Main.Theme_Color
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Theme Color Set (" & Main.Theme_Color.ToArgb.ToString & ")" & vbCrLf) 'DEBUG ACTION LOG -
    End Sub
    'Check Connection
    Shared Sub Check_Connection()
        Try
            Dim Check_Url As New System.Uri("http://game-downloader.googlecode.com")
            Main.Request = WebRequest.Create(Check_Url)
            Main.Request.Proxy = Nothing
            Main.Response = Main.Request.GetResponse
            Main.Response.Close()
            Main.Request = Nothing
            Main.Connection = True
        Catch ex As Exception
            Main.Request = Nothing
            Main.Connection = False
        End Try
    End Sub
    'Games And Categories List
    Shared Sub Games_And_Categories_List()
        Try
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Loading Games List" & vbCrLf) 'DEBUG ACTION LOG - 
            Main.Searchcfg = Nothing
            Dim Search_CFG_Stream As Stream = Main.CFG_WebClient.OpenRead("http://game-downloader.googlecode.com/svn/trunk/Data/Search.cfg")
            Dim Search_CFG_Reader As New StreamReader(Search_CFG_Stream)
            Main.Searchcfg = Search_CFG_Reader.ReadToEnd()
            Search_CFG_Reader.Close() 'Close StreamReader
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Games List Loaded" & vbCrLf) 'DEBUG ACTION LOG - 
        Catch Wx As System.Net.WebException
            Main.NotifyIcon_Main.BalloonTipText = "Connection Failed: " & Wx.Message
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Connection Failed (" & Wx.Message & ")" & vbCrLf) 'DEBUG ACTION LOG -
            'Update Variables on debug window
            Debug.Variables()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class