<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TableCard1 = New System.Windows.Forms.PictureBox()
        Me.TableCard2 = New System.Windows.Forms.PictureBox()
        Me.TableCard3 = New System.Windows.Forms.PictureBox()
        Me.CompTable1 = New System.Windows.Forms.PictureBox()
        Me.CompTable2 = New System.Windows.Forms.PictureBox()
        Me.CompTable3 = New System.Windows.Forms.PictureBox()
        Me.FaceDown1 = New System.Windows.Forms.PictureBox()
        Me.FaceDown2 = New System.Windows.Forms.PictureBox()
        Me.FaceDown3 = New System.Windows.Forms.PictureBox()
        Me.CDown1 = New System.Windows.Forms.PictureBox()
        Me.CDown2 = New System.Windows.Forms.PictureBox()
        Me.CDown3 = New System.Windows.Forms.PictureBox()
        Me.PickUpPile = New System.Windows.Forms.PictureBox()
        Me.PutDownPile = New System.Windows.Forms.PictureBox()
        Me.HandCard3 = New System.Windows.Forms.PictureBox()
        Me.HandCard2 = New System.Windows.Forms.PictureBox()
        Me.HandCard1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.HandRight = New System.Windows.Forms.Button()
        Me.HandLeft = New System.Windows.Forms.Button()
        CType(Me.TableCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PickUpPile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PutDownPile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HandCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HandCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HandCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(54, 164)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(256, 212)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(73, 382)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(216, 186)
        Me.ListBox2.TabIndex = 1
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.ForeColor = System.Drawing.Color.Yellow
        Me.CmdClose.Location = New System.Drawing.Point(1501, 844)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(91, 52)
        Me.CmdClose.TabIndex = 2
        Me.CmdClose.Text = "End Game"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'TableCard1
        '
        Me.TableCard1.BackColor = System.Drawing.Color.Transparent
        Me.TableCard1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableCard1.Enabled = False
        Me.TableCard1.ErrorImage = Nothing
        Me.TableCard1.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.TableCard1.InitialImage = Nothing
        Me.TableCard1.Location = New System.Drawing.Point(349, 687)
        Me.TableCard1.Name = "TableCard1"
        Me.TableCard1.Size = New System.Drawing.Size(139, 209)
        Me.TableCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TableCard1.TabIndex = 3
        Me.TableCard1.TabStop = False
        '
        'TableCard2
        '
        Me.TableCard2.BackColor = System.Drawing.Color.Transparent
        Me.TableCard2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableCard2.Enabled = False
        Me.TableCard2.ErrorImage = Nothing
        Me.TableCard2.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.TableCard2.InitialImage = Nothing
        Me.TableCard2.Location = New System.Drawing.Point(546, 687)
        Me.TableCard2.Name = "TableCard2"
        Me.TableCard2.Size = New System.Drawing.Size(139, 209)
        Me.TableCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TableCard2.TabIndex = 4
        Me.TableCard2.TabStop = False
        '
        'TableCard3
        '
        Me.TableCard3.BackColor = System.Drawing.Color.Transparent
        Me.TableCard3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableCard3.Enabled = False
        Me.TableCard3.ErrorImage = Nothing
        Me.TableCard3.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.TableCard3.InitialImage = Nothing
        Me.TableCard3.Location = New System.Drawing.Point(742, 687)
        Me.TableCard3.Name = "TableCard3"
        Me.TableCard3.Size = New System.Drawing.Size(139, 209)
        Me.TableCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TableCard3.TabIndex = 5
        Me.TableCard3.TabStop = False
        '
        'CompTable1
        '
        Me.CompTable1.BackColor = System.Drawing.Color.Transparent
        Me.CompTable1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CompTable1.Enabled = False
        Me.CompTable1.ErrorImage = Nothing
        Me.CompTable1.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.CompTable1.InitialImage = Nothing
        Me.CompTable1.Location = New System.Drawing.Point(742, 12)
        Me.CompTable1.Name = "CompTable1"
        Me.CompTable1.Size = New System.Drawing.Size(139, 209)
        Me.CompTable1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CompTable1.TabIndex = 6
        Me.CompTable1.TabStop = False
        '
        'CompTable2
        '
        Me.CompTable2.BackColor = System.Drawing.Color.Transparent
        Me.CompTable2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CompTable2.Enabled = False
        Me.CompTable2.ErrorImage = Nothing
        Me.CompTable2.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.CompTable2.InitialImage = Nothing
        Me.CompTable2.Location = New System.Drawing.Point(546, 12)
        Me.CompTable2.Name = "CompTable2"
        Me.CompTable2.Size = New System.Drawing.Size(139, 209)
        Me.CompTable2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CompTable2.TabIndex = 7
        Me.CompTable2.TabStop = False
        '
        'CompTable3
        '
        Me.CompTable3.BackColor = System.Drawing.Color.Transparent
        Me.CompTable3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CompTable3.Enabled = False
        Me.CompTable3.ErrorImage = Nothing
        Me.CompTable3.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.CompTable3.InitialImage = Nothing
        Me.CompTable3.Location = New System.Drawing.Point(349, 12)
        Me.CompTable3.Name = "CompTable3"
        Me.CompTable3.Size = New System.Drawing.Size(139, 209)
        Me.CompTable3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CompTable3.TabIndex = 8
        Me.CompTable3.TabStop = False
        '
        'FaceDown1
        '
        Me.FaceDown1.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.FaceDown1.Location = New System.Drawing.Point(349, 687)
        Me.FaceDown1.Name = "FaceDown1"
        Me.FaceDown1.Size = New System.Drawing.Size(139, 209)
        Me.FaceDown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FaceDown1.TabIndex = 9
        Me.FaceDown1.TabStop = False
        '
        'FaceDown2
        '
        Me.FaceDown2.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.FaceDown2.Location = New System.Drawing.Point(546, 687)
        Me.FaceDown2.Name = "FaceDown2"
        Me.FaceDown2.Size = New System.Drawing.Size(139, 209)
        Me.FaceDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FaceDown2.TabIndex = 10
        Me.FaceDown2.TabStop = False
        '
        'FaceDown3
        '
        Me.FaceDown3.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.FaceDown3.Location = New System.Drawing.Point(742, 687)
        Me.FaceDown3.Name = "FaceDown3"
        Me.FaceDown3.Size = New System.Drawing.Size(139, 209)
        Me.FaceDown3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FaceDown3.TabIndex = 11
        Me.FaceDown3.TabStop = False
        '
        'CDown1
        '
        Me.CDown1.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.CDown1.Location = New System.Drawing.Point(742, 12)
        Me.CDown1.Name = "CDown1"
        Me.CDown1.Size = New System.Drawing.Size(139, 209)
        Me.CDown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CDown1.TabIndex = 12
        Me.CDown1.TabStop = False
        '
        'CDown2
        '
        Me.CDown2.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.CDown2.Location = New System.Drawing.Point(546, 12)
        Me.CDown2.Name = "CDown2"
        Me.CDown2.Size = New System.Drawing.Size(139, 209)
        Me.CDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CDown2.TabIndex = 13
        Me.CDown2.TabStop = False
        '
        'CDown3
        '
        Me.CDown3.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.CDown3.Location = New System.Drawing.Point(349, 12)
        Me.CDown3.Name = "CDown3"
        Me.CDown3.Size = New System.Drawing.Size(139, 209)
        Me.CDown3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CDown3.TabIndex = 14
        Me.CDown3.TabStop = False
        '
        'PickUpPile
        '
        Me.PickUpPile.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.PickUpPile.Location = New System.Drawing.Point(641, 246)
        Me.PickUpPile.Name = "PickUpPile"
        Me.PickUpPile.Size = New System.Drawing.Size(139, 209)
        Me.PickUpPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PickUpPile.TabIndex = 15
        Me.PickUpPile.TabStop = False
        '
        'PutDownPile
        '
        Me.PutDownPile.BackColor = System.Drawing.Color.Transparent
        Me.PutDownPile.Location = New System.Drawing.Point(452, 246)
        Me.PutDownPile.Name = "PutDownPile"
        Me.PutDownPile.Size = New System.Drawing.Size(139, 209)
        Me.PutDownPile.TabIndex = 16
        Me.PutDownPile.TabStop = False
        '
        'HandCard3
        '
        Me.HandCard3.BackColor = System.Drawing.Color.Transparent
        Me.HandCard3.Cursor = System.Windows.Forms.Cursors.Default
        Me.HandCard3.Enabled = False
        Me.HandCard3.ErrorImage = Nothing
        Me.HandCard3.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.HandCard3.InitialImage = Nothing
        Me.HandCard3.Location = New System.Drawing.Point(742, 472)
        Me.HandCard3.Name = "HandCard3"
        Me.HandCard3.Size = New System.Drawing.Size(139, 209)
        Me.HandCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HandCard3.TabIndex = 19
        Me.HandCard3.TabStop = False
        '
        'HandCard2
        '
        Me.HandCard2.BackColor = System.Drawing.Color.Transparent
        Me.HandCard2.Cursor = System.Windows.Forms.Cursors.Default
        Me.HandCard2.Enabled = False
        Me.HandCard2.ErrorImage = Nothing
        Me.HandCard2.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.HandCard2.InitialImage = Nothing
        Me.HandCard2.Location = New System.Drawing.Point(546, 472)
        Me.HandCard2.Name = "HandCard2"
        Me.HandCard2.Size = New System.Drawing.Size(139, 209)
        Me.HandCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HandCard2.TabIndex = 18
        Me.HandCard2.TabStop = False
        '
        'HandCard1
        '
        Me.HandCard1.BackColor = System.Drawing.Color.Transparent
        Me.HandCard1.Cursor = System.Windows.Forms.Cursors.Default
        Me.HandCard1.Enabled = False
        Me.HandCard1.ErrorImage = Nothing
        Me.HandCard1.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.HandCard1.InitialImage = Nothing
        Me.HandCard1.Location = New System.Drawing.Point(349, 472)
        Me.HandCard1.Name = "HandCard1"
        Me.HandCard1.Size = New System.Drawing.Size(139, 209)
        Me.HandCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HandCard1.TabIndex = 17
        Me.HandCard1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1509, 852)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1517, 860)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'HandRight
        '
        Me.HandRight.BackColor = System.Drawing.Color.Transparent
        Me.HandRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HandRight.ForeColor = System.Drawing.Color.Yellow
        Me.HandRight.Location = New System.Drawing.Point(887, 472)
        Me.HandRight.Name = "HandRight"
        Me.HandRight.Size = New System.Drawing.Size(24, 209)
        Me.HandRight.TabIndex = 22
        Me.HandRight.Text = ">"
        Me.HandRight.UseVisualStyleBackColor = False
        '
        'HandLeft
        '
        Me.HandLeft.BackColor = System.Drawing.Color.Transparent
        Me.HandLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HandLeft.ForeColor = System.Drawing.Color.Yellow
        Me.HandLeft.Location = New System.Drawing.Point(319, 472)
        Me.HandLeft.Name = "HandLeft"
        Me.HandLeft.Size = New System.Drawing.Size(24, 209)
        Me.HandLeft.TabIndex = 23
        Me.HandLeft.Text = "<"
        Me.HandLeft.UseVisualStyleBackColor = False
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1620, 920)
        Me.Controls.Add(Me.HandLeft)
        Me.Controls.Add(Me.HandRight)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HandCard3)
        Me.Controls.Add(Me.HandCard2)
        Me.Controls.Add(Me.HandCard1)
        Me.Controls.Add(Me.PutDownPile)
        Me.Controls.Add(Me.PickUpPile)
        Me.Controls.Add(Me.CompTable3)
        Me.Controls.Add(Me.CompTable2)
        Me.Controls.Add(Me.CompTable1)
        Me.Controls.Add(Me.TableCard3)
        Me.Controls.Add(Me.TableCard2)
        Me.Controls.Add(Me.TableCard1)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.FaceDown3)
        Me.Controls.Add(Me.FaceDown2)
        Me.Controls.Add(Me.FaceDown1)
        Me.Controls.Add(Me.CDown2)
        Me.Controls.Add(Me.CDown1)
        Me.Controls.Add(Me.CDown3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GameForm"
        Me.Text = "Form1"
        CType(Me.TableCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PickUpPile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PutDownPile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HandCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HandCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HandCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents CmdClose As Button
    Friend WithEvents TableCard1 As PictureBox
    Friend WithEvents TableCard2 As PictureBox
    Friend WithEvents TableCard3 As PictureBox
    Friend WithEvents CompTable1 As PictureBox
    Friend WithEvents CompTable2 As PictureBox
    Friend WithEvents CompTable3 As PictureBox
    Friend WithEvents FaceDown1 As PictureBox
    Friend WithEvents FaceDown2 As PictureBox
    Friend WithEvents FaceDown3 As PictureBox
    Friend WithEvents CDown1 As PictureBox
    Friend WithEvents CDown2 As PictureBox
    Friend WithEvents CDown3 As PictureBox
    Friend WithEvents PickUpPile As PictureBox
    Friend WithEvents PutDownPile As PictureBox
    Friend WithEvents HandCard3 As PictureBox
    Friend WithEvents HandCard2 As PictureBox
    Friend WithEvents HandCard1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents HandRight As Button
    Friend WithEvents HandLeft As Button
End Class
