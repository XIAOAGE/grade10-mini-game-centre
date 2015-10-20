<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mouselabHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mouselabHelp))
        Me.picStart = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picExample = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picCheckPoint2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTimeStats = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblBoxBackground = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExample, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picCheckPoint2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'picStart
        '
        Me.picStart.Image = Global.Mini_Game_Center.My.Resources.Resources.Start
        Me.picStart.Location = New System.Drawing.Point(220, 20)
        Me.picStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picStart.Name = "picStart"
        Me.picStart.Size = New System.Drawing.Size(75, 75)
        Me.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStart.TabIndex = 1
        Me.picStart.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Click the start button,"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 54)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Your mouse cursor will change to, (move your mosuse --->)"
        '
        'picExample
        '
        Me.picExample.BackColor = System.Drawing.Color.White
        Me.picExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picExample.Location = New System.Drawing.Point(220, 98)
        Me.picExample.Margin = New System.Windows.Forms.Padding(4)
        Me.picExample.Name = "picExample"
        Me.picExample.Size = New System.Drawing.Size(74, 67)
        Me.picExample.TabIndex = 4
        Me.picExample.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Also the timer will start to count your time!"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.picStart)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.picExample)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(301, 208)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "How to Start the game"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.picCheckPoint2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(311, 208)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "How to Set a checkpoint"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 42)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "You just have to click on this picture to start the game again!"
        '
        'picCheckPoint2
        '
        Me.picCheckPoint2.Image = CType(resources.GetObject("picCheckPoint2.Image"), System.Drawing.Image)
        Me.picCheckPoint2.Location = New System.Drawing.Point(227, 74)
        Me.picCheckPoint2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picCheckPoint2.Name = "picCheckPoint2"
        Me.picCheckPoint2.Size = New System.Drawing.Size(75, 75)
        Me.picCheckPoint2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCheckPoint2.TabIndex = 70
        Me.picCheckPoint2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "When your mouse entered into a checkpoint,"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "it will apear a picture"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTimeStats)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblTime)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.lblBoxBackground)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 230)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(301, 183)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Timing"
        '
        'lblTimeStats
        '
        Me.lblTimeStats.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimeStats.AutoSize = True
        Me.lblTimeStats.BackColor = System.Drawing.Color.White
        Me.lblTimeStats.Location = New System.Drawing.Point(148, 98)
        Me.lblTimeStats.Name = "lblTimeStats"
        Me.lblTimeStats.Size = New System.Drawing.Size(71, 17)
        Me.lblTimeStats.TabIndex = 105
        Me.lblTimeStats.Text = "(Stopped)"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 133)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(285, 42)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "It also tells you wether the timer is started or stopped."
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(12, 98)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(113, 17)
        Me.lblTime.TabIndex = 104
        Me.lblTime.Text = "Time: 13 second"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(9, 32)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(285, 59)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "The timer will start once you started the game, It will pause whenever you hit a " & _
            "wall or a Message popped out"
        '
        'lblBoxBackground
        '
        Me.lblBoxBackground.BackColor = System.Drawing.Color.White
        Me.lblBoxBackground.Location = New System.Drawing.Point(9, 91)
        Me.lblBoxBackground.Name = "lblBoxBackground"
        Me.lblBoxBackground.Size = New System.Drawing.Size(225, 32)
        Me.lblBoxBackground.TabIndex = 103
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(360, 230)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(301, 183)
        Me.GroupBox4.TabIndex = 106
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "High Score"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 91)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(285, 30)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "The less time is better!!"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 17)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Time: 68 Second"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(15, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 17)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Best Player: Marco"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(9, 32)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(285, 59)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Your score will be saved in our text file and it will show up in highscore list i" & _
            "f you beat the Top 3 record."
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(9, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(225, 49)
        Me.Label13.TabIndex = 103
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(571, 423)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 28)
        Me.btnOk.TabIndex = 107
        Me.btnOk.Text = "Comfirm"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'mouselabHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 466)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "mouselabHelp"
        Me.Text = "Help"
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExample, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picCheckPoint2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picStart As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picExample As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picCheckPoint2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTimeStats As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblBoxBackground As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
