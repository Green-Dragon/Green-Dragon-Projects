

Imports System.Net.Sockets
Imports System.IO
Imports System.Net
Imports System.Threading

Module MainModule
    Dim listener As TcpListener
    Dim client As New TcpClient
    Dim conninf As IPEndPoint
    Dim actives As New List(Of Connection)
    Dim cryptProvider As CryptProvider
    Dim adminPassword As String

    Sub Main()
        Dim DataManager As New DataManager
        DataManager.Startup()
        cryptProvider = New CryptProvider(DataManager.GetEncDec)
        conninf = New IPEndPoint(IPAddress.Any, DataManager.GetPort)
        adminPassword = DataManager.GetAdminPassword

        If ConsoleSpecialKey.ControlC Then
            End
        End If

        Console.Title = "Green Dragon Chat"
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("Green Dragon Chat v. " & My.Application.Info.Version.ToString)
        Console.WriteLine("Press CTRL-C to exit")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Set up server...")
        listener = New TcpListener(conninf)

        Try
            listener.Start()
        Catch
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Initialising failed. Is the server already started?")
            Console.WriteLine("Press any key to exit...")
            Console.ForegroundColor = ConsoleColor.Black
            Console.ReadKey()
            End
        End Try

        Console.WriteLine("Successful. Listening on port " & DataManager.GetPort)
        Console.ForegroundColor = ConsoleColor.White

        While True
            client = listener.AcceptTcpClient

            Dim c As New Connection
            c.connstr = client.GetStream
            c.reader = New BinaryReader(c.connstr)
            c.writer = New BinaryWriter(c.connstr)

            c.isAdmin = False

            Try
                c.aliasIU = readString(c)
            Catch : End Try

            '######################Client######################
            Dim UserControlServiceProvider As New UserControlServiceProvider

            Dim isConnected As Boolean = False

            For Each checkAV As Connection In actives
                If checkAV.aliasIU.ToLower = c.aliasIU.ToLower Then
                    isConnected = True
                    Exit For
                End If
            Next
            '######################Client#####################

            If actives.Count - 2 <= DataManager.GetMaxUsers Then
                If UserControlServiceProvider.IsBlacklisted(DataManager.GetBlacklist, c.aliasIU) = False Then
                    If UserControlServiceProvider.IsWhitelisted(DataManager.GetWhitelist, DataManager.GetWhitelistBool, c.aliasIU) = True Then
                        If isConnected = False Then
                            actives.Add(c)

                            Dim remoteAddress As IPEndPoint = client.Client.RemoteEndPoint
                            Dim remoteAddressStr As String = remoteAddress.Address.ToString

                            SendToAllClients(1, c.aliasIU & " has joined")

                            Console.ForegroundColor = ConsoleColor.Cyan
                            Console.WriteLine("[" & Format(Now, "hh:mm:ss") & "] " & c.aliasIU & " (" & remoteAddressStr & ") logged in")
                            Console.ForegroundColor = ConsoleColor.White

                            ChangeUsers()

                            Dim person As New Thread(AddressOf ListenToConnection)
                            person.Start(c)
                        Else
                            c.connstr.Close()
                            c.reader.Close()
                            c.writer.Close()
                            Console.ForegroundColor = ConsoleColor.Cyan
                            Console.WriteLine("[" & Format(Now, "hh:mm:ss") & "] Disconnected " & c.aliasIU & ": Already logged in")
                            Console.ForegroundColor = ConsoleColor.White
                        End If
                    Else
                        c.connstr.Close()
                        c.reader.Close()
                        c.writer.Close()
                        Console.ForegroundColor = ConsoleColor.Cyan
                        Console.WriteLine("[" & Format(Now, "hh:mm:ss") & "] Disconnected " & c.aliasIU & ": Not whitelisted")
                        Console.ForegroundColor = ConsoleColor.White
                    End If
                Else
                    c.connstr.Close()
                    c.reader.Close()
                    c.writer.Close()
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.WriteLine("[" & Format(Now, "hh:mm:ss") & "] Disconnected " & c.aliasIU & ": Banned")
                    Console.ForegroundColor = ConsoleColor.White
                End If
            Else
                c.connstr.Close()
                c.reader.Close()
                c.writer.Close()
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.WriteLine("[" & Format(Now, "hh:mm:ss") & "] Disconnected " & c.aliasIU & ": Only " & DataManager.GetMaxUsers & " users allowed")
                Console.ForegroundColor = ConsoleColor.White
            End If
        End While
    End Sub

    Private Sub ChangeUsers()

        Dim activesTemp As String = ""

        For Each cn As Connection In actives
            activesTemp &= ":" & cn.aliasIU
        Next

        Dim activesStr As String = activesTemp.Substring(1)

        SendToAllClients(2, activesStr)

    End Sub

    Private Sub SendToAllClients(ByVal key As Int32, ByVal argument As String)
        For Each c As Connection In actives
            Try
                writeInt(c, key)
                writeString(c, argument)
            Catch : End Try
        Next
    End Sub

    Private Sub SendToSpecClient(ByVal key As Int32, ByVal argument As String, ByVal AliasIU As String)
        For Each conns As Connection In actives
            Try
                If conns.aliasIU = AliasIU Then
                    writeInt(conns, key)
                    writeString(conns, argument)
                    Exit For
                End If
            Catch : End Try
        Next
    End Sub

    Private Function readString(ByVal connection As Connection) As String
        Return cryptProvider.Decrypt(connection.reader.ReadString)
    End Function

    Private Function readInt(ByVal connection As Connection) As Int32
        Return connection.reader.ReadInt32
    End Function

    Private Sub writeString(ByVal connection As Connection, ByVal Message As String)
        connection.writer.Write(cryptProvider.Encrypt(Message))
        connection.writer.Flush()
    End Sub

    Private Sub writeInt(ByVal connection As Connection, ByVal val As Int32)
        connection.writer.Write(val)
        connection.writer.Flush()
    End Sub

    Private Sub ChangeEncDec(ByVal newEncDec As String)
        Dim StartupManager As New DataManager

        StartupManager.WriteEncDec(newEncDec)
    End Sub

    Private Sub Disconnect(ByVal c As Connection)
        c.isAdmin = False
        actives.Remove(c)
        c.connstr.Close()
        c.reader.Close()
        c.writer.Close()
    End Sub

    Private Sub ListenToConnection(ByVal connection As Connection)
        Do
            Try
                Dim key As Int32 = readInt(connection)

                Select Case key
                    Case 1
                        '#########################################
                        Dim argument As String = readString(connection)

                        Console.WriteLine("[" & Format(Now, "hh:mm:ss") & "] " & connection.aliasIU & ": " & argument)
                        SendToAllClients(1, "[" & connection.aliasIU & "] " & argument)
                        '#########################################
                    Case 2
                        '#########################################
                        Dim argument As String = readString(connection)
                        Dim argument2 As String = readString(connection)

                        Console.WriteLine("[" & Format(Now, "hh:mm:ss") & "] " & connection.aliasIU & " --> " & argument2 & ": " & argument)
                        SendToSpecClient(1, "[" & connection.aliasIU & " --> " & argument2 & "] " & argument, argument2)
                        SendToSpecClient(1, "[" & connection.aliasIU & " --> " & argument2 & "] " & argument, connection.aliasIU)
                        '#########################################
                    Case 3
                        '#########################################
                        Dim argument As String = readString(connection)

                        If connection.isAdmin = False Then
                            If argument = adminPassword Then
                                connection.isAdmin = True

                                Console.ForegroundColor = ConsoleColor.Green
                                Console.WriteLine("[" & Format(Now, "hh:mm:ss") & "] " & connection.aliasIU & " is now admin")
                                Console.ForegroundColor = ConsoleColor.White

                                SendToSpecClient(1, "[Server] You are now admin", connection.aliasIU)
                            Else
                                Console.ForegroundColor = ConsoleColor.Green
                                Console.WriteLine("[" & Format(Now, "hh:mm:ss") & "] " & connection.aliasIU & " tried opping with phrase <" & argument & ">")
                                Console.ForegroundColor = ConsoleColor.White

                                SendToSpecClient(1, "[Server] Wrong phrase", connection.aliasIU)
                            End If
                        Else
                            SendToSpecClient(1, "[Server] You are already admin", connection.aliasIU)
                        End If
                        '#########################################
                    Case 4
                        '#########################################
                        Dim argument As String = readString(connection)

                        If connection.isAdmin = True Then
                            ChangeEncDec(argument)

                            Console.ForegroundColor = ConsoleColor.Green
                            Console.WriteLine("[" & Format(Now, "hh:mm:ss") & "] " & connection.aliasIU & " changed encryption key to <" & argument & ">")
                            Console.ForegroundColor = ConsoleColor.White
                        Else
                            SendToSpecClient(1, "[Server] You are not admin", connection.aliasIU)
                        End If
                        '#########################################
                    Case 5
                        '#########################################
                        Dim argument As String = readString(connection)

                        If connection.isAdmin = True Then
                            For Each conns As Connection In actives
                                If conns.aliasIU = argument Then
                                    Disconnect(conns)
                                End If
                            Next
                        Else
                            SendToSpecClient(1, "[Server] You are not admin", connection.aliasIU)
                        End If
                        '#########################################
                    Case 6
                        '#########################################
                        Dim argument As String = readString(connection)

                        If connection.isAdmin = True Then
                            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\blacklist.txt", argument & vbNewLine, True)

                            For Each conns As Connection In actives
                                If conns.aliasIU = argument Then
                                    Disconnect(conns)
                                End If
                            Next
                        Else
                            SendToSpecClient(1, "[Server] You are not admin", connection.aliasIU)
                        End If
                        '#########################################
                End Select
            Catch
                Disconnect(connection)

                SendToAllClients(1, connection.aliasIU & " has left")

                Console.ForegroundColor = ConsoleColor.Cyan
                Console.WriteLine("[" & Format(Now, "hh:mm:ss") & "] " & connection.aliasIU & " logged out")
                Console.ForegroundColor = ConsoleColor.White

                If actives.Count > 0 Then
                    ChangeUsers()
                End If

                Exit Do
            End Try
        Loop
    End Sub
End Module
