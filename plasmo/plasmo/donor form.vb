Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Imports System.Text.RegularExpressions

Public Class donorForm
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs)
        Reciever_form.Show()
        Me.Close()
    End Sub

    Private Sub Donor_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub DashboardBtnMenu_Click(sender As Object, e As EventArgs) Handles DashboardBtnMenu.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub DonorBtnMenu_Click(sender As Object, e As EventArgs) Handles DonorBtnMenu.Click

    End Sub

    Private Sub RecieverBtnMenu_Click(sender As Object, e As EventArgs) Handles RecieverBtnMenu.Click
        Reciever_form.Show()
        Me.Close()
    End Sub
    Private Sub QueueBtnMenu_Click(sender As Object, e As EventArgs) Handles QueueBtnMenu.Click
        queue.Show()
        Me.Close()
    End Sub
    Private Sub LogoutBtnMenu_Click(sender As Object, e As EventArgs) Handles LogoutBtnMenu.Click
        login.Show()
        Me.Close()
    End Sub
    Private Sub HistoryBtnMenu_Click(sender As Object, e As EventArgs) Handles HistoryBtnMenu.Click
        donor_history.Show()
        Me.Close()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Public Function Truncate(value As String, length As Integer) As String
        If length > value.Length Then
            Return value
        Else
            Return value.Substring(0, length)
        End If
    End Function

    Private Sub fname_TextChanged(sender As Object, e As EventArgs) Handles fname.TextChanged

    End Sub

    Private Sub gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gender.SelectedIndexChanged

    End Sub

    Public Function GenerateID() As String
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(999, 10000)
    End Function

    Public Function GenerateDonorID() As String
        Dim ID
        If antibody.SelectedItem = "Y" Then
            ID = "E080" + GenerateID()
        Else
            ID = "E060" + GenerateID()
        End If


        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        con.Open()
        Dim cmd As New SqlCommand("select plasma_id from donor_records", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader


        While dr.Read
            If ID = dr("plasma_id") Then
                Return GenerateDonorID()
            End If
        End While
        Return ID
    End Function


    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If fname.Text = "" Then
            MsgBox("Enter First Name")
            fname.Focus()
        ElseIf lname.Text = "" Then
            MsgBox("Enter Last Name")
            lname.Focus()
        ElseIf age.Text = "" Then
            MsgBox("Enter Age")
            age.Focus()
        ElseIf age.Text.Length <> 2 Then
            MsgBox("INVALID!!! Please enter valid age")
            age.Focus()
        ElseIf pnumber.Text = "" Then
            MsgBox("Enter a valid Contact No.")
            pnumber.Focus()
        ElseIf pnumber.Text.Length <> 10 Then
            MsgBox("INVALID CONTACT NO.")
            pnumber.Focus()
        ElseIf mail.Text = "" Then
            MsgBox("Enter email address")
            mail.Focus()
        ElseIf city.Text = "" Then
            MsgBox("Enter City")
            city.Focus()
        ElseIf address.Text = "" Then
            MsgBox("Enter Address")
            address.Focus()
        Else
            Validatemail()
        End If
    End Sub
    Sub Validatemail()
        Dim email As String = mail.Text
        If EmailAddresscheck(email) = False Then
            MsgBox("The email address you entered is not valid")
            mail.Focus()
        Else
            Insert()

        End If
    End Sub
    Function EmailAddresscheck(ByVal emailaddress As String) As Boolean
        Dim pttern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pttern)
        If emailAddressMatch.Success Then
            EmailAddresscheck = True
        Else
            EmailAddresscheck = False

        End If

    End Function
    Sub Insert()
        Dim gen As Char = Truncate(gender.SelectedItem, 1)
        Dim anti As Char = Truncate(antibody.SelectedItem, 1)
        Dim price As Integer = 0
        If anti = "Y" Then
            price = 5500
        Else
            price = 4500
        End If
        Dim time As Date = Date.UtcNow
        Dim donor_id As String = GenerateDonorID()
        donor_reciept.plasmaIDLabel.Text = donor_id

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
        Dim cmd1 As New SqlCommand("insert into donor_records(plasma_id,first_name,last_name,age,phone_number,email,city,address,blood_group,sex,anti_body,price,sold,transaction_time) values('" & donor_id & "','" & fname.Text & "','" & lname.Text & "','" & age.Text & "','" & pnumber.Text & "','" & mail.Text & "','" & city.Text & "','" & address.Text & "','" & blood_group & "','" & gen & "','" & anti & "','" & price & "','" & "N" & "','" & time & "')", con)
        con.Open()
        cmd1.ExecuteNonQuery()

        Dashboard.Refresh()
        con.Close()
        donor_success.Show()
        Me.Close()
        'End If
    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles fNameErrorText.Click

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles phNumberErrorText.Click

    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles emailErrortext.Click

    End Sub

    Private Sub fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fname.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Not ((Asc(e.KeyChar) <= 122 And Asc(e.KeyChar) >= 97) Or (Asc(e.KeyChar) <= 90 And Asc(e.KeyChar) >= 65) Or Asc(e.KeyChar) = 32) Then
                e.Handled = True
                MsgBox("Only Characters are Valid")
            End If
        End If
    End Sub

    Private Sub lname_TextChanged(sender As Object, e As EventArgs) Handles lname.TextChanged

    End Sub

    Private Sub lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lname.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Not ((Asc(e.KeyChar) <= 122 And Asc(e.KeyChar) >= 97) Or (Asc(e.KeyChar) <= 90 And Asc(e.KeyChar) >= 65) Or Asc(e.KeyChar) = 32) Then
                e.Handled = True
                MsgBox("Only Characters are Valid")
            End If
        End If
    End Sub

    Private Sub city_TextChanged(sender As Object, e As EventArgs) Handles city.TextChanged

    End Sub

    Private Sub city_KeyPress(sender As Object, e As KeyPressEventArgs) Handles city.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Not ((Asc(e.KeyChar) <= 122 And Asc(e.KeyChar) >= 97) Or (Asc(e.KeyChar) <= 90 And Asc(e.KeyChar) >= 65) Or Asc(e.KeyChar) = 32) Then
                e.Handled = True
                MsgBox("Only Characters are Valid")
            End If
        End If
    End Sub

    Private Sub age_TextChanged(sender As Object, e As EventArgs) Handles age.TextChanged

    End Sub

    Private Sub age_Leave(sender As Object, e As EventArgs) Handles age.Leave
        If age.Text < 17 Or age.Text > 71 Then
            MsgBox("Sorry!!! You are Not allowed")
            age.Focus()

        End If
    End Sub
End Class