Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text >= 90 Then
            TextBox2.Text = "A"
        ElseIf TextBox1.Text >= 80 Then
            TextBox2.Text = "B"
        ElseIf TextBox1.Text >= 70 Then
            TextBox2.Text = "C"
        ElseIf TextBox1.Text >= 60 Then
            TextBox2.Text = "D"
        Else TextBox2.Text = "F"
        End If
    End Sub
End Class
