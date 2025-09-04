Imports System.Numerics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class BorrowedHistoryUser
    Public Shared bh
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"
    Dim mark As String

    Private Sub RefreshDataGridView(searchText As String)
        Try
            con.Open()
            ' Modify the query to load data from the "borrowed" table based on UserID
            Dim query As String = "SELECT Category, ItemName, Description, Quantity, Remarks, dateTime FROM borrowed WHERE UserID=@UserID AND Quantity > 0 AND (Category LIKE @SearchText OR ItemName LIKE @SearchText OR Description LIKE @SearchText OR Quantity LIKE @SearchText OR Remarks LIKE @SearchText OR dateTime LIKE @SearchText)"
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                ' Pass the UserID parameter
                cmd.Parameters.AddWithValue("@UserID", bh)
                ' Pass the SearchText parameter
                cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")

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

    Private Sub history()
        Try
            If dgvInventory.SelectedRows.Count > 0 Then
                ' Get the selected data from the DataGridView

                Dim quantity As Integer = Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("quantity").Value)

                If quantity = 0 Then
                    mark = "zero"
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub BorrowedHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbUserID.Text = bh
        con.ConnectionString = connectionStr
        RefreshDataGridView(txtSearch.Text)
        loadReturnItems()
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim bi As New BorrowItem()
        BorrowItem.bi = lbUserID.Text
        bi.Show()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Call the RefreshDataGridView method with the updated search text
        RefreshDataGridView(txtSearch.Text)
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' Check if a row is selected
        If dgvInventory.SelectedRows.Count > 0 Then
            ' Get the selected data from the DataGridView
            Dim userID As Integer = bh
            Dim category As String = dgvInventory.SelectedRows(0).Cells("category").Value.ToString()
            Dim itemName As String = dgvInventory.SelectedRows(0).Cells("itemName").Value.ToString()
            Dim description As String = dgvInventory.SelectedRows(0).Cells("description").Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("quantity").Value)
            Dim remarks As String = dgvInventory.SelectedRows(0).Cells("remarks").Value.ToString()
            Dim dateTime As String = dgvInventory.SelectedRows(0).Cells("dateTime").Value.ToString()

            Dim rif As New ReturnedItems()
            ReturnedItems.rif = lbUserID.Text
            rif.PopulateFields(userID, category, itemName, description, quantity, remarks, dateTime)
            rif.ShowDialog()

            RefreshDataGridView(txtSearch.Text)
            loadReturnItems()
        Else
            MessageBox.Show("Please select a row to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub loadReturnItems()
        Try
            con.Open()
            ' Modify the query to load data from the "borrowed" table based on UserID
            Dim query As String = "SELECT Category, ItemName, Description, Quantity, Remarks, DateTime, Status FROM returned WHERE UserID=@UserID"
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                ' Pass the UserID parameter
                cmd.Parameters.AddWithValue("@UserID", bh)

                Using da As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dgvReturnItems.DataSource = dt
                    End Using
                End Using
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
End Class
