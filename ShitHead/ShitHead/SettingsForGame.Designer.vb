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
        Me.PayInNum = New System.Windows.Forms.Label()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.SubmitBills = New System.Windows.Forms.Button()
        Me.CustomAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PayIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PayIn
        '
        Me.PayIn.AutoSize = False
        Me.PayIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PayIn.LargeChange = 10
        Me.PayIn.Location = New System.Drawing.Point(12, 145)
        Me.PayIn.Maximum = 100
        Me.PayIn.Name = "PayIn"
        Me.PayIn.Size = New System.Drawing.Size(664, 39)
        Me.PayIn.SmallChange = 5
        Me.PayIn.TabIndex = 0
        Me.PayIn.TickFrequency = 10
        Me.PayIn.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'BotCount
        '
        Me.BotCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotCount.Location = New System.Drawing.Point(12, 41)
        Me.BotCount.Maximum = 3
        Me.BotCount.Minimum = 1
        Me.BotCount.Name = "BotCount"
        Me.BotCount.Size = New System.Drawing.Size(664, 45)
        Me.BotCount.TabIndex = 1
        Me.BotCount.TickStyle = System.Windows.Forms.TickStyle.Both
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
        'PayInNum
        '
        Me.PayInNum.AutoSize = True
        Me.PayInNum.Location = New System.Drawing.Point(697, 156)
        Me.PayInNum.Name = "PayInNum"
        Me.PayInNum.Size = New System.Drawing.Size(39, 13)
        Me.PayInNum.TabIndex = 5
        Me.PayInNum.Text = "Label4"
        '
        'Confirm
        '
        Me.Confirm.BackColor = System.Drawing.Color.Transparent
        Me.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Confirm.ForeColor = System.Drawing.Color.Yellow
        Me.Confirm.Location = New System.Drawing.Point(700, 207)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(88, 36)
        Me.Confirm.TabIndex = 6
        Me.Confirm.Text = "Confirm"
        Me.Confirm.UseVisualStyleBackColor = False
        '
        'SubmitBills
        '
        Me.SubmitBills.BackColor = System.Drawing.Color.Transparent
        Me.SubmitBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitBills.ForeColor = System.Drawing.Color.Yellow
        Me.SubmitBills.Location = New System.Drawing.Point(118, 207)
        Me.SubmitBills.Name = "SubmitBills"
        Me.SubmitBills.Size = New System.Drawing.Size(75, 23)
        Me.SubmitBills.TabIndex = 7
        Me.SubmitBills.Text = "Submit"
        Me.SubmitBills.UseVisualStyleBackColor = False
        '
        'CustomAmount
        '
        Me.CustomAmount.BackColor = System.Drawing.Color.Green
        Me.CustomAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomAmount.ForeColor = System.Drawing.Color.Yellow
        Me.CustomAmount.Location = New System.Drawing.Point(12, 212)
        Me.CustomAmount.Name = "CustomAmount"
        Me.CustomAmount.Size = New System.Drawing.Size(100, 13)
        Me.CustomAmount.TabIndex = 8
        Me.CustomAmount.Text = "Write number here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(12, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "or write your number in here"
        '
        'SettingsForGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(800, 255)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CustomAmount)
        Me.Controls.Add(Me.SubmitBills)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.PayInNum)
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
    Friend WithEvents PayInNum As Label
    Friend WithEvents Confirm As Button
    Friend WithEvents SubmitBills As Button
    Friend WithEvents CustomAmount As TextBox
    Friend WithEvents Label3 As Label
End Class
