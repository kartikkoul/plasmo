Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class donor_history

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click

    End Sub

    Private Sub DonorHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim li As Integer
        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        con.Open()
        Dim cmd As New SqlCommand("select plasma_id, first_name, second_name, age, blood_group, anti_body, transaction_time from donor_records", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        ListView1.Items.Clear()
        li = 0
        While dr.Read
            Dim name As String = dr("first_name") + " " + dr("second_name")
            ListView1.Items.Add(dr("plasma_id"))
            ListView1.Items(li).SubItems.Add(name)
            ListView1.Items(li).SubItems.Add(dr("age"))
            ListView1.Items(li).SubItems.Add(dr("blood_group"))
            ListView1.Items(li).SubItems.Add(dr("anti_body"))
            ListView1.Items(li).SubItems.Add(dr("transaction_time"))
            li = li + 1
        End While
        con.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub
End Class