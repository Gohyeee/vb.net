Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer
        Dim ave As Single

        If (String.IsNullOrEmpty(first.Text)) Then
            MessageBox.Show("중간고사에 값을 입력해주세요")
            first.Focus()
        End If
        If IsNumeric(first.Text) Then
        Else
            MessageBox.Show("중간고사에 숫자를 입력해주세요")
            first.SelectAll()
            first.Focus()

        End If
        If (String.IsNullOrEmpty(final.Text)) Then
            MessageBox.Show("기말고사에 값을 입력해주세요")
            final.Focus()
        End If
        If IsNumeric(final.Text) Then
        Else
            MessageBox.Show("기말고사에 숫자를 입력해주세요")
            first.SelectAll()
            first.Focus()
        End If

        sum = Val(first.Text) + Val(final.Text)
        ave = sum / 2

        Me.sum.Text = sum
        Me.ave.Text = ave

    End Sub
End Class
