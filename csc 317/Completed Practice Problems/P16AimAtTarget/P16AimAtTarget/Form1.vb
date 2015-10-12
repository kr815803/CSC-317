Public Class Form1

    Dim moving As Boolean = False
    Dim changeX As Integer
    Dim changeY As Integer

    Private Function AlmostThere(ByVal ob1 As Object, ByVal ob2 As Object) As Object
        'if midpoint of ob1 is inside ob2, return true
        Dim xmid, ymid As Integer 'for ob1
        Dim xmin, xmax, ymin, ymax As Integer 'for ob2
        xmid = ob1.left + ob1.width \ 2
        ymid = ob1.top + ob1.height \ 2
        xmin = ob2.left : xmax = xmin + ob2.width
        ymin = ob2.top : ymax = ymin + ob2.height
        'check for almost there
        Return (xmin <= xmid) And (xmid <= xmax) And (ymin <= ymid) And (ymid <= ymax)
    End Function

    Private Sub pnG_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnG.MouseDown
        moving = True
        tmr1.Enabled = False
    End Sub

    Private Sub pnG_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnG.MouseMove
        If moving Then
            pnG.Left = MousePosition.X - Me.Left - 10 'adjust
            pnG.Top = MousePosition.Y - Me.Top - 30 'adjust
        End If
    End Sub

    Private Sub pnG_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnG.MouseUp
        moving = False
        'shoot - changX and changeY are global variables
        changeX = pnG.Left - pnB.Left
        changeY = pnG.Top - pnB.Top 'could be negative if going up!
        tmr1.Enabled = True
        tmr2.Enabled = True
    End Sub

    Private Sub tmr1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr1.Tick
        pnG.Left += changeX / 25 : pnG.Top += changeY / 25
    End Sub

    Private Sub tmr2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr2.Tick
        If AlmostThere(pnG, pnR) Then
            'stop timers
            tmr1.Enabled = False
            tmr2.Enabled = False
            'make label and panel coincide
            pnG.Left = pnR.Left
            pnG.Top = pnR.Top
            'change png to blue and pnr to blue
            pnG.BackColor = Color.Blue
            pnR.BackColor = Color.Blue
            MessageBox.Show("You Win!")
            Me.Close()
        End If
        If pnG.Left > pnR.Left Or pnG.Top < pnR.Top Then
            tmr1.Enabled = False
            tmr2.Enabled = False
            MessageBox.Show("You Lose!")
        End If
    End Sub
End Class
