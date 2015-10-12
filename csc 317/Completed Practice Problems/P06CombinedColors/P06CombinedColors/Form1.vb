Public Class Form1

    Private Sub DecimalToByte(ByVal txtLetter As TextBox, ByRef txtCode As TextBox)
        Dim ascii As Integer
        Dim divisor As Integer
        Dim bitNumber As Integer
        Dim digit As Integer

        If txtLetter.Text <> "" Then
            ascii = Val(txtLetter.Text)
            txtCode.Text = ""
            divisor = 128
            For bitNumber = 1 To 8
                digit = ascii \ divisor
                If digit = 0 Then
                    txtCode.Text = txtCode.Text & "0"
                Else
                    txtCode.Text = txtCode.Text & "1"
                    ascii = ascii - divisor
                End If
                divisor = divisor / 2
            Next bitNumber
        End If
    End Sub

    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        Dim bm As Bitmap
        Dim r, g, b As Integer
        Dim wid, hgt As Integer
        Dim row, col As Integer
        Dim pic1Third, pic2Third As Integer

        dlgColor.ShowDialog()
        panCombined.BackColor = dlgColor.Color

        txtRed.Text = dlgColor.Color.R
        txtGreen.Text = dlgColor.Color.G
        txtBlue.Text = dlgColor.Color.B

        DecimalToByte(txtRed, txtRedByte)
        DecimalToByte(txtGreen, txtGreenByte)
        DecimalToByte(txtBlue, txtBlueByte)

        bm = picCombined.Image

        r = dlgColor.Color.R
        g = dlgColor.Color.G
        b = dlgColor.Color.B

        hgt = bm.Height - 1
        wid = bm.Width - 1

        pic1Third = hgt / 3

        pic2Third = pic1Third * 2

        For row = 1 To pic1Third
            For col = 1 To wid
                bm.SetPixel(col, row, Color.FromArgb(255, r, 0, 0))
            Next col
        Next row

        For row = pic1Third To pic2Third
            For col = 1 To wid
                bm.SetPixel(col, row, Color.FromArgb(255, 0, g, 0))
            Next col
        Next row

        For row = pic2Third To hgt
            For col = 1 To wid
                bm.SetPixel(col, row, Color.FromArgb(255, 0, 0, b))
            Next col
        Next row

        picCombined.Image = bm
        btnColor.Focus()


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub picCombined_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCombined.Click

    End Sub
End Class
