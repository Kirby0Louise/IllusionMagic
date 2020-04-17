Public Class frmMain

    Private unsaved As Boolean = False

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If unsaved Then
            'Prompt to confirm exit without saving
            Dim result1 As DialogResult = MessageBox.Show("You have unsaved data.  Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo)
            If result1 = DialogResult.Yes Then
                Application.Exit()
            End If
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub
End Class
