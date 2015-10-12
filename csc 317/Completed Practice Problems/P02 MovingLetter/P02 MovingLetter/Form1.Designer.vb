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
        Me.chkRandom = New System.Windows.Forms.CheckBox()
        Me.Letter = New System.Windows.Forms.Label()
        Me.tbEastWest = New System.Windows.Forms.TrackBar()
        Me.nudLetter = New System.Windows.Forms.NumericUpDown()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tbEastWest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLetter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkRandom
        '
        Me.chkRandom.AutoSize = True
        Me.chkRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRandom.Location = New System.Drawing.Point(548, 56)
        Me.chkRandom.Name = "chkRandom"
        Me.chkRandom.Size = New System.Drawing.Size(107, 28)
        Me.chkRandom.TabIndex = 0
        Me.chkRandom.Text = "Random"
        Me.chkRandom.UseVisualStyleBackColor = True
        '
        'Letter
        '
        Me.Letter.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letter.ForeColor = System.Drawing.Color.Red
        Me.Letter.Location = New System.Drawing.Point(324, 142)
        Me.Letter.Name = "Letter"
        Me.Letter.Size = New System.Drawing.Size(85, 73)
        Me.Letter.TabIndex = 1
        Me.Letter.Text = "A"
        '
        'tbEastWest
        '
        Me.tbEastWest.Location = New System.Drawing.Point(305, 56)
        Me.tbEastWest.Minimum = -10
        Me.tbEastWest.Name = "tbEastWest"
        Me.tbEastWest.Size = New System.Drawing.Size(155, 45)
        Me.tbEastWest.TabIndex = 2
        '
        'nudLetter
        '
        Me.nudLetter.Location = New System.Drawing.Point(78, 56)
        Me.nudLetter.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.nudLetter.Minimum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.nudLetter.Name = "nudLetter"
        Me.nudLetter.Size = New System.Drawing.Size(120, 20)
        Me.nudLetter.TabIndex = 3
        Me.nudLetter.Value = New Decimal(New Integer() {65, 0, 0, 0})
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(710, 261)
        Me.Controls.Add(Me.nudLetter)
        Me.Controls.Add(Me.tbEastWest)
        Me.Controls.Add(Me.Letter)
        Me.Controls.Add(Me.chkRandom)
        Me.Name = "Form1"
        Me.Text = "P02 MovingLetter, Rauenzahn, Kelsey"
        CType(Me.tbEastWest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLetter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkRandom As System.Windows.Forms.CheckBox
    Friend WithEvents Letter As System.Windows.Forms.Label
    Friend WithEvents tbEastWest As System.Windows.Forms.TrackBar
    Friend WithEvents nudLetter As System.Windows.Forms.NumericUpDown
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
