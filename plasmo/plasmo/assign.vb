Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class assign
    Private Sub assign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Server=DESKTOP-5GP20F1\SQLEXPRESS;Database=plasmo;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("Select * from reciever_records where reciever_id='" & reciever_id.Text & "'")
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            fname.Text = dr("first_name")
            lname.Text = dr("last_name")
            age.Text = dr("age")
            pnumber.Text = dr("phone_number")
            email.Text = dr("email")
            city.Text = dr("city")
            address.Text = dr("address")
            sex.Text = dr("sex")
            Select Case dr("demand")
                Case "1"
                    demand.SelectedIndex = 2
                Case "0"
                    demand.SelectedIndex = 1
                Case Else
                    demand.SelectedIndex = 0
            End Select


            Select Case dr("blood_group")
                Case "AP"
                    bgroup.Text = "A+"

                Case "AM"
                    bgroup.Text = "A-"

                Case "BP"
                    bgroup.Text = "B+"

                Case "BM"
                    bgroup.Text = "B-"

                Case "ABP"
                    bgroup.Text = "AB+"

                Case "ABM"
                    bgroup.Text = "AB-"

                Case "OP"
                    bgroup.Text = "O+"
                Case "OM"
                    bgroup.Text = "O-"
            End Select
        Else
                    MsgBox("Something went wrong :(")
        End If


    End Sub

    Private Sub lname_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub age_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnumber_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub mail_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bgroup_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub city_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub address_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub fname_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub gender_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ageErrorText_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub phNumberErrorText_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub emailErrortext_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub addressErrorText_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cityErrorText_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub fNameErrorText_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lNameErrorText_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lNameErrorText_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
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


        Dim blood_group As String = ""
        Select Case bgroup.Text
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
        con.Open()
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
                antiBody = dr("anti_body")
                Exit While
            End While
            Dim time As Date = Date.UtcNow

            If con.State = 1 Then
                con.Close()
            End If
            Dim updateRecieverQuery As New SqlCommand("UPDATE reciever_records SET plasma_id = '" & plasmaID & "' ,price = '" & price & "',anti_body='" & antiBody & "', recieved='" & "Y" & "', transaction_time = '" & time & "' WHERE reciever_id = '" & reciever_id.Text & "'", con)
            Dim updateDonorQuery As New SqlCommand("UPDATE donor_records SET sold='" & "Y" & "' WHERE plasma_id = '" & plasmaID & "'", con)
            con.Open()
            updateRecieverQuery.ExecuteNonQuery()
            updateDonorQuery.ExecuteNonQuery()
            con.Close()
            reciever_reciept.recieverIDLabel.Text = "(" + reciever_id.Text + ")"
            reciever_reciept.Show()
            Me.Hide()
        Else
            con.Close()
            PlasmaNotAvailable.Show()
            Me.Hide()
    End Sub
End Class