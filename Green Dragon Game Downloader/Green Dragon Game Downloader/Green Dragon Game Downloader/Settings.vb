
Public Class Settings
    'On Download Complete
    Dim Do_Nothing_CheckedChanged As Boolean
    Dim Open_Download_File_CheckedChanged As Boolean
    Dim Open_Download_Folder_CheckedChanged As Boolean
    'Theme Color
    Dim Theme_Color_Default_CheckedChanged As Boolean
    Dim Theme_Color_User_CheckedChanged As Boolean
    'Download Directory
    Dim Download_Enabled_CheckedChanged As Boolean
    Dim Download_Path_TextChanged As String
    Dim Download_Default_CheckedChanged As Boolean
    Dim Download_User_CheckedChanged As Boolean
    'Startup Sound
    Dim Startup_Sound_Enabled_CheckedChanged As Boolean
    Dim Startup_Sound_Path_TextChanged As String
    Dim Startup_Sound_Default_CheckedChanged As Boolean
    Dim Startup_Sound_User_CheckedChanged As Boolean
    'Download Complete Sound
    Dim Download_Complete_Sound_Enabled_CheckedChanged As Boolean
    Dim Download_Complete_Sound_Path_TextChanged As String
    Dim Download_Complete_Sound_Default_CheckedChanged As Boolean
    Dim Download_Complete_Sound_User_CheckedChanged As Boolean
    'On FormLoad
    Private Sub Settings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Settings Opened" & vbCrLf) 'DEBUG ACTION LOG - 
        'On Download Complete
        Do_Nothing_CheckedChanged = RadioButton_Do_Nothing.Checked
        Open_Download_File_CheckedChanged = RadioButton_Open_Download_File.Checked
        Open_Download_Folder_CheckedChanged = RadioButton_Open_Download_Folder.Checked
        'Theme Color
        Theme_Color_Default_CheckedChanged = RadioButton_Theme_Color_Default.Checked
        Theme_Color_User_CheckedChanged = RadioButton_Theme_Color_User.Checked
        'Download Directory
        Download_Enabled_CheckedChanged = CheckBox_Download_Enabled.Checked
        Download_Path_TextChanged = TextBox_Download_Path.Text
        Download_Default_CheckedChanged = RadioButton_Download_Default.Checked
        Download_User_CheckedChanged = RadioButton_Download_User.Checked
        'Startup Sound
        Startup_Sound_Enabled_CheckedChanged = CheckBox_Startup_Sound_Enabled.Checked
        Startup_Sound_Path_TextChanged = TextBox_Startup_Sound_Path.Text
        Startup_Sound_Default_CheckedChanged = RadioButton_Startup_Sound_Default.Checked
        Startup_Sound_User_CheckedChanged = RadioButton_Startup_Sound_User.Checked
        'Download Complete Sound
        Download_Complete_Sound_Enabled_CheckedChanged = CheckBox_Download_Complete_Sound_Enabled.Checked
        Download_Complete_Sound_Path_TextChanged = TextBox_Download_Complete_Sound_Path.Text
        Download_Complete_Sound_Default_CheckedChanged = RadioButton_Download_Complete_Sound_Default.Checked
        Download_Complete_Sound_User_CheckedChanged = RadioButton_Download_Complete_Sound_User.Checked
    End Sub
    'RadioButton Download Default
    Private Sub RadioButton_Download_Default_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Download_Default.CheckedChanged
        If RadioButton_Download_Default.Checked = True Then
            TextBox_Download_Path.Text = Environment.GetEnvironmentVariable("userprofile") & "\Downloads\"
            Main.Game_Download_Path = TextBox_Download_Path.Text
        End If
    End Sub
    'RadioButton Download User - Click
    Private Sub RadioButton_Download_User_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Download_User.Click
        If RadioButton_Download_User.Checked Then
            If Not TextBox_Download_Path.Text = Nothing Then
                If FolderBrowserDialog_Download_Directory.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Open Folder Dialog
                    If Not FolderBrowserDialog_Download_Directory.SelectedPath.EndsWith("\") Then
                        TextBox_Download_Path.Text = FolderBrowserDialog_Download_Directory.SelectedPath & "\"
                    Else
                        TextBox_Download_Path.Text = FolderBrowserDialog_Download_Directory.SelectedPath
                    End If
                    FolderBrowserDialog_Download_Directory.SelectedPath = Nothing 'Clear Open Folder Dialog SelectedPath
                Else
                    RadioButton_Download_Default.Checked = True 'User Canceled
                End If
            End If
        End If
    End Sub
    'RadioButton Startup Sound Default
    Private Sub RadioButton_Startup_Sound_Default_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Startup_Sound_Default.CheckedChanged
        If RadioButton_Startup_Sound_Default.Checked Then
            TextBox_Startup_Sound_Path.Text = Nothing
        End If
    End Sub
    'RadioButton Startup Sound User - Click
    Private Sub RadioButton_Startup_Sound_User_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Startup_Sound_User.Click
        If RadioButton_Startup_Sound_User.Checked Then
            If OpenFileDialog_Get_Wave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CheckBox_Startup_Sound_Enabled.Checked = True 'Enabled Startup Sound
                TextBox_Startup_Sound_Path.Text = OpenFileDialog_Get_Wave.FileName 'Show Text in textbox
                OpenFileDialog_Get_Wave.FileName = Nothing 'Clear Open File Dialog
            Else
                RadioButton_Startup_Sound_Default.Checked = True  'User Canceled
            End If
        End If
    End Sub
    'RadioButton Completed Sound Default
    Private Sub RadioButton_Download_Complete_Sound_Default_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Download_Complete_Sound_Default.CheckedChanged
        If RadioButton_Download_Complete_Sound_Default.Checked = True Then
            TextBox_Download_Complete_Sound_Path.Text = Nothing
        End If
    End Sub
    'RadioButton Completed Sound User - Click
    Private Sub RadioButton_Download_Complete_Sound_User_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Download_Complete_Sound_User.Click
        If RadioButton_Download_Complete_Sound_User.Checked Then
            If OpenFileDialog_Get_Wave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CheckBox_Download_Complete_Sound_Enabled.Checked = True 'Enabled Completed Sound
                TextBox_Download_Complete_Sound_Path.Text = OpenFileDialog_Get_Wave.FileName 'Show Text in textbox
                OpenFileDialog_Get_Wave.FileName = Nothing 'Clear Open File Dialog
            Else
                RadioButton_Download_Complete_Sound_Default.Checked = True 'User Canceled
            End If
        End If
    End Sub
    'CheckBox Download Enabled CheckedChanged
    Private Sub CheckBox_Download_Enabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_Download_Enabled.CheckedChanged
        If CheckBox_Download_Enabled.Checked Then
            TextBox_Download_Path.Enabled = True
            RadioButton_Download_User.Enabled = True
            RadioButton_Download_Default.Enabled = True
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Download Directory (Enabled)" & vbCrLf) 'DEBUG ACTION LOG - 
        Else
            TextBox_Download_Path.Enabled = False
            RadioButton_Download_User.Enabled = False
            RadioButton_Download_Default.Enabled = False
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Download Directory (Disabled)" & vbCrLf) 'DEBUG ACTION LOG - 
        End If
    End Sub
    'CheckBox Startup Sound Enabled CheckedChanged
    Private Sub CheckBox_Startup_Sound_Enabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_Startup_Sound_Enabled.CheckedChanged
        If CheckBox_Startup_Sound_Enabled.Checked Then
            TextBox_Startup_Sound_Path.Enabled = True
            RadioButton_Startup_Sound_User.Enabled = True
            RadioButton_Startup_Sound_Default.Enabled = True
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Startup Sound (Enabled)" & vbCrLf) 'DEBUG ACTION LOG - 
        Else
            TextBox_Startup_Sound_Path.Enabled = False
            RadioButton_Startup_Sound_User.Enabled = False
            RadioButton_Startup_Sound_Default.Enabled = False
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Startup Sound (Disabled)" & vbCrLf) 'DEBUG ACTION LOG - 
        End If
    End Sub
    'CheckBox Completed Sound Enabled CheckedChanged
    Private Sub CheckBox_Download_Complete_Sound_Enabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_Download_Complete_Sound_Enabled.CheckedChanged
        If CheckBox_Download_Complete_Sound_Enabled.Checked Then
            TextBox_Download_Complete_Sound_Path.Enabled = True
            RadioButton_Download_Complete_Sound_User.Enabled = True
            RadioButton_Download_Complete_Sound_Default.Enabled = True
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Download Complete Sound (Enabled)" & vbCrLf) 'DEBUG ACTION LOG - 
        Else
            TextBox_Download_Complete_Sound_Path.Enabled = False
            RadioButton_Download_Complete_Sound_User.Enabled = False
            RadioButton_Download_Complete_Sound_Default.Enabled = False
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Download Complete Sound (Disabled)" & vbCrLf) 'DEBUG ACTION LOG - 
        End If
    End Sub
    'RadioButton Theme Color User - Click
    Private Sub RadioButton_Theme_Color_User_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Theme_Color_User.Click
        If RadioButton_Theme_Color_User.Checked = True Then
            If ColorDialog_Theme.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If ColorDialog_Theme.Color = Color.Black Then
                    MsgBox("Black is used by Background, Please use another color.", MsgBoxStyle.Information)
                    RadioButton_Theme_Color_Default.Checked = True
                ElseIf ColorDialog_Theme.Color = Color.White Then
                    MsgBox("White is used by Font, Please use another color.", MsgBoxStyle.Information)
                    RadioButton_Theme_Color_Default.Checked = True
                ElseIf ColorDialog_Theme.Color = Color.FromArgb(0, 74, 127) Then
                    MsgBox("This color is used by Default Color, Please use another color.", MsgBoxStyle.Information)
                    RadioButton_Theme_Color_Default.Checked = True
                Else
                    Main.Theme_Color = ColorDialog_Theme.Color
                    Data.Set_Theme_Color()
                End If
            Else
                RadioButton_Theme_Color_Default.Checked = True
            End If
        End If
    End Sub
    'RadioButton Theme Color Default
    Private Sub RadioButton_Theme_Color_Default_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Theme_Color_Default.CheckedChanged
        If RadioButton_Theme_Color_Default.Checked = True Then
            If Not Main.Theme_Color = Color.FromArgb(0, 74, 127) Then
                Main.Theme_Color = Color.FromArgb(0, 74, 127)
                ColorDialog_Theme.Color = Main.Theme_Color
                Data.Set_Theme_Color()
            End If
        End If
    End Sub
    'Close Window
    Private Sub PictureBox_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Close.Click
        Close()
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
    'Move Window - Label_Title
    Private Sub Label_Title_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label_Title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Label_Title.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub
    'On FormClosed
    Private Sub Settings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Settings Closed" & vbCrLf) 'DEBUG ACTION LOG - 
    End Sub
    'Save Settings on Closing
    Private Sub Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'On Download Complete
        If Not Do_Nothing_CheckedChanged = RadioButton_Do_Nothing.Checked Or _
             Not Open_Download_File_CheckedChanged = RadioButton_Open_Download_File.Checked Or _
             Not Open_Download_Folder_CheckedChanged = RadioButton_Open_Download_Folder.Checked Or _
             Not Theme_Color_Default_CheckedChanged = RadioButton_Theme_Color_Default.Checked Or _
             Not Theme_Color_User_CheckedChanged = RadioButton_Theme_Color_User.Checked Or _
             Not Download_Enabled_CheckedChanged = CheckBox_Download_Enabled.Checked Or _
             Not Download_Path_TextChanged = TextBox_Download_Path.Text Or _
             Not Download_Default_CheckedChanged = RadioButton_Download_Default.Checked Or _
             Not Download_User_CheckedChanged = RadioButton_Download_User.Checked Or _
             Not Startup_Sound_Enabled_CheckedChanged = CheckBox_Startup_Sound_Enabled.Checked Or _
             Not Startup_Sound_Path_TextChanged = TextBox_Startup_Sound_Path.Text Or _
             Not Startup_Sound_Default_CheckedChanged = RadioButton_Startup_Sound_Default.Checked Or _
             Not Startup_Sound_User_CheckedChanged = RadioButton_Startup_Sound_User.Checked Or _
             Not Download_Complete_Sound_Enabled_CheckedChanged = CheckBox_Download_Complete_Sound_Enabled.Checked Or _
             Not Download_Complete_Sound_Path_TextChanged = TextBox_Download_Complete_Sound_Path.Text Or _
             Not Download_Complete_Sound_Default_CheckedChanged = RadioButton_Download_Complete_Sound_Default.Checked Or _
             Not Download_Complete_Sound_User_CheckedChanged = RadioButton_Download_Complete_Sound_User.Checked Then
            'Save Settings.cfg
            Data.Save_Settings()
        End If
        'On Download Complete
        Do_Nothing_CheckedChanged = Nothing
        Open_Download_File_CheckedChanged = Nothing
        Open_Download_Folder_CheckedChanged = Nothing
        'Theme Color
        Theme_Color_Default_CheckedChanged = Nothing
        Theme_Color_User_CheckedChanged = Nothing
        'Download Directory
        Download_Enabled_CheckedChanged = Nothing
        Download_Path_TextChanged = Nothing
        Download_Default_CheckedChanged = Nothing
        Download_User_CheckedChanged = Nothing
        'Startup Sound
        Startup_Sound_Enabled_CheckedChanged = Nothing
        Startup_Sound_Path_TextChanged = Nothing
        Startup_Sound_Default_CheckedChanged = Nothing
        Startup_Sound_User_CheckedChanged = Nothing
        'Download Complete Sound
        Download_Complete_Sound_Enabled_CheckedChanged = Nothing
        Download_Complete_Sound_Path_TextChanged = Nothing
        Download_Complete_Sound_Default_CheckedChanged = Nothing
        Download_Complete_Sound_User_CheckedChanged = Nothing
    End Sub
    'Form Activated Close Red
    Private Sub Settings_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        PictureBox_Close.Image = My.Resources.Close_Red
    End Sub
    'Form Deactivate Close Grey
    Private Sub Settings_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        PictureBox_Close.Image = My.Resources.Close_Grey
    End Sub
    'RadioButton Do Nothing CheckedChanged
    Private Sub RadioButton_Do_Nothing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Do_Nothing.CheckedChanged
        If RadioButton_Do_Nothing.Checked = True Then
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: On Download Complete (Do Nothing)" & vbCrLf) 'DEBUG ACTION LOG - 
        End If
    End Sub
    'RadioButton Open Download File CheckedChanged
    Private Sub RadioButton_Open_Download_File_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Open_Download_File.CheckedChanged
        If RadioButton_Open_Download_File.Checked = True Then
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: On Download Complete (Open Download File)" & vbCrLf) 'DEBUG ACTION LOG - 
        End If
    End Sub
    'RadioButton Open Download Folder CheckedChanged
    Private Sub RadioButton_Open_Download_Folder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Open_Download_Folder.CheckedChanged
        If RadioButton_Open_Download_Folder.Checked = True Then
            Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: On Download Complete (Open Download Folder)" & vbCrLf) 'DEBUG ACTION LOG - 
        End If
    End Sub
    'Download Path Changed
    Private Sub TextBox_Download_Path_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Download_Path.TextChanged
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Download Path Changed (" & TextBox_Download_Path.Text & ")" & vbCrLf) 'DEBUG ACTION LOG - 
    End Sub
    'Startup Sound Path Changed
    Private Sub TextBox_Startup_Sound_Path_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Startup_Sound_Path.TextChanged
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Startup Sound Path Changed (" & TextBox_Startup_Sound_Path.Text & ")" & vbCrLf) 'DEBUG ACTION LOG -
    End Sub
    'Download Complete Sound Path Changed
    Private Sub TextBox_Download_Complete_Sound_Path_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Download_Complete_Sound_Path.TextChanged
        Debug.TextBox_Action_Log.AppendText("<" & Now.ToString("hh:mm:ss.fff tt") & "> " & "Information: Download Complete Sound Path Changed (" & TextBox_Download_Complete_Sound_Path.Text & ")" & vbCrLf) 'DEBUG ACTION LOG -
    End Sub
    'RadioButton_Theme_Color_User
    Private Sub RadioButton_Theme_Color_User_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Theme_Color_User.CheckedChanged
        If RadioButton_Theme_Color_User.Checked Then
            RadioButton_Theme_Color_User.FlatAppearance.BorderColor = Main.Theme_Color
            RadioButton_Theme_Color_User.FlatAppearance.BorderSize = 2
        Else
            RadioButton_Theme_Color_User.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40)
            RadioButton_Theme_Color_User.FlatAppearance.BorderSize = 1
        End If
    End Sub
    'RadioButton_Download_User
    Private Sub RadioButton_Download_User_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Download_User.CheckedChanged
        If RadioButton_Download_User.Checked Then
            RadioButton_Download_User.FlatAppearance.BorderColor = Main.Theme_Color
            RadioButton_Download_User.FlatAppearance.BorderSize = 2
        Else
            RadioButton_Download_User.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40)
            RadioButton_Download_User.FlatAppearance.BorderSize = 1
        End If
    End Sub
    'RadioButton_Startup_Sound_User
    Private Sub RadioButton_Startup_Sound_User_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Startup_Sound_User.CheckedChanged
        If RadioButton_Startup_Sound_User.Checked Then
            RadioButton_Startup_Sound_User.FlatAppearance.BorderColor = Main.Theme_Color
            RadioButton_Startup_Sound_User.FlatAppearance.BorderSize = 2
        Else
            RadioButton_Startup_Sound_User.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40)
            RadioButton_Startup_Sound_User.FlatAppearance.BorderSize = 1
        End If
    End Sub
    'RadioButton_Download_Complete_Sound_User
    Private Sub RadioButton_Download_Complete_Sound_User_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Download_Complete_Sound_User.CheckedChanged
        If RadioButton_Download_Complete_Sound_User.Checked Then
            RadioButton_Download_Complete_Sound_User.FlatAppearance.BorderColor = Main.Theme_Color
            RadioButton_Download_Complete_Sound_User.FlatAppearance.BorderSize = 2
        Else
            RadioButton_Download_Complete_Sound_User.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40)
            RadioButton_Download_Complete_Sound_User.FlatAppearance.BorderSize = 1
        End If
    End Sub
End Class