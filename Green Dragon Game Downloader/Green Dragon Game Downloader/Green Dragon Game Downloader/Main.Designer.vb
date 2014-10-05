<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolTip_Main = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Minimize = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.PictureBox_PlayOnline = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Singleplayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox_MultiPlayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox_RequiresAccount = New System.Windows.Forms.PictureBox()
        Me.ComboBox_Category = New System.Windows.Forms.ComboBox()
        Me.NotifyIcon_Main = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip_Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuItem_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuItem_News = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuItem_Downloads = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuItem_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuItem_CheckForUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuItem_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox_Category = New System.Windows.Forms.GroupBox()
        Me.GroupBox_About = New System.Windows.Forms.GroupBox()
        Me.Label_FileSize = New System.Windows.Forms.Label()
        Me.TextBox_About = New System.Windows.Forms.TextBox()
        Me.Button_youtube = New System.Windows.Forms.Button()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Button_Download = New System.Windows.Forms.Button()
        Me.TextBox_Version = New System.Windows.Forms.TextBox()
        Me.TextBox_File_Size = New System.Windows.Forms.TextBox()
        Me.Button_Website = New System.Windows.Forms.Button()
        Me.TextBox_RequiresAccount = New System.Windows.Forms.TextBox()
        Me.TextBox_Singleplayer = New System.Windows.Forms.TextBox()
        Me.TextBox_MultiPlayer = New System.Windows.Forms.TextBox()
        Me.TextBox_PlayOnline = New System.Windows.Forms.TextBox()
        Me.GroupBox_Games = New System.Windows.Forms.GroupBox()
        Me.ListView_Games = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.NotifyIcon_Requesting = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox_Search_For_Game = New System.Windows.Forms.GroupBox()
        Me.TextBox_Search_For_Game = New System.Windows.Forms.TextBox()
        Me.MenuStrip_Main = New System.Windows.Forms.MenuStrip()
        Me.ReconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.GroupBox_Screen_Shot = New System.Windows.Forms.GroupBox()
        Me.PictureBox_Game_Image = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_PlayOnline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Singleplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_MultiPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_RequiresAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_Menu.SuspendLayout()
        Me.GroupBox_Category.SuspendLayout()
        Me.GroupBox_About.SuspendLayout()
        Me.GroupBox_Games.SuspendLayout()
        Me.GroupBox_Search_For_Game.SuspendLayout()
        Me.MenuStrip_Main.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.GroupBox_Screen_Shot.SuspendLayout()
        CType(Me.PictureBox_Game_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip_Main
        '
        Me.ToolTip_Main.AutoPopDelay = 5000
        Me.ToolTip_Main.InitialDelay = 500
        Me.ToolTip_Main.ReshowDelay = 100
        Me.ToolTip_Main.ShowAlways = True
        '
        'PictureBox_AppIcon
        '
        Me.PictureBox_AppIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_AppIcon.Image = CType(resources.GetObject("PictureBox_AppIcon.Image"), System.Drawing.Image)
        Me.PictureBox_AppIcon.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox_AppIcon.Name = "PictureBox_AppIcon"
        Me.PictureBox_AppIcon.Size = New System.Drawing.Size(16, 20)
        Me.PictureBox_AppIcon.TabIndex = 3
        Me.PictureBox_AppIcon.TabStop = False
        Me.ToolTip_Main.SetToolTip(Me.PictureBox_AppIcon, "Minimize to tray")
        '
        'PictureBox_Minimize
        '
        Me.PictureBox_Minimize.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Minimize_Grey
        Me.PictureBox_Minimize.Location = New System.Drawing.Point(748, 4)
        Me.PictureBox_Minimize.Name = "PictureBox_Minimize"
        Me.PictureBox_Minimize.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Minimize.TabIndex = 1
        Me.PictureBox_Minimize.TabStop = False
        Me.ToolTip_Main.SetToolTip(Me.PictureBox_Minimize, "Minimize")
        '
        'PictureBox_Close
        '
        Me.PictureBox_Close.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Close_Grey
        Me.PictureBox_Close.Location = New System.Drawing.Point(770, 4)
        Me.PictureBox_Close.Name = "PictureBox_Close"
        Me.PictureBox_Close.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Close.TabIndex = 0
        Me.PictureBox_Close.TabStop = False
        Me.ToolTip_Main.SetToolTip(Me.PictureBox_Close, "Close")
        '
        'PictureBox_PlayOnline
        '
        Me.PictureBox_PlayOnline.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox_PlayOnline.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Play_Online
        Me.PictureBox_PlayOnline.Location = New System.Drawing.Point(112, 10)
        Me.PictureBox_PlayOnline.Name = "PictureBox_PlayOnline"
        Me.PictureBox_PlayOnline.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_PlayOnline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_PlayOnline.TabIndex = 8
        Me.PictureBox_PlayOnline.TabStop = False
        Me.ToolTip_Main.SetToolTip(Me.PictureBox_PlayOnline, "Play online")
        '
        'PictureBox_Singleplayer
        '
        Me.PictureBox_Singleplayer.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox_Singleplayer.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Singleplayer
        Me.PictureBox_Singleplayer.Location = New System.Drawing.Point(6, 10)
        Me.PictureBox_Singleplayer.Name = "PictureBox_Singleplayer"
        Me.PictureBox_Singleplayer.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Singleplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Singleplayer.TabIndex = 4
        Me.PictureBox_Singleplayer.TabStop = False
        Me.ToolTip_Main.SetToolTip(Me.PictureBox_Singleplayer, "Single player")
        '
        'PictureBox_MultiPlayer
        '
        Me.PictureBox_MultiPlayer.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox_MultiPlayer.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Multiplayer
        Me.PictureBox_MultiPlayer.Location = New System.Drawing.Point(59, 10)
        Me.PictureBox_MultiPlayer.Name = "PictureBox_MultiPlayer"
        Me.PictureBox_MultiPlayer.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_MultiPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_MultiPlayer.TabIndex = 6
        Me.PictureBox_MultiPlayer.TabStop = False
        Me.ToolTip_Main.SetToolTip(Me.PictureBox_MultiPlayer, "Multi player")
        '
        'PictureBox_RequiresAccount
        '
        Me.PictureBox_RequiresAccount.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox_RequiresAccount.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Requires_Account
        Me.PictureBox_RequiresAccount.Location = New System.Drawing.Point(165, 10)
        Me.PictureBox_RequiresAccount.Name = "PictureBox_RequiresAccount"
        Me.PictureBox_RequiresAccount.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_RequiresAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_RequiresAccount.TabIndex = 10
        Me.PictureBox_RequiresAccount.TabStop = False
        Me.ToolTip_Main.SetToolTip(Me.PictureBox_RequiresAccount, "Requires account")
        '
        'ComboBox_Category
        '
        Me.ComboBox_Category.BackColor = System.Drawing.Color.White
        Me.ComboBox_Category.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox_Category.DropDownHeight = 195
        Me.ComboBox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Category.IntegralHeight = False
        Me.ComboBox_Category.Location = New System.Drawing.Point(3, 16)
        Me.ComboBox_Category.Name = "ComboBox_Category"
        Me.ComboBox_Category.Size = New System.Drawing.Size(269, 21)
        Me.ComboBox_Category.Sorted = True
        Me.ComboBox_Category.TabIndex = 0
        Me.ComboBox_Category.TabStop = False
        '
        'NotifyIcon_Main
        '
        Me.NotifyIcon_Main.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon_Main.BalloonTipTitle = "Game Downloader"
        Me.NotifyIcon_Main.ContextMenuStrip = Me.ContextMenuStrip_Menu
        Me.NotifyIcon_Main.Icon = CType(resources.GetObject("NotifyIcon_Main.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_Main.Text = "Game Downloader" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right-Click for options menu."
        '
        'ContextMenuStrip_Menu
        '
        Me.ContextMenuStrip_Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ContextMenuStrip_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextMenuItem_About, Me.ContextMenuItem_News, Me.ContextMenuItem_Downloads, Me.ContextMenuItem_Settings, Me.ContextMenuItem_CheckForUpdates, Me.ToolStripSeparator1, Me.ContextMenuItem_Exit})
        Me.ContextMenuStrip_Menu.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip_Menu.Size = New System.Drawing.Size(184, 142)
        '
        'ContextMenuItem_About
        '
        Me.ContextMenuItem_About.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ContextMenuItem_About.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.About
        Me.ContextMenuItem_About.Name = "ContextMenuItem_About"
        Me.ContextMenuItem_About.Size = New System.Drawing.Size(183, 22)
        Me.ContextMenuItem_About.Text = "About"
        '
        'ContextMenuItem_News
        '
        Me.ContextMenuItem_News.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ContextMenuItem_News.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.News
        Me.ContextMenuItem_News.Name = "ContextMenuItem_News"
        Me.ContextMenuItem_News.Size = New System.Drawing.Size(183, 22)
        Me.ContextMenuItem_News.Text = "News"
        '
        'ContextMenuItem_Downloads
        '
        Me.ContextMenuItem_Downloads.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ContextMenuItem_Downloads.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Open_Download_Directory
        Me.ContextMenuItem_Downloads.Name = "ContextMenuItem_Downloads"
        Me.ContextMenuItem_Downloads.Size = New System.Drawing.Size(183, 22)
        Me.ContextMenuItem_Downloads.Text = "Downloads"
        '
        'ContextMenuItem_Settings
        '
        Me.ContextMenuItem_Settings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ContextMenuItem_Settings.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Settings
        Me.ContextMenuItem_Settings.Name = "ContextMenuItem_Settings"
        Me.ContextMenuItem_Settings.Size = New System.Drawing.Size(183, 22)
        Me.ContextMenuItem_Settings.Text = "Settings"
        '
        'ContextMenuItem_CheckForUpdates
        '
        Me.ContextMenuItem_CheckForUpdates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ContextMenuItem_CheckForUpdates.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Check_For_Updates
        Me.ContextMenuItem_CheckForUpdates.Name = "ContextMenuItem_CheckForUpdates"
        Me.ContextMenuItem_CheckForUpdates.Size = New System.Drawing.Size(183, 22)
        Me.ContextMenuItem_CheckForUpdates.Text = "Check For Updates"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.Black
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'ContextMenuItem_Exit
        '
        Me.ContextMenuItem_Exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ContextMenuItem_Exit.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Exiting
        Me.ContextMenuItem_Exit.Name = "ContextMenuItem_Exit"
        Me.ContextMenuItem_Exit.Size = New System.Drawing.Size(183, 22)
        Me.ContextMenuItem_Exit.Text = "Exit"
        '
        'GroupBox_Category
        '
        Me.GroupBox_Category.Controls.Add(Me.ComboBox_Category)
        Me.GroupBox_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupBox_Category.Location = New System.Drawing.Point(5, 100)
        Me.GroupBox_Category.Name = "GroupBox_Category"
        Me.GroupBox_Category.Size = New System.Drawing.Size(275, 43)
        Me.GroupBox_Category.TabIndex = 7
        Me.GroupBox_Category.TabStop = False
        Me.GroupBox_Category.Text = "Category"
        '
        'GroupBox_About
        '
        Me.GroupBox_About.Controls.Add(Me.Label_FileSize)
        Me.GroupBox_About.Controls.Add(Me.TextBox_About)
        Me.GroupBox_About.Controls.Add(Me.Button_youtube)
        Me.GroupBox_About.Controls.Add(Me.Label_Version)
        Me.GroupBox_About.Controls.Add(Me.Button_Download)
        Me.GroupBox_About.Controls.Add(Me.TextBox_Version)
        Me.GroupBox_About.Controls.Add(Me.TextBox_File_Size)
        Me.GroupBox_About.Controls.Add(Me.Button_Website)
        Me.GroupBox_About.Controls.Add(Me.TextBox_RequiresAccount)
        Me.GroupBox_About.Controls.Add(Me.PictureBox_PlayOnline)
        Me.GroupBox_About.Controls.Add(Me.PictureBox_Singleplayer)
        Me.GroupBox_About.Controls.Add(Me.TextBox_Singleplayer)
        Me.GroupBox_About.Controls.Add(Me.TextBox_MultiPlayer)
        Me.GroupBox_About.Controls.Add(Me.TextBox_PlayOnline)
        Me.GroupBox_About.Controls.Add(Me.PictureBox_MultiPlayer)
        Me.GroupBox_About.Controls.Add(Me.PictureBox_RequiresAccount)
        Me.GroupBox_About.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_About.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox_About.Location = New System.Drawing.Point(286, 328)
        Me.GroupBox_About.Name = "GroupBox_About"
        Me.GroupBox_About.Size = New System.Drawing.Size(500, 174)
        Me.GroupBox_About.TabIndex = 8
        Me.GroupBox_About.TabStop = False
        '
        'Label_FileSize
        '
        Me.Label_FileSize.AutoSize = True
        Me.Label_FileSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FileSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label_FileSize.Location = New System.Drawing.Point(363, 13)
        Me.Label_FileSize.Name = "Label_FileSize"
        Me.Label_FileSize.Size = New System.Drawing.Size(59, 13)
        Me.Label_FileSize.TabIndex = 23
        Me.Label_FileSize.Text = "File Size:"
        '
        'TextBox_About
        '
        Me.TextBox_About.BackColor = System.Drawing.Color.White
        Me.TextBox_About.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_About.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_About.Location = New System.Drawing.Point(6, 32)
        Me.TextBox_About.Multiline = True
        Me.TextBox_About.Name = "TextBox_About"
        Me.TextBox_About.ReadOnly = True
        Me.TextBox_About.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_About.Size = New System.Drawing.Size(491, 102)
        Me.TextBox_About.TabIndex = 2
        Me.TextBox_About.TabStop = False
        '
        'Button_youtube
        '
        Me.Button_youtube.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_youtube.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button_youtube.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Youtube_Search
        Me.Button_youtube.Location = New System.Drawing.Point(6, 138)
        Me.Button_youtube.Name = "Button_youtube"
        Me.Button_youtube.Size = New System.Drawing.Size(155, 30)
        Me.Button_youtube.TabIndex = 3
        Me.Button_youtube.TabStop = False
        Me.Button_youtube.Text = "Youtube"
        Me.Button_youtube.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_youtube.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_youtube.UseVisualStyleBackColor = True
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label_Version.Location = New System.Drawing.Point(218, 13)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(53, 13)
        Me.Label_Version.TabIndex = 22
        Me.Label_Version.Text = "Version:"
        '
        'Button_Download
        '
        Me.Button_Download.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_Download.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button_Download.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Save
        Me.Button_Download.Location = New System.Drawing.Point(342, 138)
        Me.Button_Download.Name = "Button_Download"
        Me.Button_Download.Size = New System.Drawing.Size(155, 30)
        Me.Button_Download.TabIndex = 6
        Me.Button_Download.TabStop = False
        Me.Button_Download.Text = "Download"
        Me.Button_Download.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Download.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Download.UseVisualStyleBackColor = True
        '
        'TextBox_Version
        '
        Me.TextBox_Version.BackColor = System.Drawing.Color.White
        Me.TextBox_Version.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Version.Location = New System.Drawing.Point(277, 13)
        Me.TextBox_Version.Name = "TextBox_Version"
        Me.TextBox_Version.ReadOnly = True
        Me.TextBox_Version.Size = New System.Drawing.Size(80, 13)
        Me.TextBox_Version.TabIndex = 2
        Me.TextBox_Version.TabStop = False
        Me.TextBox_Version.WordWrap = False
        '
        'TextBox_File_Size
        '
        Me.TextBox_File_Size.BackColor = System.Drawing.Color.White
        Me.TextBox_File_Size.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_File_Size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_File_Size.Location = New System.Drawing.Point(428, 13)
        Me.TextBox_File_Size.Name = "TextBox_File_Size"
        Me.TextBox_File_Size.ReadOnly = True
        Me.TextBox_File_Size.Size = New System.Drawing.Size(60, 13)
        Me.TextBox_File_Size.TabIndex = 2
        Me.TextBox_File_Size.TabStop = False
        Me.TextBox_File_Size.WordWrap = False
        '
        'Button_Website
        '
        Me.Button_Website.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_Website.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button_Website.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Search
        Me.Button_Website.Location = New System.Drawing.Point(174, 138)
        Me.Button_Website.Name = "Button_Website"
        Me.Button_Website.Size = New System.Drawing.Size(155, 30)
        Me.Button_Website.TabIndex = 4
        Me.Button_Website.TabStop = False
        Me.Button_Website.Text = "Website"
        Me.Button_Website.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Website.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Website.UseVisualStyleBackColor = True
        '
        'TextBox_RequiresAccount
        '
        Me.TextBox_RequiresAccount.BackColor = System.Drawing.Color.White
        Me.TextBox_RequiresAccount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_RequiresAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_RequiresAccount.Location = New System.Drawing.Point(187, 13)
        Me.TextBox_RequiresAccount.Name = "TextBox_RequiresAccount"
        Me.TextBox_RequiresAccount.ReadOnly = True
        Me.TextBox_RequiresAccount.Size = New System.Drawing.Size(25, 13)
        Me.TextBox_RequiresAccount.TabIndex = 11
        Me.TextBox_RequiresAccount.TabStop = False
        Me.TextBox_RequiresAccount.WordWrap = False
        '
        'TextBox_Singleplayer
        '
        Me.TextBox_Singleplayer.BackColor = System.Drawing.Color.White
        Me.TextBox_Singleplayer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Singleplayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_Singleplayer.Location = New System.Drawing.Point(28, 13)
        Me.TextBox_Singleplayer.Name = "TextBox_Singleplayer"
        Me.TextBox_Singleplayer.ReadOnly = True
        Me.TextBox_Singleplayer.Size = New System.Drawing.Size(25, 13)
        Me.TextBox_Singleplayer.TabIndex = 5
        Me.TextBox_Singleplayer.TabStop = False
        Me.TextBox_Singleplayer.WordWrap = False
        '
        'TextBox_MultiPlayer
        '
        Me.TextBox_MultiPlayer.BackColor = System.Drawing.Color.White
        Me.TextBox_MultiPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_MultiPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_MultiPlayer.Location = New System.Drawing.Point(81, 13)
        Me.TextBox_MultiPlayer.Name = "TextBox_MultiPlayer"
        Me.TextBox_MultiPlayer.ReadOnly = True
        Me.TextBox_MultiPlayer.Size = New System.Drawing.Size(25, 13)
        Me.TextBox_MultiPlayer.TabIndex = 7
        Me.TextBox_MultiPlayer.TabStop = False
        Me.TextBox_MultiPlayer.WordWrap = False
        '
        'TextBox_PlayOnline
        '
        Me.TextBox_PlayOnline.BackColor = System.Drawing.Color.White
        Me.TextBox_PlayOnline.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_PlayOnline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_PlayOnline.Location = New System.Drawing.Point(134, 13)
        Me.TextBox_PlayOnline.Name = "TextBox_PlayOnline"
        Me.TextBox_PlayOnline.ReadOnly = True
        Me.TextBox_PlayOnline.Size = New System.Drawing.Size(25, 13)
        Me.TextBox_PlayOnline.TabIndex = 9
        Me.TextBox_PlayOnline.TabStop = False
        Me.TextBox_PlayOnline.WordWrap = False
        '
        'GroupBox_Games
        '
        Me.GroupBox_Games.Controls.Add(Me.ListView_Games)
        Me.GroupBox_Games.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Games.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupBox_Games.Location = New System.Drawing.Point(5, 149)
        Me.GroupBox_Games.Name = "GroupBox_Games"
        Me.GroupBox_Games.Size = New System.Drawing.Size(275, 353)
        Me.GroupBox_Games.TabIndex = 9
        Me.GroupBox_Games.TabStop = False
        Me.GroupBox_Games.Text = "Games"
        '
        'ListView_Games
        '
        Me.ListView_Games.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView_Games.BackColor = System.Drawing.Color.White
        Me.ListView_Games.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_Games.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView_Games.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_Games.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ListView_Games.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView_Games.HideSelection = False
        Me.ListView_Games.LargeImageList = Me.ImageList_Main
        Me.ListView_Games.Location = New System.Drawing.Point(3, 16)
        Me.ListView_Games.MultiSelect = False
        Me.ListView_Games.Name = "ListView_Games"
        Me.ListView_Games.Size = New System.Drawing.Size(269, 334)
        Me.ListView_Games.SmallImageList = Me.ImageList_Main
        Me.ListView_Games.TabIndex = 22
        Me.ListView_Games.TileSize = New System.Drawing.Size(128, 128)
        Me.ListView_Games.UseCompatibleStateImageBehavior = False
        Me.ListView_Games.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 240
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList_Main.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        '
        'NotifyIcon_Requesting
        '
        Me.NotifyIcon_Requesting.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon_Requesting.BalloonTipTitle = "Game Downloader"
        Me.NotifyIcon_Requesting.Icon = CType(resources.GetObject("NotifyIcon_Requesting.Icon"), System.Drawing.Icon)
        '
        'GroupBox_Search_For_Game
        '
        Me.GroupBox_Search_For_Game.Controls.Add(Me.TextBox_Search_For_Game)
        Me.GroupBox_Search_For_Game.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Search_For_Game.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupBox_Search_For_Game.Location = New System.Drawing.Point(5, 51)
        Me.GroupBox_Search_For_Game.Name = "GroupBox_Search_For_Game"
        Me.GroupBox_Search_For_Game.Size = New System.Drawing.Size(275, 43)
        Me.GroupBox_Search_For_Game.TabIndex = 19
        Me.GroupBox_Search_For_Game.TabStop = False
        Me.GroupBox_Search_For_Game.Text = "Search For Game"
        '
        'TextBox_Search_For_Game
        '
        Me.TextBox_Search_For_Game.AcceptsReturn = True
        Me.TextBox_Search_For_Game.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TextBox_Search_For_Game.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox_Search_For_Game.BackColor = System.Drawing.Color.White
        Me.TextBox_Search_For_Game.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Search_For_Game.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Search_For_Game.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.TextBox_Search_For_Game.Location = New System.Drawing.Point(3, 16)
        Me.TextBox_Search_For_Game.Name = "TextBox_Search_For_Game"
        Me.TextBox_Search_For_Game.Size = New System.Drawing.Size(269, 20)
        Me.TextBox_Search_For_Game.TabIndex = 2
        Me.TextBox_Search_For_Game.TabStop = False
        Me.TextBox_Search_For_Game.WordWrap = False
        '
        'MenuStrip_Main
        '
        Me.MenuStrip_Main.BackColor = System.Drawing.Color.White
        Me.MenuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReconnectToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.DownloadsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip_Main.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip_Main.Name = "MenuStrip_Main"
        Me.MenuStrip_Main.Size = New System.Drawing.Size(790, 24)
        Me.MenuStrip_Main.TabIndex = 20
        '
        'ReconnectToolStripMenuItem
        '
        Me.ReconnectToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReconnectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ReconnectToolStripMenuItem.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Reconnect
        Me.ReconnectToolStripMenuItem.Name = "ReconnectToolStripMenuItem"
        Me.ReconnectToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ReconnectToolStripMenuItem.Text = "Reconnect"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CheckForUpdatesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.CheckForUpdatesToolStripMenuItem.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Check_For_Updates
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.SettingsToolStripMenuItem.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Settings
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'DownloadsToolStripMenuItem
        '
        Me.DownloadsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DownloadsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.DownloadsToolStripMenuItem.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Open_Download_Directory
        Me.DownloadsToolStripMenuItem.Name = "DownloadsToolStripMenuItem"
        Me.DownloadsToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.DownloadsToolStripMenuItem.Text = "Downloads"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.AboutToolStripMenuItem.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.About
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_Main.Controls.Add(Me.PictureBox_AppIcon)
        Me.Panel_Main.Controls.Add(Me.Label_Title)
        Me.Panel_Main.Controls.Add(Me.PictureBox_Minimize)
        Me.Panel_Main.Controls.Add(Me.PictureBox_Close)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Main.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Panel_Main.ForeColor = System.Drawing.Color.White
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(790, 24)
        Me.Panel_Main.TabIndex = 21
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Location = New System.Drawing.Point(27, 5)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(193, 15)
        Me.Label_Title.TabIndex = 2
        Me.Label_Title.Text = "Green Dragon Game Downloader"
        '
        'GroupBox_Screen_Shot
        '
        Me.GroupBox_Screen_Shot.Controls.Add(Me.PictureBox_Game_Image)
        Me.GroupBox_Screen_Shot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Screen_Shot.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox_Screen_Shot.Location = New System.Drawing.Point(286, 51)
        Me.GroupBox_Screen_Shot.Name = "GroupBox_Screen_Shot"
        Me.GroupBox_Screen_Shot.Size = New System.Drawing.Size(500, 271)
        Me.GroupBox_Screen_Shot.TabIndex = 22
        Me.GroupBox_Screen_Shot.TabStop = False
        '
        'PictureBox_Game_Image
        '
        Me.PictureBox_Game_Image.BackColor = System.Drawing.Color.White
        Me.PictureBox_Game_Image.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_Game_Image.InitialImage = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Loading
        Me.PictureBox_Game_Image.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox_Game_Image.Name = "PictureBox_Game_Image"
        Me.PictureBox_Game_Image.Size = New System.Drawing.Size(494, 252)
        Me.PictureBox_Game_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Game_Image.TabIndex = 1
        Me.PictureBox_Game_Image.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(790, 505)
        Me.Controls.Add(Me.MenuStrip_Main)
        Me.Controls.Add(Me.GroupBox_Screen_Shot)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.GroupBox_Search_For_Game)
        Me.Controls.Add(Me.GroupBox_Category)
        Me.Controls.Add(Me.GroupBox_About)
        Me.Controls.Add(Me.GroupBox_Games)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip_Main
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Downloader"
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_PlayOnline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Singleplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_MultiPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_RequiresAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_Menu.ResumeLayout(False)
        Me.GroupBox_Category.ResumeLayout(False)
        Me.GroupBox_About.ResumeLayout(False)
        Me.GroupBox_About.PerformLayout()
        Me.GroupBox_Games.ResumeLayout(False)
        Me.GroupBox_Search_For_Game.ResumeLayout(False)
        Me.GroupBox_Search_For_Game.PerformLayout()
        Me.MenuStrip_Main.ResumeLayout(False)
        Me.MenuStrip_Main.PerformLayout()
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
        Me.GroupBox_Screen_Shot.ResumeLayout(False)
        CType(Me.PictureBox_Game_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Download As System.Windows.Forms.Button
    Friend WithEvents ToolTip_Main As System.Windows.Forms.ToolTip
    Friend WithEvents Button_Website As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon_Main As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip_Menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuItem_Settings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuItem_Exit As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents GroupBox_Category As System.Windows.Forms.GroupBox
    Public WithEvents ComboBox_Category As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox_About As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_About As System.Windows.Forms.TextBox
    Public WithEvents GroupBox_Games As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Version As System.Windows.Forms.TextBox
    Friend WithEvents NotifyIcon_Requesting As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button_youtube As System.Windows.Forms.Button
    Friend WithEvents TextBox_Singleplayer As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_Singleplayer As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_RequiresAccount As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_RequiresAccount As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_PlayOnline As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_PlayOnline As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_MultiPlayer As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_MultiPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuItem_CheckForUpdates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuItem_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox_File_Size As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_Search_For_Game As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Search_For_Game As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip_Main As System.Windows.Forms.MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuItem_News As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel_Main As System.Windows.Forms.Panel
    Friend WithEvents PictureBox_Minimize As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Close As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_AppIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Title As System.Windows.Forms.Label
    Friend WithEvents DownloadsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuItem_Downloads As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_FileSize As System.Windows.Forms.Label
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList
    Friend WithEvents ListView_Games As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox_Screen_Shot As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_Game_Image As System.Windows.Forms.PictureBox

End Class
