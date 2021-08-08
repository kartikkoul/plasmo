Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class Reciever_form
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim gen As Char = Truncate(gender.SelectedItem, 1)
        Dim reciever_id As String = GenerateRecieverID()

        Dim selected_blood_group As String = bloodGroup.SelectedItem
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
        Dim insertQuery As New SqlCommand("insert into reciever_records(reciever_id,first_name,last_name,age,phone_number,email,city,address,blood_group,sex,recieved) values('" & reciever_id & "','" & fName.Text & "','" & lName.Text & "','" & age.Text & "','" & phNumber.Text & "','" & email.Text & "','" & city.Text & "','" & address.Text & "','" & blood_group & "','" & gen & "','" & "N" & "')", con)
        con.Open()
        insertQuery.ExecuteNonQuery()
        Dim cmd As New SqlCommand("select plasma_id, price from donor_records where blood_group='" & blood_group & "', sold='N'", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        con.Close()

        If dr.HasRows Then
            Dim plasmaID = dr(0)("plasma_id")
            Dim price = dr(0)("price")
            Dim time As Date = Date.UtcNow
            Dim updateRecieverQuery As New SqlCommand("UPDATE reciever_records SET plasma_id = '" & plasmaID & "' ,price = '" & price & "', transaction_time = '" & time & "' WHERE reciever_id = '" & reciever_id & "'", con)
            Dim updateDonorQuery As New SqlCommand("UPDATE donor_records SET sold=Y WHERE plasma_id = '" & plasmaID & "'", con)
            If con.State = 1 Then
                conn.Close()
            End If
            con.Open()
            updateRecieverQuery.ExecuteNonQuery()
            updateDonorQuery.ExecuteNonQuery()
            con.Close()
            reciever_reciept.Show()
            Me.Hide()
        Else
            PlasmaNotAvailable.Show()
            Me.Show()
        End If
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles fName.TextChanged

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Hide()
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