Public Class Form1
    Dim FolderName, FileName As String

    Private Sub btnSaveText_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveText.Click
        If fbd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            FolderName = fbd1.SelectedPath
            FileName = FolderName & "\demo.txt"
            Dim TextFile As System.IO.StreamWriter
            TextFile = System.IO.File.CreateText(Filename)
            TextFile.WriteLine(tbSave.Text)
            TextFile.Close()
        End If
    End Sub

    Private Sub btnRetrieve_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click
        tbRetrieve.Clear()
        If fbd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                FolderName = fbd1.SelectedPath
                FileName = FolderName & "\demo.txt"
                Dim TextFile As System.IO.StreamReader
                TextFile = System.IO.File.OpenText(FileName)
                tbRetrieve.Text = TextFile.ReadLine
                TextFile.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "TextFileSaveOpen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

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

    Private Sub btnSaveImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveImage.Click
        If fbd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim FolderName As String = fbd1.SelectedPath
                Dim fileName As String = FolderName & "\demo.bmp"
                Dim ImageFile As System.IO.Stream
                ImageFile = System.IO.File.Create(fileName)
                picImage.Image.Save(ImageFile, System.Drawing.Imaging.ImageFormat.Bmp)
                ImageFile.Close()
            Catch ex As Exception
                MessageBox.Show("Must save image to a new file!", "Text And Image Files")
            End Try
        End If
    End Sub
End Class
