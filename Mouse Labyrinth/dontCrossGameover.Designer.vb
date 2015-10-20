<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblPlayer1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lblPlayer1))
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTut1 = New System.Windows.Forms.Label()
        Me.lblTut2 = New System.Windows.Forms.Label()
        Me.lblSpaceToStart = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(336, 161)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(185, 53)
        Me.lblWinner.TabIndex = 0
        Me.lblWinner.Text = "Winner: "
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(298, 70)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(128, 53)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "Score"
        '
        'lblTut1
        '
        Me.lblTut1.AutoSize = True
        Me.lblTut1.BackColor = System.Drawing.Color.Green
        Me.lblTut1.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTut1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTut1.Location = New System.Drawing.Point(143, 265)
        Me.lblTut1.Name = "lblTut1"
        Me.lblTut1.Size = New System.Drawing.Size(129, 53)
        Me.lblTut1.TabIndex = 2
        Me.lblTut1.Text = "Green"
        '
        'lblTut2
        '
        Me.lblTut2.AutoSize = True
        Me.lblTut2.BackColor = System.Drawing.Color.Purple
        Me.lblTut2.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTut2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTut2.Location = New System.Drawing.Point(665, 265)
        Me.lblTut2.Name = "lblTut2"
        Me.lblTut2.Size = New System.Drawing.Size(132, 53)
        Me.lblTut2.TabIndex = 3
        Me.lblTut2.Text = "Purple"
        '
        'lblSpaceToStart
        '
        Me.lblSpaceToStart.AutoSize = True
        Me.lblSpaceToStart.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpaceToStart.Location = New System.Drawing.Point(202, 687)
        Me.lblSpaceToStart.Name = "lblSpaceToStart"
        Me.lblSpaceToStart.Size = New System.Drawing.Size(607, 53)
        Me.lblSpaceToStart.TabIndex = 4
        Me.lblSpaceToStart.Text = "Press SPACE to start the game"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Purple
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(511, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(525, 858)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(-5, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(525, 858)
        Me.Label2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(143, 538)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 53)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "A,S,D,W"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Purple
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(653, 538)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 53)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Arrows Keys"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Purple
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Green
        Me.PictureBox2.Location = New System.Drawing.Point(973, 809)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'lblPlayer1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 849)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSpaceToStart)
        Me.Controls.Add(Me.lblTut2)
        Me.Controls.Add(Me.lblTut1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "lblPlayer1"
        Me.Text = "Don't Cross"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblTut1 As System.Windows.Forms.Label
    Friend WithEvents lblTut2 As System.Windows.Forms.Label
    Friend WithEvents lblSpaceToStart As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
