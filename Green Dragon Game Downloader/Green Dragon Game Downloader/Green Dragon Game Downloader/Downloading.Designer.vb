<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Downloading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Downloading))
        Me.ProgressBar_Downloading = New System.Windows.Forms.ProgressBar()
        Me.Label_File_Name = New System.Windows.Forms.Label()
        Me.Label_Total_Size = New System.Windows.Forms.Label()
        Me.Label_Size_Completed = New System.Windows.Forms.Label()
        Me.Label_Speed = New System.Windows.Forms.Label()
        Me.Label_Time_Remaining = New System.Windows.Forms.Label()
        Me.Label_Size_Remaining = New System.Windows.Forms.Label()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.TextBox_RequiresAccount = New System.Windows.Forms.TextBox()
        Me.TextBox_PlayOnline = New System.Windows.Forms.TextBox()
        Me.TextBox_MultiPlayer = New System.Windows.Forms.TextBox()
        Me.TextBox_Singleplayer = New System.Windows.Forms.TextBox()
        Me.ToolTip_Downloading = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox_RequiresAccount = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Singleplayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox_MultiPlayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox_PlayOnline = New System.Windows.Forms.PictureBox()
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Cancel_Download = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Open_Download_Directory = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Compact = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Always_On_Top = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Website = New System.Windows.Forms.PictureBox()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.Version_Label = New System.Windows.Forms.Label()
        Me.File_Name_Label = New System.Windows.Forms.Label()
        Me.Total_Size_Label = New System.Windows.Forms.Label()
        Me.Speed_Label = New System.Windows.Forms.Label()
        Me.Time_Remaining_Label = New System.Windows.Forms.Label()
        Me.Size_Remaining_Label = New System.Windows.Forms.Label()
        Me.Size_Completed_Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox_Host_Logo = New System.Windows.Forms.PictureBox()
        Me.Label_Hosted_By = New System.Windows.Forms.Label()
        Me.Hosted_By_Label = New System.Windows.Forms.Label()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.PictureBox_Minimize = New System.Windows.Forms.PictureBox()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer_Speed = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon_Downloading = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PictureBox_Game_Image = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_RequiresAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Singleplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_MultiPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_PlayOnline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Cancel_Download, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Open_Download_Directory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Compact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Always_On_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Website, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox_Host_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Main.SuspendLayout()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox_Game_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar_Downloading
        '
        Me.ProgressBar_Downloading.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ProgressBar_Downloading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProgressBar_Downloading.Location = New System.Drawing.Point(9, 32)
        Me.ProgressBar_Downloading.MarqueeAnimationSpeed = 0
        Me.ProgressBar_Downloading.Name = "ProgressBar_Downloading"
        Me.ProgressBar_Downloading.Size = New System.Drawing.Size(447, 12)
        Me.ProgressBar_Downloading.Step = 1
        Me.ProgressBar_Downloading.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar_Downloading.TabIndex = 0
        '
        'Label_File_Name
        '
        Me.Label_File_Name.AutoSize = True
        Me.Label_File_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_File_Name.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label_File_Name.Location = New System.Drawing.Point(81, 42)
        Me.Label_File_Name.Name = "Label_File_Name"
        Me.Label_File_Name.Size = New System.Drawing.Size(19, 13)
        Me.Label_File_Name.TabIndex = 1
        Me.Label_File_Name.Text = "***"
        '
        'Label_Total_Size
        '
        Me.Label_Total_Size.AutoSize = True
        Me.Label_Total_Size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Total_Size.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label_Total_Size.Location = New System.Drawing.Point(82, 55)
        Me.Label_Total_Size.Name = "Label_Total_Size"
        Me.Label_Total_Size.Size = New System.Drawing.Size(19, 13)
        Me.Label_Total_Size.TabIndex = 4
        Me.Label_Total_Size.Text = "***"
        '
        'Label_Size_Completed
        '
        Me.Label_Size_Completed.AutoSize = True
        Me.Label_Size_Completed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Size_Completed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label_Size_Completed.Location = New System.Drawing.Point(109, 47)
        Me.Label_Size_Completed.Name = "Label_Size_Completed"
        Me.Label_Size_Completed.Size = New System.Drawing.Size(68, 13)
        Me.Label_Size_Completed.TabIndex = 5
        Me.Label_Size_Completed.Text = "Calculating..."
        '
        'Label_Speed
        '
        Me.Label_Speed.AutoSize = True
        Me.Label_Speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Speed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label_Speed.Location = New System.Drawing.Point(59, 16)
        Me.Label_Speed.Name = "Label_Speed"
        Me.Label_Speed.Size = New System.Drawing.Size(68, 13)
        Me.Label_Speed.TabIndex = 6
        Me.Label_Speed.Text = "Calculating..."
        '
        'Label_Time_Remaining
        '
        Me.Label_Time_Remaining.AutoSize = True
        Me.Label_Time_Remaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Time_Remaining.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label_Time_Remaining.Location = New System.Drawing.Point(369, 16)
        Me.Label_Time_Remaining.Name = "Label_Time_Remaining"
        Me.Label_Time_Remaining.Size = New System.Drawing.Size(68, 13)
        Me.Label_Time_Remaining.TabIndex = 7
        Me.Label_Time_Remaining.Text = "Calculating..."
        '
        'Label_Size_Remaining
        '
        Me.Label_Size_Remaining.AutoSize = True
        Me.Label_Size_Remaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Size_Remaining.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label_Size_Remaining.Location = New System.Drawing.Point(391, 47)
        Me.Label_Size_Remaining.Name = "Label_Size_Remaining"
        Me.Label_Size_Remaining.Size = New System.Drawing.Size(68, 13)
        Me.Label_Size_Remaining.TabIndex = 8
        Me.Label_Size_Remaining.Text = "Calculating..."
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label_Name.Location = New System.Drawing.Point(59, 16)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(19, 13)
        Me.Label_Name.TabIndex = 11
        Me.Label_Name.Text = "***"
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Version.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label_Version.Location = New System.Drawing.Point(69, 29)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(19, 13)
        Me.Label_Version.TabIndex = 12
        Me.Label_Version.Text = "***"
        '
        'TextBox_RequiresAccount
        '
        Me.TextBox_RequiresAccount.BackColor = System.Drawing.Color.White
        Me.TextBox_RequiresAccount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_RequiresAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_RequiresAccount.Location = New System.Drawing.Point(403, 90)
        Me.TextBox_RequiresAccount.Name = "TextBox_RequiresAccount"
        Me.TextBox_RequiresAccount.ReadOnly = True
        Me.TextBox_RequiresAccount.Size = New System.Drawing.Size(25, 13)
        Me.TextBox_RequiresAccount.TabIndex = 20
        Me.TextBox_RequiresAccount.TabStop = False
        Me.TextBox_RequiresAccount.WordWrap = False
        '
        'TextBox_PlayOnline
        '
        Me.TextBox_PlayOnline.BackColor = System.Drawing.Color.White
        Me.TextBox_PlayOnline.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_PlayOnline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_PlayOnline.Location = New System.Drawing.Point(291, 90)
        Me.TextBox_PlayOnline.Name = "TextBox_PlayOnline"
        Me.TextBox_PlayOnline.ReadOnly = True
        Me.TextBox_PlayOnline.Size = New System.Drawing.Size(25, 13)
        Me.TextBox_PlayOnline.TabIndex = 18
        Me.TextBox_PlayOnline.TabStop = False
        Me.TextBox_PlayOnline.WordWrap = False
        '
        'TextBox_MultiPlayer
        '
        Me.TextBox_MultiPlayer.BackColor = System.Drawing.Color.White
        Me.TextBox_MultiPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_MultiPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_MultiPlayer.Location = New System.Drawing.Point(179, 90)
        Me.TextBox_MultiPlayer.Name = "TextBox_MultiPlayer"
        Me.TextBox_MultiPlayer.ReadOnly = True
        Me.TextBox_MultiPlayer.Size = New System.Drawing.Size(25, 13)
        Me.TextBox_MultiPlayer.TabIndex = 16
        Me.TextBox_MultiPlayer.TabStop = False
        Me.TextBox_MultiPlayer.WordWrap = False
        '
        'TextBox_Singleplayer
        '
        Me.TextBox_Singleplayer.BackColor = System.Drawing.Color.White
        Me.TextBox_Singleplayer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Singleplayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_Singleplayer.Location = New System.Drawing.Point(68, 90)
        Me.TextBox_Singleplayer.Name = "TextBox_Singleplayer"
        Me.TextBox_Singleplayer.ReadOnly = True
        Me.TextBox_Singleplayer.Size = New System.Drawing.Size(25, 13)
        Me.TextBox_Singleplayer.TabIndex = 14
        Me.TextBox_Singleplayer.TabStop = False
        Me.TextBox_Singleplayer.WordWrap = False
        '
        'ToolTip_Downloading
        '
        Me.ToolTip_Downloading.AutoPopDelay = 5000
        Me.ToolTip_Downloading.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ToolTip_Downloading.ForeColor = System.Drawing.Color.White
        Me.ToolTip_Downloading.InitialDelay = 500
        Me.ToolTip_Downloading.ReshowDelay = 100
        Me.ToolTip_Downloading.ShowAlways = True
        '
        'PictureBox_RequiresAccount
        '
        Me.PictureBox_RequiresAccount.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox_RequiresAccount.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Requires_Account
        Me.PictureBox_RequiresAccount.Location = New System.Drawing.Point(381, 90)
        Me.PictureBox_RequiresAccount.Name = "PictureBox_RequiresAccount"
        Me.PictureBox_RequiresAccount.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_RequiresAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_RequiresAccount.TabIndex = 19
        Me.PictureBox_RequiresAccount.TabStop = False
        Me.ToolTip_Downloading.SetToolTip(Me.PictureBox_RequiresAccount, "Requires account")
        '
        'PictureBox_Singleplayer
        '
        Me.PictureBox_Singleplayer.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox_Singleplayer.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Singleplayer
        Me.PictureBox_Singleplayer.Location = New System.Drawing.Point(46, 90)
        Me.PictureBox_Singleplayer.Name = "PictureBox_Singleplayer"
        Me.PictureBox_Singleplayer.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Singleplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Singleplayer.TabIndex = 13
        Me.PictureBox_Singleplayer.TabStop = False
        Me.ToolTip_Downloading.SetToolTip(Me.PictureBox_Singleplayer, "Single player")
        '
        'PictureBox_MultiPlayer
        '
        Me.PictureBox_MultiPlayer.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox_MultiPlayer.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Multiplayer
        Me.PictureBox_MultiPlayer.Location = New System.Drawing.Point(157, 90)
        Me.PictureBox_MultiPlayer.Name = "PictureBox_MultiPlayer"
        Me.PictureBox_MultiPlayer.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_MultiPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_MultiPlayer.TabIndex = 15
        Me.PictureBox_MultiPlayer.TabStop = False
        Me.ToolTip_Downloading.SetToolTip(Me.PictureBox_MultiPlayer, "Multi player")
        '
        'PictureBox_PlayOnline
        '
        Me.PictureBox_PlayOnline.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox_PlayOnline.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Play_Online
        Me.PictureBox_PlayOnline.Location = New System.Drawing.Point(269, 90)
        Me.PictureBox_PlayOnline.Name = "PictureBox_PlayOnline"
        Me.PictureBox_PlayOnline.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_PlayOnline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_PlayOnline.TabIndex = 17
        Me.PictureBox_PlayOnline.TabStop = False
        Me.ToolTip_Downloading.SetToolTip(Me.PictureBox_PlayOnline, "Play online")
        '
        'PictureBox_AppIcon
        '
        Me.PictureBox_AppIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_AppIcon.Image = CType(resources.GetObject("PictureBox_AppIcon.Image"), System.Drawing.Image)
        Me.PictureBox_AppIcon.InitialImage = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Loading
        Me.PictureBox_AppIcon.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox_AppIcon.Name = "PictureBox_AppIcon"
        Me.PictureBox_AppIcon.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_AppIcon.TabIndex = 3
        Me.PictureBox_AppIcon.TabStop = False
        Me.ToolTip_Downloading.SetToolTip(Me.PictureBox_AppIcon, "Minimized to tray")
        '
        'PictureBox_Cancel_Download
        '
        Me.PictureBox_Cancel_Download.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Cancel_Download.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Cancel
        Me.PictureBox_Cancel_Download.Location = New System.Drawing.Point(409, 4)
        Me.PictureBox_Cancel_Download.Name = "PictureBox_Cancel_Download"
        Me.PictureBox_Cancel_Download.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Cancel_Download.TabIndex = 9
        Me.PictureBox_Cancel_Download.TabStop = False
        Me.ToolTip_Downloading.SetToolTip(Me.PictureBox_Cancel_Download, "Cancel Download")
        '
        'PictureBox_Open_Download_Directory
        '
        Me.PictureBox_Open_Download_Directory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Open_Download_Directory.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Open_Download_Directory
        Me.PictureBox_Open_Download_Directory.Location = New System.Drawing.Point(431, 4)
        Me.PictureBox_Open_Download_Directory.Name = "PictureBox_Open_Download_Directory"
        Me.PictureBox_Open_Download_Directory.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Open_Download_Directory.TabIndex = 8
        Me.PictureBox_Open_Download_Directory.TabStop = False
        Me.ToolTip_Downloading.SetToolTip(Me.PictureBox_Open_Download_Directory, "Open Download Directory")
        '
        'PictureBox_Compact
        '
        Me.PictureBox_Compact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Compact.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Compact_On
        Me.PictureBox_Compact.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox_Compact.Name = "PictureBox_Compact"
        Me.PictureBox_Compact.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Compact.TabIndex = 6
        Me.PictureBox_Compact.TabStop = False
        Me.ToolTip_Downloading.SetToolTip(Me.PictureBox_Compact, "Compact")
        '
        'PictureBox_Always_On_Top
        '
        Me.PictureBox_Always_On_Top.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Always_On_Top.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Always_On_Top_Off
        Me.PictureBox_Always_On_Top.Location = New System.Drawing.Point(27, 4)
        Me.PictureBox_Always_On_Top.Name = "PictureBox_Always_On_Top"
        Me.PictureBox_Always_On_Top.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Always_On_Top.TabIndex = 5
        Me.PictureBox_Always_On_Top.TabStop = False
        Me.ToolTip_Downloading.SetToolTip(Me.PictureBox_Always_On_Top, "Always on top")
        '
        'PictureBox_Website
        '
        Me.PictureBox_Website.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Website.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Search
        Me.PictureBox_Website.Location = New System.Drawing.Point(453, 4)
        Me.PictureBox_Website.Name = "PictureBox_Website"
        Me.PictureBox_Website.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Website.TabIndex = 0
        Me.PictureBox_Website.TabStop = False
        Me.ToolTip_Downloading.SetToolTip(Me.PictureBox_Website, "Website")
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Name_Label.Location = New System.Drawing.Point(10, 16)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(43, 13)
        Me.Name_Label.TabIndex = 21
        Me.Name_Label.Text = "Name:"
        '
        'Version_Label
        '
        Me.Version_Label.AutoSize = True
        Me.Version_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Version_Label.Location = New System.Drawing.Point(10, 29)
        Me.Version_Label.Name = "Version_Label"
        Me.Version_Label.Size = New System.Drawing.Size(53, 13)
        Me.Version_Label.TabIndex = 22
        Me.Version_Label.Text = "Version:"
        '
        'File_Name_Label
        '
        Me.File_Name_Label.AutoSize = True
        Me.File_Name_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.File_Name_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.File_Name_Label.Location = New System.Drawing.Point(10, 42)
        Me.File_Name_Label.Name = "File_Name_Label"
        Me.File_Name_Label.Size = New System.Drawing.Size(65, 13)
        Me.File_Name_Label.TabIndex = 23
        Me.File_Name_Label.Text = "File name:"
        '
        'Total_Size_Label
        '
        Me.Total_Size_Label.AutoSize = True
        Me.Total_Size_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Size_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Total_Size_Label.Location = New System.Drawing.Point(10, 55)
        Me.Total_Size_Label.Name = "Total_Size_Label"
        Me.Total_Size_Label.Size = New System.Drawing.Size(66, 13)
        Me.Total_Size_Label.TabIndex = 24
        Me.Total_Size_Label.Text = "Total size:"
        '
        'Speed_Label
        '
        Me.Speed_Label.AutoSize = True
        Me.Speed_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speed_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Speed_Label.Location = New System.Drawing.Point(6, 16)
        Me.Speed_Label.Name = "Speed_Label"
        Me.Speed_Label.Size = New System.Drawing.Size(47, 13)
        Me.Speed_Label.TabIndex = 25
        Me.Speed_Label.Text = "Speed:"
        '
        'Time_Remaining_Label
        '
        Me.Time_Remaining_Label.AutoSize = True
        Me.Time_Remaining_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_Remaining_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Time_Remaining_Label.Location = New System.Drawing.Point(267, 16)
        Me.Time_Remaining_Label.Name = "Time_Remaining_Label"
        Me.Time_Remaining_Label.Size = New System.Drawing.Size(96, 13)
        Me.Time_Remaining_Label.TabIndex = 26
        Me.Time_Remaining_Label.Text = "Time remaining:"
        '
        'Size_Remaining_Label
        '
        Me.Size_Remaining_Label.AutoSize = True
        Me.Size_Remaining_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_Remaining_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Size_Remaining_Label.Location = New System.Drawing.Point(292, 47)
        Me.Size_Remaining_Label.Name = "Size_Remaining_Label"
        Me.Size_Remaining_Label.Size = New System.Drawing.Size(93, 13)
        Me.Size_Remaining_Label.TabIndex = 27
        Me.Size_Remaining_Label.Text = "Size remaining:"
        '
        'Size_Completed_Label
        '
        Me.Size_Completed_Label.AutoSize = True
        Me.Size_Completed_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_Completed_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Size_Completed_Label.Location = New System.Drawing.Point(6, 47)
        Me.Size_Completed_Label.Name = "Size_Completed_Label"
        Me.Size_Completed_Label.Size = New System.Drawing.Size(97, 13)
        Me.Size_Completed_Label.TabIndex = 28
        Me.Size_Completed_Label.Text = "Size completed:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar_Downloading)
        Me.GroupBox1.Controls.Add(Me.Speed_Label)
        Me.GroupBox1.Controls.Add(Me.Size_Completed_Label)
        Me.GroupBox1.Controls.Add(Me.Size_Remaining_Label)
        Me.GroupBox1.Controls.Add(Me.Label_Size_Completed)
        Me.GroupBox1.Controls.Add(Me.Time_Remaining_Label)
        Me.GroupBox1.Controls.Add(Me.Label_Speed)
        Me.GroupBox1.Controls.Add(Me.Label_Size_Remaining)
        Me.GroupBox1.Controls.Add(Me.Label_Time_Remaining)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 364)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 69)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox_Host_Logo)
        Me.GroupBox2.Controls.Add(Me.Label_Hosted_By)
        Me.GroupBox2.Controls.Add(Me.Hosted_By_Label)
        Me.GroupBox2.Controls.Add(Me.Name_Label)
        Me.GroupBox2.Controls.Add(Me.TextBox_Singleplayer)
        Me.GroupBox2.Controls.Add(Me.Label_Version)
        Me.GroupBox2.Controls.Add(Me.TextBox_RequiresAccount)
        Me.GroupBox2.Controls.Add(Me.Version_Label)
        Me.GroupBox2.Controls.Add(Me.Label_Name)
        Me.GroupBox2.Controls.Add(Me.PictureBox_RequiresAccount)
        Me.GroupBox2.Controls.Add(Me.File_Name_Label)
        Me.GroupBox2.Controls.Add(Me.Label_Total_Size)
        Me.GroupBox2.Controls.Add(Me.PictureBox_Singleplayer)
        Me.GroupBox2.Controls.Add(Me.PictureBox_MultiPlayer)
        Me.GroupBox2.Controls.Add(Me.Total_Size_Label)
        Me.GroupBox2.Controls.Add(Me.Label_File_Name)
        Me.GroupBox2.Controls.Add(Me.TextBox_PlayOnline)
        Me.GroupBox2.Controls.Add(Me.PictureBox_PlayOnline)
        Me.GroupBox2.Controls.Add(Me.TextBox_MultiPlayer)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 112)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'PictureBox_Host_Logo
        '
        Me.PictureBox_Host_Logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Host_Logo.Location = New System.Drawing.Point(264, 59)
        Me.PictureBox_Host_Logo.Name = "PictureBox_Host_Logo"
        Me.PictureBox_Host_Logo.Size = New System.Drawing.Size(196, 25)
        Me.PictureBox_Host_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Host_Logo.TabIndex = 29
        Me.PictureBox_Host_Logo.TabStop = False
        Me.PictureBox_Host_Logo.Visible = False
        '
        'Label_Hosted_By
        '
        Me.Label_Hosted_By.AutoSize = True
        Me.Label_Hosted_By.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Hosted_By.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label_Hosted_By.Location = New System.Drawing.Point(84, 68)
        Me.Label_Hosted_By.Name = "Label_Hosted_By"
        Me.Label_Hosted_By.Size = New System.Drawing.Size(19, 13)
        Me.Label_Hosted_By.TabIndex = 28
        Me.Label_Hosted_By.Text = "***"
        Me.Label_Hosted_By.Visible = False
        '
        'Hosted_By_Label
        '
        Me.Hosted_By_Label.AutoSize = True
        Me.Hosted_By_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Hosted_By_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Hosted_By_Label.Location = New System.Drawing.Point(10, 68)
        Me.Hosted_By_Label.Name = "Hosted_By_Label"
        Me.Hosted_By_Label.Size = New System.Drawing.Size(68, 13)
        Me.Hosted_By_Label.TabIndex = 27
        Me.Hosted_By_Label.Text = "Hosted by:"
        Me.Hosted_By_Label.Visible = False
        '
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_Main.Controls.Add(Me.PictureBox_Minimize)
        Me.Panel_Main.Controls.Add(Me.PictureBox_AppIcon)
        Me.Panel_Main.Controls.Add(Me.Label_Title)
        Me.Panel_Main.Controls.Add(Me.PictureBox_Close)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Main.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(472, 24)
        Me.Panel_Main.TabIndex = 33
        '
        'PictureBox_Minimize
        '
        Me.PictureBox_Minimize.Image = CType(resources.GetObject("PictureBox_Minimize.Image"), System.Drawing.Image)
        Me.PictureBox_Minimize.Location = New System.Drawing.Point(431, 3)
        Me.PictureBox_Minimize.Name = "PictureBox_Minimize"
        Me.PictureBox_Minimize.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Minimize.TabIndex = 4
        Me.PictureBox_Minimize.TabStop = False
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.ForeColor = System.Drawing.Color.White
        Me.Label_Title.Location = New System.Drawing.Point(27, 5)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(89, 15)
        Me.Label_Title.TabIndex = 2
        Me.Label_Title.Text = "Downloading..."
        '
        'PictureBox_Close
        '
        Me.PictureBox_Close.Image = CType(resources.GetObject("PictureBox_Close.Image"), System.Drawing.Image)
        Me.PictureBox_Close.Location = New System.Drawing.Point(453, 3)
        Me.PictureBox_Close.Name = "PictureBox_Close"
        Me.PictureBox_Close.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Close.TabIndex = 0
        Me.PictureBox_Close.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox_Cancel_Download)
        Me.Panel1.Controls.Add(Me.PictureBox_Open_Download_Directory)
        Me.Panel1.Controls.Add(Me.PictureBox_Compact)
        Me.Panel1.Controls.Add(Me.PictureBox_Always_On_Top)
        Me.Panel1.Controls.Add(Me.PictureBox_Website)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 433)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 25)
        Me.Panel1.TabIndex = 35
        '
        'Timer_Speed
        '
        Me.Timer_Speed.Interval = 1000
        '
        'NotifyIcon_Downloading
        '
        Me.NotifyIcon_Downloading.BalloonTipTitle = "Game Downloader"
        Me.NotifyIcon_Downloading.Icon = CType(resources.GetObject("NotifyIcon_Downloading.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_Downloading.Text = "Downloading..."
        '
        'PictureBox_Game_Image
        '
        Me.PictureBox_Game_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_Game_Image.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_Game_Image.InitialImage = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Loading
        Me.PictureBox_Game_Image.Location = New System.Drawing.Point(0, 136)
        Me.PictureBox_Game_Image.Name = "PictureBox_Game_Image"
        Me.PictureBox_Game_Image.Size = New System.Drawing.Size(472, 228)
        Me.PictureBox_Game_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Game_Image.TabIndex = 9
        Me.PictureBox_Game_Image.TabStop = False
        '
        'Downloading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(472, 458)
        Me.Controls.Add(Me.PictureBox_Game_Image)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Downloading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Downloading..."
        CType(Me.PictureBox_RequiresAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Singleplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_MultiPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_PlayOnline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Cancel_Download, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Open_Download_Directory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Compact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Always_On_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Website, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox_Host_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox_Game_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar_Downloading As System.Windows.Forms.ProgressBar
    Friend WithEvents Label_File_Name As System.Windows.Forms.Label
    Friend WithEvents Label_Total_Size As System.Windows.Forms.Label
    Friend WithEvents Label_Size_Completed As System.Windows.Forms.Label
    Friend WithEvents Label_Speed As System.Windows.Forms.Label
    Friend WithEvents Label_Time_Remaining As System.Windows.Forms.Label
    Friend WithEvents Label_Size_Remaining As System.Windows.Forms.Label
    Friend WithEvents PictureBox_Game_Image As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Name As System.Windows.Forms.Label
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents TextBox_RequiresAccount As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_RequiresAccount As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_PlayOnline As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_PlayOnline As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_MultiPlayer As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_MultiPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_Singleplayer As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_Singleplayer As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip_Downloading As System.Windows.Forms.ToolTip
    Friend WithEvents Name_Label As System.Windows.Forms.Label
    Friend WithEvents Version_Label As System.Windows.Forms.Label
    Friend WithEvents File_Name_Label As System.Windows.Forms.Label
    Friend WithEvents Total_Size_Label As System.Windows.Forms.Label
    Friend WithEvents Speed_Label As System.Windows.Forms.Label
    Friend WithEvents Time_Remaining_Label As System.Windows.Forms.Label
    Friend WithEvents Size_Remaining_Label As System.Windows.Forms.Label
    Friend WithEvents Size_Completed_Label As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel_Main As System.Windows.Forms.Panel
    Friend WithEvents PictureBox_AppIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Title As System.Windows.Forms.Label
    Friend WithEvents PictureBox_Close As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Minimize As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox_Open_Download_Directory As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Compact As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Always_On_Top As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Website As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Cancel_Download As System.Windows.Forms.PictureBox
    Friend WithEvents Timer_Speed As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon_Downloading As System.Windows.Forms.NotifyIcon
    Friend WithEvents Hosted_By_Label As System.Windows.Forms.Label
    Friend WithEvents Label_Hosted_By As System.Windows.Forms.Label
    Friend WithEvents PictureBox_Host_Logo As System.Windows.Forms.PictureBox
End Class
