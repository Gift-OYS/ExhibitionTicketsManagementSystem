<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.确定 = New System.Windows.Forms.Button()
        Me.标题 = New System.Windows.Forms.Label()
        Me.输入框 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        '确定
        '
        Me.确定.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.确定.Location = New System.Drawing.Point(123, 149)
        Me.确定.Name = "确定"
        Me.确定.Size = New System.Drawing.Size(75, 37)
        Me.确定.TabIndex = 5
        Me.确定.Text = "确定"
        Me.确定.UseVisualStyleBackColor = True
        '
        '标题
        '
        Me.标题.AutoSize = True
        Me.标题.BackColor = System.Drawing.Color.Transparent
        Me.标题.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标题.ForeColor = System.Drawing.Color.White
        Me.标题.Location = New System.Drawing.Point(53, 24)
        Me.标题.Name = "标题"
        Me.标题.Size = New System.Drawing.Size(232, 54)
        Me.标题.TabIndex = 4
        Me.标题.Text = "本页面需要管理员权限，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "请输入管理员密码："
        '
        '输入框
        '
        Me.输入框.Location = New System.Drawing.Point(98, 97)
        Me.输入框.Multiline = True
        Me.输入框.Name = "输入框"
        Me.输入框.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.输入框.Size = New System.Drawing.Size(124, 31)
        Me.输入框.TabIndex = 3
        '
        'Form11
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(338, 210)
        Me.Controls.Add(Me.确定)
        Me.Controls.Add(Me.标题)
        Me.Controls.Add(Me.输入框)
        Me.Name = "Form11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "管理员身份验证"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 确定 As Button
    Friend WithEvents 标题 As Label
    Friend WithEvents 输入框 As TextBox
End Class
