Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim number As Integer 'it might be prime
        Dim divisor As Integer 'it might be a factor of number - use MOD to find out
        Dim prime As Boolean 'start as True but make False if there are divisors
        'NOTE: only need test divisors up to the square root of the number

        For number = 2 To 2500 'check all numbers up to 1000
            prime = True 'hope that number is prime
            For divisor = 2 To System.Math.Sqrt(number) 'square root function is in System.Math class
                If number Mod divisor = 0 Then
                    prime = False
                    Exit For
                End If
            Next
            If prime Then
                'no divisors found - prim is still True
                lstPrime.Items.Add(number)
            End If
        Next
    End Sub
End Class
