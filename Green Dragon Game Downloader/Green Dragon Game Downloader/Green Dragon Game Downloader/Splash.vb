
Public Class Splash
    Public Loading As String
    Public Loading_Bar As Integer = 0
    'OnStartup
    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label_Version.Text = "Version: " & My.Application.Info.Version.ToString
        Label_Copyright.Text = My.Application.Info.Copyright
        Label_Made_By.Text = My.Application.Info.CompanyName
    End Sub
    'AccessControl
    Public Sub Loading_AccessControl()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf Loading_AccessControl))
        Else
            Label_Loading.Text = Loading
        End If
    End Sub
    'AccessControl
    Public Sub Loading_Bar_AccessControl()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf Loading_Bar_AccessControl))
        Else
            ProgressBar_Loading.Value = Loading_Bar
        End If
    End Sub
End Class