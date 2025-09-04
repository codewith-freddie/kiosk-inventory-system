Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Profile
    Public Shared pu
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"
    Private Sub txtCurrentPass_GotFocus(sender As Object, e As EventArgs) Handles txtCurrentPass.GotFocus
        txtCurrentPass.UseSystemPasswordChar = True
    End Sub

    Private Sub txtNewPass_GotFocus(sender As Object, e As EventArgs) Handles txtNewPass.GotFocus
        txtNewPass.UseSystemPasswordChar = True
    End Sub

    Private Sub txtConfirmPass_GotFocus(sender As Object, e As EventArgs) Handles txtConfirmPass.GotFocus
        txtConfirmPass.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckPasswordMatch()
        Dim password As String = txtNewPass.Text
        Dim confirmPassword As String = txtConfirmPass.Text

        If Not String.IsNullOrEmpty(password) AndAlso Not String.IsNullOrEmpty(confirmPassword) Then
            If password <> confirmPassword Then
                MessageBox.Show("Passwords do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewPass.Text = ""
                txtConfirmPass.Text = ""
                txtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub cbCP1_CheckedChanged(sender As Object, e As EventArgs) Handles cbCP1.CheckedChanged
        If cbCP1.Checked = True Then
            txtCurrentPass.UseSystemPasswordChar = False
        Else
            txtCurrentPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub cbNP2_CheckedChanged(sender As Object, e As EventArgs) Handles cbNP2.CheckedChanged
        If cbNP2.Checked = True Then
            txtNewPass.UseSystemPasswordChar = False
        Else
            txtNewPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub cbCP3_CheckedChanged(sender As Object, e As EventArgs) Handles cbCP3.CheckedChanged
        If cbCP3.Checked = True Then
            txtConfirmPass.UseSystemPasswordChar = False
        Else
            txtConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Profile_User__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRoleID.Text = pu
        'textChanged()
        con.ConnectionString = connectionStr
        displaydata()
    End Sub
    Sub displaydata()
        Try
            con.Open()
            Dim query As New MySqlCommand("SELECT * FROM accounts WHERE roleID=@roleID", con)
            query.Parameters.AddWithValue("roleID", txtRoleID.Text)

            Dim reader As MySqlDataReader = query.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    txtFullName.Text = reader("fullname").ToString()
                    txtStatus.Text = reader("status").ToString()
                    txtGender.Text = reader("gender").ToString()
                    txtDepart.Text = reader("depart").ToString()
                    txtPassword.Text = reader("password").ToString()
                End While
            End If

            If txtStatus.Text = "Student" Then
                lbRoleID.Text = "Student ID"
                lbDepart.Text = "Course and
Year Level"
            Else
                lbRoleID.Text = "Faculty ID"
                lbDepart.Text = "Department"
            End If
        Catch ex As Exception
            ' Handle the exception, e.g., display an error message
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Shadows Sub textChanged()
        Try
            con.Open()
            Using cmd As New MySqlCommand("SELECT * FROM accounts WHERE roleID = @roleID AND status = @status", con)
                cmd.Parameters.AddWithValue("@USERNAME", lbRoleID.Text)
                cmd.Parameters.AddWithValue("@PASSWORD", lbStatus.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()

                    If reader("status").ToString() = "Faculty" Then
                        lbStatus.Text = "Faculty ID"

                    ElseIf reader("status").ToString() = "Student" Then
                        lbStatus.Text = "Student ID"
                    End If
                Else
                    MessageBox.Show("Error Bugo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        Try
            If Not String.IsNullOrEmpty(txtCurrentPass.Text) Then
                If Not String.IsNullOrEmpty(txtNewPass.Text) AndAlso Not String.IsNullOrEmpty(txtConfirmPass.Text) Then
                    If ValidateCurrentPassword() Then
                        ' Check if the new password and confirm password match
                        If txtNewPass.Text = txtConfirmPass.Text Then
                            ' Update the password in the database
                            UpdatePassword()
                            displaydata()

                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Clear password fields after successful change
                            txtCurrentPass.Text = ""
                            txtNewPass.Text = ""
                            txtConfirmPass.Text = ""
                        Else
                            MessageBox.Show("New password and confirm password do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Current password is incorrect. Please enter the correct password.", "Password Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Please enter a new password and confirm password.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please enter the Current Password.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Function to validate the current password against the database
    Private Function ValidateCurrentPassword() As Boolean
        Try
            con.Open()
            Dim query As New MySqlCommand("SELECT password FROM accounts WHERE roleID=@roleID", con)
            query.Parameters.AddWithValue("roleID", pu)

            Dim storedPassword As String = Convert.ToString(query.ExecuteScalar())

            ' Compare the entered current password with the stored password in the database
            Return txtCurrentPass.Text = storedPassword
        Finally
            con.Close()
        End Try
    End Function

    ' Function to update the password in the database
    Private Sub UpdatePassword()
        Try
            con.Open()
            Dim updateQuery As New MySqlCommand("UPDATE accounts SET password=@password WHERE roleID=@roleID", con)
            updateQuery.Parameters.AddWithValue("password", txtNewPass.Text)
            updateQuery.Parameters.AddWithValue("roleID", pu)
            updateQuery.ExecuteNonQuery()
        Finally
            con.Close()
        End Try
    End Sub

End Class