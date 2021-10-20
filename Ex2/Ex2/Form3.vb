Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form4.Label3.Text <> " " Then
            现金.Enabled = False
        End If
        If Form2.Label7.Text = "天文科技展" Then
            If Form2.成人票.Checked Then
                Me.标题3.Text = 50 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.学生票.Checked Then
                Me.标题3.Text = 30 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.集体票.Checked Then
                Me.标题3.Text = 35 * (Form2.ComboBox1.SelectedIndex + 1)
            End If
        ElseIf Form2.Label7.Text = "历史文物展" Then
            If Form2.成人票.Checked Then
                Me.标题3.Text = 45 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.学生票.Checked Then
                Me.标题3.Text = 25 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.集体票.Checked Then
                Me.标题3.Text = 30 * (Form2.ComboBox1.SelectedIndex + 1)
            End If
        ElseIf Form2.Label7.Text = "游戏动漫展" Then
            If Form2.成人票.Checked Then
                Me.标题3.Text = 40 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.学生票.Checked Then
                Me.标题3.Text = 25 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.集体票.Checked Then
                Me.标题3.Text = 30 * (Form2.ComboBox1.SelectedIndex + 1)
            End If
        End If
    End Sub

    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles 标题3.TextChanged
        If Form2.Label7.Text = "天文科技展" Then
            If Form2.成人票.Checked Then
                Me.标题3.Text = 50 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.学生票.Checked Then
                Me.标题3.Text = 30 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.集体票.Checked Then
                Me.标题3.Text = 35 * (Form2.ComboBox1.SelectedIndex + 1)
            End If
        ElseIf Form2.Label7.Text = "历史文物展" Then
            If Form2.成人票.Checked Then
                Me.标题3.Text = 45 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.学生票.Checked Then
                Me.标题3.Text = 25 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.集体票.Checked Then
                Me.标题3.Text = 30 * (Form2.ComboBox1.SelectedIndex + 1)
            End If
        ElseIf Form2.Label7.Text = "游戏动漫展" Then
            If Form2.成人票.Checked Then
                Me.标题3.Text = 40 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.学生票.Checked Then
                Me.标题3.Text = 25 * (Form2.ComboBox1.SelectedIndex + 1)
            ElseIf Form2.集体票.Checked Then
                Me.标题3.Text = 30 * (Form2.ComboBox1.SelectedIndex + 1)
            End If
        End If
    End Sub

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

    Private Sub Form_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Form2.Show()
    End Sub
End Class