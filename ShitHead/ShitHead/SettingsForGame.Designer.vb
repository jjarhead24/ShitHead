<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForGame
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
        Me.PayIn = New System.Windows.Forms.TrackBar()
        Me.BotCount = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BotNum = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PayIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PayIn
        '
        Me.PayIn.AutoSize = False
        Me.PayIn.LargeChange = 8
        Me.PayIn.Location = New System.Drawing.Point(12, 145)
        Me.PayIn.Maximum = 100
        Me.PayIn.Name = "PayIn"
        Me.PayIn.Size = New System.Drawing.Size(664, 39)
        Me.PayIn.TabIndex = 0
        '
        'BotCount
        '
        Me.BotCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotCount.Location = New System.Drawing.Point(12, 41)
        Me.BotCount.Maximum = 3
        Me.BotCount.Name = "BotCount"
        Me.BotCount.Size = New System.Drawing.Size(664, 45)
        Me.BotCount.TabIndex = 1
        Me.BotCount.Value = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(184, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "How many bots do you want to play against?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(163, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(428, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "How many bills do you want to pay into the game?"
        '
        'BotNum
        '
        Me.BotNum.AutoSize = True
        Me.BotNum.Location = New System.Drawing.Point(697, 55)
        Me.BotNum.Name = "BotNum"
        Me.BotNum.Size = New System.Drawing.Size(39, 13)
        Me.BotNum.TabIndex = 4
        Me.BotNum.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(697, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SettingsForGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(800, 255)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BotNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BotCount)
        Me.Controls.Add(Me.PayIn)
        Me.Name = "SettingsForGame"
        Me.Text = "SettingsForGame"
        CType(Me.PayIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PayIn As TrackBar
    Friend WithEvents BotCount As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BotNum As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
