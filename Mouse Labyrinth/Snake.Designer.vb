<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class snake
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(snake))
        Me.pb_Field = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblspeed = New System.Windows.Forms.Label()
        Me.lblspeedname = New System.Windows.Forms.Label()
        Me.lblresume = New System.Windows.Forms.Label()
        Me.lblexit = New System.Windows.Forms.Label()
        Me.lblpause = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblthirdscore = New System.Windows.Forms.Label()
        Me.lblthird = New System.Windows.Forms.Label()
        Me.lblsecondscore = New System.Windows.Forms.Label()
        Me.lblscoreshow = New System.Windows.Forms.Label()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.lbllevelshow = New System.Windows.Forms.Label()
        Me.lbllevel = New System.Windows.Forms.Label()
        Me.tm_snakeMover = New System.Windows.Forms.Timer(Me.components)
        Me.lblsecond = New System.Windows.Forms.Label()
        Me.lblfirstscore = New System.Windows.Forms.Label()
        Me.lblfirst = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pb_Field, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_Field
        '
        Me.pb_Field.BackColor = System.Drawing.Color.White
        Me.pb_Field.Location = New System.Drawing.Point(0, 0)
        Me.pb_Field.Margin = New System.Windows.Forms.Padding(4)
        Me.pb_Field.Name = "pb_Field"
        Me.pb_Field.Size = New System.Drawing.Size(871, 617)
        Me.pb_Field.TabIndex = 1
        Me.pb_Field.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1019, 446)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "pixels/second"
        '
        'lblspeed
        '
        Me.lblspeed.AutoSize = True
        Me.lblspeed.Location = New System.Drawing.Point(980, 446)
        Me.lblspeed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblspeed.Name = "lblspeed"
        Me.lblspeed.Size = New System.Drawing.Size(16, 17)
        Me.lblspeed.TabIndex = 44
        Me.lblspeed.Text = "0"
        '
        'lblspeedname
        '
        Me.lblspeedname.AutoSize = True
        Me.lblspeedname.Location = New System.Drawing.Point(896, 446)
        Me.lblspeedname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblspeedname.Name = "lblspeedname"
        Me.lblspeedname.Size = New System.Drawing.Size(53, 17)
        Me.lblspeedname.TabIndex = 43
        Me.lblspeedname.Text = "Speed:"
        '
        'lblresume
        '
        Me.lblresume.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblresume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresume.Location = New System.Drawing.Point(895, 490)
        Me.lblresume.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblresume.Name = "lblresume"
        Me.lblresume.Size = New System.Drawing.Size(223, 47)
        Me.lblresume.TabIndex = 42
        Me.lblresume.Text = "Resume"
        Me.lblresume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblresume.Visible = False
        '
        'lblexit
        '
        Me.lblexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexit.Location = New System.Drawing.Point(895, 555)
        Me.lblexit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblexit.Name = "lblexit"
        Me.lblexit.Size = New System.Drawing.Size(223, 47)
        Me.lblexit.TabIndex = 41
        Me.lblexit.Text = "Exit"
        Me.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpause
        '
        Me.lblpause.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblpause.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpause.Location = New System.Drawing.Point(895, 490)
        Me.lblpause.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpause.Name = "lblpause"
        Me.lblpause.Size = New System.Drawing.Size(223, 47)
        Me.lblpause.TabIndex = 40
        Me.lblpause.Text = "Pause"
        Me.lblpause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(911, 384)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 17)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "3."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(911, 321)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 17)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "2."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(911, 257)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 17)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "1."
        '
        'lblthirdscore
        '
        Me.lblthirdscore.AutoSize = True
        Me.lblthirdscore.Location = New System.Drawing.Point(1076, 384)
        Me.lblthirdscore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblthirdscore.Name = "lblthirdscore"
        Me.lblthirdscore.Size = New System.Drawing.Size(16, 17)
        Me.lblthirdscore.TabIndex = 36
        Me.lblthirdscore.Text = "0"
        '
        'lblthird
        '
        Me.lblthird.AutoSize = True
        Me.lblthird.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthird.Location = New System.Drawing.Point(943, 384)
        Me.lblthird.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblthird.Name = "lblthird"
        Me.lblthird.Size = New System.Drawing.Size(96, 17)
        Me.lblthird.TabIndex = 35
        Me.lblthird.Text = "PlaceHolder"
        '
        'lblsecondscore
        '
        Me.lblsecondscore.AutoSize = True
        Me.lblsecondscore.Location = New System.Drawing.Point(1076, 321)
        Me.lblsecondscore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsecondscore.Name = "lblsecondscore"
        Me.lblsecondscore.Size = New System.Drawing.Size(16, 17)
        Me.lblsecondscore.TabIndex = 34
        Me.lblsecondscore.Text = "0"
        '
        'lblscoreshow
        '
        Me.lblscoreshow.AutoSize = True
        Me.lblscoreshow.Location = New System.Drawing.Point(1040, 140)
        Me.lblscoreshow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblscoreshow.Name = "lblscoreshow"
        Me.lblscoreshow.Size = New System.Drawing.Size(16, 17)
        Me.lblscoreshow.TabIndex = 29
        Me.lblscoreshow.Text = "0"
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.Location = New System.Drawing.Point(916, 140)
        Me.lblscore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(55, 17)
        Me.lblscore.TabIndex = 28
        Me.lblscore.Text = "Score:"
        '
        'lbllevelshow
        '
        Me.lbllevelshow.AutoSize = True
        Me.lbllevelshow.Location = New System.Drawing.Point(1040, 102)
        Me.lbllevelshow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllevelshow.Name = "lbllevelshow"
        Me.lbllevelshow.Size = New System.Drawing.Size(16, 17)
        Me.lbllevelshow.TabIndex = 27
        Me.lbllevelshow.Text = "1"
        '
        'lbllevel
        '
        Me.lbllevel.AutoSize = True
        Me.lbllevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllevel.Location = New System.Drawing.Point(916, 102)
        Me.lbllevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllevel.Name = "lbllevel"
        Me.lbllevel.Size = New System.Drawing.Size(52, 17)
        Me.lbllevel.TabIndex = 26
        Me.lbllevel.Text = "Level:"
        '
        'tm_snakeMover
        '
        Me.tm_snakeMover.Interval = 80
        '
        'lblsecond
        '
        Me.lblsecond.AutoSize = True
        Me.lblsecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecond.Location = New System.Drawing.Point(943, 321)
        Me.lblsecond.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsecond.Name = "lblsecond"
        Me.lblsecond.Size = New System.Drawing.Size(96, 17)
        Me.lblsecond.TabIndex = 33
        Me.lblsecond.Text = "PlaceHolder"
        '
        'lblfirstscore
        '
        Me.lblfirstscore.AutoSize = True
        Me.lblfirstscore.Location = New System.Drawing.Point(1076, 257)
        Me.lblfirstscore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfirstscore.Name = "lblfirstscore"
        Me.lblfirstscore.Size = New System.Drawing.Size(16, 17)
        Me.lblfirstscore.TabIndex = 32
        Me.lblfirstscore.Text = "0"
        '
        'lblfirst
        '
        Me.lblfirst.AutoSize = True
        Me.lblfirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirst.Location = New System.Drawing.Point(943, 257)
        Me.lblfirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfirst.Name = "lblfirst"
        Me.lblfirst.Size = New System.Drawing.Size(96, 17)
        Me.lblfirst.TabIndex = 31
        Me.lblfirst.Text = "PlaceHolder"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(899, 177)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 41)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Best Score"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(891, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 97)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Snake"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'snake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 618)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblspeed)
        Me.Controls.Add(Me.lblspeedname)
        Me.Controls.Add(Me.lblresume)
        Me.Controls.Add(Me.lblexit)
        Me.Controls.Add(Me.lblpause)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblthirdscore)
        Me.Controls.Add(Me.lblthird)
        Me.Controls.Add(Me.lblsecondscore)
        Me.Controls.Add(Me.lblscoreshow)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.lbllevelshow)
        Me.Controls.Add(Me.lbllevel)
        Me.Controls.Add(Me.lblsecond)
        Me.Controls.Add(Me.lblfirstscore)
        Me.Controls.Add(Me.lblfirst)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb_Field)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "snake"
        Me.Text = "Snake"
        CType(Me.pb_Field, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_Field As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblspeed As System.Windows.Forms.Label
    Friend WithEvents lblspeedname As System.Windows.Forms.Label
    Friend WithEvents lblresume As System.Windows.Forms.Label
    Friend WithEvents lblexit As System.Windows.Forms.Label
    Friend WithEvents lblpause As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblthirdscore As System.Windows.Forms.Label
    Friend WithEvents lblthird As System.Windows.Forms.Label
    Friend WithEvents lblsecondscore As System.Windows.Forms.Label
    Friend WithEvents lblscoreshow As System.Windows.Forms.Label
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents lbllevelshow As System.Windows.Forms.Label
    Friend WithEvents lbllevel As System.Windows.Forms.Label
    Friend WithEvents tm_snakeMover As System.Windows.Forms.Timer
    Friend WithEvents lblsecond As System.Windows.Forms.Label
    Friend WithEvents lblfirstscore As System.Windows.Forms.Label
    Friend WithEvents lblfirst As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
