Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_Start.Click
        If bt_Start.Text = "클릭되었습니다" Then
            bt_Start.Text = "버 튼2"
        Else
            bt_Start.Text = "클릭되었습니다"
        End If
        If Me.Text = "VB Test2" Then
            Me.Text = "잘했어요"
        Else
            Me.Text = "VB Test2"
        End If


    End Sub

    Private Sub bt_Start_MouseHover(sender As Object, e As EventArgs) Handles bt_Start.MouseHover
        If bt_Start.Text = "버튼위에마우스" Then
            bt_Start.Text = "버 튼"
        Else
            bt_Start.Text = "버튼위에마우스"
        End If
    End Sub

    Private Sub bt_msg_Click(sender As Object, e As EventArgs) Handles bt_msg.Click
        MsgBox("Hello World!")
        Label1.Text = Now.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Now.ToString
    End Sub

    Private Sub bt_Calc_Click(sender As Object, e As EventArgs) Handles bt_Calc.Click
        tx_Result.Text = CStr(CDbl(tx_Price.Text) * CDbl(tx_Number.Text)) 'VB는 형변환을 하지 않아도 묵시적으로 형변환을 해주기는 하나 정확한 코딩을 위해서는 형변환을 해주는 것이 옳다'
    End Sub
End Class
