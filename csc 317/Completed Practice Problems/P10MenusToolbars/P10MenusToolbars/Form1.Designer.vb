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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuPicture = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPictureNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPictureClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPictureExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewSmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewBig = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tspNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspSmall = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspBig = New System.Windows.Forms.ToolStripButton()
        Me.picBig = New System.Windows.Forms.PictureBox()
        Me.picSmall = New System.Windows.Forms.PictureBox()
        Me.picBlank = New System.Windows.Forms.PictureBox()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.picBig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPicture, Me.mnuView})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuPicture
        '
        Me.mnuPicture.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPictureNew, Me.mnuPictureClear, Me.mnuPictureExit})
        Me.mnuPicture.Name = "mnuPicture"
        Me.mnuPicture.Size = New System.Drawing.Size(56, 20)
        Me.mnuPicture.Text = "Picture"
        '
        'mnuPictureNew
        '
        Me.mnuPictureNew.Name = "mnuPictureNew"
        Me.mnuPictureNew.ShortcutKeyDisplayString = ""
        Me.mnuPictureNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuPictureNew.Size = New System.Drawing.Size(146, 22)
        Me.mnuPictureNew.Text = "&New "
        '
        'mnuPictureClear
        '
        Me.mnuPictureClear.Name = "mnuPictureClear"
        Me.mnuPictureClear.ShortcutKeyDisplayString = ""
        Me.mnuPictureClear.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuPictureClear.Size = New System.Drawing.Size(146, 22)
        Me.mnuPictureClear.Text = "&Clear "
        '
        'mnuPictureExit
        '
        Me.mnuPictureExit.Name = "mnuPictureExit"
        Me.mnuPictureExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuPictureExit.Size = New System.Drawing.Size(146, 22)
        Me.mnuPictureExit.Text = "E&xit"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewSmall, Me.mnuViewBig})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "View"
        '
        'mnuViewSmall
        '
        Me.mnuViewSmall.Name = "mnuViewSmall"
        Me.mnuViewSmall.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuViewSmall.Size = New System.Drawing.Size(143, 22)
        Me.mnuViewSmall.Text = "&Small"
        '
        'mnuViewBig
        '
        Me.mnuViewBig.Name = "mnuViewBig"
        Me.mnuViewBig.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuViewBig.Size = New System.Drawing.Size(143, 22)
        Me.mnuViewBig.Text = "&Big "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspNew, Me.ToolStripSeparator1, Me.tspClear, Me.ToolStripSeparator2, Me.ToolStripSeparator4, Me.tspSmall, Me.ToolStripSeparator3, Me.tspBig})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(592, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tspNew
        '
        Me.tspNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspNew.Image = Global.P10MenusToolbars.My.Resources.Resources.NewFolder
        Me.tspNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspNew.Name = "tspNew"
        Me.tspNew.Size = New System.Drawing.Size(23, 22)
        Me.tspNew.Text = "ToolStripButton1"
        Me.tspNew.ToolTipText = "Get New Picture"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tspClear
        '
        Me.tspClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspClear.Image = Global.P10MenusToolbars.My.Resources.Resources.Blank1
        Me.tspClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspClear.Name = "tspClear"
        Me.tspClear.Size = New System.Drawing.Size(23, 22)
        Me.tspClear.Text = "ToolStripButton2"
        Me.tspClear.ToolTipText = "Clear Picture"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tspSmall
        '
        Me.tspSmall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspSmall.Enabled = False
        Me.tspSmall.Image = Global.P10MenusToolbars.My.Resources.Resources.Thumb
        Me.tspSmall.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspSmall.Name = "tspSmall"
        Me.tspSmall.Size = New System.Drawing.Size(23, 22)
        Me.tspSmall.Text = "ToolStripButton3"
        Me.tspSmall.ToolTipText = "View Small Picture"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tspBig
        '
        Me.tspBig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspBig.Enabled = False
        Me.tspBig.Image = Global.P10MenusToolbars.My.Resources.Resources.Show
        Me.tspBig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspBig.Name = "tspBig"
        Me.tspBig.Size = New System.Drawing.Size(23, 22)
        Me.tspBig.Text = "ToolStripButton4"
        Me.tspBig.ToolTipText = "View Big Picture"
        '
        'picBig
        '
        Me.picBig.BackColor = System.Drawing.Color.White
        Me.picBig.Enabled = False
        Me.picBig.Image = Global.P10MenusToolbars.My.Resources.Resources.Blank
        Me.picBig.Location = New System.Drawing.Point(181, 183)
        Me.picBig.Name = "picBig"
        Me.picBig.Size = New System.Drawing.Size(308, 279)
        Me.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBig.TabIndex = 5
        Me.picBig.TabStop = False
        Me.picBig.Visible = False
        '
        'picSmall
        '
        Me.picSmall.BackColor = System.Drawing.Color.White
        Me.picSmall.Enabled = False
        Me.picSmall.Image = Global.P10MenusToolbars.My.Resources.Resources.Blank
        Me.picSmall.Location = New System.Drawing.Point(163, 163)
        Me.picSmall.Name = "picSmall"
        Me.picSmall.Size = New System.Drawing.Size(137, 97)
        Me.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmall.TabIndex = 4
        Me.picSmall.TabStop = False
        Me.picSmall.Visible = False
        '
        'picBlank
        '
        Me.picBlank.BackColor = System.Drawing.Color.White
        Me.picBlank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBlank.Image = Global.P10MenusToolbars.My.Resources.Resources.Blank
        Me.picBlank.Location = New System.Drawing.Point(162, 163)
        Me.picBlank.Name = "picBlank"
        Me.picBlank.Size = New System.Drawing.Size(220, 158)
        Me.picBlank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlank.TabIndex = 3
        Me.picBlank.TabStop = False
        Me.picBlank.Visible = False
        '
        'picImage
        '
        Me.picImage.BackColor = System.Drawing.Color.White
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picImage.Image = Global.P10MenusToolbars.My.Resources.Resources.Blank
        Me.picImage.Location = New System.Drawing.Point(163, 163)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(219, 158)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 2
        Me.picImage.TabStop = False
        '
        'ofd1
        '
        Me.ofd1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(592, 562)
        Me.Controls.Add(Me.picBig)
        Me.Controls.Add(Me.picSmall)
        Me.Controls.Add(Me.picBlank)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "P10MenusToolbars, Rauenzahn, Kelsey"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.picBig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSmall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuPicture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPictureNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents mnuPictureClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picBlank As System.Windows.Forms.PictureBox
    Friend WithEvents mnuPictureExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewSmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewBig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspSmall As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspBig As System.Windows.Forms.ToolStripButton
    Friend WithEvents picSmall As System.Windows.Forms.PictureBox
    Friend WithEvents picBig As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ofd1 As System.Windows.Forms.OpenFileDialog

End Class
