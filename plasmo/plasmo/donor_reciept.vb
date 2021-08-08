Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand


Public Class donor_reciept
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        con.Open()
        Dim cmd As New SqlCommand("select first_name, last_name, phone_number, age, address, blood_group, sex, email, transaction_time from donor_records where plasma_id='" & plasmaIDLabel.Text & "'", con)
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
            Namelabel.Text = name
            ageLabel.Text = dr("age")
            phNumberLabel.Text = dr("phone_number")
            addressLabel.Text = dr("address")
            sexLabel.Text = dr("sex")
            emailLabel.Text = dr("email")
            bloodGroupLabel.Text = blood_group
            dateLabel.Text = dr("transaction_time")
        End While
        con.Close()
    End Sub
End Class