Public Class Form1
    Public ticks As Integer = 0 'number of ticks of the clock
    Public p(4) As Panel
    Dim flicker As Integer = 0

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        p(0) = Panel1
        p(1) = Panel2
        p(2) = Panel3
        p(3) = Panel4
        p(4) = Panel5
    End Sub

    Private Sub tmr1_LeftRight_Tick(sender As System.Object, e As System.EventArgs) Handles tmr1_LeftRight.Tick
        Dim i As Integer 'to loop through array
        Randomize()
        If ticks = 1 Then 'line up all panels in the array
            For i = 0 To 4
                p(i).Top = 50 + 75 * i
                p(i).Left = 50
            Next
        ElseIf ticks > 6 Then 'go back to the starting line
            ticks = 0
        Else 'move all panels in the array
            For i = 0 To 4
                p(i).Left += 15 + ((40 * Rnd()) + 60)
                p(i).Top += -5 + ((35 * Rnd()) - 20)
            Next
        End If
        ticks += 1
        p(flicker).Visible = True
        flicker += 1
        If flicker = 5 Then
            flicker = 0
        End If
    End Sub

    Private Sub tmr2_Blink_Tick(sender As Object, e As System.EventArgs) Handles tmr2_Blink.Tick
        If p(flicker).Visible Then
            p(flicker).Visible = False
        Else
            p(flicker).Visible = True
        End If
    End Sub
End Class
