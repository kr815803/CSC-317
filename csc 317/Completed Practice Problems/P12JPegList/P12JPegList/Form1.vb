Public Class Form1

    Private Sub btnFind_Click(sender As Object, e As System.EventArgs) Handles btnFind.Click
        Dim FolderName As String
        lstBox.Items.Clear()

        Dim filter As String
        filter = "*.jpg"
        If fbd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            FolderName = fbd1.SelectedPath
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FolderName, FileIO.SearchOption.SearchTopLevelOnly, filter)
                lstBox.Items.Add(foundFile)
            Next
        End If
    End Sub

    Private Sub lstBox_Click(sender As Object, e As System.EventArgs) Handles lstBox.Click
        Dim FileName As String
        Try
            FileName = lstBox.SelectedItem
            picImage.Image = New Bitmap(FileName)
        Catch ex As Exception
            MessageBox.Show("You did not click on a picture file!")
        End Try

    End Sub
End Class
