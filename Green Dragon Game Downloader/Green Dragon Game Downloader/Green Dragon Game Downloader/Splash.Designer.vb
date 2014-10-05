<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Label_Loading = New System.Windows.Forms.Label()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Label_Copyright = New System.Windows.Forms.Label()
        Me.Label_Made_By = New System.Windows.Forms.Label()
        Me.ProgressBar_Loading = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.BackColor = System.Drawing.Color.Transparent
        Me.Label_Title.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label_Title.Location = New System.Drawing.Point(131, 18)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(317, 19)
        Me.Label_Title.TabIndex = 4
        Me.Label_Title.Text = "Green Dragon Game Downloader"
        '
        'Label_Loading
        '
        Me.Label_Loading.AutoSize = True
        Me.Label_Loading.BackColor = System.Drawing.Color.Transparent
        Me.Label_Loading.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Loading.Location = New System.Drawing.Point(135, 57)
        Me.Label_Loading.Name = "Label_Loading"
        Me.Label_Loading.Size = New System.Drawing.Size(49, 13)
        Me.Label_Loading.TabIndex = 3
        Me.Label_Loading.Text = "Loading"
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.BackColor = System.Drawing.Color.Transparent
        Me.Label_Version.Location = New System.Drawing.Point(135, 70)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(45, 13)
        Me.Label_Version.TabIndex = 6
        Me.Label_Version.Text = "Version:"
        '
        'Label_Copyright
        '
        Me.Label_Copyright.AutoSize = True
        Me.Label_Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Label_Copyright.Location = New System.Drawing.Point(135, 83)
        Me.Label_Copyright.Name = "Label_Copyright"
        Me.Label_Copyright.Size = New System.Drawing.Size(51, 13)
        Me.Label_Copyright.TabIndex = 8
        Me.Label_Copyright.Text = "Copyright"
        '
        'Label_Made_By
        '
        Me.Label_Made_By.AutoSize = True
        Me.Label_Made_By.BackColor = System.Drawing.Color.Transparent
        Me.Label_Made_By.Location = New System.Drawing.Point(135, 96)
        Me.Label_Made_By.Name = "Label_Made_By"
        Me.Label_Made_By.Size = New System.Drawing.Size(79, 13)
        Me.Label_Made_By.TabIndex = 9
        Me.Label_Made_By.Text = "CompanyName"
        '
        'ProgressBar_Loading
        '
        Me.ProgressBar_Loading.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ProgressBar_Loading.Location = New System.Drawing.Point(138, 112)
        Me.ProgressBar_Loading.MarqueeAnimationSpeed = 0
        Me.ProgressBar_Loading.Name = "ProgressBar_Loading"
        Me.ProgressBar_Loading.Size = New System.Drawing.Size(298, 12)
        Me.ProgressBar_Loading.Step = 1
        Me.ProgressBar_Loading.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar_Loading.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Green_Dragon_Game_Downloader.My.Resources.Resources.Splash_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 136)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar_Loading)
        Me.Controls.Add(Me.Label_Made_By)
        Me.Controls.Add(Me.Label_Copyright)
        Me.Controls.Add(Me.Label_Version)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.Label_Loading)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download Game"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Title As System.Windows.Forms.Label
    Friend WithEvents Label_Loading As System.Windows.Forms.Label
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents Label_Copyright As System.Windows.Forms.Label
    Friend WithEvents Label_Made_By As System.Windows.Forms.Label
    Friend WithEvents ProgressBar_Loading As System.Windows.Forms.ProgressBar
End Class
