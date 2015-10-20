Public Class mainMenu

    Private Sub mainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer = 0
        While x = 0
            GlobalVariables.PlayerName = InputBox("Welcome to Mini-Game Central" & vbNewLine & vbNewLine & "Please Enter your name" & vbNewLine)
            If GlobalVariables.PlayerName = "" Then
                MessageBox.Show("Please enter your name!")
            ElseIf GlobalVariables.PlayerName.Length > 25 Then
                MessageBox.Show("Your name is too long!")
            ElseIf GlobalVariables.PlayerName.Length <= 3 Then
                MessageBox.Show("Your name is too short!")
            Else
                x = 1
            End If
        End While
    End Sub

    Private Sub picMouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMouse.Click
        mouseLabyrinth.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        GlobalVariables.DCgreen = 0
        GlobalVariables.DCpurple = 0
        GlobalVariables.DClose = "Winner:"
        GlobalVariables.PlayerName2 = InputBox("Welcome to Don't Cross!" & vbNewLine & "You will need a second player in this game" & vbNewLine & "What is the second player name?")
        lblPlayer1.Show()
    End Sub

    Private Sub picSnake1p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSnake1p.Click
        snake.Show()
    End Sub

    Private Sub picSnake2p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSnake2p.Click
        _2PlayerSnake.Show()
    End Sub

    Private Sub btnClipboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClipboard.Click
        My.Computer.Clipboard.SetText("http://mrcomputers.info/ShenMarco/MGC/home.html")
    End Sub
End Class