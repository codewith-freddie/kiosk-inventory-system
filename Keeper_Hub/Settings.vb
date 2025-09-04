Imports System.IO
Imports System.Transactions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Settings
    Public Shared sets
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
                txtCurrentPass.Focus()
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

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbUsername.Text = sets
        con.ConnectionString = connectionStr
        displaydata()
    End Sub
    Sub displaydata()
        Try
            con.Open()
            Dim query As New MySqlCommand("SELECT * FROM accounts WHERE roleID=@roleID", con)
            query.Parameters.AddWithValue("@roleID", lbUsername.Text)

            Dim reader As MySqlDataReader = query.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    txtRoleID.Text = reader("roleID").ToString
                    txtFullName.Text = reader("fullname").ToString()
                    txtStatus.Text = reader("status").ToString()
                    txtGender.Text = reader("gender").ToString()
                    txtDepart.Text = reader("depart").ToString()
                End While
            End If

        Catch ex As Exception
            ' Handle the exception, e.g., display an error message
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
            Dim query As New MySqlCommand("SELECT password FROM accounts WHERE roleID = 'Admin'", con)
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
            Dim updateQuery As New MySqlCommand("UPDATE accounts SET password=@password WHERE roleID = 'Admin'", con)
            updateQuery.Parameters.AddWithValue("password", txtNewPass.Text)
            updateQuery.ExecuteNonQuery()
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateInfo()
    End Sub

    Private Sub UpdateInfo()
        If Not String.IsNullOrEmpty(txtFullName.Text) AndAlso Not String.IsNullOrEmpty(txtStatus.Text) AndAlso Not String.IsNullOrEmpty(txtGender.Text) AndAlso Not String.IsNullOrEmpty(txtDepart.Text) Then
            Try
                con.Open()
                Dim updateQuery As New MySqlCommand("UPDATE accounts SET FullName = @fullname, Status = @status, Gender = @gender, Depart = @depart WHERE roleID='Admin'", con)
                updateQuery.Parameters.AddWithValue("@fullname", txtFullName.Text)
                updateQuery.Parameters.AddWithValue("@status", txtStatus.Text)
                updateQuery.Parameters.AddWithValue("@gender", txtGender.Text)
                updateQuery.Parameters.AddWithValue("@depart", txtDepart.Text)
                updateQuery.ExecuteNonQuery()
            Finally
                con.Close()
            End Try
            MessageBox.Show("Personal Information changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("All fields are required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class