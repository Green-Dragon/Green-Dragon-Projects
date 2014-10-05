

Public Class DataManager
    Dim iniProvider As IniProvider

    Public Sub Startup()
        iniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\clientconf")

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\clientconf") = False Then

            iniProvider.Write("Connection", "Ip", "127.0.0.1")
            iniProvider.Write("Connection", "Port", "50192")
            iniProvider.Write("Connection", "Alias", Environment.UserName)
            iniProvider.Write("IntInfo", "Started", "false")
            iniProvider.Write("Security", "EncDec", "ThisIsAPassword")

        End If

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\data") = False Then

            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\data", "127.0.0.1:localhost:You" & vbNewLine & "localhost:127.0.0.1:You" & vbNewLine, False)

        End If

    End Sub

    Public Function IsFirstStart() As Boolean
        iniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\clientconf")

        Select Case iniProvider.Read("IntInfo", "Started")
            Case "false"
                iniProvider.Write("IntInfo", "Started", "true")
                Return True
            Case "true"
                Return False
            Case Else
                iniProvider.Write("IntInfo", "Started", "false")
                Return True
        End Select

    End Function

    Public Sub SaveSaves(ByVal saves As String)

        Dim SavedAliases As String = IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\data")
        If SavedAliases.Contains(saves) = False Then
            IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\data", SavedAliases & saves & "::" & vbNewLine)
        End If

    End Sub

    Public Sub UnhandledException(ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs)

        My.Computer.FileSystem.WriteAllText(Environment.GetFolderPath(0) & "\nclog.txt", e.Exception.ToString & vbNewLine & "- - -" & vbNewLine, True)
        MsgBox("Sorry, that's a bug." & vbNewLine, MsgBoxStyle.Critical, "Runtime error")

    End Sub

    Public Function IsValidIP(ByVal sIP As String) As Boolean
        Dim bValid As Boolean = False

        If sIP.Length > 0 Then
            Dim sNumber() As String = sIP.Split(".")

            If sNumber.Length = 4 Then
                bValid = True

                For i = 0 To 3
                    If Not IsNumeric(sNumber(i)) OrElse sNumber(i).Length > 3 Then
                        bValid = False : Exit For
                    End If

                    Dim Value As Integer = Integer.Parse(sNumber(i))

                    If i = 0 Then
                        If Value < 10 Or Value > 255 Then
                            bValid = False : Exit For
                        End If

                    Else
                        If Value < 0 Or Value > 255 Then
                            bValid = False : Exit For
                        End If
                    End If
                Next
            End If
        End If

        Return bValid
    End Function
End Class
