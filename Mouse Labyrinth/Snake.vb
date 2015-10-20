Public Class snake
    'This is Bryan and Marco's snake game.
    'It is finished on June 2th
    'You need to use arrows to control the snake. There are seven levels. Snake's speed will increase.
    'eat the mouse and snake will be lengthened.

    Dim snakehead As PictureBox                'This is the body of the snake
    Dim snakebody(999) As PictureBox            'This is the body of the snake
    Dim length_of_snake As Integer = 0         'This is the initial length of the snake
    Dim left_right_mover As Integer = 0         'This is the horizontal distance snake moves every 50 miliseconds
    Dim up_down_mover As Integer = 0            'This is the vertical distance snake moves every 50 miliseconds
    Dim checkLR As Integer = 0                  'This variable is make snake can only move forward, when it's moving horizontally
    Dim checkUD As Integer = 0                  'This variable is make snake can only move forward, when it's moving vertically
    Dim score As Integer = 0                    'The score starts from 0
    Dim colornumber As Integer = 0
    Dim test1 As Integer
    Dim test2 As Integer
    Dim mouse As PictureBox
    Dim highScore(3) As Integer
    Dim highScoreName(3) As String

    Private Sub create_head()
        'here is creating the head of the snake.
        snakehead = New PictureBox
        With snakehead
            .Height = 19                              'size of the snake's head
            .Width = 19
            .BackColor = Color.Red                     'snake's color

            'locate snake randomly.
            test1 = Math.Round(Rnd() * 23)
            test2 = Math.Round(Rnd() * 27)

            .Top = test1 * 20
            .Left = test2 * 20

        End With

        Me.Controls.Add(snakehead)
        snakehead.BringToFront()

    End Sub

    Private Sub snake_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'This part is for snake control.
        'The number is to restrict snake that it can only move forward.

        Select Case e.KeyCode
            Case Keys.Left And checkLR <> 1
                checkLR = 2
                left_right_mover = -20
                up_down_mover = 0
                checkUD = 0
            Case Keys.Right And checkLR <> 2
                checkLR = 1
                left_right_mover = 20
                up_down_mover = 0
                checkUD = 0
            Case Keys.Up And checkUD <> 1
                checkUD = 2
                left_right_mover = 0
                up_down_mover = -20
                checkLR = 0
            Case Keys.Down And checkUD <> 2
                checkUD = 1
                left_right_mover = 0
                up_down_mover = 20
                checkLR = 0
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        create_head()
        tm_snakeMover.Start()
        create_mouse()
        fillHighScoreFromFile()
    End Sub

    Private Sub tm_snakeMover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm_snakeMover.Tick
        Dim i As Integer
        'This is part is for snake's body follow snake's head's path.
        For i = length_of_snake To 1 Step -1
            If i = 1 Then
                snakebody(i).Top = snakehead.Top
                snakebody(i).Left = snakehead.Left
            ElseIf i > 1 Then
                snakebody(i).Top = snakebody(i - 1).Top
                snakebody(i).Left = snakebody(i - 1).Left
            End If
        Next

        'Every time inteval, snake's location is changed.
        snakehead.Top += up_down_mover
        snakehead.Left += left_right_mover

        collide_with_walls()
        collide_with_mouse()
        collide_with_self()
        speed()
    End Sub

    Private Sub lengthenSnake()

        'This part is to lengthen the snake.
        length_of_snake += 1
        colornumber += 1
        snakebody(length_of_snake) = New PictureBox
        With snakebody(length_of_snake)

            .Height = 19
            .Width = 19

            'change snake's body's color.
            If colornumber = 1 Then
                .BackColor = Color.Orange
            ElseIf colornumber = 2 Then
                .BackColor = Color.Yellow
            ElseIf colornumber = 3 Then
                .BackColor = Color.Green
            ElseIf colornumber = 4 Then
                .BackColor = Color.Turquoise
            ElseIf colornumber = 5 Then
                .BackColor = Color.Blue
            ElseIf colornumber = 6 Then
                .BackColor = Color.Violet
            ElseIf colornumber = 7 Then
                .BackColor = Color.Red
                colornumber -= 7
            End If

            .Top = snakehead.Top
            .Left = snakehead.Left + 1000

        End With

        Me.Controls.Add(snakebody(length_of_snake))
        snakebody(length_of_snake).BringToFront()
    End Sub

    Private Sub collide_with_walls()

        'This part checks if snake's head collide with walls
        If snakehead.Left < pb_Field.Left Then
            tm_snakeMover.Stop()
            MessageBox.Show("You lose")
            checkForHighScore()
            snakeGameOver.Show()
        End If

        If snakehead.Right > pb_Field.Right Then
            tm_snakeMover.Stop()
            MessageBox.Show("You lose")
            checkForHighScore()
            snakeGameover.Show()
        End If

        If snakehead.Top < pb_Field.Top Then
            tm_snakeMover.Stop()
            MessageBox.Show("You lose")
            checkForHighScore()
            snakeGameover.Show()
        End If

        If snakehead.Bottom > pb_Field.Bottom Then
            tm_snakeMover.Stop()
            MessageBox.Show("You lose")
            checkForHighScore()
            snakeGameover.Show()
        End If
    End Sub

    Private Sub create_mouse()

        'This part creates mouse
        mouse = New PictureBox
        With mouse

            .Width = 19
            .Height = 19
            .BackColor = Color.Gray

            'Create mouse randomly
            test1 = Math.Round(Rnd() * 23)
            test2 = Math.Round(Rnd() * 27)

            .Top = test1 * 20
            .Left = test2 * 20
        End With

        Me.Controls.Add(mouse)
        mouse.BringToFront()
    End Sub

    Private Sub collide_with_mouse()

        'This part check if snake's head collide with the mouse
        If snakehead.Bounds.IntersectsWith(mouse.Bounds) Then
            lengthenSnake()
            test1 = Math.Round(Rnd() * 23)
            test2 = Math.Round(Rnd() * 27)

            'locate mouse randomly.
            mouse.Top = test1 * 20
            mouse.Left = test2 * 20

            score += 100
            lblscoreshow.Text = score

            'This part keep track of score and change level and speed
            If score >= 1000 And score <= 2000 Then
                tm_snakeMover.Interval = 75
                lbllevelshow.Text = 2
            ElseIf score >= 2000 And score <= 3000 Then
                tm_snakeMover.Interval = 70
                lbllevelshow.Text = 3
            ElseIf score >= 4000 And score <= 6000 Then
                tm_snakeMover.Interval = 65
                lbllevelshow.Text = 4
            ElseIf score > 6000 And score <= 8000 Then
                tm_snakeMover.Interval = 60
                lbllevelshow.Text = 5
            ElseIf score > 8000 And score <= 10000 Then
                tm_snakeMover.Interval = 55
                lbllevelshow.Text = 6
            ElseIf score > 10000 Then
                tm_snakeMover.Interval = 50
                lbllevelshow.Text = 7
            End If
        End If
    End Sub

    Private Sub collide_with_self()
        'This part check if mouse collide with itself
        Dim e As Integer

        For e = length_of_snake To 1 Step -1
            If snakebody(e).Left = snakehead.Left And snakebody(e).Top = snakehead.Top Then
                tm_snakeMover.Stop()
                MessageBox.Show("game over")
                checkForHighScore()
                snakeGameover.Show()
            End If
        Next
    End Sub

    Private Sub fillHighScoreFromFile()

        'read scores from the .txt document'
        'fill the high score board with the score in the ducument
        Dim highScoreTextFile As New System.IO.StreamReader(CurDir() & "SnakeHighScore.txt")

        For i = 0 To 2

            highScoreName(i) = highScoreTextFile.ReadLine
            highScore(i) = highScoreTextFile.ReadLine

        Next

        lblfirst.Text = highScoreName(0)
        lblfirstscore.Text = highScore(0)

        lblsecond.Text = highScoreName(1)
        lblsecondscore.Text = highScore(1)

        lblthird.Text = highScoreName(2)
        lblthirdscore.Text = highScore(2)

        highScoreTextFile.Close()
    End Sub

    Private Sub checkForHighScore()

        'Check if current score is higher that previous score
        For i = 0 To 2
            If lblscoreshow.Text > highScore(i) Then
                'if it is higher than previous score, it will ask user's name and write it into .txt document.
                bumpScoresDown(i)
                highScoreName(i) = GlobalVariables.PlayerName
                highScore(i) = lblscoreshow.Text
                Exit For
            End If
        Next
        updateHighScores()
        writeTheHighScoreToFile()

    End Sub

    Private Sub updateHighScores()
        'upadte the high score to the high score board.
        lblfirst.Text = highScoreName(0)
        lblfirstscore.Text = highScore(0)

        lblsecond.Text = highScoreName(1)
        lblsecondscore.Text = highScore(1)

        lblthird.Text = highScoreName(2)
        lblthirdscore.Text = highScore(2)

    End Sub

    Private Sub bumpScoresDown(ByVal newScoreSpot As Integer)
        'check which index should be replaced by the current score. And bump down the ranks
        For i = 2 To newScoreSpot Step -1
            highScore(i + 1) = highScore(i)
            highScoreName(i + 1) = highScoreName(i)
        Next

    End Sub

    Private Sub writeTheHighScoreToFile()
        'rewrite the rank in the .txt document.
        Dim highScoreTxtFile As New System.IO.StreamWriter(CurDir() & "SnakeHighScore.txt")
        For i = 0 To 2
            highScoreTxtFile.Write(highScoreName(i))
            highScoreTxtFile.WriteLine()
            highScoreTxtFile.Write(highScore(i))
            highScoreTxtFile.WriteLine()
        Next
        highScoreTxtFile.Close()
    End Sub

    Private Sub lblpause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblpause.Click
        'pause function
        tm_snakeMover.Stop()
        lblpause.Visible = False
        lblresume.Visible = True
    End Sub

    Private Sub lblexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblexit.Click
        'exit funtion
        End
    End Sub

    Private Sub lblresume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblresume.Click
        'resume function
        tm_snakeMover.Start()
        lblpause.Visible = True
        lblresume.Visible = False
    End Sub

    Private Sub speed()
        'calculate the speed
        Dim speed As Integer
        speed = 20 / tm_snakeMover.Interval * 1000
        lblspeed.Text = speed
    End Sub
End Class
