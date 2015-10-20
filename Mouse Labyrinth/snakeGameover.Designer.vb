<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class snakeGameOver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(snakeGameOver))
        Me.lblthirdname = New System.Windows.Forms.Label()
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.lblsecondname = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblfirst = New System.Windows.Forms.Label()
        Me.lblthird = New System.Windows.Forms.Label()
        Me.lblsecond = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblthirdname
        '
        Me.lblthirdname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthirdname.Location = New System.Drawing.Point(379, 300)
        Me.lblthirdname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblthirdname.Name = "lblthirdname"
        Me.lblthirdname.Size = New System.Drawing.Size(147, 100)
        Me.lblthirdname.TabIndex = 22
        Me.lblthirdname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfirstname
        '
        Me.lblfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirstname.Location = New System.Drawing.Point(379, 143)
        Me.lblfirstname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(147, 100)
        Me.lblfirstname.TabIndex = 21
        Me.lblfirstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsecondname
        '
        Me.lblsecondname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecondname.Location = New System.Drawing.Point(379, 220)
        Me.lblsecondname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsecondname.Name = "lblsecondname"
        Me.lblsecondname.Size = New System.Drawing.Size(147, 100)
        Me.lblsecondname.TabIndex = 20
        Me.lblsecondname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(499, 455)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(300, 89)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblfirst
        '
        Me.lblfirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirst.Location = New System.Drawing.Point(551, 143)
        Me.lblfirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfirst.Name = "lblfirst"
        Me.lblfirst.Size = New System.Drawing.Size(147, 100)
        Me.lblfirst.TabIndex = 18
        Me.lblfirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblthird
        '
        Me.lblthird.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthird.Location = New System.Drawing.Point(551, 300)
        Me.lblthird.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblthird.Name = "lblthird"
        Me.lblthird.Size = New System.Drawing.Size(147, 100)
        Me.lblthird.TabIndex = 17
        Me.lblthird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsecond
        '
        Me.lblsecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecond.Location = New System.Drawing.Point(551, 220)
        Me.lblsecond.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsecond.Name = "lblsecond"
        Me.lblsecond.Size = New System.Drawing.Size(147, 100)
        Me.lblsecond.TabIndex = 16
        Me.lblsecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(224, 220)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 100)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "2."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 300)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 100)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "3."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 100)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "1."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 113)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "High  Score"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(146, 455)
        Me.btnRestart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(300, 89)
        Me.btnRestart.TabIndex = 23
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'snakeGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 575)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblthirdname)
        Me.Controls.Add(Me.lblfirstname)
        Me.Controls.Add(Me.lblsecondname)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblfirst)
        Me.Controls.Add(Me.lblthird)
        Me.Controls.Add(Me.lblsecond)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "snakeGameOver"
        Me.Text = "Game Over"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblthirdname As System.Windows.Forms.Label
    Friend WithEvents lblfirstname As System.Windows.Forms.Label
    Friend WithEvents lblsecondname As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblfirst As System.Windows.Forms.Label
    Friend WithEvents lblthird As System.Windows.Forms.Label
    Friend WithEvents lblsecond As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
End Class
