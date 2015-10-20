Public Class lblPlayer1

    Private Sub dontCrossGameover_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTut1.Text = GlobalVariables.PlayerName
        lblTut2.Text = GlobalVariables.PlayerName2
        If GlobalVariables.DCpurple = 0 And GlobalVariables.DCgreen = 0 Then
            lblScore.Visible = False
            lblWinner.Visible = False
        Else
            Don_tcross.Close()
            lblWinner.Text = GlobalVariables.DClose
            lblScore.Text = "Green: " & GlobalVariables.DCgreen & " - " & GlobalVariables.DCpurple & " :Purple"
        End If
    End Sub

    Private Sub dontCrossGameover_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Space
                Don_tcross.Show()
                Me.Close()
        End Select
    End Sub
End Class