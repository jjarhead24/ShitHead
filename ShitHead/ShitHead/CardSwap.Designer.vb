<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class card_swap
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
        Me.Hand1 = New System.Windows.Forms.PictureBox()
        Me.Table3 = New System.Windows.Forms.PictureBox()
        Me.Hand3 = New System.Windows.Forms.PictureBox()
        Me.Hand2 = New System.Windows.Forms.PictureBox()
        Me.Table2 = New System.Windows.Forms.PictureBox()
        Me.Table1 = New System.Windows.Forms.PictureBox()
        Me.Done = New System.Windows.Forms.Button()
        Me.HandLbl1 = New System.Windows.Forms.Label()
        Me.HandLbl2 = New System.Windows.Forms.Label()
        Me.HandLbl3 = New System.Windows.Forms.Label()
        Me.TableLbl1 = New System.Windows.Forms.Label()
        Me.TableLbl2 = New System.Windows.Forms.Label()
        Me.TableLbl3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Hand1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hand3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hand2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hand1
        '
        Me.Hand1.BackColor = System.Drawing.Color.Transparent
        Me.Hand1.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Hand1.Location = New System.Drawing.Point(99, 15)
        Me.Hand1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Hand1.Name = "Hand1"
        Me.Hand1.Size = New System.Drawing.Size(205, 273)
        Me.Hand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Hand1.TabIndex = 0
        Me.Hand1.TabStop = False
        '
        'Table3
        '
        Me.Table3.BackColor = System.Drawing.Color.Transparent
        Me.Table3.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Table3.Location = New System.Drawing.Point(583, 335)
        Me.Table3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Table3.Name = "Table3"
        Me.Table3.Size = New System.Drawing.Size(205, 273)
        Me.Table3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Table3.TabIndex = 1
        Me.Table3.TabStop = False
        '
        'Hand3
        '
        Me.Hand3.BackColor = System.Drawing.Color.Transparent
        Me.Hand3.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Hand3.Location = New System.Drawing.Point(583, 15)
        Me.Hand3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Hand3.Name = "Hand3"
        Me.Hand3.Size = New System.Drawing.Size(205, 273)
        Me.Hand3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Hand3.TabIndex = 2
        Me.Hand3.TabStop = False
        '
        'Hand2
        '
        Me.Hand2.BackColor = System.Drawing.Color.Transparent
        Me.Hand2.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Hand2.Location = New System.Drawing.Point(341, 15)
        Me.Hand2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Hand2.Name = "Hand2"
        Me.Hand2.Size = New System.Drawing.Size(205, 273)
        Me.Hand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Hand2.TabIndex = 4
        Me.Hand2.TabStop = False
        '
        'Table2
        '
        Me.Table2.BackColor = System.Drawing.Color.Transparent
        Me.Table2.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Table2.Location = New System.Drawing.Point(341, 335)
        Me.Table2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Table2.Name = "Table2"
        Me.Table2.Size = New System.Drawing.Size(205, 273)
        Me.Table2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Table2.TabIndex = 5
        Me.Table2.TabStop = False
        '
        'Table1
        '
        Me.Table1.BackColor = System.Drawing.Color.Transparent
        Me.Table1.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Table1.Location = New System.Drawing.Point(99, 335)
        Me.Table1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(205, 273)
        Me.Table1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Table1.TabIndex = 6
        Me.Table1.TabStop = False
        '
        'Done
        '
        Me.Done.BackColor = System.Drawing.Color.Transparent
        Me.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Done.ForeColor = System.Drawing.Color.Yellow
        Me.Done.Location = New System.Drawing.Point(796, 550)
        Me.Done.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Done.Name = "Done"
        Me.Done.Size = New System.Drawing.Size(109, 58)
        Me.Done.TabIndex = 7
        Me.Done.Text = "Done"
        Me.Done.UseVisualStyleBackColor = False
        '
        'HandLbl1
        '
        Me.HandLbl1.AutoSize = True
        Me.HandLbl1.Location = New System.Drawing.Point(184, 292)
        Me.HandLbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HandLbl1.Name = "HandLbl1"
        Me.HandLbl1.Size = New System.Drawing.Size(51, 17)
        Me.HandLbl1.TabIndex = 8
        Me.HandLbl1.Text = "Label1"
        '
        'HandLbl2
        '
        Me.HandLbl2.AutoSize = True
        Me.HandLbl2.Location = New System.Drawing.Point(435, 292)
        Me.HandLbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HandLbl2.Name = "HandLbl2"
        Me.HandLbl2.Size = New System.Drawing.Size(51, 17)
        Me.HandLbl2.TabIndex = 9
        Me.HandLbl2.Text = "Label2"
        '
        'HandLbl3
        '
        Me.HandLbl3.AutoSize = True
        Me.HandLbl3.Location = New System.Drawing.Point(667, 292)
        Me.HandLbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HandLbl3.Name = "HandLbl3"
        Me.HandLbl3.Size = New System.Drawing.Size(51, 17)
        Me.HandLbl3.TabIndex = 10
        Me.HandLbl3.Text = "Label3"
        '
        'TableLbl1
        '
        Me.TableLbl1.AutoSize = True
        Me.TableLbl1.Location = New System.Drawing.Point(184, 315)
        Me.TableLbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TableLbl1.Name = "TableLbl1"
        Me.TableLbl1.Size = New System.Drawing.Size(51, 17)
        Me.TableLbl1.TabIndex = 11
        Me.TableLbl1.Text = "Label4"
        '
        'TableLbl2
        '
        Me.TableLbl2.AutoSize = True
        Me.TableLbl2.Location = New System.Drawing.Point(435, 315)
        Me.TableLbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TableLbl2.Name = "TableLbl2"
        Me.TableLbl2.Size = New System.Drawing.Size(51, 17)
        Me.TableLbl2.TabIndex = 12
        Me.TableLbl2.Text = "Label5"
        '
        'TableLbl3
        '
        Me.TableLbl3.AutoSize = True
        Me.TableLbl3.Location = New System.Drawing.Point(667, 315)
        Me.TableLbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TableLbl3.Name = "TableLbl3"
        Me.TableLbl3.Size = New System.Drawing.Size(51, 17)
        Me.TableLbl3.TabIndex = 13
        Me.TableLbl3.Text = "Label6"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ShitHead.My.Resources.Resources.border1
        Me.PictureBox1.Location = New System.Drawing.Point(64, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(9, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Hand Cards"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(7, 447)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Table Cards"
        '
        'card_swap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(921, 623)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLbl3)
        Me.Controls.Add(Me.TableLbl2)
        Me.Controls.Add(Me.TableLbl1)
        Me.Controls.Add(Me.HandLbl3)
        Me.Controls.Add(Me.HandLbl2)
        Me.Controls.Add(Me.HandLbl1)
        Me.Controls.Add(Me.Done)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.Table2)
        Me.Controls.Add(Me.Hand2)
        Me.Controls.Add(Me.Hand3)
        Me.Controls.Add(Me.Table3)
        Me.Controls.Add(Me.Hand1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "card_swap"
        Me.Text = "card_swap"
        CType(Me.Hand1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hand3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hand2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hand1 As PictureBox
    Friend WithEvents Table3 As PictureBox
    Friend WithEvents Hand3 As PictureBox
    Friend WithEvents Hand2 As PictureBox
    Friend WithEvents Table2 As PictureBox
    Friend WithEvents Table1 As PictureBox
    Friend WithEvents Done As Button
    Friend WithEvents HandLbl1 As Label
    Friend WithEvents HandLbl2 As Label
    Friend WithEvents HandLbl3 As Label
    Friend WithEvents TableLbl1 As Label
    Friend WithEvents TableLbl2 As Label
    Friend WithEvents TableLbl3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
