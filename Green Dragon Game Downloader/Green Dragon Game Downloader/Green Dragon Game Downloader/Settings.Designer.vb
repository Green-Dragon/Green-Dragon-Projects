<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.RadioButton_Open_Download_File = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Open_Download_Folder = New System.Windows.Forms.RadioButton()
        Me.GroupBox_On_Download_Complete = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Do_Nothing = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Download_Complete_Sound = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Download_Complete_Sound_User = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Download_Complete_Sound_Default = New System.Windows.Forms.RadioButton()
        Me.TextBox_Download_Complete_Sound_Path = New System.Windows.Forms.TextBox()
        Me.CheckBox_Download_Complete_Sound_Enabled = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog_Get_Wave = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox_Startup_Sound = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Startup_Sound_User = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Startup_Sound_Default = New System.Windows.Forms.RadioButton()
        Me.TextBox_Startup_Sound_Path = New System.Windows.Forms.TextBox()
        Me.CheckBox_Startup_Sound_Enabled = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Download_Directory = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Download_User = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Download_Default = New System.Windows.Forms.RadioButton()
        Me.CheckBox_Download_Enabled = New System.Windows.Forms.CheckBox()
        Me.TextBox_Download_Path = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog_Download_Directory = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox_Theme_Color = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Theme_Color_User = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Theme_Color_Default = New System.Windows.Forms.RadioButton()
        Me.ColorDialog_Theme = New System.Windows.Forms.ColorDialog()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.GroupBox_On_Download_Complete.SuspendLayout()
        Me.GroupBox_Download_Complete_Sound.SuspendLayout()
        Me.GroupBox_Startup_Sound.SuspendLayout()
        Me.GroupBox_Download_Directory.SuspendLayout()
        Me.GroupBox_Theme_Color.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton_Open_Download_File
        '
        Me.RadioButton_Open_Download_File.AutoSize = True
        Me.RadioButton_Open_Download_File.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Open_Download_File.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RadioButton_Open_Download_File.Location = New System.Drawing.Point(91, 19)
        Me.RadioButton_Open_Download_File.Name = "RadioButton_Open_Download_File"
        Me.RadioButton_Open_Download_File.Size = New System.Drawing.Size(121, 17)
        Me.RadioButton_Open_Download_File.TabIndex = 1
        Me.RadioButton_Open_Download_File.Text = "Open Download File"
        Me.RadioButton_Open_Download_File.UseVisualStyleBackColor = True
        '
        'RadioButton_Open_Download_Folder
        '
        Me.RadioButton_Open_Download_Folder.AutoSize = True
        Me.RadioButton_Open_Download_Folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Open_Download_Folder.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RadioButton_Open_Download_Folder.Location = New System.Drawing.Point(218, 19)
        Me.RadioButton_Open_Download_Folder.Name = "RadioButton_Open_Download_Folder"
        Me.RadioButton_Open_Download_Folder.Size = New System.Drawing.Size(134, 17)
        Me.RadioButton_Open_Download_Folder.TabIndex = 2
        Me.RadioButton_Open_Download_Folder.Text = "Open Download Folder"
        Me.RadioButton_Open_Download_Folder.UseVisualStyleBackColor = True
        '
        'GroupBox_On_Download_Complete
        '
        Me.GroupBox_On_Download_Complete.Controls.Add(Me.RadioButton_Do_Nothing)
        Me.GroupBox_On_Download_Complete.Controls.Add(Me.RadioButton_Open_Download_Folder)
        Me.GroupBox_On_Download_Complete.Controls.Add(Me.RadioButton_Open_Download_File)
        Me.GroupBox_On_Download_Complete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_On_Download_Complete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupBox_On_Download_Complete.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox_On_Download_Complete.Name = "GroupBox_On_Download_Complete"
        Me.GroupBox_On_Download_Complete.Size = New System.Drawing.Size(354, 49)
        Me.GroupBox_On_Download_Complete.TabIndex = 3
        Me.GroupBox_On_Download_Complete.TabStop = False
        Me.GroupBox_On_Download_Complete.Text = "On Download Complete"
        '
        'RadioButton_Do_Nothing
        '
        Me.RadioButton_Do_Nothing.AutoSize = True
        Me.RadioButton_Do_Nothing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Do_Nothing.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RadioButton_Do_Nothing.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_Do_Nothing.Name = "RadioButton_Do_Nothing"
        Me.RadioButton_Do_Nothing.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton_Do_Nothing.TabIndex = 9
        Me.RadioButton_Do_Nothing.Text = "Do Nothing"
        Me.RadioButton_Do_Nothing.UseVisualStyleBackColor = False
        '
        'GroupBox_Download_Complete_Sound
        '
        Me.GroupBox_Download_Complete_Sound.Controls.Add(Me.RadioButton_Download_Complete_Sound_User)
        Me.GroupBox_Download_Complete_Sound.Controls.Add(Me.RadioButton_Download_Complete_Sound_Default)
        Me.GroupBox_Download_Complete_Sound.Controls.Add(Me.TextBox_Download_Complete_Sound_Path)
        Me.GroupBox_Download_Complete_Sound.Controls.Add(Me.CheckBox_Download_Complete_Sound_Enabled)
        Me.GroupBox_Download_Complete_Sound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Download_Complete_Sound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupBox_Download_Complete_Sound.Location = New System.Drawing.Point(12, 195)
        Me.GroupBox_Download_Complete_Sound.Name = "GroupBox_Download_Complete_Sound"
        Me.GroupBox_Download_Complete_Sound.Size = New System.Drawing.Size(484, 49)
        Me.GroupBox_Download_Complete_Sound.TabIndex = 38
        Me.GroupBox_Download_Complete_Sound.TabStop = False
        Me.GroupBox_Download_Complete_Sound.Text = "Download Complete Sound"
        '
        'RadioButton_Download_Complete_Sound_User
        '
        Me.RadioButton_Download_Complete_Sound_User.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Download_Complete_Sound_User.AutoSize = True
        Me.RadioButton_Download_Complete_Sound_User.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Download_Complete_Sound_User.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RadioButton_Download_Complete_Sound_User.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.RadioButton_Download_Complete_Sound_User.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.RadioButton_Download_Complete_Sound_User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RadioButton_Download_Complete_Sound_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton_Download_Complete_Sound_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Download_Complete_Sound_User.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RadioButton_Download_Complete_Sound_User.Location = New System.Drawing.Point(431, 17)
        Me.RadioButton_Download_Complete_Sound_User.Name = "RadioButton_Download_Complete_Sound_User"
        Me.RadioButton_Download_Complete_Sound_User.Size = New System.Drawing.Size(41, 25)
        Me.RadioButton_Download_Complete_Sound_User.TabIndex = 14
        Me.RadioButton_Download_Complete_Sound_User.Text = "User"
        Me.RadioButton_Download_Complete_Sound_User.UseVisualStyleBackColor = False
        '
        'RadioButton_Download_Complete_Sound_Default
        '
        Me.RadioButton_Download_Complete_Sound_Default.AutoSize = True
        Me.RadioButton_Download_Complete_Sound_Default.Checked = True
        Me.RadioButton_Download_Complete_Sound_Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Download_Complete_Sound_Default.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RadioButton_Download_Complete_Sound_Default.Location = New System.Drawing.Point(366, 20)
        Me.RadioButton_Download_Complete_Sound_Default.Name = "RadioButton_Download_Complete_Sound_Default"
        Me.RadioButton_Download_Complete_Sound_Default.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton_Download_Complete_Sound_Default.TabIndex = 13
        Me.RadioButton_Download_Complete_Sound_Default.TabStop = True
        Me.RadioButton_Download_Complete_Sound_Default.Text = "Default"
        Me.RadioButton_Download_Complete_Sound_Default.UseVisualStyleBackColor = False
        '
        'TextBox_Download_Complete_Sound_Path
        '
        Me.TextBox_Download_Complete_Sound_Path.BackColor = System.Drawing.Color.White
        Me.TextBox_Download_Complete_Sound_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Download_Complete_Sound_Path.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Download_Complete_Sound_Path.Location = New System.Drawing.Point(77, 20)
        Me.TextBox_Download_Complete_Sound_Path.Name = "TextBox_Download_Complete_Sound_Path"
        Me.TextBox_Download_Complete_Sound_Path.ReadOnly = True
        Me.TextBox_Download_Complete_Sound_Path.Size = New System.Drawing.Size(283, 20)
        Me.TextBox_Download_Complete_Sound_Path.TabIndex = 12
        Me.TextBox_Download_Complete_Sound_Path.TabStop = False
        '
        'CheckBox_Download_Complete_Sound_Enabled
        '
        Me.CheckBox_Download_Complete_Sound_Enabled.AutoSize = True
        Me.CheckBox_Download_Complete_Sound_Enabled.Checked = True
        Me.CheckBox_Download_Complete_Sound_Enabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Download_Complete_Sound_Enabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Download_Complete_Sound_Enabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CheckBox_Download_Complete_Sound_Enabled.Location = New System.Drawing.Point(6, 21)
        Me.CheckBox_Download_Complete_Sound_Enabled.Name = "CheckBox_Download_Complete_Sound_Enabled"
        Me.CheckBox_Download_Complete_Sound_Enabled.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox_Download_Complete_Sound_Enabled.TabIndex = 11
        Me.CheckBox_Download_Complete_Sound_Enabled.TabStop = False
        Me.CheckBox_Download_Complete_Sound_Enabled.Text = "Enabled"
        Me.CheckBox_Download_Complete_Sound_Enabled.UseVisualStyleBackColor = False
        '
        'OpenFileDialog_Get_Wave
        '
        Me.OpenFileDialog_Get_Wave.Filter = "Wave (*.wav)|*.wav"
        '
        'GroupBox_Startup_Sound
        '
        Me.GroupBox_Startup_Sound.Controls.Add(Me.RadioButton_Startup_Sound_User)
        Me.GroupBox_Startup_Sound.Controls.Add(Me.RadioButton_Startup_Sound_Default)
        Me.GroupBox_Startup_Sound.Controls.Add(Me.TextBox_Startup_Sound_Path)
        Me.GroupBox_Startup_Sound.Controls.Add(Me.CheckBox_Startup_Sound_Enabled)
        Me.GroupBox_Startup_Sound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Startup_Sound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupBox_Startup_Sound.Location = New System.Drawing.Point(12, 140)
        Me.GroupBox_Startup_Sound.Name = "GroupBox_Startup_Sound"
        Me.GroupBox_Startup_Sound.Size = New System.Drawing.Size(484, 49)
        Me.GroupBox_Startup_Sound.TabIndex = 42
        Me.GroupBox_Startup_Sound.TabStop = False
        Me.GroupBox_Startup_Sound.Text = "Startup Sound"
        '
        'RadioButton_Startup_Sound_User
        '
        Me.RadioButton_Startup_Sound_User.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Startup_Sound_User.AutoSize = True
        Me.RadioButton_Startup_Sound_User.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Startup_Sound_User.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RadioButton_Startup_Sound_User.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.RadioButton_Startup_Sound_User.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.RadioButton_Startup_Sound_User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RadioButton_Startup_Sound_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton_Startup_Sound_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Startup_Sound_User.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RadioButton_Startup_Sound_User.Location = New System.Drawing.Point(431, 17)
        Me.RadioButton_Startup_Sound_User.Name = "RadioButton_Startup_Sound_User"
        Me.RadioButton_Startup_Sound_User.Size = New System.Drawing.Size(41, 25)
        Me.RadioButton_Startup_Sound_User.TabIndex = 10
        Me.RadioButton_Startup_Sound_User.Text = "User"
        Me.RadioButton_Startup_Sound_User.UseVisualStyleBackColor = False
        '
        'RadioButton_Startup_Sound_Default
        '
        Me.RadioButton_Startup_Sound_Default.AutoSize = True
        Me.RadioButton_Startup_Sound_Default.Checked = True
        Me.RadioButton_Startup_Sound_Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Startup_Sound_Default.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RadioButton_Startup_Sound_Default.Location = New System.Drawing.Point(366, 19)
        Me.RadioButton_Startup_Sound_Default.Name = "RadioButton_Startup_Sound_Default"
        Me.RadioButton_Startup_Sound_Default.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton_Startup_Sound_Default.TabIndex = 9
        Me.RadioButton_Startup_Sound_Default.TabStop = True
        Me.RadioButton_Startup_Sound_Default.Text = "Default"
        Me.RadioButton_Startup_Sound_Default.UseVisualStyleBackColor = False
        '
        'TextBox_Startup_Sound_Path
        '
        Me.TextBox_Startup_Sound_Path.BackColor = System.Drawing.Color.White
        Me.TextBox_Startup_Sound_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Startup_Sound_Path.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Startup_Sound_Path.Location = New System.Drawing.Point(77, 19)
        Me.TextBox_Startup_Sound_Path.Name = "TextBox_Startup_Sound_Path"
        Me.TextBox_Startup_Sound_Path.ReadOnly = True
        Me.TextBox_Startup_Sound_Path.Size = New System.Drawing.Size(283, 20)
        Me.TextBox_Startup_Sound_Path.TabIndex = 8
        Me.TextBox_Startup_Sound_Path.TabStop = False
        '
        'CheckBox_Startup_Sound_Enabled
        '
        Me.CheckBox_Startup_Sound_Enabled.AutoSize = True
        Me.CheckBox_Startup_Sound_Enabled.Checked = True
        Me.CheckBox_Startup_Sound_Enabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Startup_Sound_Enabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Startup_Sound_Enabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CheckBox_Startup_Sound_Enabled.Location = New System.Drawing.Point(6, 21)
        Me.CheckBox_Startup_Sound_Enabled.Name = "CheckBox_Startup_Sound_Enabled"
        Me.CheckBox_Startup_Sound_Enabled.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox_Startup_Sound_Enabled.TabIndex = 7
        Me.CheckBox_Startup_Sound_Enabled.TabStop = False
        Me.CheckBox_Startup_Sound_Enabled.Text = "Enabled"
        Me.CheckBox_Startup_Sound_Enabled.UseVisualStyleBackColor = False
        '
        'GroupBox_Download_Directory
        '
        Me.GroupBox_Download_Directory.Controls.Add(Me.RadioButton_Download_User)
        Me.GroupBox_Download_Directory.Controls.Add(Me.RadioButton_Download_Default)
        Me.GroupBox_Download_Directory.Controls.Add(Me.CheckBox_Download_Enabled)
        Me.GroupBox_Download_Directory.Controls.Add(Me.TextBox_Download_Path)
        Me.GroupBox_Download_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Download_Directory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupBox_Download_Directory.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox_Download_Directory.Name = "GroupBox_Download_Directory"
        Me.GroupBox_Download_Directory.Size = New System.Drawing.Size(484, 49)
        Me.GroupBox_Download_Directory.TabIndex = 43
        Me.GroupBox_Download_Directory.TabStop = False
        Me.GroupBox_Download_Directory.Text = "Download Directory"
        '
        'RadioButton_Download_User
        '
        Me.RadioButton_Download_User.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Download_User.AutoSize = True
        Me.RadioButton_Download_User.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_Download_User.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Download_User.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RadioButton_Download_User.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.RadioButton_Download_User.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.RadioButton_Download_User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RadioButton_Download_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton_Download_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Download_User.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RadioButton_Download_User.Location = New System.Drawing.Point(431, 17)
        Me.RadioButton_Download_User.Name = "RadioButton_Download_User"
        Me.RadioButton_Download_User.Size = New System.Drawing.Size(41, 25)
        Me.RadioButton_Download_User.TabIndex = 6
        Me.RadioButton_Download_User.Text = "User"
        Me.RadioButton_Download_User.UseVisualStyleBackColor = False
        '
        'RadioButton_Download_Default
        '
        Me.RadioButton_Download_Default.AutoSize = True
        Me.RadioButton_Download_Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Download_Default.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RadioButton_Download_Default.Location = New System.Drawing.Point(366, 19)
        Me.RadioButton_Download_Default.Name = "RadioButton_Download_Default"
        Me.RadioButton_Download_Default.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton_Download_Default.TabIndex = 5
        Me.RadioButton_Download_Default.Text = "Default"
        Me.RadioButton_Download_Default.UseVisualStyleBackColor = False
        '
        'CheckBox_Download_Enabled
        '
        Me.CheckBox_Download_Enabled.AutoSize = True
        Me.CheckBox_Download_Enabled.Checked = True
        Me.CheckBox_Download_Enabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Download_Enabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Download_Enabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CheckBox_Download_Enabled.Location = New System.Drawing.Point(6, 21)
        Me.CheckBox_Download_Enabled.Name = "CheckBox_Download_Enabled"
        Me.CheckBox_Download_Enabled.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox_Download_Enabled.TabIndex = 3
        Me.CheckBox_Download_Enabled.TabStop = False
        Me.CheckBox_Download_Enabled.Text = "Enabled"
        Me.CheckBox_Download_Enabled.UseVisualStyleBackColor = False
        '
        'TextBox_Download_Path
        '
        Me.TextBox_Download_Path.BackColor = System.Drawing.Color.White
        Me.TextBox_Download_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Download_Path.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Download_Path.Location = New System.Drawing.Point(77, 19)
        Me.TextBox_Download_Path.Name = "TextBox_Download_Path"
        Me.TextBox_Download_Path.ReadOnly = True
        Me.TextBox_Download_Path.Size = New System.Drawing.Size(283, 20)
        Me.TextBox_Download_Path.TabIndex = 4
        Me.TextBox_Download_Path.TabStop = False
        '
        'FolderBrowserDialog_Download_Directory
        '
        Me.FolderBrowserDialog_Download_Directory.Description = "Please Select A Download Directory"
        Me.FolderBrowserDialog_Download_Directory.ShowNewFolderButton = False
        '
        'GroupBox_Theme_Color
        '
        Me.GroupBox_Theme_Color.Controls.Add(Me.RadioButton_Theme_Color_User)
        Me.GroupBox_Theme_Color.Controls.Add(Me.RadioButton_Theme_Color_Default)
        Me.GroupBox_Theme_Color.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Theme_Color.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupBox_Theme_Color.Location = New System.Drawing.Point(372, 30)
        Me.GroupBox_Theme_Color.Name = "GroupBox_Theme_Color"
        Me.GroupBox_Theme_Color.Size = New System.Drawing.Size(124, 49)
        Me.GroupBox_Theme_Color.TabIndex = 44
        Me.GroupBox_Theme_Color.TabStop = False
        Me.GroupBox_Theme_Color.Text = "Theme Color"
        '
        'RadioButton_Theme_Color_User
        '
        Me.RadioButton_Theme_Color_User.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Theme_Color_User.AutoSize = True
        Me.RadioButton_Theme_Color_User.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_Theme_Color_User.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Theme_Color_User.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RadioButton_Theme_Color_User.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.RadioButton_Theme_Color_User.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.RadioButton_Theme_Color_User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RadioButton_Theme_Color_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton_Theme_Color_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Theme_Color_User.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RadioButton_Theme_Color_User.Location = New System.Drawing.Point(71, 15)
        Me.RadioButton_Theme_Color_User.Name = "RadioButton_Theme_Color_User"
        Me.RadioButton_Theme_Color_User.Size = New System.Drawing.Size(41, 25)
        Me.RadioButton_Theme_Color_User.TabIndex = 8
        Me.RadioButton_Theme_Color_User.Text = "User"
        Me.RadioButton_Theme_Color_User.UseVisualStyleBackColor = False
        '
        'RadioButton_Theme_Color_Default
        '
        Me.RadioButton_Theme_Color_Default.AutoSize = True
        Me.RadioButton_Theme_Color_Default.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_Theme_Color_Default.Checked = True
        Me.RadioButton_Theme_Color_Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Theme_Color_Default.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RadioButton_Theme_Color_Default.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_Theme_Color_Default.Name = "RadioButton_Theme_Color_Default"
        Me.RadioButton_Theme_Color_Default.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton_Theme_Color_Default.TabIndex = 7
        Me.RadioButton_Theme_Color_Default.TabStop = True
        Me.RadioButton_Theme_Color_Default.Text = "Default"
        Me.RadioButton_Theme_Color_Default.UseVisualStyleBackColor = False
        '
        'ColorDialog_Theme
        '
        Me.ColorDialog_Theme.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorDialog_Theme.FullOpen = True
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
        Me.Panel_Main.Size = New System.Drawing.Size(505, 24)
        Me.Panel_Main.TabIndex = 45
        '
        'PictureBox_AppIcon
        '
        Me.PictureBox_AppIcon.Image = CType(resources.GetObject("PictureBox_AppIcon.Image"), System.Drawing.Image)
        Me.PictureBox_AppIcon.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox_AppIcon.Name = "PictureBox_AppIcon"
        Me.PictureBox_AppIcon.Size = New System.Drawing.Size(16, 20)
        Me.PictureBox_AppIcon.TabIndex = 3
        Me.PictureBox_AppIcon.TabStop = False
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.ForeColor = System.Drawing.Color.White
        Me.Label_Title.Location = New System.Drawing.Point(27, 5)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(53, 15)
        Me.Label_Title.TabIndex = 2
        Me.Label_Title.Text = "Settings"
        '
        'PictureBox_Close
        '
        Me.PictureBox_Close.Image = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Close_Grey
        Me.PictureBox_Close.Location = New System.Drawing.Point(486, 4)
        Me.PictureBox_Close.Name = "PictureBox_Close"
        Me.PictureBox_Close.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Close.TabIndex = 0
        Me.PictureBox_Close.TabStop = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(505, 255)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.GroupBox_Theme_Color)
        Me.Controls.Add(Me.GroupBox_Download_Directory)
        Me.Controls.Add(Me.GroupBox_Startup_Sound)
        Me.Controls.Add(Me.GroupBox_Download_Complete_Sound)
        Me.Controls.Add(Me.GroupBox_On_Download_Complete)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.GroupBox_On_Download_Complete.ResumeLayout(False)
        Me.GroupBox_On_Download_Complete.PerformLayout()
        Me.GroupBox_Download_Complete_Sound.ResumeLayout(False)
        Me.GroupBox_Download_Complete_Sound.PerformLayout()
        Me.GroupBox_Startup_Sound.ResumeLayout(False)
        Me.GroupBox_Startup_Sound.PerformLayout()
        Me.GroupBox_Download_Directory.ResumeLayout(False)
        Me.GroupBox_Download_Directory.PerformLayout()
        Me.GroupBox_Theme_Color.ResumeLayout(False)
        Me.GroupBox_Theme_Color.PerformLayout()
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadioButton_Open_Download_File As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Open_Download_Folder As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_On_Download_Complete As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_Do_Nothing As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_Download_Complete_Sound As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog_Get_Wave As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox_Startup_Sound As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_Startup_Sound_Enabled As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Download_Complete_Sound_Enabled As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_Download_Directory As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Download_Path As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog_Download_Directory As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TextBox_Download_Complete_Sound_Path As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Startup_Sound_Path As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox_Download_Enabled As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton_Download_Default As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Download_User As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Startup_Sound_User As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Startup_Sound_Default As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Download_Complete_Sound_User As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Download_Complete_Sound_Default As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_Theme_Color As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_Theme_Color_User As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Theme_Color_Default As System.Windows.Forms.RadioButton
    Friend WithEvents ColorDialog_Theme As System.Windows.Forms.ColorDialog
    Friend WithEvents Panel_Main As System.Windows.Forms.Panel
    Friend WithEvents PictureBox_AppIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Title As System.Windows.Forms.Label
    Friend WithEvents PictureBox_Close As System.Windows.Forms.PictureBox
End Class
