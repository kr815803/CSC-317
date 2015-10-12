<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pnG = New System.Windows.Forms.Panel()
        Me.pnR = New System.Windows.Forms.Panel()
        Me.pnB = New System.Windows.Forms.Panel()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'pnG
        '
        Me.pnG.BackColor = System.Drawing.Color.DarkGreen
        Me.pnG.Location = New System.Drawing.Point(230, 316)
        Me.pnG.Name = "pnG"
        Me.pnG.Size = New System.Drawing.Size(25, 25)
        Me.pnG.TabIndex = 0
        '
        'pnR
        '
        Me.pnR.BackColor = System.Drawing.Color.Red
        Me.pnR.Location = New System.Drawing.Point(542, 41)
        Me.pnR.Name = "pnR"
        Me.pnR.Size = New System.Drawing.Size(25, 25)
        Me.pnR.TabIndex = 1
        '
        'pnB
        '
        Me.pnB.BackColor = System.Drawing.Color.Black
        Me.pnB.Location = New System.Drawing.Point(55, 338)
        Me.pnB.Name = "pnB"
        Me.pnB.Size = New System.Drawing.Size(25, 25)
        Me.pnB.TabIndex = 1
        '
        'tmr1
        '
        '
        'tmr2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(619, 409)
        Me.Controls.Add(Me.pnB)
        Me.Controls.Add(Me.pnR)
        Me.Controls.Add(Me.pnG)
        Me.Name = "Form1"
        Me.Text = "P16AimAtTarget, Rauenzahn, Kelsey"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnG As System.Windows.Forms.Panel
    Friend WithEvents pnR As System.Windows.Forms.Panel
    Friend WithEvents pnB As System.Windows.Forms.Panel
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents tmr2 As System.Windows.Forms.Timer

End Class
