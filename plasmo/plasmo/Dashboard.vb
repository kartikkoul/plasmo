Imports System.Data
Imports System.Data.SqlClient
Public Class Dashboard
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Aplus As Integer = 0

        Dim con As New SqlConnection("Server=WHITEDEVIL\SQLEXPRESS;Database=plasmo;Integrated Security=true")
        If con.State = 1 Then con.Close()
        Dim dashcmd As New SqlCommand("select count(plasma_id) from donor_records where blood_group = A+,sold = N")
        con.Open()
        Dim dr As SqlDataReader = dashcmd.ExecuteReader
        Dim count As Integer = dr("plasma_id")
        MsgBox(count)
        con.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles DashboardBtnMenu.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles RecieverBtnMenu.Click
        Reciever_form.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles DonorBtnMenu.Click
        Donor_form.Show()
        Me.Hide()

    End Sub



    Private Sub Guna2CircleProgressBar4_ValueChanged(sender As Object, e As EventArgs) Handles Guna2CircleProgressBar4.ValueChanged

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles QueueBtnMenu.Click

    End Sub


    Private Sub DashboardBtnMenu_Click(sender As Object, e As EventArgs) Handles DashboardBtnMenu.Click

    End Sub
    Private Sub DonorBtnMenu_Click(sender As Object, e As EventArgs) Handles DonorBtnMenu.Click
        Donor_form.Show()
        Me.Hide()
    End Sub

    Private Sub RecieverBtnMenu_Click(sender As Object, e As EventArgs) Handles RecieverBtnMenu.Click
        Reciever_form.Show()
        Me.Hide()
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

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class