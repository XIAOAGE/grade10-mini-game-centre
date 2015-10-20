<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _2PlayerSnakeEnd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_2PlayerSnakeEnd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Footlight MT Light", 28.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Winner "
        '
        'lblWinner
        '
        Me.lblWinner.Font = New System.Drawing.Font("Footlight MT Light", 28.2!)
        Me.lblWinner.Location = New System.Drawing.Point(12, 113)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(801, 51)
        Me.lblWinner.TabIndex = 1
        Me.lblWinner.Text = " Winner "
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer
        '
        Me.lblPlayer.Font = New System.Drawing.Font("Footlight MT Light", 28.2!)
        Me.lblPlayer.Location = New System.Drawing.Point(12, 244)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(404, 51)
        Me.lblPlayer.TabIndex = 2
        Me.lblPlayer.Text = "Player1"
        Me.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer2
        '
        Me.lblPlayer2.Font = New System.Drawing.Font("Footlight MT Light", 28.2!)
        Me.lblPlayer2.Location = New System.Drawing.Point(409, 244)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(404, 51)
        Me.lblPlayer2.TabIndex = 3
        Me.lblPlayer2.Text = "Player2"
        Me.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore1
        '
        Me.lblScore1.Font = New System.Drawing.Font("Footlight MT Light", 28.2!)
        Me.lblScore1.Location = New System.Drawing.Point(12, 309)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(404, 51)
        Me.lblScore1.TabIndex = 4
        Me.lblScore1.Text = "Score"
        Me.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore2
        '
        Me.lblScore2.Font = New System.Drawing.Font("Footlight MT Light", 28.2!)
        Me.lblScore2.Location = New System.Drawing.Point(422, 309)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(391, 51)
        Me.lblScore2.TabIndex = 5
        Me.lblScore2.Text = "Score"
        Me.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Footlight MT Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(127, 461)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(252, 94)
        Me.btnRestart.TabIndex = 6
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Footlight MT Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(445, 461)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(252, 94)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        '_2PlayerSnakeEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 594)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "_2PlayerSnakeEnd"
        Me.Text = "Snake - 2 Player"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents lblScore1 As System.Windows.Forms.Label
    Friend WithEvents lblScore2 As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
