
Public Class DataManager
    Dim iniProvider As IniProvider

    Public Sub Startup()
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\serverconf") = False Then

            iniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\serverconf")

            iniProvider.Write("Connection", "Port", "50192")
            iniProvider.Write("Security", "EncDec", "ThisIsAPassword")
            iniProvider.Write("Security", "Whitelist", "false")
            iniProvider.Write("Security", "MaxUsers", "10")
            iniProvider.Write("Security", "AdminPassword", "ChooseOne")

        End If

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\whitelist.txt") = False Then
            IO.File.Create(My.Application.Info.DirectoryPath & "\whitelist.txt")
        End If

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\blacklist.txt") = False Then
            IO.File.Create(My.Application.Info.DirectoryPath & "\blacklist.txt")
        End If

    End Sub

    Public Function GetPort() As String
      
        iniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\serverconf")
        Return iniProvider.Read("Connection", "Port")

    End Function

    Public Function GetMaxUsers() As Integer
        iniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\serverconf")
        Return CInt(iniProvider.Read("Security", "MaxUsers"))
    End Function

    Public Sub WriteEncDec(ByVal newEncDec As String)
       
        iniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\serverconf")
        iniProvider.Write("Security", "EncDec", newEncDec)
    End Sub

    Public Function GetEncDec() As String
   
        iniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\serverconf")
        Return iniProvider.Read("Security", "EncDec")

    End Function

    Public Function GetWhitelistBool() As Boolean
       
        iniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\serverconf")

        Select Case iniProvider.Read("Security", "Whitelist")
            Case "true"
                Return True
            Case "false"
                Return False
            Case Else
                Return False
        End Select

    End Function

    Public Function GetWhitelist() As String()

        If IO.File.Exists(My.Application.Info.DirectoryPath & "\whitelist.txt") = True Then
            Return IO.File.ReadAllLines(My.Application.Info.DirectoryPath & "\whitelist.txt")
        Else
            Dim mod1() As String = {""}
            Return mod1
        End If

    End Function

    Public Function GetBlacklist() As String()

        If IO.File.Exists(My.Application.Info.DirectoryPath & "\blacklist.txt") = True Then
            Return IO.File.ReadAllLines(My.Application.Info.DirectoryPath & "\blacklist.txt")
        Else
            Dim mod1() As String = {""}
            Return mod1
        End If

    End Function

    Public Function GetAdminPassword() As String
      
        iniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\serverconf")
        Return iniProvider.Read("Security", "AdminPassword")

    End Function
End Class
