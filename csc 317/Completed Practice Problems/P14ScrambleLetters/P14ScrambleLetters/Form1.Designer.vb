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
        Me.lR = New System.Windows.Forms.Label()
        Me.lT = New System.Windows.Forms.Label()
        Me.lA = New System.Windows.Forms.Label()
        Me.lE = New System.Windows.Forms.Label()
        Me.lS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lR
        '
        Me.lR.BackColor = System.Drawing.Color.Red
        Me.lR.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lR.Location = New System.Drawing.Point(119, 287)
        Me.lR.Name = "lR"
        Me.lR.Size = New System.Drawing.Size(60, 55)
        Me.lR.TabIndex = 0
        Me.lR.Text = "R"
        '
        'lT
        '
        Me.lT.BackColor = System.Drawing.Color.Red
        Me.lT.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lT.Location = New System.Drawing.Point(320, 287)
        Me.lT.Name = "lT"
        Me.lT.Size = New System.Drawing.Size(54, 55)
        Me.lT.TabIndex = 1
        Me.lT.Text = "T"
        '
        'lA
        '
        Me.lA.BackColor = System.Drawing.Color.Red
        Me.lA.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lA.Location = New System.Drawing.Point(416, 287)
        Me.lA.Name = "lA"
        Me.lA.Size = New System.Drawing.Size(57, 55)
        Me.lA.TabIndex = 1
        Me.lA.Text = "A"
        '
        'lE
        '
        Me.lE.BackColor = System.Drawing.Color.Red
        Me.lE.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lE.Location = New System.Drawing.Point(519, 287)
        Me.lE.Name = "lE"
        Me.lE.Size = New System.Drawing.Size(57, 55)
        Me.lE.TabIndex = 2
        Me.lE.Text = "E"
        '
        'lS
        '
        Me.lS.BackColor = System.Drawing.Color.Red
        Me.lS.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lS.Location = New System.Drawing.Point(219, 287)
        Me.lS.Name = "lS"
        Me.lS.Size = New System.Drawing.Size(57, 55)
        Me.lS.TabIndex = 3
        Me.lS.Text = "S"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(706, 377)
        Me.Controls.Add(Me.lS)
        Me.Controls.Add(Me.lE)
        Me.Controls.Add(Me.lA)
        Me.Controls.Add(Me.lT)
        Me.Controls.Add(Me.lR)
        Me.Name = "Form1"
        Me.Text = "P14ScrambleLetters, Rauenzahn, Kelsey"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lR As System.Windows.Forms.Label
    Friend WithEvents lT As System.Windows.Forms.Label
    Friend WithEvents lA As System.Windows.Forms.Label
    Friend WithEvents lE As System.Windows.Forms.Label
    Friend WithEvents lS As System.Windows.Forms.Label

End Class
