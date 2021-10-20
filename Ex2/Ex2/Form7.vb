Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles 下一步.Click
        If L.Text = " " Then
            MessageBox.Show("您还未付款！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Me.Hide()
            Form4.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles 现金.Click
        L.Text = "现金"
        MessageBox.Show("付款成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles 微信.Click
        L.Text = "微信"
        Form9.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles 支付宝.Click
        L.Text = "支付宝"
        Form10.Show()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form4.Label3.Text <> " " Then
            现金.Enabled = False
        End If
    End Sub

    Private Sub Form_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Form2.Show()
    End Sub
End Class