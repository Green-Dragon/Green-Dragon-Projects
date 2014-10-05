Public Class mainFrm
    Dim folderpath As String

    Private Sub OpenToolStripMenuItem_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'it will open the folder dialog where you can select where is the specific folder of your music
            FolderBrowserDialog1.ShowDialog()

            If DialogResult.OK Then
                'if true that if you click ok on the folder dialog box then
                'it will get the selected path of your folder and store it into di variable
                Dim di As New IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath)
                'in this line of code it will get all the specific file that has the .mp3 extension and store it into diar1 variable
                Dim diar1 As IO.FileInfo() = di.GetFiles("*.")

                'and in this line it will gather all information with regardsto fullpath and names of all files and store it to the folderpath variable
                folderpath = di.FullName.ToString

                'it will call the sub procedure jokenresult() to perform some actions
                jokenresult()
            End If
        Catch ex As Exception
            'if errors occur then the program will catch it and send it back to the user.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub
    Public Sub jokenresult()

        Green_Dragon_Media_Player.Width = 787


    End Sub
    Private Sub list_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'the myPlayer will play or display something from the list based on the user selected item
        Green_Dragon_Media_Player.URL = folderpath & "\"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

 

    Private Sub mainFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Green_Dragon_Media_Player.Width = 787    ' it will resize the width of myPlayer into 787
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            'it will open the folder dialog where you can select where is the specific folder of your music
            FolderBrowserDialog1.ShowDialog()

            If DialogResult.OK Then
                'if true that if you click ok on the folder dialog box then
                'it will get the selected path of your folder and store it into di variable
                Dim di As New IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath)
                'in this line of code it will get all the specific file that has the .mp3 extension and store it into diar1 variable
                Dim diar1 As IO.FileInfo() = di.GetFiles("*.")
                Dim dra As IO.FileInfo
                'and in this line it will gather all information with regardsto fullpath and names of all files and store it to the folderpath variable
                folderpath = di.FullName.ToString

                ' list the names of all files in the specified directory

                For Each dra In diar1
                    Dim a As Integer = 0
                    ' a = a + 1

                Next
                'it will call the sub procedure jokenresult() to perform some actions
                jokenresult()
            End If
        Catch ex As Exception
            'if errors occur then the program will catch it and send it back to the user.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub OpenFileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileToolStripMenuItem1.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Green_Dragon_Media_Player.URL = OpenFileDialog1.FileName()
        End If
    End Sub

End Class
