Imports System.IO
Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Hide()
        Form5.Hide()
        Form6.Hide()
        Form7.Hide()
        Form2.标题2.Text -= Form2.ComboBox1.SelectedIndex + 1
        Form1.Show()
        If Form2.Label7.Text = "天文科技展" Then
            Dim sw As StreamWriter
            sw = File.AppendText("tianwenkeji.txt")
            If Label3.Text = " " Then
                If Form2.成人票.Checked Then
                    sw.WriteLine(Date.Today & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.老年票.Checked Then
                    sw.WriteLine(Date.Today & " " & "老年票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.学生票.Checked Then
                    sw.WriteLine(Date.Today & " " & "学生票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.儿童票.Checked Then
                    sw.WriteLine(Date.Today & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 50 * (Form2.ComboBox1.SelectedIndex + 1))
                    sw.WriteLine(Date.Today & " " & "儿童票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 30 * (Form2.ComboBox1.SelectedIndex + 1))
                ElseIf Form2.集体票.Checked Then
                    sw.WriteLine(Date.Today & " " & "集体票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                End If
            Else
                If Form2.成人票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.老年票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "老年票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.学生票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "学生票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.儿童票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 50 * (Form2.ComboBox1.SelectedIndex + 1))
                    sw.WriteLine(Label3.Text & " " & "儿童票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 30 * (Form2.ComboBox1.SelectedIndex + 1))
                ElseIf Form2.集体票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "集体票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                End If
            End If
            sw.Close()
            Label3.Text = " "
            Form3.L.Text = " "
            Form7.L.Text = " "
        ElseIf Form2.Label7.Text = "历史文物展" Then
            Dim sw As StreamWriter
            sw = File.AppendText("lishiwenwu.txt")
            If Label3.Text = " " Then
                If Form2.成人票.Checked Then
                    sw.WriteLine(Date.Today & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.老年票.Checked Then
                    sw.WriteLine(Date.Today & " " & "老年票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.学生票.Checked Then
                    sw.WriteLine(Date.Today & " " & "学生票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.儿童票.Checked Then
                    sw.WriteLine(Date.Today & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 45 * (Form2.ComboBox1.SelectedIndex + 1))
                    sw.WriteLine(Date.Today & " " & "儿童票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 25 * (Form2.ComboBox1.SelectedIndex + 1))
                ElseIf Form2.集体票.Checked Then
                    sw.WriteLine(Date.Today & " " & "集体票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                End If
            Else
                If Form2.成人票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.老年票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "老年票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.学生票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "学生票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.儿童票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 45 * (Form2.ComboBox1.SelectedIndex + 1))
                    sw.WriteLine(Label3.Text & " " & "儿童票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 25 * (Form2.ComboBox1.SelectedIndex + 1))
                ElseIf Form2.集体票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "集体票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                End If
            End If
            sw.Close()
            Label3.Text = " "
            Form3.L.Text = " "
            Form7.L.Text = " "
        ElseIf Form2.Label7.Text = "游戏动漫展" Then
            Dim sw As StreamWriter
            sw = File.AppendText("youxidongman.txt")
            If Label3.Text = " " Then
                If Form2.成人票.Checked Then
                    sw.WriteLine(Date.Today & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.老年票.Checked Then
                    sw.WriteLine(Date.Today & " " & "老年票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.学生票.Checked Then
                    sw.WriteLine(Date.Today & " " & "学生票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.儿童票.Checked Then
                    sw.WriteLine(Date.Today & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 40 * (Form2.ComboBox1.SelectedIndex + 1))
                    sw.WriteLine(Date.Today & " " & "儿童票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 25 * (Form2.ComboBox1.SelectedIndex + 1))
                ElseIf Form2.集体票.Checked Then
                    sw.WriteLine(Date.Today & " " & "集体票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                End If
            Else
                If Form2.成人票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.老年票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "老年票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.学生票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "学生票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                ElseIf Form2.儿童票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "成人票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 40 * (Form2.ComboBox1.SelectedIndex + 1))
                    sw.WriteLine(Label3.Text & " " & "儿童票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & 25 * (Form2.ComboBox1.SelectedIndex + 1))
                ElseIf Form2.集体票.Checked Then
                    sw.WriteLine(Label3.Text & " " & "集体票" & " " & Form2.ComboBox1.SelectedIndex + 1 & " " & Form3.标题3.Text)
                End If
            End If
            sw.Close()
            Label3.Text = " "
            Form3.L.Text = " "
            Form7.L.Text = " "
        End If
    End Sub
    Private Sub Form_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class