<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.TextBox_About = New System.Windows.Forms.TextBox()
        Me.GroupBox_About = New System.Windows.Forms.GroupBox()
        Me.PictureBox_Logo = New System.Windows.Forms.PictureBox()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.Button_Project_Page = New System.Windows.Forms.Button()
        Me.GroupBox_About.SuspendLayout()
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Main.SuspendLayout()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_About
        '
        Me.TextBox_About.BackColor = System.Drawing.Color.White
        Me.TextBox_About.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_About.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_About.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_About.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox_About.Location = New System.Drawing.Point(3, 16)
        Me.TextBox_About.Multiline = True
        Me.TextBox_About.Name = "TextBox_About"
        Me.TextBox_About.ReadOnly = True
        Me.TextBox_About.Size = New System.Drawing.Size(279, 136)
        Me.TextBox_About.TabIndex = 0
        Me.TextBox_About.TabStop = False
        Me.TextBox_About.Text = resources.GetString("TextBox_About.Text")
        '
        'GroupBox_About
        '
        Me.GroupBox_About.Controls.Add(Me.TextBox_About)
        Me.GroupBox_About.Controls.Add(Me.PictureBox_Logo)
        Me.GroupBox_About.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_About.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_About.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupBox_About.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox_About.Name = "GroupBox_About"
        Me.GroupBox_About.Size = New System.Drawing.Size(365, 155)
        Me.GroupBox_About.TabIndex = 7
        Me.GroupBox_About.TabStop = False
        Me.GroupBox_About.Text = "About"
        '
        'PictureBox_Logo
        '
        Me.PictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox_Logo.Image = CType(resources.GetObject("PictureBox_Logo.Image"), System.Drawing.Image)
        Me.PictureBox_Logo.InitialImage = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Loading
        Me.PictureBox_Logo.Location = New System.Drawing.Point(282, 16)
        Me.PictureBox_Logo.Name = "PictureBox_Logo"
        Me.PictureBox_Logo.Size = New System.Drawing.Size(80, 136)
        Me.PictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Logo.TabIndex = 1
        Me.PictureBox_Logo.TabStop = False
        '
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_Main.Controls.Add(Me.PictureBox_AppIcon)
        Me.Panel_Main.Controls.Add(Me.Label_Title)
        Me.Panel_Main.Controls.Add(Me.PictureBox_Close)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Main.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(365, 24)
        Me.Panel_Main.TabIndex = 23
        '
        'PictureBox_AppIcon
        '
        Me.PictureBox_AppIcon.Image = CType(resources.GetObject("PictureBox_AppIcon.Image"), System.Drawing.Image)
        Me.PictureBox_AppIcon.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox_AppIcon.Name = "PictureBox_AppIcon"
        Me.PictureBox_AppIcon.Size = New System.Drawing.Size(16, 30)
        Me.PictureBox_AppIcon.TabIndex = 3
        Me.PictureBox_AppIcon.TabStop = False
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.ForeColor = System.Drawing.Color.White
        Me.Label_Title.Location = New System.Drawing.Point(27, 5)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(41, 15)
        Me.Label_Title.TabIndex = 2
        Me.Label_Title.Text = "About"
        '
        'PictureBox_Close
        '
        Me.PictureBox_Close.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Close_Grey
        Me.PictureBox_Close.Location = New System.Drawing.Point(346, 4)
        Me.PictureBox_Close.Name = "PictureBox_Close"
        Me.PictureBox_Close.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Close.TabIndex = 0
        Me.PictureBox_Close.TabStop = False
        '
        'Button_Project_Page
        '
        Me.Button_Project_Page.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_Project_Page.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button_Project_Page.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Search
        Me.Button_Project_Page.Location = New System.Drawing.Point(67, 185)
        Me.Button_Project_Page.Name = "Button_Project_Page"
        Me.Button_Project_Page.Size = New System.Drawing.Size(205, 30)
        Me.Button_Project_Page.TabIndex = 6
        Me.Button_Project_Page.TabStop = False
        Me.Button_Project_Page.Text = "Green Dragon"
        Me.Button_Project_Page.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Project_Page.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Project_Page.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(365, 220)
        Me.Controls.Add(Me.Button_Project_Page)
        Me.Controls.Add(Me.GroupBox_About)
        Me.Controls.Add(Me.Panel_Main)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.GroupBox_About.ResumeLayout(False)
        Me.GroupBox_About.PerformLayout()
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox_About As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_About As System.Windows.Forms.GroupBox
    Friend WithEvents Panel_Main As System.Windows.Forms.Panel
    Friend WithEvents PictureBox_AppIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Title As System.Windows.Forms.Label
    Friend WithEvents PictureBox_Close As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Project_Page As System.Windows.Forms.Button
End Class
