<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.first = New System.Windows.Forms.TextBox()
        Me.final = New System.Windows.Forms.TextBox()
        Me.sum = New System.Windows.Forms.TextBox()
        Me.ave = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "중간"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "기말"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "합계"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "평균"
        '
        'first
        '
        Me.first.Location = New System.Drawing.Point(271, 96)
        Me.first.Name = "first"
        Me.first.Size = New System.Drawing.Size(100, 21)
        Me.first.TabIndex = 4
        '
        'final
        '
        Me.final.Location = New System.Drawing.Point(271, 131)
        Me.final.Name = "final"
        Me.final.Size = New System.Drawing.Size(100, 21)
        Me.final.TabIndex = 5
        '
        'sum
        '
        Me.sum.Location = New System.Drawing.Point(271, 165)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(100, 21)
        Me.sum.TabIndex = 6
        '
        'ave
        '
        Me.ave.Location = New System.Drawing.Point(271, 201)
        Me.ave.Name = "ave"
        Me.ave.Size = New System.Drawing.Size(100, 21)
        Me.ave.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(476, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 58)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "계산"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ave)
        Me.Controls.Add(Me.sum)
        Me.Controls.Add(Me.final)
        Me.Controls.Add(Me.first)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents first As TextBox
    Friend WithEvents final As TextBox
    Friend WithEvents sum As TextBox
    Friend WithEvents ave As TextBox
    Friend WithEvents Button1 As Button
End Class
