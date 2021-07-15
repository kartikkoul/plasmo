Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ImageCheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CircleProgressBar1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub Guna2TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        LoginValidation()

    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub Guna2TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles Guna2TextBox3.TextChanged
        Guna2TextBox3.UseSystemPasswordChar = True
    End Sub

    Public Sub LoginValidation()
        If Guna2TextBox2.Text = "" Or Guna2TextBox3.Text = "" Then
            MsgBox("User ID and Password cannot be empty")
        Else
            conn = New SqlConnection("Data Source = WHITEDEVIL\SQLEXPRESS; Initial Catalog = auth; Integrated Security = True;")

            query = "select [admin id],[admin pass] from login where [admin id] = '" & Guna2TextBox2.Text & "' and [admin pass] = '" & Guna2TextBox3.Text & "' "
            cmd = New SqlCommand(query, conn)

            Try
                conn.Open()
                Dim da As New SqlDataAdapter
                Dim dset As New DataSet
                da.SelectCommand = cmd
                da.Fill(dset, "login")
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While (dr.Read())
                        Dashboard.Show()
                        Me.Hide()
                        Guna2TextBox2.Clear()
                        Guna2TextBox3.Clear()

                    End While
                    conn.Close()
                Else
                    conn.Close()
                    MsgBox("Invalid Credentials")
                    Guna2TextBox2.Clear()
                    Guna2TextBox3.Clear()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub



    Public Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs)
        Guna2PictureBox3.Visible = False
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs)
        Guna2PictureBox4.Visible = False
        Guna2PictureBox3.Visible = False
    End Sub

    Public Sub Guna2PictureBox3_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click

    End Sub

    Private Sub Guna2PictureBox4_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click

    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Newdataset)

    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
