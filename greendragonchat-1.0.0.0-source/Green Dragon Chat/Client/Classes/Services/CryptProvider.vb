

Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class CryptProvider
    Dim Password As String

    Public Sub New(ByVal encDec As String)

        Password = encDec

    End Sub

    Public Function Encrypt(ByVal Message As String) As String
        Dim CMS As New RijndaelManaged

        Dim CS As New MD5CryptoServiceProvider
        Dim PW() As Byte = CS.ComputeHash(Encoding.UTF8.GetBytes(Password))

        CS.Clear()
        CMS.Key = PW
        CMS.GenerateIV()

        Dim TRG() As Byte = CMS.IV
        Dim MS As New MemoryStream

        MS.Write(TRG, 0, TRG.Length)

        Dim DSX As New CryptoStream(MS, CMS.CreateEncryptor, CryptoStreamMode.Write)
        Dim STR() As Byte = System.Text.Encoding.UTF8.GetBytes(Message)

        DSX.Write(STR, 0, STR.Length)
        DSX.FlushFinalBlock()

        Dim STRI() As Byte = MS.ToArray()
        Return Convert.ToBase64String(STRI)
        DSX.Close()
        CMS.Clear()

    End Function

    Public Function Decrypt(ByVal Message As String) As String
        Dim CMS As New RijndaelManaged
        Dim CMSL As Integer = 16
        Dim CS As New MD5CryptoServiceProvider
        Dim PW() As Byte = CS.ComputeHash(Encoding.UTF8.GetBytes(Password))

        CS.Clear()

        Dim ENDGM() As Byte = Convert.FromBase64String(Message)

        Dim MS As New MemoryStream(ENDGM)
        Dim iv(15) As Byte

        MS.Read(iv, 0, CMSL)
        CMS.IV = iv
        CMS.Key = PW

        Dim CRYP As New CryptoStream(MS, CMS.CreateDecryptor, CryptoStreamMode.Read)

        Dim STR(MS.Length - CMSL) As Byte
        Dim i As Integer = CRYP.Read(STR, 0, STR.Length)

        Return System.Text.Encoding.UTF8.GetString(STR, 0, i)
        CRYP.Close()
        CMS.Clear()

    End Function
End Class
