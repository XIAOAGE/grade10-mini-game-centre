<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _2PlayerSnake
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_2PlayerSnake))
        Me.pb_Field = New System.Windows.Forms.PictureBox()
        Me.Player1 = New System.Windows.Forms.Label()
        Me.Player2 = New System.Windows.Forms.Label()
        Me.Player1Score = New System.Windows.Forms.Label()
        Me.Player2Score = New System.Windows.Forms.Label()
        Me.tm_snakeMover = New System.Windows.Forms.Timer(Me.components)
        Me.tm_snakeMover2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pb_Field, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_Field
        '
        Me.pb_Field.BackColor = System.Drawing.Color.White
        Me.pb_Field.Location = New System.Drawing.Point(0, 0)
        Me.pb_Field.Margin = New System.Windows.Forms.Padding(4)
        Me.pb_Field.Name = "pb_Field"
        Me.pb_Field.Size = New System.Drawing.Size(871, 616)
        Me.pb_Field.TabIndex = 2
        Me.pb_Field.TabStop = False
        '
        'Player1
        '
        Me.Player1.Font = New System.Drawing.Font("Georgia", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1.Location = New System.Drawing.Point(879, 89)
        Me.Player1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Player1.Name = "Player1"
        Me.Player1.Size = New System.Drawing.Size(88, 40)
        Me.Player1.TabIndex = 3
        Me.Player1.Text = "Player1"
        Me.Player1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Player2
        '
        Me.Player2.Font = New System.Drawing.Font("Georgia", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2.Location = New System.Drawing.Point(1024, 84)
        Me.Player2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Player2.Name = "Player2"
        Me.Player2.Size = New System.Drawing.Size(96, 45)
        Me.Player2.TabIndex = 4
        Me.Player2.Text = "Player2"
        Me.Player2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Player1Score
        '
        Me.Player1Score.Font = New System.Drawing.Font("Georgia", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1Score.Location = New System.Drawing.Point(879, 167)
        Me.Player1Score.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Player1Score.Name = "Player1Score"
        Me.Player1Score.Size = New System.Drawing.Size(92, 72)
        Me.Player1Score.TabIndex = 5
        Me.Player1Score.Text = "0"
        Me.Player1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Player2Score
        '
        Me.Player2Score.Font = New System.Drawing.Font("Georgia", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2Score.Location = New System.Drawing.Point(1028, 160)
        Me.Player2Score.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Player2Score.Name = "Player2Score"
        Me.Player2Score.Size = New System.Drawing.Size(92, 87)
        Me.Player2Score.TabIndex = 6
        Me.Player2Score.Text = "0"
        Me.Player2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tm_snakeMover
        '
        Me.tm_snakeMover.Interval = 80
        '
        'tm_snakeMover2
        '
        Me.tm_snakeMover2.Interval = 80
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(913, 247)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Rule"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(896, 305)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 259)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        '_2PlayerSnake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 617)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Player2Score)
        Me.Controls.Add(Me.Player1Score)
        Me.Controls.Add(Me.Player2)
        Me.Controls.Add(Me.Player1)
        Me.Controls.Add(Me.pb_Field)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "_2PlayerSnake"
        Me.Text = "Snake - 2 Player"
        CType(Me.pb_Field, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb_Field As System.Windows.Forms.PictureBox
    Friend WithEvents Player1 As System.Windows.Forms.Label
    Friend WithEvents Player2 As System.Windows.Forms.Label
    Friend WithEvents Player1Score As System.Windows.Forms.Label
    Friend WithEvents Player2Score As System.Windows.Forms.Label
    Friend WithEvents tm_snakeMover As System.Windows.Forms.Timer
    Friend WithEvents tm_snakeMover2 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
