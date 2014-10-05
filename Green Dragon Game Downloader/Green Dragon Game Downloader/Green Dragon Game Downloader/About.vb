
Public Class About
    'Website
    Private Sub Button_Website_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Main.NotifyIcon_Main.BalloonTipText = "Opening the Green Dragon website."
        Main.NotifyIcon_Main.ShowBalloonTip(1500)
        Try
            Process.Start("http://www.greendragonsearch.net/")
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
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
    'Move Window - Label Title
    Private Sub Label_Title_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label_Title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Label_Title.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub
    'Button Project Page MouseLeave
    Private Sub Button_Project_Page_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Project_Page.MouseLeave
        Button_Project_Page.FlatAppearance.BorderColor = Panel_Main.BackColor
    End Sub

    'Form Activated Close Red
    Private Sub About_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        PictureBox_Close.Image = My.Resources.Close_Red
    End Sub
    'Form Deactivate Close Grey
    Private Sub About_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        PictureBox_Close.Image = My.Resources.Close_Grey
    End Sub
End Class