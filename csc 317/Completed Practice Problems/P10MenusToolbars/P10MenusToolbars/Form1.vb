Public Class Form1


    Private Sub mnuPictureNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPictureNew.Click, tspNew.Click
        Dim result As DialogResult = ofd1.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            Dim FileName As String = ofd1.FileName
            picImage.Image = New Bitmap(FileName)
            mnuViewBig.Enabled = True
            mnuViewSmall.Enabled = True
            tspBig.Enabled = True
            tspSmall.Enabled = True
        End If
    End Sub

    Private Sub mnuPictureClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPictureClear.Click, tspClear.Click
        picImage.Image = picBlank.Image
        picImage.Visible = True
        picBig.Visible = False
        picSmall.Visible = False
        mnuViewBig.Enabled = False
        mnuViewSmall.Enabled = False
        tspBig.Enabled = False
        tspSmall.Enabled = False
    End Sub

    Private Sub mnuPictureExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPictureExit.Click
        Me.Close()
    End Sub

    Private Sub tspSmall_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tspSmall.Click, mnuViewSmall.Click
        picSmall.Image = picImage.Image
        picSmall.Visible = True
        picImage.Visible = False
        picBig.Visible = False
    End Sub

    Private Sub tspBig_Click(sender As Object, e As System.EventArgs) Handles tspBig.Click, mnuViewBig.Click
        picBig.Image = picImage.Image
        picBig.Visible = True
        picImage.Visible = False
        picSmall.Visible = False
    End Sub
End Class
