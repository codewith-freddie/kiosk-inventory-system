Imports MySql.Data.MySqlClient

Public Class AddUser
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.SelectedItem = "Faculty"
        cmbUserType.SelectedItem = "User"
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        If cmbStatus.SelectedItem <> "Faculty" AndAlso cmbStatus.SelectedItem <> "Student" Then
            MessageBox.Show("Invalid Input!")
        ElseIf cmbStatus.SelectedItem = "Student" Then
            lbRoleID.Text = "Student ID"
            lbStatus.Text = "Course and
Year Level"
        Else
            lbRoleID.Text = "Faculty ID"
            lbStatus.Text = "Department"
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub txtConfirmPassword_GotFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.GotFocus
        txtConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearFields()
        cmbStatus.SelectedItem = "Faculty"
        lbRoleID.Text = "Faculty ID"
        lbStatus.Text = "Department"
        txtRoleID.Text = ""
        txtFullName.Text = ""
        txtDepart.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
        cmbGender.Text = ""
    End Sub

    Private Sub txtConfirmPassword_Leave(sender As Object, e As EventArgs) Handles txtConfirmPassword.Leave
        CheckPasswordMatch()
    End Sub

    Private Sub CheckPasswordMatch()
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        If Not String.IsNullOrEmpty(password) AndAlso Not String.IsNullOrEmpty(confirmPassword) Then
            If password <> confirmPassword Then
                MessageBox.Show("Passwords do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Text = ""
                txtConfirmPassword.Text = ""
                txtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub cbPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbPassword.CheckedChanged
        If cbPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub cbConfirmPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbConfirmPass.CheckedChanged
        If cbConfirmPass.Checked = True Then
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim status As String = cmbStatus.Text
            Dim roleID As String = txtRoleID.Text
            Dim fullName As String = txtFullName.Text
            Dim depart As String = txtDepart.Text
            Dim gender As String = cmbGender.Text
            Dim password As String = txtPassword.Text
            Dim user_type As String = cmbUserType.Text

            If String.IsNullOrEmpty(status) OrElse String.IsNullOrEmpty(roleID) OrElse String.IsNullOrEmpty(fullName) OrElse String.IsNullOrEmpty(depart) OrElse String.IsNullOrEmpty(gender) OrElse String.IsNullOrEmpty(password) Then
                MessageBox.Show("Please fill in all the required fields.")
                Exit Sub
            End If

            ' Check if roleID already exists
            If IsRoleIDExists(roleID) Then
                MessageBox.Show("RoleID already exists. Please choose a different RoleID.", "Duplicate RoleID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Check for valid values in cmbStatus and cmbGender
            If status <> "Faculty" AndAlso status <> "Student" Then
                MessageBox.Show("Invalid status. Please select either Faculty or Student.")
                Exit Sub
            End If

            If gender <> "Male" AndAlso gender <> "Female" AndAlso gender <> "Other" Then
                MessageBox.Show("Invalid gender. Please select either Male or Female.")
                Exit Sub
            End If

            Using con As New MySqlConnection(connectionStr)
                con.Open()
                Dim query As String = "INSERT INTO accounts (status, roleID, fullname, depart, gender, password, user_type) VALUES (@status, @roleID, @fullname, @depart, @gender, @password, @user_type)"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@roleID", roleID)
                    cmd.Parameters.AddWithValue("@fullname", fullName)
                    cmd.Parameters.AddWithValue("@depart", depart)
                    cmd.Parameters.AddWithValue("@gender", gender)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@user_type", user_type)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Successfully Added!")
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function IsRoleIDExists(roleID As String) As Boolean
        Using con As New MySqlConnection(connectionStr)
            con.Open()
            Dim query As String = "SELECT COUNT(*) FROM accounts WHERE roleID = @roleID"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@roleID", roleID)
                Return CInt(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function
End Class
