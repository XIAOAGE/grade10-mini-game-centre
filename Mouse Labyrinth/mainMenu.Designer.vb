<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.picDontCross = New System.Windows.Forms.PictureBox()
        Me.picSnake1p = New System.Windows.Forms.PictureBox()
        Me.picMouse = New System.Windows.Forms.PictureBox()
        Me.picSnake2p = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClipboard = New System.Windows.Forms.Button()
        CType(Me.picDontCross, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake1p, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake2p, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDontCross
        '
        Me.picDontCross.BackColor = System.Drawing.Color.Transparent
        Me.picDontCross.Image = CType(resources.GetObject("picDontCross.Image"), System.Drawing.Image)
        Me.picDontCross.Location = New System.Drawing.Point(-5, -27)
        Me.picDontCross.Margin = New System.Windows.Forms.Padding(4)
        Me.picDontCross.Name = "picDontCross"
        Me.picDontCross.Size = New System.Drawing.Size(779, 639)
        Me.picDontCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picDontCross.TabIndex = 2
        Me.picDontCross.TabStop = False
        '
        'picSnake1p
        '
        Me.picSnake1p.Image = CType(resources.GetObject("picSnake1p.Image"), System.Drawing.Image)
        Me.picSnake1p.Location = New System.Drawing.Point(16, 487)
        Me.picSnake1p.Margin = New System.Windows.Forms.Padding(4)
        Me.picSnake1p.Name = "picSnake1p"
        Me.picSnake1p.Size = New System.Drawing.Size(291, 65)
        Me.picSnake1p.TabIndex = 3
        Me.picSnake1p.TabStop = False
        '
        'picMouse
        '
        Me.picMouse.BackColor = System.Drawing.Color.Transparent
        Me.picMouse.Image = CType(resources.GetObject("picMouse.Image"), System.Drawing.Image)
        Me.picMouse.Location = New System.Drawing.Point(771, 575)
        Me.picMouse.Margin = New System.Windows.Forms.Padding(4)
        Me.picMouse.Name = "picMouse"
        Me.picMouse.Size = New System.Drawing.Size(241, 65)
        Me.picMouse.TabIndex = 5
        Me.picMouse.TabStop = False
        '
        'picSnake2p
        '
        Me.picSnake2p.Image = CType(resources.GetObject("picSnake2p.Image"), System.Drawing.Image)
        Me.picSnake2p.Location = New System.Drawing.Point(16, 575)
        Me.picSnake2p.Margin = New System.Windows.Forms.Padding(4)
        Me.picSnake2p.Name = "picSnake2p"
        Me.picSnake2p.Size = New System.Drawing.Size(291, 65)
        Me.picSnake2p.TabIndex = 6
        Me.picSnake2p.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(417, 618)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(241, 65)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 686)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "http://mrcomputers.info/ShenMarco/MGC/home.html"
        '
        'btnClipboard
        '
        Me.btnClipboard.Location = New System.Drawing.Point(12, 709)
        Me.btnClipboard.Name = "btnClipboard"
        Me.btnClipboard.Size = New System.Drawing.Size(109, 32)
        Me.btnClipboard.TabIndex = 9
        Me.btnClipboard.Text = "Clipboard"
        Me.btnClipboard.UseVisualStyleBackColor = True
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 753)
        Me.Controls.Add(Me.btnClipboard)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.picSnake2p)
        Me.Controls.Add(Me.picMouse)
        Me.Controls.Add(Me.picSnake1p)
        Me.Controls.Add(Me.picDontCross)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "mainMenu"
        Me.Text = "Mini-Game Central"
        CType(Me.picDontCross, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake1p, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake2p, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picDontCross As System.Windows.Forms.PictureBox
    Friend WithEvents picSnake1p As System.Windows.Forms.PictureBox
    Friend WithEvents picMouse As System.Windows.Forms.PictureBox
    Friend WithEvents picSnake2p As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClipboard As System.Windows.Forms.Button
End Class
