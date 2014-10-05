

Imports System.Net.Dns
Imports System.Net
Imports System.Net.NetworkInformation

Public Class Settings
    Dim iniProvider As IniProvider
    Dim ACS() As String
    Dim GGEF As String = "1"
    
    Private Sub SETTINGS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IPSUCP.Hide()
        INFORMS.Hide()
        KOMMUNIKATION.Show()

        iniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\clientconf")

        VERENTPW.Text = iniProvider.Read("Security", "EncDec")

        For Each phys As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces
            ComboBox1.Items.Add(phys.Name)
        Next

        ACS = IO.File.ReadAllLines(My.Application.Info.DirectoryPath & "\data")

        For i As Integer = 0 To ACS.Length - 1
            Dim mod1() As String = ACS(i).Split(":")
            SavedServers.Items.Add(mod1(0))
        Next

        MESSPORT.Text = iniProvider.Read("Connection", "Port")

    End Sub

    Private Sub SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVE.Click

        iniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\clientconf")

        iniProvider.Write("Security", "EncDec", VERENTPW.Text)

        iniProvider.Write("Connection", "Port", MESSPORT.Text)

        IO.File.WriteAllLines(My.Application.Info.DirectoryPath & "\data", ACS)

        Me.Close()

    End Sub

    Private Sub CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCEL.Click

        Me.Close()

    End Sub

    Private Sub STANDART_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STANDART.Click

        VERENTPW.Text = "ThisIsAPassword"

        MESSPORT.Text = "50192"

    End Sub

#Region "Style-Spezifischer Code"

    Private Sub KOMMUNIKATION1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KOMMUNIKATION1.MouseEnter

        If GGEF <> "1" Then
            KOMMUNIKATION1.BackColor = Color.FromArgb(240, 240, 240)
        End If

    End Sub

    Private Sub KOMMUNIKATION1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KOMMUNIKATION1.MouseLeave

        If GGEF <> "1" Then
            KOMMUNIKATION1.BackColor = Color.White
        End If

    End Sub

    Private Sub Label7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.MouseEnter

        If GGEF <> "1" Then
            KOMMUNIKATION1.BackColor = Color.FromArgb(240, 240, 240)
        End If

    End Sub

    Private Sub Label7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.MouseLeave

        If GGEF <> "1" Then
            KOMMUNIKATION1.BackColor = Color.White
        End If

    End Sub

    Private Sub IPSUCP1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPSUCP1.MouseEnter

        If GGEF <> "3" Then
            IPSUCP1.BackColor = Color.FromArgb(240, 240, 240)
        End If

    End Sub

    Private Sub IPSUCP1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPSUCP1.MouseLeave

        If GGEF <> "3" Then
            IPSUCP1.BackColor = Color.White
        End If

    End Sub

    Private Sub Label10_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.MouseEnter

        If GGEF <> "3" Then
            IPSUCP1.BackColor = Color.FromArgb(240, 240, 240)
        End If

    End Sub

    Private Sub Label10_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.MouseLeave

        If GGEF <> "3" Then
            IPSUCP1.BackColor = Color.White
        End If

    End Sub

    Private Sub INFORMS1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INFORMS1.MouseEnter

        If GGEF <> "4" Then
            INFORMS1.BackColor = Color.FromArgb(240, 240, 240)
        End If

    End Sub

    Private Sub INFORMS1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INFORMS1.MouseLeave

        If GGEF <> "4" Then
            INFORMS1.BackColor = Color.White
        End If

    End Sub

    Private Sub Label11_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.MouseEnter

        If GGEF <> "4" Then
            INFORMS1.BackColor = Color.FromArgb(240, 240, 240)
        End If

    End Sub

    Private Sub Label11_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.MouseLeave

        If GGEF <> "4" Then
            INFORMS1.BackColor = Color.White
        End If

    End Sub

    Private Sub KOMMUNIKATION1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KOMMUNIKATION1.Click

        GGEF = "1"
        KOMMUNIKATION1.BackColor = Color.FromArgb(240, 240, 240)
        IPSUCP1.BackColor = Color.White
        INFORMS1.BackColor = Color.White

        IPSUCP.Hide()
        INFORMS.Hide()
        KOMMUNIKATION.Show()

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

        GGEF = "1"
        KOMMUNIKATION1.BackColor = Color.FromArgb(240, 240, 240)
        IPSUCP1.BackColor = Color.White
        INFORMS1.BackColor = Color.White

        IPSUCP.Hide()
        INFORMS.Hide()
        KOMMUNIKATION.Show()

    End Sub

    Private Sub IPSUCP1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPSUCP1.Click

        GGEF = "3"
        IPSUCP1.BackColor = Color.FromArgb(240, 240, 240)
        KOMMUNIKATION1.BackColor = Color.White
        INFORMS1.BackColor = Color.White

        INFORMS.Hide()
        KOMMUNIKATION.Hide()
        IPSUCP.Show()

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

        GGEF = "3"
        IPSUCP1.BackColor = Color.FromArgb(240, 240, 240)
        KOMMUNIKATION1.BackColor = Color.White
        INFORMS1.BackColor = Color.White

        INFORMS.Hide()
        KOMMUNIKATION.Hide()
        IPSUCP.Show()

    End Sub

    Private Sub INFORMS1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INFORMS1.Click

        GGEF = "4"
        INFORMS1.BackColor = Color.FromArgb(240, 240, 240)
        IPSUCP1.BackColor = Color.White
        KOMMUNIKATION1.BackColor = Color.White

        KOMMUNIKATION.Hide()
        IPSUCP.Hide()
        INFORMS.Show()

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

        GGEF = "4"
        INFORMS1.BackColor = Color.FromArgb(240, 240, 240)
        IPSUCP1.BackColor = Color.White
        KOMMUNIKATION1.BackColor = Color.White

        KOMMUNIKATION.Hide()
        IPSUCP.Hide()
        INFORMS.Show()

    End Sub
#End Region

    Private Sub MESSPORT_TextChanged(sender As System.Object, e As System.EventArgs) Handles MESSPORT.TextChanged

        If IsNumeric(MESSPORT.Text) = False Then
            MESSPORT.BackColor = Color.Red
        Else
            If CInt(MESSPORT.Text) > 99999 Then
                MESSPORT.BackColor = Color.Red
            Else
                MESSPORT.BackColor = Color.White
            End If
        End If

    End Sub

    Private Sub CANCEL_Click_1(sender As System.Object, e As System.EventArgs) Handles CANCEL.Click
        Me.Close()
    End Sub

    Private Sub CrCrKeyBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrCrKeyBTN.Click

        CryptionKeyGenerator.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        CheckBox1.Enabled = True

        For Each phys As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces
            If phys.Name = ComboBox1.SelectedItem.ToString Then
                IDTB.Text = phys.Id
                MACTB.Text = phys.GetPhysicalAddress.ToString
                StatusTB.Text = phys.OperationalStatus.ToString
                SpeedTB.Text = CStr(Math.Round(phys.Speed / 1000000)) & " MB/s"
                IsReceiveOnlyTB.Text = phys.IsReceiveOnly.ToString
                InterfaceTypeTB.Text = phys.NetworkInterfaceType.ToString
                SupportsMulticastTB.Text = phys.SupportsMulticast.ToString
                BytesSentTB.Text = phys.GetIPv4Statistics.BytesSent
                BytesReceivedTB.Text = phys.GetIPv4Statistics.BytesReceived

                Exit For
            End If
        Next

    End Sub

    Private Sub AktTM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AktTM.Tick

        For Each phys As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces
            If phys.Name = ComboBox1.SelectedItem.ToString Then
                IDTB.Text = phys.Id
                MACTB.Text = phys.GetPhysicalAddress.ToString
                StatusTB.Text = phys.OperationalStatus.ToString
                SpeedTB.Text = CStr(Math.Round(phys.Speed / 1000000)) & " MB/s"
                IsReceiveOnlyTB.Text = phys.IsReceiveOnly.ToString
                InterfaceTypeTB.Text = phys.NetworkInterfaceType.ToString
                SupportsMulticastTB.Text = phys.SupportsMulticast.ToString
                BytesSentTB.Text = phys.GetIPv4Statistics.BytesSent
                BytesReceivedTB.Text = phys.GetIPv4Statistics.BytesReceived

                Exit For
            End If
        Next

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            AktTM.Enabled = True
        Else
            AktTM.Enabled = False
        End If

    End Sub

    Dim isPassword As Boolean = True

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

        If isPassword = True Then
            VERENTPW.UseSystemPasswordChar = False
            PictureBox5.Image = My.Resources._200px_Unlocked_svg
            isPassword = False
        Else
            VERENTPW.UseSystemPasswordChar = True
            PictureBox5.Image = My.Resources._200px_Locked_svg
            isPassword = True
        End If

    End Sub

    Private Sub SavedServers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SavedServers.SelectedIndexChanged

        If SavedServers.SelectedIndex > -1 Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            Button1.Enabled = True

            Dim mod1() As String = ACS(SavedServers.SelectedIndex).Split(":")

            TextBox1.Text = mod1(1)
            TextBox2.Text = mod1(2)
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        ACS(SavedServers.SelectedIndex) = SavedServers.SelectedItem & ":" & TextBox1.Text & ":" & TextBox2.Text

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button1.Enabled = False

        TextBox1.Clear()
        TextBox1.Enabled = False
        TextBox2.Clear()
        TextBox2.Enabled = False
        SavedServers.Items.Clear()
        ACS = {""}
    End Sub
End Class
