

Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Threading
Imports System.Net.NetworkInformation

Public Class Main
    Dim connstr As NetworkStream
    Dim writer As BinaryWriter
    Dim reader As BinaryReader
    Dim client As TcpClient
    Dim person As Thread
    Public isConnected As Boolean = False
    Dim CryptProvider As CryptProvider
    Dim IniProvider As IniProvider
    Public Port As String
    Dim DataManager As DataManager

    Private Sub MAIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        IniProvider = New IniProvider(My.Application.Info.DirectoryPath & "\clientconf")

        AliasTB.Text = IniProvider.Read("Connection", "Alias")
        IpTB.Text = IniProvider.Read("Connection", "Ip")
        Port = IniProvider.Read("Connection", "Port")

        '###################
        Dim ACS() As String = IO.File.ReadAllLines(My.Application.Info.DirectoryPath & "\data")

        For i As Integer = 0 To ACS.Length - 1
            Dim mod1() As String = ACS(i).Split(":")

            IpTB.AutoCompleteCustomSource.Add(mod1(0))
        Next
        '###################

        CryptProvider = New CryptProvider(IniProvider.Read("Security", "EncDec"))

        'OMG it's so cheap:
        Control.CheckForIllegalCrossThreadCalls = False

        DataManager = New DataManager

        If DataManager.IsFirstStart = True Then
            TBI.ShowBalloonTip(3000, "Did you know...", "With a right-click on this icon you have access to additional options?", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub ConnectBTN_Click(sender As System.Object, e As System.EventArgs) Handles ConnectBTN.Click
        IniProvider.Write("Connection", "Alias", AliasTB.Text)
        IniProvider.Write("Connection", "Ip", IpTB.Text)

        If isConnected = False Then
            If IpTB.Text <> "" Then
                If Port <> "" Then
                    If AliasTB.Text <> "" Then
                        If AliasTB.Text.Contains(" ") = False Then
                            If DataManager.IsValidIP(IpTB.Text) = True Then
                                DataManager.SaveSaves(IpTB.Text)

                                IpTB.Enabled = False
                                AliasTB.Enabled = False
                                ConnectBTN.Enabled = False
                                StatusLB.Text = "Sending ping..."

                                Dim PingProvider As New Ping
                                AddHandler PingProvider.PingCompleted, AddressOf PingCompleted

                                PingProvider.SendAsync(IpTB.Text, IpTB.Text)
                            Else
                                StatusLB.Text = "Invalid IP"
                            End If
                        End If
                    End If
                End If
            End If
        Else
            Disconnect()
            StatusLB.Text = "Disconnected."
            SendBox.Enabled = False
            Inbox.Clear()
            ActivesLB.Items.Clear()
        End If

    End Sub

    Private Sub PingCompleted(ByVal sender As Object, ByVal e As System.Net.NetworkInformation.PingCompletedEventArgs)
        If e.Reply.Status = IPStatus.Success Then
            Try
                client = New TcpClient
                client.Connect(IpTB.Text, Port)

                If client.Connected = True Then
                    ConnectBTN.Enabled = True
                    ConnectBTN.Text = "Disconnect"
                    isConnected = True
                    StatusLB.Text = "Connected."

                    connstr = client.GetStream
                    writer = New BinaryWriter(connstr)
                    reader = New BinaryReader(connstr)

                    writeString(AliasTB.Text)

                    person = New Thread(AddressOf listening)
                    person.Start()
                    SendBox.Enabled = True
                Else
                    Disconnect()
                    ConnectBTN.Enabled = True
                    StatusLB.Text = "Disconnected."
                    SendBox.Enabled = False
                    Inbox.Clear()
                    ActivesLB.Items.Clear()
                End If
            Catch
                client.Close()
                ConnectBTN.Enabled = True
                IpTB.Enabled = True
                AliasTB.Enabled = True
                StatusLB.Text = "Connection failed."
                SendBox.Enabled = False
                Inbox.Clear()
                ActivesLB.Items.Clear()
            End Try
        Else
            IpTB.Enabled = True
            AliasTB.Enabled = True
            ConnectBTN.Enabled = True

            StatusLB.Text = "This IP is not available"
        End If
    End Sub

    Private Sub UpdateActives(ByVal actives As String)
        Dim act() As String = actives.Split(":")
        ActivesLB.Items.Clear()
        ActivesLB.Items.AddRange(act)
    End Sub

    Private Sub listening()
        While client.Connected
            Try
                Dim key As Int32 = readInt()
                Dim argument As String = readString()

                Select Case key
                    Case 1
                        receiving(argument)
                    Case 2
                        UpdateActives(argument)
                End Select
            Catch
                Disconnect()
                StatusLB.Text = "Disconnected."
                IpTB.Enabled = True
                AliasTB.Enabled = True
                ConnectBTN.Text = "Connect"
                isConnected = False
                SendBox.Enabled = False
                Inbox.Clear()
                ActivesLB.Items.Clear()
            End Try
        End While
    End Sub

    Private Sub Disconnect()
        client.Close()
        connstr.Close()
        reader.Close()
        writer.Close()
    End Sub

    Private Sub SendMessage()

        If SendBox.Text <> "" Then
            writeInt(1)
            writeString(SendBox.Text)
            SendBox.Clear()
        End If

    End Sub

    Private Sub Command(ByVal Length As Integer, ByVal Key As Integer)
        Dim mod1 As String = SendBox.Text
        Dim mod2 As String = mod1.Replace(" ", "")
        Dim mod3 As String = mod2.Remove(0, Length)

        writeInt(Key)
        writeString(mod3)
    End Sub

    Private Sub PrivateMessage()
        Dim mod1 As String = SendBox.Text
        Dim mod2 As String = mod1.Remove(0, 1)

        If mod2.Contains(" ") Then
            Dim mod3() As String = mod2.Split(" ")

            writeInt(2)
            writeString(mod3(1))
            writeString(mod3(0))
            SendBox.Clear()
        Else
            SendBox.Clear()
        End If
    End Sub

    Private Sub Help()
        Inbox.AppendText("@<nickname> <message>" & vbNewLine)
        Inbox.AppendText("/op <password>" & vbNewLine)
        Inbox.AppendText("/ckey <new key>" & vbNewLine)
        Inbox.AppendText("/kick <nickname>" & vbNewLine)
        Inbox.AppendText("/ban <nickname>" & vbNewLine)
        Inbox.AppendText("/help" & vbNewLine)
    End Sub

    Private Sub CheckForCommands()

        If SendBox.Text.StartsWith("/") Then
            If SendBox.Text.StartsWith("/op") Then
                Command(3, 3)
                SendBox.Clear()
            ElseIf SendBox.Text.StartsWith("/ckey") Then
                Command(5, 4)
                SendBox.Clear()
            ElseIf SendBox.Text.StartsWith("/kick") Then
                Command(5, 5)
                SendBox.Clear()
            ElseIf SendBox.Text.StartsWith("/ban") Then
                Command(4, 6)
                SendBox.Clear()
            ElseIf SendBox.Text = "/help" Then
                Help()
                SendBox.Clear()
            Else
                SendBox.Clear()
            End If
        ElseIf SendBox.Text.StartsWith("@") Then
            PrivateMessage()
            SendBox.Clear()
        Else
            SendMessage()
        End If

    End Sub

    Private Sub receiving(ByVal message As String)
        Inbox.AppendText(message & vbNewLine)
    End Sub

    Private Function readString() As String
        Return CryptProvider.Decrypt(reader.ReadString)
    End Function

    Private Function readInt() As Int32
        Return reader.ReadInt32
    End Function

    Private Sub writeString(ByVal Message As String)
        writer.Write(CryptProvider.Encrypt(Message))
        writer.Flush()
    End Sub

    Private Sub writeInt(ByVal val As Int32)
        writer.Write(val)
        writer.Flush()
    End Sub

    Private Sub SendBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles SendBox.KeyPress

        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            CheckForCommands()
        End If

    End Sub

    Private Sub MAIN_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub AliasTB_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AliasTB.MouseEnter
        AliasTB.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub AliasTB_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AliasTB.MouseLeave
        AliasTB.BackColor = Color.White
    End Sub

    Private Sub IpTB_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IpTB.MouseEnter
        IpTB.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub IpTB_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IpTB.MouseLeave
        IpTB.BackColor = Color.White
    End Sub

    'Dim Before As Point = New Point(700, 344)

    'Private Sub Main_SizeChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.SizeChanged

    '    If Me.Size.Height >= Before.Y Then
    '        Inbox.Size = New Point(Inbox.Size.Width, Inbox.Size.Height + (Me.Size.Height - Before.Y))
    '        SendBox.Location = New Point(SendBox.Location.X, SendBox.Location.Y + (Me.Size.Height - Before.Y))
    '    Else
    '        Inbox.Size = New Point(Inbox.Size.Width, Inbox.Size.Height - (Before.Y - Me.Size.Height))
    '        SendBox.Location = New Point(SendBox.Location.X, SendBox.Location.Y + (Me.Size.Height - Before.Y))
    '    End If

    '    Before = Me.Size

    'End Sub
End Class
