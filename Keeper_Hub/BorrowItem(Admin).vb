Imports MySql.Data.MySqlClient

Public Class BorrowItemAdmin
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"

    Private Sub BorrowItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = connectionStr
        LoadFunctionalCategories()
    End Sub

    Private Sub ClearFields()
        txtUserID.Text = ""
        txtItemID.Text = ""
        cmbCategory.Text = ""
        cmbItemName.Text = ""
        txtDescription.Text = ""
        txtQuantity.Text = ""
        txtRemarks.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub LoadFunctionalCategories()
        Try
            con.Open()
            Dim query As String = "SELECT DISTINCT category FROM inventory WHERE remarks = 'Functional'"
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    cmbCategory.Items.Clear()
                    While reader.Read()
                        cmbCategory.Items.Add(reader("category").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadFunctionalItemNames(category As String)
        Try
            con.Open()
            Dim query As String = "SELECT itemName FROM inventory WHERE category = @category AND remarks = 'Functional' and Quantity > 0"
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@category", category)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    cmbItemName.Items.Clear()
                    While reader.Read()
                        cmbItemName.Items.Add(reader("itemName").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadItemDetails(itemName As String)
        Try
            con.Open()
            Dim query As String = "SELECT itemID, description, quantity, remarks FROM inventory WHERE itemName = @itemName AND remarks = 'Functional'"
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@itemName", itemName)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtItemID.Text = reader("itemID").ToString()
                        txtDescription.Text = reader("description").ToString()
                        txtQuantity.Text = reader("quantity").ToString()
                        txtRemarks.Text = reader("remarks").ToString()
                    Else
                        ClearFields()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If cmbCategory.SelectedIndex <> -1 Then
            Dim selectedCategory As String = cmbCategory.SelectedItem.ToString()
            LoadFunctionalItemNames(selectedCategory)
            ClearFields()
        End If
    End Sub

    Private Sub cmbItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemName.SelectedIndexChanged
        If cmbItemName.SelectedIndex <> -1 Then
            Dim selectedItemName As String = cmbItemName.SelectedItem.ToString()
            LoadItemDetails(selectedItemName)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim userID As String = txtUserID.Text
            Dim itemID As String = txtItemID.Text
            Dim category As String = cmbCategory.Text
            Dim itemName As String = cmbItemName.Text
            Dim description As String = txtDescription.Text
            Dim quantity As Integer

            ' Check if the quantity is a valid integer
            If Not Integer.TryParse(txtQuantity.Text, quantity) Then
                MessageBox.Show("Quantity must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim remarks As String = "Functional"

            If String.IsNullOrEmpty(userID) OrElse String.IsNullOrEmpty(category) OrElse String.IsNullOrEmpty(itemName) OrElse String.IsNullOrEmpty(description) Then
                MessageBox.Show("Please fill in all the required fields.")
                Exit Sub
            End If

            Using con As New MySqlConnection(connectionStr)
                con.Open()

                ' Start a transaction to ensure consistency in database updates
                Using transaction As MySqlTransaction = con.BeginTransaction()
                    Try
                        ' Update the borrowed table
                        Dim borrowQuery As String = "INSERT INTO borrowed (UserID, ItemID, Category, ItemName, Description, Quantity, Remarks) VALUES (@userID, @itemID, @category, @itemName, @description, @quantity, @remarks)"
                        Using cmdBorrow As New MySqlCommand(borrowQuery, con, transaction)
                            cmdBorrow.Parameters.AddWithValue("@userID", userID)
                            cmdBorrow.Parameters.AddWithValue("@itemID", itemID)
                            cmdBorrow.Parameters.AddWithValue("@category", category)
                            cmdBorrow.Parameters.AddWithValue("@itemName", itemName)
                            cmdBorrow.Parameters.AddWithValue("@description", description)
                            cmdBorrow.Parameters.AddWithValue("@quantity", quantity)
                            cmdBorrow.Parameters.AddWithValue("@remarks", remarks)
                            cmdBorrow.ExecuteNonQuery()
                        End Using

                        ' Update the inventory table
                        Dim updateQuantityQuery As String = "UPDATE inventory SET quantity = quantity - @quantity WHERE itemID = @itemID"
                        Using cmdUpdateQuantity As New MySqlCommand(updateQuantityQuery, con, transaction)
                            cmdUpdateQuantity.Parameters.AddWithValue("@quantity", quantity)
                            cmdUpdateQuantity.Parameters.AddWithValue("@itemID", itemID)
                            cmdUpdateQuantity.ExecuteNonQuery()
                        End Using

                        ' Commit the transaction if everything is successful
                        transaction.Commit()

                        MessageBox.Show("Successfully Added!")
                        ClearFields()

                    Catch ex As Exception
                        ' Rollback the transaction if an error occurs
                        transaction.Rollback()
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
