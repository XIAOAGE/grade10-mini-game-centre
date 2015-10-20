Public Class _2PlayerSnakeEnd

    Private Sub _2PlayerSnakeEnd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _2PlayerSnake.Close()
        lblWinner.Text = GlobalVariables.SnakeWinner
        lblPlayer.Text = GlobalVariables.PlayerName
        lblPlayer2.Text = GlobalVariables.PlayerName2
        lblScore1.Text = GlobalVariables.SFinal1
        lblScore2.Text = GlobalVariables.SFinal2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        GlobalVariables.SnakeWinner = ""
        GlobalVariables.SFinal1 = 0
        GlobalVariables.SFinal2 = 0
        _2PlayerSnake.Show()
    End Sub
End Class