<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TableCard1 = New System.Windows.Forms.PictureBox()
        Me.TableCard2 = New System.Windows.Forms.PictureBox()
        Me.TableCard3 = New System.Windows.Forms.PictureBox()
        Me.CompTable1 = New System.Windows.Forms.PictureBox()
        Me.CompTable2 = New System.Windows.Forms.PictureBox()
        Me.CompTable3 = New System.Windows.Forms.PictureBox()
        CType(Me.TableCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(306, 284)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(256, 212)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(665, 296)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(216, 186)
        Me.ListBox2.TabIndex = 1
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.ForeColor = System.Drawing.Color.Yellow
        Me.CmdClose.Location = New System.Drawing.Point(1259, 704)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(91, 52)
        Me.CmdClose.TabIndex = 2
        Me.CmdClose.Text = "End Game"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'TableCard1
        '
        Me.TableCard1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableCard1.Enabled = False
        Me.TableCard1.ErrorImage = Nothing
        Me.TableCard1.Image = Global.ShitHead.My.Resources.Resources.ezgif_6_551fa5ce788d
        Me.TableCard1.InitialImage = Nothing
        Me.TableCard1.Location = New System.Drawing.Point(222, 502)
        Me.TableCard1.Name = "TableCard1"
        Me.TableCard1.Size = New System.Drawing.Size(180, 254)
        Me.TableCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TableCard1.TabIndex = 3
        Me.TableCard1.TabStop = False
        '
        'TableCard2
        '
        Me.TableCard2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableCard2.Enabled = False
        Me.TableCard2.ErrorImage = Nothing
        Me.TableCard2.Image = Global.ShitHead.My.Resources.Resources.ezgif_6_551fa5ce788d
        Me.TableCard2.InitialImage = Nothing
        Me.TableCard2.Location = New System.Drawing.Point(546, 502)
        Me.TableCard2.Name = "TableCard2"
        Me.TableCard2.Size = New System.Drawing.Size(180, 254)
        Me.TableCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TableCard2.TabIndex = 4
        Me.TableCard2.TabStop = False
        '
        'TableCard3
        '
        Me.TableCard3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableCard3.Enabled = False
        Me.TableCard3.ErrorImage = Nothing
        Me.TableCard3.Image = Global.ShitHead.My.Resources.Resources.ezgif_6_551fa5ce788d
        Me.TableCard3.InitialImage = Nothing
        Me.TableCard3.Location = New System.Drawing.Point(872, 502)
        Me.TableCard3.Name = "TableCard3"
        Me.TableCard3.Size = New System.Drawing.Size(180, 254)
        Me.TableCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TableCard3.TabIndex = 5
        Me.TableCard3.TabStop = False
        '
        'CompTable1
        '
        Me.CompTable1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CompTable1.Enabled = False
        Me.CompTable1.ErrorImage = Nothing
        Me.CompTable1.Image = Global.ShitHead.My.Resources.Resources.ezgif_6_551fa5ce788d
        Me.CompTable1.InitialImage = Nothing
        Me.CompTable1.Location = New System.Drawing.Point(872, 12)
        Me.CompTable1.Name = "CompTable1"
        Me.CompTable1.Size = New System.Drawing.Size(180, 254)
        Me.CompTable1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CompTable1.TabIndex = 6
        Me.CompTable1.TabStop = False
        '
        'CompTable2
        '
        Me.CompTable2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CompTable2.Enabled = False
        Me.CompTable2.ErrorImage = Nothing
        Me.CompTable2.Image = Global.ShitHead.My.Resources.Resources.ezgif_6_551fa5ce788d
        Me.CompTable2.InitialImage = Nothing
        Me.CompTable2.Location = New System.Drawing.Point(546, 12)
        Me.CompTable2.Name = "CompTable2"
        Me.CompTable2.Size = New System.Drawing.Size(180, 254)
        Me.CompTable2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CompTable2.TabIndex = 7
        Me.CompTable2.TabStop = False
        '
        'CompTable3
        '
        Me.CompTable3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CompTable3.Enabled = False
        Me.CompTable3.ErrorImage = Nothing
        Me.CompTable3.Image = Global.ShitHead.My.Resources.Resources.ezgif_6_551fa5ce788d
        Me.CompTable3.InitialImage = Nothing
        Me.CompTable3.Location = New System.Drawing.Point(222, 12)
        Me.CompTable3.Name = "CompTable3"
        Me.CompTable3.Size = New System.Drawing.Size(180, 254)
        Me.CompTable3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CompTable3.TabIndex = 8
        Me.CompTable3.TabStop = False
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1362, 768)
        Me.Controls.Add(Me.CompTable3)
        Me.Controls.Add(Me.CompTable2)
        Me.Controls.Add(Me.CompTable1)
        Me.Controls.Add(Me.TableCard3)
        Me.Controls.Add(Me.TableCard2)
        Me.Controls.Add(Me.TableCard1)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GameForm"
        Me.Text = "Form1"
        CType(Me.TableCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompTable3, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
