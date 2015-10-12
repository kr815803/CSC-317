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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.hsbColor = New System.Windows.Forms.HScrollBar()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.fdFont = New System.Windows.Forms.FontDialog()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.BackColor = System.Drawing.Color.White
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(183, 90)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(69, 26)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.Text = "Visual"
        '
        'hsbColor
        '
        Me.hsbColor.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.hsbColor.Location = New System.Drawing.Point(99, 260)
        Me.hsbColor.Maximum = 30
        Me.hsbColor.Name = "hsbColor"
        Me.hsbColor.Size = New System.Drawing.Size(270, 17)
        Me.hsbColor.TabIndex = 1
        '
        'btnBlue
        '
        Me.btnBlue.BackColor = System.Drawing.Color.Blue
        Me.btnBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlue.Location = New System.Drawing.Point(324, 323)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(40, 40)
        Me.btnBlue.TabIndex = 2
        Me.btnBlue.Text = "3"
        Me.btnBlue.UseVisualStyleBackColor = False
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.Red
        Me.btnRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRed.Location = New System.Drawing.Point(102, 323)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(40, 40)
        Me.btnRed.TabIndex = 4
        Me.btnRed.Text = "1"
        Me.btnRed.UseVisualStyleBackColor = False
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.Green
        Me.btnGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGreen.Location = New System.Drawing.Point(212, 323)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(40, 40)
        Me.btnGreen.TabIndex = 6
        Me.btnGreen.Text = "2"
        Me.btnGreen.UseVisualStyleBackColor = False
        '
        'lblRed
        '
        Me.lblRed.BackColor = System.Drawing.Color.Black
        Me.lblRed.Location = New System.Drawing.Point(97, 318)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(50, 50)
        Me.lblRed.TabIndex = 7
        Me.lblRed.Text = "Label1"
        Me.lblRed.Visible = False
        '
        'lblGreen
        '
        Me.lblGreen.BackColor = System.Drawing.Color.Black
        Me.lblGreen.Location = New System.Drawing.Point(207, 318)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(50, 50)
        Me.lblGreen.TabIndex = 8
        Me.lblGreen.Text = "Label2"
        Me.lblGreen.Visible = False
        '
        'lblBlue
        '
        Me.lblBlue.BackColor = System.Drawing.Color.Black
        Me.lblBlue.Location = New System.Drawing.Point(319, 318)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(50, 50)
        Me.lblBlue.TabIndex = 9
        Me.lblBlue.Text = "Label3"
        Me.lblBlue.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(466, 437)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.hsbColor)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblBlue)
        Me.Name = "Form1"
        Me.Text = "P08 FontColorSizeEasy, Rauenzahn, Kelsey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents hsbColor As System.Windows.Forms.HScrollBar
    Friend WithEvents btnBlue As System.Windows.Forms.Button
    Friend WithEvents btnRed As System.Windows.Forms.Button
    Friend WithEvents btnGreen As System.Windows.Forms.Button
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents fdFont As System.Windows.Forms.FontDialog

End Class
