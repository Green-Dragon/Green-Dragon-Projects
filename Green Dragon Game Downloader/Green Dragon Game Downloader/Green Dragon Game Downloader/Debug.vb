
Public Class Debug
    'Closing
    Private Sub Debug_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Dont Allow Closing
        If Main.Visible = True And Me.Visible = True Then
            Me.Hide()
            e.Cancel = True
        End If
    End Sub
    'Onload
    Private Sub Debug_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Variables()
    End Sub
    'Variables
    Public Sub Variables()
        'Time Stamp
        TextBox_Variables.Text = "<" & Now.ToString("hh:mm:ss.fff tt") & "> " & vbCrLf
        'Main.Theme Color
        If Main.Theme_Color = Nothing Then
            TextBox_Variables.AppendText("Main.Theme_Color =" & vbCrLf)
        Else
            TextBox_Variables.AppendText("Main.Theme_Color = " & Main.Theme_Color.ToString & vbCrLf)
        End If
        'Main.Game Download Path
        If Main.Game_Download_Path = Nothing Then
            TextBox_Variables.AppendText("Main.Game_Download_Path =" & vbCrLf & vbCrLf)
        Else
            TextBox_Variables.AppendText("Main.Game_Download_Path = " & Main.Game_Download_Path.ToString & vbCrLf & vbCrLf)
        End If
        '---
        'Main.Selected Game
        If Main.Selected_Game = Nothing Then
            TextBox_Variables.AppendText("Main.Selected_Game =" & vbCrLf)
        Else
            TextBox_Variables.AppendText("Main.Selected_Game = " & Main.Selected_Game.ToString & vbCrLf)
        End If
        'Main.Website
        If Main.Website = Nothing Then
            TextBox_Variables.AppendText("Main.Website =" & vbCrLf)
        Else
            TextBox_Variables.AppendText("Main.Website = " & Main.Website.ToString & vbCrLf)
        End If
        'Main.Download
        If Main.Download = Nothing Then
            TextBox_Variables.AppendText("Main.Download =" & vbCrLf)
        Else
            TextBox_Variables.AppendText("Main.Download = " & Main.Download.ToString & vbCrLf)
        End If
        'Main.Game Download
        If Main.Game_Download = Nothing Then
            TextBox_Variables.AppendText("Main.Game_Download =" & vbCrLf & vbCrLf)
        Else
            TextBox_Variables.AppendText("Main.Game_Download = " & Main.Game_Download.ToString & vbCrLf & vbCrLf)
        End If
        '---
        'Main.Auto Selecting Random Category And Game
        TextBox_Variables.AppendText("Main.Auto_Selecting_Random_Category_And_Game = " & Main.Auto_Selecting_Random_Category_And_Game.ToString & vbCrLf)
        'Main.Searching For Game
        TextBox_Variables.AppendText("Main.Searching_For_Game = " & Main.Searching_For_Game & vbCrLf)
        'Main.TotalFileSize
        If Main.TotalFileSize = Nothing Then
            TextBox_Variables.AppendText("Main.TotalFileSize =" & vbCrLf & vbCrLf)
        Else
            TextBox_Variables.AppendText("Main.TotalFileSize = " & Main.TotalFileSize.ToString & vbCrLf & vbCrLf)
        End If
        '---
        'Main.Games Downloading
        If Main.Games_Downloading.Count < 0 Then
            TextBox_Variables.AppendText("Main.Games_Downloading =" & vbCrLf)
        Else
            Dim game() As String = CType(Main.Games_Downloading.ToArray(Type.GetType("System.String")), String())
            Dim games As String
            games = Join(game, ", ") ' join the strings
            TextBox_Variables.AppendText("Main.Games_Downloading = " & games & vbCrLf)
        End If
    End Sub
    'Action Log Changed
    Private Sub TextBox_Action_Log_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Action_Log.TextChanged
        Variables()
    End Sub
End Class