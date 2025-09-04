Imports MySql.Data.MySqlClient

Public Class ReturnedItem
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"

    Private Sub RefreshDataGridView(searchText As String)
        Try
            con.Open()
            Dim query As String = "SELECT Category, ItemName, Description, Quantity, Remarks, DateTime, Status FROM returned WHERE ReturnedID LIKE @SearchText OR UserID LIKE @SearchText OR ItemID LIKE @SearchText OR Category LIKE @SearchText OR ItemName LIKE @SearchText OR Description LIKE @SearchText OR Quantity LIKE @SearchText OR Remarks LIKE @SearchText OR Status LIKE @SearchText"
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
    Private Sub ReturnedItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = connectionStr
        RefreshDataGridView(txtSearch.Text)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RefreshDataGridView(txtSearch.Text)
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If dgvInventory.SelectedRows.Count > 0 Then
            ' Get the selected data from the DataGridView
            Dim category As String = dgvInventory.SelectedRows(0).Cells("category").Value.ToString()
            Dim itemName As String = dgvInventory.SelectedRows(0).Cells("itemName").Value.ToString()
            Dim description As String = dgvInventory.SelectedRows(0).Cells("description").Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("quantity").Value)
            Dim remarks As String = dgvInventory.SelectedRows(0).Cells("remarks").Value.ToString()
            Dim dateTime As String = dgvInventory.SelectedRows(0).Cells("dateTime").Value.ToString()

            Dim confirmation As New Confirmation_ReturnItem_()
            confirmation.PopulateFields(category, itemName, description, quantity, remarks, dateTime)
            confirmation.ShowDialog()

            RefreshDataGridView(txtSearch.Text)
        Else
            MessageBox.Show("Please select a row to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDataGridView(txtSearch.Text)
    End Sub
End Class