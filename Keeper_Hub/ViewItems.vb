Imports MySql.Data.MySqlClient

Public Class ViewItems
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"

    Private Sub RefreshDataGridView(searchText As String)
        Try
            con.Open()
            Dim query As String = "SELECT * FROM inventory WHERE Remarks = 'Functional' AND Quantity > 0 AND (ItemID LIKE @SearchText OR Category LIKE @SearchText OR ItemName LIKE @SearchText OR Description LIKE @SearchText OR Quantity LIKE @SearchText OR Remarks LIKE @SearchText)"
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")

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

    Private Sub ViewItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = connectionStr
        RefreshDataGridView(txtSearch.Text)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RefreshDataGridView(txtSearch.Text)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        LoginDashboard.Show()
    End Sub
End Class