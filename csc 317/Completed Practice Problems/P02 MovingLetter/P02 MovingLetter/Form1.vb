Public Class Form1
    Dim LetChar As Integer
    Dim EastWest As Integer
    Dim ewChange As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Letter.Text = Chr(65)
        Randomize()
    End Sub

    Private Sub nudLetter_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudLetter.ValueChanged
        Letter.Text = Chr(nudLetter.Value)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim rndLetter As Integer
        If chkRandom.Checked Then
            rndLetter = 65 + Rnd() * 25
            Letter.Text = Chr(rndLetter)
        End If
    End Sub

    Private Sub tbEastWest_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbEastWest.Scroll
        Dim currentX, movedX, currentY As Integer
        ewChange = 0
        currentX = Letter.Location.X
        currentY = Letter.Location.Y
        movedX = currentX + EastWest + ewChange
        If (movedX > 750) Or (movedX < -50) Then
            EastWest = -EastWest
        End If
        Letter.Location = New System.Drawing.Point(movedX, currentY)
        EastWest = tbEastWest.Value
    End Sub

End Class
