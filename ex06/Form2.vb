Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const PI As Single = 3.141592
        Dim radius As Single
        Dim length As Single

        radius = TextBox1.Text
        length = radius * 2 * PI
        Label2.Text = Label2.Text & length
    End Sub
End Class