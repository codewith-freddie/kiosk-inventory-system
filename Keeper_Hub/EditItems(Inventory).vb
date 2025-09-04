Imports MySql.Data.MySqlClient

Public Class EditItems
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"
    Public Sub PopulateFields(category As String, itemName As String, description As String, quantity As Integer, remarks As String)
        txtCategory.Text = category
        txtItemName.Text = itemName
        txtDescription.Text = description
        txtQuantity.Text = quantity.ToString()
        txtRemarks.Text = remarks
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim itemID As String = txtItemID.Text
            Dim category As String = txtCategory.Text
            Dim itemName As String = txtItemName.Text
            Dim description As String = txtDescription.Text
            Dim quantity As String = txtQuantity.Text
            Dim remarks As String = txtRemarks.Text

            If String.IsNullOrEmpty(itemID) OrElse String.IsNullOrEmpty(category) OrElse String.IsNullOrEmpty(itemName) OrElse String.IsNullOrEmpty(description) OrElse String.IsNullOrEmpty(quantity) OrElse String.IsNullOrEmpty(remarks) Then
                MessageBox.Show("Please fill in all the required fields.")
                Exit Sub
            End If

            Using con As New MySqlConnection(connectionStr)
                con.Open()


                ' Use the UPDATE statement with a WHERE clause to specify which record to update
                Dim query As String = "UPDATE inventory SET ItemID = @itemID, Category = @category, ItemName = @itemName, Description = @description, Quantity = @quantity, Remarks = @remarks WHERE itemID = @itemID"

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@category", category)
                    cmd.Parameters.AddWithValue("@itemName", itemName)
                    cmd.Parameters.AddWithValue("@description", description)
                    cmd.Parameters.AddWithValue("@quantity", quantity)
                    cmd.Parameters.AddWithValue("@remarks", remarks)
                    cmd.Parameters.AddWithValue("@itemID", itemID) ' Replace YourPrimaryKeyValue with the actual primary key value

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Successfully Updated!")
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ItemID()
        Try
            Dim category As String = txtCategory.Text
            Dim itemName As String = txtItemName.Text
            Dim description As String = txtDescription.Text

            Using con As New MySqlConnection(connectionStr)
                con.Open()

                Dim load As New MySqlCommand("SELECT ItemID FROM inventory WHERE Category = @category AND ItemName = @itemName AND Description = @description", con)
                load.Parameters.AddWithValue("@category", category)
                load.Parameters.AddWithValue("@itemName", itemName)
                load.Parameters.AddWithValue("@description", description)

                Dim reader As MySqlDataReader = load.ExecuteReader()

                If reader.HasRows Then
                    ' Assuming you only need the first result, no need for a loop
                    reader.Read()
                    txtItemID.Text = reader("ItemID").ToString()
                Else
                    ' Handle the case where no matching record is found
                    txtItemID.Text = "Not Found"
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ClearFields()
        txtItemID.Text = ""
        txtCategory.Text = ""
        txtItemName.Text = ""
        txtDescription.Text = ""
        txtQuantity.Text = ""
        txtRemarks.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub EditItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ItemID()
    End Sub
End Class