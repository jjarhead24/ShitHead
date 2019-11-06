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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdNo
        '
        Me.cmdNo.BackColor = System.Drawing.Color.Transparent
        Me.cmdNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNo.ForeColor = System.Drawing.Color.Yellow
        Me.cmdNo.Location = New System.Drawing.Point(12, 65)
        Me.cmdNo.Name = "cmdNo"
        Me.cmdNo.Size = New System.Drawing.Size(135, 43)
        Me.cmdNo.TabIndex = 0
        Me.cmdNo.Text = "No"
        Me.cmdNo.UseVisualStyleBackColor = False
        '
        'cmdYes
        '
        Me.cmdYes.BackColor = System.Drawing.Color.Transparent
        Me.cmdYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdYes.ForeColor = System.Drawing.Color.Yellow
        Me.cmdYes.Location = New System.Drawing.Point(172, 65)
        Me.cmdYes.Name = "cmdYes"
        Me.cmdYes.Size = New System.Drawing.Size(135, 43)
        Me.cmdYes.TabIndex = 1
        Me.cmdYes.Text = "Yes"
        Me.cmdYes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(28, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Are you sure you want to quit?"
        '
        'Quit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(319, 131)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdYes)
        Me.Controls.Add(Me.cmdNo)
        Me.Name = "Quit"
        Me.Text = "Quit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdNo As Button
    Friend WithEvents cmdYes As Button
    Friend WithEvents Label1 As Label
End Class
