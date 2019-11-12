<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class card_swap
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
        Me.Hand1 = New System.Windows.Forms.PictureBox()
        Me.Table3 = New System.Windows.Forms.PictureBox()
        Me.Hand3 = New System.Windows.Forms.PictureBox()
        Me.Hand2 = New System.Windows.Forms.PictureBox()
        Me.Table2 = New System.Windows.Forms.PictureBox()
        Me.Table1 = New System.Windows.Forms.PictureBox()
        Me.Done = New System.Windows.Forms.Button()
        CType(Me.Hand1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hand3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hand2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hand1
        '
        Me.Hand1.BackColor = System.Drawing.Color.Transparent
        Me.Hand1.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Hand1.Location = New System.Drawing.Point(74, 12)
        Me.Hand1.Name = "Hand1"
        Me.Hand1.Size = New System.Drawing.Size(154, 222)
        Me.Hand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Hand1.TabIndex = 0
        Me.Hand1.TabStop = False
        '
        'Table3
        '
        Me.Table3.BackColor = System.Drawing.Color.Transparent
        Me.Table3.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Table3.Location = New System.Drawing.Point(437, 272)
        Me.Table3.Name = "Table3"
        Me.Table3.Size = New System.Drawing.Size(154, 222)
        Me.Table3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Table3.TabIndex = 1
        Me.Table3.TabStop = False
        '
        'Hand3
        '
        Me.Hand3.BackColor = System.Drawing.Color.Transparent
        Me.Hand3.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Hand3.Location = New System.Drawing.Point(437, 12)
        Me.Hand3.Name = "Hand3"
        Me.Hand3.Size = New System.Drawing.Size(154, 222)
        Me.Hand3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Hand3.TabIndex = 2
        Me.Hand3.TabStop = False
        '
        'Hand2
        '
        Me.Hand2.BackColor = System.Drawing.Color.Transparent
        Me.Hand2.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Hand2.Location = New System.Drawing.Point(256, 12)
        Me.Hand2.Name = "Hand2"
        Me.Hand2.Size = New System.Drawing.Size(154, 222)
        Me.Hand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Hand2.TabIndex = 4
        Me.Hand2.TabStop = False
        '
        'Table2
        '
        Me.Table2.BackColor = System.Drawing.Color.Transparent
        Me.Table2.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Table2.Location = New System.Drawing.Point(256, 272)
        Me.Table2.Name = "Table2"
        Me.Table2.Size = New System.Drawing.Size(154, 222)
        Me.Table2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Table2.TabIndex = 5
        Me.Table2.TabStop = False
        '
        'Table1
        '
        Me.Table1.BackColor = System.Drawing.Color.Transparent
        Me.Table1.Image = Global.ShitHead.My.Resources.Resources.Card_back
        Me.Table1.Location = New System.Drawing.Point(74, 272)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(154, 222)
        Me.Table1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Table1.TabIndex = 6
        Me.Table1.TabStop = False
        '
        'Done
        '
        Me.Done.BackColor = System.Drawing.Color.Transparent
        Me.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Done.ForeColor = System.Drawing.Color.Yellow
        Me.Done.Location = New System.Drawing.Point(597, 447)
        Me.Done.Name = "Done"
        Me.Done.Size = New System.Drawing.Size(82, 47)
        Me.Done.TabIndex = 7
        Me.Done.Text = "Done"
        Me.Done.UseVisualStyleBackColor = False
        '
        'card_swap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ShitHead.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(691, 506)
        Me.Controls.Add(Me.Done)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.Table2)
        Me.Controls.Add(Me.Hand2)
        Me.Controls.Add(Me.Hand3)
        Me.Controls.Add(Me.Table3)
        Me.Controls.Add(Me.Hand1)
        Me.Name = "card_swap"
        Me.Text = "card_swap"
        CType(Me.Hand1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hand3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hand2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Hand1 As PictureBox
    Friend WithEvents Table3 As PictureBox
    Friend WithEvents Hand3 As PictureBox
    Friend WithEvents Hand2 As PictureBox
    Friend WithEvents Table2 As PictureBox
    Friend WithEvents Table1 As PictureBox
    Friend WithEvents Done As Button
End Class
