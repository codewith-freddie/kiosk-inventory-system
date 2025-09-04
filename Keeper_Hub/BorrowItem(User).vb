Imports MySql.Data.MySqlClient

Public Class BorrowItem
    Public Shared bi
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"

    Private Sub BorrowItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDetails()
        LoadUserID()
        con.ConnectionString = connectionStr
        LoadFunctionalCategories()
    End Sub

    Private Sub LoadUserID()
        txtUserID.Text = bi
    End Sub

    Private Sub ClearFields()
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
            Dim query As String = "SELECT itemName FROM inventory WHERE category = @category AND remarks = 'Functional' AND Quantity > 0"
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
            Dim category As String = cmbCategory.Text
            con.Open()
            Dim query As String = "SELECT itemID, description, quantity, remarks FROM inventory WHERE itemName = @itemName AND Category = @category AND remarks = 'Functional'"
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@itemName", itemName)
                cmd.Parameters.AddWithValue("@category", category)
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
            LoadUserID()
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

    Private Sub loadDetails()
        Try
            Dim userID As Integer = bi

            Using con As New MySqlConnection(connectionStr)
                con.Open()

                Dim load As New MySqlCommand("SELECT Status, Fullname, Gender, Depart FROM accounts WHERE UserID = @userID", con)
                load.Parameters.AddWithValue("@userID", userID)

                Dim reader As MySqlDataReader = load.ExecuteReader()

                If reader.HasRows Then
                    ' Assuming you only need the first result, no need for a loop
                    reader.Read()
                    lbStatus.Text = reader("Status").ToString()
                    lbFullName.Text = reader("FullName").ToString()
                    lbGender.Text = reader("Gender").ToString()
                    lbDepart.Text = reader("Depart").ToString()
                Else
                    ' Handle the case where no matching record is found
                    lbFullName.Text = "Not Found"
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim userID As String = bi
            Dim userStatus As String = lbStatus.Text
            Dim fullname As String = lbFullName.Text
            Dim gender As String = lbGender.Text
            Dim depart As String = lbDepart.Text
            Dim itemID As String = txtItemID.Text
            Dim category As String = cmbCategory.Text
            Dim itemName As String = cmbItemName.Text
            Dim description As String = txtDescription.Text
            Dim quantity As Integer
            Dim status As String = "Incomplete"

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

                        Dim historyQuery As String = "INSERT INTO history (UserID, User_Status, Name, Gender, Depart, Category, ItemName, Description, Quantity, Remarks, Status) VALUES (@userID, @user_status, @name, @gender, @depart, @category, @itemName, @description, @quantity, @remarks, @status)"
                        Using cmdHistory As New MySqlCommand(historyQuery, con, transaction)
                            cmdHistory.Parameters.AddWithValue("@userID", userID)
                            cmdHistory.Parameters.AddWithValue("@user_status", userStatus)
                            cmdHistory.Parameters.AddWithValue("@name", fullname)
                            cmdHistory.Parameters.AddWithValue("@gender", gender)
                            cmdHistory.Parameters.AddWithValue("@depart", depart)
                            cmdHistory.Parameters.AddWithValue("@category", category)
                            cmdHistory.Parameters.AddWithValue("@itemName", itemName)
                            cmdHistory.Parameters.AddWithValue("@description", description)
                            cmdHistory.Parameters.AddWithValue("@quantity", quantity)
                            cmdHistory.Parameters.AddWithValue("@remarks", remarks)
                            cmdHistory.Parameters.AddWithValue("@status", status)
                            cmdHistory.ExecuteNonQuery()
                        End Using

                        ' Commit the transaction if everything is successful
                        transaction.Commit()

                        MessageBox.Show("Successfully Added!")
                        txtUserID.Text = ""
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
