<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.标题2 = New System.Windows.Forms.Label()
        Me.标题1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(150, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(266, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = " "
        '
        '标题2
        '
        Me.标题2.AutoSize = True
        Me.标题2.BackColor = System.Drawing.Color.Transparent
        Me.标题2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题2.Location = New System.Drawing.Point(69, 96)
        Me.标题2.Name = "标题2"
        Me.标题2.Size = New System.Drawing.Size(252, 27)
        Me.标题2.TabIndex = 6
        Me.标题2.Text = "购票成功，祝您玩得愉快！"
        '
        '标题1
        '
        Me.标题1.AutoSize = True
        Me.标题1.BackColor = System.Drawing.Color.Transparent
        Me.标题1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题1.Location = New System.Drawing.Point(69, 51)
        Me.标题1.Name = "标题1"
        Me.标题1.Size = New System.Drawing.Size(232, 27)
        Me.标题1.TabIndex = 5
        Me.标题1.Text = "身份核验及付款中。。。"
        '
        'Form4
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(390, 218)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.标题2)
        Me.Controls.Add(Me.标题1)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "购票结果"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents 标题2 As Label
    Friend WithEvents 标题1 As Label
End Class
