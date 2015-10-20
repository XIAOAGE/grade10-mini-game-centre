Public Class mouselabHelp

    Dim cur As Icon

    Private Sub picExample_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picExample.MouseEnter
        'Give an example of the player what the cursor will look like when it started
        cur = (My.Resources.Mouse)
        Me.Cursor = New Cursor(cur.Handle)
    End Sub

    Private Sub picExample_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picExample.MouseLeave
        'Change the cursor back to normal when they leave the picture box
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'End this form to bring the player back to the game screen
        mouseLabyrinth.Show()
        Me.Close()
    End Sub
End Class