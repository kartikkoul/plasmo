Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand


Public Class donor_reciept
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        con.Open()
        Dim cmd As New SqlCommand("select * from donor_records where plasma_id='" & plasmaIDLabel.Text & "'", con)
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



            Dim name As String = dr("first_name") + " " + dr("last_name")
            plasmaIDLabel.Text = "(" + plasmaIDLabel.Text + ")"
            Namelabel.Text = name
            ageLabel.Text = dr("age")
            phNumberLabel.Text = dr("phone_number")
            addressLabel.Text = dr("address")
            sexLabel.Text = dr("sex")
            emailLabel.Text = dr("email")
            bloodGroupLabel.Text = blood_group
            dateLabel.Text = dr("transaction_time")
            Exit While
        End While
        con.Close()
    End Sub

    Private Sub Namelabel_Click(sender As Object, e As EventArgs) Handles Namelabel.Click

    End Sub



    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
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
        Me.Close()
    End Sub
    Private Sub LogoutBtnMenu_Click(sender As Object, e As EventArgs) Handles LogoutBtnMenu.Click
        login.Show()
        Me.Close()
    End Sub
    Private Sub HistoryBtnMenu_Click(sender As Object, e As EventArgs) Handles HistoryBtnMenu.Click
        donor_history.Show()
        Me.Close()
    End Sub

    Private Sub Guna2HtmlLabel7_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel7.Click

    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel5.Click

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Guna2HtmlLabel15_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel15.Click

    End Sub

    Private Sub Guna2HtmlLabel11_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel11.Click

    End Sub

    Private Sub Guna2HtmlLabel9_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel9.Click

    End Sub

    Private Sub Guna2HtmlLabel13_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel13.Click

    End Sub

    Private Sub Guna2HtmlLabel17_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel17.Click

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel4.Click

    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub
End Class