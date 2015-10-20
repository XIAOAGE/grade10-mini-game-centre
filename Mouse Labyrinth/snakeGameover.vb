Public Class snakeGameOver

    Private Sub snakeGameOver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        snake.Close()
        fillHighScoreFromFile()
    End Sub

    Dim highScore(3) As Integer
    Dim highScoreName(3) As String

    Private Sub fillHighScoreFromFile()

        'read scores from the .txt document'
        'fill the high score board with the score in the ducument
        Dim highScoreTextFile As New System.IO.StreamReader(CurDir() & "SnakeHighScore.txt")

        For i = 0 To 2

            highScoreName(i) = highScoreTextFile.ReadLine
            highScore(i) = highScoreTextFile.ReadLine

        Next

        lblfirstname.Text = highScoreName(0)
        lblfirst.Text = highScore(0)

        lblsecondname.Text = highScoreName(1)
        lblsecond.Text = highScore(1)

        lblthirdname.Text = highScoreName(2)
        lblthird.Text = highScore(2)

        highScoreTextFile.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        snake.Show()
        Me.Close()
    End Sub
End Class