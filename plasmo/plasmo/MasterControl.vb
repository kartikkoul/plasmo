Public Class MasterControl
    Private Sub MasterControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchForms(Dashboard)
    End Sub

    Sub switchForms(ByVal panel As Form)
        Guna2Panel1.Controls.Clear()
        panel.TopLevel = False
        Guna2Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub DashboardBtnMenu_Click(sender As Object, e As EventArgs) Handles DashboardBtnMenu.Click
        switchForms(Dashboard)
    End Sub

    Private Sub DonorBtnMenu_Click(sender As Object, e As EventArgs)
        switchForms(donorForm)
    End Sub

    Private Sub RecieverBtnMenu_Click(sender As Object, e As EventArgs)
        switchForms(Reciever_form)
    End Sub
    Private Sub QueueBtnMenu_Click(sender As Object, e As EventArgs)
        switchForms(queue)
    End Sub
    Private Sub LogoutBtnMenu_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Hide()
    End Sub
    Private Sub HistoryBtnMenu_Click(sender As Object, e As EventArgs)
        switchForms(donor_history)
    End Sub
End Class