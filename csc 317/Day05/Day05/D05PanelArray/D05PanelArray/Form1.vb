Public Class Form1
    Public ticks As Integer 'number of ticks of the clock
    Public p(4) As Panel

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        p(0) = Panel1
        p(1) = Panel2
        p(2) = Panel3
        p(3) = Panel4
        p(4) = Panel5

        ticks = 0 'just beginning
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer 'to loop through array
        If ticks = 1 Then 'line up all panels in the array
            For i = 0 To 4
                p(i).Top = 50 + 75 * i
                p(i).Left = 50
            Next
        ElseIf ticks > 6 Then 'go back to the starting line
            ticks = 0
        Else 'move all panels in the array
            For i = 0 To 4
                p(i).Left += 100
            Next
        End If
        ticks += 1
    End Sub
End Class
