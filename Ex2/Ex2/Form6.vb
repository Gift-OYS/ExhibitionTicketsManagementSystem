Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7.标题1.Text = "一名儿童必须有一位监护人陪同，" & Environment.NewLine & "因此，为您准备了   " & Form2.ComboBox1.SelectedIndex + 1 & "   张成人票"
        If Form2.Label7.Text = "天文科技展" Then
            Form7.标题5.Text = 50 * (Form2.ComboBox1.SelectedIndex + 1)
        ElseIf Form2.Label7.Text = "历史文物展" Then
            Form7.标题5.Text = 45 * (Form2.ComboBox1.SelectedIndex + 1)
        ElseIf Form2.Label7.Text = "游戏动漫展" Then
            Form7.标题5.Text = 40 * (Form2.ComboBox1.SelectedIndex + 1)
        End If
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form7.标题1.Text = "一名儿童必须有一位监护人陪同，" & Environment.NewLine & "因此，为您准备了   " & Form2.ComboBox1.SelectedIndex + 1 & "   张成人票"
        If Form2.Label7.Text = "天文科技展" Then
            Form7.标题5.Text = (30 + 50) * (Form2.ComboBox1.SelectedIndex + 1)
        ElseIf Form2.Label7.Text = "历史文物展" Then
            Form7.标题5.Text = (25 + 45) * (Form2.ComboBox1.SelectedIndex + 1)
        ElseIf Form2.Label7.Text = "游戏动漫展" Then
            Form7.标题5.Text = (25 + 40) * (Form2.ComboBox1.SelectedIndex + 1)
        End If
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Form_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Form2.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class