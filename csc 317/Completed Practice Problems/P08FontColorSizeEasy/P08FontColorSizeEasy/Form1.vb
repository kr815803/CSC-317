Public Class Form1
    Dim previousLabel As Label

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        previousLabel = lblRed
    End Sub

    Private Sub hsbColor_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbColor.Scroll
        Dim colorNumber As Integer
        colorNumber = hsbColor.Value
        Select Case colorNumber
            Case 1 To 10
                lblDisplay.ForeColor = Color.Red
                previousLabel.Visible = False
                lblRed.Visible = True
                previousLabel = lblRed
            Case 11 To 20
                lblDisplay.ForeColor = Color.Green
                previousLabel.Visible = False
                lblGreen.Visible = True
                previousLabel = lblGreen
            Case 21 To 30
                lblDisplay.ForeColor = Color.Blue
                previousLabel.Visible = False
                lblBlue.Visible = True
                previousLabel = lblBlue
        End Select

    End Sub

    Private Sub btnRed_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRed.Click, btnGreen.Click, btnBlue.Click
        Select Case sender.name
            Case "btnRed"
                lblDisplay.ForeColor = Color.Red
                hsbColor.Value = 1
                previousLabel.Visible = False
                lblRed.Visible = True
                previousLabel = lblRed
            Case "btnGreen"
                lblDisplay.ForeColor = Color.Green
                hsbColor.Value = 1
                previousLabel.Visible = False
                lblGreen.Visible = True
                previousLabel = lblGreen
            Case "btnBlue"
                lblDisplay.ForeColor = Color.Blue
                hsbColor.Value = 1
                previousLabel.Visible = False
                lblBlue.Visible = True
                previousLabel = lblBlue
        End Select

    End Sub

    Private Sub lblDisplay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDisplay.Click
        If fdFont.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblDisplay.Font = fdFont.Font
        End If
    End Sub
End Class
