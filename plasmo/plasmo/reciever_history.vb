Public Class reciever_history
    Private Sub reciever_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ToggleSwitch1.Checked = True
        donor_history.Show()
        Me.Hide()
    End Sub


End Class