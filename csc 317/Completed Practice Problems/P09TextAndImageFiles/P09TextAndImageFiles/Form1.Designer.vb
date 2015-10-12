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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSave = New System.Windows.Forms.TextBox()
        Me.tbRetrieve = New System.Windows.Forms.TextBox()
        Me.btnSaveText = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.btnSaveImage = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.picBlank = New System.Windows.Forms.PictureBox()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TO SAVE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TO RETRIEVE"
        '
        'tbSave
        '
        Me.tbSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSave.Location = New System.Drawing.Point(215, 60)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(117, 29)
        Me.tbSave.TabIndex = 2
        '
        'tbRetrieve
        '
        Me.tbRetrieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRetrieve.Location = New System.Drawing.Point(215, 122)
        Me.tbRetrieve.Name = "tbRetrieve"
        Me.tbRetrieve.Size = New System.Drawing.Size(117, 29)
        Me.tbRetrieve.TabIndex = 3
        '
        'btnSaveText
        '
        Me.btnSaveText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveText.Location = New System.Drawing.Point(377, 55)
        Me.btnSaveText.Name = "btnSaveText"
        Me.btnSaveText.Size = New System.Drawing.Size(145, 40)
        Me.btnSaveText.TabIndex = 4
        Me.btnSaveText.Text = "SAVE TEXT"
        Me.btnSaveText.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(134, 381)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 29)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetrieve.Location = New System.Drawing.Point(377, 122)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(145, 41)
        Me.btnRetrieve.TabIndex = 5
        Me.btnRetrieve.Text = "RETRIEVE"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'btnSaveImage
        '
        Me.btnSaveImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveImage.Location = New System.Drawing.Point(271, 381)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(149, 29)
        Me.btnSaveImage.TabIndex = 6
        Me.btnSaveImage.Text = "SAVE IMAGE"
        Me.btnSaveImage.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.BackColor = System.Drawing.Color.White
        Me.picImage.Location = New System.Drawing.Point(169, 190)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(216, 169)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 7
        Me.picImage.TabStop = False
        '
        'ofd1
        '
        Me.ofd1.FileName = "OpenFileDialog1"
        '
        'picBlank
        '
        Me.picBlank.BackColor = System.Drawing.Color.White
        Me.picBlank.Location = New System.Drawing.Point(169, 190)
        Me.picBlank.Name = "picBlank"
        Me.picBlank.Size = New System.Drawing.Size(216, 169)
        Me.picBlank.TabIndex = 8
        Me.picBlank.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(577, 451)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.btnSaveImage)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSaveText)
        Me.Controls.Add(Me.tbRetrieve)
        Me.Controls.Add(Me.tbSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBlank)
        Me.Name = "Form1"
        Me.Text = "P09TextAndImageFiles, Rauenzahn, Kelsey"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbSave As System.Windows.Forms.TextBox
    Friend WithEvents tbRetrieve As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveText As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRetrieve As System.Windows.Forms.Button
    Friend WithEvents btnSaveImage As System.Windows.Forms.Button
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents fbd1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ofd1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents picBlank As System.Windows.Forms.PictureBox

End Class
