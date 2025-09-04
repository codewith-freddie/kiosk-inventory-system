Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Transactions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Confirmation_ReturnItem_
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"
    Public Sub PopulateFields(category As String, itemName As String, description As String, quantity As Integer, remarks As String, dateTime As String)
        txtCategory.Text = category
        txtItemName.Text = itemName
        txtDescription.Text = description
        txtQuantity.Text = quantity.ToString()
        txtRemarks.Text = remarks
        txtDateTime.Text = dateTime
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub loadBorrowedQuantity()
        Try
            Dim category As String = txtCategory.Text
            Dim itemName As String = txtItemName.Text
            Dim description As String = txtDescription.Text

            Using con As New MySqlConnection(connectionStr)
                con.Open()

                Dim query As New MySqlCommand("SELECT Quantity FROM borrowed WHERE Category = @category AND ItemName = @itemName AND Description = @description", con)
                query.Parameters.AddWithValue("@category", category)
                query.Parameters.AddWithValue("@itemName", itemName)
                query.Parameters.AddWithValue("@description", description)

                Dim reader As MySqlDataReader = query.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        lbBorrowedQty.Text = reader("Quantity").ToString()
                    End While
                Else
                    ' Handle the case where no matching record is found
                    lbBorrowedQty.Text = "Not Found"
                End If
            End Using
        Catch ex As Exception
            ' Handle the exception, e.g., display an error message
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            Dim returnedID As String = txtReturnedID.Text
            Dim borrowedID As String = txtBorrowedID.Text
            Dim userID As String = txtUserID.Text
            Dim itemID As String = txtItemID.Text
            Dim category As String = txtCategory.Text
            Dim itemName As String = txtItemName.Text
            Dim description As String = txtDescription.Text
            Dim quantity As Integer = txtQuantity.Text
            Dim remarks As String = txtRemarks.Text
            Dim dateTime As String = txtDateTime.Text
            Dim status As String = "Confirmed"

            Using con As New MySqlConnection(connectionStr)
                con.Open()

                ' Start a transaction to ensure consistency in database updates
                Using transaction As MySqlTransaction = con.BeginTransaction()
                    Try

                        ' Update the inventory table
                        Dim updateInventoryQuantityQuery As String = "UPDATE inventory SET quantity = quantity + @quantity WHERE Category = @category AND itemName = @ItemName AND Description = @Description"
                        Using cmdUpdateQuantity As New MySqlCommand(updateInventoryQuantityQuery, con, transaction)
                            cmdUpdateQuantity.Parameters.AddWithValue("@quantity", quantity)
                            cmdUpdateQuantity.Parameters.AddWithValue("@category", category)
                            cmdUpdateQuantity.Parameters.AddWithValue("@ItemName", itemName)
                            cmdUpdateQuantity.Parameters.AddWithValue("@Description", description)
                            cmdUpdateQuantity.ExecuteNonQuery()
                        End Using

                        ' Update the borrowed table
                        Dim updateBorrowedQuantityQuery As String = "UPDATE borrowed SET quantity = quantity - @quantity WHERE category = @category AND itemName = @ItemName AND description = @Description"
                        Using cmdUpdateQuantity As New MySqlCommand(updateBorrowedQuantityQuery, con, transaction)
                            cmdUpdateQuantity.Parameters.AddWithValue("@quantity", quantity)
                            cmdUpdateQuantity.Parameters.AddWithValue("@category", category)
                            cmdUpdateQuantity.Parameters.AddWithValue("@ItemName", itemName)
                            cmdUpdateQuantity.Parameters.AddWithValue("@Description", description)
                            cmdUpdateQuantity.ExecuteNonQuery()
                        End Using



                        ' Update the returned table
                        Dim updateReturnedQuantityQuery As String = "UPDATE returned SET Status = @status WHERE Category = @category AND ItemName = @itemName AND Description = @description AND Quantity = @quantity AND Remarks = @remarks"
                        Using cmdUpdateQuantity As New MySqlCommand(updateReturnedQuantityQuery, con, transaction)
                            cmdUpdateQuantity.Parameters.AddWithValue("@status", status)
                            cmdUpdateQuantity.Parameters.AddWithValue("@category", category)
                            cmdUpdateQuantity.Parameters.AddWithValue("@itemName", itemName)
                            cmdUpdateQuantity.Parameters.AddWithValue("@description", description)
                            cmdUpdateQuantity.Parameters.AddWithValue("@quantity", quantity)
                            cmdUpdateQuantity.Parameters.AddWithValue("@remarks", remarks)
                            cmdUpdateQuantity.ExecuteNonQuery()
                        End Using

                        ' Commit the transaction if everything is successful
                        transaction.Commit()

                        MessageBox.Show("Successfully Added!")
                        btnConfirm.Enabled = False
                        loadBorrowedQuantity()


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

    Private Sub HistoryInsert()
        Try
            Dim category As String = txtCategory.Text
            Dim itemName As String = txtItemName.Text
            Dim description As String = txtDescription.Text
            Dim remarks As String = txtRemarks.Text
            Dim dateTime As String = txtDateTime.Text
            Dim status As String = "Completed"

            Using con As New MySqlConnection(connectionStr)
                con.Open()

                ' Start a transaction to ensure consistency in database updates
                Using transaction As MySqlTransaction = con.BeginTransaction()
                    Try
                        If lbBorrowedQty.Text = 0 Then
                            Dim historyQuery As String = "INSERT INTO history (ReturnedRemarks, ReturnedDate) VALUES (@remarks, @date) WHERE Category = @category AND ItemName = @itemName AND Description = @description"
                            Using cmdHistory As New MySqlCommand(historyQuery, con, transaction)
                                cmdHistory.Parameters.AddWithValue("@category", category)
                                cmdHistory.Parameters.AddWithValue("@itemName", itemName)
                                cmdHistory.Parameters.AddWithValue("@description", description)
                                cmdHistory.Parameters.AddWithValue("@remarks", remarks)
                                cmdHistory.Parameters.AddWithValue("@date", dateTime)
                                cmdHistory.ExecuteNonQuery()
                            End Using

                            Dim updateHistoryQuantityQuery As String = "UPDATE history SET Status = @status WHERE Category = @category AND ItemName = @itemName AND Description = @description"
                            Using cmdUpdateStatus As New MySqlCommand(updateHistoryQuantityQuery, con, transaction)
                                cmdUpdateStatus.Parameters.AddWithValue("@status", status)
                                cmdUpdateStatus.Parameters.AddWithValue("@category", category)
                                cmdUpdateStatus.Parameters.AddWithValue("@itemName", itemName)
                                cmdUpdateStatus.Parameters.AddWithValue("@description", description)

                                MessageBox.Show("Successfully Added to History!")
                            End Using
                        Else
                            MessageBox.Show("Failed to Insert in History")
                        End If

                        ' Commit the transaction if everything is successful
                        transaction.Commit()

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

    Private Sub Confirmation_ReturnItem__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBorrowedQuantity()
    End Sub
End Class