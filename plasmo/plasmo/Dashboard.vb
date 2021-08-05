Imports System.Data
Imports System.Data.SqlClient
Public Class Dashboard
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim con As New SqlConnection("Server=DESKTOP-5GP20F1\SQLEXPRESS;Database=plasmo;Integrated Security=true")
        If con.State = 1 Then con.Close()
        Dim aplus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records where blood_group = A+,sold = N", con)
        con.Open()
        Dim Aplus As Int16 = aplus_cmd.ExecuteNonQuery
        con.Close()
        APlusCircle.Value = Aplus

        If con.State = 1 Then con.Close()
        Dim aminus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records where blood_group = A+,sold = N", con)
        con.Open()
        Dim AMinus As Int16 = aminus_cmd.ExecuteNonQuery
        con.Close()
        APlusCircle.Value = AMinus

        If con.State = 1 Then con.Close()
        Dim bplus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records where blood_group = A+,sold = N", con)
        con.Open()
        Dim BPlus As Int16 = bplus_cmd.ExecuteNonQuery
        con.Close()
        APlusCircle.Value = BPlus

        If con.State = 1 Then con.Close()
        Dim abplus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records where blood_group = A+,sold = N", con)
        con.Open()
        Dim ABPlus As Int16 = abplus_cmd.ExecuteNonQuery
        con.Close()
        APlusCircle.Value = ABPlus

        If con.State = 1 Then con.Close()
        Dim abminus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records where blood_group = A+,sold = N", con)
        con.Open()
        Dim ABMinus As Int16 = abminus_cmd.ExecuteNonQuery
        con.Close()
        APlusCircle.Value = ABMinus

        If con.State = 1 Then con.Close()
        Dim oplus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records where blood_group = A+,sold = N", con)
        con.Open()
        Dim OPlus As Int16 = oplus_cmd.ExecuteNonQuery
        con.Close()
        APlusCircle.Value = OPlus

        If con.State = 1 Then con.Close()
        Dim ominus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records where blood_group = A+,sold = N", con)
        con.Open()
        Dim OMinus As Int16 = ominus_cmd.ExecuteNonQuery
        con.Close()
        APlusCircle.Value = OMinus

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



    Private Sub Guna2CircleProgressBar4_ValueChanged(sender As Object, e As EventArgs) Handles APlusCircle.ValueChanged

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
        donor_history.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Guna2CircleProgressBar8_ValueChanged(sender As Object, e As EventArgs) Handles OPlusCircle.ValueChanged

    End Sub
End Class