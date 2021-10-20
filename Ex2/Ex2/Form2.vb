Imports System.IO
Public Class Form2
    Dim piaoshu = 20000
    Dim todayy As Integer = Convert.ToInt32((Date.Today.ToString.Split(" ")(0)).Split("/")(0))
    Dim todaym As Integer = Convert.ToInt32((Date.Today.ToString.Split(" ")(0)).Split("/")(1))
    Dim todayd As Integer = Convert.ToInt32((Date.Today.ToString.Split(" ")(0)).Split("/")(2))
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s1() As String
        Dim length1 As Integer
        s1 = File.ReadAllLines("tianwenkeji.txt")
        length1 = s1.GetUpperBound(0)
        Dim yyyy1(length1) As Integer
        Dim mm1(length1) As Integer
        Dim dd1(length1) As Integer
        Dim piaoshu1(length1) As Double
        For j = 0 To length1
            yyyy1(j) = Convert.ToInt32((s1(j).Split(" ")(0)).Split("/")(0))
            mm1(j) = Convert.ToInt32((s1(j).Split(" ")(0)).Split("/")(1))
            dd1(j) = Convert.ToInt32((s1(j).Split(" ")(0)).Split("/")(2))
        Next
        For i As Integer = 0 To length1
            If yyyy1(i) = todayy And mm1(i) = todaym And dd1(i) = todayd Then
                piaoshu -= Convert.ToInt32(s1(i).Split(" ")(2))
            End If
        Next

        Dim s2() As String
        Dim length2 As Integer
        s2 = File.ReadAllLines("lishiwenwu.txt")
        length2 = s2.GetUpperBound(0)
        Dim yyyy2(length2) As Integer
        Dim mm2(length2) As Integer
        Dim dd2(length2) As Integer
        Dim piaoshu2(length2) As Double
        For j = 0 To length2
            yyyy2(j) = Convert.ToInt32((s2(j).Split(" ")(0)).Split("/")(0))
            mm2(j) = Convert.ToInt32((s2(j).Split(" ")(0)).Split("/")(1))
            dd2(j) = Convert.ToInt32((s2(j).Split(" ")(0)).Split("/")(2))
        Next
        For i As Integer = 0 To length2
            If yyyy2(i) = todayy And mm2(i) = todaym And dd2(i) = todayd Then
                piaoshu -= Convert.ToInt32(s2(i).Split(" ")(2))
            End If
        Next

        Dim s3() As String
        Dim length3 As Integer
        s3 = File.ReadAllLines("youxidongman.txt")
        length3 = s3.GetUpperBound(0)
        Dim yyyy3(length3) As Integer
        Dim mm3(length3) As Integer
        Dim dd3(length3) As Integer
        Dim piaoshu3(length3) As Double
        For j = 0 To length3
            yyyy3(j) = Convert.ToInt32((s3(j).Split(" ")(0)).Split("/")(0))
            mm3(j) = Convert.ToInt32((s3(j).Split(" ")(0)).Split("/")(1))
            dd3(j) = Convert.ToInt32((s3(j).Split(" ")(0)).Split("/")(2))
        Next
        For i As Integer = 0 To length3
            If yyyy3(i) = todayy And mm3(i) = todaym And dd3(i) = todayd Then
                piaoshu -= Convert.ToInt32(s3(i).Split(" ")(2))
            End If
        Next

        标题2.Text = piaoshu
        Dim a(49) As Object
        For i As Integer = 0 To a.Length - 1
            a(i) = i + 1
        Next
        ComboBox1.Items.AddRange(a)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles 下一步.Click
        If (成人票.Checked Or 老年票.Checked Or 学生票.Checked Or 儿童票.Checked Or 集体票.Checked) = False Then
            MessageBox.Show("请选择您要购买的票的种类！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("请选择您要购买票的数量！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If ComboBox1.SelectedItem > 标题2.Text Then
                MessageBox.Show("当前票额不足！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If 儿童票.Checked And ComboBox1.SelectedItem * 2 > 标题2.Text Then
                    MessageBox.Show("当前票额不足！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If 成人票.Checked Or 学生票.Checked Or 集体票.Checked Then
                        Me.Hide()
                        Form3.Show()
                    ElseIf 老年票.Checked Then
                        Me.Hide()
                        Form5.Show()
                    ElseIf 儿童票.Checked Then
                        Me.Hide()
                        Form6.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles 标题8.Click
        If (成人票.Checked Or 老年票.Checked Or 学生票.Checked Or 儿童票.Checked Or 集体票.Checked) = False Then
            MessageBox.Show("请选择您要购买的票的种类！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("请选择您要购买票的数量！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If ComboBox1.SelectedItem > 标题2.Text Then
                MessageBox.Show("当前票额不足！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If 儿童票.Checked And ComboBox1.SelectedItem * 2 > 标题2.Text Then
                    MessageBox.Show("当前票额不足！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Me.Hide()
                    Form8.Show()
                End If
            End If
        End If
    End Sub

    Private Sub Form_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Form1.Show()
    End Sub

End Class