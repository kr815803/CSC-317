Public Class Form1
    Dim EastWest, NorthSouth As Integer
    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.Click
        If Timer1.Enabled Then
            Timer1.Enabled = False 'toggle
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.Left < 425 Then
            Label1.Left = Label1.Left + 5
        ElseIf Label1.Top > 20 Then
            Label1.Top = Label1.Top - 5
        End If
    End Sub
End Class
