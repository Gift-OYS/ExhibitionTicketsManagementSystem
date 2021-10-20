<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TextAnnotation5 As System.Windows.Forms.DataVisualization.Charting.TextAnnotation = New System.Windows.Forms.DataVisualization.Charting.TextAnnotation()
        Dim TextAnnotation6 As System.Windows.Forms.DataVisualization.Charting.TextAnnotation = New System.Windows.Forms.DataVisualization.Charting.TextAnnotation()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim TextAnnotation7 As System.Windows.Forms.DataVisualization.Charting.TextAnnotation = New System.Windows.Forms.DataVisualization.Charting.TextAnnotation()
        Dim TextAnnotation8 As System.Windows.Forms.DataVisualization.Charting.TextAnnotation = New System.Windows.Forms.DataVisualization.Charting.TextAnnotation()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.欢迎界面 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.售票大厅 = New System.Windows.Forms.TabPage()
        Me.游戏动漫展 = New System.Windows.Forms.Button()
        Me.历史文物展 = New System.Windows.Forms.Button()
        Me.天文科技展 = New System.Windows.Forms.Button()
        Me.后台统计 = New System.Windows.Forms.TabPage()
        Me.钱数 = New System.Windows.Forms.Label()
        Me.票数 = New System.Windows.Forms.Label()
        Me.表二 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.表一 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.按日统计 = New System.Windows.Forms.Button()
        Me.按月统计 = New System.Windows.Forms.Button()
        Me.按年统计 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.欢迎界面.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.售票大厅.SuspendLayout()
        Me.后台统计.SuspendLayout()
        CType(Me.表二, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.表一, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '欢迎界面
        '
        Me.欢迎界面.BackgroundImage = CType(resources.GetObject("欢迎界面.BackgroundImage"), System.Drawing.Image)
        Me.欢迎界面.Controls.Add(Me.Label4)
        Me.欢迎界面.Controls.Add(Me.Label5)
        Me.欢迎界面.Controls.Add(Me.Label6)
        Me.欢迎界面.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.欢迎界面.Location = New System.Drawing.Point(4, 25)
        Me.欢迎界面.Name = "欢迎界面"
        Me.欢迎界面.Padding = New System.Windows.Forms.Padding(3)
        Me.欢迎界面.Size = New System.Drawing.Size(804, 439)
        Me.欢迎界面.TabIndex = 0
        Me.欢迎界面.Text = "欢迎界面"
        Me.欢迎界面.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(149, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(556, 162)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "天文科技展：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "成人票：50 老年票：40 学生票：30 儿童票：30 集体票：35" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "历史文物展：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "成人票：45 老年票：35 学生票：25 儿童票：25 集" &
    "体票：30" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "天文科技展：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "成人票：40 老年票：30 学生票：25 儿童票：25 集体票：30"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(96, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 27)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "寒假大促！"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("隶书", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(85, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(635, 43)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "欢迎来到展览馆门票管理系统！"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.欢迎界面)
        Me.TabControl1.Controls.Add(Me.售票大厅)
        Me.TabControl1.Controls.Add(Me.后台统计)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(812, 468)
        Me.TabControl1.TabIndex = 1
        '
        '售票大厅
        '
        Me.售票大厅.BackgroundImage = CType(resources.GetObject("售票大厅.BackgroundImage"), System.Drawing.Image)
        Me.售票大厅.Controls.Add(Me.游戏动漫展)
        Me.售票大厅.Controls.Add(Me.历史文物展)
        Me.售票大厅.Controls.Add(Me.天文科技展)
        Me.售票大厅.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.售票大厅.Location = New System.Drawing.Point(4, 25)
        Me.售票大厅.Name = "售票大厅"
        Me.售票大厅.Padding = New System.Windows.Forms.Padding(3)
        Me.售票大厅.Size = New System.Drawing.Size(804, 439)
        Me.售票大厅.TabIndex = 4
        Me.售票大厅.Text = "售票大厅"
        Me.售票大厅.UseVisualStyleBackColor = True
        '
        '游戏动漫展
        '
        Me.游戏动漫展.BackgroundImage = CType(resources.GetObject("游戏动漫展.BackgroundImage"), System.Drawing.Image)
        Me.游戏动漫展.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.游戏动漫展.ForeColor = System.Drawing.Color.Black
        Me.游戏动漫展.Location = New System.Drawing.Point(538, 90)
        Me.游戏动漫展.Name = "游戏动漫展"
        Me.游戏动漫展.Size = New System.Drawing.Size(124, 259)
        Me.游戏动漫展.TabIndex = 5
        Me.游戏动漫展.Text = "游戏动漫展"
        Me.游戏动漫展.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.游戏动漫展.UseVisualStyleBackColor = True
        '
        '历史文物展
        '
        Me.历史文物展.BackgroundImage = CType(resources.GetObject("历史文物展.BackgroundImage"), System.Drawing.Image)
        Me.历史文物展.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.历史文物展.ForeColor = System.Drawing.Color.White
        Me.历史文物展.Location = New System.Drawing.Point(340, 90)
        Me.历史文物展.Name = "历史文物展"
        Me.历史文物展.Size = New System.Drawing.Size(124, 259)
        Me.历史文物展.TabIndex = 4
        Me.历史文物展.Text = "历史文物展"
        Me.历史文物展.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.历史文物展.UseVisualStyleBackColor = True
        '
        '天文科技展
        '
        Me.天文科技展.BackgroundImage = CType(resources.GetObject("天文科技展.BackgroundImage"), System.Drawing.Image)
        Me.天文科技展.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.天文科技展.ForeColor = System.Drawing.Color.White
        Me.天文科技展.Location = New System.Drawing.Point(142, 90)
        Me.天文科技展.Name = "天文科技展"
        Me.天文科技展.Size = New System.Drawing.Size(124, 259)
        Me.天文科技展.TabIndex = 3
        Me.天文科技展.Text = "天文科技展"
        Me.天文科技展.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.天文科技展.UseVisualStyleBackColor = True
        '
        '后台统计
        '
        Me.后台统计.BackgroundImage = CType(resources.GetObject("后台统计.BackgroundImage"), System.Drawing.Image)
        Me.后台统计.Controls.Add(Me.Label1)
        Me.后台统计.Controls.Add(Me.钱数)
        Me.后台统计.Controls.Add(Me.票数)
        Me.后台统计.Controls.Add(Me.表二)
        Me.后台统计.Controls.Add(Me.表一)
        Me.后台统计.Controls.Add(Me.按日统计)
        Me.后台统计.Controls.Add(Me.按月统计)
        Me.后台统计.Controls.Add(Me.按年统计)
        Me.后台统计.Controls.Add(Me.DateTimePicker1)
        Me.后台统计.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.后台统计.Location = New System.Drawing.Point(4, 25)
        Me.后台统计.Name = "后台统计"
        Me.后台统计.Padding = New System.Windows.Forms.Padding(3)
        Me.后台统计.Size = New System.Drawing.Size(804, 439)
        Me.后台统计.TabIndex = 5
        Me.后台统计.Text = "后台统计"
        Me.后台统计.UseVisualStyleBackColor = True
        '
        '钱数
        '
        Me.钱数.AutoSize = True
        Me.钱数.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.钱数.Location = New System.Drawing.Point(513, 370)
        Me.钱数.Name = "钱数"
        Me.钱数.Size = New System.Drawing.Size(0, 25)
        Me.钱数.TabIndex = 23
        '
        '票数
        '
        Me.票数.AutoSize = True
        Me.票数.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.票数.Location = New System.Drawing.Point(136, 370)
        Me.票数.Name = "票数"
        Me.票数.Size = New System.Drawing.Size(0, 25)
        Me.票数.TabIndex = 22
        '
        '表二
        '
        TextAnnotation5.Name = "TextAnnotation1"
        TextAnnotation5.Text = "金额"
        TextAnnotation5.X = 5.0R
        TextAnnotation5.Y = 5.0R
        TextAnnotation6.Name = "TextAnnotation2"
        TextAnnotation6.Text = "展览种类"
        TextAnnotation6.X = 70.0R
        TextAnnotation6.Y = 85.0R
        Me.表二.Annotations.Add(TextAnnotation5)
        Me.表二.Annotations.Add(TextAnnotation6)
        Me.表二.BackColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.表二.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.表二.Legends.Add(Legend3)
        Me.表二.Location = New System.Drawing.Point(427, 100)
        Me.表二.Name = "表二"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.表二.Series.Add(Series3)
        Me.表二.Size = New System.Drawing.Size(309, 267)
        Me.表二.TabIndex = 21
        Me.表二.Text = "表二"
        Title3.Name = "售票金额统计"
        Title3.Text = "售票数量统计"
        Me.表二.Titles.Add(Title3)
        '
        '表一
        '
        TextAnnotation7.Name = "TextAnnotation1"
        TextAnnotation7.Text = "数量"
        TextAnnotation7.X = 5.0R
        TextAnnotation7.Y = 5.0R
        TextAnnotation8.Name = "TextAnnotation2"
        TextAnnotation8.Text = "展览种类"
        TextAnnotation8.X = 70.0R
        TextAnnotation8.Y = 85.0R
        Me.表一.Annotations.Add(TextAnnotation7)
        Me.表一.Annotations.Add(TextAnnotation8)
        Me.表一.BackColor = System.Drawing.Color.Transparent
        ChartArea4.Name = "ChartArea1"
        Me.表一.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.表一.Legends.Add(Legend4)
        Me.表一.Location = New System.Drawing.Point(69, 100)
        Me.表一.Name = "表一"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.表一.Series.Add(Series4)
        Me.表一.Size = New System.Drawing.Size(309, 267)
        Me.表一.TabIndex = 20
        Me.表一.Text = "表一"
        Title4.Name = "售票数量统计"
        Title4.Text = "售票数量统计"
        Me.表一.Titles.Add(Title4)
        '
        '按日统计
        '
        Me.按日统计.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.按日统计.Location = New System.Drawing.Point(587, 39)
        Me.按日统计.Name = "按日统计"
        Me.按日统计.Size = New System.Drawing.Size(88, 34)
        Me.按日统计.TabIndex = 19
        Me.按日统计.Text = "按日统计"
        Me.按日统计.UseVisualStyleBackColor = True
        '
        '按月统计
        '
        Me.按月统计.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.按月统计.Location = New System.Drawing.Point(484, 39)
        Me.按月统计.Name = "按月统计"
        Me.按月统计.Size = New System.Drawing.Size(88, 34)
        Me.按月统计.TabIndex = 18
        Me.按月统计.Text = "按月统计"
        Me.按月统计.UseVisualStyleBackColor = True
        '
        '按年统计
        '
        Me.按年统计.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.按年统计.Location = New System.Drawing.Point(379, 39)
        Me.按年统计.Name = "按年统计"
        Me.按年统计.Size = New System.Drawing.Size(88, 34)
        Me.按年统计.TabIndex = 17
        Me.按年统计.Text = "按年统计"
        Me.按年统计.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(141, 42)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 27)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 6.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(681, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 34)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "受纵坐标范围的限制，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "建议按年月日的顺序"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(810, 465)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "售票管理系统"
        Me.欢迎界面.ResumeLayout(False)
        Me.欢迎界面.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.售票大厅.ResumeLayout(False)
        Me.后台统计.ResumeLayout(False)
        Me.后台统计.PerformLayout()
        CType(Me.表二, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.表一, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 欢迎界面 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents 售票大厅 As TabPage
    Friend WithEvents 游戏动漫展 As Button
    Friend WithEvents 历史文物展 As Button
    Friend WithEvents 天文科技展 As Button
    Friend WithEvents 后台统计 As TabPage
    Friend WithEvents 钱数 As Label
    Friend WithEvents 票数 As Label
    Friend WithEvents 表二 As DataVisualization.Charting.Chart
    Friend WithEvents 表一 As DataVisualization.Charting.Chart
    Friend WithEvents 按日统计 As Button
    Friend WithEvents 按月统计 As Button
    Friend WithEvents 按年统计 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
