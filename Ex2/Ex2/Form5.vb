Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.标题3.Text = 0
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        If Form2.Label7.Text = "天文科技展" Then
            Form3.标题3.Text = 40 * (Form2.ComboBox1.SelectedIndex + 1)
        ElseIf Form2.Label7.Text = "历史文物展" Then
            Form3.标题3.Text = 35 * (Form2.ComboBox1.SelectedIndex + 1)
        ElseIf Form2.Label7.Text = "游戏动漫展" Then
            Form3.标题3.Text = 30 * (Form2.ComboBox1.SelectedIndex + 1)
        End If
        Form3.Show()
    End Sub

    Private Sub Form_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Form2.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class