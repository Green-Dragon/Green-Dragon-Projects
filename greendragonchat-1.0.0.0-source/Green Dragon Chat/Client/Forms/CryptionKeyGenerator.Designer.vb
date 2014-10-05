<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CryptionKeyGenerator
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CryptionKeyGenerator))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KeyGenPN = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KeyTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click on 2 different points in the field below"
        '
        'KeyGenPN
        '
        Me.KeyGenPN.BackColor = System.Drawing.Color.Silver
        Me.KeyGenPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KeyGenPN.Location = New System.Drawing.Point(12, 35)
        Me.KeyGenPN.Name = "KeyGenPN"
        Me.KeyGenPN.Size = New System.Drawing.Size(249, 127)
        Me.KeyGenPN.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 4
        '
        'KeyTB
        '
        Me.KeyTB.BackColor = System.Drawing.Color.White
        Me.KeyTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KeyTB.Location = New System.Drawing.Point(12, 176)
        Me.KeyTB.Name = "KeyTB"
        Me.KeyTB.ReadOnly = True
        Me.KeyTB.Size = New System.Drawing.Size(249, 20)
        Me.KeyTB.TabIndex = 5
        Me.KeyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CryptionKeyGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(273, 208)
        Me.Controls.Add(Me.KeyTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.KeyGenPN)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CryptionKeyGenerator"
        Me.Text = "Cryption Key Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KeyGenPN As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KeyTB As System.Windows.Forms.TextBox
End Class
