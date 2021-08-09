Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class reciever_history
    Private Sub reciever_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        con.Open()
        Dim cmd As New SqlCommand("select RECIEVER_ID, first_name, last_name, age, blood_group, plasma_id, transaction_time from reciever_records where recieved='" & "Y" & "'", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        Guna2DataGridView1.Rows.Clear()

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
            Guna2DataGridView1.Rows.Add(dr("reciever_id"), name, dr("age"), blood_group, dr("plasma_id"), dr("transaction_time"))
        End While
        con.Close()
    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs)

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

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel2_Click_1(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub Guna2PictureBox3_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        donor_history.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
End Class