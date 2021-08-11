Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class CategoryDetail
    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles type.Click

    End Sub

    Private Sub CategoryDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bloodGroup = type.Text

        Select Case bloodGroup
            Case "A+"
                bloodGroup = "AP"
            Case "A-"
                bloodGroup = "AM"
            Case "B+"
                bloodGroup = "BP"
            Case "B-"
                bloodGroup = "BM"
            Case "AB+"
                bloodGroup = "ABP"
            Case "AB-"
                bloodGroup = "ABM"
            Case "O+"
                bloodGroup = "OP"
            Case "O-"
                bloodGroup = "OM"
        End Select

        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        con.Open()
        Dim cmd As New SqlCommand("select plasma_id, anti_body, age, price from donor_records where sold='" & "N" & "' and blood_group='" & bloodGroup & "'", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        Guna2DataGridView1.Rows.Clear()

        While dr.Read
            Dim anti_body As String
            If dr("anti_body") = "Y" Then
                anti_body = "YES"

            Else
                anti_body = "NO"
            End If
            Guna2DataGridView1.Rows.Add(dr("plasma_id"), anti_body, dr("age"), dr("price"))
        End While
        con.Close()

    End Sub
End Class