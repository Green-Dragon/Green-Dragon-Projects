<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form


    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.AText = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LicenseTB = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.APanel = New System.Windows.Forms.Panel()
        Me.NCLogo = New System.Windows.Forms.PictureBox()
        Me.LicenseTB.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.APanel.SuspendLayout()
        CType(Me.NCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OKBtn
        '
        Me.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKBtn.Location = New System.Drawing.Point(604, 279)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(65, 23)
        Me.OKBtn.TabIndex = 18
        Me.OKBtn.Text = "Ok"
        Me.OKBtn.UseVisualStyleBackColor = True
        '
        'AText
        '
        Me.AText.AutoSize = True
        Me.AText.Location = New System.Drawing.Point(18, 17)
        Me.AText.Name = "AText"
        Me.AText.Size = New System.Drawing.Size(336, 78)
        Me.AText.TabIndex = 0
        Me.AText.Text = "Green Dragon Chat, a programm for chatting with the TCP/IP protocol" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "emilsaya" & _
            "hi@gmail.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(463, 197)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'LicenseTB
        '
        Me.LicenseTB.BackColor = System.Drawing.Color.White
        Me.LicenseTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LicenseTB.Controls.Add(Me.TextBox1)
        Me.LicenseTB.Location = New System.Drawing.Point(198, 68)
        Me.LicenseTB.Name = "LicenseTB"
        Me.LicenseTB.Size = New System.Drawing.Size(471, 205)
        Me.LicenseTB.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(254, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 26)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Green Dragon Chat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[Version]"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(12, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(180, 65)
        Me.Panel3.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "About"
        '
        'APanel
        '
        Me.APanel.BackColor = System.Drawing.Color.White
        Me.APanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.APanel.Controls.Add(Me.AText)
        Me.APanel.Location = New System.Drawing.Point(198, 68)
        Me.APanel.Name = "APanel"
        Me.APanel.Size = New System.Drawing.Size(471, 205)
        Me.APanel.TabIndex = 17
        '
        'NCLogo
        '
        Me.NCLogo.BackColor = System.Drawing.Color.White
        Me.NCLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.NCLogo.Enabled = False
        Me.NCLogo.ErrorImage = Nothing
        Me.NCLogo.InitialImage = Nothing
        Me.NCLogo.Location = New System.Drawing.Point(198, 12)
        Me.NCLogo.Name = "NCLogo"
        Me.NCLogo.Size = New System.Drawing.Size(48, 48)
        Me.NCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.NCLogo.TabIndex = 19
        Me.NCLogo.TabStop = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(681, 314)
        Me.Controls.Add(Me.OKBtn)
        Me.Controls.Add(Me.NCLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.APanel)
        Me.Controls.Add(Me.LicenseTB)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowInTaskbar = False
        Me.Text = "About"
        Me.LicenseTB.ResumeLayout(False)
        Me.LicenseTB.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.APanel.ResumeLayout(False)
        Me.APanel.PerformLayout()
        CType(Me.NCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OKBtn As System.Windows.Forms.Button
    Friend WithEvents NCLogo As System.Windows.Forms.PictureBox
    Friend WithEvents AText As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LicenseTB As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents APanel As System.Windows.Forms.Panel
End Class
