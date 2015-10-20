
Public Class mouseLabyrinth

    'Check if the player is playing the game
    Private IsPlaying As Boolean
    Private IsEnded As Boolean = False
    Dim password As String
    Dim time As Integer

    'Ask the player for their name for later uses
    'Make all label together so if player hit ANY label it will lead to MouseEnter event below
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each C As Control In Me.Controls
            If TypeOf C Is Label Then
                AddHandler C.MouseEnter, AddressOf Label_MouseEnter
            End If
        Next
    End Sub

    'Check if the player hit any labels
    Private Sub Label_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsPlaying = False Then Return
        IsPlaying = False
        If picCheckPoint1.Visible = True Then
            MessageBox.Show("Uh oh, please go back to the checkpoint.")
        Else
            MessageBox.Show("Uh oh, please go back to the start.")
        End If
    End Sub

    'Start the game
    Private Sub picStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picStart.Click
        If IsPlaying = False Then IsPlaying = True
    End Sub

    'Check if player reached the checkpoint
    Private Sub picCheck1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCheck1.MouseEnter
        If IsPlaying = True Then picCheckPoint1.Visible = True
    End Sub

    'CheckPoint1
    Private Sub picCheckPoint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCheckPoint1.Click
        If IsEnded = False Then IsPlaying = True
    End Sub

    'Remove the gold label to make player easlier
    Private Sub picActive1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picActive1.MouseEnter
        If IsPlaying = True And picCheckPoint1.Visible = True Then
            lblTrap.Visible = False
        End If
    End Sub

    'Check if player reached the checkpoint
    Private Sub picCheck2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCheck2.MouseEnter
        If IsPlaying = True Then picCheckPoint2.Visible = True
    End Sub

    'CheckPoint2
    Private Sub picCheckPoint2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCheckPoint2.Click
        IsPlaying = True
    End Sub

    'Prevent people from cheating
    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picStart.MouseDown, picMove.MouseDown, picCheckPoint1.MouseDown, picEnded1.MouseDown, picActive3Recover.MouseDown, picCheckPoint2.MouseDown, picActive1.MouseDown, MyBase.MouseDown
        If IsPlaying = True And rbOff.Checked Then
            IsPlaying = False
            MsgBox("Please do not click while you are playing", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    '##############################################################################################################
    '#              Boxes Movements                                                                               #
    '##############################################################################################################

    'Sorry If this is a bit messy here because I don't full know how to use Timer to make objects to move.

    '---------------------------------------------------------------------------------------------------------------
    '|          Stage 1                                                                                            |
    '---------------------------------------------------------------------------------------------------------------

    Private Sub tmTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmTimer.Tick
        Dim cur As Icon 'Cursor
        If IsPlaying = True Then
            'Start the timer when the player IsPlaying
            tmTime.Start()
            lblTimeStats.Text = "(Started)"
            'Change the mouse cursor to "Mouse.ico" icon
            cur = (My.Resources.Mouse)
            Me.Cursor = New Cursor(cur.Handle)
        Else
            'Stop the timer
            tmTime.Stop()
            lblTimeStats.Text = "(Stopped)"
            'Change the cursor back to default
            Me.Cursor = Cursors.Default
        End If

        'Start other timers
        time = tmTime.Interval - 1000
        lblTime.Text = "Time: " & tmTime.Interval - 1000 & " second"
        tmTimer.Interval += 1
        If tmTimer.Interval >= 100 And tmTimer.Interval <= 101 Then
            tm1Up.Enabled = True
            tm7Up.Enabled = True
            tm8Up.Enabled = True
            tm9Up.Enabled = True
            tm10Up.Enabled = True
        ElseIf tmTimer.Interval >= 102 And tmTimer.Interval <= 103 Then
            tm2Up.Enabled = True
        ElseIf tmTimer.Interval >= 104 And tmTimer.Interval <= 105 Then
            tm3Up.Enabled = True
        ElseIf tmTimer.Interval >= 106 And tmTimer.Interval <= 107 Then
            tm4Up.Enabled = True
        ElseIf tmTimer.Interval >= 108 And tmTimer.Interval <= 109 Then
            tm5Up.Enabled = True
        ElseIf tmTimer.Interval >= 110 And tmTimer.Interval <= 111 Then
            tm6Up.Enabled = True
        End If
    End Sub

    'THESE ALL part of the code controls how the object move back and forth
    '#################################################################################################
    Private Sub tm1Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm1Up.Tick
        lblObject1.Top -= 20
        If lblObject1.Top < 385 Then
            tm1Down.Enabled = True
            tm1Up.Enabled = False
        End If
    End Sub

    Private Sub tm1Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm1Down.Tick
        lblObject1.Top += 20
        If lblObject1.Top > 475 Then
            tm1Down.Enabled = False
            tm1Up.Enabled = True
        End If
    End Sub

    Private Sub tm2Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm2Up.Tick
        lblObject2.Top -= 20
        If lblObject2.Top < 385 Then
            tm2Down.Enabled = True
            tm2Up.Enabled = False
        End If
    End Sub

    Private Sub tm2Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm2Down.Tick
        lblObject2.Top += 20
        If lblObject2.Top > 475 Then
            tm2Down.Enabled = False
            tm2Up.Enabled = True
        End If
    End Sub

    Private Sub tm3Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm3Up.Tick
        lblObject3.Top -= 20
        If lblObject3.Top < 385 Then
            tm3Down.Enabled = True
            tm3Up.Enabled = False
        End If
    End Sub

    Private Sub tm3Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm3Down.Tick
        lblObject3.Top += 20
        If lblObject3.Top > 475 Then
            tm3Down.Enabled = False
            tm3Up.Enabled = True
        End If
    End Sub

    Private Sub tm4Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm4Up.Tick
        lblObject4.Top -= 20
        If lblObject4.Top < 385 Then
            tm4Down.Enabled = True
            tm4Up.Enabled = False
        End If
    End Sub

    Private Sub tm4Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm4Down.Tick
        lblObject4.Top += 20
        If lblObject4.Top > 475 Then
            tm4Down.Enabled = False
            tm4Up.Enabled = True
        End If
    End Sub

    Private Sub tm5Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm5Up.Tick
        lblObject5.Top -= 20
        If lblObject5.Top < 385 Then
            tm5Down.Enabled = True
            tm5Up.Enabled = False
        End If
    End Sub

    Private Sub tm5Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm5Down.Tick
        lblObject5.Top += 20
        If lblObject5.Top > 475 Then
            tm5Down.Enabled = False
            tm5Up.Enabled = True
        End If
    End Sub

    Private Sub tm6Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm6Up.Tick
        lblObject6.Top -= 20
        If lblObject6.Top < 385 Then
            tm6Down.Enabled = True
            tm6Up.Enabled = False
        End If
    End Sub

    Private Sub tm6Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm6Down.Tick
        lblObject6.Top += 20
        If lblObject6.Top > 475 Then
            tm6Down.Enabled = False
            tm6Up.Enabled = True
        End If
    End Sub

    Private Sub tm7Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm7Up.Tick
        lblObject7.Top -= 30
        If lblObject7.Top < 28 Then
            tm7Down.Enabled = True
            tm7Up.Enabled = False
        End If
    End Sub

    Private Sub tm7Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm7Down.Tick
        lblObject7.Top += 30
        If lblObject7.Top > 295 Then
            tm7Down.Enabled = False
            tm7Up.Enabled = True
        End If
    End Sub

    Private Sub tm8Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm8Up.Tick
        lblObject8.Top -= 23
        If lblObject8.Top < 10 Then
            tm8Down.Enabled = True
            tm8Up.Enabled = False
        End If
    End Sub

    Private Sub tm8Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm8Down.Tick
        lblObject8.Top += 23
        If lblObject8.Top > 397 Then
            tm8Down.Enabled = False
            tm8Up.Enabled = True
        End If
    End Sub

    Private Sub tm9Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm9Up.Tick
        lblObject9.Left -= 20
        If lblObject9.Left < 505 Then
            tm9Down.Enabled = True
            tm9Up.Enabled = False
        End If
    End Sub

    Private Sub tm9Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm9Down.Tick
        lblObject9.Left += 20
        If lblObject9.Left > 659 Then
            tm9Down.Enabled = False
            tm9Up.Enabled = True
        End If
    End Sub

    Private Sub tm10Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm10Up.Tick
        lblObject10.Left -= 30
        If lblObject10.Left < 215 Then
            tm10Down.Enabled = True
            tm10Up.Enabled = False
        End If
    End Sub

    Private Sub tm10Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm10Down.Tick
        lblObject10.Left += 30
        If lblObject10.Left > 470 Then
            tm10Down.Enabled = False
            tm10Up.Enabled = True
        End If
    End Sub

    '---------------------------------------------------------------------------------------------------------------
    '|          Stage 2   (CheckPoint2)                                                                            |
    '---------------------------------------------------------------------------------------------------------------

    Private Sub tmTimer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmTimer2.Tick
        tmTimer2.Interval += 1
        If tmTimer2.Interval >= 100 And tmTimer.Interval <= 101 Then
            tm11Left.Enabled = True
            tm17Up.Enabled = True
        ElseIf tmTimer2.Interval >= 102 And tmTimer.Interval <= 103 Then
            tm12Left.Enabled = True
        ElseIf tmTimer2.Interval >= 104 And tmTimer.Interval <= 105 Then
            tm13Left.Enabled = True
            tm18Up.Enabled = True
        ElseIf tmTimer2.Interval >= 106 And tmTimer.Interval <= 107 Then
            tm14Left.Enabled = True
        ElseIf tmTimer2.Interval >= 108 And tmTimer.Interval <= 109 Then
            tm15Left.Enabled = True
            tm19Up.Enabled = True
        End If
    End Sub

    Private Sub tm11Left_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm11Left.Tick
        lbl2Object1.Left -= 10
        If lbl2Object1.Left <= 686 Then
            tm11Left.Enabled = False
            tm11Right.Enabled = True
        End If
    End Sub

    Private Sub tm11Right_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm11Right.Tick
        lbl2Object1.Left += 10
        If lbl2Object1.Left >= 720 Then
            tm11Left.Enabled = True
            tm11Right.Enabled = False
        End If
    End Sub

    Private Sub tm12Left_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm12Left.Tick
        lbl2Object2.Left -= 10
        If lbl2Object2.Left <= 686 Then
            tm12Left.Enabled = False
            tm12Right.Enabled = True
        End If
    End Sub

    Private Sub tm12Right_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm12Right.Tick
        lbl2Object2.Left += 10
        If lbl2Object2.Left >= 720 Then
            tm12Left.Enabled = True
            tm12Right.Enabled = False
        End If
    End Sub

    Private Sub tm13Left_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm13Left.Tick
        lbl2Object3.Left -= 10
        If lbl2Object3.Left <= 686 Then
            tm13Left.Enabled = False
            tm13Right.Enabled = True
        End If
    End Sub

    Private Sub tm13Right_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm13Right.Tick
        lbl2Object3.Left += 10
        If lbl2Object3.Left >= 720 Then
            tm13Left.Enabled = True
            tm13Right.Enabled = False
        End If
    End Sub

    Private Sub tm14Left_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm14Left.Tick
        lbl2Object4.Left -= 10
        If lbl2Object4.Left <= 686 Then
            tm14Left.Enabled = False
            tm14Right.Enabled = True
        End If
    End Sub

    Private Sub tm14Right_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm14Right.Tick
        lbl2Object4.Left += 10
        If lbl2Object4.Left >= 720 Then
            tm14Left.Enabled = True
            tm14Right.Enabled = False
        End If
    End Sub

    Private Sub tm15Left_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm15Left.Tick
        lblLogo2.Left -= 10
        If lblLogo2.Left <= 688 Then
            tm15Left.Enabled = False
            tm15Right.Enabled = True
        End If
    End Sub

    Private Sub tm15Right_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm15Right.Tick
        lblLogo2.Left += 10
        If lblLogo2.Left >= 720 Then
            tm15Left.Enabled = True
            tm15Right.Enabled = False
        End If
    End Sub

    Private Sub picActive3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picActive3.MouseEnter
        If IsPlaying = True Then
            tm16Left.Enabled = True
            picActive3Recover.Visible = True
            picActive3.Visible = False
        End If
    End Sub

    Private Sub tm16Left_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm16Left.Tick
        picMove.Left -= 8
        If picMove.Left <= 63 Then
            tm16Left.Enabled = False
            tm16Right.Enabled = True
        End If
    End Sub

    Private Sub tm16Right_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm16Right.Tick
        picMove.Left += 15
        If picMove.Left >= 390 Then
            tm16Left.Enabled = True
            tm16Right.Enabled = False
        End If
    End Sub

    Private Sub tm17Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm17Up.Tick
        lblMove1.Top -= 7
        lblMove11.Top -= 7
        If lblMove1.Top <= 414 Then
            tm17Up.Enabled = False
            tm17Down.Enabled = True
        End If
    End Sub

    Private Sub tm17Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm17Down.Tick
        lblMove1.Top += 7
        lblMove11.Top += 7
        If lblMove1.Top >= 466 Then
            tm17Up.Enabled = True
            tm17Down.Enabled = False
        End If
    End Sub

    Private Sub tm18Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm18Up.Tick
        lblMove2.Top -= 7
        lblMove22.Top -= 7
        If lblMove2.Top <= 414 Then
            tm18Up.Enabled = False
            tm18Down.Enabled = True
        End If
    End Sub

    Private Sub tm18Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm18Down.Tick
        lblMove2.Top += 7
        lblMove22.Top += 7
        If lblMove2.Top >= 466 Then
            tm18Up.Enabled = True
            tm18Down.Enabled = False
        End If
    End Sub

    Private Sub tm19Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm19Up.Tick
        lblMove3.Top -= 7
        lblMove33.Top -= 7
        If lblMove3.Top <= 414 Then
            tm19Up.Enabled = False
            tm19Down.Enabled = True
        End If
    End Sub

    Private Sub tm19Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm19Down.Tick
        lblMove3.Top += 7
        lblMove33.Top += 7
        If lblMove3.Top >= 466 Then
            tm19Up.Enabled = True
            tm19Down.Enabled = False
        End If
    End Sub

    'End moving the objects back and forth
    '#################################################################################################

    '##############################################################################################################
    '#              Finishing the game                                                                            #
    '##############################################################################################################

    Private Sub tmTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmTime.Tick
        tmTime.Interval += 1
    End Sub

    Private Sub picFinish_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFinish.MouseEnter
        If IsPlaying = True Then
            IsPlaying = False
            MessageBox.Show("You made it! Congratulations!")
            picEnded1.Visible = True
            picStart.Visible = False
            picCheck1.Visible = False
            picCheck2.Visible = False
            If picCheckPoint1.Visible = True Then
                picCheckPoint1.Visible = False
                picEnded2.Visible = True
            ElseIf picCheckPoint2.Visible = True Then
                picCheckPoint2.Visible = False
                picEnded3.Visible = True
            End If
        End If
    End Sub

    Private Sub rbOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOn.Click
        'Password for cheating mode
        'Debug use
        password = InputBox("Please enter the password")
        If password = "Marco is Awesome" Or password = "Marco is awesome" Or password = "marco is awesome" Then
            rbOn.Checked = True
        Else
            rbOff.Checked = True
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close() 'End the game if the player use this button
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        mouselabHelp.Show() 'Bring up the HELP form
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        picEnded1.Visible = False
        picEnded2.Visible = False
        picEnded3.Visible = False
        picStart.Visible = True
        picCheck1.Visible = True
        picCheck2.Visible = True
        picCheckPoint1.Visible = False
        picCheckPoint2.Visible = False
        tmTime.Interval = 1000
    End Sub
End Class
