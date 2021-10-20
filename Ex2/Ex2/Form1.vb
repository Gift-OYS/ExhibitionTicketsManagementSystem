Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles 天文科技展.Click
        Me.Hide()
        Form2.Label7.Text = "天文科技展"
        Form2.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles 历史文物展.Click
        Me.Hide()
        Form2.Label7.Text = "历史文物展"
        Form2.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles 游戏动漫展.Click
        Me.Hide()
        Form2.Label7.Text = "游戏动漫展"
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles 按日统计.Click
        Dim yyyy As Integer = DateTimePicker1.Value.Year
        Dim mm As Integer = DateTimePicker1.Value.Month
        Dim dd As Integer = DateTimePicker1.Value.Day

        Dim i As Integer
        Dim j As Integer
        If 表一.Series.Count = 1 Then
            表一.Series.RemoveAt(0)
            表一.Series.Add("成人票")
            表一.Series.Add("老年票")
            表一.Series.Add("学生票")
            表一.Series.Add("儿童票")
            表一.Series.Add("集体票")

            For i = 0 To 4
                For j = 0 To 2
                    表一.Series(i).Points.Add()
                Next
            Next
        End If

        表一.Series(0).Points(0).AxisLabel = "天文科技"
        表一.Series(0).Points(1).AxisLabel = "历史文物"
        表一.Series(0).Points(2).AxisLabel = "游戏动漫"

        If 表二.Series.Count = 1 Then
            表二.Series.RemoveAt(0)
            表二.Series.Add("成人票")
            表二.Series.Add("老年票")
            表二.Series.Add("学生票")
            表二.Series.Add("儿童票")
            表二.Series.Add("集体票")

            For i = 0 To 4
                For j = 0 To 2
                    表二.Series(i).Points.Add()
                Next
            Next
        End If

        表二.Series(0).Points(0).AxisLabel = "天文科技展"
        表二.Series(0).Points(1).AxisLabel = "历史文物展"
        表二.Series(0).Points(2).AxisLabel = "游戏动漫展"

        Dim 天文s() As String
        Dim 天文length As Integer
        天文s = File.ReadAllLines("tianwenkeji.txt")
        天文length = 天文s.GetUpperBound(0)
        Dim 天文yyyy(天文length) As Integer
        Dim 天文mm(天文length) As Integer
        Dim 天文dd(天文length) As Integer
        Dim 天文zhonglei(天文length) As String
        Dim 天文piaoshu(天文length) As Double
        Dim 天文jine(天文length) As Double
        For j = 0 To 天文length
            天文yyyy(j) = Convert.ToInt32((天文s(j).Split(" ")(0)).Split("/")(0))
            天文mm(j) = Convert.ToInt32((天文s(j).Split(" ")(0)).Split("/")(1))
            天文dd(j) = Convert.ToInt32((天文s(j).Split(" ")(0)).Split("/")(2))
            天文zhonglei(j) = 天文s(j).Split(" ")(1)
            天文piaoshu(j) = Convert.ToInt32(天文s(j).Split(" ")(2))
            天文jine(j) = Convert.ToInt32(天文s(j).Split(" ")(3))
        Next

        Dim 历史s() As String
        Dim 历史length As Integer
        历史s = File.ReadAllLines("lishiwenwu.txt")
        历史length = 历史s.GetUpperBound(0)
        Dim 历史yyyy(历史length) As Integer
        Dim 历史mm(历史length) As Integer
        Dim 历史dd(历史length) As Integer
        Dim 历史zhonglei(历史length) As String
        Dim 历史piaoshu(历史length) As Double
        Dim 历史jine(历史length) As Double
        For j = 0 To 历史length
            历史yyyy(j) = Convert.ToInt32((历史s(j).Split(" ")(0)).Split("/")(0))
            历史mm(j) = Convert.ToInt32((历史s(j).Split(" ")(0)).Split("/")(1))
            历史dd(j) = Convert.ToInt32((历史s(j).Split(" ")(0)).Split("/")(2))
            历史zhonglei(j) = 历史s(j).Split(" ")(1)
            历史piaoshu(j) = Convert.ToInt32(历史s(j).Split(" ")(2))
            历史jine(j) = Convert.ToInt32(历史s(j).Split(" ")(3))
        Next

        Dim 游戏s() As String
        Dim 游戏length As Integer
        游戏s = File.ReadAllLines("youxidongman.txt")
        游戏length = 游戏s.GetUpperBound(0)
        Dim 游戏yyyy(游戏length) As Integer
        Dim 游戏mm(游戏length) As Integer
        Dim 游戏dd(游戏length) As Integer
        Dim 游戏zhonglei(游戏length) As String
        Dim 游戏piaoshu(游戏length) As Double
        Dim 游戏jine(游戏length) As Double
        For j = 0 To 游戏length
            游戏yyyy(j) = Convert.ToInt32((游戏s(j).Split(" ")(0)).Split("/")(0))
            游戏mm(j) = Convert.ToInt32((游戏s(j).Split(" ")(0)).Split("/")(1))
            游戏dd(j) = Convert.ToInt32((游戏s(j).Split(" ")(0)).Split("/")(2))
            游戏zhonglei(j) = 游戏s(j).Split(" ")(1)
            游戏piaoshu(j) = Convert.ToInt32(游戏s(j).Split(" ")(2))
            游戏jine(j) = Convert.ToInt32(游戏s(j).Split(" ")(3))
        Next

        Dim 成人jine(2) As Integer
        Dim 老年jine(2) As Integer
        Dim 学生jine(2) As Integer
        Dim 儿童jine(2) As Integer
        Dim 集体jine(2) As Integer

        Dim 成人piaoshu(2) As Integer
        Dim 老年piaoshu(2) As Integer
        Dim 学生piaoshu(2) As Integer
        Dim 儿童piaoshu(2) As Integer
        Dim 集体piaoshu(2) As Integer

        For i = 0 To 天文length
            If 天文zhonglei(i) = "成人票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) And dd = 天文dd(i) Then
                成人jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "老年票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) And dd = 天文dd(i) Then
                老年jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "学生票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) And dd = 天文dd(i) Then
                学生jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "儿童票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) And dd = 天文dd(i) Then
                儿童jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "集体票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) And dd = 天文dd(i) Then
                集体jine(0) += 天文jine(i)
            End If
        Next

        For i = 0 To 历史length
            If 历史zhonglei(i) = "成人票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) And dd = 历史dd(i) Then
                成人jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "老年票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) And dd = 历史dd(i) Then
                老年jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "学生票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) And dd = 历史dd(i) Then
                学生jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "儿童票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) And dd = 历史dd(i) Then
                儿童jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "集体票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) And dd = 历史dd(i) Then
                集体jine(1) += 历史jine(i)
            End If
        Next

        For i = 0 To 游戏length
            If 游戏zhonglei(i) = "成人票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) And dd = 游戏dd(i) Then
                成人jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "老年票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) And dd = 游戏dd(i) Then
                老年jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "学生票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) And dd = 游戏dd(i) Then
                学生jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "儿童票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) And dd = 游戏dd(i) Then
                儿童jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "集体票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) And dd = 游戏dd(i) Then
                集体jine(2) += 游戏jine(i)
            End If
        Next

        For i = 0 To 天文length
            If 天文zhonglei(i) = "成人票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) And dd = 天文dd(i) Then
                成人piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "老年票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) And dd = 天文dd(i) Then
                老年piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "学生票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) And dd = 天文dd(i) Then
                学生piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "儿童票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) And dd = 天文dd(i) Then
                儿童piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "集体票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) And dd = 天文dd(i) Then
                集体piaoshu(0) += 天文piaoshu(i)
            End If
        Next

        For i = 0 To 历史length
            If 历史zhonglei(i) = "成人票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) And dd = 历史dd(i) Then
                成人piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "老年票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) And dd = 历史dd(i) Then
                老年piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "学生票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) And dd = 历史dd(i) Then
                学生piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "儿童票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) And dd = 历史dd(i) Then
                儿童piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "集体票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) And dd = 历史dd(i) Then
                集体piaoshu(1) += 历史piaoshu(i)
            End If
        Next

        For i = 0 To 游戏length
            If 游戏zhonglei(i) = "成人票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) And dd = 游戏dd(i) Then
                成人piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "老年票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) And dd = 游戏dd(i) Then
                老年piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "学生票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) And dd = 游戏dd(i) Then
                学生piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "儿童票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) And dd = 游戏dd(i) Then
                儿童piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "集体票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) And dd = 游戏dd(i) Then
                集体piaoshu(2) += 游戏piaoshu(i)
            End If
        Next

        For i = 0 To 4
            For j = 0 To 2
                If i = 0 Then
                    表一.Series(0).Points(j).YValues = {成人piaoshu(j)}
                    表一.Series(0).Points(j).Label = 成人piaoshu(j)
                ElseIf i = 1 Then
                    表一.Series(1).Points(j).YValues = {老年piaoshu(j)}
                    表一.Series(1).Points(j).Label = 老年piaoshu(j)
                ElseIf i = 2 Then
                    表一.Series(2).Points(j).YValues = {学生piaoshu(j)}
                    表一.Series(2).Points(j).Label = 学生piaoshu(j)
                ElseIf i = 3 Then
                    表一.Series(3).Points(j).YValues = {儿童piaoshu(j)}
                    表一.Series(3).Points(j).Label = 儿童piaoshu(j)
                ElseIf i = 4 Then
                    表一.Series(4).Points(j).YValues = {集体piaoshu(j)}
                    表一.Series(4).Points(j).Label = 集体piaoshu(j)
                End If
            Next
        Next

        For i = 0 To 4
            For j = 0 To 2
                If i = 0 Then
                    表二.Series(0).Points(j).YValues = {成人jine(j)}
                    表二.Series(0).Points(j).Label = 成人jine(j)
                ElseIf i = 1 Then
                    表二.Series(1).Points(j).YValues = {老年jine(j)}
                    表二.Series(1).Points(j).Label = 老年jine(j)
                ElseIf i = 2 Then
                    表二.Series(2).Points(j).YValues = {学生jine(j)}
                    表二.Series(2).Points(j).Label = 学生jine(j)
                ElseIf i = 3 Then
                    表二.Series(3).Points(j).YValues = {儿童jine(j)}
                    表二.Series(3).Points(j).Label = 儿童jine(j)
                ElseIf i = 4 Then
                    表二.Series(4).Points(j).YValues = {集体jine(j)}
                    表二.Series(4).Points(j).Label = 集体jine(j)
                End If
            Next
        Next

        Dim sum2 As Integer = 0
        Dim sum1 As Integer = 0
        For i = 0 To 2
            sum2 += 成人piaoshu(i) + 老年piaoshu(i) + 学生piaoshu(i) + 儿童piaoshu(i) + 集体piaoshu(i)
            sum1 += 成人jine(i) + 老年jine(i) + 学生jine(i) + 儿童jine(i) + 集体jine(i)
        Next
        票数.Text = "共卖出" & sum2 & "张票"
        钱数.Text = "共收入" & sum1 & "元"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles 按月统计.Click
        Dim yyyy As Integer = DateTimePicker1.Value.Year
        Dim mm As Integer = DateTimePicker1.Value.Month

        Dim i As Integer
        Dim j As Integer
        If 表一.Series.Count = 1 Then
            表一.Series.RemoveAt(0)
            表一.Series.Add("成人票")
            表一.Series.Add("老年票")
            表一.Series.Add("学生票")
            表一.Series.Add("儿童票")
            表一.Series.Add("集体票")

            For i = 0 To 4
                For j = 0 To 2
                    表一.Series(i).Points.Add()
                Next
            Next
        End If

        表一.Series(0).Points(0).AxisLabel = "天文科技展"
        表一.Series(0).Points(1).AxisLabel = "历史文物展"
        表一.Series(0).Points(2).AxisLabel = "游戏动漫展"

        If 表二.Series.Count = 1 Then
            表二.Series.RemoveAt(0)
            表二.Series.Add("成人票")
            表二.Series.Add("老年票")
            表二.Series.Add("学生票")
            表二.Series.Add("儿童票")
            表二.Series.Add("集体票")

            For i = 0 To 4
                For j = 0 To 2
                    表二.Series(i).Points.Add()
                Next
            Next
        End If

        表二.Series(0).Points(0).AxisLabel = "天文科技展"
        表二.Series(0).Points(1).AxisLabel = "历史文物展"
        表二.Series(0).Points(2).AxisLabel = "游戏动漫展"

        Dim 天文s() As String
        Dim 天文length As Integer
        天文s = File.ReadAllLines("tianwenkeji.txt")
        天文length = 天文s.GetUpperBound(0)
        Dim 天文yyyy(天文length) As Integer
        Dim 天文mm(天文length) As Integer
        Dim 天文zhonglei(天文length) As String
        Dim 天文piaoshu(天文length) As Double
        Dim 天文jine(天文length) As Double
        For j = 0 To 天文length
            天文yyyy(j) = Convert.ToInt32((天文s(j).Split(" ")(0)).Split("/")(0))
            天文mm(j) = Convert.ToInt32((天文s(j).Split(" ")(0)).Split("/")(1))
            天文zhonglei(j) = 天文s(j).Split(" ")(1)
            天文piaoshu(j) = Convert.ToInt32(天文s(j).Split(" ")(2))
            天文jine(j) = Convert.ToInt32(天文s(j).Split(" ")(3))
        Next

        Dim 历史s() As String
        Dim 历史length As Integer
        历史s = File.ReadAllLines("lishiwenwu.txt")
        历史length = 历史s.GetUpperBound(0)
        Dim 历史yyyy(历史length) As Integer
        Dim 历史mm(历史length) As Integer
        Dim 历史zhonglei(历史length) As String
        Dim 历史piaoshu(历史length) As Double
        Dim 历史jine(历史length) As Double
        For j = 0 To 历史length
            历史yyyy(j) = Convert.ToInt32((历史s(j).Split(" ")(0)).Split("/")(0))
            历史mm(j) = Convert.ToInt32((历史s(j).Split(" ")(0)).Split("/")(1))
            历史zhonglei(j) = 历史s(j).Split(" ")(1)
            历史piaoshu(j) = Convert.ToInt32(历史s(j).Split(" ")(2))
            历史jine(j) = Convert.ToInt32(历史s(j).Split(" ")(3))
        Next

        Dim 游戏s() As String
        Dim 游戏length As Integer
        游戏s = File.ReadAllLines("youxidongman.txt")
        游戏length = 游戏s.GetUpperBound(0)
        Dim 游戏yyyy(游戏length) As Integer
        Dim 游戏mm(游戏length) As Integer
        Dim 游戏zhonglei(游戏length) As String
        Dim 游戏piaoshu(游戏length) As Double
        Dim 游戏jine(游戏length) As Double
        For j = 0 To 游戏length
            游戏yyyy(j) = Convert.ToInt32((游戏s(j).Split(" ")(0)).Split("/")(0))
            游戏mm(j) = Convert.ToInt32((游戏s(j).Split(" ")(0)).Split("/")(1))
            游戏zhonglei(j) = 游戏s(j).Split(" ")(1)
            游戏piaoshu(j) = Convert.ToInt32(游戏s(j).Split(" ")(2))
            游戏jine(j) = Convert.ToInt32(游戏s(j).Split(" ")(3))
        Next

        Dim 成人jine(2) As Integer
        Dim 老年jine(2) As Integer
        Dim 学生jine(2) As Integer
        Dim 儿童jine(2) As Integer
        Dim 集体jine(2) As Integer

        Dim 成人piaoshu(2) As Integer
        Dim 老年piaoshu(2) As Integer
        Dim 学生piaoshu(2) As Integer
        Dim 儿童piaoshu(2) As Integer
        Dim 集体piaoshu(2) As Integer

        For i = 0 To 天文length
            If 天文zhonglei(i) = "成人票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) Then
                成人jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "老年票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) Then
                老年jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "学生票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) Then
                学生jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "儿童票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) Then
                儿童jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "集体票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) Then
                集体jine(0) += 天文jine(i)
            End If
        Next

        For i = 0 To 历史length
            If 历史zhonglei(i) = "成人票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) Then
                成人jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "老年票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) Then
                老年jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "学生票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) Then
                学生jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "儿童票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) Then
                儿童jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "集体票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) Then
                集体jine(1) += 历史jine(i)
            End If
        Next

        For i = 0 To 游戏length
            If 游戏zhonglei(i) = "成人票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) Then
                成人jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "老年票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) Then
                老年jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "学生票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) Then
                学生jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "儿童票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) Then
                儿童jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "集体票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) Then
                集体jine(2) += 游戏jine(i)
            End If
        Next

        For i = 0 To 天文length
            If 天文zhonglei(i) = "成人票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) Then
                成人piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "老年票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) Then
                老年piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "学生票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) Then
                学生piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "儿童票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) Then
                儿童piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "集体票" And yyyy = 天文yyyy(i) And mm = 天文mm(i) Then
                集体piaoshu(0) += 天文piaoshu(i)
            End If
        Next

        For i = 0 To 历史length
            If 历史zhonglei(i) = "成人票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) Then
                成人piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "老年票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) Then
                老年piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "学生票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) Then
                学生piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "儿童票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) Then
                儿童piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "集体票" And yyyy = 历史yyyy(i) And mm = 历史mm(i) Then
                集体piaoshu(1) += 历史piaoshu(i)
            End If
        Next

        For i = 0 To 游戏length
            If 游戏zhonglei(i) = "成人票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) Then
                成人piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "老年票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) Then
                老年piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "学生票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) Then
                学生piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "儿童票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) Then
                儿童piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "集体票" And yyyy = 游戏yyyy(i) And mm = 游戏mm(i) Then
                集体piaoshu(2) += 游戏piaoshu(i)
            End If
        Next

        For i = 0 To 4
            For j = 0 To 2
                If i = 0 Then
                    表一.Series(0).Points(j).YValues = {成人piaoshu(j)}
                    表一.Series(0).Points(j).Label = 成人piaoshu(j)
                ElseIf i = 1 Then
                    表一.Series(1).Points(j).YValues = {老年piaoshu(j)}
                    表一.Series(1).Points(j).Label = 老年piaoshu(j)
                ElseIf i = 2 Then
                    表一.Series(2).Points(j).YValues = {学生piaoshu(j)}
                    表一.Series(2).Points(j).Label = 学生piaoshu(j)
                ElseIf i = 3 Then
                    表一.Series(3).Points(j).YValues = {儿童piaoshu(j)}
                    表一.Series(3).Points(j).Label = 儿童piaoshu(j)
                ElseIf i = 4 Then
                    表一.Series(4).Points(j).YValues = {集体piaoshu(j)}
                    表一.Series(4).Points(j).Label = 集体piaoshu(j)
                End If
            Next
        Next

        For i = 0 To 4
            For j = 0 To 2
                If i = 0 Then
                    表二.Series(0).Points(j).YValues = {成人jine(j)}
                    表二.Series(0).Points(j).Label = 成人jine(j)
                ElseIf i = 1 Then
                    表二.Series(1).Points(j).YValues = {老年jine(j)}
                    表二.Series(1).Points(j).Label = 老年jine(j)
                ElseIf i = 2 Then
                    表二.Series(2).Points(j).YValues = {学生jine(j)}
                    表二.Series(2).Points(j).Label = 学生jine(j)
                ElseIf i = 3 Then
                    表二.Series(3).Points(j).YValues = {儿童jine(j)}
                    表二.Series(3).Points(j).Label = 儿童jine(j)
                ElseIf i = 4 Then
                    表二.Series(4).Points(j).YValues = {集体jine(j)}
                    表二.Series(4).Points(j).Label = 集体jine(j)
                End If
            Next
        Next

        Dim sum2 As Integer = 0
        Dim sum1 As Integer = 0
        For i = 0 To 2
            sum2 += 成人piaoshu(i) + 老年piaoshu(i) + 学生piaoshu(i) + 儿童piaoshu(i) + 集体piaoshu(i)
            sum1 += 成人jine(i) + 老年jine(i) + 学生jine(i) + 儿童jine(i) + 集体jine(i)
        Next
        票数.Text = "共卖出" & sum2 & "张票"
        钱数.Text = "共收入" & sum1 & "元"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles 按年统计.Click
        Dim yyyy As Integer = DateTimePicker1.Value.Year

        Dim i As Integer
        Dim j As Integer
        If 表一.Series.Count = 1 Then
            表一.Series.RemoveAt(0)
            表一.Series.Add("成人票")
            表一.Series.Add("老年票")
            表一.Series.Add("学生票")
            表一.Series.Add("儿童票")
            表一.Series.Add("集体票")

            For i = 0 To 4
                For j = 0 To 2
                    表一.Series(i).Points.Add()
                Next
            Next
        End If

        表一.Series(0).Points(0).AxisLabel = "天文科技展"
        表一.Series(0).Points(1).AxisLabel = "历史文物展"
        表一.Series(0).Points(2).AxisLabel = "游戏动漫展"

        If 表二.Series.Count = 1 Then
            表二.Series.RemoveAt(0)
            表二.Series.Add("成人票")
            表二.Series.Add("老年票")
            表二.Series.Add("学生票")
            表二.Series.Add("儿童票")
            表二.Series.Add("集体票")

            For i = 0 To 4
                For j = 0 To 2
                    表二.Series(i).Points.Add()
                Next
            Next
        End If

        表二.Series(0).Points(0).AxisLabel = "天文科技展"
        表二.Series(0).Points(1).AxisLabel = "历史文物展"
        表二.Series(0).Points(2).AxisLabel = "游戏动漫展"

        Dim 天文s() As String
        Dim 天文length As Integer
        天文s = File.ReadAllLines("tianwenkeji.txt")
        天文length = 天文s.GetUpperBound(0)
        Dim 天文yyyy(天文length) As Integer
        Dim 天文zhonglei(天文length) As String
        Dim 天文piaoshu(天文length) As Double
        Dim 天文jine(天文length) As Double
        For j = 0 To 天文length
            天文yyyy(j) = Convert.ToInt32((天文s(j).Split(" ")(0)).Split("/")(0))
            天文zhonglei(j) = 天文s(j).Split(" ")(1)
            天文piaoshu(j) = Convert.ToInt32(天文s(j).Split(" ")(2))
            天文jine(j) = Convert.ToInt32(天文s(j).Split(" ")(3))
        Next

        Dim 历史s() As String
        Dim 历史length As Integer
        历史s = File.ReadAllLines("lishiwenwu.txt")
        历史length = 历史s.GetUpperBound(0)
        Dim 历史yyyy(历史length) As Integer
        Dim 历史zhonglei(历史length) As String
        Dim 历史piaoshu(历史length) As Double
        Dim 历史jine(历史length) As Double
        For j = 0 To 历史length
            历史yyyy(j) = Convert.ToInt32((历史s(j).Split(" ")(0)).Split("/")(0))
            历史zhonglei(j) = 历史s(j).Split(" ")(1)
            历史piaoshu(j) = Convert.ToInt32(历史s(j).Split(" ")(2))
            历史jine(j) = Convert.ToInt32(历史s(j).Split(" ")(3))
        Next

        Dim 游戏s() As String
        Dim 游戏length As Integer
        游戏s = File.ReadAllLines("youxidongman.txt")
        游戏length = 游戏s.GetUpperBound(0)
        Dim 游戏yyyy(游戏length) As Integer
        Dim 游戏zhonglei(游戏length) As String
        Dim 游戏piaoshu(游戏length) As Double
        Dim 游戏jine(游戏length) As Double
        For j = 0 To 游戏length
            游戏yyyy(j) = Convert.ToInt32((游戏s(j).Split(" ")(0)).Split("/")(0))
            游戏zhonglei(j) = 游戏s(j).Split(" ")(1)
            游戏piaoshu(j) = Convert.ToInt32(游戏s(j).Split(" ")(2))
            游戏jine(j) = Convert.ToInt32(游戏s(j).Split(" ")(3))
        Next

        Dim 成人jine(2) As Integer
        Dim 老年jine(2) As Integer
        Dim 学生jine(2) As Integer
        Dim 儿童jine(2) As Integer
        Dim 集体jine(2) As Integer

        Dim 成人piaoshu(2) As Integer
        Dim 老年piaoshu(2) As Integer
        Dim 学生piaoshu(2) As Integer
        Dim 儿童piaoshu(2) As Integer
        Dim 集体piaoshu(2) As Integer

        For i = 0 To 天文length
            If 天文zhonglei(i) = "成人票" And yyyy = 天文yyyy(i) Then
                成人jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "老年票" And yyyy = 天文yyyy(i) Then
                老年jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "学生票" And yyyy = 天文yyyy(i) Then
                学生jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "儿童票" And yyyy = 天文yyyy(i) Then
                儿童jine(0) += 天文jine(i)
            ElseIf 天文zhonglei(i) = "集体票" And yyyy = 天文yyyy(i) Then
                集体jine(0) += 天文jine(i)
            End If
        Next

        For i = 0 To 历史length
            If 历史zhonglei(i) = "成人票" And yyyy = 历史yyyy(i) Then
                成人jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "老年票" And yyyy = 历史yyyy(i) Then
                老年jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "学生票" And yyyy = 历史yyyy(i) Then
                学生jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "儿童票" And yyyy = 历史yyyy(i) Then
                儿童jine(1) += 历史jine(i)
            ElseIf 历史zhonglei(i) = "集体票" And yyyy = 历史yyyy(i) Then
                集体jine(1) += 历史jine(i)
            End If
        Next

        For i = 0 To 游戏length
            If 游戏zhonglei(i) = "成人票" And yyyy = 游戏yyyy(i) Then
                成人jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "老年票" And yyyy = 游戏yyyy(i) Then
                老年jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "学生票" And yyyy = 游戏yyyy(i) Then
                学生jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "儿童票" And yyyy = 游戏yyyy(i) Then
                儿童jine(2) += 游戏jine(i)
            ElseIf 游戏zhonglei(i) = "集体票" And yyyy = 游戏yyyy(i) Then
                集体jine(2) += 游戏jine(i)
            End If
        Next

        For i = 0 To 天文length
            If 天文zhonglei(i) = "成人票" And yyyy = 天文yyyy(i) Then
                成人piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "老年票" And yyyy = 天文yyyy(i) Then
                老年piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "学生票" And yyyy = 天文yyyy(i) Then
                学生piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "儿童票" And yyyy = 天文yyyy(i) Then
                儿童piaoshu(0) += 天文piaoshu(i)
            ElseIf 天文zhonglei(i) = "集体票" And yyyy = 天文yyyy(i) Then
                集体piaoshu(0) += 天文piaoshu(i)
            End If
        Next

        For i = 0 To 历史length
            If 历史zhonglei(i) = "成人票" And yyyy = 历史yyyy(i) Then
                成人piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "老年票" And yyyy = 历史yyyy(i) Then
                老年piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "学生票" And yyyy = 历史yyyy(i) Then
                学生piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "儿童票" And yyyy = 历史yyyy(i) Then
                儿童piaoshu(1) += 历史piaoshu(i)
            ElseIf 历史zhonglei(i) = "集体票" And yyyy = 历史yyyy(i) Then
                集体piaoshu(1) += 历史piaoshu(i)
            End If
        Next

        For i = 0 To 游戏length
            If 游戏zhonglei(i) = "成人票" And yyyy = 游戏yyyy(i) Then
                成人piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "老年票" And yyyy = 游戏yyyy(i) Then
                老年piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "学生票" And yyyy = 游戏yyyy(i) Then
                学生piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "儿童票" And yyyy = 游戏yyyy(i) Then
                儿童piaoshu(2) += 游戏piaoshu(i)
            ElseIf 游戏zhonglei(i) = "集体票" And yyyy = 游戏yyyy(i) Then
                集体piaoshu(2) += 游戏piaoshu(i)
            End If
        Next

        For i = 0 To 4
            For j = 0 To 2
                If i = 0 Then
                    表一.Series(0).Points(j).YValues = {成人piaoshu(j)}
                    表一.Series(0).Points(j).Label = 成人piaoshu(j)
                ElseIf i = 1 Then
                    表一.Series(1).Points(j).YValues = {老年piaoshu(j)}
                    表一.Series(1).Points(j).Label = 老年piaoshu(j)
                ElseIf i = 2 Then
                    表一.Series(2).Points(j).YValues = {学生piaoshu(j)}
                    表一.Series(2).Points(j).Label = 学生piaoshu(j)
                ElseIf i = 3 Then
                    表一.Series(3).Points(j).YValues = {儿童piaoshu(j)}
                    表一.Series(3).Points(j).Label = 儿童piaoshu(j)
                ElseIf i = 4 Then
                    表一.Series(4).Points(j).YValues = {集体piaoshu(j)}
                    表一.Series(4).Points(j).Label = 集体piaoshu(j)
                End If
            Next
        Next

        For i = 0 To 4
            For j = 0 To 2
                If i = 0 Then
                    表二.Series(0).Points(j).YValues = {成人jine(j)}
                    表二.Series(0).Points(j).Label = 成人jine(j)
                ElseIf i = 1 Then
                    表二.Series(1).Points(j).YValues = {老年jine(j)}
                    表二.Series(1).Points(j).Label = 老年jine(j)
                ElseIf i = 2 Then
                    表二.Series(2).Points(j).YValues = {学生jine(j)}
                    表二.Series(2).Points(j).Label = 学生jine(j)
                ElseIf i = 3 Then
                    表二.Series(3).Points(j).YValues = {儿童jine(j)}
                    表二.Series(3).Points(j).Label = 儿童jine(j)
                ElseIf i = 4 Then
                    表二.Series(4).Points(j).YValues = {集体jine(j)}
                    表二.Series(4).Points(j).Label = 集体jine(j)
                End If
            Next
        Next

        Dim sum2 As Integer = 0
        Dim sum1 As Integer = 0
        For i = 0 To 2
            sum2 += 成人piaoshu(i) + 老年piaoshu(i) + 学生piaoshu(i) + 儿童piaoshu(i) + 集体piaoshu(i)
            sum1 += 成人jine(i) + 老年jine(i) + 学生jine(i) + 儿童jine(i) + 集体jine(i)
        Next
        票数.Text = "共卖出" & sum2 & "张票"
        钱数.Text = "共收入" & sum1 & "元"
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 2 Then
            Me.Hide()
            Form11.Show()
        End If
    End Sub

End Class
