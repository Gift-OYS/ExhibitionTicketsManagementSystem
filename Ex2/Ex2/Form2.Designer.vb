<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.标题8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.标题6 = New System.Windows.Forms.Label()
        Me.标题5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.标题4 = New System.Windows.Forms.Label()
        Me.标题3 = New System.Windows.Forms.Label()
        Me.标题2 = New System.Windows.Forms.Label()
        Me.集体票 = New System.Windows.Forms.RadioButton()
        Me.儿童票 = New System.Windows.Forms.RadioButton()
        Me.学生票 = New System.Windows.Forms.RadioButton()
        Me.老年票 = New System.Windows.Forms.RadioButton()
        Me.成人票 = New System.Windows.Forms.RadioButton()
        Me.下一步 = New System.Windows.Forms.Button()
        Me.标题1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '标题8
        '
        Me.标题8.AutoSize = True
        Me.标题8.BackColor = System.Drawing.Color.Transparent
        Me.标题8.Font = New System.Drawing.Font("微软雅黑", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题8.Location = New System.Drawing.Point(252, 265)
        Me.标题8.Name = "标题8"
        Me.标题8.Size = New System.Drawing.Size(124, 27)
        Me.标题8.TabIndex = 30
        Me.标题8.Text = "▶在线预约◀"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(405, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        '标题6
        '
        Me.标题6.AutoSize = True
        Me.标题6.BackColor = System.Drawing.Color.Transparent
        Me.标题6.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题6.Location = New System.Drawing.Point(283, 102)
        Me.标题6.Name = "标题6"
        Me.标题6.Size = New System.Drawing.Size(50, 25)
        Me.标题6.TabIndex = 28
        Me.标题6.Text = "还剩"
        '
        '标题5
        '
        Me.标题5.AutoSize = True
        Me.标题5.BackColor = System.Drawing.Color.Transparent
        Me.标题5.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题5.Location = New System.Drawing.Point(396, 180)
        Me.标题5.Name = "标题5"
        Me.标题5.Size = New System.Drawing.Size(31, 25)
        Me.标题5.TabIndex = 27
        Me.标题5.Text = "张"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(335, 177)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(55, 32)
        Me.ComboBox1.TabIndex = 26
        '
        '标题4
        '
        Me.标题4.AutoSize = True
        Me.标题4.BackColor = System.Drawing.Color.Transparent
        Me.标题4.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题4.Location = New System.Drawing.Point(264, 140)
        Me.标题4.Name = "标题4"
        Me.标题4.Size = New System.Drawing.Size(202, 25)
        Me.标题4.TabIndex = 25
        Me.标题4.Text = "请选择您要购买的票数"
        '
        '标题3
        '
        Me.标题3.AutoSize = True
        Me.标题3.BackColor = System.Drawing.Color.Transparent
        Me.标题3.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题3.Location = New System.Drawing.Point(415, 102)
        Me.标题3.Name = "标题3"
        Me.标题3.Size = New System.Drawing.Size(31, 25)
        Me.标题3.TabIndex = 24
        Me.标题3.Text = "张"
        '
        '标题2
        '
        Me.标题2.AutoSize = True
        Me.标题2.BackColor = System.Drawing.Color.Transparent
        Me.标题2.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题2.Location = New System.Drawing.Point(335, 102)
        Me.标题2.Name = "标题2"
        Me.标题2.Size = New System.Drawing.Size(72, 25)
        Me.标题2.TabIndex = 23
        Me.标题2.Text = "Label2"
        '
        '集体票
        '
        Me.集体票.AutoSize = True
        Me.集体票.BackColor = System.Drawing.Color.Transparent
        Me.集体票.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.集体票.Location = New System.Drawing.Point(82, 215)
        Me.集体票.Name = "集体票"
        Me.集体票.Size = New System.Drawing.Size(90, 29)
        Me.集体票.TabIndex = 22
        Me.集体票.TabStop = True
        Me.集体票.Text = "集体票"
        Me.集体票.UseVisualStyleBackColor = False
        '
        '儿童票
        '
        Me.儿童票.AutoSize = True
        Me.儿童票.BackColor = System.Drawing.Color.Transparent
        Me.儿童票.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.儿童票.Location = New System.Drawing.Point(82, 180)
        Me.儿童票.Name = "儿童票"
        Me.儿童票.Size = New System.Drawing.Size(90, 29)
        Me.儿童票.TabIndex = 21
        Me.儿童票.TabStop = True
        Me.儿童票.Text = "儿童票"
        Me.儿童票.UseVisualStyleBackColor = False
        '
        '学生票
        '
        Me.学生票.AutoSize = True
        Me.学生票.BackColor = System.Drawing.Color.Transparent
        Me.学生票.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.学生票.Location = New System.Drawing.Point(82, 145)
        Me.学生票.Name = "学生票"
        Me.学生票.Size = New System.Drawing.Size(90, 29)
        Me.学生票.TabIndex = 20
        Me.学生票.TabStop = True
        Me.学生票.Text = "学生票"
        Me.学生票.UseVisualStyleBackColor = False
        '
        '老年票
        '
        Me.老年票.AutoSize = True
        Me.老年票.BackColor = System.Drawing.Color.Transparent
        Me.老年票.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.老年票.Location = New System.Drawing.Point(82, 114)
        Me.老年票.Name = "老年票"
        Me.老年票.Size = New System.Drawing.Size(90, 29)
        Me.老年票.TabIndex = 19
        Me.老年票.TabStop = True
        Me.老年票.Text = "老年票"
        Me.老年票.UseVisualStyleBackColor = False
        '
        '成人票
        '
        Me.成人票.AutoSize = True
        Me.成人票.BackColor = System.Drawing.Color.Transparent
        Me.成人票.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.成人票.Location = New System.Drawing.Point(82, 79)
        Me.成人票.Name = "成人票"
        Me.成人票.Size = New System.Drawing.Size(90, 29)
        Me.成人票.TabIndex = 18
        Me.成人票.TabStop = True
        Me.成人票.Text = "成人票"
        Me.成人票.UseVisualStyleBackColor = False
        '
        '下一步
        '
        Me.下一步.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.下一步.Location = New System.Drawing.Point(434, 269)
        Me.下一步.Name = "下一步"
        Me.下一步.Size = New System.Drawing.Size(79, 42)
        Me.下一步.TabIndex = 17
        Me.下一步.Text = "下一步"
        Me.下一步.UseVisualStyleBackColor = True
        '
        '标题1
        '
        Me.标题1.AutoSize = True
        Me.标题1.BackColor = System.Drawing.Color.Transparent
        Me.标题1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题1.Location = New System.Drawing.Point(49, 36)
        Me.标题1.Name = "标题1"
        Me.标题1.Size = New System.Drawing.Size(221, 25)
        Me.标题1.TabIndex = 16
        Me.标题1.Text = "请选择您要购买的种类："
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(512, 313)
        Me.Controls.Add(Me.标题8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.标题6)
        Me.Controls.Add(Me.标题5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.标题4)
        Me.Controls.Add(Me.标题3)
        Me.Controls.Add(Me.标题2)
        Me.Controls.Add(Me.集体票)
        Me.Controls.Add(Me.儿童票)
        Me.Controls.Add(Me.学生票)
        Me.Controls.Add(Me.老年票)
        Me.Controls.Add(Me.成人票)
        Me.Controls.Add(Me.下一步)
        Me.Controls.Add(Me.标题1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "购票窗口"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 标题8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents 标题6 As Label
    Friend WithEvents 标题5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents 标题4 As Label
    Friend WithEvents 标题3 As Label
    Friend WithEvents 标题2 As Label
    Friend WithEvents 集体票 As RadioButton
    Friend WithEvents 儿童票 As RadioButton
    Friend WithEvents 学生票 As RadioButton
    Friend WithEvents 老年票 As RadioButton
    Friend WithEvents 成人票 As RadioButton
    Friend WithEvents 下一步 As Button
    Friend WithEvents 标题1 As Label
End Class
