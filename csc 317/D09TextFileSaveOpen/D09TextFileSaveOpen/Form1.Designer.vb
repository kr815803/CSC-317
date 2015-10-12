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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.Save1 = New System.Windows.Forms.TextBox()
        Me.Save2 = New System.Windows.Forms.TextBox()
        Me.Save3 = New System.Windows.Forms.TextBox()
        Me.Retrieve1 = New System.Windows.Forms.TextBox()
        Me.Retrieve2 = New System.Windows.Forms.TextBox()
        Me.Retrieve3 = New System.Windows.Forms.TextBox()
        Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To Save"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To Retrieve"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(341, 65)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 33)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetrieve.Location = New System.Drawing.Point(341, 237)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(120, 33)
        Me.btnRetrieve.TabIndex = 3
        Me.btnRetrieve.Text = "Retrieve"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'Save1
        '
        Me.Save1.Location = New System.Drawing.Point(185, 65)
        Me.Save1.Multiline = True
        Me.Save1.Name = "Save1"
        Me.Save1.Size = New System.Drawing.Size(109, 32)
        Me.Save1.TabIndex = 4
        '
        'Save2
        '
        Me.Save2.Location = New System.Drawing.Point(185, 119)
        Me.Save2.Multiline = True
        Me.Save2.Name = "Save2"
        Me.Save2.Size = New System.Drawing.Size(109, 32)
        Me.Save2.TabIndex = 5
        '
        'Save3
        '
        Me.Save3.Location = New System.Drawing.Point(182, 174)
        Me.Save3.Multiline = True
        Me.Save3.Name = "Save3"
        Me.Save3.Size = New System.Drawing.Size(109, 32)
        Me.Save3.TabIndex = 6
        '
        'Retrieve1
        '
        Me.Retrieve1.Location = New System.Drawing.Point(182, 237)
        Me.Retrieve1.Multiline = True
        Me.Retrieve1.Name = "Retrieve1"
        Me.Retrieve1.Size = New System.Drawing.Size(109, 32)
        Me.Retrieve1.TabIndex = 7
        '
        'Retrieve2
        '
        Me.Retrieve2.Location = New System.Drawing.Point(182, 293)
        Me.Retrieve2.Multiline = True
        Me.Retrieve2.Name = "Retrieve2"
        Me.Retrieve2.Size = New System.Drawing.Size(109, 32)
        Me.Retrieve2.TabIndex = 8
        '
        'Retrieve3
        '
        Me.Retrieve3.Location = New System.Drawing.Point(182, 344)
        Me.Retrieve3.Multiline = True
        Me.Retrieve3.Name = "Retrieve3"
        Me.Retrieve3.Size = New System.Drawing.Size(109, 32)
        Me.Retrieve3.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(473, 398)
        Me.Controls.Add(Me.Retrieve3)
        Me.Controls.Add(Me.Retrieve2)
        Me.Controls.Add(Me.Retrieve1)
        Me.Controls.Add(Me.Save3)
        Me.Controls.Add(Me.Save2)
        Me.Controls.Add(Me.Save1)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "D09TextFileSaveOpen, Rauenzahn, Kelsey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRetrieve As System.Windows.Forms.Button
    Friend WithEvents Save1 As System.Windows.Forms.TextBox
    Friend WithEvents Save2 As System.Windows.Forms.TextBox
    Friend WithEvents Save3 As System.Windows.Forms.TextBox
    Friend WithEvents Retrieve1 As System.Windows.Forms.TextBox
    Friend WithEvents Retrieve2 As System.Windows.Forms.TextBox
    Friend WithEvents Retrieve3 As System.Windows.Forms.TextBox
    Friend WithEvents fbd1 As System.Windows.Forms.FolderBrowserDialog

End Class
