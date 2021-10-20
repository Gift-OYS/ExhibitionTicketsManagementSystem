Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles 确定.Click
        Form4.Label3.Text = MonthCalendar1.SelectionStart
        If Form2.成人票.Checked Or Form2.学生票.Checked Or Form2.集体票.Checked Then
            Me.Hide()
            Form3.Show()
        ElseIf Form2.老年票.Checked Then
            Me.Hide()
            Form5.Show()
        ElseIf Form2.儿童票.Checked Then
            Me.Hide()
            Form6.Show()
        End If
    End Sub

    Private Sub Form_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Form2.Show()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class