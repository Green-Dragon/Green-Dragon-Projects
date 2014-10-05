
Public Class Downloading
    Public WithEvents Downloader As New WebClient
    Public Game_Download As String
    Public speed As Double
    Public TotalFileSize As Long
    Public Sw As New Stopwatch
    Public Game_Download_Path As String
    Public Website As String
    Public Download As String
    Public Game_Name As String
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
    Private Sub Downloading_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Label_Title.Text = "Queued (Awaiting Processing)"
            Downloader.Proxy = Nothing
            Downloader.DownloadFileAsync(New Uri(Download), Game_Download_Path & Game_Download)
            Sw.Start()
            Timer_Speed.Enabled = True
            NotifyIcon_Downloading.Visible = True
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Downloading (" & Game_Name & ")" & vbCrLf) 'DEBUG ACTION LOG -
            Me.BringToFront()
            Me.Activate()
        Catch Wx As System.Net.WebException
            Main.NotifyIcon_Requesting.Visible = False
            Main.NotifyIcon_Main.BalloonTipText = Wx.Message
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & ">Error: " & Wx.Message & vbCrLf) 'DEBUG ACTION LOG -
            'Update Variables on debug window
            Debug.Variables()
        Catch Ex As Exception
            Main.NotifyIcon_Requesting.Visible = False
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Close Window
    Private Sub PictureBox_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Close.Click
        Cancel_Download()
    End Sub
    'Cancel Download
    Private Sub PictureBox_Cancel_Download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Cancel_Download.Click
        Cancel_Download()
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
    'Website
    Private Sub PictureBox_Website_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Website.Click
        Try
            If Not Website = Nothing Then
                NotifyIcon_Downloading.BalloonTipText = "Opening " & Label_Name.Text.ToLower & " website."
                NotifyIcon_Downloading.ShowBalloonTip(1500)
                Process.Start(Website)
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Open Download Directory
    Private Sub PictureBox_Open_Download_Directory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Open_Download_Directory.Click
        Try
            Process.Start(Game_Download_Path)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Always On Top
    Private Sub PictureBox_Always_On_Top_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Always_On_Top.Click
        If Me.TopMost = False Then
            PictureBox_Always_On_Top.Image = My.Resources.Always_On_Top_On
            Me.TopMost = True
        Else
            PictureBox_Always_On_Top.Image = My.Resources.Always_On_Top_Off
            Me.TopMost = False
        End If
    End Sub
    'Compact
    Private Sub PictureBox_Compact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Compact.Click
        If Me.Height = 223 = False Then
            PictureBox_Game_Image.Visible = False
            Me.Height = 223
            PictureBox_Compact.Image = My.Resources.Compact_Off
        Else
            Me.Height = 458
            PictureBox_Game_Image.Visible = True
            PictureBox_Compact.Image = My.Resources.Compact_On
        End If
    End Sub
    'AppIcon_Click - Show Hide Downloading Window
    Private Sub PictureBox_AppIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_AppIcon.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
            Me.Hide()
        Else
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            Me.BringToFront()
            Me.Activate()
        End If
    End Sub
    'File Completed
    Private Sub Downloader_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles Downloader.DownloadFileCompleted
        If e.Cancelled = False Then
            Downloader.Dispose()
            Timer_Speed.Enabled = False
            Sw.Reset()
            'Play Completed Sound
            Data.Play_Completed_Sound()
            NotifyIcon_Downloading.Visible = False
            'Download Complete Message
            Main.NotifyIcon_Main.BalloonTipText = "Completed Download: " & Game_Name
            Main.NotifyIcon_Main.ShowBalloonTip(1500)
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Completed Download (" & Game_Name & ")" & vbCrLf) 'DEBUG ACTION LOG -
            If Settings.RadioButton_Open_Download_File.Checked = True Then
                If File.Exists(Game_Download_Path & Game_Download) Then
                    Process.Start(Game_Download_Path & Game_Download)
                End If
            ElseIf Settings.RadioButton_Open_Download_Folder.Checked = True Then
                If Directory.Exists(Game_Download_Path) Then
                    Process.Start(Game_Download_Path)
                End If
            End If
            Main.Games_Downloading.Remove(Game_Name)
            'Update Variables on debug window
            Debug.Variables()
            Me.Close()
        Else
            'Delete Unfinished Download File
            File.Delete(Game_Download_Path & Game_Download)
            Main.Games_Downloading.Remove(Game_Name)
            'Update Variables on debug window
            Debug.Variables()
            Me.Close()
        End If
        'Clear Values
        Game_Download = Nothing
        Game_Download_Path = Nothing
    End Sub
    'File Downloading
    Private Sub Downloader_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles Downloader.DownloadProgressChanged
        ProgressBar_Downloading.Value = e.ProgressPercentage
        If TaskbarManager.IsPlatformSupported Then
            TaskbarManager.Instance.SetProgressValue(e.ProgressPercentage, 100, Handle)
        End If
        Label_Title.Text = e.ProgressPercentage.ToString & " % of " & Game_Name
        Me.Text = e.ProgressPercentage.ToString & " % of " & Game_Name
        NotifyIcon_Downloading.Text = e.ProgressPercentage.ToString & " % of " & Game_Name
        Label_Size_Completed.Text = Main.SetBytes(e.BytesReceived)
        Label_Size_Remaining.Text = Main.SetBytes(e.TotalBytesToReceive - e.BytesReceived)
    End Sub
    'Calc DLS
    Private Sub Timer_Speed_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Speed.Tick
        Dim DLFile As New FileInfo(Game_Download_Path & Game_Download)
        speed = DLFile.Length / Sw.Elapsed.TotalSeconds
        If Not Double.IsInfinity(speed) And Sw.Elapsed.TotalSeconds > 0.0 And speed > 0.0 Then
            Label_Speed.Text = SetBytes(speed) & "/sec"
            If (TotalFileSize - DLFile.Length) / speed > 5.0 Then
                Label_Time_Remaining.Text = Format(DateAdd("s", (TotalFileSize - DLFile.Length) / speed, "00:00:00"), "HH:mm:ss")
            Else
                Label_Time_Remaining.Text = "a few seconds"
            End If
        End If
    End Sub
    'Trayicon Show / Hide Downloading Window
    Private Sub NotifyIcon_Downloading_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon_Downloading.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Minimized
                Me.Hide()
            Else
                Me.Show()
                Me.WindowState = FormWindowState.Normal
                Me.BringToFront()
                Me.Activate()
            End If
        End If
    End Sub
    'PictureBox Minimize MouseHover
    Private Sub PictureBox_Minimize_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox_Minimize.MouseHover
        PictureBox_Minimize.Image = My.Resources.Minimize_Blue
    End Sub
    'PictureBox Minimize MouseLeave
    Private Sub PictureBox_Minimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox_Minimize.MouseLeave
        PictureBox_Minimize.Image = My.Resources.Minimize_Grey
    End Sub
    'Form Activated Close Red
    Private Sub Downloading_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        PictureBox_Close.Image = My.Resources.Close_Red
    End Sub
    'Form Deactivate Close Grey
    Private Sub Downloading_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        PictureBox_Close.Image = My.Resources.Close_Grey
    End Sub
    'Use Theme Color
    Public Sub Use_Theme_Color()
        'Downloading
        Name_Label.ForeColor = Main.Theme_Color
        Version_Label.ForeColor = Main.Theme_Color
        File_Name_Label.ForeColor = Main.Theme_Color
        Total_Size_Label.ForeColor = Main.Theme_Color
        Speed_Label.ForeColor = Main.Theme_Color
        Time_Remaining_Label.ForeColor = Main.Theme_Color
        Size_Completed_Label.ForeColor = Main.Theme_Color
        Size_Remaining_Label.ForeColor = Main.Theme_Color
        ProgressBar_Downloading.ForeColor = Main.Theme_Color
        Hosted_By_Label.ForeColor = Main.Theme_Color
    End Sub
    'Visit Host
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Host_Logo.Click
        Try
            If Label_Hosted_By.Text = "SourceForge.net" Then
                Process.Start("http://sourceforge.net/")
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Cancel Download
    Private Sub Cancel_Download()
        Try
            If Downloader.IsBusy = True Then
                If MessageBox.Show("A game is currently downloading." & vbNewLine & "Do you want to cancel the download?", "Green Dragon Game Downloader", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If Downloader.IsBusy = True Then
                        Main.NotifyIcon_Main.BalloonTipText = "Canceled Download: " & Game_Name
                        Main.NotifyIcon_Main.ShowBalloonTip(1500)
                        Timer_Speed.Enabled = False
                        Sw.Reset()
                        Downloader.CancelAsync()
                        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Canceled Download (" & Game_Name & ")" & vbCrLf) 'DEBUG ACTION LOG -
                    End If
                End If
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class