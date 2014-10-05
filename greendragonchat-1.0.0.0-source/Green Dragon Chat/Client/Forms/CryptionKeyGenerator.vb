

Public Class CryptionKeyGenerator
    Dim first As Boolean = False
    Dim wrd1 As Integer
    Dim wrd2 As Integer
    Dim charset As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!/\&()"

    Private Sub KeyGenPN_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles KeyGenPN.MouseClick

        If first = False Then
            wrd1 = e.Location.X + e.Location.Y
            Label2.Text = 1
            first = True
        ElseIf first = True Then
            wrd2 = e.Location.X + e.Location.Y
            GenerateKey()
            Label2.Text = ""
            first = False
        End If

    End Sub

    Private Sub GenerateKey()
        Dim seed As Integer
        Dim temp As String = ""

        seed = (wrd1 * wrd2) / (wrd1 + wrd2)

        Dim randm As New Random(seed)

        For i As Integer = 0 To 30
            Dim x As Integer = randm.Next(0, 67)
            temp &= charset.Chars(x)
        Next

        KeyTB.Text = temp
    End Sub
End Class