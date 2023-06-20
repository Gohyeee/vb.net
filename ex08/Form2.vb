Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = Label3.Text + " " + TextBox1.Text + "입니다."
        Label4.Text = Label4.Text + " " + Val(TextBox2.Text) * 0.01 & "원 입니다."
    End Sub
End Class