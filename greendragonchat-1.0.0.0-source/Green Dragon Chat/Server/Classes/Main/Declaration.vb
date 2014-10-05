Imports System.IO
Imports System.Net.Sockets

Public Structure Connection
    Dim connstr As NetworkStream
    Dim writer As BinaryWriter
    Dim reader As BinaryReader
    Dim isAdmin As Boolean
    Dim aliasIU As String
End Structure
