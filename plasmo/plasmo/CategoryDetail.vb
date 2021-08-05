Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class CategoryDetail

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click

    End Sub

    Private Sub CategoryDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim li As Integer
        Dim con As New SqlConnection("Server=WHITEDEVIL\SQLEXPRESS;Database=plasmo;Integrated Security=true")
        con.Open()
        Dim cmd As New SqlCommand("select * from donor_records", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        ListView1.Items.Clear()
        li = 0
        While dr.Read
            Dim reciever_name As String = dr("first_name") + " " + dr("last_name")
            ListView1.Items.Add(li + 1)
            ListView1.Items(li).SubItems.Add(dr("plasma_id"))
            ListView1.Items(li).SubItems.Add(reciever_name)
            ListView1.Items(li).SubItems.Add(dr("age"))
            ListView1.Items(li).SubItems.Add(dr("phone_number"))
            li = li + 1
        End While
        con.Close()



    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class