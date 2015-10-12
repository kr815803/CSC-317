Public Class Form1
    Dim slideNumber As Integer
    Dim Slides(24) As Bitmap
    Dim displaySlide As Integer

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Dim FolderName As String
        Dim filter As String
        Dim foundFile As String
        slideNumber = 0

        filter = "*.jpg"

        If fdb1.ShowDialog = Windows.Forms.DialogResult.OK Then
            FolderName = fdb1.SelectedPath
            For Each foundFile In My.Computer.FileSystem.GetFiles(FolderName, FileIO.SearchOption.SearchTopLevelOnly, filter)
                Try
                    Slides(slideNumber) = New Bitmap(foundFile)
                    slideNumber += 1
                Catch ex As Exception
                    tmr1.Enabled = False
                    slideNumber = -1
                    MessageBox.Show("Too many pictues in this folder! Must be no more than 25")
                End Try
            Next
            If slideNumber > -1 Then
                tmr1.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If tmr1.Enabled = False Then
            tmr1.Enabled = True
            btnShow.Text = "Pause"
        Else
            tmr1.Enabled = False
            btnShow.Text = "Show"
        End If
    End Sub

    Private Sub tmr1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr1.Tick
        If slideNumber = -1 Then
            tmr1.Enabled = False
            MessageBox.Show("NO PICTURES TO DISPLAY!")
        End If
        If slideNumber > -1 Then
            displaySlide += 1
            If displaySlide = slideNumber Then
                displaySlide = 0
            End If
            picDisplay.Image = Slides(displaySlide)
        End If
    End Sub
End Class
