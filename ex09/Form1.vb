Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) >= 70 And Val(TextBox2.Text) >= 70 Then
            TextBox3.Text = "합격"
        Else TextBox3.Text = "불합격"
        End If
    End Sub
End Class
