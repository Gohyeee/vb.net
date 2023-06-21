Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case Val(TextBox1.Text)
            Case Is >= 90
                TextBox2.Text = "A"
            Case Is >= 80
                TextBox2.Text = "B"
            Case Is >= 70
                TextBox2.Text = "C"
            Case Is >= 60
                TextBox2.Text = "D"
            Case Else
                TextBox2.Text = "F"
        End Select

    End Sub
End Class
