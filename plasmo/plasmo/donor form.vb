Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class Donor_form
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
        Form1.Show()
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
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub HistoryBtnMenu_Click(sender As Object, e As EventArgs) Handles HistoryBtnMenu.Click
        Details.Show()
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

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim gen As Char = Truncate(gender.SelectedItem, 1)
        Dim anti As Char = Truncate(antibody.SelectedItem, 1)

        Dim con As New SqlConnection("Server=WHITEDEVIL\SQLEXPRESS;Database=plasmo;Integrated Security=true")
        Dim cmd1 As New SqlCommand("insert into donor_records(first_name,last_name,age,phone_number,email,city,address,blood_group,sex,anti_body,plasma_id,sold) values('" & fname.Text & "','" & lname.Text & "','" & age.Text & "','" & pnumber.Text & "','" & mail.Text & "','" & city.Text & "','" & address.Text & "','" & bgroup.SelectedItem & "','" & gen & "','" & anti & "','" & "E0800743" & "','" & "N" & "')", con)
        con.Open()
        cmd1.ExecuteNonQuery()
        MsgBox("Donor Registered")
        Me.Refresh()
        con.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub
End Class