<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.StatusLB = New System.Windows.Forms.Label()
        Me.ConnectBTN = New System.Windows.Forms.Button()
        Me.IpTB = New System.Windows.Forms.TextBox()
        Me.AliasTB = New System.Windows.Forms.TextBox()
        Me.Inbox = New System.Windows.Forms.TextBox()
        Me.SendBox = New System.Windows.Forms.TextBox()
        Me.TBS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TBI = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ActivesLB = New System.Windows.Forms.ListBox()
        Me.Info = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TBS.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusLB
        '
        Me.StatusLB.AutoSize = True
        Me.StatusLB.ForeColor = System.Drawing.Color.Gray
        Me.StatusLB.Location = New System.Drawing.Point(501, 90)
        Me.StatusLB.Name = "StatusLB"
        Me.StatusLB.Size = New System.Drawing.Size(0, 13)
        Me.StatusLB.TabIndex = 16
        '
        'ConnectBTN
        '
        Me.ConnectBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectBTN.Location = New System.Drawing.Point(504, 64)
        Me.ConnectBTN.Name = "ConnectBTN"
        Me.ConnectBTN.Size = New System.Drawing.Size(168, 23)
        Me.ConnectBTN.TabIndex = 15
        Me.ConnectBTN.Text = "Connect"
        Me.ConnectBTN.UseVisualStyleBackColor = True
        '
        'IpTB
        '
        Me.IpTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.IpTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.IpTB.BackColor = System.Drawing.Color.White
        Me.IpTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IpTB.ForeColor = System.Drawing.Color.Black
        Me.IpTB.Location = New System.Drawing.Point(504, 38)
        Me.IpTB.Name = "IpTB"
        Me.IpTB.Size = New System.Drawing.Size(168, 20)
        Me.IpTB.TabIndex = 14
        '
        'AliasTB
        '
        Me.AliasTB.BackColor = System.Drawing.Color.White
        Me.AliasTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AliasTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AliasTB.ForeColor = System.Drawing.Color.Black
        Me.AliasTB.Location = New System.Drawing.Point(504, 12)
        Me.AliasTB.MaxLength = 30
        Me.AliasTB.Name = "AliasTB"
        Me.AliasTB.Size = New System.Drawing.Size(168, 20)
        Me.AliasTB.TabIndex = 13
        '
        'Inbox
        '
        Me.Inbox.BackColor = System.Drawing.Color.White
        Me.Inbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Inbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Inbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inbox.ForeColor = System.Drawing.Color.Black
        Me.Inbox.Location = New System.Drawing.Point(12, 12)
        Me.Inbox.Multiline = True
        Me.Inbox.Name = "Inbox"
        Me.Inbox.ReadOnly = True
        Me.Inbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Inbox.Size = New System.Drawing.Size(460, 256)
        Me.Inbox.TabIndex = 12
        '
        'SendBox
        '
        Me.SendBox.AutoCompleteCustomSource.AddRange(New String() {"/help", "/about", "/settings", "/internet", "/clear", "/ping", "/msgb", "/close"})
        Me.SendBox.BackColor = System.Drawing.Color.White
        Me.SendBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SendBox.Enabled = False
        Me.SendBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendBox.ForeColor = System.Drawing.Color.Black
        Me.SendBox.Location = New System.Drawing.Point(12, 274)
        Me.SendBox.MaxLength = 500
        Me.SendBox.Name = "SendBox"
        Me.SendBox.Size = New System.Drawing.Size(460, 20)
        Me.SendBox.TabIndex = 11
        '
        'TBS
        '
        Me.TBS.BackColor = System.Drawing.Color.White
        Me.TBS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.TBS.Name = "TBS"
        Me.TBS.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TBS.Size = New System.Drawing.Size(117, 48)
        Me.TBS.Text = "Options&"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'TBI
        '
        Me.TBI.ContextMenuStrip = Me.TBS
        Me.TBI.Icon = CType(resources.GetObject("TBI.Icon"), System.Drawing.Icon)
        Me.TBI.Text = "Green Dragon Chat"
        Me.TBI.Visible = True
        '
        'ActivesLB
        '
        Me.ActivesLB.FormattingEnabled = True
        Me.ActivesLB.Location = New System.Drawing.Point(478, 121)
        Me.ActivesLB.Name = "ActivesLB"
        Me.ActivesLB.ScrollAlwaysVisible = True
        Me.ActivesLB.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ActivesLB.Size = New System.Drawing.Size(194, 173)
        Me.ActivesLB.TabIndex = 18
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GreenDragonChat.My.Resources.Resources.Video_display_svg
        Me.PictureBox2.Location = New System.Drawing.Point(478, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        Me.Info.SetToolTip(Me.PictureBox2, "IP address")
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 306)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusLB)
        Me.Controls.Add(Me.ConnectBTN)
        Me.Controls.Add(Me.IpTB)
        Me.Controls.Add(Me.AliasTB)
        Me.Controls.Add(Me.Inbox)
        Me.Controls.Add(Me.SendBox)
        Me.Controls.Add(Me.ActivesLB)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Green Dragon Chat"
        Me.TBS.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusLB As System.Windows.Forms.Label
    Friend WithEvents ConnectBTN As System.Windows.Forms.Button
    Friend WithEvents IpTB As System.Windows.Forms.TextBox
    Friend WithEvents AliasTB As System.Windows.Forms.TextBox
    Friend WithEvents Inbox As System.Windows.Forms.TextBox
    Friend WithEvents SendBox As System.Windows.Forms.TextBox
    Friend WithEvents TBS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBI As System.Windows.Forms.NotifyIcon
    Friend WithEvents ActivesLB As System.Windows.Forms.ListBox
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Info As System.Windows.Forms.ToolTip

End Class
