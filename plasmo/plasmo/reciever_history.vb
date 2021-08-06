Public Class reciever_history
    Private Sub reciever_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ToggleSwitch1.Checked = True
        donor_history.Hide()


    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        donor_history.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub
End Class