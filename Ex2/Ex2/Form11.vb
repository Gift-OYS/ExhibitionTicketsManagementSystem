Public Class Form11

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles 确定.Click
        If 输入框.Text = "admin" Then
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("密码错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            输入框.Text = ""
        End If
    End Sub

    Private Sub Form_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Form1.TabControl1.SelectedIndex = 0
        Form1.Show()
    End Sub

    Private Sub 输入框_KeyDown(sender As Object, e As KeyEventArgs) Handles 输入框.KeyDown
        If e.KeyCode = Keys.Enter Then
            If 输入框.Text = "admin" Then
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("密码错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                输入框.Text = ""
            End If
        End If
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class