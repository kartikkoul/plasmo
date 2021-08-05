Imports System.Data
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles LoginButton.Click
        LoginValidation()

    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub Guna2TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Public Sub LoginValidation()
        If UserIDTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("User ID and Password cannot be empty")
        Else
            conn = New SqlConnection("Data Source = WHITEDEVIL\SQLEXPRESS; Initial Catalog = plasmo; Integrated Security = True;MultipleActiveResultSets=true;")

            query = "select admin_id,admin_pass from auth where admin_id = '" & UserIDTextBox.Text & "' and admin_pass = '" & PasswordTextBox.Text & "' "
            cmd = New SqlCommand(query, conn)

            Try
                conn.Open()
                Dim da As New SqlDataAdapter
                Dim dset As New DataSet
                da.SelectCommand = cmd
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While (dr.Read())
                        Dashboard.Show()
                        Me.Hide()
                        UserIDTextBox.Clear()
                        PasswordTextBox.Clear()

                    End While
                    conn.Close()
                Else
                    conn.Close()
                    MsgBox("Invalid Credentials")
                    UserIDTextBox.Clear()
                    PasswordTextBox.Clear()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
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

    Public Sub Guna2PictureBox3_Click_1(sender As Object, e As EventArgs) Handles EyeOpen.Click

    End Sub

    Private Sub Guna2PictureBox4_Click_1(sender As Object, e As EventArgs) Handles EyeClosed.Click

    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Newdataset)

    End Sub



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

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
