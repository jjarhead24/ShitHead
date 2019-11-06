<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.cmdStore = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdPlay
        '
        Me.cmdPlay.BackColor = System.Drawing.Color.Yellow
        Me.cmdPlay.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.cmdPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPlay.ForeColor = System.Drawing.Color.Yellow
        Me.cmdPlay.Location = New System.Drawing.Point(51, 84)
        Me.cmdPlay.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(190, 54)
        Me.cmdPlay.TabIndex = 0
        Me.cmdPlay.Text = "Play ShitHead"
        Me.cmdPlay.UseVisualStyleBackColor = False
        '
        'cmdStore
        '
        Me.cmdStore.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.cmdStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdStore.ForeColor = System.Drawing.Color.Yellow
        Me.cmdStore.Location = New System.Drawing.Point(51, 160)
        Me.cmdStore.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdStore.Name = "cmdStore"
        Me.cmdStore.Size = New System.Drawing.Size(190, 54)
        Me.cmdStore.TabIndex = 1
        Me.cmdStore.Text = "Store"
        Me.cmdStore.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.ForeColor = System.Drawing.Color.Yellow
        Me.cmdExit.Location = New System.Drawing.Point(10, 239)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(177, 32)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Quit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(-2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 73)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ShitHead"
        '
        'btnLogOut
        '
        Me.btnLogOut.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.ForeColor = System.Drawing.Color.Yellow
        Me.btnLogOut.Location = New System.Drawing.Point(191, 239)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(85, 32)
        Me.btnLogOut.TabIndex = 5
        Me.btnLogOut.Text = "LogOut"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(287, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdStore)
        Me.Controls.Add(Me.cmdPlay)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPlay As Button
    Friend WithEvents cmdStore As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogOut As Button
End Class
