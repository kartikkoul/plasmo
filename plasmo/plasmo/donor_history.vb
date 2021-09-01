'''''''''''''''''''''''''''''''''''DONOR HISTORY''''''''''''''''''''''''''

Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class donor_history

    Private Sub DonorHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FilterData("")
        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet

        '------------TOTAL NUMBER OF DONORS AND RECIEVERS--------------'
        If con.State = 1 Then con.Close()
        Dim countDonorsCmd As New SqlCommand("select plasma_id from donor_records", con)
        con.Open()
        adapter.SelectCommand = countDonorsCmd
        adapter.Fill(ds, "donor_records")
        Dim countDonors As Integer = ds.Tables(0).Rows.Count
        adapter.Dispose()
        ds.Dispose()
        con.Close()
        totalDonors.Text = countDonors

        Dim countRecieversCmd As New SqlCommand("select * from reciever_records where recieved='" & "Y" & "'", con)
        Dim ad As New SqlDataAdapter
        Dim ds2 As New DataSet
        con.Open()
        ad.SelectCommand = countRecieversCmd
        ad.Fill(ds2, "reciever_records")
        Dim countRecievers As Integer = ds2.Tables(0).Rows.Count
        ad.Dispose()
        ds2.Dispose()
        con.Close()
        totalRecievers.Text = countRecievers
        '--------------------------------------------------------------'


        con.Open()
        Dim cmd As New SqlCommand("select plasma_id, first_name, last_name, age, blood_group, anti_body, transaction_time from donor_records", con)
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
            '--------LOADS DATA INTO INDIVIDUAL ROW OF THE TABLE---------'
            Guna2DataGridView1.Rows.Add(dr("plasma_id"), name, dr("age"), blood_group, dr("anti_body"), dr("transaction_time"))
            '------------------------------------------------------------'

        End While
        con.Close()


    End Sub

    'Public Sub FilterData(valueToSearch As String)
    '    'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
    '    Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
    '    Dim searchQuery As String = "SELECT * From donor_records WHERE CONCAT(plasma_id, first_name, last_name, age) like '%" & valueToSearch & "%'"

    '    Dim command As New SqlCommand(searchQuery, con)
    '    Dim adapter As New SqlDataAdapter(command)
    '    Dim table As New DataTable()

    '    'adapter.Fill(table)

    '    Guna2DataGridView1.DataSource = adapter.Fill(table)

    'End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub DashboardBtnMenu_Click(sender As Object, e As EventArgs) Handles dashboardBtnMenu.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub DonorBtnMenu_Click(sender As Object, e As EventArgs) Handles donorBtnMenu.Click
        donorForm.Show()
        Me.Close()
    End Sub

    Private Sub RecieverBtnMenu_Click(sender As Object, e As EventArgs) Handles recieverBtnMenu.Click
        Reciever_form.Show()
        Me.Close()
    End Sub
    Private Sub QueueBtnMenu_Click(sender As Object, e As EventArgs) Handles queueBtnMenu.Click
        queue.Show()
        Me.Close()
    End Sub
    Private Sub LogoutBtnMenu_Click(sender As Object, e As EventArgs) Handles logoutBtnMenu.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        reciever_history.Show()
        Me.Close()
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            DonorDetails.plasma_id.Text = row.Cells(0).Value.ToString
            DonorDetails.Show()
            Me.Close()
        End If
    End Sub

    '------------------------------------FOR HOVER EFFECTS OVER ROWS-------------------------------'
    Private Sub Guna2DataGridView1_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellMouseEnter
        If e.RowIndex > -1 Then
            Dim row = Guna2DataGridView1.Rows(e.RowIndex)
            row.DefaultCellStyle.BackColor = Color.White
        End If
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Guna2DataGridView1_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellMouseLeave
        If e.RowIndex > -1 Then
            Dim row = Guna2DataGridView1.Rows(e.RowIndex)
            row.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        End If
        Me.Cursor = Cursors.Default
    End Sub
    '----------------------------------------------------------------------------------------------'


    Private Sub SearchBtn_Click(sender As Object, e As EventArgs)
        Dim name As String
        Dim id As String
        If searchBox.Text.Trim.Length = 0 Then
            name = searchBox.Text
            id = searchBox.Text.Trim
        Else
            Exit Sub
        End If
        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        Dim dr As SqlDataReader
        Dim cmd As New SqlCommand("Select * from donor_records where plasma_id = '" & id & "' or first_name='" & name & "'", con)
        con.Open()
        dr = cmd.ExecuteReader
        If dr.HasRows Then

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



                Dim name2 As String = dr("first_name") + " " + dr("last_name")
                Guna2DataGridView1.Rows.Add(dr("plasma_id"), name2, dr("age"), blood_group, dr("anti_body"), dr("transaction_time"))
            End While
            con.Close()
        Else
            con.Close()
            searchBox.BorderColor = Color.Red
            searchBox.HoverState.BorderColor = Color.Red
            searchBox.FocusedState.BorderColor = Color.Red
        End If
    End Sub


    '-----------------------IN ORDER TO ACHIEVE SEARCHING RECORDS----------------'
    Public Sub search(id As String, firstName As String, lastName As String, value As String)
        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        If con.State = 1 Then con.Close()
        Dim cmd As New SqlCommand("SELECT * FROM donor_records WHERE plasma_id LIKE '%" & id & "%' OR first_name LIKE '%" & firstName & "%' OR last_name LIKE '%" & lastName & "%' OR CONCAT(plasma_id, first_name, last_name) LIKE '%" & value & "%'", con)
        con.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            searchBox.BorderColor = Color.Silver
            searchBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
            searchBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
            'adapter.SelectCommand = cmd
            'adapter.Fill(ds, "donor_records")
            'Dim countDonors As Integer = ds.Tables(0).Rows.Count
            'adapter.Dispose()
            'ds.Dispose()
            con.Close()
        Else
            If searchBox.Text.Trim.Length = 0 Then
                searchBox.BorderColor = Color.Silver
                searchBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
                searchBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
            Else
                searchBox.BorderColor = Color.Red
                searchBox.HoverState.BorderColor = Color.Red
                searchBox.FocusedState.BorderColor = Color.Red
            End If
        End If
    End Sub
    '----------------------------------------------------------------------------'


    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        Dim id As String = searchBox.Text.Trim
        Dim first_name As String = searchBox.Text.Trim
        Dim last_name As String = searchBox.Text.Trim
        Dim value As String = searchBox.Text
        search(id, first_name, last_name, value)
    End Sub
End Class