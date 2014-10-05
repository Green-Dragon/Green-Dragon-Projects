

Public Class UserControlServiceProvider

    Public Function IsWhitelisted(ByVal Whitelist() As String, ByVal UseWhitelist As Boolean, ByVal AliasUI As String) As Boolean
        Dim mod1 As Boolean = False

        If UseWhitelist = True Then
            For i As Integer = 0 To Whitelist.Length - 1
                If Whitelist(i).ToLower = AliasUI.ToLower Then
                    mod1 = True
                    Exit For
                End If
            Next
        Else
            mod1 = True
        End If

        Return mod1
    End Function

    Public Function IsBlacklisted(ByVal Blacklist() As String, ByVal AliasUI As String) As Boolean
        Dim mod1 As Boolean = False

        For i As Integer = 0 To Blacklist.Length - 1
            If Blacklist(i).ToLower = AliasUI.ToLower Then
                mod1 = True
                Exit For
            End If
        Next

        Return mod1
    End Function
End Class
