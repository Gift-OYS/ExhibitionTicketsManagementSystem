<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.L = New System.Windows.Forms.Label()
        Me.标题7 = New System.Windows.Forms.Label()
        Me.支付宝 = New System.Windows.Forms.Button()
        Me.现金 = New System.Windows.Forms.Button()
        Me.微信 = New System.Windows.Forms.Button()
        Me.下一步 = New System.Windows.Forms.Button()
        Me.标题6 = New System.Windows.Forms.Label()
        Me.标题5 = New System.Windows.Forms.Label()
        Me.标题3 = New System.Windows.Forms.Label()
        Me.标题2 = New System.Windows.Forms.Label()
        Me.标题1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.BackColor = System.Drawing.Color.Transparent
        Me.L.Location = New System.Drawing.Point(363, 206)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(15, 15)
        Me.L.TabIndex = 30
        Me.L.Text = " "
        Me.L.Visible = False
        '
        '标题7
        '
        Me.标题7.AutoSize = True
        Me.标题7.BackColor = System.Drawing.Color.Transparent
        Me.标题7.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题7.Location = New System.Drawing.Point(166, 228)
        Me.标题7.Name = "标题7"
        Me.标题7.Size = New System.Drawing.Size(159, 20)
        Me.标题7.TabIndex = 29
        Me.标题7.Text = "请选择您的付款方式："
        '
        '支付宝
        '
        Me.支付宝.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.支付宝.Location = New System.Drawing.Point(263, 261)
        Me.支付宝.Name = "支付宝"
        Me.支付宝.Size = New System.Drawing.Size(62, 27)
        Me.支付宝.TabIndex = 28
        Me.支付宝.Text = "支付宝"
        Me.支付宝.UseVisualStyleBackColor = True
        '
        '现金
        '
        Me.现金.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.现金.Location = New System.Drawing.Point(153, 261)
        Me.现金.Name = "现金"
        Me.现金.Size = New System.Drawing.Size(49, 27)
        Me.现金.TabIndex = 27
        Me.现金.Text = "现金"
        Me.现金.UseVisualStyleBackColor = True
        '
        '微信
        '
        Me.微信.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.微信.Location = New System.Drawing.Point(208, 261)
        Me.微信.Name = "微信"
        Me.微信.Size = New System.Drawing.Size(49, 27)
        Me.微信.TabIndex = 26
        Me.微信.Text = "微信"
        Me.微信.UseVisualStyleBackColor = True
        '
        '下一步
        '
        Me.下一步.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.下一步.Location = New System.Drawing.Point(421, 271)
        Me.下一步.Name = "下一步"
        Me.下一步.Size = New System.Drawing.Size(79, 42)
        Me.下一步.TabIndex = 25
        Me.下一步.Text = "下一步"
        Me.下一步.UseVisualStyleBackColor = True
        '
        '标题6
        '
        Me.标题6.AutoSize = True
        Me.标题6.BackColor = System.Drawing.Color.Transparent
        Me.标题6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题6.Location = New System.Drawing.Point(95, 163)
        Me.标题6.Name = "标题6"
        Me.标题6.Size = New System.Drawing.Size(312, 27)
        Me.标题6.TabIndex = 24
        Me.标题6.Text = "请出示监护人【身份证】并付款！"
        '
        '标题5
        '
        Me.标题5.AutoSize = True
        Me.标题5.BackColor = System.Drawing.Color.Transparent
        Me.标题5.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题5.Location = New System.Drawing.Point(258, 115)
        Me.标题5.Name = "标题5"
        Me.标题5.Size = New System.Drawing.Size(72, 25)
        Me.标题5.TabIndex = 23
        Me.标题5.Text = "Label5"
        '
        '标题3
        '
        Me.标题3.AutoSize = True
        Me.标题3.BackColor = System.Drawing.Color.Transparent
        Me.标题3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题3.Location = New System.Drawing.Point(331, 113)
        Me.标题3.Name = "标题3"
        Me.标题3.Size = New System.Drawing.Size(32, 27)
        Me.标题3.TabIndex = 22
        Me.标题3.Text = "元"
        '
        '标题2
        '
        Me.标题2.AutoSize = True
        Me.标题2.BackColor = System.Drawing.Color.Transparent
        Me.标题2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题2.Location = New System.Drawing.Point(132, 113)
        Me.标题2.Name = "标题2"
        Me.标题2.Size = New System.Drawing.Size(132, 27)
        Me.标题2.TabIndex = 21
        Me.标题2.Text = "应付金额为："
        '
        '标题1
        '
        Me.标题1.AutoSize = True
        Me.标题1.BackColor = System.Drawing.Color.Transparent
        Me.标题1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题1.Location = New System.Drawing.Point(123, 34)
        Me.标题1.Name = "标题1"
        Me.标题1.Size = New System.Drawing.Size(292, 27)
        Me.标题1.TabIndex = 20
        Me.标题1.Text = "一名儿童必须有一位监护人陪同"
        '
        'Form7
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(500, 313)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.标题7)
        Me.Controls.Add(Me.支付宝)
        Me.Controls.Add(Me.现金)
        Me.Controls.Add(Me.微信)
        Me.Controls.Add(Me.下一步)
        Me.Controls.Add(Me.标题6)
        Me.Controls.Add(Me.标题5)
        Me.Controls.Add(Me.标题3)
        Me.Controls.Add(Me.标题2)
        Me.Controls.Add(Me.标题1)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "支付窗口"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L As Label
    Friend WithEvents 标题7 As Label
    Friend WithEvents 支付宝 As Button
    Friend WithEvents 现金 As Button
    Friend WithEvents 微信 As Button
    Friend WithEvents 下一步 As Button
    Friend WithEvents 标题6 As Label
    Friend WithEvents 标题5 As Label
    Friend WithEvents 标题3 As Label
    Friend WithEvents 标题2 As Label
    Friend WithEvents 标题1 As Label
End Class
