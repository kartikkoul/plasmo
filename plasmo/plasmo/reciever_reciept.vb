Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class reciever_reciept
    Private Sub reciever_reciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reciever_id = recieverIDLabel.Text
        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        con.Open()
        Dim cmd As New SqlCommand("select first_name, last_name, phone_number, age, address, blood_group, sex, email, transaction_time,anti_body, price from reciever_records where reciever_id='" & recieverIDLabel.Text & "'", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader


        While dr.Read

            Dim blood_group As String = dr("blood_group")

            Select Case dr("blood_group")
                Case "AP"
                    blood_group = "A+"

                Case "AM"
                    blood_group = "A-"

                Case "BP"
                    blood_group = "B+"

                Case "BM"
                    blood_group = "B-"

                Case "ABP"
                    blood_group = "AB+"

                Case "ABM"
                    blood_group = "AB-"

                Case "OP"
                    blood_group = "O+"
                Case "OM"
                    blood_group = "O-"
            End Select




            Namelabel.Text = "(" + dr("first_name") + " " + dr("last_name") + ")"
            ageLabel.Text = dr("age")
            phNumberLabel.Text = dr("phone_number")
            addressLabel.Text = dr("address")
            sexLabel.Text = dr("sex")
            emailLabel.Text = dr("email")
            bloodGroupLabel.Text = blood_group
            dateLabel.Text = dr("transaction_time")
            antiBodyLabel.Text = dr("anti_body")
            costLabel.Text = "₹ " + dr("price").ToString()
        End While
        con.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub DashboardBtnMenu_Click(sender As Object, e As EventArgs) Handles DashboardBtnMenu.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
    Private Sub DonorBtnMenu_Click(sender As Object, e As EventArgs) Handles DonorBtnMenu.Click
        donorForm.Show()
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

    Private Sub bloodGroupLabel_Click(sender As Object, e As EventArgs) Handles bloodGroupLabel.Click

    End Sub

    Private Sub emailLabel_Click(sender As Object, e As EventArgs) Handles emailLabel.Click

    End Sub
End Class