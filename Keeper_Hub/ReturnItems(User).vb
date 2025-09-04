Imports MySql.Data.MySqlClient

Public Class ReturnedItems
    Public Shared rif
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"

    Public Sub PopulateFields(userID As Integer, category As String, itemName As String, description As String, quantity As Integer, remarks As String, dateTime As String)
        txtUserID.Text = userID
        txtCategory.Text = category
        txtItemName.Text = itemName
        txtDescription.Text = description
        txtQuantity.Text = quantity.ToString()
        txtRemarks.Text = remarks
        txtDateTime.Text = dateTime
    End Sub
    Private Sub ReturnedItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtBorrowedID.Text = ""
        txtUserID.Text = ""
        txtItemID.Text = ""
        txtItemName.Text = ""
        txtCategory.Text = ""
        txtDescription.Text = ""
        txtQuantity.Text = ""
        txtRemarks.Text = ""
        txtDateTime.Text = ""
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim userID As String = rif
            Dim category As String = txtCategory.Text
            Dim itemName As String = txtItemName.Text
            Dim description As String = txtDescription.Text
            Dim quantity As Integer = txtQuantity.Text
            Dim remarks As String = txtRemarks.Text
            Dim status As String = "Pending"

            ' Check if the quantity is a valid integer
            If Not Integer.TryParse(txtQuantity.Text, quantity) Then
                MessageBox.Show("Quantity must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If String.IsNullOrEmpty(quantity) Then
                MessageBox.Show("Please fill in the quantity.")
                Exit Sub
            End If

            Using con As New MySqlConnection(connectionStr)
                con.Open()

                ' Start a transaction to ensure consistency in database updates
                Using transaction As MySqlTransaction = con.BeginTransaction()
                    Try
                        ' Update the borrowed table
                        Dim borrowQuery As String = "INSERT INTO returned (UserID, Category, ItemName, Description, Quantity, Remarks, Status) VALUES (@userID, @category, @itemName, @description, @quantity, @remarks, @status)"
                        Using cmdBorrow As New MySqlCommand(borrowQuery, con, transaction)
                            cmdBorrow.Parameters.AddWithValue("@userID", userID)
                            cmdBorrow.Parameters.AddWithValue("@category", category)
                            cmdBorrow.Parameters.AddWithValue("@itemName", itemName)
                            cmdBorrow.Parameters.AddWithValue("@description", description)
                            cmdBorrow.Parameters.AddWithValue("@quantity", quantity)
                            cmdBorrow.Parameters.AddWithValue("@remarks", remarks)
                            cmdBorrow.Parameters.AddWithValue("@status", status)
                            cmdBorrow.ExecuteNonQuery()
                        End Using

                        ' Commit the transaction if everything is successful
                        transaction.Commit()

                        MessageBox.Show("Successfully Added!")
                        ClearFields()
                        Me.Close()

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