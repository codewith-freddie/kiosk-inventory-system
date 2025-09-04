Imports System.Security.Cryptography.Xml
Imports MySql.Data.MySqlClient

Public Class LoginDashboard
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"
    Private usernamePlaceholder As String = "Username"
    Private passwordPlaceholder As String = "Password"

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = usernamePlaceholder Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.FromArgb(9, 96, 79)
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = passwordPlaceholder Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.FromArgb(9, 96, 79)
        End If
        txtPassword.UseSystemPasswordChar = True ' Set bullets for password
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = usernamePlaceholder
        txtUsername.ForeColor = Color.Gray

        txtPassword.Text = passwordPlaceholder
        txtPassword.ForeColor = Color.Gray
        txtPassword.PasswordChar = ControlChars.NullChar ' No bullets for placeholder

        con.ConnectionString = connectionStr
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lbExit.Click
        ' Close the entire application when the Exit Label is clicked
        Application.Exit()
    End Sub

    Private Sub cbHide_CheckedChanged(sender As Object, e As EventArgs) Handles cbHide.CheckedChanged
        If cbHide.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim su As New SignUp()
        Me.Hide()
        su.Show()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("All fields are required!")
        Else
            Try
                con.Open()
                Using cmd As New MySqlCommand("SELECT * FROM accounts WHERE roleID = @USERNAME AND password = @PASSWORD", con)
                    cmd.Parameters.AddWithValue("@USERNAME", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text.Trim())

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()

                        If reader("user_type").ToString() = "Admin" Then
                            MessageBox.Show("Login Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Dim AdminMain As New AdminDashboard
                            AdminDashboard.AdminMain = txtUsername.Text
                            Me.Hide()
                            AdminDashboard.Show()


                        ElseIf reader("user_type").ToString() = "User" Then
                            MessageBox.Show("Login Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Dim UserMain As New UserDashboard
                            UserDashboard.UserMain = txtUsername.Text
                            UserDashboard.Show()
                        End If
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                    Else
                        MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtUsername.Text = ""
                        txtPassword.Text = ""

                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub lbAvailableItems_Click(sender As Object, e As EventArgs) Handles lbAvailableItems.Click
        Dim inventory As New ViewItems
        Me.Hide()
        inventory.Show()
    End Sub
End Class
