Public Class Don_tcross

    Dim player1 As PictureBox
    Dim player1body(1000) As PictureBox
    Dim length_of_player1 As Integer = 0
    Dim left_right_mover As Integer = 0
    Dim up_down_mover As Integer = 0
    Dim checkLR As Integer = 0
    Dim checkUD As Integer = 0
    '#####################################
    Dim player2 As PictureBox
    Dim player2body(1000) As PictureBox
    Dim length_of_player2 As Integer = 0
    Dim left_right_mover2 As Integer = 0
    Dim up_down_mover2 As Integer = 0
    Dim checkLR2 As Integer = 0
    Dim checkUD2 As Integer = 0
    '######################################
    Dim x As Integer



    Private Sub create_player1()

        player1 = New PictureBox

        With player1
            .Height = 30
            .Width = 30
            .BackColor = Color.Purple
            .Top = 0
            .Left = 0
        End With

        Me.Controls.Add(player1)
        player1.BringToFront()

    End Sub

    Private Sub create_player2()

        player2 = New PictureBox

        With player2
            .Height = 30
            .Width = 30
            .BackColor = Color.ForestGreen
            .Top = 660
            .Left = 720
        End With

        Me.Controls.Add(player2)
        player2.BringToFront()

    End Sub

    Private Sub lengthenplayer1()

        length_of_player1 += 1
        player1body(length_of_player1) = New PictureBox

        With player1body(length_of_player1)
            .Height = 30
            .Width = 30
            .BackColor = Color.Purple
            .Top = 0
            .Left = 1000
        End With

        Me.Controls.Add(player1body(length_of_player1))
        player1body(length_of_player1).BringToFront()

    End Sub

    Private Sub lengthenplayer2()

        length_of_player2 += 1
        player2body(length_of_player2) = New PictureBox

        With player2body(length_of_player2)
            .Height = 30
            .Width = 30
            .BackColor = Color.ForestGreen
            .Top = 0
            .Left = 1000
        End With

        Me.Controls.Add(player2body(length_of_player2))
        player2body(length_of_player2).BringToFront()

    End Sub

    Private Sub Don_tcross_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        create_player1()
        create_player2()

        left_right_mover = 30
        left_right_mover2 = -30
        tm_snakeMover.Start()
        checkLR = 1
        checkLR2 = 2
        tm_snakeMover2.Start()

    End Sub

    Private Sub snake_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'This part is for snake control.
        'The number is to restrict snake that it can only move forward.
        Select Case e.KeyCode
            Case Keys.Left And checkLR <> 1
                checkLR = 2
                left_right_mover = -30
                up_down_mover = 0
                checkUD = 0

            Case Keys.Right And checkLR <> 2
                checkLR = 1
                left_right_mover = 30
                up_down_mover = 0
                checkUD = 0

            Case Keys.Up And checkUD <> 1
                checkUD = 2
                left_right_mover = 0
                up_down_mover = -30
                checkLR = 0

            Case Keys.Down And checkUD <> 2
                checkUD = 1
                left_right_mover = 0
                up_down_mover = 30
                checkLR = 0
        End Select
    End Sub

    Private Sub snake_KeyDown2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'This part is for snake control.
        'The number is to restrict snake that it can only move forward.
        Select Case e.KeyCode
            Case Keys.A And checkLR2 <> 1
                checkLR2 = 2
                left_right_mover2 = -30
                up_down_mover2 = 0
                checkUD2 = 0

            Case Keys.D And checkLR2 <> 2
                checkLR2 = 1
                left_right_mover2 = 30
                up_down_mover2 = 0
                checkUD2 = 0

            Case Keys.W And checkUD2 <> 1
                checkUD2 = 2
                left_right_mover2 = 0
                up_down_mover2 = -30
                checkLR2 = 0

            Case Keys.S And checkUD2 <> 2
                checkUD2 = 1
                left_right_mover2 = 0
                up_down_mover2 = 30
                checkLR2 = 0
        End Select
    End Sub

    Private Sub tm_snakeMover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm_snakeMover.Tick
        lengthenplayer1()
        Dim i As Integer
        For i = length_of_player1 To 0 Step -1
            If i = 1 Then
                player1body(length_of_player1).Left = player1.Left
                player1body(length_of_player1).Top = player1.Top
            ElseIf i > 1 Then
                player1body(length_of_player1).Left = player1body(length_of_player1 - 1).Left
                player1body(length_of_player1).Top = player1body(length_of_player1 - 1).Top
            End If
        Next

        player1.Top += up_down_mover
        player1.Left += left_right_mover
        collide_with_walls1()
        collide_with_other1()
        collide_with_self1()
    End Sub

    Private Sub tm_snakeMover2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm_snakeMover2.Tick

        lengthenplayer2()
        Dim i As Integer
        For i = length_of_player2 To 0 Step -1
            If i = 1 Then
                player2body(length_of_player2).Left = player2.Left
                player2body(length_of_player2).Top = player2.Top
            ElseIf i > 1 Then
                player2body(length_of_player2).Left = player2body(length_of_player2 - 1).Left
                player2body(length_of_player2).Top = player2body(length_of_player2 - 1).Top
            End If
        Next

        player2.Top += up_down_mover2
        player2.Left += left_right_mover2
        collide_with_walls2()
        Collide_with_other2()
        collide_with_self2()
    End Sub

    Private Sub collide_with_walls1()

        'This part checks if snake's head collide with walls
        If player1.Left < pb_map.Left Then
            tm_snakeMover.Stop()
            tm_snakeMover2.Stop()
            GlobalVariables.DClose = "Winner: Green!"
            GlobalVariables.DCgreen += 1
            lblPlayer1.Show()
        End If

        If player1.Right > pb_map.Right Then
            tm_snakeMover.Stop()
            tm_snakeMover2.Stop()
            GlobalVariables.DClose = "Winner: Green!"
            GlobalVariables.DCgreen += 1
            lblPlayer1.Show()
        End If

        If player1.Top < pb_map.Top Then
            tm_snakeMover.Stop()
            tm_snakeMover2.Stop()
            GlobalVariables.DClose = "Winner: Green!"
            GlobalVariables.DCgreen += 1
            lblPlayer1.Show()
        End If

        If player1.Bottom > pb_map.Bottom Then
            tm_snakeMover.Stop()
            tm_snakeMover2.Stop()
            GlobalVariables.DClose = "Winner: Green!"
            GlobalVariables.DCgreen += 1
            lblPlayer1.Show()
        End If
    End Sub

    Private Sub collide_with_walls2()

        'This part checks if snake's head collide with walls
        If player2.Left < pb_map.Left Then
            tm_snakeMover2.Stop()
            tm_snakeMover.Stop()
            GlobalVariables.DClose = "Winner: Purple!"
            GlobalVariables.DCpurple += 1
            lblPlayer1.Show()
        End If

        If player2.Right > pb_map.Right Then
            tm_snakeMover2.Stop()
            tm_snakeMover.Stop()
            GlobalVariables.DClose = "Winner: Purple!"
            GlobalVariables.DCpurple += 1
            lblPlayer1.Show()
        End If

        If player2.Top < pb_map.Top Then
            tm_snakeMover2.Stop()
            tm_snakeMover.Stop()
            GlobalVariables.DClose = "Winner: Purple!"
            GlobalVariables.DCpurple += 1
            lblPlayer1.Show()
        End If

        If player2.Bottom > pb_map.Bottom Then
            tm_snakeMover2.Stop()
            tm_snakeMover.Stop()
            GlobalVariables.DClose = "Winner: Purple!"
            GlobalVariables.DCpurple += 1
            lblPlayer1.Show()
        End If
    End Sub

    Private Sub collide_with_self1()
        Dim e As Integer

        For e = length_of_player1 To 1 Step -1
            If player1body(e).Left = player1.Left And player1body(e).Top = player1.Top Then
                tm_snakeMover.Stop()
                tm_snakeMover2.Stop()
                GlobalVariables.DClose = "Winner: Green!"
                GlobalVariables.DCgreen += 1
                lblPlayer1.Show()
            End If
        Next

    End Sub

    Private Sub collide_with_self2()
        Dim e As Integer

        For e = length_of_player2 To 1 Step -1
            If player2body(e).Left = player2.Left And player2body(e).Top = player2.Top Then
                tm_snakeMover2.Stop()
                tm_snakeMover.Stop()
                GlobalVariables.DClose = "Winner: Purple!"
                GlobalVariables.DCpurple += 1
                lblPlayer1.Show()
            End If
        Next
    End Sub

    Private Sub collide_with_other1()

        Dim e As Integer
        For e = length_of_player2 To 1 Step -1

            If player1.Top = player2body(e).Top And player1.Left = player2body(e).Left Then
                tm_snakeMover2.Stop()
                tm_snakeMover.Stop()
                GlobalVariables.DClose = "Winner: Green!"
                GlobalVariables.DCgreen += 1
                lblPlayer1.Show()
            End If
        Next
    End Sub

    Private Sub Collide_with_other2()
        Dim e As Integer
        For e = length_of_player1 To 1 Step -1

            If player2.Top = player1body(e).Top And player2.Left = player1body(e).Left Then
                tm_snakeMover2.Stop()
                tm_snakeMover.Stop()
                GlobalVariables.DClose = "Winner: Purple!"
                GlobalVariables.DCpurple += 1
                lblPlayer1.Show()
            End If
        Next
    End Sub
End Class
