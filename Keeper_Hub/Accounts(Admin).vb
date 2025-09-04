Imports MySql.Data.MySqlClient

Public Class Accounts
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim au As New AddUser()
        au.Show()
    End Sub

    Private Sub UsersSubform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = connectionStr
        RefreshDataGridView(txtSearch.Text)
    End Sub

    Private Sub RefreshDataGridView(searchText As String)
        Try
            con.Open()
            Dim query As String = "SELECT Status, Fullname, Gender, Depart, Date, Password, User_Type FROM accounts WHERE (status LIKE @SearchText OR fullname LIKE @SearchText OR depart LIKE @SearchText OR gender LIKE @SearchText OR date LIKE @SearchText)"
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")

                Dim searchDate As DateTime
                If DateTime.TryParse(searchText, searchDate) Then
                    ' If valid date, use it in the query
                    cmd.Parameters.AddWithValue("@SearchDate", searchDate)
                Else
                    ' If not a valid date, set the parameter to a default value
                    cmd.Parameters.AddWithValue("@SearchDate", DBNull.Value)
                End If

                Using da As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dgvAccounts.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a row is selected
        If dgvAccounts.SelectedRows.Count > 0 Then
            ' Get the selected Fullname from the DataGridView
            Dim selectedFullname As String = dgvAccounts.SelectedRows(0).Cells("Fullname").Value.ToString()

            ' Display a confirmation message box
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Check the user's response
            If result = DialogResult.Yes Then
                ' Call the method to delete the selected user
                DeleteUser(selectedFullname)

                ' Refresh the DataGridView
                RefreshDataGridView(txtSearch.Text)
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub DeleteUser(Fullname As String)
        Try
            con.Open()
            Dim query As String = "DELETE FROM accounts WHERE Fullname = @Fullname"
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Fullname", Fullname)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDataGridView(txtSearch.Text)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RefreshDataGridView(txtSearch.Text)
    End Sub
End Class
