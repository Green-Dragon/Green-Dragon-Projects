<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Debug))
        Me.GroupBox_Action_Log = New System.Windows.Forms.GroupBox()
        Me.TextBox_Action_Log = New System.Windows.Forms.TextBox()
        Me.GroupBox_Variables = New System.Windows.Forms.GroupBox()
        Me.TextBox_Variables = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox_Action_Log.SuspendLayout()
        Me.GroupBox_Variables.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Action_Log
        '
        Me.GroupBox_Action_Log.Controls.Add(Me.TextBox_Action_Log)
        Me.GroupBox_Action_Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox_Action_Log.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox_Action_Log.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupBox_Action_Log.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_Action_Log.Name = "GroupBox_Action_Log"
        Me.GroupBox_Action_Log.Size = New System.Drawing.Size(584, 410)
        Me.GroupBox_Action_Log.TabIndex = 0
        Me.GroupBox_Action_Log.TabStop = False
        Me.GroupBox_Action_Log.Text = "Action log"
        '
        'TextBox_Action_Log
        '
        Me.TextBox_Action_Log.BackColor = System.Drawing.Color.White
        Me.TextBox_Action_Log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Action_Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Action_Log.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Action_Log.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Action_Log.Location = New System.Drawing.Point(3, 16)
        Me.TextBox_Action_Log.Multiline = True
        Me.TextBox_Action_Log.Name = "TextBox_Action_Log"
        Me.TextBox_Action_Log.ReadOnly = True
        Me.TextBox_Action_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_Action_Log.Size = New System.Drawing.Size(578, 391)
        Me.TextBox_Action_Log.TabIndex = 0
        Me.TextBox_Action_Log.WordWrap = False
        '
        'GroupBox_Variables
        '
        Me.GroupBox_Variables.Controls.Add(Me.TextBox_Variables)
        Me.GroupBox_Variables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox_Variables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox_Variables.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupBox_Variables.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_Variables.Name = "GroupBox_Variables"
        Me.GroupBox_Variables.Size = New System.Drawing.Size(584, 252)
        Me.GroupBox_Variables.TabIndex = 1
        Me.GroupBox_Variables.TabStop = False
        Me.GroupBox_Variables.Text = "Variables"
        '
        'TextBox_Variables
        '
        Me.TextBox_Variables.BackColor = System.Drawing.Color.White
        Me.TextBox_Variables.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Variables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Variables.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Variables.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Variables.Location = New System.Drawing.Point(3, 16)
        Me.TextBox_Variables.Multiline = True
        Me.TextBox_Variables.Name = "TextBox_Variables"
        Me.TextBox_Variables.ReadOnly = True
        Me.TextBox_Variables.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_Variables.Size = New System.Drawing.Size(578, 233)
        Me.TextBox_Variables.TabIndex = 0
        Me.TextBox_Variables.WordWrap = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox_Action_Log)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox_Variables)
        Me.SplitContainer1.Size = New System.Drawing.Size(584, 666)
        Me.SplitContainer1.SplitterDistance = 410
        Me.SplitContainer1.TabIndex = 2
        '
        'Debug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 666)
        Me.Controls.Add(Me.SplitContainer1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Debug"
        Me.Text = "Debug Window"
        Me.GroupBox_Action_Log.ResumeLayout(False)
        Me.GroupBox_Action_Log.PerformLayout()
        Me.GroupBox_Variables.ResumeLayout(False)
        Me.GroupBox_Variables.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox_Action_Log As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Action_Log As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_Variables As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Variables As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
