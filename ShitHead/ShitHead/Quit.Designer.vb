<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quit
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
        Me.cmdNo = New System.Windows.Forms.Button()
        Me.cmdYes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdNo
        '
        Me.cmdNo.Location = New System.Drawing.Point(149, 140)
        Me.cmdNo.Name = "cmdNo"
        Me.cmdNo.Size = New System.Drawing.Size(75, 23)
        Me.cmdNo.TabIndex = 0
        Me.cmdNo.Text = "No"
        Me.cmdNo.UseVisualStyleBackColor = True
        '
        'cmdYes
        '
        Me.cmdYes.Location = New System.Drawing.Point(336, 140)
        Me.cmdYes.Name = "cmdYes"
        Me.cmdYes.Size = New System.Drawing.Size(75, 23)
        Me.cmdYes.TabIndex = 1
        Me.cmdYes.Text = "Yes"
        Me.cmdYes.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdYes)
        Me.Controls.Add(Me.cmdNo)
        Me.Name = "Quit"
        Me.Text = "Quit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdNo As Button
    Friend WithEvents cmdYes As Button
End Class
