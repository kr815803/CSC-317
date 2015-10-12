Public Class Form1

    Private Sub picImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picImage.Click
        Dim FileName As String
        Dim result As DialogResult = ofd1.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            FileName = ofd1.FileName
            picImage.Image = New Bitmap(FileName)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        picImage.Image = picBlank.Image
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If fbd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim FolderName As String = fbd1.SelectedPath
                Dim FileName As String = FolderName & "\demo.bmp"
                Dim ImageFile As System.IO.Stream
                ImageFile = System.IO.File.Create(FileName)
                picImage.Image.Save(ImageFile, System.Drawing.Imaging.ImageFormat.Bmp)
                ImageFile.Close()
            Catch ex As Exception
                MessageBox.Show("Must save image to a new file!", "Text and Image Files")
            End Try
        End If
    End Sub
End Class
