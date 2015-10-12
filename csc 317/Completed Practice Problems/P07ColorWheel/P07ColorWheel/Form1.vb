Public Class Form1
    Dim r As Integer
    Dim g As Integer
    Dim b As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        r = 0 : g = 0 : b = 0
        panCombined.BackColor = Color.FromArgb(255, r, g, b)
    End Sub

    Private Sub btnGoPause_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGoPause.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True 'toggle
            btnGoPause.Text = "PAUSE"
            Timer1.Enabled = True 'toggle
        Else
            Timer1.Enabled = False
            btnGoPause.Text = "GO"
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        b += 10
        If b = 260 Then
            b = 0
            g += 20
            If g = 260 Then
                g = 0
                r += 50
                If r = 300 Then
                    r = 0
                End If
            End If
        End If

        lblBlue.Text = b.ToString
        lblGreen.Text = g.ToString
        lblRed.Text = r.ToString

        panCombined.BackColor = Color.FromArgb(255, r, g, b)
    End Sub

    Private Sub hsbSlowDown_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbSlowDown.Scroll
        Timer1.Interval = hsbSlowDown.Value
    End Sub
End Class
