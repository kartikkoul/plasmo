'''''''''''''''''''''''''''RECIEVER RECIEPT FORM''''''''''''''''''''
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class reciever_reciept
    Private Sub reciever_reciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reciever_id = recieverIDLabel.Text
        recieverIDLabel.Text = "(" + recieverIDLabel.Text + ")"
        Dim con As New SqlConnection("server=DESKTOP-5GP20F1\SQLEXPRESS;database=plasmo;integrated security=true")
        con.Open()
        Dim cmd As New SqlCommand("select first_name, last_name, phone_number, age, address, blood_group, sex, email, transaction_time,anti_body, price from reciever_records where reciever_id='" & reciever_id & "'", con)
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




            Namelabel.Text = dr("first_name") + " " + dr("last_name")
            ageLabel.Text = dr("age")
            phNumberLabel.Text = dr("phone_number")
            addressLabel.Text = dr("address")
            sexLabel.Text = dr("sex")
            emailLabel.Text = dr("email")
            bloodGroupLabel.Text = blood_group
            dateLabel.Text = dr("transaction_time")
            antiBodyLabel.Text = dr("anti_body")
            costLabel.Text = "₹ " + dr("price").ToString()
        End While
        con.Close()
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
        donorForm.Show()
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

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        PrintPreviewDialog1.Document = Me.PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        da(e.Graphics)
    End Sub
    Sub da(ByVal g As Graphics)


        Dim ydiff As New Int32
        Dim ystart As New Int32
        Dim xstart As New Int32

        Dim fontColor = New SolidBrush(Color.FromArgb(237, 68, 78))

        ydiff = 20
        ystart = 50
        g.DrawString("PLASMO", Guna2HtmlLabel1.Font, fontColor, 370, ystart + 20)
        g.DrawString(recieverIDLabel.Text, Guna2HtmlLabel1.Font, Brushes.Black, 360, ystart + 60)


        g.DrawString("Name................................................ ", Guna2HtmlLabel1.Font, Brushes.Black, 100, 150)

        g.DrawString("Phone Number........................................", Guna2HtmlLabel1.Font, Brushes.Black, 100, 200)

        g.DrawString("Age.................................................", Guna2HtmlLabel1.Font, Brushes.Black, 100, 250)

        g.DrawString("Address............................................. ", Guna2HtmlLabel1.Font, Brushes.Black, 100, 300)

        g.DrawString("Sex................................................. ", Guna2HtmlLabel1.Font, Brushes.Black, 100, 350)

        g.DrawString("Email...............................................", Guna2HtmlLabel1.Font, Brushes.Black, 100, 400)

        g.DrawString("Blood Group.........................................", Guna2HtmlLabel1.Font, Brushes.Black, 100, 450)

        g.DrawString("Antibodies.........................................", Guna2HtmlLabel1.Font, Brushes.Black, 100, 500)

        g.DrawString("Cost.........................................", Guna2HtmlLabel1.Font, Brushes.Black, 100, 550)

        g.DrawString("Received On..........................................", Guna2HtmlLabel1.Font, Brushes.Black, 100, 600)

        g.DrawString(Namelabel.Text, Guna2HtmlLabel1.Font, Brushes.Black, 500, 150)
        g.DrawString(phNumberLabel.Text, Guna2HtmlLabel1.Font, Brushes.Black, 500, 200)
        g.DrawString(ageLabel.Text, Guna2HtmlLabel1.Font, Brushes.Black, 500, 250)
        g.DrawString(addressLabel.Text, Guna2HtmlLabel1.Font, Brushes.Black, 500, 300)
        g.DrawString(sexLabel.Text, Guna2HtmlLabel1.Font, Brushes.Black, 500, 350)
        g.DrawString(emailLabel.Text, Guna2HtmlLabel1.Font, Brushes.Black, 500, 400)
        g.DrawString(bloodGroupLabel.Text, Guna2HtmlLabel1.Font, Brushes.Black, 500, 450)
        g.DrawString(antiBodyLabel.Text, Guna2HtmlLabel1.Font, Brushes.Black, 500, 500)
        g.DrawString(costLabel.Text, Guna2HtmlLabel1.Font, Brushes.Black, 500, 550)
        g.DrawString(dateLabel.Text, Guna2HtmlLabel1.Font, Brushes.Black, 500, 600)

        ystart = 210
        xstart = 30
        ydiff = 20

        ystart = ystart + ydiff

    End Sub
End Class