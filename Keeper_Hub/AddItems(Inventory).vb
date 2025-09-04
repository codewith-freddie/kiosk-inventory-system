Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class AddItems
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim category As String = txtCategory.Text
            Dim itemName As String = txtItemName.Text
            Dim description As String = txtDescription.Text
            Dim quantity As String = txtQuantity.Text
            Dim remarks As String = txtRemarks.Text

            If String.IsNullOrEmpty(category) OrElse String.IsNullOrEmpty(itemName) OrElse String.IsNullOrEmpty(description) OrElse String.IsNullOrEmpty(quantity) OrElse String.IsNullOrEmpty(remarks) Then
                MessageBox.Show("Please fill in all the required fields.")
                Exit Sub
            End If

            ' Check for valid values

            Using con As New MySqlConnection(connectionStr)
                con.Open()
                Dim query As String = "INSERT INTO inventory (Category, ItemName, Description, Quantity, Remarks) VALUES (@category, @itemName, @description, @quantity, @remarks)"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@category", category)
                    cmd.Parameters.AddWithValue("@itemName", itemName)
                    cmd.Parameters.AddWithValue("@description", description)
                    cmd.Parameters.AddWithValue("@quantity", quantity)
                    cmd.Parameters.AddWithValue("@remarks", remarks)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Successfully Added!")
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ClearFields()
        txtCategory.Text = ""
        txtItemName.Text = ""
        txtDescription.Text = ""
        txtQuantity.Text = ""
        txtRemarks.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class