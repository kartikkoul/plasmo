Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class donor_history

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles dashboardBtnMenu.Click

    End Sub

    Private Sub DonorHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet

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
        con.Open()
        adapter.SelectCommand = countRecieversCmd
        adapter.Fill(ds, "reciever_records")
        Dim countRecievers As Integer = ds.Tables(0).Rows.Count
        adapter.Dispose()
        ds.Dispose()
        con.Close()
        totalRecievers.Text = countRecievers

        con.Open()
        Dim cmd As New SqlCommand("select plasma_id, first_name, last_name, age, blood_group, anti_body, transaction_time from donor_records", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        Guna2DataGridView1.Rows.Clear()

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
            Guna2DataGridView1.Rows.Add(dr("plasma_id"), name, dr("age"), blood_group, dr("anti_body"), dr("transaction_time"))
        End While
        con.Close()


    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

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
    Private Sub HistoryBtnMenu_Click(sender As Object, e As EventArgs) Handles historyBtnMenu.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub




    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

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


End Class