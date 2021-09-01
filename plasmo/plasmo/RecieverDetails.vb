Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class RecieverDetails
    Private Sub DonorDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Server=DESKTOP-5GP20F1\SQLEXPRESS;Database=plasmo;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("Select * from reciever_records where reciever_id='" & reciever_id.Text & "'", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        While dr.Read
            full_name.Text = dr("first_name") + " " + dr("last_name")
            age.Text = dr("age")
            pnumber.Text = dr("phone_number")
            email.Text = dr("email")
            city.Text = dr("city")
            address.Text = dr("address")
            transaction_time.Text = dr("transaction_time")
            plasma_id.Text = dr("plasma_id")
            Select Case dr("blood_group")
                Case "AP"
                    bgroup.Text = "A+"

                Case "AM"
                    bgroup.Text = "A-"

                Case "BP"
                    bgroup.Text = "B+"

                Case "BM"
                    bgroup.Text = "B-"

                Case "ABP"
                    bgroup.Text = "AB+"

                Case "ABM"
                    bgroup.Text = "AB-"

                Case "OP"
                    bgroup.Text = "O+"
                Case "OM"
                    bgroup.Text = "O-"
            End Select

            Select Case dr("anti_body")
                Case "Y"
                    antibody.Text = "Yes"
                Case Else
                    antibody.Text = "No"
            End Select

            Select Case dr("sex")
                Case "M"
                    sex.Text = "Male"
                Case "F"
                    sex.Text = "Female"
                Case Else
                    sex.Text = "Other"
            End Select
        End While
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub DashboardBtnMenu_Click(sender As Object, e As EventArgs) Handles DashboardBtnMenu.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub DonorBtnMenu_Click(sender As Object, e As EventArgs) Handles DonorBtnMenu.Click
        donorForm.Show()
        Me.Close()
    End Sub

    Private Sub RecieverBtnMenu_Click(sender As Object, e As EventArgs) Handles RecieverBtnMenu.Click
        Reciever_form.Show()
        Me.Close()
    End Sub
    Private Sub QueueBtnMenu_Click(sender As Object, e As EventArgs) Handles QueueBtnMenu.Click
        queue.Show()
    End Sub
    Private Sub LogoutBtnMenu_Click(sender As Object, e As EventArgs) Handles LogoutBtnMenu.Click
        login.Show()
        Me.Close()
    End Sub
    Private Sub HistoryBtnMenu_Click(sender As Object, e As EventArgs) Handles HistoryBtnMenu.Click
        donor_history.Show()
        Me.Close()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        reciever_history.Show()
        Me.Close()
    End Sub

    Private Sub plasma_id_Click(sender As Object, e As EventArgs) Handles plasma_id.Click
        DonorDetails.plasma_id.Text = plasma_id.Text
        DonorDetails.Show()
        Me.Close()
    End Sub
End Class