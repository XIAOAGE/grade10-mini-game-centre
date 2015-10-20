Public Class _2PlayerSnake

    Dim snakehead2 As PictureBox
    Dim snakebody2(999) As PictureBox
    Dim snakehead As PictureBox
    Dim snakebody(999) As PictureBox
    Dim length_of_snake As Integer = 0
    Dim length_of_snake2 As Integer = 0
    Dim mouse As PictureBox
    Dim checkLR As Integer = 0
    Dim checkUD As Integer = 0
    Dim checkLR2 As Integer = 0
    Dim checkUD2 As Integer = 0
    Dim left_right_mover As Integer = 0
    Dim up_down_mover As Integer = 0
    Dim left_right_mover2 As Integer = 0
    Dim up_down_mover2 As Integer = 0
    Dim score As Integer = 0
    Dim score2 As Integer = 0
    Dim finalscore As Integer
    Dim finalscore2 As Integer

    Private Sub create_head()

        Dim test1 As Integer
        Dim test2 As Integer


        snakehead = New PictureBox
        With snakehead
            .Height = 19
            .Width = 19
            .BackColor = Color.Black


            test1 = Math.Round(Rnd() * 23)
            test2 = Math.Round(Rnd() * 27)

            .Top = test1 * 20
            .Left = test2 * 20

        End With

        Me.Controls.Add(snakehead)
        snakehead.BringToFront()

    End Sub

    Private Sub lengthenSnake()

        'This part is to lengthen the snake.
        length_of_snake += 1
        snakebody(length_of_snake) = New PictureBox
        With snakebody(length_of_snake)

            .Height = 19
            .Width = 19

            'change snake's body's color.
            .BackColor = Color.Black


            .Top = snakehead.Top
            .Left = snakehead.Left + 1000


        End With

        Me.Controls.Add(snakebody(length_of_snake))
        snakebody(length_of_snake).BringToFront()
    End Sub

    Private Sub lengthenSnake2()

        'This part is to lengthen the snake.
        length_of_snake2 += 1
        snakebody2(length_of_snake2) = New PictureBox
        With snakebody2(length_of_snake2)

            .Height = 19
            .Width = 19

            'change snake's body's color.
            .BackColor = Color.Red

            .Top = snakehead2.Top
            .Left = snakehead2.Left + 1000


        End With

        Me.Controls.Add(snakebody2(length_of_snake2))
        snakebody2(length_of_snake2).BringToFront()
    End Sub

    Private Sub create_head2()

        Dim test1 As Integer
        Dim test2 As Integer


        snakehead2 = New PictureBox
        With snakehead2
            .Height = 19
            .Width = 19
            .BackColor = Color.Red


            test1 = Math.Round(Rnd() * 23)
            test2 = Math.Round(Rnd() * 27)

            .Top = test1 * 20
            .Left = test2 * 20

        End With

        Me.Controls.Add(snakehead2)
        snakehead2.BringToFront()

    End Sub

    Private Sub create_mouse()

        Dim test1 As Integer
        Dim test2 As Integer
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

        Dim test1 As Integer
        Dim test2 As Integer
        'This part check if snake's head collide with the mouse
        If snakehead.Bounds.IntersectsWith(mouse.Bounds) Then
            lengthenSnake()
            test1 = Math.Round(Rnd() * 23)
            test2 = Math.Round(Rnd() * 27)

            'locate mouse randomly.
            mouse.Top = test1 * 20
            mouse.Left = test2 * 20

            score += 100
            Player1Score.Text = score

            'This part keep track of score and change level and speed
            If score >= 1000 And score <= 2000 Then
                tm_snakeMover.Interval = 75
            ElseIf score >= 2000 And score <= 3000 Then
                tm_snakeMover.Interval = 70
            ElseIf score >= 4000 And score <= 6000 Then
                tm_snakeMover.Interval = 65
            ElseIf score > 6000 And score <= 8000 Then
                tm_snakeMover.Interval = 60
            ElseIf score > 8000 And score <= 10000 Then
                tm_snakeMover.Interval = 55
            ElseIf score > 10000 Then
                tm_snakeMover.Interval = 50
            End If
        End If

        finalscore = score
    End Sub

    Private Sub collide_with_mouse2()

        Dim test1 As Integer
        Dim test2 As Integer
        'This part check if snake's head collide with the mouse
        If snakehead2.Bounds.IntersectsWith(mouse.Bounds) Then
            lengthenSnake2()
            test1 = Math.Round(Rnd() * 23)
            test2 = Math.Round(Rnd() * 27)

            'locate mouse randomly.
            mouse.Top = test1 * 20
            mouse.Left = test2 * 20

            score2 += 100
            Player2Score.Text = score2

            'This part keep track of score and change level and speed
            If score2 >= 1000 And score2 <= 2000 Then
                tm_snakeMover.Interval = 75
            ElseIf score2 >= 2000 And score2 <= 3000 Then
                tm_snakeMover.Interval = 70
            ElseIf score2 >= 4000 And score2 <= 6000 Then
                tm_snakeMover.Interval = 65
            ElseIf score2 > 6000 And score2 <= 8000 Then
                tm_snakeMover.Interval = 60
            ElseIf score2 > 8000 And score2 <= 10000 Then
                tm_snakeMover.Interval = 55
            ElseIf score2 > 10000 Then
                tm_snakeMover.Interval = 50
            End If
        End If

        finalscore2 = score2
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

    Private Sub snake_KeyDown2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'This part is for snake control.
        'The number is to restrict snake that it can only move forward.

        Select Case e.KeyCode
            Case Keys.A And checkLR2 <> 1
                checkLR2 = 2
                left_right_mover2 = -20
                up_down_mover2 = 0
                checkUD2 = 0
            Case Keys.D And checkLR2 <> 2
                checkLR2 = 1
                left_right_mover2 = 20
                up_down_mover2 = 0
                checkUD2 = 0
            Case Keys.W And checkUD2 <> 1
                checkUD2 = 2
                left_right_mover2 = 0
                up_down_mover2 = -20
                checkLR2 = 0
            Case Keys.S And checkUD2 <> 2
                checkUD2 = 1
                left_right_mover2 = 0
                up_down_mover2 = 20
                checkLR2 = 0
        End Select

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


    End Sub

    Private Sub tm_snakeMover_Tick2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm_snakeMover.Tick

        Dim a As Integer

        'This is part is for snake's body follow snake's head's path.
        For a = length_of_snake2 To 1 Step -1
            If a = 1 Then
                snakebody2(a).Top = snakehead2.Top
                snakebody2(a).Left = snakehead2.Left
            ElseIf a > 1 Then
                snakebody2(a).Top = snakebody2(a - 1).Top
                snakebody2(a).Left = snakebody2(a - 1).Left
            End If
        Next

        snakehead2.Top += up_down_mover2
        snakehead2.Left += left_right_mover2

        collide_with_walls2()
        collide_with_mouse2()
        collide_with_self2()
    End Sub

    Private Sub collide_with_walls()

        'This part checks if snake's head collide with walls
        If snakehead.Left < pb_Field.Left Or snakehead.Right > pb_Field.Right Or snakehead.Top < pb_Field.Top Or snakehead.Bottom > pb_Field.Bottom Then
            tm_snakeMover.Stop()
            finalscore -= 1000
            If finalscore > finalscore2 Then
                GlobalVariables.SFinal1 = finalscore
                GlobalVariables.SFinal2 = finalscore2
                GlobalVariables.SnakeWinner = name1
                _2PlayerSnakeEnd.Show()
            ElseIf finalscore < finalscore2 Then
                GlobalVariables.SFinal1 = finalscore
                GlobalVariables.SFinal2 = finalscore2
                GlobalVariables.SnakeWinner = name2
                _2PlayerSnakeEnd.Show()
            ElseIf finalscore = finalscore2 Then
                GlobalVariables.SFinal1 = finalscore
                GlobalVariables.SFinal2 = finalscore2
                GlobalVariables.SnakeWinner = "Tie"
                _2PlayerSnakeEnd.Show()
            End If
        End If
    End Sub

    Private Sub collide_with_walls2()

        'This part checks if snake's head collide with walls
        If snakehead2.Left < pb_Field.Left Or snakehead2.Right > pb_Field.Right Or snakehead2.Top < pb_Field.Top Or snakehead2.Bottom > pb_Field.Bottom Then
            tm_snakeMover.Stop()
            finalscore2 -= 1000
            If finalscore > finalscore2 Then
                GlobalVariables.SFinal1 = finalscore
                GlobalVariables.SFinal2 = finalscore2
                GlobalVariables.SnakeWinner = name1
                _2PlayerSnakeEnd.Show()
            ElseIf finalscore < finalscore2 Then
                GlobalVariables.SFinal1 = finalscore
                GlobalVariables.SFinal2 = finalscore2
                GlobalVariables.SnakeWinner = name2
                _2PlayerSnakeEnd.Show()
            ElseIf finalscore = finalscore2 Then
                GlobalVariables.SFinal1 = finalscore
                GlobalVariables.SFinal2 = finalscore2
                GlobalVariables.SnakeWinner = "Tie"
                _2PlayerSnakeEnd.Show()
            End If
        End If
    End Sub

    Private Sub collide_with_self()
        'This part check if mouse collide with itself
        Dim e As Integer

        For e = length_of_snake To 1 Step -1
            If snakebody(e).Left = snakehead.Left And snakebody(e).Top = snakehead.Top Then
                tm_snakeMover.Stop()
                finalscore -= 1000
                If finalscore > finalscore2 Then
                    GlobalVariables.SFinal1 = finalscore
                    GlobalVariables.SFinal2 = finalscore2
                    GlobalVariables.SnakeWinner = name1
                    _2PlayerSnakeEnd.Show()
                ElseIf finalscore < finalscore2 Then
                    GlobalVariables.SFinal1 = finalscore
                    GlobalVariables.SFinal2 = finalscore2
                    GlobalVariables.SnakeWinner = name2
                    _2PlayerSnakeEnd.Show()
                ElseIf finalscore = finalscore2 Then
                    GlobalVariables.SFinal1 = finalscore
                    GlobalVariables.SFinal2 = finalscore2
                    GlobalVariables.SnakeWinner = "Tie"
                    _2PlayerSnakeEnd.Show()
                End If
            End If
        Next
    End Sub

    Private Sub collide_with_self2()
        'This part check if mouse collide with itself
        Dim e As Integer

        For e = length_of_snake2 To 1 Step -1
            If snakebody2(e).Left = snakehead2.Left And snakebody2(e).Top = snakehead2.Top Then
                tm_snakeMover.Stop()
                finalscore2 -= 1000
                If finalscore > finalscore2 Then
                    GlobalVariables.SFinal1 = finalscore
                    GlobalVariables.SFinal2 = finalscore2
                    GlobalVariables.SnakeWinner = name1
                    _2PlayerSnakeEnd.Show()
                ElseIf finalscore < finalscore2 Then
                    GlobalVariables.SFinal1 = finalscore
                    GlobalVariables.SFinal2 = finalscore2
                    GlobalVariables.SnakeWinner = name2
                    _2PlayerSnakeEnd.Show()
                ElseIf finalscore = finalscore2 Then
                    GlobalVariables.SFinal1 = finalscore
                    GlobalVariables.SFinal2 = finalscore2
                    GlobalVariables.SnakeWinner = "Tie"
                    _2PlayerSnakeEnd.Show()
                End If
            End If
        Next
    End Sub

    Dim name1 As String
    Dim name2 As String

    Public Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _2PlayerSnakeEnd.Close()
        name1 = GlobalVariables.PlayerName
        Player1.Text = name1
        If GlobalVariables.PlayerName2 = "" Then
            name2 = InputBox("Welcome to 2 Player Snake!" & vbNewLine & "You will need a second player in this game" & vbNewLine & "What is the second player name?")
        Else
            name2 = GlobalVariables.PlayerName2
        End If
        Player2.Text = name2
        create_head2()
        create_head()
        tm_snakeMover.Start()
        create_mouse()
        tm_snakeMover2.Start()
        GlobalVariables.PlayerName2 = name2
    End Sub
End Class