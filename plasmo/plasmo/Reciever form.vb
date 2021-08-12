Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class Reciever_form
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub


    Public Function Truncate(value As String, length As Integer) As String
        If length > value.Length Then
            Return value
        Else
            Return value.Substring(0, length)
        End If
    End Function

    Public Function GenerateID() As String
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(999, 10000)
    End Function

    Public Function GenerateRecieverID() As String
        Dim ID = "R080" + GenerateID()

        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        con.Open()
        Dim cmd As New SqlCommand("select reciever_id from reciever_records", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader


        While dr.Read
            If ID = dr("reciever_id") Then
                Return GenerateRecieverID()
            End If
        End While
        Return ID
    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim gen As Char = Truncate(gender.SelectedItem, 1)
        Dim reciever_id As String = GenerateRecieverID()
        Dim demands = demand.SelectedItem
        Dim wantAntibody As String = ""

        Select Case demands
            Case "Doesn't Matter"
                demands = vbNull

            Case "Yes"
                demands = 1
                wantAntibody = "Y"

            Case "No"
                demands = 0
                wantAntibody = "N"
        End Select


        Dim selected_blood_group As String = bgroup.SelectedItem
        Dim blood_group As String = "AP"

        Select Case selected_blood_group
            Case "A+"
                blood_group = "AP"

            Case "A-"
                blood_group = "AM"

            Case "B+"
                blood_group = "BP"

            Case "B-"
                blood_group = "BM"

            Case "AB+"
                blood_group = "ABP"

            Case "AB-"
                blood_group = "ABM"

            Case "O+"
                blood_group = "OP"
            Case "O-"
                blood_group = "OM"
        End Select

        Dim con As New SqlConnection("Server=DESKTOP-5GP20F1\SQLEXPRESS;Database=plasmo;Integrated Security=True")
        Dim insertQuery As New SqlCommand("insert into reciever_records(reciever_id,first_name,last_name,age,phone_number,email,city, address,blood_group,sex,recieved, demand) values('" & reciever_id & "','" & fname.Text & "','" & lname.Text & "','" & age.Text & "','" & pnumber.Text & "','" & mail.Text & "','" & city.Text & "','" & address.Text & "','" & blood_group & "','" & gen & "','" & "N" & "','" & demands & "')", con)
        con.Open()
        insertQuery.ExecuteNonQuery()
        Dim cmd As New SqlCommand()

        If wantAntibody.Trim.Length = 0 Then
            cmd = New SqlCommand("select plasma_id, price, anti_body from donor_records where blood_group='" & blood_group & "' AND sold='" & "N" & "'", con)

        Else
            cmd = New SqlCommand("select plasma_id, price, anti_body from donor_records where blood_group='" & blood_group & "', anti_body='" & wantAntibody & "' AND sold='" & "N" & "'", con)
        End If


        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        Dim plasmaID As String = 0
        Dim price As Integer = 0
        Dim antiBody As String = ""
        If dr.HasRows Then
            While dr.Read
                plasmaID = dr("plasma_id")
                price = dr("price")
                antiBody=dr("anti_body")
                Exit While
            End While
            Dim time As Date = Date.UtcNow

            If con.State = 1 Then
                con.Close()
            End If
            Dim updateRecieverQuery As New SqlCommand("UPDATE reciever_records SET plasma_id = '" & plasmaID & "' ,price = '" & price & "',anti_body='" & antiBody & "', recieved='" & "Y" & "', transaction_time = '" & time & "' WHERE reciever_id = '" & reciever_id & "'", con)
            Dim updateDonorQuery As New SqlCommand("UPDATE donor_records SET sold='" & "Y" & "' WHERE plasma_id = '" & plasmaID & "'", con)
            con.Open()
            updateRecieverQuery.ExecuteNonQuery()
            updateDonorQuery.ExecuteNonQuery()
            con.Close()
            reciever_reciept.recieverIDLabel.Text = "(" + reciever_id + ")"
            reciever_reciept.Show()
            Me.Hide()
        Else
            con.Close()
            PlasmaNotAvailable.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

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

    End Sub
    Private Sub QueueBtnMenu_Click(sender As Object, e As EventArgs) Handles QueueBtnMenu.Click
        queue.Show()
        Me.Hide()
    End Sub
    Private Sub LogoutBtnMenu_Click(sender As Object, e As EventArgs) Handles LogoutBtnMenu.Click
        login.Show()
        Me.Hide()
    End Sub
    Private Sub HistoryBtnMenu_Click(sender As Object, e As EventArgs) Handles HistoryBtnMenu.Click
        donor_history.Show()
        Me.Hide()
    End Sub

    Private Sub Reciever_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class