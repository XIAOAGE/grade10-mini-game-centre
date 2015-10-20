<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Don_tcross
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Don_tcross))
        Me.pb_map = New System.Windows.Forms.PictureBox()
        Me.tm_snakeMover = New System.Windows.Forms.Timer(Me.components)
        Me.tm_snakeMover2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pb_map, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_map
        '
        Me.pb_map.BackColor = System.Drawing.Color.White
        Me.pb_map.Location = New System.Drawing.Point(0, 0)
        Me.pb_map.Margin = New System.Windows.Forms.Padding(4)
        Me.pb_map.Name = "pb_map"
        Me.pb_map.Size = New System.Drawing.Size(1000, 849)
        Me.pb_map.TabIndex = 0
        Me.pb_map.TabStop = False
        '
        'tm_snakeMover
        '
        Me.tm_snakeMover.Interval = 80
        '
        'tm_snakeMover2
        '
        Me.tm_snakeMover2.Interval = 80
        '
        'Don_tcross
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 849)
        Me.Controls.Add(Me.pb_map)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Don_tcross"
        Me.Text = "Don't Cross"
        CType(Me.pb_map, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb_map As System.Windows.Forms.PictureBox
    Friend WithEvents tm_snakeMover As System.Windows.Forms.Timer
    Friend WithEvents tm_snakeMover2 As System.Windows.Forms.Timer
End Class
