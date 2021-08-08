Public Class reciever_history
    Private Sub reciever_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel2_Click_1(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub Guna2PictureBox3_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        donor_history.Show()
        Me.Hide()
    End Sub
End Class