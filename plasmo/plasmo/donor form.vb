'''''''''''''''''''''''''''''''''''''''''''''''''DONOR-FORM Form''''''''''''''''''''''''''''''''''
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Imports System.Text.RegularExpressions
Public Class donorForm
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs)
        Reciever_form.Show()
        Me.Close()
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

    '--------------TRUNCATE FUNCTION FOR SENDING APPROPRIATE VALUES TO DATABASE------------------'
    Public Function Truncate(value As String, length As Integer) As String
        If length > value.Length Then
            Return value
        Else
            Return value.Substring(0, length)
        End If
    End Function

    '--------------------------------------------------------------------------------------------'

    '------------------------AUTOMATIC GENERATION OF UNIQUE DONOR IDs-----------------------------'
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
    '---------------------------------------------------------------------------------------------'

    '-------------------------------EMAIL VALIDATION USING REGEX----------------------------------'
    Public Function EmailAddresscheck(ByVal emailaddress As String) As Boolean
        Dim pttern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pttern)
        If emailAddressMatch.Success Then
            EmailAddresscheck = True
        Else
            EmailAddresscheck = False

        End If
    End Function
    '---------------------------------------------------------------------------------------------'


    Public Sub Validatemail()
        Dim email As String = mail.Text
        If EmailAddresscheck(email) = False Then
            mail.BorderColor = Color.Red
            emailErrortext.Visible = True
            Exit Sub
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim valid = True

        '-----------------------HANDLING INVALID INPUTS-------------------'
        If fname.Text.Trim.Length = 0 Then
            fname.BorderColor = Color.Red
            fname.HoverState.BorderColor = Color.Red
            fname.FocusedState.BorderColor = Color.Red
            fNameErrorText.Visible = True
            valid = False
        End If

        If lname.Text = "" Then
            lname.BorderColor = Color.Red
            lname.HoverState.BorderColor = Color.Red
            lname.FocusedState.BorderColor = Color.Red
            lNameErrorText.Visible = True
            valid = False
        End If


        If age.Text.Trim.Length = 0 Then
            age.BorderColor = Color.Red
            age.HoverState.BorderColor = Color.Red
            age.FocusedState.BorderColor = Color.Red
            ageErrorText.Visible = True
            valid = False
        Else
            Dim ageInput As Integer = age.Text
            If ageInput < 17 Or ageInput > 71 Then
                age.BorderColor = Color.Red
                age.HoverState.BorderColor = Color.Red
                age.FocusedState.BorderColor = Color.Red
                ageErrorText.Visible = True
                valid = False
            End If
        End If

        If pnumber.Text.Trim.Length = 0 Or pnumber.Text.Length <> 10 Then
            pnumber.BorderColor = Color.Red
            pnumber.HoverState.BorderColor = Color.Red
            pnumber.FocusedState.BorderColor = Color.Red
            phNumberErrorText.Visible = True
            valid = False
        End If

        If mail.Text.Trim.Length = 0 Then
            mail.BorderColor = Color.Red
            mail.HoverState.BorderColor = Color.Red
            mail.FocusedState.BorderColor = Color.Red
            emailErrortext.Visible = True
            valid = False
        End If

        If city.Text.Trim.Length = 0 Then
            city.BorderColor = Color.Red
            city.HoverState.BorderColor = Color.Red
            city.FocusedState.BorderColor = Color.Red
            cityErrorText.Visible = True
            valid = False
        End If

        If address.Text.Trim.Length = 0 Then
            address.BorderColor = Color.Red
            address.HoverState.BorderColor = Color.Red
            address.FocusedState.BorderColor = Color.Red
            addressErrorText.Visible = True
            valid = False
        End If
        Validatemail()


        If valid = False Then
            Exit Sub
        End If
        '---------------------------------------------------------------'


        '------------------SENDING DATA TO THE DATABASE------------------'
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
        '----------------------------------------------------------------'
        donor_success.Show()
        Me.Close()

    End Sub

    Private Sub fname_TextChanged(sender As Object, e As EventArgs) Handles fname.TextChanged
        fname.BorderColor = Color.Black
        fname.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        fname.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        fname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
        fNameErrorText.Visible = False
    End Sub
    Private Sub lname_TextChanged(sender As Object, e As EventArgs) Handles lname.TextChanged
        lname.BorderColor = Color.Black
        lname.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        lname.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        lname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
        lNameErrorText.Visible = False
    End Sub

    Private Sub age_TextChanged(sender As Object, e As EventArgs) Handles age.TextChanged
        age.BorderColor = Color.Black
        age.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        age.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        age.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
        ageErrorText.Visible = False
    End Sub

    Private Sub pnumber_TextChanged(sender As Object, e As EventArgs) Handles pnumber.TextChanged
        pnumber.BorderColor = Color.Black
        pnumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        pnumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        pnumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
        phNumberErrorText.Visible = False
    End Sub

    Private Sub mail_TextChanged(sender As Object, e As EventArgs) Handles mail.TextChanged
        mail.BorderColor = Color.Black
        mail.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        mail.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        mail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
        emailErrortext.Visible = False
    End Sub

    Private Sub city_TextChanged(sender As Object, e As EventArgs) Handles city.TextChanged
        city.BorderColor = Color.Black
        city.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        city.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        city.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
        cityErrorText.Visible = False
    End Sub

    Private Sub address_TextChanged(sender As Object, e As EventArgs) Handles address.TextChanged
        address.BorderColor = Color.Black
        address.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        address.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        address.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
        addressErrorText.Visible = False
    End Sub

    '---IN ORDER TO ALLOW ONLY NUMBERS AS INPUTS IN AGE AND PHONE_NUMBER TEXTBOX WITH THEIR APPROPRIATE LENGTHS RESPECTIVELY-------'
    Private Sub age_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles age.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) And age.Text.Trim.Length < 2 Then

            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pnumber.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) And pnumber.Text.Trim.Length < 10 Then

            Else
                e.Handled = True
            End If
        End If
    End Sub
    '------------------------------------------------------------------------------------------------------------------------------'

End Class