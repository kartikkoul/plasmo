﻿Imports System.Data
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
        Guna2ToggleSwitch1.Checked = False
        Dim li As Integer
        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        con.Open()
        Dim cmd As New SqlCommand("select plasma_id, first_name, second_name, age, blood_group, anti_body, transaction_time from donor_records", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        ListView1.Items.Clear()
        li = 0
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



            Dim name As String = dr("first_name") + " " + dr("second_name")
            ListView1.Items.Add(dr("plasma_id"))
            ListView1.Columns.Add(name)
            ListView1.Columns.Add(dr("age"))
            ListView1.Columns.Add(blood_group)
            ListView1.Columns.Add(dr("anti_body"))
            ListView1.Columns.Add(dr("transaction_time"))
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

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged_1(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged

        Me.Hide()
        reciever_history.Show()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub
End Class