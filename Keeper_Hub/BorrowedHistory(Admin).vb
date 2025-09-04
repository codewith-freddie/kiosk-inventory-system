Imports MySql.Data.MySqlClient

Public Class BorrowedHistory
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"

    Private Sub RefreshDataGridView()
        Try
            con.Open()
            Dim query As String = "SELECT Category, ItemName, Description, Quantity, Remarks, DateTime FROM borrowed"
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                Using da As New MySqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dgvInventory.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub InventorySubform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = connectionStr
        RefreshDataGridView()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        RefreshDataGridView()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            con.Open()
            Dim searchText As String = txtSearch.Text.Trim()

            ' Modify the query to include a WHERE clause for filtering
            Dim query As String = "SELECT * FROM borrowed WHERE BorrowedID LIKE @SearchText OR UserID LIKE @SearchText OR ItemID LIKE @SearchText OR Category LIKE @SearchText OR ItemName LIKE @SearchText OR Description LIKE @SearchText OR Quantity LIKE @SearchText OR Remarks LIKE @SearchText OR dateTIME = @SearchDate"

            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                ' Use parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")

                ' Check if searchText is a valid date
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
                        dgvInventory.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDataGridView()
    End Sub
End Class
