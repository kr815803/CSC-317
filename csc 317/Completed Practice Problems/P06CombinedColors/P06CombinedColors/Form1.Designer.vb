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
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.txtGreenByte = New System.Windows.Forms.TextBox()
        Me.txtRedByte = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtBlueByte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.picCombined = New System.Windows.Forms.PictureBox()
        Me.panCombined = New System.Windows.Forms.PictureBox()
        CType(Me.picCombined, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panCombined, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(619, 120)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(75, 38)
        Me.btnColor.TabIndex = 0
        Me.btnColor.Text = "Choose Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(392, 260)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(83, 89)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.ReadOnly = True
        Me.txtRed.Size = New System.Drawing.Size(100, 20)
        Me.txtRed.TabIndex = 2
        '
        'txtGreen
        '
        Me.txtGreen.Location = New System.Drawing.Point(253, 89)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.ReadOnly = True
        Me.txtGreen.Size = New System.Drawing.Size(100, 20)
        Me.txtGreen.TabIndex = 3
        '
        'txtGreenByte
        '
        Me.txtGreenByte.Location = New System.Drawing.Point(253, 182)
        Me.txtGreenByte.Name = "txtGreenByte"
        Me.txtGreenByte.ReadOnly = True
        Me.txtGreenByte.Size = New System.Drawing.Size(100, 20)
        Me.txtGreenByte.TabIndex = 4
        '
        'txtRedByte
        '
        Me.txtRedByte.Location = New System.Drawing.Point(83, 182)
        Me.txtRedByte.Name = "txtRedByte"
        Me.txtRedByte.ReadOnly = True
        Me.txtRedByte.Size = New System.Drawing.Size(100, 20)
        Me.txtRedByte.TabIndex = 5
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(432, 88)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.ReadOnly = True
        Me.txtBlue.Size = New System.Drawing.Size(100, 20)
        Me.txtBlue.TabIndex = 6
        '
        'txtBlueByte
        '
        Me.txtBlueByte.Location = New System.Drawing.Point(432, 182)
        Me.txtBlueByte.Name = "txtBlueByte"
        Me.txtBlueByte.ReadOnly = True
        Me.txtBlueByte.Size = New System.Drawing.Size(100, 20)
        Me.txtBlueByte.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Decimal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Blue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Green"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Red"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Bits"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(628, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Components"
        '
        'picCombined
        '
        Me.picCombined.BackColor = System.Drawing.Color.Transparent
        Me.picCombined.Image = Global.CombinedColors.My.Resources.Resources.black1
        Me.picCombined.Location = New System.Drawing.Point(607, 218)
        Me.picCombined.Name = "picCombined"
        Me.picCombined.Size = New System.Drawing.Size(100, 105)
        Me.picCombined.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCombined.TabIndex = 9
        Me.picCombined.TabStop = False
        '
        'panCombined
        '
        Me.panCombined.BackColor = System.Drawing.Color.FloralWhite
        Me.panCombined.Location = New System.Drawing.Point(607, 29)
        Me.panCombined.Name = "panCombined"
        Me.panCombined.Size = New System.Drawing.Size(100, 50)
        Me.panCombined.TabIndex = 8
        Me.panCombined.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(750, 332)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picCombined)
        Me.Controls.Add(Me.panCombined)
        Me.Controls.Add(Me.txtBlueByte)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtRedByte)
        Me.Controls.Add(Me.txtGreenByte)
        Me.Controls.Add(Me.txtGreen)
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnColor)
        Me.Name = "Form1"
        Me.Text = "P06CombinedColors, Rauenzahn, Kelsey"
        CType(Me.picCombined, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panCombined, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtRed As System.Windows.Forms.TextBox
    Friend WithEvents txtGreen As System.Windows.Forms.TextBox
    Friend WithEvents txtGreenByte As System.Windows.Forms.TextBox
    Friend WithEvents txtRedByte As System.Windows.Forms.TextBox
    Friend WithEvents txtBlue As System.Windows.Forms.TextBox
    Friend WithEvents txtBlueByte As System.Windows.Forms.TextBox
    Friend WithEvents panCombined As System.Windows.Forms.PictureBox
    Friend WithEvents picCombined As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog

End Class
