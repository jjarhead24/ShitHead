<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rolling_start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rolling_start))
        Me.RollDice = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.DiceShow = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bot3Dice = New System.Windows.Forms.PictureBox()
        Me.Bot3Roll = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Bot2Dice = New System.Windows.Forms.PictureBox()
        Me.Bot2Roll = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Bot1Dice = New System.Windows.Forms.PictureBox()
        Me.Bot1Roll = New System.Windows.Forms.Label()
        CType(Me.DiceShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Bot3Dice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Bot2Dice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Bot1Dice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RollDice
        '
        Me.RollDice.BackColor = System.Drawing.Color.Transparent
        Me.RollDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RollDice.ForeColor = System.Drawing.Color.Yellow
        Me.RollDice.Location = New System.Drawing.Point(73, 106)
        Me.RollDice.Name = "RollDice"
        Me.RollDice.Size = New System.Drawing.Size(96, 47)
        Me.RollDice.TabIndex = 0
        Me.RollDice.Text = "Roll the dice!"
        Me.RollDice.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Transparent
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back.ForeColor = System.Drawing.Color.Yellow
        Me.Back.Location = New System.Drawing.Point(73, 181)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(96, 47)
        Me.Back.TabIndex = 1
        Me.Back.Text = "Go back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'DiceShow
        '
        Me.DiceShow.BackColor = System.Drawing.Color.Transparent
        Me.DiceShow.Image = CType(resources.GetObject("DiceShow.Image"), System.Drawing.Image)
        Me.DiceShow.Location = New System.Drawing.Point(259, 90)
        Me.DiceShow.Name = "DiceShow"
        Me.DiceShow.Size = New System.Drawing.Size(179, 176)
        Me.DiceShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiceShow.TabIndex = 2
        Me.DiceShow.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(479, -25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 421)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Bot3Dice)
        Me.GroupBox2.Controls.Add(Me.Bot3Roll)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 466)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Bot3Dice
        '
        Me.Bot3Dice.Image = CType(resources.GetObject("Bot3Dice.Image"), System.Drawing.Image)
        Me.Bot3Dice.Location = New System.Drawing.Point(124, 297)
        Me.Bot3Dice.Name = "Bot3Dice"
        Me.Bot3Dice.Size = New System.Drawing.Size(102, 103)
        Me.Bot3Dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bot3Dice.TabIndex = 6
        Me.Bot3Dice.TabStop = False
        '
        'Bot3Roll
        '
        Me.Bot3Roll.AutoSize = True
        Me.Bot3Roll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot3Roll.ForeColor = System.Drawing.Color.Yellow
        Me.Bot3Roll.Location = New System.Drawing.Point(19, 314)
        Me.Bot3Roll.Name = "Bot3Roll"
        Me.Bot3Roll.Size = New System.Drawing.Size(88, 24)
        Me.Bot3Roll.TabIndex = 6
        Me.Bot3Roll.Text = "Bot 3 got:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Bot2Dice)
        Me.GroupBox3.Controls.Add(Me.Bot2Roll)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(0, -44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(253, 335)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Bot2Dice
        '
        Me.Bot2Dice.Image = CType(resources.GetObject("Bot2Dice.Image"), System.Drawing.Image)
        Me.Bot2Dice.Location = New System.Drawing.Point(124, 213)
        Me.Bot2Dice.Name = "Bot2Dice"
        Me.Bot2Dice.Size = New System.Drawing.Size(102, 104)
        Me.Bot2Dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bot2Dice.TabIndex = 7
        Me.Bot2Dice.TabStop = False
        '
        'Bot2Roll
        '
        Me.Bot2Roll.AutoSize = True
        Me.Bot2Roll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot2Roll.ForeColor = System.Drawing.Color.Yellow
        Me.Bot2Roll.Location = New System.Drawing.Point(19, 224)
        Me.Bot2Roll.Name = "Bot2Roll"
        Me.Bot2Roll.Size = New System.Drawing.Size(88, 24)
        Me.Bot2Roll.TabIndex = 5
        Me.Bot2Roll.Text = "Bot 2 got:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Bot1Dice)
        Me.GroupBox4.Controls.Add(Me.Bot1Roll)
        Me.GroupBox4.Location = New System.Drawing.Point(0, -62)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(253, 269)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Bot1Dice
        '
        Me.Bot1Dice.Image = CType(resources.GetObject("Bot1Dice.Image"), System.Drawing.Image)
        Me.Bot1Dice.Location = New System.Drawing.Point(124, 140)
        Me.Bot1Dice.Name = "Bot1Dice"
        Me.Bot1Dice.Size = New System.Drawing.Size(102, 103)
        Me.Bot1Dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bot1Dice.TabIndex = 8
        Me.Bot1Dice.TabStop = False
        '
        'Bot1Roll
        '
        Me.Bot1Roll.AutoSize = True
        Me.Bot1Roll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot1Roll.ForeColor = System.Drawing.Color.Yellow
        Me.Bot1Roll.Location = New System.Drawing.Point(18, 140)
        Me.Bot1Roll.Name = "Bot1Roll"
        Me.Bot1Roll.Size = New System.Drawing.Size(88, 24)
        Me.Bot1Roll.TabIndex = 4
        Me.Bot1Roll.Text = "Bot 1 got:"
        '
        'Rolling_start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(717, 387)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DiceShow)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.RollDice)
        Me.Name = "Rolling_start"
        Me.Text = "Rolling_start"
        CType(Me.DiceShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Bot3Dice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Bot2Dice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Bot1Dice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RollDice As Button
    Friend WithEvents Back As Button
    Friend WithEvents DiceShow As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Bot3Dice As PictureBox
    Friend WithEvents Bot3Roll As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Bot2Dice As PictureBox
    Friend WithEvents Bot2Roll As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Bot1Dice As PictureBox
    Friend WithEvents Bot1Roll As Label
End Class
