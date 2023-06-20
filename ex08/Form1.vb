Public Class Form1
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Form2.Show()
    'End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = TextBox1.Text And TextBox2.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = TextBox1.Text Or TextBox2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = TextBox1.Text Xor TextBox2.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = TextBox1.Text AndAlso TextBox2.Text
    End Sub



End Class
