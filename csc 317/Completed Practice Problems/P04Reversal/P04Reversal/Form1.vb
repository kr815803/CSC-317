Public Class Form1
    Private Sub txtLetter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLetter.KeyDown
        txtLetter.Clear()
    End Sub

    Private Sub txtLetter_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLetter.KeyUp
        txtForward.Text = txtForward.Text & txtLetter.Text
        txtReverse.Text = txtLetter.Text & txtReverse.Text
        lstProgress.Items.Add(txtForward.Text)
        Dim count, row As Integer 'count is size of ListBox, and row to be used to loop backwards
        count = lstProgress.Items.Count
        lstReverse.Items.Clear() 'get ready for a new listing!
        For row = count - 1 To 0 Step -1 'loop bottom to top in lstProgress - MUST use -1 for step size or loop will not work!
            lstReverse.Items.Add(lstProgress.Items(row)) 'use (row) to indicate the location of the item in the list
        Next
    End Sub
End Class
