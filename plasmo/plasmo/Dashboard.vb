Imports System.Data
Imports System.Data.SqlClient
Public Class Dashboard
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim con As New SqlConnection("Server=DESKTOP-5GP20F1\SQLEXPRESS;Database=plasmo;Integrated Security=true")
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet


        If con.State = 1 Then con.Close()

        Dim aplus_cmd As New SqlCommand("select * as availableCount from donor_records  where blood_group=A+,sold=N", con)
        con.Open()
        adapter.SelectCommand = aplus_cmd
        adapter.Fill(ds, "donor_records")
        Dim Aplus As Integer = ds.Tables(0).Rows.Count
        adapter.Dispose()
        ds.Dispose()
        con.Close()
        APlusCircle.Value = Aplus

        If con.State = 1 Then con.Close()
        Dim aminus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records where blood_group=A-,sold=N", con)
        con.Open()
        adapter.SelectCommand = aplus_cmd
        adapter.Fill(ds, "donor_records")
        Dim AMinus As Integer = ds.Tables(0).Rows.Count
        adapter.Dispose()
        ds.Dispose()
        con.Close()
        AMinusCircle.Value = AMinus

        If con.State = 1 Then con.Close()
        Dim bplus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records  where blood_group=B+,sold=N", con)
        con.Open()
        adapter.SelectCommand = aplus_cmd
        adapter.Fill(ds, "donor_records")
        Dim BPlus As Integer = ds.Tables(0).Rows.Count
        adapter.Dispose()
        ds.Dispose()
        con.Close()
        BPlusCircle.Value = BPlus

        If con.State = 1 Then con.Close()
        Dim bminus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records  where blood_group=B-,sold=N", con)
        con.Open()
        adapter.SelectCommand = aplus_cmd
        adapter.Fill(ds, "donor_records")
        Dim BMinus As Integer = ds.Tables(0).Rows.Count
        adapter.Dispose()
        ds.Dispose()
        con.Close()
        BMinusCircle.Value = BMinus

        If con.State = 1 Then con.Close()
        Dim abplus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records  where blood_group=AB+,sold=N", con)
        con.Open()
        adapter.SelectCommand = aplus_cmd
        adapter.Fill(ds, "donor_records")
        Dim ABPlus As Integer = ds.Tables(0).Rows.Count
        adapter.Dispose()
        ds.Dispose()
        con.Close()
        ABPlusCircle.Value = ABPlus

        If con.State = 1 Then con.Close()
        Dim abminus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records  where blood_group=AB-,sold=N", con)
        con.Open()
        adapter.SelectCommand = aplus_cmd
        adapter.Fill(ds, "donor_records")
        Dim ABMinus As Integer = ds.Tables(0).Rows.Count
        adapter.Dispose()
        ds.Dispose()
        con.Close()
        ABMinusCircle.Value = ABMinus

        If con.State = 1 Then con.Close()
        Dim oplus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records  where blood_group=O+,sold=N", con)
        con.Open()
        adapter.SelectCommand = aplus_cmd
        adapter.Fill(ds, "donor_records")
        Dim OPlus As Integer = ds.Tables(0).Rows.Count
        adapter.Dispose()
        ds.Dispose()
        con.Close()
        OPlusCircle.Value = OPlus

        If con.State = 1 Then con.Close()
        Dim ominus_cmd As New SqlCommand("select count(plasma_id) as availableCount from donor_records  where blood_group=O-,sold=N", con)
        con.Open()
        adapter.SelectCommand = aplus_cmd
        adapter.Fill(ds, "donor_records")
        Dim OMinus As Integer = ds.Tables(0).Rows.Count
        adapter.Dispose()
        ds.Dispose()
        con.Close()
        OMinusCircle.Value = OMinus

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