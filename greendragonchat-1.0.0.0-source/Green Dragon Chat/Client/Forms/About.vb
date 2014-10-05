' Copyright (C) Florian Bührle

' This file is part of Green Dragon Chat.
' Green Dragon Chat is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.

' Green Dragon Chat is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License
' along with Green Dragon Chat.  If not, see <http://www.gnu.org/licenses/>.

Public Class About
    Dim clickedBox As Char = "1"

    Private Sub OKBUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBtn.Click

        Me.Close()

    End Sub

    Private Sub ABOUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LicenseTB.Hide()
        APanel.Show()

        Label1.Text = "Green Dragon Chat" & vbNewLine & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor

    End Sub

#Region "Style-Spezifischer Code"

    Private Sub Panel3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseEnter

        If clickedBox <> "1" Then
            Panel3.BackColor = Color.FromArgb(240, 240, 240)
        End If

    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseLeave

        If clickedBox <> "1" Then
            Panel3.BackColor = Color.White
        End If

    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter

        If clickedBox <> "1" Then
            Panel3.BackColor = Color.FromArgb(240, 240, 240)
        End If

    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave

        If clickedBox <> "1" Then
            Panel3.BackColor = Color.White
        End If

    End Sub


    Private Sub Label3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If clickedBox <> "2" Then

        End If

    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If clickedBox <> "2" Then

        End If

    End Sub

    Private Sub Panel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Click

        clickedBox = "1"
        LicenseTB.Hide()
        APanel.Show()

        Panel3.BackColor = Color.FromArgb(240, 240, 240)


    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

        clickedBox = "1"
        LicenseTB.Hide()
        APanel.Show()

        Panel3.BackColor = Color.FromArgb(240, 240, 240)


    End Sub

    Private Sub Panel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        clickedBox = "2"
        APanel.Hide()
        LicenseTB.Show()


        Panel3.BackColor = Color.White

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        clickedBox = "2"
        APanel.Hide()
        LicenseTB.Show()


        Panel3.BackColor = Color.White

    End Sub
#End Region


End Class
