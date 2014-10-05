'Imports System.Drawing.Drawing2D


Public Class Main
    Public Website As String
    Public Download As String
    Public WithEvents CFG_WebClient As New WebClient
    Public Game_CFG As String
    Public Game_Download_Path As String
    Public Selected_Game As String
    Public Theme_Color As Color = Color.FromArgb(0, 74, 127)
    Public Connection As Boolean = False
    Public Request As WebRequest = Nothing
    Public Response As WebResponse = Nothing
    Public TotalFileSize As Long
    Public Game_Download As String
    Public Games_Downloading As New ArrayList
    Public Auto_Selecting_Random_Category_And_Game As Boolean = False
    Public Searching_For_Game As Boolean = False
    Public Game_Icon As Image
    Public Searchcfg As String
    Public GameCount As Integer = 0
    Public Selected_Item As String
    Public Selected_Index As Integer
    'SetBytes
    Function SetBytes(ByVal Bytes As Double) As String
        SetBytes = Nothing
        If Bytes >= 1073741824 Then
            SetBytes = Format(Bytes / 1024 / 1024 / 1024, "#0.00") & " GB"
        ElseIf Bytes >= 1048576 Then
            SetBytes = Format(Bytes / 1024 / 1024, "#0.00") & " MB"
        ElseIf Bytes >= 1024 Then
            SetBytes = Format(Bytes / 1024, "#0.00") & " KB"
        ElseIf Bytes < 1024 Then
            SetBytes = Fix(Bytes) & " Bytes"
        End If
    End Function
    'On Startup
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Debug.TextBox_Action_Log.Text = "<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action Log Started" & vbCrLf  'DEBUG ACTION LOG - Time Stamp
        Me.KeyPreview = True
        CFG_WebClient.Proxy = Nothing
        'Rename window and window label
        Me.Text = My.Application.Info.Title.ToString
        Label_Title.Text = My.Application.Info.Title.ToString
        'Check For Downloads Folder
        Splash.Loading = "Checking For Downloads Folder..."
        Splash.Loading_AccessControl()
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Checking For Downloads Folder" & vbCrLf) 'DEBUG ACTION LOG - 
        Splash.Loading_Bar = 15
        Splash.Loading_Bar_AccessControl()
        If Not Directory.Exists(Environment.GetEnvironmentVariable("userprofile") & "\Downloads\") Then
            Directory.CreateDirectory(Environment.GetEnvironmentVariable("userprofile") & "\Downloads\")
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Downloads Folder Created" & vbCrLf) 'DEBUG ACTION LOG -
        Else
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Downloads Folder Found" & vbCrLf) 'DEBUG ACTION LOG -
        End If
        'Check For Data Folder
        Splash.Loading = "Checking For Data Folder..."
        Splash.Loading_AccessControl()
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Checking For Data Folder" & vbCrLf) 'DEBUG ACTION LOG - 
        Splash.Loading_Bar = 25
        Splash.Loading_Bar_AccessControl()
        If Not Directory.Exists(Application.StartupPath & "\Data\") Then
            Directory.CreateDirectory(Application.StartupPath & "\Data\")
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Data Folder Created" & vbCrLf) 'DEBUG ACTION LOG -
        Else
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Data Folder Found" & vbCrLf) 'DEBUG ACTION LOG -
        End If
        'Check For Icons Folder
        Splash.Loading = "Checking for Icons folder..."
        Splash.Loading_AccessControl()
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Checking For Icons Folder" & vbCrLf) 'DEBUG ACTION LOG -
        If Not Directory.Exists(Application.StartupPath & "\Data\Icons\") Then
            Directory.CreateDirectory(Application.StartupPath & "\Data\Icons\")
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Icons Folder Created" & vbCrLf) 'DEBUG ACTION LOG -
        Else
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Icons Folder Found" & vbCrLf) 'DEBUG ACTION LOG -
        End If
        'Check For Needed Libraries
        Splash.Loading = "Checking For Needed Libraries..."
        Splash.Loading_AccessControl()
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Checking For Needed Libraries" & vbCrLf) 'DEBUG ACTION LOG - 
        'Check For Microsoft.WindowsAPICodePack.Shell.dll
        If Not File.Exists(Application.StartupPath & "\Microsoft.WindowsAPICodePack.Shell.dll") Then
            My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Microsoft.WindowsAPICodePack.Shell.dll", My.Resources.Microsoft_WindowsAPICodePack_Shell, False)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Library Created (Microsoft.WindowsAPICodePack.Shell.dll)" & vbCrLf) 'DEBUG ACTION LOG -
        Else
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Library (Microsoft.WindowsAPICodePack.Shell.dll) Found" & vbCrLf) 'DEBUG ACTION LOG -
        End If
        'Checking For Microsoft.WindowsAPICodePack.dll
        If Not File.Exists(Application.StartupPath & "\Microsoft.WindowsAPICodePack.dll") Then
            My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Microsoft.WindowsAPICodePack.dll", My.Resources.Microsoft_WindowsAPICodePack, False)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Library Created (Microsoft.WindowsAPICodePack.dll)" & vbCrLf) 'DEBUG ACTION LOG -
        Else
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Library (Microsoft.WindowsAPICodePack.dll) Found" & vbCrLf) 'DEBUG ACTION LOG -
        End If
        'Check For Game Downloader_OLD.exe 
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Checking For Old File Version (Green Dragon Game Downloader_OLD.exe)" & vbCrLf) 'DEBUG ACTION LOG -
        If File.Exists(Application.StartupPath & "\Game Downloader_OLD.exe") Then
            File.Delete(Application.StartupPath & "\Game Downloader_OLD.exe")
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Deleted Old File Version (Green Dragon Game Downloader_OLD.exe)" & vbCrLf) 'DEBUG ACTION LOG - 
        Else
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: No Old File Version Found" & vbCrLf) 'DEBUG ACTION LOG -
        End If
        'Load settings
        Splash.Loading = "Loading: \Data\Settings.cfg"
        Splash.Loading_AccessControl()
        Splash.Loading_Bar = 55
        Splash.Loading_Bar_AccessControl()
        Data.Load_Settings()
        'Check Server Connection
        Splash.Loading = "Checking Connection..."
        Splash.Loading_AccessControl()
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Checking Connection" & vbCrLf) 'DEBUG ACTION LOG - 
        Splash.Loading_Bar = 75
        Splash.Loading_Bar_AccessControl()
        Data.Check_Connection()
        'Verify Server Connection
        Splash.Loading = "Verifying Connection..."
        Splash.Loading_AccessControl()
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Verifying Connection" & vbCrLf) 'DEBUG ACTION LOG - 
        If Connection = True Then
            Splash.Loading = "Connected"
            Splash.Loading_AccessControl()
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Connected" & vbCrLf) 'DEBUG ACTION LOG - 
        Else
            Splash.Loading = "Connection: Failed"
            Splash.Loading_AccessControl()
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Connection Failed" & vbCrLf) 'DEBUG ACTION LOG - 
            'Show NotifyIcon_Main
            NotifyIcon_Main.Visible = True
            NotifyIcon_Main.BalloonTipText = "Connection: Failed"
            NotifyIcon_Main.ShowBalloonTip(1500)
            System.Threading.Thread.Sleep(1500)
            Exit Sub
        End If
        'Load Games And Categories List
        Data.Games_And_Categories_List()
        'Load Categories
        Splash.Loading = "Loading Categories..."
        Splash.Loading_AccessControl()
        Splash.Loading_Bar = 80
        Splash.Loading_Bar_AccessControl()
        Data.Category_List()
        'Load Search Autocomplete
        Splash.Loading = "Loading Autocomplete List..."
        Splash.Loading_AccessControl()
        Data.Load_Search_Autocomplete()
        Splash.Loading_Bar = 90
        Splash.Loading_Bar_AccessControl()
        'Load Game Icons
        Splash.Loading = "Loading Game Icons..."
        Splash.Loading_AccessControl()
        Data.Game_Image_List()
        'Clean User Icons
        Data.Clean_Icon_Images()
        Splash.Loading = "Cleaning Game Icons..."
        Splash.Loading_AccessControl()
        Data.Game_Image_List()
        'Auto select category and game
        Splash.Loading = "Selecting Random Game..."
        Splash.Loading_AccessControl()
        Splash.Loading_Bar = 95
        Splash.Loading_Bar_AccessControl()
        Data.Auto_Select_Random_Category_And_Game()
        'Loading Bar 100%
        Splash.Loading_Bar = 100
        Splash.Loading_Bar_AccessControl()
        'Play startup sound
        Data.Play_Startup_Sound()
        'Show NotifyIcon_Main
        NotifyIcon_Main.Visible = True
    End Sub
    'On Closing
    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Games_Downloading.Count < 1 And Debug.Visible = False And False Then
            NotifyIcon_Main.Icon = Nothing
            Debug.Close()
        Else
            Me.WindowState = FormWindowState.Minimized
            Me.Hide()
            Me.NotifyIcon_Main.BalloonTipText = "Closed to tray."
            Me.NotifyIcon_Main.ShowBalloonTip(1500)
            'Do Not Close
            e.Cancel = True
        End If
    End Sub
    'Category SelectedIndexChanged
    Private Sub ComboBox_Category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Category.SelectedIndexChanged
        'Clear GUI And Data
        Data.Clear_GUI_And_Data()
        Selected_Game = Nothing
        'Build Game List
        Data.Game_List()
        'Select first game in the list
        If Not ListView_Games.Items.Count = 0 Then
            If Auto_Selecting_Random_Category_And_Game = False And Searching_For_Game = False Then
                ListView_Games.Items(0).Selected = True
                ListView_Games.Items(0).EnsureVisible()
                ListView_Games.Select()
            End If
        End If
    End Sub
    'Youtube Button
    Private Sub Button_youtube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_youtube.Click
        If Not Selected_Index = -1 Then
            Try
                NotifyIcon_Main.BalloonTipText = "Searching for (" & Selected_Game.ToLower & ") on youtube."
                NotifyIcon_Main.ShowBalloonTip(1500)
                Dim Youtube_Search_String As String = System.Web.HttpUtility.UrlEncode(Selected_Game)
                Process.Start("https://www.youtube.com/results?search_type=videos&search_query=" & Youtube_Search_String)
                Youtube_Search_String = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Website Button
    Private Sub Button_Website_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Website.Click
        Try
            If Not Website = Nothing Then
                If Not Selected_Index = -1 Then
                    NotifyIcon_Main.BalloonTipText = "Opening " & Selected_Game.ToLower & " website."
                    NotifyIcon_Main.ShowBalloonTip(1500)
                    Process.Start(Website)
                End If
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Download Button
    Private Sub Button_Download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Download.Click
        If Not Selected_Index = -1 Then 'Check for a selected Game
            Dim str As String
            For Each str In Games_Downloading
                If Selected_Game = str Then
                    Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "This game is already downloading (" & Selected_Game & ")" & vbCrLf) 'DEBUG ACTION LOG -
                    MsgBox("This game is already downloading!", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Next
            If Settings.CheckBox_Download_Enabled.Checked = True Then 'If Enabled
                If Directory.Exists(Settings.TextBox_Download_Path.Text.ToString) Then 'If Download Directory Exists
                    Game_Download_Path = Settings.TextBox_Download_Path.Text.ToString 'Set String
                Else
                    If Settings.RadioButton_Download_Default.Checked = True Then
                        Directory.CreateDirectory(Environment.GetEnvironmentVariable("userprofile") & "\Downloads\")
                        Game_Download_Path = Settings.TextBox_Download_Path.Text.ToString 'Set String
                    Else
                        MsgBox("Download directory not found!" & vbCrLf & "Please select a download directory.", MsgBoxStyle.Information)
                        If Settings.FolderBrowserDialog_Download_Directory.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Open Folder Dialog
                            Game_Download_Path = Settings.FolderBrowserDialog_Download_Directory.SelectedPath & "\"
                            Settings.TextBox_Download_Path.Text = Game_Download_Path.ToString 'Set String
                        Else
                            Exit Sub
                        End If
                    End If
                End If
            Else
                If Settings.FolderBrowserDialog_Download_Directory.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Open Folder Dialog
                    Game_Download_Path = Settings.FolderBrowserDialog_Download_Directory.SelectedPath & "\"
                Else
                    Exit Sub
                End If
            End If
            'Clear FolderBrowserDialog Directory
            Settings.FolderBrowserDialog_Download_Directory.SelectedPath = Nothing
            'Clear TotalFileSize
            TotalFileSize = Nothing
            Dim t As New Thread(AddressOf Requesting_Thread)
            t.Priority = ThreadPriority.Normal
            t.Start()
            t.Join()
            If TotalFileSize > 1 Then
                Dim New_Downloading_Window As New Downloading
                New_Downloading_Window.Use_Theme_Color()
                New_Downloading_Window.Download = Download
                New_Downloading_Window.Game_Download = Game_Download
                New_Downloading_Window.Game_Download_Path = Game_Download_Path
                'Download Info
                New_Downloading_Window.Label_Title.Text = Nothing
                New_Downloading_Window.TotalFileSize = TotalFileSize
                New_Downloading_Window.Website = Website
                New_Downloading_Window.Game_Name = Selected_Game
                New_Downloading_Window.Label_Name.Text = Selected_Game
                New_Downloading_Window.Label_Version.Text = TextBox_Version.Text
                New_Downloading_Window.Label_File_Name.Text = Game_Download
                New_Downloading_Window.Label_Total_Size.Text = SetBytes(TotalFileSize)
                New_Downloading_Window.TextBox_Singleplayer.Text = TextBox_Singleplayer.Text
                New_Downloading_Window.TextBox_MultiPlayer.Text = TextBox_MultiPlayer.Text
                New_Downloading_Window.TextBox_PlayOnline.Text = TextBox_PlayOnline.Text
                New_Downloading_Window.TextBox_RequiresAccount.Text = TextBox_RequiresAccount.Text
                New_Downloading_Window.ToolTip_Downloading.SetToolTip(New_Downloading_Window.PictureBox_Website, Selected_Game & " website")
                New_Downloading_Window.PictureBox_AppIcon.Image = Game_Icon
                New_Downloading_Window.PictureBox_Game_Image.ImageLocation = PictureBox_Game_Image.ImageLocation
                Try
                    'Create a Bitmap object from an image file.
                    Dim myBitmap As New Bitmap(Game_Icon)
                    'Get an Hicon for myBitmap. 
                    Dim HIcon As IntPtr = myBitmap.GetHicon()
                    'Create a new icon from the handle. 
                    Dim newIcon As Icon = System.Drawing.Icon.FromHandle(HIcon)
                    'Set the form Icon attribute to the new icon. 
                    New_Downloading_Window.NotifyIcon_Downloading.Icon = newIcon
                    'Destroy the icon, since the form creates its own copy of the icon.
                    myBitmap.Dispose()
                    newIcon.Dispose()
                Catch ex As Exception
                End Try

                If Download.Contains("sourceforge.net") Then 'SourceForge
                    New_Downloading_Window.Label_Hosted_By.Text = "SourceForge.net"
                    New_Downloading_Window.Hosted_By_Label.Visible = True
                    New_Downloading_Window.Label_Hosted_By.Visible = True
                    New_Downloading_Window.PictureBox_Host_Logo.Image = My.Resources.Sourceforge
                    New_Downloading_Window.PictureBox_Host_Logo.Visible = True
                    New_Downloading_Window.ToolTip_Downloading.SetToolTip(New_Downloading_Window.PictureBox_Host_Logo, "SourceForge.net")
                End If
                Games_Downloading.Add(Selected_Game)
                New_Downloading_Window.Show()
                'Clear TotalFileSize
                TotalFileSize = Nothing
                'Update Variables on debug window
                Debug.Variables()
            End If
        End If
    End Sub
    'Close
    Private Sub PictureBox_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Close.Click
        If Games_Downloading.Count < 1 Then
            Close()
        Else
            Me.WindowState = FormWindowState.Minimized
            Me.Hide()
            Me.NotifyIcon_Main.BalloonTipText = "Closed to tray."
            Me.NotifyIcon_Main.ShowBalloonTip(1500)
        End If
    End Sub
    'Exit | ContextMenuItem
    Private Sub ContextMenuItem_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuItem_Exit.Click
        If Games_Downloading.Count < 1 Then
            Close()
        Else
            If Me.Visible Then
                Me.WindowState = FormWindowState.Minimized
                Me.Hide()
                Me.NotifyIcon_Main.BalloonTipText = "Closed to tray."
                Me.NotifyIcon_Main.ShowBalloonTip(1500)
            End If
        End If
    End Sub
    'Settings | ContextMenuItem
    Private Sub ContextMenuItem_Settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuItem_Settings.Click
        If Settings.Visible = False Then
            Settings.ShowDialog()
        Else
            Settings.Close()
        End If
    End Sub
    'Check For Updates | ContextMenuItem
    Private Sub ContextMenuItem_CheckForUpdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuItem_CheckForUpdates.Click
        Data.Check_For_Updates()
    End Sub
    'About | ContextMenuItem
    Private Sub ContextMenuItem_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuItem_About.Click
        If About.Visible = False Then
            About.ShowDialog()
        Else
            About.Close()
        End If
    End Sub
    'Trayicon Show / Hide Main Window
    Private Sub NotifyIcon_Main_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon_Main.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Data.Show_Hide_Main_Window()
        End If
    End Sub
    'Settings | ToolStripMenuItem
    Private Sub ToolStripMenuItem_Settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        If Settings.Visible = False Then
            Settings.ShowDialog()
        Else
            Settings.Close()
        End If
    End Sub
    'Check For Updates | ToolStripMenuItem
    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Data.Check_For_Updates()
    End Sub
    'About | ToolStripMenuItem
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        If About.Visible = False Then
            About.ShowDialog()
        Else
            About.Close()
        End If
    End Sub
    'Search For Game
    Private Sub TextBox_Search_For_Game_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox_Search_For_Game.KeyDown
        If e.KeyData = Keys.Enter Then
            If TextBox_Search_For_Game.Text.Length > 0 Then
                Data.Search_For_Game()
                TextBox_Search_For_Game.Clear()
            End If
        End If
    End Sub
    'Reconnect | ToolStripMenuItem
    Private Sub ToolStripMenuItem_Reconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconnectToolStripMenuItem.Click
        Data.Reconnect()
    End Sub
    'Move Window - Panel
    Private Sub Panel_Main_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Main.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Panel_Main.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub
    'Move Window - Label Title
    Private Sub Label_Title_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label_Title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Label_Title.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub
    'Minimize
    Private Sub PictureBox_Minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'AppIcon_Click - Show/Hide Main Window
    Private Sub PictureBox_AppIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_AppIcon.Click
        Data.Show_Hide_Main_Window()
    End Sub
    'Open Download Directory
    Private Sub ToolStripMenuItem_Downloads_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadsToolStripMenuItem.Click
        Try
            If Directory.Exists(Settings.TextBox_Download_Path.Text.ToString) Then
                Process.Start(Settings.TextBox_Download_Path.Text.ToString)
                Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Opened Download Directory (" & Settings.TextBox_Download_Path.Text.ToString & ")" & vbCrLf) 'DEBUG ACTION LOG - 
            Else
                Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Download Directory Not Found Default Download Directory Loaded (" & Settings.TextBox_Download_Path.Text.ToString & ")" & vbCrLf) 'DEBUG ACTION LOG - 
                MsgBox("Download directory not found!" & vbCrLf & "Default download directory will be selected and loaded.", MsgBoxStyle.Information)
                Settings.RadioButton_Download_Default.Checked = True
                Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Checking For Downloads Folder" & vbCrLf) 'DEBUG ACTION LOG - 
                If Not Directory.Exists(Environment.GetEnvironmentVariable("userprofile") & "\Downloads\") Then
                    Directory.CreateDirectory(Environment.GetEnvironmentVariable("userprofile") & "\Downloads\")
                    Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Downloads Folder Created" & vbCrLf) 'DEBUG ACTION LOG -
                Else
                    Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Downloads Folder Found" & vbCrLf) 'DEBUG ACTION LOG -
                End If
                Process.Start(Settings.TextBox_Download_Path.Text.ToString)
                Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Opened Download Directory (" & Settings.TextBox_Download_Path.Text.ToString & ")" & vbCrLf) 'DEBUG ACTION LOG - 
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Open Download Directory
    Private Sub ContextMenuItem_Downloads_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuItem_Downloads.Click
        Try
            If Directory.Exists(Settings.TextBox_Download_Path.Text.ToString) Then
                Process.Start(Settings.TextBox_Download_Path.Text.ToString)
                Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Opened Download Directory (" & Settings.TextBox_Download_Path.Text.ToString & ")" & vbCrLf) 'DEBUG ACTION LOG - 
            Else
                Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Download Directory Not Found Default Download Directory Loaded (" & Settings.TextBox_Download_Path.Text.ToString & ")" & vbCrLf) 'DEBUG ACTION LOG - 
                MsgBox("Download directory not found!" & vbCrLf & "Default download directory will be selected and loaded.", MsgBoxStyle.Information)
                Settings.RadioButton_Download_Default.Checked = True
                Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Checking For Downloads Folder" & vbCrLf) 'DEBUG ACTION LOG - 
                If Not Directory.Exists(Environment.GetEnvironmentVariable("userprofile") & "\Downloads\") Then
                    Directory.CreateDirectory(Environment.GetEnvironmentVariable("userprofile") & "\Downloads\")
                    Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Downloads Folder Created" & vbCrLf) 'DEBUG ACTION LOG -
                Else
                    Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Downloads Folder Found" & vbCrLf) 'DEBUG ACTION LOG -
                End If
                Process.Start(Settings.TextBox_Download_Path.Text.ToString)
                Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Opened Download Directory (" & Settings.TextBox_Download_Path.Text.ToString & ")" & vbCrLf) 'DEBUG ACTION LOG - 
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Main KeyDown
    Private Sub Main_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        'Ctrl+~ Show Debug window
        If e.Control And e.KeyCode = Keys.Oem3 Then
            If Not Debug.Visible Then
                Debug.Show()
            End If
        End If
        'Ctrl+Home Open Downloads
        If e.Control And e.KeyCode = Keys.Home Then
            DownloadsToolStripMenuItem.PerformClick()
        End If
        'Ctrl+D Download
        If e.Control And e.KeyCode = Keys.D Then
            Button_Download.PerformClick()
        End If
        'Ctrl+W Website
        If e.Control And e.KeyCode = Keys.W Then
            Button_Website.PerformClick()
        End If
        'Ctrl+Y Youtube
        If e.Control And e.KeyCode = Keys.Y Then
            Button_youtube.PerformClick()
        End If
        'Ctrl+R Reconnect
        If e.Control And e.KeyCode = Keys.R Then
            ReconnectToolStripMenuItem.PerformClick()
        End If
        'Ctrl+S Settings
        If e.Control And e.KeyCode = Keys.S Then
            SettingsToolStripMenuItem.PerformClick()
        End If
        'Ctrl+U Check for updates
        If e.Control And e.KeyCode = Keys.U Then
            CheckForUpdatesToolStripMenuItem.PerformClick()
        End If
        'Ctrl+A About
        If e.Control And e.KeyCode = Keys.A Then
            About.ShowDialog()
        End If
    End Sub
    'Minimize Blue
    Private Sub PictureBox_Minimize_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox_Minimize.MouseHover
        PictureBox_Minimize.Image = My.Resources.Minimize_Blue
    End Sub
    'Minimize Grey
    Private Sub PictureBox_Minimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox_Minimize.MouseLeave
        PictureBox_Minimize.Image = My.Resources.Minimize_Grey
    End Sub
    'Form Deactivate Close Grey
    Private Sub Main_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        PictureBox_Close.Image = My.Resources.Close_Grey
    End Sub
    'Form Activated Close Red
    Private Sub Main_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        PictureBox_Close.Image = My.Resources.Close_Red
    End Sub
    'Requesting Thread
    Private Sub Requesting_Thread()
        Try
            NotifyIcon_Requesting.Visible = True
            NotifyIcon_Requesting.BalloonTipText = "Requesting file from server."
            NotifyIcon_Requesting.ShowBalloonTip(1500)
            Request = WebRequest.Create(Download)
            'If required by the server, set the credentials
            Request.Credentials = CredentialCache.DefaultCredentials
            Request.Timeout = 8000
            Response = Request.GetResponse
            TotalFileSize = Response.ContentLength
            Response.Close()
            NotifyIcon_Requesting.Visible = False
        Catch Wx As System.Net.WebException
            NotifyIcon_Requesting.Visible = False
            NotifyIcon_Main.BalloonTipText = "Connection Failed: " & Wx.Message
            NotifyIcon_Main.ShowBalloonTip(1500)
        Catch Ex As Exception
            NotifyIcon_Requesting.Visible = False
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'ListView1 SelectedValueChanged
    Private Sub ListView1_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ListView_Games.ItemSelectionChanged
        If e.Item.Selected Then
            Selected_Index = e.ItemIndex
            Selected_Item = e.Item.Text
        End If
        If Not Selected_Index = -1 Then
            If Not Selected_Game = Selected_Item Then
                Game_Download = Nothing
                Selected_Game = Nothing
                Selected_Game = e.Item.Text
                Try
                    'Clear GUI And Data
                    Data.Clear_GUI_And_Data()
                    Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Action: Loading Game Data (" & Selected_Game & ")" & vbCrLf)  'DEBUG ACTION LOG -
                    'Set Images
                    PictureBox_Game_Image.ImageLocation = ("http://game-downloader.googlecode.com/svn/trunk/Data/Categories/" & ComboBox_Category.SelectedItem.ToString & "/" & Selected_Game & "/Image.jpg")
                    Dim G_Stream As Stream
                    G_Stream = CFG_WebClient.OpenRead("http://game-downloader.googlecode.com/svn/trunk/Data/Categories/" & ComboBox_Category.SelectedItem.ToString & "/" & Selected_Game & "/Icon.png")
                    Game_Icon = Image.FromStream(G_Stream)
                    'Store Stream
                    Dim Game_CFG_Stream As Stream = CFG_WebClient.OpenRead("http://game-downloader.googlecode.com/svn/trunk/Data/Categories/" & ComboBox_Category.SelectedItem.ToString & "/" & Selected_Game & "/Game.cfg")
                    'Read Stream
                    Dim Game_Reader As New StreamReader(Game_CFG_Stream)
                    Game_CFG = Game_Reader.ReadToEnd
                    Game_Reader.Close() 'Close StreamReader
                    Game_CFG_Stream.Close() 'Close Stream
                    CFG_WebClient.Dispose()
                    Dim CFG_Line() As String = Split(Game_CFG, vbCrLf.ToCharArray)
                    Game_CFG = Nothing
                    'Version //Line 0
                    If CFG_Line(0).StartsWith("Version:") Then
                        CFG_Line(0) = CFG_Line(0).Substring(8)
                        If Not CFG_Line(0) = Nothing Then
                            TextBox_Version.Text = CFG_Line(0).ToString
                        Else
                            CFG_Line = Nothing
                            Data.Bad_Game_CFG()
                            Exit Sub
                        End If
                    Else
                        CFG_Line = Nothing
                        Data.Bad_Game_CFG()
                        Exit Sub
                    End If
                    'FileSize //Line 1
                    If CFG_Line(1).StartsWith("FileSize:") Then
                        CFG_Line(1) = CFG_Line(1).Substring(CFG_Line(1).LastIndexOf(":") + 1)
                        If Not CFG_Line(1) = Nothing Then
                            TextBox_File_Size.Text = CFG_Line(1).ToString
                        Else
                            CFG_Line = Nothing
                            Data.Bad_Game_CFG()
                            Exit Sub
                        End If
                    Else
                        CFG_Line = Nothing
                        Data.Bad_Game_CFG()
                        Exit Sub
                    End If
                    'About //Line 2
                    If CFG_Line(2).StartsWith("About:") Then
                        CFG_Line(2) = CFG_Line(2).Substring(6)
                        If Not CFG_Line(2) = Nothing Then
                            TextBox_About.Text = CFG_Line(2).ToString
                        Else
                            CFG_Line = Nothing
                            Data.Bad_Game_CFG()
                            Exit Sub
                        End If
                    Else
                        CFG_Line = Nothing
                        Data.Bad_Game_CFG()
                        Exit Sub
                    End If
                    'SinglePlayer //Line 3
                    If CFG_Line(3).StartsWith("SinglePlayer:") Then
                        CFG_Line(3) = CFG_Line(3).Substring(CFG_Line(3).LastIndexOf(":") + 1)
                        If CFG_Line(3).StartsWith("True") Then
                            TextBox_Singleplayer.Text = "Yes"
                        ElseIf CFG_Line(3).StartsWith("False") Then
                            TextBox_Singleplayer.Text = "No"
                        Else
                            CFG_Line = Nothing
                            Data.Bad_Game_CFG()
                            Exit Sub
                        End If
                    Else
                        CFG_Line = Nothing
                        Data.Bad_Game_CFG()
                        Exit Sub
                    End If
                    'MultiPlayer //Line 4
                    If CFG_Line(4).StartsWith("MultiPlayer:") Then
                        CFG_Line(4) = CFG_Line(4).Substring(CFG_Line(4).LastIndexOf(":") + 1)
                        If CFG_Line(4).StartsWith("True") Then
                            TextBox_MultiPlayer.Text = "Yes"
                        ElseIf CFG_Line(4).StartsWith("False") Then
                            TextBox_MultiPlayer.Text = "No"
                        Else
                            CFG_Line = Nothing
                            Data.Bad_Game_CFG()
                            Exit Sub
                        End If
                    Else
                        CFG_Line = Nothing
                        Data.Bad_Game_CFG()
                        Exit Sub
                    End If
                    'PlayOnline //Line 5
                    If CFG_Line(5).StartsWith("PlayOnline:") Then
                        CFG_Line(5) = CFG_Line(5).Substring(CFG_Line(5).LastIndexOf(":") + 1)
                        If CFG_Line(5).StartsWith("True") Then
                            TextBox_PlayOnline.Text = "Yes"
                        ElseIf CFG_Line(5).StartsWith("False") Then
                            TextBox_PlayOnline.Text = "No"
                        Else
                            CFG_Line = Nothing
                            Data.Bad_Game_CFG()
                            Exit Sub
                        End If
                    Else
                        CFG_Line = Nothing
                        Data.Bad_Game_CFG()
                        Exit Sub
                    End If
                    'RequiresAccount //Line 6
                    If CFG_Line(6).StartsWith("RequiresAccount:") Then
                        CFG_Line(6) = CFG_Line(6).Substring(CFG_Line(6).LastIndexOf(":") + 1)
                        If CFG_Line(6).StartsWith("True") Then
                            TextBox_RequiresAccount.Text = "Yes"
                        ElseIf CFG_Line(6).StartsWith("False") Then
                            TextBox_RequiresAccount.Text = "No"
                        Else
                            CFG_Line = Nothing
                            Data.Bad_Game_CFG()
                            Exit Sub
                        End If
                    Else
                        CFG_Line = Nothing
                        Data.Bad_Game_CFG()
                        Exit Sub
                    End If
                    'Website //Line 7
                    If CFG_Line(7).StartsWith("Website:") Then
                        CFG_Line(7) = CFG_Line(7).Substring(8)
                        If CFG_Line(7).StartsWith("http://") Or CFG_Line(7).StartsWith("https://") Then
                            Website = CFG_Line(7).ToString
                        Else
                            CFG_Line = Nothing
                            Data.Bad_Game_CFG()
                            Exit Sub
                        End If
                    Else
                        CFG_Line = Nothing
                        Data.Bad_Game_CFG()
                        Exit Sub
                    End If
                    'Download //Line 8
                    If CFG_Line(8).StartsWith("Download:") Then
                        CFG_Line(8) = CFG_Line(8).Substring(9)
                        If CFG_Line(8).StartsWith("http://") Or CFG_Line(8).StartsWith("https://") Then
                            Download = CFG_Line(8).ToString
                        Else
                            CFG_Line = Nothing
                            Data.Bad_Game_CFG()
                            Exit Sub
                        End If
                    Else
                        CFG_Line = Nothing
                        Data.Bad_Game_CFG()
                        Exit Sub
                    End If
                    'Clear array
                    CFG_Line = Nothing
                    Game_Download = System.Web.HttpUtility.UrlDecode(Path.GetFileName(Download))
                    'Set ToolTips
                    ToolTip_Main.SetToolTip(Button_youtube, "Search for " & Selected_Game & " on youtube.")
                    ToolTip_Main.SetToolTip(Button_Website, Selected_Game & " website.")
                    ToolTip_Main.SetToolTip(Button_Download, "Download " & Selected_Game & ".")
                    Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Game Data Loaded (" & Selected_Game & ")" & vbCrLf)  'DEBUG ACTION LOG -
                Catch Wx As System.Net.WebException
                    NotifyIcon_Main.BalloonTipText = "Connection Failed: " & Wx.Message
                    NotifyIcon_Main.ShowBalloonTip(1500)
                    Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Error: Connection Failed (" & Wx.Message & ")" & vbCrLf) 'DEBUG ACTION LOG -
                    'Update Variables on debug window
                    Debug.Variables()
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                    Data.Bad_Game_CFG()
                End Try
            End If
        End If
    End Sub
End Class