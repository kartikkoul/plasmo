''''''''''''''''''''''''''''''''''''''''''''''''''''''CATEGORY DETAILS FORM''''''''''''''''''''''''''''''''''''''''
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class CategoryDetail


    Private Sub CategoryDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim bloodGroup = type.Text

        Select Case bloodGroup
            Case "A+"
                bloodGroup = "AP"
            Case "A-"
                bloodGroup = "AM"
            Case "B+"
                End
        bloodGroup = "BP"
            Case "B-"
                bloodGroup = "BM"
            Case "AB+"
                bloodGroup = "ABP"
            Case "AB-"
                bloodGroup = "ABM"
            Case "O+"
                bloodGroup = "OP"
            Case "O-"
                bloodGroup = "OM"
        End Select



        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")

        '-------------------------For Information Of Total Number Of Antibody and Non-Antibody Plasma------------------------------------------
        If con.State = 1 Then con.Close()
        Dim countAntibodyQuery As New SqlCommand("select plasma_id from donor_records  where blood_group='" & bloodGroup & "' and anti_body= '" & "Y" & "' AND sold='" & "N" & "'", con)
        con.Open()
        adapter.SelectCommand = countAntibodyQuery
        adapter.Fill(ds, "donor_records")
        Dim countAntibody = ds.Tables(0).Rows.Count
        If countAntibody > 0 Then
            antibodyCountTextbox.Text = countAntibody

        Else
            antibodyCountTextbox.Text = 0
        End If
        adapter.Dispose()
        ds.Clear()
        con.Close()

        If con.State = 1 Then con.Close()
        Dim countNonAntibodyQuery As New SqlCommand("select plasma_id from donor_records  where blood_group='" & bloodGroup & "'and anti_body= '" & "N" & "' AND sold='" & "N" & "'", con)
        con.Open()
        adapter.SelectCommand = countNonAntibodyQuery
        adapter.Fill(ds, "donor_records")
        Dim countNonAntibody = ds.Tables(0).Rows.Count
        If countNonAntibody > 0 Then
            nonAntiBodyCountTextBox.Text = countNonAntibody

        Else
            nonAntiBodyCountTextBox.Text = 0
        End If

        adapter.Dispose()
        ds.Clear()
        con.Close()




        ''-------------------------XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX------------------------------------------

        con.Open()
        Dim cmd As New SqlCommand("select plasma_id, anti_body, age, price from donor_records where sold='" & "N" & "' and blood_group='" & bloodGroup & "'", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        Guna2DataGridView1.Rows.Clear()

        '--------------------------------LOADING DATA INTO DATA GRID IN THE FORM----------------------------'
        While dr.Read
            Dim anti_body As String
            If dr("anti_body") = "Y" Then
                anti_body = "YES"

            Else
                anti_body = "NO"
            End If
            Guna2DataGridView1.Rows.Add(dr("plasma_id"), anti_body, dr("age"), "₹ " + dr("price").ToString)
        End While
        '---------------------------------------------------------------------------------------------------'

        con.Close()

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub RecieverBtnMenu_Click(sender As Object, e As EventArgs) Handles RecieverBtnMenu.Click
        Reciever_form.Show()
        Me.Close()
    End Sub

    Private Sub DonorBtnMenu_Click(sender As Object, e As EventArgs) Handles DonorBtnMenu.Click
        donorForm.Show()
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

    Private Sub DashboardBtnMenu_Click(sender As Object, e As EventArgs) Handles DashboardBtnMenu.Click
        Dashboard.Show()
        Me.Close()
    End Sub


    '------------------------------------------FOR HOVER EFFECT ON ROWS----------------------------------------------'
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
    '----------------------------------------------------------------------------------------------------------------'

End Class