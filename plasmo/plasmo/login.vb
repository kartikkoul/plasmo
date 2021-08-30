'''''''''''''''''''''''''''''''''''''''''''''LOGIN FORM''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports System.Data
Imports System.Data.SqlClient
Public Class login
    Public Sub LoginValidation() 'For Checking Entered Credentials

        If UserIDTextBox.Text.Trim.Length = 0 Or PasswordTextBox.Text.Trim.Length = 0 Then
            '---------------------------FOR CHECKING BLANK INPUTS------------------------------'
            If UserIDTextBox.Text.Trim.Length = 0 And PasswordTextBox.Text.Trim.Length = 0 Then
                userIdError.Visible = True
                UserIDTextBox.BorderColor = Color.Red
                UserIDTextBox.FocusedState.BorderColor = Color.Red
                UserIDTextBox.HoverState.BorderColor = Color.Red
                passError.Visible = True
                PasswordTextBox.BorderColor = Color.Red
                PasswordTextBox.FocusedState.BorderColor = Color.Red
                PasswordTextBox.HoverState.BorderColor = Color.Red

            ElseIf UserIDTextBox.Text.Trim.Length = 0 Then
                userIdError.Visible = True
                UserIDTextBox.BorderColor = Color.Red
                UserIDTextBox.FocusedState.BorderColor = Color.Red
                UserIDTextBox.HoverState.BorderColor = Color.Red

            Else
                passError.Visible = True
                PasswordTextBox.BorderColor = Color.Red
                PasswordTextBox.FocusedState.BorderColor = Color.Red
                PasswordTextBox.HoverState.BorderColor = Color.Red

            End If
            '-------------------------------------------------------------------------------------'
        Else

            conn = New SqlConnection("Data Source = DESKTOP-5GP20F1\SQLEXPRESS; Initial Catalog = plasmo; Integrated Security = True;MultipleActiveResultSets=true;")

            query = "select username,pass from auth where username = '" & UserIDTextBox.Text & "' and pass = '" & PasswordTextBox.Text & "' "
            cmd = New SqlCommand(query, conn)

            Try
                conn.Open()
                Dim da As New SqlDataAdapter
                Dim dset As New DataSet
                da.SelectCommand = cmd
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                'WHEN CREDENTIALS MATCHES IN THE DATABASE
                If dr.HasRows Then
                    While (dr.Read())
                        Dashboard.Show()
                        Me.Hide()
                        UserIDTextBox.Clear()
                        PasswordTextBox.Clear()

                    End While
                    conn.Close()
                Else
                    'WHEN CREDENTIALS DOES NOT MATCH
                    conn.Close()
                    UserIDTextBox.Clear()
                    PasswordTextBox.Clear()
                    InvalidCredentials.Visible = True
                End If
            Catch ex As Exception
                'EXCEPTION HANDLING
                InvalidCredentials.Text = ex.ToString
                InvalidCredentials.Visible = True
            End Try

        End If
    End Sub

    Public Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs)
        EyeOpen.Visible = True
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs)
        EyeClosed.Visible = False
        EyeOpen.Visible = False
    End Sub

    '---------------------------FOR SWITCHING BETWEEN HIDDEN AND EXPOSED PASSWORD---------------------'
    Private Sub EyeButton_Click(sender As Object, e As EventArgs) Handles EyeButton.Click

        If PasswordTextBox.UseSystemPasswordChar = True Then
            PasswordTextBox.UseSystemPasswordChar = False
            EyeOpen.Visible = True
            EyeClosed.Visible = False

        Else
            PasswordTextBox.UseSystemPasswordChar = True
            EyeOpen.Visible = False
            EyeClosed.Visible = True
        End If
    End Sub
    '------------------------------------------------------------------------------------------------'

    '----------------------------------APPLICATION WINDOW CONTROLS-----------------------------------'
    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub
    '------------------------------------------------------------------------------------------------'
    Private Sub UserIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserIDTextBox.TextChanged
        UserIDTextBox.BorderColor = Color.FromArgb(64, 64, 64)
        UserIDTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
        UserIDTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        userIdError.Visible = False
        InvalidCredentials.Visible = False
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles LoginButton.Click
        LoginValidation()
    End Sub

    Public Sub Guna2TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        PasswordTextBox.BorderColor = Color.FromArgb(64, 64, 64)
        PasswordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
        PasswordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        passError.Visible = False
        InvalidCredentials.Visible = False
    End Sub
End Class
