Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class donorForm
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs)
        Reciever_form.Show()
        Me.Hide()
    End Sub

    Private Sub Donor_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
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

    End Sub

    Private Sub RecieverBtnMenu_Click(sender As Object, e As EventArgs) Handles RecieverBtnMenu.Click
        Reciever_form.Show()
        Me.Hide()
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
        Dim ID = "E080" + GenerateID()

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
        'Dim isInvalid As Boolean = fname.Text.Trim.Length == 0 Or lname.Text.Trim.Length = 0 Or (age.Text < 17 Or age.Text > 71 Or age.Text.Trim.Length = 0)
        'If isInvalid Then
        '    If fname.Text.Trim.Length = 0 Then
        '        fNameErrorText.Visible = True
        '        fname.BorderColor = Color.Red

        '    ElseIf lname.Text.Trim.Length = 0 Then
        '        lNameErrorText.Visible = True
        '        lname.BorderColor = Color.Red

        '    ElseIf (age.Text < 17 Or age.Text > 71 Or age.Text.Trim.Length = 0) Then
        '        ageErrorText.Visible = True
        '        age.BorderColor = Color.Red
        '    End If
        'Else
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
        donor_history.Refresh()










        Dashboard.Refresh()
        con.Close()
        donor_success.Show()
        Me.Hide()
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
End Class