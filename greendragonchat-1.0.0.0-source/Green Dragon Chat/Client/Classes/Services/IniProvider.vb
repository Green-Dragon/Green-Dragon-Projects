

Public Class IniProvider
    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKEYName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Dim path As String

    Public Sub New(ByVal path As String)

        Me.path = path

    End Sub

    Public Function Read(ByVal SECT As String, ByVal KEY As String) As String

        Dim sTemp As String = Space(1024)
        Dim Length As Integer = GetPrivateProfileString(SECT, KEY, "", sTemp, 1024, path)
        Return Left(sTemp, Length)

    End Function

    Public Sub Write(ByVal SECT As String, ByVal KEY As String, ByVal WRT As String)

        WritePrivateProfileString(SECT, KEY, WRT, path)

    End Sub
End Class
