Public Class Form1
    Dim moving As Boolean = False
    Dim newLeft As Integer
    Dim newTop As Integer

    Private Sub lA_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lA.MouseDown, lE.MouseDown, lR.MouseDown, lS.MouseDown, lT.MouseDown
        moving = True
    End Sub

    Private Sub lA_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lA.MouseUp, lE.MouseUp, lR.MouseUp, lS.MouseUp, lT.MouseUp
        moving = False
    End Sub

    Private Sub lA_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lA.MouseMove, lE.MouseMove, lR.MouseMove, lS.MouseMove, lT.MouseMove
        If moving Then
            newLeft = MousePosition.X - Me.Left - 10 'adjust
            newTop = MousePosition.Y - Me.Top - 30 'adjust

            If sender Is lA Then
                lA.Left = newLeft
                lA.Top = newTop
            ElseIf sender Is lE Then
                lE.Top = newTop
                lE.Left = newLeft
            ElseIf sender Is lS Then
                lS.Top = newTop
                lS.Left = newLeft
            ElseIf sender Is lR Then
                lR.Top = newTop
                lR.Left = newLeft
            ElseIf sender Is lT Then
                lT.Left = newLeft
                lT.Top = newTop

            End If

        End If
    End Sub
End Class
