Imports MySql.Data.MySqlClient

Public Class InventorySubform
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"

    Private Sub RefreshDataGridView(searchText As String)
        Try
            con.Open()
            Dim query As String = "SELECT Category, ItemName, Description, Quantity, Remarks FROM inventory WHERE ItemID LIKE @SearchText OR Category LIKE @SearchText OR ItemName LIKE @SearchText OR Description LIKE @SearchText OR Quantity LIKE @SearchText OR Remarks LIKE @SearchText"
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

    Private Sub InventorySubform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = connectionStr
        RefreshDataGridView(txtSearch.Text)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a row is selected
        If dgvInventory.SelectedRows.Count > 0 Then
            ' Confirm the deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Get the selected itemID from the DataGridView
                Dim selecteditemID As Integer = Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("itemID").Value)

                ' Call the method to delete the selected item
                DeleteItem(selecteditemID)

                ' Refresh the DataGridView
                RefreshDataGridView(txtSearch.Text)
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DeleteItem(itemID As Integer)
        Try
            con.Open()
            Dim query As String = "DELETE FROM inventory WHERE itemID = @itemID"
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@itemID", itemID)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ai As New AddItems()
        ai.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDataGridView(txtSearch.Text)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Check if a row is selected
        If dgvInventory.SelectedRows.Count > 0 Then
            ' Get the selected data from the DataGridView
            Dim category As String = dgvInventory.SelectedRows(0).Cells("category").Value.ToString()
            Dim itemName As String = dgvInventory.SelectedRows(0).Cells("itemName").Value.ToString()
            Dim description As String = dgvInventory.SelectedRows(0).Cells("description").Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("quantity").Value)
            Dim remarks As String = dgvInventory.SelectedRows(0).Cells("remarks").Value.ToString()

            ' Open the EditItems form and pass the data
            Dim editItemsForm As New EditItems()
            editItemsForm.PopulateFields(category, itemName, description, quantity, remarks)
            editItemsForm.ShowDialog()

            ' Optional: Refresh the DataGridView after editing
            RefreshDataGridView(txtSearch.Text)
        Else
            MessageBox.Show("Please select a row to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RefreshDataGridView(txtSearch.Text)
    End Sub
End Class
