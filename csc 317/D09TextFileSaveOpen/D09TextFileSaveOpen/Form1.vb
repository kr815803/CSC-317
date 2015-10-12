Public Class Form1

    Dim FolderName, FileName As String
    Dim r(3), s(3) As TextBox 'do not use index 0
  
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r(1) = Retrieve1 : r(2) = Retrieve2 : r(3) = Retrieve3
        s(1) = Save1 : s(2) = Save2 : s(3) = Save3
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If fbd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            FolderName = fbd1.SelectedPath
            FileName = FolderName & "\demo.txt"
            Dim TextFile As System.IO.StreamWriter
            TextFile = System.IO.File.CreateText(FileName)
            For i As Integer = 1 To 3
                If s(i).Text <> "" Then TextFile.WriteLine(s(i).Text)
            Next
            TextFile.Close()
        End If
    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As System.EventArgs) Handles btnRetrieve.Click
        For i As Integer = 1 To 3
            r(i).Clear()
        Next
        If fbd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                FolderName = fbd1.SelectedPath
                FileName = FolderName & "\demo.txt"
                Dim TextFile As System.IO.StreamReader
                TextFile = System.IO.File.OpenText(FileName)
                'might not have 3 lines in file, so need to use Peek method
                Dim i = 1
                Do Until TextFile.Peek = -1 'use this instead of for loop!
                    r(i).Text = TextFile.ReadLine
                    i += 1
                Loop
                TextFile.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "TextFileSaveOpen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
