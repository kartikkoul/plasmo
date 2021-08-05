Public Class Reciever_form
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Reciever_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Hide()
    End Sub
    Private Sub DashboardBtnMenu_Click(sender As Object, e As EventArgs) Handles DashboardBtnMenu.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
    Private Sub DonorBtnMenu_Click(sender As Object, e As EventArgs) Handles DonorBtnMenu.Click
        Donor_form.Show()
        Me.Hide()
    End Sub

    Private Sub RecieverBtnMenu_Click(sender As Object, e As EventArgs) Handles RecieverBtnMenu.Click

    End Sub
    Private Sub QueueBtnMenu_Click(sender As Object, e As EventArgs) Handles QueueBtnMenu.Click

    End Sub
    Private Sub LogoutBtnMenu_Click(sender As Object, e As EventArgs) Handles LogoutBtnMenu.Click
        login.Show()
        Me.Hide()
    End Sub
    Private Sub HistoryBtnMenu_Click(sender As Object, e As EventArgs) Handles HistoryBtnMenu.Click
        Details.Show()
        Me.Hide()
    End Sub
End Class