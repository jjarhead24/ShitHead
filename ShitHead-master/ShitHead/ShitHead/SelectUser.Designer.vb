<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectUser
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
        Me.lbUsers = New System.Windows.Forms.ListBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbUsers
        '
        Me.lbUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbUsers.FormattingEnabled = True
        Me.lbUsers.Location = New System.Drawing.Point(0, 0)
        Me.lbUsers.Name = "lbUsers"
        Me.lbUsers.Size = New System.Drawing.Size(227, 225)
        Me.lbUsers.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNew.Location = New System.Drawing.Point(0, 225)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(227, 30)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New User"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'SelectUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 255)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lbUsers)
        Me.Name = "SelectUser"
        Me.Text = "SelectUser"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbUsers As ListBox
    Friend WithEvents btnNew As Button
End Class
